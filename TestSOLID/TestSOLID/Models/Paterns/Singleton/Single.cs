using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Singleton
{
    class Single
    {
        private static Single instance;

        public Single() { }

        public static Single getInstance() {
            if (instance == null) {
                instance = new Single();
            }
            return instance;
        }
    }
}
