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
    internal unsafe struct cef_shared_memory_region_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_shared_memory_region_t*, int> _is_valid;
        internal delegate* unmanaged<cef_shared_memory_region_t*, UIntPtr> _size;
        internal delegate* unmanaged<cef_shared_memory_region_t*, void*> _memory;
        
        // AddRef
        
        public static void add_ref(cef_shared_memory_region_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_shared_memory_region_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_shared_memory_region_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_shared_memory_region_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_shared_memory_region_t* self)
        {
            return self->_is_valid(self);
        }
        
        // Size
        
        public static UIntPtr size(cef_shared_memory_region_t* self)
        {
            return self->_size(self);
        }
        
        // Memory
        
        public static void* memory(cef_shared_memory_region_t* self)
        {
            return self->_memory(self);
        }
        
    }
}
