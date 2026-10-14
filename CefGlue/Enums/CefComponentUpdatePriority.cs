//
// This file manually written from cef/include/internal/cef_types_component.h.
// C API name: cef_component_update_priority_t.
//
namespace Xilium.CefGlue;

/// <summary>
/// Component update priority.
/// </summary>
public enum CefComponentUpdatePriority
{
    /// <summary>
    /// Background priority. Update requests may be queued.
    /// </summary>
    Background = 0,

    /// <summary>
    /// Foreground priority. Update requests are processed immediately.
    /// </summary>
    Foreground = 1,
}
