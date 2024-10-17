namespace ZenohFS
open System
open System.Runtime.InteropServices
open Microsoft.FSharp.NativeInterop
open Microsoft.FSharp.Core
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators
open Microsoft.FSharp.Primitives.Basics
open Microsoft.FSharp.Core.Operators

open System
open System.Diagnostics
open System.Runtime.InteropServices

module Types =
    
    [<Struct; StructLayout(LayoutKind.Sequential);>]
    type z_owned_bytes_t =
        val mutable _0 : byte
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_bytes_t() =
        member val _this = Unchecked.defaultof<z_owned_bytes_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_bytes_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_slice_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_slice_t() =
        member val _this = Unchecked.defaultof<z_owned_slice_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_view_slice_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_slice_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_string_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_string_t() =
        member val _this = Unchecked.defaultof<z_owned_string_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_view_string_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_string_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_string_array_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_string_array_t() =
        member val _this = Unchecked.defaultof<z_owned_string_array_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_string_array_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_sample_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_sample_t() =
        member val _this = Unchecked.defaultof<z_owned_sample_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_sample_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_bytes_reader_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_bytes_writer_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_bytes_writer_t() =
        member val _this = Unchecked.defaultof<z_owned_bytes_writer_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_bytes_writer_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_bytes_slice_iterator_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_encoding_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_encoding_t() =
        member val _this = Unchecked.defaultof<z_owned_encoding_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_encoding_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_reply_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_reply_t() =
        member val _this = Unchecked.defaultof<z_owned_reply_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_reply_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_reply_err_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_reply_err_t() =
        member val _this = Unchecked.defaultof<z_owned_reply_err_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_reply_err_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_query_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_query_t() =
        member val _this = Unchecked.defaultof<z_owned_query_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_query_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_queryable_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_queryable_t() =
        member val _this = Unchecked.defaultof<z_owned_queryable_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_queryable_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_keyexpr_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_keyexpr_t() =
        member val _this = Unchecked.defaultof<z_owned_keyexpr_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_view_keyexpr_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_keyexpr_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_session_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_session_t() =
        member val _this = Unchecked.defaultof<z_owned_session_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_session_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_config_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_config_t() =
        member val _this = Unchecked.defaultof<z_owned_config_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_config_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_timestamp_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_publisher_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_publisher_t() =
        member val _this = Unchecked.defaultof<z_owned_publisher_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_publisher_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_subscriber_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_subscriber_t() =
        member val _this = Unchecked.defaultof<z_owned_subscriber_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_subscriber_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_owned_hello_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_moved_hello_t() =
        member val _this = Unchecked.defaultof<z_owned_hello_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_loaned_hello_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_owned_serializer_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_moved_serializer_t() =
        member val _this = Unchecked.defaultof<ze_owned_serializer_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_loaned_serializer_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_deserializer_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_get_options_t() =
        member val target = Unchecked.defaultof<z_query_target_t> with get, set
        member val consolidation = Unchecked.defaultof<z_query_consolidation_t> with get, set
        member val payload = Unchecked.defaultof<obj> with get, set
        member val encoding = Unchecked.defaultof<obj> with get, set
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val allowed_destination = Unchecked.defaultof<zc_locality_t> with get, set
        member val accept_replies = Unchecked.defaultof<zc_reply_keyexpr_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        member val source_info = Unchecked.defaultof<obj> with get, set
        member val attachment = Unchecked.defaultof<obj> with get, set
        member val timeout_ms = Unchecked.defaultof<System.UInt64> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_query_consolidation_t() =
        member val mode = Unchecked.defaultof<z_consolidation_mode_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type zc_liveliness_declaration_options_t() =
        member val _dummy = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type zc_liveliness_subscriber_options_t() =
        [<MarshalAs>]
        member val history = Unchecked.defaultof<System.Boolean> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type zc_liveliness_get_options_t() =
        member val timeout_ms = Unchecked.defaultof<System.UInt32> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_publication_cache_options_t() =
        member val queryable_prefix = Unchecked.defaultof<obj> with get, set
        member val queryable_origin = Unchecked.defaultof<zc_locality_t> with get, set
        [<MarshalAs>]
        member val queryable_complete = Unchecked.defaultof<System.Boolean> with get, set
        member val history = Unchecked.defaultof<nuint> with get, set
        member val resources_limit = Unchecked.defaultof<nuint> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_publisher_options_t() =
        member val encoding = Unchecked.defaultof<obj> with get, set
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val reliability = Unchecked.defaultof<z_reliability_t> with get, set
        member val allowed_destination = Unchecked.defaultof<zc_locality_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_publisher_put_options_t() =
        member val encoding = Unchecked.defaultof<obj> with get, set
        member val timestamp = Unchecked.defaultof<obj> with get, set
        member val source_info = Unchecked.defaultof<obj> with get, set
        member val attachment = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_publisher_delete_options_t() =
        member val timestamp = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_put_options_t() =
        member val encoding = Unchecked.defaultof<obj> with get, set
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val timestamp = Unchecked.defaultof<obj> with get, set
        member val reliability = Unchecked.defaultof<z_reliability_t> with get, set
        member val allowed_destination = Unchecked.defaultof<zc_locality_t> with get, set
        member val source_info = Unchecked.defaultof<obj> with get, set
        member val attachment = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_delete_options_t() =
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val timestamp = Unchecked.defaultof<obj> with get, set
        member val reliability = Unchecked.defaultof<z_reliability_t> with get, set
        member val allowed_destination = Unchecked.defaultof<zc_locality_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_queryable_options_t() =
        [<MarshalAs>]
        member val complete = Unchecked.defaultof<System.Boolean> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_query_reply_options_t() =
        member val encoding = Unchecked.defaultof<obj> with get, set
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val timestamp = Unchecked.defaultof<obj> with get, set
        member val source_info = Unchecked.defaultof<obj> with get, set
        member val attachment = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_query_reply_err_options_t() =
        member val encoding = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_query_reply_del_options_t() =
        member val congestion_control = Unchecked.defaultof<z_congestion_control_t> with get, set
        member val priority = Unchecked.defaultof<z_priority_t> with get, set
        [<MarshalAs>]
        member val is_express = Unchecked.defaultof<System.Boolean> with get, set
        member val timestamp = Unchecked.defaultof<obj> with get, set
        member val source_info = Unchecked.defaultof<obj> with get, set
        member val attachment = Unchecked.defaultof<obj> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type ze_querying_subscriber_options_t() =
        member val allowed_origin = Unchecked.defaultof<zc_locality_t> with get, set
        member val query_selector = Unchecked.defaultof<obj> with get, set
        member val query_target = Unchecked.defaultof<z_query_target_t> with get, set
        member val query_consolidation = Unchecked.defaultof<z_query_consolidation_t> with get, set
        member val query_accept_replies = Unchecked.defaultof<zc_reply_keyexpr_t> with get, set
        member val query_timeout_ms = Unchecked.defaultof<System.UInt64> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_scout_options_t() =
        member val timeout_ms = Unchecked.defaultof<System.UInt64> with get, set
        member val what = Unchecked.defaultof<z_what_t> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_open_options_t() =
        member val _dummy = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_close_options_t() =
        member val _dummy = Unchecked.defaultof<System.Byte> with get, set
    [<Struct; StructLayout(LayoutKind.Sequential)>]
    type z_subscriber_options_t() =
        member val _0 = Unchecked.defaultof<System.Byte> with get, set
        
    type z_sample_kind_t =
        | PUT = 0u
        | DELETE = 1u
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_sample_kind_t : uint
{
    PUT = 0,
    DELETE = 1,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum zc_locality_t : uint
{
    ANY = 0,
    SESSION_LOCAL = 1,
    REMOTE = 2,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_reliability_t : uint
{
    BEST_EFFORT,
    RELIABLE,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum zc_reply_keyexpr_t : uint
{
    ANY = 0,
    MATCHING_QUERY = 1,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_query_target_t : uint
{
    BEST_MATCHING,
    ALL,
    ALL_COMPLETE,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_consolidation_mode_t : uint
{
    AUTO = -1,
    NONE = 0,
    MONOTONIC = 1,
    LATEST = 2,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_priority_t : uint
{
    REAL_TIME = 1,
    INTERACTIVE_HIGH = 2,
    INTERACTIVE_LOW = 3,
    DATA_HIGH = 4,
    DATA = 5,
    DATA_LOW = 6,
    BACKGROUND = 7,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_congestion_control_t : uint
{
    BLOCK,
    DROP,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_keyexpr_intersection_level_t : uint
{
    DISJOINT = 0,
    INTERSECTS = 1,
    INCLUDES = 2,
    EQUALS = 3,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_whatami_t : uint
{
    ROUTER = 1,
    PEER = 2,
    CLIENT = 4,
} *)
(* ERROR UnknownNode "EnumDeclarationSyntax" public enum z_what_t : uint
{
    ROUTER = 1,
    PEER = 2,
    CLIENT = 4,
    ROUTER_PEER,
    ROUTER_CLIENT,
    PEER_CLIENT,
    ROUTER_PEER_CLIENT,
} *)

type z_owned_session_t

module Imports =
    
    [<Literal>]
    let __DllName = "zenohc"
    
    [<DllImport(__DllName, EntryPoint = "z_session_loan", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)>]
    extern z_loaned_session_t* z_session_loan(z_owned_session_t*);
    
    [<DllImport(__DllName, EntryPoint = "z_internal_session_null", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)>]
    extern unit z_internal_session_null(nativeptr<z_owned_session_t> );

    [<DllImport(__DllName, EntryPoint = "z_open_options_default", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)>]
    extern void z_open_options_default(nativeptr<MaybeUninit> this_);

    [<DllImport(__DllName, EntryPoint = "z_open", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)>]
    extern sbyte z_open(nativeptr<z_owned_session_t> this_, nativeptr<z_moved_config_t> config, nativeptr<z_open_options_t> options);

module Session =
    

    
   
    
    type Session() =
        
        let session = 
        
        interface IDisposable with
            this.Dispose() = ()