﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VncViewerLib
{
    public abstract class MessageBase
    {
        [MessageMember(0)]
        public byte MessageType { get; private set; }

        public MessageBase(byte messageType)
        {
            MessageType = messageType;
        }
    }
}
