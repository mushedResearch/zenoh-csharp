using System.Runtime.InteropServices;

namespace Zenoh;

public static unsafe partial class NativeMethods
    {
        const string __DllName = "zenohc.dll";



        /// <summary>
        ///  Constructs an empty view slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_slice_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_view_slice_empty(z_view_slice_t* this_);

        /// <summary>
        ///  Constructs a `len` bytes long view starting at `start`.
        ///
        ///  @return -1 if `start == NULL` and `len &gt; 0` (and creates an empty view slice), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_slice_from_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_slice_from_buf(z_view_slice_t* @this, byte* start, nuint len);

        /// <summary>
        ///  Borrows view slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_slice_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_slice_t* z_view_slice_loan(z_view_slice_t* this_);

        /// <summary>
        ///  @return ``true`` if the slice is not empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_slice_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_view_slice_is_empty(z_view_slice_t* this_);

        /// <summary>
        ///  Constructs an empty `z_owned_slice_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_slice_empty(z_owned_slice_t* this_);

        /// <summary>
        ///  Constructs an empty `z_owned_slice_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_slice_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_slice_null(z_owned_slice_t* this_);

        /// <summary>
        ///  Frees the memory and invalidates the slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_slice_drop(z_moved_slice_t* this_);

        /// <summary>
        ///  Borrows slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_slice_t* z_slice_loan(z_owned_slice_t* this_);

        /// <summary>
        ///  Constructs an owned copy of a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_slice_clone(z_owned_slice_t* dst, z_loaned_slice_t* this_);

        /// <summary>
        ///  @return ``true`` if slice is not empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_slice_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_slice_check(z_owned_slice_t* this_);

        /// <summary>
        ///  @return the length of the slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_slice_len(z_loaned_slice_t* this_);

        /// <summary>
        ///  @return the pointer to the slice data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* z_slice_data(z_loaned_slice_t* this_);

        /// <summary>
        ///  @return ``true`` if slice is empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_slice_is_empty(z_loaned_slice_t* this_);

        /// <summary>
        ///  Constructs a slice by copying a `len` bytes long sequence starting at `start`.
        ///
        ///  @return -1 if `start == NULL` and `len &gt; 0` (creating an empty slice), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_copy_from_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_slice_copy_from_buf(MaybeUninit* @this, byte* start, nuint len);

        /// <summary>
        ///  Constructs a slice by transferring ownership of `data` to it.
        ///  @param this_: Pointer to an uninitialized memoery location where slice will be constructed.
        ///  @param data: Pointer to the data to be owned by `this_`.
        ///  @param len: Number of bytes in `data`.
        ///  @param deleter: A thread-safe delete function to free the `data`. Will be called once when `this_` is dropped. Can be NULL, in case if `data` is allocated in static memory.
        ///  @param context: An optional context to be passed to the `deleter`.
        ///
        ///  @return -1 if `start == NULL` and `len &gt; 0` (creating an empty slice), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_slice_from_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_slice_from_buf(MaybeUninit* @this, byte* data, nuint len, delegate* unmanaged[Cdecl]<void*, void*, void> drop, void* context);

        /// <summary>
        ///  Frees memory and invalidates `z_owned_string_t`, putting it in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_drop(z_moved_string_t* this_);

        /// <summary>
        ///  @return ``true`` if `this_` is a valid string, ``false`` if it is in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_string_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_string_check(z_owned_string_t* this_);

        /// <summary>
        ///  Constructs owned string in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_string_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_string_null(z_owned_string_t* this_);

        /// <summary>
        ///  @return ``true`` if view string is valid, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_string_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_view_string_is_empty(z_view_string_t* this_);

        /// <summary>
        ///  Constructs an empty owned string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_empty(z_owned_string_t* this_);

        /// <summary>
        ///  Constructs an empty view string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_string_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_view_string_empty(z_view_string_t* this_);

        /// <summary>
        ///  Borrows string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_string_t* z_string_loan(z_owned_string_t* this_);

        /// <summary>
        ///  Borrows view string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_string_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_string_t* z_view_string_loan(z_view_string_t* this_);

        /// <summary>
        ///  Constructs an owned string by copying `str` into it (including terminating 0), using `strlen` (this should therefore not be used with untrusted inputs).
        ///
        ///  @return -1 if `str == NULL` (and creates a string in a gravestone state), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_copy_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_string_copy_from_str(z_owned_string_t* this_, byte* str);

        /// <summary>
        ///  Constructs an owned string by copying a `str` substring of length `len`.
        ///
        ///  @return -1 if `str == NULL` and `len &gt; 0` (and creates a string in a gravestone state), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_copy_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_string_copy_from_substr(z_owned_string_t* @this, byte* str, nuint len);

        /// <summary>
        ///  Constructs an owned string by transferring ownership of a null-terminated string `str` to it.
        ///  @param this_: Pointer to an uninitialized memory location where an owned string will be constructed.
        ///  @param value: Pointer to a null terminated string to be owned by `this_`.
        ///  @param deleter: A thread-safe delete function to free the `str`. Will be called once when `str` is dropped. Can be NULL, in case if `str` is allocated in static memory.
        ///  @param context: An optional context to be passed to the `deleter`.
        ///  @return -1 if `str == NULL` and `len &gt; 0` (and creates a string in a gravestone state), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_string_from_str(z_owned_string_t* @this, byte* str, delegate* unmanaged[Cdecl]<void*, void*, void> drop, void* context);

        /// <summary>
        ///  Constructs a view string of `str`, using `strlen` (this should therefore not be used with untrusted inputs).
        ///
        ///  @return -1 if `str == NULL` (and creates a string in a gravestone state), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_string_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_string_from_str(z_view_string_t* @this, byte* str);

        /// <summary>
        ///  Constructs a view string to a specified substring of length `len`.
        ///
        ///  @return -1 if `str == NULL` and `len &gt; 0` (and creates a string in a gravestone state), 0 otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_string_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_string_from_substr(z_view_string_t* @this, byte* str, nuint len);

        /// <summary>
        ///  @return the length of the string (without terminating 0 character).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_string_len(z_loaned_string_t* this_);

        /// <summary>
        ///  @return the pointer of the string data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* z_string_data(z_loaned_string_t* this_);

        /// <summary>
        ///  Constructs an owned copy of a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_clone(z_owned_string_t* dst, z_loaned_string_t* @this);

        [DllImport(__DllName, EntryPoint = "z_string_as_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_slice_t* z_string_as_slice(z_loaned_string_t* this_);

        /// <summary>
        ///  @return ``true`` if string is empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_string_is_empty(z_loaned_string_t* this_);

        /// <summary>
        ///  Constructs a new empty string array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_array_new(MaybeUninit* this_);

        /// <summary>
        ///  Constructs string array in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_string_array_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_string_array_null(MaybeUninit* this_);

        /// <summary>
        ///  @return ``true`` if the string array is valid, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_string_array_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_string_array_check(z_owned_string_array_t* this_);

        /// <summary>
        ///  Destroys the string array, resetting it to its gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_array_drop(z_moved_string_array_t* this_);

        /// <summary>
        ///  Borrows string array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_string_array_t* z_string_array_loan(z_owned_string_array_t* @this);

        /// <summary>
        ///  Mutably borrows string array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_string_array_t* z_string_array_loan_mut(z_owned_string_array_t* @this);

        /// <summary>
        ///  @return number of elements in the array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_string_array_len(z_loaned_string_array_t* this_);

        /// <summary>
        ///  @return ``true`` if the array is empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_string_array_is_empty(z_loaned_string_array_t* this_);

        /// <summary>
        ///  @return the value at the position of index in the string array.
        ///
        ///  Will return `NULL` if the index is out of bounds.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_string_t* z_string_array_get(z_loaned_string_array_t* @this, nuint index);

        /// <summary>
        ///  Appends specified value to the end of the string array by copying.
        ///
        ///  @return the new length of the array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_push_by_copy", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_string_array_push_by_copy(z_loaned_string_array_t* @this, z_loaned_string_t* value);

        /// <summary>
        ///  Appends specified value to the end of the string array by alias.
        ///
        ///  @return the new length of the array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_push_by_alias", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_string_array_push_by_alias(z_loaned_string_array_t* @this, z_loaned_string_t* value);

        /// <summary>
        ///  Constructs an owned copy of a string array.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_string_array_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_string_array_clone(MaybeUninit* dst, z_loaned_string_array_t* this_);

        /// <summary>
        ///  Create uhlc timestamp from session id.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_timestamp_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_timestamp_new(MaybeUninit* @this, z_loaned_session_t* session);

        /// <summary>
        ///  Returns NPT64 time associated with this timestamp.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_timestamp_ntp64_time", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong z_timestamp_ntp64_time(z_timestamp_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns id associated with this timestamp.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_timestamp_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_id_t z_timestamp_id(z_timestamp_t* this_);

        /// <summary>
        ///  Returns the key expression of the sample.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_sample_keyexpr(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns the encoding associated with the sample data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_encoding", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_sample_encoding(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns the sample payload data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_payload", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_sample_payload(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns the sample kind.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_kind", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_sample_kind_t z_sample_kind(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns the sample timestamp.
        ///
        ///  Will return `NULL`, if sample is not associated with a timestamp.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_timestamp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_timestamp_t* z_sample_timestamp(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns sample attachment.
        ///
        ///  Returns `NULL`, if sample does not contain any attachment.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_attachment", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_sample_attachment(z_loaned_sample_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the sample source_info.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_source_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_source_info_t* z_sample_source_info(z_loaned_sample_t* this_);

        /// <summary>
        ///  Constructs an owned shallow copy of the sample (i.e. all modficiations applied to the copy, might be visible in the original) in provided uninitilized memory location.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_sample_clone(MaybeUninit* dst, z_loaned_sample_t* @this);

        /// <summary>
        ///  Returns sample qos priority value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_priority", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_priority_t z_sample_priority(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns whether sample qos express flag was set or not.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_express", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_sample_express(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns sample qos congestion control value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_congestion_control", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_congestion_control_t z_sample_congestion_control(z_loaned_sample_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the reliability setting the sample was delivered with.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_reliability", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_reliability_t z_sample_reliability(z_loaned_sample_t* this_);

        /// <summary>
        ///  Returns ``true`` if sample is valid, ``false`` if it is in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_sample_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_sample_check(z_owned_sample_t* this_);

        /// <summary>
        ///  Borrows sample.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_sample_t* z_sample_loan(z_owned_sample_t* this_);

        /// <summary>
        ///  Frees the memory and invalidates the sample, resetting it to a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_sample_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_sample_drop(z_moved_sample_t* this_);

        /// <summary>
        ///  Constructs sample in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_sample_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_sample_null(MaybeUninit* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns default value of `zc_locality_t`
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_locality_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern zc_locality_t zc_locality_default();

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the default value for `reliability`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reliability_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_reliability_t z_reliability_default();

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the default value of #zc_reply_keyexpr_t.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_reply_keyexpr_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern zc_reply_keyexpr_t zc_reply_keyexpr_default();

        /// <summary>
        ///  Create a default `z_query_target_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_target_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_target_t z_query_target_default();

        /// <summary>
        ///  Returns the default value of #z_priority_t.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_priority_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_priority_t z_priority_default();

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the zenoh id of entity global id.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_entity_global_id_zid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_id_t z_entity_global_id_zid(z_entity_global_id_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the entity id of the entity global id.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_entity_global_id_eid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint z_entity_global_id_eid(z_entity_global_id_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Creates source info.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_source_info_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_source_info_new(MaybeUninit* @this, z_entity_global_id_t* source_id, uint source_sn);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the source_id of the source info.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_source_info_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_entity_global_id_t z_source_info_id(z_loaned_source_info_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the source_sn of the source info.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_source_info_sn", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint z_source_info_sn(z_loaned_source_info_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns ``true`` if source info is valid, ``false`` if it is in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_source_info_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_source_info_check(z_owned_source_info_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Borrows source info.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_source_info_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_source_info_t* z_source_info_loan(z_owned_source_info_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Frees the memory and invalidates the source info, resetting it to a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_source_info_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_source_info_drop(z_moved_source_info_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs source info in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_source_info_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_source_info_null(MaybeUninit* this_);

        /// <summary>
        ///  Borrows config.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_config_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_config_t* z_config_loan(z_owned_config_t* this_);

        /// <summary>
        ///  Mutably borrows config.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_config_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_config_t* z_config_loan_mut(z_owned_config_t* this_);

        /// <summary>
        ///  Constructs a new empty configuration.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_config_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_config_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs config in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_config_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_config_null(MaybeUninit* this_);

        /// <summary>
        ///  Clones the config into provided uninitialized memory location.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_config_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_config_clone(MaybeUninit* dst, z_loaned_config_t* @this);

        /// <summary>
        ///  Gets the property with the given path key from the configuration, and constructs and owned string from it.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_get_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_get_from_str(z_loaned_config_t* @this, byte* key, MaybeUninit* out_value_string);

        /// <summary>
        ///  Gets the property with the given path key from the configuration, and constructs and owned string from it.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_get_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_get_from_substr(z_loaned_config_t* @this, byte* key, nuint key_len, MaybeUninit* out_value_string);

        /// <summary>
        ///  Inserts a JSON-serialized `value` at the `key` position of the configuration.
        ///
        ///  Returns 0 if successful, a negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_insert_json5", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_insert_json5(z_loaned_config_t* @this, byte* key, byte* value);

        /// <summary>
        ///  Inserts a JSON-serialized `value` at the `key` position of the configuration.
        ///
        ///  Returns 0 if successful, a negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_insert_json5_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_insert_json5_from_substr(z_loaned_config_t* @this, byte* key, nuint key_len, byte* value, nuint value_len);

        /// <summary>
        ///  Frees `config`, and resets it to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_config_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_config_drop(z_moved_config_t* this_);

        /// <summary>
        ///  Returns ``true`` if config is valid, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_config_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_config_check(z_owned_config_t* this_);

        /// <summary>
        ///  Reads a configuration from a JSON-serialized string, such as '{mode:"client",connect:{endpoints:["tcp/127.0.0.1:7447"]}}'.
        ///
        ///  Returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_from_str(MaybeUninit* @this, byte* s);

        /// <summary>
        ///  Constructs a json string representation of the `config`, such as '{"mode":"client","connect":{"endpoints":["tcp/127.0.0.1:7447"]}}'.
        ///
        ///  Returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_to_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_to_string(z_loaned_config_t* config, MaybeUninit* out_config_string);

        /// <summary>
        ///  Constructs a configuration by parsing a file at `path`. Currently supported format is JSON5, a superset of JSON.
        ///
        ///  Returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_from_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_from_file(MaybeUninit* @this, byte* path);

        /// <summary>
        ///  Constructs a configuration by parsing a file path stored in ZENOH_CONFIG environmental variable.
        ///
        ///  Returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_config_from_env", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_config_from_env(MaybeUninit* @this);

        /// <summary>
        ///  Constructs a `z_owned_encoding_t` from a specified substring.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_encoding_from_substr(MaybeUninit* @this, byte* s, nuint len);

        /// <summary>
        ///  Set a schema to this encoding from a c substring. Zenoh does not define what a schema is and its semantichs is left to the implementer.
        ///  E.g. a common schema for `text/plain` encoding is `utf-8`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_set_schema_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_encoding_set_schema_from_substr(z_loaned_encoding_t* @this, byte* s, nuint len);

        /// <summary>
        ///  Set a schema to this encoding from a c string. Zenoh does not define what a schema is and its semantichs is left to the implementer.
        ///  E.g. a common schema for `text/plain` encoding is `utf-8`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_set_schema_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_encoding_set_schema_from_str(z_loaned_encoding_t* @this, byte* s);

        /// <summary>
        ///  Constructs a `z_owned_encoding_t` from a specified string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_encoding_from_str(MaybeUninit* @this, byte* s);

        /// <summary>
        ///  Constructs an owned non-null-terminated string from encoding
        ///
        ///  @param this_: Encoding.
        ///  @param out_str: Uninitialized memory location where a string to be constructed.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_to_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_encoding_to_string(z_loaned_encoding_t* @this, MaybeUninit* out_str);

        /// <summary>
        ///  Returns a loaned default `z_loaned_encoding_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_loan_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_loan_default();

        /// <summary>
        ///  Constructs a default `z_owned_encoding_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_encoding_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_encoding_null(MaybeUninit* this_);

        /// <summary>
        ///  Frees the memory and resets the encoding it to its default value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_encoding_drop(z_moved_encoding_t* this_);

        /// <summary>
        ///  Returns ``true`` if encoding is in non-default state, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_encoding_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_encoding_check(z_owned_encoding_t* this_);

        /// <summary>
        ///  Borrows encoding.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_loan(z_owned_encoding_t* this_);

        /// <summary>
        ///  Mutably borrows encoding.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_loan_mut(z_owned_encoding_t* this_);

        /// <summary>
        ///  Constructs an owned copy of the encoding in provided uninitilized memory location.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_encoding_clone(MaybeUninit* dst, z_loaned_encoding_t* @this);

        /// <summary>
        ///  Returns ``true`` if `this_` equals to `other`, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_equals", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_encoding_equals(z_loaned_encoding_t* this_, z_loaned_encoding_t* other);

        /// <summary>
        ///  Just some bytes.
        ///
        ///  Constant alias for string: `"zenoh/bytes"`.
        ///
        ///  Usually used for types: `uint8_t[]`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_bytes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_bytes();

        /// <summary>
        ///  A VLE-encoded signed little-endian 8bit integer. Binary representation uses two's complement.
        ///
        ///  Constant alias for string: `"zenoh/int8"`.
        ///
        ///  Usually used for types: `int8_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_int8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_int8();

        /// <summary>
        ///  A VLE-encoded signed little-endian 16bit integer. Binary representation uses two's complement.
        ///
        ///  Constant alias for string: `"zenoh/int16"`.
        ///
        ///  Usually used for types: `int16_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_int16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_int16();

        /// <summary>
        ///  A VLE-encoded signed little-endian 32bit integer. Binary representation uses two's complement.
        ///
        ///  Constant alias for string: `"zenoh/int32"`.
        ///
        ///  Usually used for types: `int32_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_int32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_int32();

        /// <summary>
        ///  A VLE-encoded signed little-endian 64bit integer. Binary representation uses two's complement.
        ///
        ///  Constant alias for string: `"zenoh/int64"`.
        ///
        ///  Usually used for types: `int64_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_int64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_int64();

        /// <summary>
        ///  A VLE-encoded signed little-endian 128bit integer. Binary representation uses two's complement.
        ///
        ///  Constant alias for string: `"zenoh/int128"`.
        ///
        ///  Usually used for types: `int128_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_int128", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_int128();

        /// <summary>
        ///  A VLE-encoded unsigned little-endian 8bit integer.
        ///
        ///  Constant alias for string: `"zenoh/uint8"`.
        ///
        ///  Usually used for types: `uint8_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_uint8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_uint8();

        /// <summary>
        ///  A VLE-encoded unsigned little-endian 16bit integer.
        ///
        ///  Constant alias for string: `"zenoh/uint16"`.
        ///
        ///  Usually used for types: `uint16_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_uint16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_uint16();

        /// <summary>
        ///  A VLE-encoded unsigned little-endian 32bit integer.
        ///
        ///  Constant alias for string: `"zenoh/uint32"`.
        ///
        ///  Usually used for types: `uint32_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_uint32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_uint32();

        /// <summary>
        ///  A VLE-encoded unsigned little-endian 64bit integer.
        ///
        ///  Constant alias for string: `"zenoh/uint64"`.
        ///
        ///  Usually used for types: `uint64_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_uint64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_uint64();

        /// <summary>
        ///  A VLE-encoded unsigned little-endian 128bit integer.
        ///
        ///  Constant alias for string: `"zenoh/uint128"`.
        ///
        ///  Usually used for types: `uint128_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_uint128", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_uint128();

        /// <summary>
        ///  A VLE-encoded 32bit float. Binary representation uses *IEEE 754-2008* *binary32* .
        ///
        ///  Constant alias for string: `"zenoh/float32"`.
        ///
        ///  Usually used for types: `float`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_float32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_float32();

        /// <summary>
        ///  A VLE-encoded 64bit float. Binary representation uses *IEEE 754-2008* *binary64*.
        ///
        ///  Constant alias for string: `"zenoh/float64"`.
        ///
        ///  Usually used for types: `double`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_float64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_float64();

        /// <summary>
        ///  A boolean. `0` is `false`, `1` is `true`. Other values are invalid.
        ///
        ///  Constant alias for string: `"zenoh/bool"`.
        ///
        ///  Usually used for types: `bool`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_bool", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_bool();

        /// <summary>
        ///  A UTF-8 string.
        ///
        ///  Constant alias for string: `"zenoh/string"`.
        ///
        ///  Usually used for types: `const char*`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_string();

        /// <summary>
        ///  A zenoh error.
        ///
        ///  Constant alias for string: `"zenoh/error"`.
        ///
        ///  Usually used for types: `z_reply_error_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_zenoh_error", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_zenoh_error();

        /// <summary>
        ///  An application-specific stream of bytes.
        ///
        ///  Constant alias for string: `"application/octet-stream"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_octet_stream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_octet_stream();

        /// <summary>
        ///  A textual file.
        ///
        ///  Constant alias for string: `"text/plain"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_plain", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_plain();

        /// <summary>
        ///  JSON data intended to be consumed by an application.
        ///
        ///  Constant alias for string: `"application/json"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_json();

        /// <summary>
        ///  JSON data intended to be human readable.
        ///
        ///  Constant alias for string: `"text/json"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_json();

        /// <summary>
        ///  A Common Data Representation (CDR)-encoded data.
        ///
        ///  Constant alias for string: `"application/cdr"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_cdr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_cdr();

        /// <summary>
        ///  A Concise Binary Object Representation (CBOR)-encoded data.
        ///
        ///  Constant alias for string: `"application/cbor"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_cbor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_cbor();

        /// <summary>
        ///  YAML data intended to be consumed by an application.
        ///
        ///  Constant alias for string: `"application/yaml"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_yaml", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_yaml();

        /// <summary>
        ///  YAML data intended to be human readable.
        ///
        ///  Constant alias for string: `"text/yaml"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_yaml", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_yaml();

        /// <summary>
        ///  JSON5 encoded data that are human readable.
        ///
        ///  Constant alias for string: `"text/json5"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_json5", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_json5();

        /// <summary>
        ///  A Python object serialized using [pickle](https://docs.python.org/3/library/pickle.html).
        ///
        ///  Constant alias for string: `"application/python-serialized-object"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_python_serialized_object", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_python_serialized_object();

        /// <summary>
        ///  An application-specific protobuf-encoded data.
        ///
        ///  Constant alias for string: `"application/protobuf"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_protobuf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_protobuf();

        /// <summary>
        ///  A Java serialized object.
        ///
        ///  Constant alias for string: `"application/java-serialized-object"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_java_serialized_object", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_java_serialized_object();

        /// <summary>
        ///  An [openmetrics](https://github.com/OpenObservability/OpenMetrics) data, common used by [Prometheus](https://prometheus.io/).
        ///
        ///  Constant alias for string: `"application/openmetrics-text"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_openmetrics_text", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_openmetrics_text();

        /// <summary>
        ///  A Portable Network Graphics (PNG) image.
        ///
        ///  Constant alias for string: `"image/png"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_image_png", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_image_png();

        /// <summary>
        ///  A Joint Photographic Experts Group (JPEG) image.
        ///
        ///  Constant alias for string: `"image/jpeg"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_image_jpeg", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_image_jpeg();

        /// <summary>
        ///  A Graphics Interchange Format (GIF) image.
        ///
        ///  Constant alias for string: `"image/gif"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_image_gif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_image_gif();

        /// <summary>
        ///  A BitMap (BMP) image.
        ///
        ///  Constant alias for string: `"image/bmp"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_image_bmp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_image_bmp();

        /// <summary>
        ///  A Web Portable (WebP) image.
        ///
        ///   Constant alias for string: `"image/webp"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_image_webp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_image_webp();

        /// <summary>
        ///  An XML file intended to be consumed by an application..
        ///
        ///  Constant alias for string: `"application/xml"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_xml", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_xml();

        /// <summary>
        ///  An encoded a list of tuples, each consisting of a name and a value.
        ///
        ///  Constant alias for string: `"application/x-www-form-urlencoded"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_x_www_form_urlencoded", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_x_www_form_urlencoded();

        /// <summary>
        ///  An HTML file.
        ///
        ///  Constant alias for string: `"text/html"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_html", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_html();

        /// <summary>
        ///  An XML file that is human readable.
        ///
        ///  Constant alias for string: `"text/xml"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_xml", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_xml();

        /// <summary>
        ///  A CSS file.
        ///
        ///  Constant alias for string: `"text/css"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_css", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_css();

        /// <summary>
        ///  A JavaScript file.
        ///
        ///  Constant alias for string: `"text/javascript"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_javascript", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_javascript();

        /// <summary>
        ///  A MarkDown file.
        ///
        ///  Constant alias for string: `"text/markdown"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_markdown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_markdown();

        /// <summary>
        ///  A CSV file.
        ///
        ///  Constant alias for string: `"text/csv"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_text_csv", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_text_csv();

        /// <summary>
        ///  An application-specific SQL query.
        ///
        ///  Constant alias for string: `"application/sql"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_sql", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_sql();

        /// <summary>
        ///  Constrained Application Protocol (CoAP) data intended for CoAP-to-HTTP and HTTP-to-CoAP proxies.
        ///
        ///  Constant alias for string: `"application/coap-payload"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_coap_payload", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_coap_payload();

        /// <summary>
        ///  Defines a JSON document structure for expressing a sequence of operations to apply to a JSON document.
        ///
        ///  Constant alias for string: `"application/json-patch+json"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_json_patch_json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_json_patch_json();

        /// <summary>
        ///  A JSON text sequence consists of any number of JSON texts, all encoded in UTF-8.
        ///
        ///  Constant alias for string: `"application/json-seq"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_json_seq", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_json_seq();

        /// <summary>
        ///  A JSONPath defines a string syntax for selecting and extracting JSON values from within a given JSON value.
        ///
        ///  Constant alias for string: `"application/jsonpath"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_jsonpath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_jsonpath();

        /// <summary>
        ///  A JSON Web Token (JWT).
        ///
        ///  Constant alias for string: `"application/jwt"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_jwt", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_jwt();

        /// <summary>
        ///  An application-specific MPEG-4 encoded data, either audio or video.
        ///
        ///  Constant alias for string: `"application/mp4"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_mp4", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_mp4();

        /// <summary>
        ///  A SOAP 1.2 message serialized as XML 1.0.
        ///
        ///  Constant alias for string: `"application/soap+xml"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_soap_xml", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_soap_xml();

        /// <summary>
        ///  A YANG-encoded data commonly used by the Network Configuration Protocol (NETCONF).
        ///
        ///  Constant alias for string: `"application/yang"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_application_yang", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_application_yang();

        /// <summary>
        ///  A MPEG-4 Advanced Audio Coding (AAC) media.
        ///
        ///  Constant alias for string: `"audio/aac"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_audio_aac", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_audio_aac();

        /// <summary>
        ///  A Free Lossless Audio Codec (FLAC) media.
        ///
        ///  Constant alias for string: `"audio/flac"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_audio_flac", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_audio_flac();

        /// <summary>
        ///  An audio codec defined in MPEG-1, MPEG-2, MPEG-4, or registered at the MP4 registration authority.
        ///
        ///  Constant alias for string: `"audio/mp4"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_audio_mp4", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_audio_mp4();

        /// <summary>
        ///  An Ogg-encapsulated audio stream.
        ///
        ///  Constant alias for string: `"audio/ogg"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_audio_ogg", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_audio_ogg();

        /// <summary>
        ///  A Vorbis-encoded audio stream.
        ///
        ///  Constant alias for string: `"audio/vorbis"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_audio_vorbis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_audio_vorbis();

        /// <summary>
        ///  A h261-encoded video stream.
        ///
        ///  Constant alias for string: `"video/h261"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_h261", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_h261();

        /// <summary>
        ///  A h263-encoded video stream.
        ///
        ///  Constant alias for string: `"video/h263"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_h263", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_h263();

        /// <summary>
        ///  A h264-encoded video stream.
        ///
        ///  Constant alias for string: `"video/h264"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_h264", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_h264();

        /// <summary>
        ///  A h265-encoded video stream.
        ///
        ///  Constant alias for string: `"video/h265"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_h265", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_h265();

        /// <summary>
        ///  A h266-encoded video stream.
        ///
        ///  Constant alias for string: `"video/h266"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_h266", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_h266();

        /// <summary>
        ///  A video codec defined in MPEG-1, MPEG-2, MPEG-4, or registered at the MP4 registration authority.
        ///
        ///  Constant alias for string: `"video/mp4"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_mp4", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_mp4();

        /// <summary>
        ///  An Ogg-encapsulated video stream.
        ///
        ///  Constant alias for string: `"video/ogg"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_ogg", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_ogg();

        /// <summary>
        ///  An uncompressed, studio-quality video stream.
        ///
        ///  Constant alias for string: `"video/raw"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_raw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_raw();

        /// <summary>
        ///  A VP8-encoded video stream.
        ///
        ///  Constant alias for string: `"video/vp8"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_vp8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_vp8();

        /// <summary>
        ///  A VP9-encoded video stream.
        ///
        ///  Constant alias for string: `"video/vp9"`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_encoding_video_vp9", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_encoding_video_vp9();

        /// <summary>
        ///  Constructs an empty `z_owned_reply_err_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_reply_err_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_reply_err_null(MaybeUninit* this_);

        /// <summary>
        ///  Returns ``true`` if reply error is in non-default state, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_reply_err_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_reply_err_check(z_owned_reply_err_t* this_);

        /// <summary>
        ///  Returns reply error payload.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err_payload", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_reply_err_payload(z_loaned_reply_err_t* this_);

        /// <summary>
        ///  Returns reply error encoding.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err_encoding", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_reply_err_encoding(z_loaned_reply_err_t* this_);

        /// <summary>
        ///  Borrows reply error.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_reply_err_t* z_reply_err_loan(z_owned_reply_err_t* this_);

        /// <summary>
        ///  Frees the memory and resets the reply error it to its default value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_reply_err_drop(z_moved_reply_err_t* this_);

        /// <summary>
        ///  Returns ``true`` if reply contains a valid response, ``false`` otherwise (in this case it contains a errror value).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_is_ok", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_reply_is_ok(z_loaned_reply_t* this_);

        /// <summary>
        ///  Yields the contents of the reply by asserting it indicates a success.
        ///
        ///  Returns `NULL` if reply does not contain a sample (i. e. if `z_reply_is_ok` returns ``false``).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_ok", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_sample_t* z_reply_ok(z_loaned_reply_t* this_);

        /// <summary>
        ///  Yields the contents of the reply by asserting it indicates a failure.
        ///
        ///  Returns `NULL` if reply does not contain a error  (i. e. if `z_reply_is_ok` returns ``true``).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_reply_err_t* z_reply_err(z_loaned_reply_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Gets the id of the zenoh instance that answered this Reply.
        ///  @return `true` if id is present.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_replier_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_reply_replier_id(z_loaned_reply_t* @this, MaybeUninit* out_id);

        /// <summary>
        ///  Constructs the reply in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_reply_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_reply_null(MaybeUninit* this_);

        /// <summary>
        ///  Constructs an owned shallow copy of reply in provided uninitialized memory location.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_reply_clone(MaybeUninit* dst, z_loaned_reply_t* this_);

        /// <summary>
        ///  Constructs default `z_get_options_t`
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_get_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_get_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Query data from the matching queryables in the system.
        ///  Replies are provided through a callback function.
        ///
        ///  @param session: The zenoh session.
        ///  @param key_expr: The key expression matching resources to query.
        ///  @param parameters: The query's parameters, similar to a url's query segment.
        ///  @param callback: The callback function that will be called on reception of replies for this query. It will be automatically dropped once all replies are processed.
        ///  @param options: Additional options for the get. All owned fields will be consumed.
        ///
        ///  @return 0 in case of success, a negative error value upon failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_get(z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, byte* parameters, z_moved_closure_reply_t* callback, z_get_options_t* options);

        /// <summary>
        ///  Frees reply, resetting it to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_reply_drop(z_moved_reply_t* this_);

        /// <summary>
        ///  Returns ``true`` if `reply` is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_reply_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_reply_check(z_owned_reply_t* this_);

        /// <summary>
        ///  Borrows reply.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_reply_t* z_reply_loan(z_owned_reply_t* this_);

        /// <summary>
        ///  Creates a default `z_query_consolidation_t` (consolidation mode AUTO).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_consolidation_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_consolidation_t z_query_consolidation_default();

        /// <summary>
        ///  Automatic query consolidation strategy selection.
        ///
        ///  A query consolidation strategy will automatically be selected depending the query selector.
        ///  If the selector contains time range properties, no consolidation is performed.
        ///  Otherwise the `z_query_consolidation_latest` strategy is used.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_consolidation_auto", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_consolidation_t z_query_consolidation_auto();

        /// <summary>
        ///  Latest consolidation.
        ///
        ///  This strategy optimizes bandwidth on all links in the system but will provide a very poor latency.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_consolidation_latest", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_consolidation_t z_query_consolidation_latest();

        /// <summary>
        ///  Monotonic consolidation.
        ///
        ///  This strategy offers the best latency. Replies are directly transmitted to the application when received
        ///  without needing to wait for all replies. This mode does not guarantee that there will be no duplicates.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_consolidation_monotonic", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_consolidation_t z_query_consolidation_monotonic();

        /// <summary>
        ///  No consolidation.
        ///
        ///  This strategy is useful when querying timeseries data bases or when using quorums.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_consolidation_none", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_query_consolidation_t z_query_consolidation_none();

        /// <summary>
        ///  Constructs a copy of the reply error message.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_reply_err_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_reply_err_clone(MaybeUninit* dst, z_loaned_reply_err_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Formats the `z_id_t` into 16-digit hex string (LSB-first order)
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_id_to_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_id_to_string(z_id_t* zid, MaybeUninit* dst);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the session's Zenoh ID.
        ///
        ///  Unless the `session` is invalid, that ID is guaranteed to be non-zero.
        ///  In other words, this function returning an array of 16 zeros means you failed
        ///  to pass it a valid session.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_info_zid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_id_t z_info_zid(z_loaned_session_t* session);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Fetches the Zenoh IDs of all connected peers.
        ///
        ///  `callback` will be called once for each ID, is guaranteed to never be called concurrently,
        ///  and is guaranteed to be dropped before this function exits.
        ///
        ///  Retuns 0 on success, negative values on failure
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_info_peers_zid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_info_peers_zid(z_loaned_session_t* session, z_moved_closure_zid_t* callback);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Fetches the Zenoh IDs of all connected routers.
        ///
        ///  `callback` will be called once for each ID, is guaranteed to never be called concurrently,
        ///  and is guaranteed to be dropped before this function exits.
        ///
        ///  Retuns 0 on success, negative values on failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_info_routers_zid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_info_routers_zid(z_loaned_session_t* session, z_moved_closure_zid_t* callback);

        /// <summary>
        ///  Constructs an owned key expression in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_keyexpr_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_keyexpr_null(MaybeUninit* this_);

        /// <summary>
        ///  Constructs a view key expression in empty state
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_view_keyexpr_empty(MaybeUninit* this_);

        /// <summary>
        ///  Constructs a `z_owned_keyexpr_t` from a string, copying the passed string.
        ///  @return 0 in case of success, negative error code in case of failure (for example if `expr` is not a valid key expression or if it is
        ///  not in canon form.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_from_str(MaybeUninit* @this, byte* expr);

        /// <summary>
        ///  Constructs `z_owned_keyexpr_t` from a string, copying the passed string. The copied string is canonized.
        ///  @return 0 in case of success, negative error code in case of failure (for example if expr is not a valid key expression
        ///  even despite canonization).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_from_str_autocanonize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_from_str_autocanonize(MaybeUninit* @this, byte* expr);

        /// <summary>
        ///  Borrows `z_owned_keyexpr_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_keyexpr_loan(z_owned_keyexpr_t* this_);

        /// <summary>
        ///  Borrows `z_view_keyexpr_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_view_keyexpr_loan(z_view_keyexpr_t* this_);

        /// <summary>
        ///  Frees key expression and resets it to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_keyexpr_drop(z_moved_keyexpr_t* this_);

        /// <summary>
        ///  Returns ``true`` if `keyexpr` is valid, ``false`` if it is in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_keyexpr_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_keyexpr_check(z_owned_keyexpr_t* this_);

        /// <summary>
        ///  Returns ``true`` if `keyexpr` is valid, ``false`` if it is in gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_view_keyexpr_is_empty(z_view_keyexpr_t* this_);

        /// <summary>
        ///  Returns 0 if the passed string is a valid (and canon) key expression.
        ///  Otherwise returns negative error value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_is_canon", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_is_canon(byte* start, nuint len);

        /// <summary>
        ///  Canonizes the passed string in place, possibly shortening it by placing a new null-terminator.
        ///  May SEGFAULT if `start` is NULL or lies in read-only memory (as values initialized with string litterals do).
        ///
        ///  @return 0 upon success, negative error values upon failure (if the passed string was an invalid
        ///  key expression for reasons other than a non-canon form).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_canonize_null_terminated", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_canonize_null_terminated(byte* start);

        /// <summary>
        ///  Canonizes the passed string in place, possibly shortening it by modifying `len`.
        ///
        ///  May SEGFAULT if `start` is NULL or lies in read-only memory (as values initialized with string litterals do).
        ///
        ///  @return 0 upon success, negative error values upon failure (if the passed string was an invalid
        ///  key expression for reasons other than a non-canon form).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_canonize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_canonize(byte* start, nuint* len);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a substring.
        ///  `expr` must outlive the constucted key expression.
        ///
        ///  @param this_: An uninitialized location in memory where key expression will be constructed.
        ///  @param expr: A buffer with length &gt;= `len`.
        ///  @param len: Number of characters from `expr` to consider.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_keyexpr_from_substr(MaybeUninit* @this, byte* expr, nuint len);

        /// <summary>
        ///  Constructs a `z_owned_keyexpr_t` by copying a substring.
        ///
        ///  @param this_: An uninitialized location in memory where key expression will be constructed.
        ///  @param expr: A buffer with length &gt;= `len`.
        ///  @param len: Number of characters from `expr` to consider.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_from_substr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_from_substr(MaybeUninit* @this, byte* expr, nuint len);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a substring.
        ///  May SEGFAULT if `start` is NULL or lies in read-only memory (as values initialized with string litterals do).
        ///  `expr` must outlive the constucted key expression.
        ///
        ///  @param this_: An uninitialized location in memory where key expression will be constructed
        ///  @param expr: A buffer of with length &gt;= `len`.
        ///  @param len: Number of characters from `expr` to consider. Will be modified to be equal to canonized key expression length.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_substr_autocanonize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_keyexpr_from_substr_autocanonize(MaybeUninit* @this, byte* start, nuint* len);

        /// <summary>
        ///  Constructs a `z_keyexpr_t` by copying a substring.
        ///
        ///  @param this_: An uninitialized location in memory where key expression will be constructed.
        ///  @param expr: A buffer of with length &gt;= `len`.
        ///  @param len: Number of characters from `expr` to consider. Will be modified to be equal to canonized key expression length.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_from_substr_autocanonize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_from_substr_autocanonize(MaybeUninit* @this, byte* start, nuint* len);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a string.
        ///  @return 0 in case of success, negative error code in case of failure (for example if expr is not a valid key expression or if it is
        ///  not in canon form.
        ///  `expr` must outlive the constucted key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_keyexpr_from_str(MaybeUninit* @this, byte* expr);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a string.
        ///  The string is canonized in-place before being passed to keyexpr, possibly shortening it by modifying `len`.
        ///  May SEGFAULT if `expr` is NULL or lies in read-only memory (as values initialized with string litterals do).
        ///  `expr` must outlive the constucted key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_str_autocanonize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_view_keyexpr_from_str_autocanonize(MaybeUninit* @this, byte* expr);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a substring without checking any of `z_view_keyexpr_t`'s assertions:
        ///
        ///  - `start` MUST be valid UTF8.
        ///  - `start` MUST follow the Key Expression specification, i.e.:
        ///   - MUST NOT contain ``//``, MUST NOT start nor end with ``/``, MUST NOT contain any of the characters ``?#$``.
        ///   - any instance of ``**`` may only be lead or followed by ``/``.
        ///   - the key expression must have canon form.
        ///
        ///  `start` must outlive constructed key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_substr_unchecked", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_view_keyexpr_from_substr_unchecked(MaybeUninit* @this, byte* start, nuint len);

        /// <summary>
        ///  Constructs a `z_view_keyexpr_t` by aliasing a string without checking any of `z_view_keyexpr_t`'s assertions:
        ///
        ///   - `s` MUST be valid UTF8.
        ///   - `s` MUST follow the Key Expression specification, i.e.:
        ///    - MUST NOT contain `//`, MUST NOT start nor end with `/`, MUST NOT contain any of the characters `?#$`.
        ///    - any instance of `**` may only be lead or followed by `/`.
        ///    - the key expression must have canon form.
        ///
        ///  `s` must outlive constructed key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_view_keyexpr_from_str_unchecked", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_view_keyexpr_from_str_unchecked(MaybeUninit* @this, byte* s);

        /// <summary>
        ///  Constructs a non-owned non-null-terminated string from key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_as_view_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_keyexpr_as_view_string(z_loaned_keyexpr_t* @this, MaybeUninit* out_string);

        /// <summary>
        ///  Constructs and declares a key expression on the network. This reduces key key expression to a numerical id,
        ///  which allows to save the bandwith, when passing key expression between Zenoh entities.
        ///
        ///  @param this_: An uninitialized location in memory where key expression will be constructed.
        ///  @param session: Session on which to declare key expression.
        ///  @param key_expr: Key expression to declare on network.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_declare_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_declare_keyexpr(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr);

        /// <summary>
        ///  Undeclares the key expression generated by a call to `z_declare_keyexpr()`.
        ///  The key expression is consumed.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_undeclare_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_undeclare_keyexpr(z_moved_keyexpr_t* @this, z_loaned_session_t* session);

        /// <summary>
        ///  Returns ``true`` if both ``left`` and ``right`` are equal, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_equals", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_keyexpr_equals(z_loaned_keyexpr_t* left, z_loaned_keyexpr_t* right);

        /// <summary>
        ///  Returns ``true`` if the keyexprs intersect, i.e. there exists at least one key which is contained in both of the
        ///  sets defined by ``left`` and ``right``, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_intersects", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_keyexpr_intersects(z_loaned_keyexpr_t* left, z_loaned_keyexpr_t* right);

        /// <summary>
        ///  Returns ``true`` if ``left`` includes ``right``, i.e. the set defined by ``left`` contains every key belonging to the set
        ///  defined by ``right``, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_includes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_keyexpr_includes(z_loaned_keyexpr_t* left, z_loaned_keyexpr_t* right);

        /// <summary>
        ///  Constructs key expression by concatenation of key expression in `left` with a string in `right`.
        ///  Returns 0 in case of success, negative error code otherwise.
        ///
        ///  You should probably prefer `z_keyexpr_join` as Zenoh may then take advantage of the hierachical separation it inserts.
        ///  To avoid odd behaviors, concatenating a key expression starting with `*` to one ending with `*` is forbidden by this operation,
        ///  as this would extremely likely cause bugs.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_concat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_concat(MaybeUninit* @this, z_loaned_keyexpr_t* left, byte* right_start, nuint right_len);

        /// <summary>
        ///  Constructs key expression by performing path-joining (automatically inserting) of `left` with `right`.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_join", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_keyexpr_join(MaybeUninit* @this, z_loaned_keyexpr_t* left, z_loaned_keyexpr_t* right);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the relation between `left` and `right` from `left`'s point of view.
        ///
        ///  @note This is slower than `z_keyexpr_intersects` and `keyexpr_includes`, so you should favor these methods for most applications.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_relation_to", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_keyexpr_intersection_level_t z_keyexpr_relation_to(z_loaned_keyexpr_t* left, z_loaned_keyexpr_t* right);

        /// <summary>
        ///  Constructs a copy of the key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_keyexpr_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_keyexpr_clone(MaybeUninit* dst, z_loaned_keyexpr_t* @this);

        /// <summary>
        ///  Initializes the zenoh runtime logger, using rust environment settings.
        ///  E.g.: `RUST_LOG=info` will enable logging at info level. Similarly, you can set the variable to `error` or `debug`.
        ///
        ///  Note that if the environment variable is not set, then logging will not be enabled.
        ///  See https://docs.rs/env_logger/latest/env_logger/index.html for accepted filter format.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_try_init_log_from_env", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_try_init_log_from_env();

        /// <summary>
        ///  Initializes the zenoh runtime logger, using rust environment settings or the provided fallback level.
        ///  E.g.: `RUST_LOG=info` will enable logging at info level. Similarly, you can set the variable to `error` or `debug`.
        ///
        ///  Note that if the environment variable is not set, then fallback filter will be used instead.
        ///  See https://docs.rs/env_logger/latest/env_logger/index.html for accepted filter format.
        ///
        ///  @param fallback_filter: The fallback filter if the `RUST_LOG` environment variable is not set.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_init_log_from_env_or", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_init_log_from_env_or(byte* fallback_filter);

        /// <summary>
        ///  Initializes the zenoh runtime logger with custom callback.
        ///
        ///  @param min_severity: Minimum severity level of log message to be be passed to the `callback`.
        ///  Messages with lower severity levels will be ignored.
        ///  @param callback: A closure that will be called with each log message severity level and content.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_init_log_with_callback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_init_log_with_callback(zc_log_severity_t min_severity, zc_moved_closure_log_t* callback);

        /// <summary>
        ///  Stops all Zenoh tasks and drops all related static variables.
        ///  All Zenoh-related structures should be properly dropped/undeclared PRIOR to this call.
        ///  None of Zenoh functionality can be used after this call.
        ///  Useful to suppress memory leaks messages due to Zenoh static variables (since they are never destroyed due to Rust language design).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_stop_z_runtime", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_stop_z_runtime();

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs liveliness token in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_internal_liveliness_token_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_internal_liveliness_token_null(MaybeUninit* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns ``true`` if liveliness token is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_internal_liveliness_token_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool zc_internal_liveliness_token_check(zc_owned_liveliness_token_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Undeclares liveliness token, frees memory and resets it to a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_token_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_liveliness_token_drop(zc_moved_liveliness_token_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs default value for `zc_liveliness_declaration_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_declaration_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_liveliness_declaration_options_default(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Borrows token.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_token_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern zc_loaned_liveliness_token_t* zc_liveliness_token_loan(zc_owned_liveliness_token_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs and declares a liveliness token on the network.
        ///
        ///  Liveliness token subscribers on an intersecting key expression will receive a PUT sample when connectivity
        ///  is achieved, and a DELETE sample if it's lost.
        ///
        ///  @param this_: An uninitialized memory location where liveliness token will be constructed.
        ///  @param session: A Zenos session to declare the liveliness token.
        ///  @param key_expr: A keyexpr to declare a liveliess token for.
        ///  @param _options: Liveliness token declaration properties.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_declare_token", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_liveliness_declare_token(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, zc_liveliness_declaration_options_t* _options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Destroys a liveliness token, notifying subscribers of its destruction.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_undeclare_token", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_liveliness_undeclare_token(zc_moved_liveliness_token_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constucts default value for `zc_liveliness_declare_subscriber_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_subscriber_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_liveliness_subscriber_options_default(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Declares a subscriber on liveliness tokens that intersect `key_expr`.
        ///
        ///  @param this_: An uninitialized memory location where subscriber will be constructed.
        ///  @param session: The Zenoh session.
        ///  @param key_expr: The key expression to subscribe to.
        ///  @param callback: The callback function that will be called each time a liveliness token status is changed.
        ///  @param _options: The options to be passed to the liveliness subscriber declaration.
        ///
        ///  @return 0 in case of success, negative error values otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_declare_subscriber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_liveliness_declare_subscriber(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_closure_sample_t* callback, zc_liveliness_subscriber_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs default value `zc_liveliness_get_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_get_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_liveliness_get_options_default(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Queries liveliness tokens currently on the network with a key expression intersecting with `key_expr`.
        ///
        ///  @param session: The Zenoh session.
        ///  @param key_expr: The key expression to query liveliness tokens for.
        ///  @param callback: The callback function that will be called for each received reply.
        ///  @param options: Additional options for the liveliness get operation.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_liveliness_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_liveliness_get(z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_closure_reply_t* callback, zc_liveliness_get_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs the default value for `ze_publication_cache_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_publication_cache_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_publication_cache_options_default(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs and declares a publication cache.
        ///
        ///  @param this_: An uninitialized location in memory where publication cache will be constructed.
        ///  @param session: A Zenoh session.
        ///  @param key_expr: The key expression to publish to.
        ///  @param options: Additional options for the publication cache.
        ///
        ///  @returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_declare_publication_cache", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_declare_publication_cache(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, ze_publication_cache_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs a publication cache in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_publication_cache_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_internal_publication_cache_null(MaybeUninit* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns ``true`` if publication cache is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_publication_cache_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ze_internal_publication_cache_check(ze_owned_publication_cache_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Undeclares and drops publication cache.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_undeclare_publication_cache", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_undeclare_publication_cache(ze_moved_publication_cache_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Drops publication cache and resets it to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_publication_cache_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_publication_cache_drop(ze_moved_publication_cache_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the key expression of the publication cache.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_publication_cache_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* ze_publication_cache_keyexpr(ze_loaned_publication_cache_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Borrows publication cache.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_publication_cache_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ze_loaned_publication_cache_t* ze_publication_cache_loan(ze_owned_publication_cache_t* this_);

        /// <summary>
        ///  Constructs the default value for `z_publisher_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_publisher_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs and declares a publisher for the given key expression.
        ///
        ///  Data can be put and deleted with this publisher with the help of the
        ///  `z_publisher_put()` and `z_publisher_delete()` functions.
        ///
        ///  @param this_: An unitilized location in memory where publisher will be constructed.
        ///  @param session: The Zenoh session.
        ///  @param key_expr: The key expression to publish.
        ///  @param options: Additional options for the publisher.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_declare_publisher", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_declare_publisher(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_publisher_options_t* options);

        /// <summary>
        ///  Constructs a publisher in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_publisher_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_publisher_null(MaybeUninit* this_);

        /// <summary>
        ///  Returns ``true`` if publisher is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_publisher_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_publisher_check(z_owned_publisher_t* this_);

        /// <summary>
        ///  Borrows publisher.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_publisher_t* z_publisher_loan(z_owned_publisher_t* this_);

        /// <summary>
        ///  Mutably borrows publisher.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_publisher_t* z_publisher_loan_mut(z_owned_publisher_t* @this);

        /// <summary>
        ///  Constructs the default value for `z_publisher_put_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_put_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_publisher_put_options_default(MaybeUninit* @this);

        /// <summary>
        ///  Sends a `PUT` message onto the publisher's key expression, transfering the payload ownership.
        ///
        ///
        ///  The payload and all owned options fields are consumed upon function return.
        ///
        ///  @param this_: The publisher.
        ///  @param session: The Zenoh session.
        ///  @param payload: The dat to publish. WIll be consumed.
        ///  @param options: The publisher put options. All owned fields will be consumed.
        ///
        ///  @return 0 in case of success, negative error values in case of failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_put", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_publisher_put(z_loaned_publisher_t* @this, z_moved_bytes_t* payload, z_publisher_put_options_t* options);

        /// <summary>
        ///  Constructs the default values for the delete operation via a publisher entity.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_delete_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_publisher_delete_options_default(MaybeUninit* @this);

        /// <summary>
        ///  Sends a `DELETE` message onto the publisher's key expression.
        ///
        ///  @return 0 in case of success, negative error code in case of failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_delete", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_publisher_delete(z_loaned_publisher_t* publisher, z_publisher_delete_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the ID of the publisher.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_entity_global_id_t z_publisher_id(z_loaned_publisher_t* publisher);

        /// <summary>
        ///  Returns the key expression of the publisher.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_publisher_keyexpr(z_loaned_publisher_t* publisher);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs an empty matching listener.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_internal_matching_listener_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_internal_matching_listener_null(MaybeUninit* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Checks the matching listener is for the gravestone state
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_internal_matching_listener_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool zc_internal_matching_listener_check(zc_owned_matching_listener_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs matching listener, registering a callback for notifying subscribers matching with a given publisher.
        ///
        ///  @param this_: An unitilized memory location where matching listener will be constructed. The matching listener will be automatically dropped when publisher is dropped.
        ///  @param publisher: A publisher to associate with matching listener.
        ///  @param callback: A closure that will be called every time the matching status of the publisher changes (If last subscriber, disconnects or when the first subscriber connects).
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_publisher_matching_listener_declare", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_publisher_matching_listener_declare(MaybeUninit* @this, z_loaned_publisher_t* publisher, zc_moved_closure_matching_status_t* callback);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Undeclares the given matching listener, droping and invalidating it.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_publisher_matching_listener_undeclare", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_publisher_matching_listener_undeclare(zc_moved_matching_listener_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Undeclares the given matching listener, droping and invalidating it.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_publisher_matching_listener_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void zc_publisher_matching_listener_drop(zc_moved_matching_listener_t* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Gets publisher matching status - i.e. if there are any subscribers matching its key expression.
        ///
        ///  @return 0 in case of success, negative error code otherwise (in this case matching_status is not updated).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "zc_publisher_get_matching_status", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte zc_publisher_get_matching_status(z_loaned_publisher_t* @this, MaybeUninit* matching_status);

        /// <summary>
        ///  @brief Undeclares the given publisher, droping and invalidating it.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_undeclare_publisher", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_undeclare_publisher(z_moved_publisher_t* this_);

        /// <summary>
        ///  Frees memory and resets publisher to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_publisher_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_publisher_drop(z_moved_publisher_t* @this);

        /// <summary>
        ///  Constructs the default value for `z_put_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_put_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_put_options_t z_put_options_default();

        /// <summary>
        ///  Publishes data on specified key expression.
        ///
        ///  @param session: The Zenoh session.
        ///  @param key_expr: The key expression to publish to.
        ///  @param payload: The value to put (consumed upon function return).
        ///  @param options: The put options (all owned values will be consumed upon function return).
        ///
        ///  @return 0 in case of success, negative error values in case of failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_put", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_put(z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_bytes_t* payload, z_put_options_t* options);

        /// <summary>
        ///  Constructs the default value for `z_delete_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_delete_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_delete_options_default(z_put_options_t*  this_);

        /// <summary>
        ///  Sends request to delete data on specified key expression (used when working with &lt;a href="https://zenoh.io/docs/manual/abstractions/#storage"&gt; Zenoh storages &lt;/a&gt;).
        ///
        ///  @param session: The zenoh session.
        ///  @param key_expr: The key expression to delete.
        ///  @param options: The delete options.
        ///
        ///  @return 0 in case of success, negative values in case of failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_delete", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_delete(z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_delete_options_t* options);

        /// <summary>
        ///  Constructs a queryable in its gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_queryable_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_queryable_null(MaybeUninit* this_);

        [DllImport(__DllName, EntryPoint = "z_queryable_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_queryable_t* z_queryable_loan(z_owned_queryable_t* this_);

        /// <summary>
        ///  Constructs query in its gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_query_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_query_null(MaybeUninit* this_);

        /// <summary>
        ///  Returns `false` if `this` is in a gravestone state, `true` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_query_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_query_check(z_owned_query_t* query);

        /// <summary>
        ///  Borrows the query.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_query_t* z_query_loan(z_owned_query_t* this_);

        /// <summary>
        ///  Destroys the query resetting it to its gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_drop(z_moved_query_t* this_);

        /// <summary>
        ///  Constructs a shallow copy of the query, allowing to keep it in an "open" state past the callback's return.
        ///
        ///  This operation is infallible, but may return a gravestone value if `query` itself was a gravestone value (which cannot be the case in a callback).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_clone(MaybeUninit* dst, z_loaned_query_t* this_);

        /// <summary>
        ///  Constructs the default value for `z_query_reply_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_queryable_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_queryable_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs the default value for `z_query_reply_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_reply_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs the default value for `z_query_reply_err_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply_err_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_reply_err_options_default(MaybeUninit* @this);

        /// <summary>
        ///  Constructs the default value for `z_query_reply_del_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply_del_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_reply_del_options_default(MaybeUninit* @this);

        /// <summary>
        ///  Constructs a Queryable for the given key expression.
        ///
        ///  @param this_: An uninitialized memory location where queryable will be constructed.
        ///  @param session: The zenoh session.
        ///  @param key_expr: The key expression the Queryable will reply to.
        ///  @param callback: The callback function that will be called each time a matching query is received. Its ownership is passed to queryable.
        ///  @param options: Options for the queryable.
        ///
        ///  @return 0 in case of success, negative error code otherwise (in this case )
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_declare_queryable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_declare_queryable(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_closure_query_t* callback, z_queryable_options_t* options);

        /// <summary>
        ///  Undeclares a `z_owned_queryable_t` and drops it.
        ///
        ///  Returns 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_undeclare_queryable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_undeclare_queryable(z_moved_queryable_t* this_);

        /// <summary>
        ///  Frees memory and resets queryable to its gravestone state.
        ///  The callback closure is not dropped, and thus the queries continue to be served until the corresponding session is closed.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_queryable_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_queryable_drop(z_moved_queryable_t* this_);

        /// <summary>
        ///  Returns ``true`` if queryable is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_queryable_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_queryable_check(z_owned_queryable_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns the ID of the queryable.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_queryable_id", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_entity_global_id_t z_queryable_id(z_loaned_queryable_t* queryable);

        /// <summary>
        ///  Sends a reply to a query.
        ///
        ///  This function must be called inside of a Queryable callback passing the
        ///  query received as parameters of the callback function. This function can
        ///  be called multiple times to send multiple replies to a query. The reply
        ///  will be considered complete when the Queryable callback returns.
        ///
        ///  @param this_: The query to reply to.
        ///  @param key_expr: The key of this reply.
        ///  @param payload: The payload of this reply. Will be consumed.
        ///  @param options: The options of this reply. All owned fields will be consumed.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_query_reply(z_loaned_query_t* @this, z_loaned_keyexpr_t* key_expr, z_moved_bytes_t* payload, z_query_reply_options_t* options);

        /// <summary>
        ///  Sends a error reply to a query.
        ///
        ///  This function must be called inside of a Queryable callback passing the
        ///  query received as parameters of the callback function. This function can
        ///  be called multiple times to send multiple replies to a query. The reply
        ///  will be considered complete when the Queryable callback returns.
        ///
        ///  @param this_: The query to reply to.
        ///  @param payload: The payload carrying error message. Will be consumed.
        ///  @param options: The options of this reply. All owned fields will be consumed.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply_err", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_query_reply_err(z_loaned_query_t* @this, z_moved_bytes_t* payload, z_query_reply_err_options_t* options);

        /// <summary>
        ///  Sends a delete reply to a query.
        ///
        ///  This function must be called inside of a Queryable callback passing the
        ///  query received as parameters of the callback function. This function can
        ///  be called multiple times to send multiple replies to a query. The reply
        ///  will be considered complete when the Queryable callback returns.
        ///
        ///  @param this: The query to reply to.
        ///  @param key_expr: The key of this delete reply.
        ///  @param options: The options of this delete reply. All owned fields will be consumed.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_reply_del", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_query_reply_del(z_loaned_query_t* @this, z_loaned_keyexpr_t* key_expr, z_query_reply_del_options_t* options);

        /// <summary>
        ///  Gets query key expression.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_query_keyexpr(z_loaned_query_t* this_);

        /// <summary>
        ///  Gets query &lt;a href="https://github.com/eclipse-zenoh/roadmap/tree/main/rfcs/ALL/Selectors"&gt;value selector&lt;/a&gt;.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_parameters", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_query_parameters(z_loaned_query_t* @this, MaybeUninit* parameters);

        /// <summary>
        ///  Gets query &lt;a href="https://github.com/eclipse-zenoh/roadmap/blob/main/rfcs/ALL/Query%20Payload.md"&gt;payload&lt;/a&gt;.
        ///
        ///  Returns NULL if query does not contain a payload.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_payload", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_query_payload(z_loaned_query_t* this_);

        /// <summary>
        ///  Gets query &lt;a href="https://github.com/eclipse-zenoh/roadmap/blob/main/rfcs/ALL/Query%20Payload.md"&gt;payload encoding&lt;/a&gt;.
        ///
        ///  Returns NULL if query does not contain an encoding.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_encoding", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_encoding_t* z_query_encoding(z_loaned_query_t* this_);

        /// <summary>
        ///  Gets query attachment.
        ///
        ///  Returns NULL if query does not contain an attachment.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_query_attachment", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_query_attachment(z_loaned_query_t* this_);

        /// <summary>
        ///  Constructs a querying subscriber in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_querying_subscriber_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_internal_querying_subscriber_null(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs the default value for `ze_querying_subscriber_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_querying_subscriber_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_querying_subscriber_options_default(MaybeUninit* @this);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs and declares a querying subscriber for a given key expression.
        ///
        ///  @param this_: An uninitialized memory location where querying subscriber will be constructed.
        ///  @param session: A Zenoh session.
        ///  @param key_expr: A key expression to subscribe to.
        ///  @param callback: The callback function that will be called each time a data matching the subscribed expression is received.
        ///  @param options: Additional options for the querying subscriber.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_declare_querying_subscriber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_declare_querying_subscriber(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_closure_sample_t* callback, ze_querying_subscriber_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Make querying subscriber perform an additional query on a specified selector.
        ///  The queried samples will be merged with the received publications and made available in the subscriber callback.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_querying_subscriber_get", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_querying_subscriber_get(ze_loaned_querying_subscriber_t* @this, z_loaned_keyexpr_t* selector, z_get_options_t* options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Undeclares the given querying subscriber, drops it and resets to a gravestone state.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_undeclare_querying_subscriber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_undeclare_querying_subscriber(ze_moved_querying_subscriber_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Drops querying subscriber.
        ///  The callback closure is not dropped, and thus the queries continue to be served until the corresponding session is closed.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_querying_subscriber_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_querying_subscriber_drop(ze_moved_querying_subscriber_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns ``true`` if querying subscriber is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_querying_subscriber_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ze_internal_querying_subscriber_check(ze_owned_querying_subscriber_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Borrows querying subscriber.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_querying_subscriber_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ze_loaned_querying_subscriber_t* ze_querying_subscriber_loan(ze_owned_querying_subscriber_t* @this);

        /// <summary>
        ///  Frees memory and resets hello message to its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_hello_drop(z_moved_hello_t* this_);

        /// <summary>
        ///  Borrows hello message.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_hello_t* z_hello_loan(z_owned_hello_t* this_);

        /// <summary>
        ///  Returns ``true`` if `hello message` is valid, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_hello_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_hello_check(z_owned_hello_t* this_);

        /// <summary>
        ///  Constructs hello message in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_hello_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_hello_null(MaybeUninit* this_);

        /// <summary>
        ///  Constructs an owned copy of hello message.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_hello_clone(MaybeUninit* dst, z_loaned_hello_t* this_);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Returns id of Zenoh entity that transmitted hello message.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_zid", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_id_t z_hello_zid(z_loaned_hello_t* this_);

        /// <summary>
        ///  Returns type of Zenoh entity that transmitted hello message.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_whatami", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_whatami_t z_hello_whatami(z_loaned_hello_t* this_);

        /// <summary>
        ///  Constructs an array of non-owned locators (in the form non-null-terminated strings) of Zenoh entity that sent hello message.
        ///
        ///  The lifetime of locator strings is bound to `this_`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_hello_locators", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_hello_locators(z_loaned_hello_t* @this, MaybeUninit* locators_out);

        /// <summary>
        ///  Constructs the default values for the scouting operation.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_scout_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_scout_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Scout for routers and/or peers.
        ///
        ///  @param config: A set of properties to configure scouting session.
        ///  @param callback: A closure that will be called on each hello message received from discoverd Zenoh entities.
        ///  @param options: A set of scouting options
        ///
        ///  @return 0 if successful, negative error values upon failure.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_scout", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_scout(z_moved_config_t* config, z_moved_closure_hello_t* callback, z_scout_options_t* options);

        /// <summary>
        ///  Constructs a non-owned non-null-terminated string from the kind of zenoh entity.
        ///
        ///  The string has static storage (i.e. valid until the end of the program).
        ///  @param whatami: A whatami bitmask of zenoh entity kind.
        ///  @param str_out: An uninitialized memory location where strring will be constructed.
        ///  @param len: Maximum number of bytes that can be written to the `buf`.
        ///
        ///  @return 0 if successful, negative error values if whatami contains an invalid bitmask.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_whatami_to_view_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_whatami_to_view_string(z_whatami_t whatami, MaybeUninit* str_out);

        /// <summary>
        ///  @brief Constructs a serializer with empty payload.
        ///  @param this_: An uninitialized memory location where serializer is to be constructed.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_serializer_empty(MaybeUninit* @this);

        /// <summary>
        ///  @brief Drops `this_`, resetting it to gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_drop(ze_moved_serializer_t* this_);

        /// <summary>
        ///  @brief Returns ``true`` if `this_` is in a valid state, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_serializer_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ze_internal_serializer_check(ze_owned_serializer_t* @this);

        /// <summary>
        ///  @brief Borrows serializer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ze_loaned_serializer_t* ze_serializer_loan(ze_owned_serializer_t* @this);

        /// <summary>
        ///  @brief Muatably borrows serializer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ze_loaned_serializer_t* ze_serializer_loan_mut(ze_owned_serializer_t* @this);

        /// <summary>
        ///  @brief Constructs a serializer in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_internal_serializer_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_internal_serializer_null(MaybeUninit* this_);

        /// <summary>
        ///  @brief Drop serializer and extract underlying `bytes` object it was writing to.
        ///  @param this_: A serializer instance.
        ///  @param bytes: An uninitialized memory location where `bytes` object` will be written to.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_finish", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_finish(ze_moved_serializer_t* @this, MaybeUninit* bytes);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_uint8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_uint8(MaybeUninit* this_, byte val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_uint16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_uint16(MaybeUninit* this_, ushort val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_uint32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_uint32(MaybeUninit* this_, uint val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_uint64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_uint64(MaybeUninit* this_, ulong val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_int8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_int8(MaybeUninit* this_, sbyte val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_int16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_int16(MaybeUninit* this_, short val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_int32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_int32(MaybeUninit* this_, int val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_int64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_int64(MaybeUninit* this_, long val);

        /// <summary>
        ///  @brief Serializes a float.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_float", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_float(MaybeUninit* this_, float val);

        /// <summary>
        ///  @brief Serializes a double.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_double", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_double(MaybeUninit* this_, double val);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_uint8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_uint8(z_loaned_bytes_t* @this, byte* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_uint16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_uint16(z_loaned_bytes_t* @this, ushort* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_uint32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_uint32(z_loaned_bytes_t* @this, uint* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_uint64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_uint64(z_loaned_bytes_t* @this, ulong* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_int8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_int8(z_loaned_bytes_t* @this, sbyte* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_int16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_int16(z_loaned_bytes_t* @this, short* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_int32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_int32(z_loaned_bytes_t* @this, int* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_int64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_int64(z_loaned_bytes_t* @this, long* dst);

        /// <summary>
        ///  @brief Deserializes into a float.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_float", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_float(z_loaned_bytes_t* @this, float* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_double", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_double(z_loaned_bytes_t* @this, double* dst);

        /// <summary>
        ///  @brief Serializes a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_slice(MaybeUninit* @this, z_loaned_slice_t* slice);

        /// <summary>
        ///  @brief Serializes a data from buffer by.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param data: A pointer to the buffer containing data.
        ///  @param len: Length of the buffer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_buf(MaybeUninit* @this, byte* data, nuint len);

        /// <summary>
        ///  @brief Deserializes into a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_slice(z_loaned_bytes_t* @this, MaybeUninit* slice);

        /// <summary>
        ///  @brief Serializes a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_string(MaybeUninit* @this, z_loaned_string_t* str);

        /// <summary>
        ///  @brief Serializes a null-terminated string.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param str: a pointer to the null-terminated string.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serialize_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serialize_str(MaybeUninit* @this, byte* str);

        /// <summary>
        ///  @brief Deserializes into a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserialize_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserialize_string(z_loaned_bytes_t* @this, MaybeUninit* str);

        /// <summary>
        ///  @brief Gets deserializer for`this_`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_from_bytes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ze_deserializer_t ze_deserializer_from_bytes(z_loaned_bytes_t* @this);

        /// <summary>
        ///  @brief Checks if deserializer parsed all of its data.
        ///  @return `true` if there is no more data to parse, `false` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_is_done", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool ze_deserializer_is_done(ze_deserializer_t* this_);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_uint8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_uint8(ze_loaned_serializer_t* this_, byte val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_uint16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_uint16(ze_loaned_serializer_t* this_, ushort val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_uint32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_uint32(ze_loaned_serializer_t* this_, uint val);

        /// <summary>
        ///  @brief Serializes an unsigned integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_uint64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_uint64(ze_loaned_serializer_t* this_, ulong val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_int8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_int8(ze_loaned_serializer_t* this_, sbyte val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_int16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_int16(ze_loaned_serializer_t* this_, short val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_int32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_int32(ze_loaned_serializer_t* this_, int val);

        /// <summary>
        ///  @brief Serializes a signed integer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_int64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_int64(ze_loaned_serializer_t* this_, long val);

        /// <summary>
        ///  @brief Serializes a float.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_float", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_float(ze_loaned_serializer_t* this_, float val);

        /// <summary>
        ///  @brief Serializes a double.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_double", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_double(ze_loaned_serializer_t* this_, double val);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_uint8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_uint8(ze_deserializer_t* @this, byte* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_uint16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_uint16(ze_deserializer_t* @this, ushort* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_uint32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_uint32(ze_deserializer_t* @this, uint* dst);

        /// <summary>
        ///  @brief Deserializes into an unsigned integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_uint64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_uint64(ze_deserializer_t* @this, ulong* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_int8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_int8(ze_deserializer_t* @this, sbyte* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_int16", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_int16(ze_deserializer_t* @this, short* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_int32", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_int32(ze_deserializer_t* @this, int* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_int64", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_int64(ze_deserializer_t* @this, long* dst);

        /// <summary>
        ///  @brief Deserializes into a float.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_float", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_float(ze_deserializer_t* @this, float* dst);

        /// <summary>
        ///  @brief Deserializes into a signed integer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_double", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_double(ze_deserializer_t* @this, double* dst);

        /// <summary>
        ///  @brief Serializes a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_slice(ze_loaned_serializer_t* @this, z_loaned_slice_t* slice);

        /// <summary>
        ///  @brief Serializes a data from buffer.
        ///  @param this_: A serializer instance.
        ///  @param data: A pointer to the buffer containing data.
        ///  @param len: Length of the buffer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_buf(ze_loaned_serializer_t* @this, byte* data, nuint len);

        /// <summary>
        ///  @brief Deserializes into a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_slice(ze_deserializer_t* @this, MaybeUninit* slice);

        /// <summary>
        ///  @brief Serializes a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_string(ze_loaned_serializer_t* @this, z_loaned_string_t* str);

        /// <summary>
        ///  @brief Serializes a null-terminated string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_str(ze_loaned_serializer_t* @this, byte* str);

        /// <summary>
        ///  @brief Deserializes into a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_string(ze_deserializer_t* @this, MaybeUninit* str);

        /// <summary>
        ///  @brief Initiates serialization of a sequence of multiple elements.
        ///  @param this_: A serializer instance.
        ///  @param len: Length of the sequence. Could be read during deserialization using `ze_deserializer_deserialize_sequence_length`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_serializer_serialize_sequence_length", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ze_serializer_serialize_sequence_length(ze_loaned_serializer_t* @this, nuint len);

        /// <summary>
        ///  @brief Initiates deserialization of a sequence of multiple elements.
        ///  @param this_: A serializer instance.
        ///  @param len:  pointer where the length of the sequence (previously passed via `z_bytes_writer_serialize_sequence_begin`) will be written.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "ze_deserializer_deserialize_sequence_length", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte ze_deserializer_deserialize_sequence_length(ze_deserializer_t* @this, nuint* len);

        /// <summary>
        ///  Borrows session.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_session_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_session_t* z_session_loan(z_owned_session_t* this_);

        /// <summary>
        ///  Constructs a Zenoh session in its gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_session_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_session_null(MaybeUninit* this_);

        /// <summary>
        ///  Constructs the default value for `z_open_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_open_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_open_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs and opens a new Zenoh session.
        ///
        ///  @return 0 in case of success, negative error code otherwise (in this case the session will be in its gravestone state).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_open", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_open(MaybeUninit* @this, z_moved_config_t* config, z_open_options_t* _options);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Constructs and opens a new Zenoh session with specified client storage.
        ///
        ///  @return 0 in case of success, negative error code otherwise (in this case the session will be in its gravestone state).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_open_with_custom_shm_clients", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_open_with_custom_shm_clients(MaybeUninit* @this, z_moved_config_t* config, z_loaned_shm_client_storage_t* shm_clients);

        /// <summary>
        ///  Returns ``true`` if `session` is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_session_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_session_check(z_owned_session_t* this_);

        /// <summary>
        ///  Constructs the default value for `z_close_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_close_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_close_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Closes and drops a zenoh session. This also drops all the closure callbacks remaining from dropped (but not undeclared subscribers).
        ///
        ///  @return 0 in  case of success, a negative value if an error occured while closing the session.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_close", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_close(z_moved_session_t* session, z_close_options_t* _options);

        /// <summary>
        ///  Frees memory and invalidates the session.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_session_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_session_drop(z_moved_session_t* this_);

        /// <summary>
        ///  Constructs a subscriber in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_subscriber_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_subscriber_null(MaybeUninit* this_);

        /// <summary>
        ///  Borrows subscriber.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_subscriber_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_subscriber_t* z_subscriber_loan(z_owned_subscriber_t* this_);

        /// <summary>
        ///  Constructs the default value for `z_subscriber_options_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_subscriber_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_subscriber_options_default(MaybeUninit* this_);

        /// <summary>
        ///  Constructs and declares a subscriber for a given key expression. Dropping subscriber
        ///
        ///  @param this_: An uninitialized location in memory, where subscriber will be constructed.
        ///  @param session: The zenoh session.
        ///  @param key_expr: The key expression to subscribe.
        ///  @param callback: The callback function that will be called each time a data matching the subscribed expression is received.
        ///  @param options: The options to be passed to the subscriber declaration.
        ///
        ///  @return 0 in case of success, negative error code otherwise (in this case subscriber will be in its gravestone state).
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_declare_subscriber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_declare_subscriber(MaybeUninit* @this, z_loaned_session_t* session, z_loaned_keyexpr_t* key_expr, z_moved_closure_sample_t* callback, z_subscriber_options_t* _options);

        /// <summary>
        ///  Returns the key expression of the subscriber.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_subscriber_keyexpr", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_keyexpr_t* z_subscriber_keyexpr(z_loaned_subscriber_t* subscriber);

        /// <summary>
        ///  Undeclares and drops subscriber.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_undeclare_subscriber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_undeclare_subscriber(z_moved_subscriber_t* this_);

        /// <summary>
        ///  Drops subscriber and resets it to its gravestone state.
        ///  The callback closure is not dropped and still keeps receiving and processing samples until the corresponding session is closed.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_subscriber_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_subscriber_drop(z_moved_subscriber_t* this_);

        /// <summary>
        ///  Returns ``true`` if subscriber is valid, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_subscriber_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_subscriber_check(z_owned_subscriber_t* this_);

        /// <summary>
        ///  The gravestone value for `z_owned_bytes_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_bytes_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_bytes_null(MaybeUninit* @this);

        /// <summary>
        ///  Constructs an empty instance of `z_owned_bytes_t`.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_empty(MaybeUninit* @this);

        /// <summary>
        ///  Drops `this_`, resetting it to gravestone value. If there are any shallow copies
        ///  created by `z_bytes_clone()`, they would still stay valid.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_drop(z_moved_bytes_t* this_);

        /// <summary>
        ///  Returns ``true`` if `this_` is in a valid state, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_bytes_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_bytes_check(z_owned_bytes_t* @this);

        /// <summary>
        ///  Borrows data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_bytes_loan(z_owned_bytes_t* @this);

        /// <summary>
        ///  Muatably borrows data.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_t* z_bytes_loan_mut(z_owned_bytes_t* @this);

        /// <summary>
        ///  Returns ``true`` if `this_` is empty, ``false`` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_is_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_bytes_is_empty(z_loaned_bytes_t* @this);

        /// <summary>
        ///  Constructs an owned shallow copy of data in provided uninitialized memory location.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_clone(MaybeUninit* dst, z_loaned_bytes_t* @this);

        /// <summary>
        ///  Returns total number of bytes in the payload.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_len", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_bytes_len(z_loaned_bytes_t* @this);

        /// <summary>
        ///  Converts data into an owned non-null-terminated string.
        ///
        ///  @param this_: Data to convert.
        ///  @param dst: An uninitialized memory location where to construct a string.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_to_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_to_string(z_loaned_bytes_t* @this, MaybeUninit* dst);

        /// <summary>
        ///  Converts data into an owned slice.
        ///
        ///  @param this_: Data to convert.
        ///  @param dst: An uninitialized memory location where to construct a slice.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_to_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_to_slice(z_loaned_bytes_t* @this, MaybeUninit* dst);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Converts data into an owned SHM buffer by copying it's shared reference.
        ///
        ///  @param this_: Data to convert.
        ///  @param dst: An uninitialized memory location where to construct an SHM buffer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_to_owned_shm", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_to_owned_shm(z_loaned_bytes_t* @this, MaybeUninit* dst);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Converts data into a loaned SHM buffer.
        ///
        ///  @param this_: Data to convert.
        ///  @param dst: An uninitialized memory location where to construct an SHM buffer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_to_loaned_shm", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_to_loaned_shm(z_loaned_bytes_t* @this, MaybeUninit* dst);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Converts data into a mutably loaned SHM buffer.
        ///
        ///  @param this_: Data to convert.
        ///  @param dst: An uninitialized memory location where to construct an SHM buffer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_to_mut_loaned_shm", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_to_mut_loaned_shm(z_loaned_bytes_t* @this, MaybeUninit* dst);

        /// <summary>
        ///  Converts a slice into `z_owned_bytes_t`.
        ///  The slice is consumed upon function return.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_from_slice(MaybeUninit* @this, z_moved_slice_t* slice);

        /// <summary>
        ///  Converts a slice into `z_owned_bytes_t` by copying.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_copy_from_slice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_copy_from_slice(MaybeUninit* @this, z_loaned_slice_t* slice);

        /// <summary>
        ///  Converts buffer into `z_owned_bytes_t`.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param data: A pointer to the buffer containing data. `this_` will take ownership of the buffer.
        ///  @param len: Length of the buffer.
        ///  @param deleter: A thread-safe function, that will be called on `data` when `this_` is dropped. Can be `NULL` if `data` is located in static memory and does not require a drop.
        ///  @param context: An optional context to be passed to `deleter`.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_buf(MaybeUninit* @this, byte* data, nuint len, delegate* unmanaged[Cdecl]<void*, void*, void> deleter, void* context);

        /// <summary>
        ///  Converts a statically allocated constant buffer into `z_owned_bytes_t`.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param data: A pointer to the statically allocated constant data.
        ///  @param len: A length of the buffer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_static_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_static_buf(MaybeUninit* @this, byte* data, nuint len);

        /// <summary>
        ///  Converts a data from buffer into `z_owned_bytes_t` by copying.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param data: A pointer to the buffer containing data.
        ///  @param len: Length of the buffer.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_copy_from_buf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_copy_from_buf(MaybeUninit* @this, byte* data, nuint len);

        /// <summary>
        ///  Converts a string into `z_owned_bytes_t`.
        ///  The string is consumed upon function return.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_from_string(MaybeUninit* @this, z_moved_string_t* s);

        /// <summary>
        ///  Converts a string into `z_owned_bytes_t` by copying.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_copy_from_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_copy_from_string(MaybeUninit* @this, z_loaned_string_t* str);

        /// <summary>
        ///  Converts a null-terminated string into `z_owned_bytes_t`.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param str: a pointer to the string. `this_` will take ownership of the string.
        ///  @param deleter: A thread-safe function, that will be called on `str` when `this_` is dropped. Can be `NULL` if `str` is located in static memory and does not require a drop.
        ///  @param context: An optional context to be passed to `deleter`.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_str(MaybeUninit* @this, byte* str, delegate* unmanaged[Cdecl]<void*, void*, void> deleter, void* context);

        /// <summary>
        ///  Converts a statically allocated constant null-terminated string into `z_owned_bytes_t` by aliasing.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param str: a pointer to the statically allocated constant string.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_static_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_static_str(MaybeUninit* @this, byte* str);

        /// <summary>
        ///  Converts a null-terminated string into `z_owned_bytes_t` by copying.
        ///  @param this_: An uninitialized location in memory where `z_owned_bytes_t` is to be constructed.
        ///  @param str: a pointer to the null-terminated string.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_copy_from_str", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_copy_from_str(MaybeUninit* @this, byte* str);

        /// <summary>
        ///  Returns an iterator on raw bytes slices contained in the `z_loaned_bytes_t`.
        ///
        ///  Zenoh may store data in non-contiguous regions of memory, this iterator
        ///  then allows to access raw data directly without any attempt of deserializing it.
        ///  Please note that no guarantee is provided on the internal memory layout.
        ///  The only provided guarantee is on the bytes order that is preserved.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_get_slice_iterator", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_bytes_slice_iterator_t z_bytes_get_slice_iterator(z_loaned_bytes_t* @this);

        /// <summary>
        ///  Gets next slice.
        ///  @param this_: Slice iterator.
        ///  @param slice: An unitialized memory location where the view for the next slice will be constructed.
        ///  @return `false` if there are no more slices (in this case slice will stay unchanged), `true` otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_slice_iterator_next", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_bytes_slice_iterator_next(z_bytes_slice_iterator_t* @this, MaybeUninit* slice);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Converts from an immutable SHM buffer consuming it.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_shm", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_shm(MaybeUninit* @this, z_moved_shm_t* shm);

        /// <summary>
        ///  @warning This API has been marked as unstable: it works as advertised, but it may be changed in a future release.
        ///  @brief Converts a mutable SHM buffer consuming it.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_from_shm_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_from_shm_mut(MaybeUninit* @this, z_moved_shm_mut_t* shm);

        /// <summary>
        ///  Returns a reader for the data.
        ///
        ///  The `data` should outlive the reader.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_get_reader", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_bytes_reader_t z_bytes_get_reader(z_loaned_bytes_t* data);

        /// <summary>
        ///  Reads data into specified destination.
        ///
        ///  @param this_: Data reader to read from.
        ///  @param dst: Buffer where the read data is written.
        ///  @param len: Maximum number of bytes to read.
        ///  @return number of bytes read. If return value is smaller than `len`, it means that  theend of the data was reached.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_reader_read", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_bytes_reader_read(z_bytes_reader_t* @this, byte* dst, nuint len);

        /// <summary>
        ///  Sets the `reader` position indicator for the payload to the value pointed to by offset.
        ///  The new position is exactly `offset` bytes measured from the beginning of the payload if origin is `SEEK_SET`,
        ///  from the current reader position if origin is `SEEK_CUR`, and from the end of the payload if origin is `SEEK_END`.
        ///  @return ​0​ upon success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_reader_seek", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_reader_seek(z_bytes_reader_t* @this, long offset, int origin);

        /// <summary>
        ///  Gets the read position indicator.
        ///  @return read position indicator on success or -1L if failure occurs.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_reader_tell", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern long z_bytes_reader_tell(z_bytes_reader_t* this_);

        /// <summary>
        ///  Gets the number of bytes that can still be read.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_reader_remaining", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint z_bytes_reader_remaining(z_bytes_reader_t* this_);

        /// <summary>
        ///  @brief Constructs a data writer with empty payload.
        ///  @param this_: An uninitialized memory location where writer is to be constructed.
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_empty", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_writer_empty(MaybeUninit* @this);

        /// <summary>
        ///  Drops `this_`, resetting it to gravestone value.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_writer_drop(z_moved_bytes_writer_t* this_);

        /// <summary>
        ///  Returns ``true`` if `this_` is in a valid state, ``false`` if it is in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_bytes_writer_check", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool z_internal_bytes_writer_check(z_owned_bytes_writer_t* @this);

        /// <summary>
        ///  Borrows writer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_writer_t* z_bytes_writer_loan(z_owned_bytes_writer_t* @this);

        /// <summary>
        ///  Muatably borrows writer.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_loan_mut", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern z_loaned_bytes_writer_t* z_bytes_writer_loan_mut(z_owned_bytes_writer_t* @this);

        /// <summary>
        ///  Constructs a writer in a gravestone state.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_internal_bytes_writer_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_internal_bytes_writer_null(MaybeUninit* this_);

        /// <summary>
        ///  @brief Drop writer and extract underlying `bytes` object it was writing to.
        ///  @param this_: A writer instance.
        ///  @param bytes: An uninitialized memory location where `bytes` object` will be written to.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_finish", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void z_bytes_writer_finish(z_moved_bytes_writer_t* @this, MaybeUninit* bytes);

        /// <summary>
        ///  Writes `len` bytes from `src` into underlying data.
        ///
        ///  @return 0 in case of success, negative error code otherwise.
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_write_all", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_writer_write_all(z_loaned_bytes_writer_t* @this, byte* src, nuint len);

        /// <summary>
        ///  Appends bytes.     
        ///  This allows to compose a serialized data out of multiple `z_owned_bytes_t` that may point to different memory regions.
        ///  Said in other terms, it allows to create a linear view on different memory regions without copy.
        ///
        ///  @return 0 in case of success, negative error code otherwise
        /// </summary>
        [DllImport(__DllName, EntryPoint = "z_bytes_writer_append", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern sbyte z_bytes_writer_append(z_loaned_bytes_writer_t* @this, z_moved_bytes_t* bytes);


    }