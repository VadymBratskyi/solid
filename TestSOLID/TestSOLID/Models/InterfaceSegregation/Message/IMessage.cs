﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.InterfaceSegregation
{
    interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
