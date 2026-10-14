//
// This file manually written from cef/include/internal/cef_types_component.h.
// C API name: cef_component_state_t.
//
namespace Xilium.CefGlue;

/// <summary>
/// Component states.
/// </summary>
public enum CefComponentState
{
    /// <summary>
    /// The component has not yet been checked for updates.
    /// </summary>
    New = 0,

    /// <summary>
    /// The component is being checked for updates now.
    /// </summary>
    Checking = 1,

    /// <summary>
    /// An update is available and will soon be processed.
    /// </summary>
    CanUpdate = 2,

    /// <summary>
    /// An update is being downloaded.
    /// </summary>
    Downloading = 3,

    /// <summary>
    /// An update is being decompressed.
    /// </summary>
    Decompressing = 4,

    /// <summary>
    /// A patch is being applied.
    /// </summary>
    Patching = 5,

    /// <summary>
    /// An update is being installed.
    /// </summary>
    Updating = 6,

    /// <summary>
    /// An update was successfully applied. The component is now installed.
    /// </summary>
    Updated = 7,

    /// <summary>
    /// The component was already up to date. The component is installed.
    /// </summary>
    UpToDate = 8,

    /// <summary>
    /// The service encountered an error during the update process.
    /// </summary>
    UpdateError = 9,

    /// <summary>
    /// The component is running a server-specified action. The component is installed.
    /// </summary>
    Run = 10,
}
