using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.InterfaceSegregation.Message
{
    class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}
