using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.InterfaceSegregation.Phone
{
    class Phone : ICall, IPhoto, IVideo, IWeb
    {
        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }

        public void Call()
        {
            Console.WriteLine("Звоним");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью смартфона");
        }
    }
}
