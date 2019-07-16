using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.InterfaceSegregation.Message
{
    interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
    }
}
