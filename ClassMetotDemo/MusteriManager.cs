using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (string Adi, string Soyadi, string KimlikNo)
        {
            Console.WriteLine(KimlikNo + " kimlik numaralı Sn." + Adi + " " + Soyadi + " sisteme eklenmiştir.");
        }

        public void MusteriSil(string Adi, string Soyadi, string KimlikNo)
        {
            Console.WriteLine(KimlikNo + " kimlik numaralı Sn." + Adi + " " + Soyadi + " sistemden silinmiştir.");
        }

    }
}
