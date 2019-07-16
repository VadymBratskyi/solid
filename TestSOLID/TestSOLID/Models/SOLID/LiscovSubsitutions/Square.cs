using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.LiscovSubsitutions
{
    class Square : Rectangle
    {
        public override int width {

            get => base.width;

            set {
                base.height = value;
                base.width = value;
            }
        }

        public override int height {

            get => base.height;

            set {
                base.width = value;
                base.height = value;
            }
        }
    }
}
