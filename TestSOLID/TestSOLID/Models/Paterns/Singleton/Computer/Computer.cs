using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Singleton.Computer
{
    class Computer
    {
        public OS OS { get; set; }

        public void Lounch(string osName) {
            OS = OS.getInstance(osName);
        }
    }
}
