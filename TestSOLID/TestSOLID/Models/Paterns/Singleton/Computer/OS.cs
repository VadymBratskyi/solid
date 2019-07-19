using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Singleton.Computer
{
    class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        private static object locker = new object();

        protected OS(string name) {
            Name = name;
        }

        public static OS getInstance(string name) {
            if (instance == null) {
                lock (locker) {

                    if (instance == null) {
                        instance = new OS(name);
                    }
                }
                
            }
            return instance;
        }

    }
}
