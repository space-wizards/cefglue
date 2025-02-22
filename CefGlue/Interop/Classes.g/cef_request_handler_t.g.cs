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
    internal unsafe struct cef_request_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_request_t*, int, int, int> _on_before_browse;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_string_t*, CefWindowOpenDisposition, int, int> _on_open_urlfrom_tab;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, cef_frame_t*, cef_request_t*, int, int, cef_string_t*, int*, cef_resource_request_handler_t*> _get_resource_request_handler;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, cef_string_t*, int, cef_string_t*, int, cef_string_t*, cef_string_t*, cef_auth_callback_t*, int> _get_auth_credentials;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, CefErrorCode, cef_string_t*, cef_sslinfo_t*, cef_callback_t*, int> _on_certificate_error;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, int, cef_string_t*, int, UIntPtr, cef_x509certificate_t**, cef_select_client_certificate_callback_t*, int> _on_select_client_certificate;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, void> _on_render_view_ready;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, cef_unresponsive_process_callback_t*, int> _on_render_process_unresponsive;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, void> _on_render_process_responsive;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, CefTerminationStatus, int, cef_string_t*, void> _on_render_process_terminated;
        internal delegate* unmanaged<cef_request_handler_t*, cef_browser_t*, void> _on_document_available_in_main_frame;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_request_handler_t* self)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_request_handler_t* self)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_request_handler_t* self)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_request_handler_t* self)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int on_before_browse(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int user_gesture, int is_redirect)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.on_before_browse(self, browser, frame, request, user_gesture, is_redirect);
        }
        
        [UnmanagedCallersOnly]
        public static int on_open_urlfrom_tab(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, CefWindowOpenDisposition target_disposition, int user_gesture)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.on_open_urlfrom_tab(self, browser, frame, target_url, target_disposition, user_gesture);
        }
        
        [UnmanagedCallersOnly]
        public static cef_resource_request_handler_t* get_resource_request_handler(cef_request_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.get_resource_request_handler(self, browser, frame, request, is_navigation, is_download, request_initiator, disable_default_handling);
        }
        
        [UnmanagedCallersOnly]
        public static int get_auth_credentials(cef_request_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.get_auth_credentials(self, browser, origin_url, isProxy, host, port, realm, scheme, callback);
        }
        
        [UnmanagedCallersOnly]
        public static int on_certificate_error(cef_request_handler_t* self, cef_browser_t* browser, CefErrorCode cert_error, cef_string_t* request_url, cef_sslinfo_t* ssl_info, cef_callback_t* callback)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.on_certificate_error(self, browser, cert_error, request_url, ssl_info, callback);
        }
        
        [UnmanagedCallersOnly]
        public static int on_select_client_certificate(cef_request_handler_t* self, cef_browser_t* browser, int isProxy, cef_string_t* host, int port, UIntPtr certificatesCount, cef_x509certificate_t** certificates, cef_select_client_certificate_callback_t* callback)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.on_select_client_certificate(self, browser, isProxy, host, port, certificatesCount, certificates, callback);
        }
        
        [UnmanagedCallersOnly]
        public static void on_render_view_ready(cef_request_handler_t* self, cef_browser_t* browser)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            obj.on_render_view_ready(self, browser);
        }
        
        [UnmanagedCallersOnly]
        public static int on_render_process_unresponsive(cef_request_handler_t* self, cef_browser_t* browser, cef_unresponsive_process_callback_t* callback)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            return obj.on_render_process_unresponsive(self, browser, callback);
        }
        
        [UnmanagedCallersOnly]
        public static void on_render_process_responsive(cef_request_handler_t* self, cef_browser_t* browser)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            obj.on_render_process_responsive(self, browser);
        }
        
        [UnmanagedCallersOnly]
        public static void on_render_process_terminated(cef_request_handler_t* self, cef_browser_t* browser, CefTerminationStatus status, int error_code, cef_string_t* error_string)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            obj.on_render_process_terminated(self, browser, status, error_code, error_string);
        }
        
        [UnmanagedCallersOnly]
        public static void on_document_available_in_main_frame(cef_request_handler_t* self, cef_browser_t* browser)
        {
            var obj = (CefRequestHandler)self->_obj.Target;
            obj.on_document_available_in_main_frame(self, browser);
        }
        
        internal static cef_request_handler_t* Alloc()
        {
            var ptr = (cef_request_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_request_handler_t));
            *ptr = default(cef_request_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_request_handler_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_request_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_request_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_request_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_request_handler_t*, int>)&has_at_least_one_ref;
            ptr->_on_before_browse = &on_before_browse;
            ptr->_on_open_urlfrom_tab = &on_open_urlfrom_tab;
            ptr->_get_resource_request_handler = &get_resource_request_handler;
            ptr->_get_auth_credentials = &get_auth_credentials;
            ptr->_on_certificate_error = &on_certificate_error;
            ptr->_on_select_client_certificate = &on_select_client_certificate;
            ptr->_on_render_view_ready = &on_render_view_ready;
            ptr->_on_render_process_unresponsive = &on_render_process_unresponsive;
            ptr->_on_render_process_responsive = &on_render_process_responsive;
            ptr->_on_render_process_terminated = &on_render_process_terminated;
            ptr->_on_document_available_in_main_frame = &on_document_available_in_main_frame;
            return ptr;
        }
        
        internal static void Free(cef_request_handler_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
