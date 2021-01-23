using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
        //eğer birisi bu interfaceyi kullanırsa buranın içindeki fonksiyonu kullanmak zorundadır.
        //Interface= Şablon
        //interfaceleri birbirinin alternatifi ama kod içerikleri farklı olan methotlar-sınıf için kullanılır.
    {
        void Hesapla();
        void BirseyYap();
    }
}
