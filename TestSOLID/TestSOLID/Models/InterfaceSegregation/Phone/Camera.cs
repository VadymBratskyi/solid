﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.InterfaceSegregation.Phone
{
    class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью фотокамеры");
        }
    }
}
