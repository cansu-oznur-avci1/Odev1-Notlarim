using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a" == "a"); //2 string karşılaştırması(bool)
            Console.WriteLine("b" == "B");
            Console.WriteLine(1.2f == 1.3f);

            int sayi = 5;
            Console.WriteLine(1 == sayi); //false
            Console.WriteLine(1 != sayi); //true

            string isim = "Cansu";
            Console.WriteLine(isim.Contains("Ca")); //belirtilen ifadeyi içeriyor mu

            //sayı 6 ise cansu yazsın değilse öznur yazsın
            Console.WriteLine(sayi == 5 ? "Cansu" : "Öznur");

            //doğruysa 1 yanlışsa 2 döndürsün
            Console.WriteLine(sayi >= 5 ? 1 : 2);
            Console.ReadLine();
        }
    }
}
