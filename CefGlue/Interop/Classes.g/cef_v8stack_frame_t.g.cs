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
    internal unsafe struct cef_v8stack_frame_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_v8stack_frame_t*, int> _is_valid;
        internal delegate* unmanaged<cef_v8stack_frame_t*, cef_string_userfree*> _get_script_name;
        internal delegate* unmanaged<cef_v8stack_frame_t*, cef_string_userfree*> _get_script_name_or_source_url;
        internal delegate* unmanaged<cef_v8stack_frame_t*, cef_string_userfree*> _get_function_name;
        internal delegate* unmanaged<cef_v8stack_frame_t*, int> _get_line_number;
        internal delegate* unmanaged<cef_v8stack_frame_t*, int> _get_column;
        internal delegate* unmanaged<cef_v8stack_frame_t*, int> _is_eval;
        internal delegate* unmanaged<cef_v8stack_frame_t*, int> _is_constructor;
        
        // AddRef
        
        public static void add_ref(cef_v8stack_frame_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_v8stack_frame_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_v8stack_frame_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_v8stack_frame_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_v8stack_frame_t* self)
        {
            return self->_is_valid(self);
        }
        
        // GetScriptName
        
        public static cef_string_userfree* get_script_name(cef_v8stack_frame_t* self)
        {
            return self->_get_script_name(self);
        }
        
        // GetScriptNameOrSourceURL
        
        public static cef_string_userfree* get_script_name_or_source_url(cef_v8stack_frame_t* self)
        {
            return self->_get_script_name_or_source_url(self);
        }
        
        // GetFunctionName
        
        public static cef_string_userfree* get_function_name(cef_v8stack_frame_t* self)
        {
            return self->_get_function_name(self);
        }
        
        // GetLineNumber
        
        public static int get_line_number(cef_v8stack_frame_t* self)
        {
            return self->_get_line_number(self);
        }
        
        // GetColumn
        
        public static int get_column(cef_v8stack_frame_t* self)
        {
            return self->_get_column(self);
        }
        
        // IsEval
        
        public static int is_eval(cef_v8stack_frame_t* self)
        {
            return self->_is_eval(self);
        }
        
        // IsConstructor
        
        public static int is_constructor(cef_v8stack_frame_t* self)
        {
            return self->_is_constructor(self);
        }
        
    }
}
