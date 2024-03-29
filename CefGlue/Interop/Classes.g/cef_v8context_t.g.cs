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
    internal unsafe struct cef_v8context_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_v8context_t*, cef_task_runner_t*> _get_task_runner;
        internal delegate* unmanaged<cef_v8context_t*, int> _is_valid;
        internal delegate* unmanaged<cef_v8context_t*, cef_browser_t*> _get_browser;
        internal delegate* unmanaged<cef_v8context_t*, cef_frame_t*> _get_frame;
        internal delegate* unmanaged<cef_v8context_t*, cef_v8value_t*> _get_global;
        internal delegate* unmanaged<cef_v8context_t*, int> _enter;
        internal delegate* unmanaged<cef_v8context_t*, int> _exit;
        internal delegate* unmanaged<cef_v8context_t*, cef_v8context_t*, int> _is_same;
        internal delegate* unmanaged<cef_v8context_t*, cef_string_t*, cef_string_t*, int, cef_v8value_t**, cef_v8exception_t**, int> _eval;
        
        // GetCurrentContext
        [DllImport(libcef.DllName, EntryPoint = "cef_v8context_get_current_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_v8context_t* get_current_context();
        
        // GetEnteredContext
        [DllImport(libcef.DllName, EntryPoint = "cef_v8context_get_entered_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_v8context_t* get_entered_context();
        
        // InContext
        [DllImport(libcef.DllName, EntryPoint = "cef_v8context_in_context", CallingConvention = libcef.CEF_CALL)]
        public static extern int in_context();
        
        // AddRef
        
        public static void add_ref(cef_v8context_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_v8context_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_v8context_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_v8context_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // GetTaskRunner
        
        public static cef_task_runner_t* get_task_runner(cef_v8context_t* self)
        {
            return self->_get_task_runner(self);
        }
        
        // IsValid
        
        public static int is_valid(cef_v8context_t* self)
        {
            return self->_is_valid(self);
        }
        
        // GetBrowser
        
        public static cef_browser_t* get_browser(cef_v8context_t* self)
        {
            return self->_get_browser(self);
        }
        
        // GetFrame
        
        public static cef_frame_t* get_frame(cef_v8context_t* self)
        {
            return self->_get_frame(self);
        }
        
        // GetGlobal
        
        public static cef_v8value_t* get_global(cef_v8context_t* self)
        {
            return self->_get_global(self);
        }
        
        // Enter
        
        public static int enter(cef_v8context_t* self)
        {
            return self->_enter(self);
        }
        
        // Exit
        
        public static int exit(cef_v8context_t* self)
        {
            return self->_exit(self);
        }
        
        // IsSame
        
        public static int is_same(cef_v8context_t* self, cef_v8context_t* that)
        {
            return self->_is_same(self, that);
        }
        
        // Eval
        
        public static int eval(cef_v8context_t* self, cef_string_t* code, cef_string_t* script_url, int start_line, cef_v8value_t** retval, cef_v8exception_t** exception)
        {
            return self->_eval(self, code, script_url, start_line, retval, exception);
        }
        
    }
}
