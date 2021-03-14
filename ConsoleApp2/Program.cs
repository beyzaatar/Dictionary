using Dictionary;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kullanicilar = new MyDictionary<int, string>();
            kullanicilar.Add(0, "Kerem ÖZER");
            kullanicilar.Add(1, "Ali RODOPLU");
            kullanicilar.Add(2, "Okan BİLİR");

            kullanicilar.Listele();
        }
    }
}
