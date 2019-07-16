using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.LiscovSubsitutions
{
    class Rectangle
    {
        public virtual int width { get; set; }
        public virtual int height { get; set; }
        public int GetArea() {
            return width * height;
        }
    }
}
