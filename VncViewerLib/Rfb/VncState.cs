﻿namespace VncViewerLib
{
    public enum VncState
    {
        NotConnected,
        Connecting,
        Connected,
        Authenticating,
        Authenticated,
        Initializing,
        Initialized,
        ReceivingMessages,
        Disconnecting,
        Disconnected
    }
}
