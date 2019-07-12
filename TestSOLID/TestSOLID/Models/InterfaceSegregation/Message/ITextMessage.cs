using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.InterfaceSegregation.Message
{
    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}
