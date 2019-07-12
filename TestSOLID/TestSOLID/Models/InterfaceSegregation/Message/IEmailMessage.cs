using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.InterfaceSegregation.Message
{
    interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
    }
}
