﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection= methot enjekte etmek demektir.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuru bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
