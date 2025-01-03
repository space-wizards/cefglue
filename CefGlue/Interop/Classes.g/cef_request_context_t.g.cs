﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_request_context_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_preference_manager_t*, cef_string_t*, int> _has_preference;
        internal delegate* unmanaged<cef_preference_manager_t*, cef_string_t*, cef_value_t*> _get_preference;
        internal delegate* unmanaged<cef_preference_manager_t*, int, cef_dictionary_value_t*> _get_all_preferences;
        internal delegate* unmanaged<cef_preference_manager_t*, cef_string_t*, int> _can_set_preference;
        internal delegate* unmanaged<cef_preference_manager_t*, cef_string_t*, cef_value_t*, cef_string_t*, int> _set_preference;
        internal delegate* unmanaged<cef_request_context_t*, cef_request_context_t*, int> _is_same;
        internal delegate* unmanaged<cef_request_context_t*, cef_request_context_t*, int> _is_sharing_with;
        internal delegate* unmanaged<cef_request_context_t*, int> _is_global;
        internal delegate* unmanaged<cef_request_context_t*, cef_request_context_handler_t*> _get_handler;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_userfree*> _get_cache_path;
        internal delegate* unmanaged<cef_request_context_t*, cef_completion_callback_t*, cef_cookie_manager_t*> _get_cookie_manager;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_string_t*, cef_scheme_handler_factory_t*, int> _register_scheme_handler_factory;
        internal delegate* unmanaged<cef_request_context_t*, int> _clear_scheme_handler_factories;
        internal delegate* unmanaged<cef_request_context_t*, cef_completion_callback_t*, void> _clear_certificate_exceptions;
        internal delegate* unmanaged<cef_request_context_t*, cef_completion_callback_t*, void> _clear_http_auth_credentials;
        internal delegate* unmanaged<cef_request_context_t*, cef_completion_callback_t*, void> _close_all_connections;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_resolve_callback_t*, void> _resolve_host;
        internal delegate* unmanaged<cef_request_context_t*, cef_completion_callback_t*, cef_media_router_t*> _get_media_router;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_string_t*, CefContentSettingTypes, cef_value_t*> _get_website_setting;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_string_t*, CefContentSettingTypes, cef_value_t*, void> _set_website_setting;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_string_t*, CefContentSettingTypes, CefContentSettingValues> _get_content_setting;
        internal delegate* unmanaged<cef_request_context_t*, cef_string_t*, cef_string_t*, CefContentSettingTypes, CefContentSettingValues, void> _set_content_setting;
        internal delegate* unmanaged<cef_request_context_t*, CefColorVariant, uint, void> _set_chrome_color_scheme;
        internal delegate* unmanaged<cef_request_context_t*, CefColorVariant> _get_chrome_color_scheme_mode;
        internal delegate* unmanaged<cef_request_context_t*, uint> _get_chrome_color_scheme_color;
        internal delegate* unmanaged<cef_request_context_t*, CefColorVariant> _get_chrome_color_scheme_variant;
        
        // GetGlobalContext
        [DllImport(libcef.DllName, EntryPoint = "cef_request_context_get_global_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* get_global_context();
        
        // CreateContext
        [DllImport(libcef.DllName, EntryPoint = "cef_request_context_create_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* create_context(cef_request_context_settings_t* settings, cef_request_context_handler_t* handler);
        
        // CreateContext
        [DllImport(libcef.DllName, EntryPoint = "cef_create_context_shared", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* create_context(cef_request_context_t* other, cef_request_context_handler_t* handler);
        
        // AddRef
        
        public static void add_ref(cef_preference_manager_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_preference_manager_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_preference_manager_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_preference_manager_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasPreference
        
        public static int has_preference(cef_preference_manager_t* self, cef_string_t* name)
        {
            return self->_has_preference(self, name);
        }
        
        // GetPreference
        
        public static cef_value_t* get_preference(cef_preference_manager_t* self, cef_string_t* name)
        {
            return self->_get_preference(self, name);
        }
        
        // GetAllPreferences
        
        public static cef_dictionary_value_t* get_all_preferences(cef_preference_manager_t* self, int include_defaults)
        {
            return self->_get_all_preferences(self, include_defaults);
        }
        
        // CanSetPreference
        
        public static int can_set_preference(cef_preference_manager_t* self, cef_string_t* name)
        {
            return self->_can_set_preference(self, name);
        }
        
        // SetPreference
        
        public static int set_preference(cef_preference_manager_t* self, cef_string_t* name, cef_value_t* value, cef_string_t* error)
        {
            return self->_set_preference(self, name, value, error);
        }
        
        // IsSame
        
        public static int is_same(cef_request_context_t* self, cef_request_context_t* other)
        {
            return self->_is_same(self, other);
        }
        
        // IsSharingWith
        
        public static int is_sharing_with(cef_request_context_t* self, cef_request_context_t* other)
        {
            return self->_is_sharing_with(self, other);
        }
        
        // IsGlobal
        
        public static int is_global(cef_request_context_t* self)
        {
            return self->_is_global(self);
        }
        
        // GetHandler
        
        public static cef_request_context_handler_t* get_handler(cef_request_context_t* self)
        {
            return self->_get_handler(self);
        }
        
        // GetCachePath
        
        public static cef_string_userfree* get_cache_path(cef_request_context_t* self)
        {
            return self->_get_cache_path(self);
        }
        
        // GetCookieManager
        
        public static cef_cookie_manager_t* get_cookie_manager(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            return self->_get_cookie_manager(self, callback);
        }
        
        // RegisterSchemeHandlerFactory
        
        public static int register_scheme_handler_factory(cef_request_context_t* self, cef_string_t* scheme_name, cef_string_t* domain_name, cef_scheme_handler_factory_t* factory)
        {
            return self->_register_scheme_handler_factory(self, scheme_name, domain_name, factory);
        }
        
        // ClearSchemeHandlerFactories
        
        public static int clear_scheme_handler_factories(cef_request_context_t* self)
        {
            return self->_clear_scheme_handler_factories(self);
        }
        
        // ClearCertificateExceptions
        
        public static void clear_certificate_exceptions(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            self->_clear_certificate_exceptions(self, callback);
        }
        
        // ClearHttpAuthCredentials
        
        public static void clear_http_auth_credentials(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            self->_clear_http_auth_credentials(self, callback);
        }
        
        // CloseAllConnections
        
        public static void close_all_connections(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            self->_close_all_connections(self, callback);
        }
        
        // ResolveHost
        
        public static void resolve_host(cef_request_context_t* self, cef_string_t* origin, cef_resolve_callback_t* callback)
        {
            self->_resolve_host(self, origin, callback);
        }
        
        // GetMediaRouter
        
        public static cef_media_router_t* get_media_router(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            return self->_get_media_router(self, callback);
        }
        
        // GetWebsiteSetting
        
        public static cef_value_t* get_website_setting(cef_request_context_t* self, cef_string_t* requesting_url, cef_string_t* top_level_url, CefContentSettingTypes content_type)
        {
            return self->_get_website_setting(self, requesting_url, top_level_url, content_type);
        }
        
        // SetWebsiteSetting
        
        public static void set_website_setting(cef_request_context_t* self, cef_string_t* requesting_url, cef_string_t* top_level_url, CefContentSettingTypes content_type, cef_value_t* value)
        {
            self->_set_website_setting(self, requesting_url, top_level_url, content_type, value);
        }
        
        // GetContentSetting
        
        public static CefContentSettingValues get_content_setting(cef_request_context_t* self, cef_string_t* requesting_url, cef_string_t* top_level_url, CefContentSettingTypes content_type)
        {
            return self->_get_content_setting(self, requesting_url, top_level_url, content_type);
        }
        
        // SetContentSetting
        
        public static void set_content_setting(cef_request_context_t* self, cef_string_t* requesting_url, cef_string_t* top_level_url, CefContentSettingTypes content_type, CefContentSettingValues value)
        {
            self->_set_content_setting(self, requesting_url, top_level_url, content_type, value);
        }
        
        // SetChromeColorScheme
        
        public static void set_chrome_color_scheme(cef_request_context_t* self, CefColorVariant variant, uint user_color)
        {
            self->_set_chrome_color_scheme(self, variant, user_color);
        }
        
        // GetChromeColorSchemeMode
        
        public static CefColorVariant get_chrome_color_scheme_mode(cef_request_context_t* self)
        {
            return self->_get_chrome_color_scheme_mode(self);
        }
        
        // GetChromeColorSchemeColor
        
        public static uint get_chrome_color_scheme_color(cef_request_context_t* self)
        {
            return self->_get_chrome_color_scheme_color(self);
        }
        
        // GetChromeColorSchemeVariant
        
        public static CefColorVariant get_chrome_color_scheme_variant(cef_request_context_t* self)
        {
            return self->_get_chrome_color_scheme_variant(self);
        }
        
    }
}
