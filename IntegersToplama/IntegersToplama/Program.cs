using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegersToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birinci = 33;
            int ikinci = 22;
            Console.WriteLine(birinci + ikinci);//33+22 (55)

            Console.WriteLine(birinci + ikinci + " bir string"); //string ekleme (55 bir string)

            Console.WriteLine(birinci + " bir string " + ikinci); //(33 bir string 22)

            Console.WriteLine(birinci + " bir string " + ikinci + 10); //bu şekilde yapınca toplama işlemi yapmadı string toplar gibi yanına yazdı(33 bir string 2210)

            Console.WriteLine((birinci + 10) + " bir string " + ikinci + 10); //parantez içine alınca toplama yaptı(43 bir string 2210)
            Console.ReadLine();
        }
    }
}
