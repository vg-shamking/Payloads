﻿using System;

namespace winPEAS.Info.UserInfo.SAM
{
    public enum DOMAIN_INFORMATION_CLASS
    {
        DomainPasswordInformation = 1,
    }

    [Flags]
    public enum PASSWORD_PROPERTIES
    {
        DOMAIN_PASSWORD_COMPLEX = 0x00000001,
        DOMAIN_PASSWORD_NO_ANON_CHANGE = 0x00000002,
        DOMAIN_PASSWORD_NO_CLEAR_CHANGE = 0x00000004,
        DOMAIN_LOCKOUT_ADMINS = 0x00000008,
        DOMAIN_PASSWORD_STORE_CLEARTEXT = 0x00000010,
        DOMAIN_REFUSE_PASSWORD_CHANGE = 0x00000020,
    }

    [Flags]
    public enum DOMAIN_ACCESS_MASK
    {
        DOMAIN_READ_PASSWORD_PARAMETERS = 0x00000001,
        DOMAIN_WRITE_PASSWORD_PARAMS = 0x00000002,
        DOMAIN_READ_OTHER_PARAMETERS = 0x00000004,
        DOMAIN_WRITE_OTHER_PARAMETERS = 0x00000008,
        DOMAIN_CREATE_USER = 0x00000010,
        DOMAIN_CREATE_GROUP = 0x00000020,
        DOMAIN_CREATE_ALIAS = 0x00000040,
        DOMAIN_GET_ALIAS_MEMBERSHIP = 0x00000080,
        DOMAIN_LIST_ACCOUNTS = 0x00000100,
        DOMAIN_LOOKUP = 0x00000200,
        DOMAIN_ADMINISTER_SERVER = 0x00000400,
        DOMAIN_ALL_ACCESS = 0x000F07FF,
        DOMAIN_READ = 0x00020084,
        DOMAIN_WRITE = 0x0002047A,
        DOMAIN_EXECUTE = 0x00020301
    }

    [Flags]
    public enum SERVER_ACCESS_MASK
    {
        SAM_SERVER_CONNECT = 0x00000001,
        SAM_SERVER_SHUTDOWN = 0x00000002,
        SAM_SERVER_INITIALIZE = 0x00000004,
        SAM_SERVER_CREATE_DOMAIN = 0x00000008,
        SAM_SERVER_ENUMERATE_DOMAINS = 0x00000010,
        SAM_SERVER_LOOKUP_DOMAIN = 0x00000020,
        SAM_SERVER_ALL_ACCESS = 0x000F003F,
        SAM_SERVER_READ = 0x00020010,
        SAM_SERVER_WRITE = 0x0002000E,
        SAM_SERVER_EXECUTE = 0x00020021
    }

    public enum NTSTATUS
    {
        STATUS_SUCCESS = 0x0,
        STATUS_MORE_ENTRIES = 0x105,
        STATUS_INVALID_HANDLE = unchecked((int)0xC0000008),
        STATUS_INVALID_PARAMETER = unchecked((int)0xC000000D),
        STATUS_ACCESS_DENIED = unchecked((int)0xC0000022),
        STATUS_OBJECT_TYPE_MISMATCH = unchecked((int)0xC0000024),
        STATUS_NO_SUCH_DOMAIN = unchecked((int)0xC00000DF),
    }
}
