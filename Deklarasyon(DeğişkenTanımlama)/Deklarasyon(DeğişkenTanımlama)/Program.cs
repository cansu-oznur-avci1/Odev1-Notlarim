using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deklarasyon_DeğişkenTanımlama_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ondalikUcBasamakliSayi; //camel case(ilk kelime küçük diğerleri büyük harfle başlar)
            float OndalikSayi; //pascal case(her kelime büyük harfle başlar)

            var impVal = true; //implicit(örtülü) decleration yaptık. Atadığımız değer(ilk değer) hangi türdeyse onu alıcak.
            //Sonradan farklı türde bir değer atamak istersem compiler hata verecek
            //kod içerisinde hangi veri tipine karşılık geldiğini karıştırmamak için çok tercih edilen bir yöntem değil

            string benimAdim; //string tanımı (#,$ işaretleri konulamaz)
            benimAdim = "Cansu";
            Console.WriteLine(benimAdim); //Cansu
            benimAdim = "Öznur"; //değiştirdik
            Console.WriteLine(benimAdim); //Öznur

            Console.WriteLine("\n" + impVal);
            Console.ReadLine();
        }
    }
}
