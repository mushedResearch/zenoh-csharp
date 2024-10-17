#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace Zenoh;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_source_info_t
{
    public UInt64 span;
    public uint scope; 
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_source_info_t
{
    public z_owned_source_info_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_bytes_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_bytes_t
{
    public z_owned_bytes_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_bytes_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_slice_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_slice_t
{
    public z_owned_slice_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_view_slice_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_slice_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_string_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_string_t
{
    public z_owned_string_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_view_string_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_string_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_string_array_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_string_array_t
{
    public z_owned_string_array_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_string_array_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_sample_t
{
    public fixed byte _0[184];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_sample_t
{
    public z_owned_sample_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_sample_t
{
    public fixed byte _0[184];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_bytes_reader_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_bytes_writer_t
{
    public fixed byte _0[56];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_bytes_writer_t
{
    public z_owned_bytes_writer_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_bytes_writer_t
{
    public fixed byte _0[56];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_bytes_slice_iterator_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_encoding_t
{
    public fixed byte _0[40];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_encoding_t
{
    public z_owned_encoding_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_encoding_t
{
    public fixed byte _0[40];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_reply_t
{
    public fixed byte _0[184];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_reply_t
{
    public z_owned_reply_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_reply_t
{
    public fixed byte _0[184];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_reply_err_t
{
    public fixed byte _0[72];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_reply_err_t
{
    public z_owned_reply_err_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_reply_err_t
{
    public fixed byte _0[72];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_query_t
{
    public fixed byte _0[136];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_query_t
{
    public z_owned_query_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_query_t
{
    public fixed byte _0[136];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_queryable_t
{
    public fixed byte _0[16];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_queryable_t
{
    public z_owned_queryable_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_queryable_t
{
    public fixed byte _0[16];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_keyexpr_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_keyexpr_t
{
    public z_owned_keyexpr_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_view_keyexpr_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_keyexpr_t
{
    public fixed byte _0[32];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_session_t
{
    public fixed byte _0[8];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_session_t
{
    public z_owned_session_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_session_t
{
    public fixed byte _0[8];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_config_t
{
    public fixed byte _0[1728];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_config_t
{
    public z_owned_config_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_config_t
{
    public fixed byte _0[1728];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_timestamp_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_publisher_t
{
    public fixed byte _0[96];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_publisher_t
{
    public z_owned_publisher_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_publisher_t
{
    public fixed byte _0[96];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_subscriber_t
{
    public fixed byte _0[48];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_subscriber_t
{
    public z_owned_subscriber_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_subscriber_t
{
    public fixed byte _0[48];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_owned_hello_t
{
    public fixed byte _0[48];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_moved_hello_t
{
    public z_owned_hello_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_loaned_hello_t
{
    public fixed byte _0[48];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_owned_serializer_t
{
    public fixed byte _0[56];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_moved_serializer_t
{
    public ze_owned_serializer_t _this;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_loaned_serializer_t
{
    public fixed byte _0[56];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_deserializer_t
{
    public fixed byte _0[24];
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_get_options_t
{
    public z_query_target_t target;
    public z_query_consolidation_t consolidation;
    public z_moved_bytes_t* payload;
    public z_moved_encoding_t* encoding;
    public z_congestion_control_t congestion_control;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public zc_locality_t allowed_destination;
    public zc_reply_keyexpr_t accept_replies;
    public z_priority_t priority;
    public z_moved_source_info_t* source_info;
    public z_moved_bytes_t* attachment;
    public ulong timeout_ms;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_query_consolidation_t
{
    public z_consolidation_mode_t mode;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct zc_liveliness_declaration_options_t
{
    public byte _dummy;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct zc_liveliness_subscriber_options_t
{
    [MarshalAs(UnmanagedType.U1)] public bool history;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct zc_liveliness_get_options_t
{
    public uint timeout_ms;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_publication_cache_options_t
{
    public z_loaned_keyexpr_t* queryable_prefix;
    public zc_locality_t queryable_origin;
    [MarshalAs(UnmanagedType.U1)] public bool queryable_complete;
    public nuint history;
    public nuint resources_limit;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_publisher_options_t
{
    public z_moved_encoding_t* encoding;
    public z_congestion_control_t congestion_control;
    public z_priority_t priority;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public z_reliability_t reliability;
    public zc_locality_t allowed_destination;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_publisher_put_options_t
{
    public z_moved_encoding_t* encoding;
    public z_timestamp_t* timestamp;
    public z_moved_source_info_t* source_info;
    public z_moved_bytes_t* attachment;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_publisher_delete_options_t
{
    public z_timestamp_t* timestamp;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_put_options_t
{
    public z_moved_encoding_t* encoding;
    public z_congestion_control_t congestion_control;
    public z_priority_t priority;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public z_timestamp_t* timestamp;
    public z_reliability_t reliability;
    public zc_locality_t allowed_destination;
    public z_moved_source_info_t* source_info;
    public z_moved_bytes_t* attachment;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_delete_options_t
{
    public z_congestion_control_t congestion_control;
    public z_priority_t priority;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public z_timestamp_t* timestamp;
    public z_reliability_t reliability;
    public zc_locality_t allowed_destination;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_queryable_options_t
{
    [MarshalAs(UnmanagedType.U1)] public bool complete;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_query_reply_options_t
{
    public z_moved_encoding_t* encoding;
    public z_congestion_control_t congestion_control;
    public z_priority_t priority;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public z_timestamp_t* timestamp;
    public z_moved_source_info_t* source_info;
    public z_moved_bytes_t* attachment;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_query_reply_err_options_t
{
    public z_moved_encoding_t* encoding;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_query_reply_del_options_t
{
    public z_congestion_control_t congestion_control;
    public z_priority_t priority;
    [MarshalAs(UnmanagedType.U1)] public bool is_express;
    public z_timestamp_t* timestamp;
    public z_moved_source_info_t* source_info;
    public z_moved_bytes_t* attachment;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ze_querying_subscriber_options_t
{
    public zc_locality_t allowed_origin;
    public z_loaned_keyexpr_t* query_selector;
    public z_query_target_t query_target;
    public z_query_consolidation_t query_consolidation;
    public zc_reply_keyexpr_t query_accept_replies;
    public ulong query_timeout_ms;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_scout_options_t
{
    public ulong timeout_ms;
    public z_what_t what;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_open_options_t
{
    public byte _dummy;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_close_options_t
{
    public byte _dummy;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct z_subscriber_options_t
{
    public byte _0;
}


public enum z_sample_kind_t : uint
{
    PUT = 0,
    DELETE = 1,
}

public enum zc_locality_t : uint
{
    ANY = 0,
    SESSION_LOCAL = 1,
    REMOTE = 2,
}

public enum z_reliability_t : uint
{
    BEST_EFFORT,
    RELIABLE,
}

public enum zc_reply_keyexpr_t : uint
{
    ANY = 0,
    MATCHING_QUERY = 1,
}

public enum z_query_target_t : uint
{
    BEST_MATCHING,
    ALL,
    ALL_COMPLETE,
}

public enum z_consolidation_mode_t : uint
{
    AUTO = -1,
    NONE = 0,
    MONOTONIC = 1,
    LATEST = 2,
}

public enum z_priority_t : uint
{
    REAL_TIME = 1,
    INTERACTIVE_HIGH = 2,
    INTERACTIVE_LOW = 3,
    DATA_HIGH = 4,
    DATA = 5,
    DATA_LOW = 6,
    BACKGROUND = 7,
}

public enum z_congestion_control_t : uint
{
    BLOCK,
    DROP,
}

public enum z_keyexpr_intersection_level_t : uint
{
    DISJOINT = 0,
    INTERSECTS = 1,
    INCLUDES = 2,
    EQUALS = 3,
}

public enum z_whatami_t : uint
{
    ROUTER = 1,
    PEER = 2,
    CLIENT = 4,
}

public enum z_what_t : uint
{
    ROUTER = 1,
    PEER = 2,
    CLIENT = 4,
    ROUTER_PEER,
    ROUTER_CLIENT,
    PEER_CLIENT,
    ROUTER_PEER_CLIENT,
}

