//
// This file manually written from cef/include/internal/cef_types_component.h.
// C API name: cef_component_update_error_t.
//
namespace Xilium.CefGlue;

/// <summary>
/// Component update error codes.
/// </summary>
public enum CefComponentUpdateError
{
    /// <summary>
    /// No error.
    /// </summary>
    None = 0,

    /// <summary>
    /// An update is already in progress for this component.
    /// </summary>
    UpdateInProgress = 1,

    /// <summary>
    /// The update was canceled.
    /// </summary>
    UpdateCanceled = 2,

    /// <summary>
    /// The update should be retried later.
    /// </summary>
    RetryLater = 3,

    /// <summary>
    /// A service error occurred.
    /// </summary>
    ServiceError = 4,

    /// <summary>
    /// An error occurred during the update check.
    /// </summary>
    UpdateCheckError = 5,

    /// <summary>
    /// The component was not found.
    /// </summary>
    CrxNotFound = 6,

    /// <summary>
    /// An invalid argument was provided.
    /// </summary>
    InvalidArgument = 7,

    /// <summary>
    /// Bad CRX data callback.
    /// </summary>
    BadCrxDataCallback = 8,
}
