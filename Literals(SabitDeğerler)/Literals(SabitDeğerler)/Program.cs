using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals_SabitDeğerler_
{
    internal class Program
    {
        static int a; //default ta private olarak algılıyor
        static float b;
        static bool c; //true || false
        static string d;
        static void Main(string[] args)
        {
            a = 1; // static fonksiyonda static olmayan bir değere erişemem
            b = 1.1f; //float value da suffix(f) eklemem gerekiyor yoksa compiler hata veriyor
            c = true;
            d = "birden fazla karakter";

            Console.WriteLine("->int");
            Console.WriteLine(a); //şeklinde yazınca a literalini console a yazdırıcam
            Console.WriteLine(123); //Herhangi bir değişkene atamadan da integer değeri console a yazdırabilirim

            Console.WriteLine("\n->float");
            Console.WriteLine(b); //şeklinde yazınca b literalini console a yazdırıcam
            Console.WriteLine(4.0m); //Herhangi bir değişkene atamadan da float değerin sonuna 'm' ya da 'M' koyarak yazdırabilirm
            Console.WriteLine(4.5M);

            Console.WriteLine("\n->bool"); 
            Console.WriteLine(c); //şeklinde yazınca c literalini console a yazdırıcam
            Console.WriteLine(false); //Herhangi bi değişken tanımlamadan da boolean değeri console a yazdırabilrim

            Console.WriteLine("\n->string");
            Console.WriteLine(d); //şeklinde yazınca d literalini console a yazdırıcam
            Console.WriteLine("1"); //Herhangi bi değişken tanımlamadan da string değeri console a yazdırabilrim
            //Ancak string değer olarak 1 yazdırmakla integer değer olarak 1 yazdırmak farklı şeyler(operasyonlar yapılacaksa integer olarak tanımlamak gerekli)
            Console.ReadLine();
   
        }
    }
}
