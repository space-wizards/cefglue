namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Class representing a V8 ArrayBuffer backing store. The backing store holds
    /// the memory that backs an ArrayBuffer. It must be created on a thread with a
    /// valid V8 isolate (renderer main thread or WebWorker thread). Once created,
    /// the Data() pointer can be safely read/written from any thread. This allows
    /// expensive operations like memcpy to be performed on a background thread
    /// before creating the ArrayBuffer on the V8 thread.
    ///
    /// The backing store is consumed when passed to
    /// CefV8Value::CreateArrayBufferFromBackingStore(), after which IsValid()
    /// returns false.
    /// </summary>
    public sealed unsafe partial class CefV8BackingStore
    {
        /// <summary>
        /// Create a new backing store with allocated memory of |byte_length| bytes.
        /// The memory is uninitialized. This method must be called on a thread with a
        /// valid V8 isolate. The returned object can safely be passed to other
        /// threads. Returns null on failure.
        /// </summary>
        public static CefV8BackingStore Create(ulong byteLength)
        {
            return CefV8BackingStore.FromNativeOrNull(
                cef_v8backing_store_t.create(checked((UIntPtr)byteLength))
                );
        }

        /// <summary>
        /// Returns a pointer to the allocated memory, or IntPtr.Zero if the backing
        /// store has been consumed or is otherwise invalid. The pointer is safe to
        /// read/write from any thread. The caller must ensure all writes are complete
        /// before passing this object to CreateArrayBufferFromBackingStore().
        /// Pointers obtained from this method should not be retained after calling
        /// CreateArrayBufferFromBackingStore(), as the memory will then be owned by
        /// the ArrayBuffer and subject to V8 garbage collection.
        /// </summary>
        public IntPtr Data
        {
            get { return (IntPtr)cef_v8backing_store_t.data(_self); }
        }

        /// <summary>
        /// Returns the size of the allocated memory in bytes, or 0 if the backing
        /// store has been consumed.
        /// </summary>
        public ulong ByteLength
        {
            get { return (ulong)cef_v8backing_store_t.byte_length(_self); }
        }

        /// <summary>
        /// Returns true if this backing store has not yet been consumed by
        /// CreateArrayBufferFromBackingStore().
        /// </summary>
        public bool IsValid
        {
            get { return cef_v8backing_store_t.is_valid(_self) != 0; }
        }
    }
}
