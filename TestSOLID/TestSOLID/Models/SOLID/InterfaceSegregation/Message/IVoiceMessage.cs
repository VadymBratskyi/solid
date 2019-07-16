using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.InterfaceSegregation.Message
{
    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}
