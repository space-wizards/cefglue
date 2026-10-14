namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// This class provides access to Chromium's component updater service, allowing
    /// clients to discover registered components and trigger on-demand updates. The
    /// methods of this class may only be called on the browser process UI thread.
    /// If the CEF context is not initialized or the component updater service is
    /// not available, methods will return safe defaults (0, nullptr, or empty).
    /// </summary>
    public sealed unsafe partial class CefComponentUpdater
    {
        /// <summary>
        /// Returns the global CefComponentUpdater singleton. Returns null if
        /// called from the incorrect thread.
        /// </summary>
        public static CefComponentUpdater GetComponentUpdater()
        {
            return CefComponentUpdater.FromNativeOrNull(
                cef_component_updater_t.get()
                );
        }

        /// <summary>
        /// Returns the number of registered components, or 0 if the service is not
        /// available.
        /// </summary>
        public int ComponentCount
        {
            get { return checked((int)cef_component_updater_t.get_component_count(_self)); }
        }

        /// <summary>
        /// Returns all registered components.
        /// </summary>
        public CefComponent[] GetComponents()
        {
            var count = ComponentCount;
            if (count == 0) return new CefComponent[0];

            UIntPtr n_componentsCount = (UIntPtr)count;
            var n_components = new cef_component_t*[count];
            fixed (cef_component_t** n_components_ptr = n_components)
            {
                cef_component_updater_t.get_components(_self, &n_componentsCount, n_components_ptr);
                if ((int)n_componentsCount > count) throw new InvalidOperationException();
            }

            count = (int)n_componentsCount;
            var components = new CefComponent[count];
            for (var i = 0; i < count; i++)
            {
                components[i] = CefComponent.FromNative(n_components[i]);
            }

            return components;
        }

        /// <summary>
        /// Returns the component with the specified |component_id|, or null if
        /// not found or the service is not available.
        /// </summary>
        public CefComponent GetComponentById(string componentId)
        {
            fixed (char* componentId_str = componentId)
            {
                var n_componentId = new cef_string_t(componentId_str, componentId != null ? componentId.Length : 0);
                return CefComponent.FromNativeOrNull(
                    cef_component_updater_t.get_component_by_id(_self, &n_componentId)
                    );
            }
        }

        /// <summary>
        /// Triggers an on-demand update for the component with the specified
        /// |component_id|. |priority| specifies whether the update should be
        /// processed in the background or foreground. Use
        /// CEF_COMPONENT_UPDATE_PRIORITY_FOREGROUND for user-initiated updates.
        ///
        /// |callback| will be called asynchronously on the UI thread when the
        /// update operation completes. The callback is always executed, including
        /// when the component is already up-to-date (returns
        /// CEF_COMPONENT_UPDATE_ERROR_NONE), when the requested component doesn't
        /// exist, or when the service is unavailable (returns
        /// CEF_COMPONENT_UPDATE_ERROR_SERVICE_ERROR). The callback may be null
        /// if no notification is needed.
        /// </summary>
        public void Update(string componentId, CefComponentUpdatePriority priority, CefComponentUpdateCallback callback)
        {
            fixed (char* componentId_str = componentId)
            {
                var n_componentId = new cef_string_t(componentId_str, componentId != null ? componentId.Length : 0);
                var n_callback = callback != null ? callback.ToNative() : null;
                cef_component_updater_t.update(_self, &n_componentId, priority, n_callback);
            }
        }
    }
}
