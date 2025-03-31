using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console'a;
            Bu bir satırdır
            Bu da bir satırdır 
            şeklinde yazdır.
            */

            Console.WriteLine("Bu bir satırdır"); //1. Yol
            Console.WriteLine("Bu da bir satırdır");
            Console.Write("\nBu bir sonraki satırdır\n"); //2. Yol(Console.Write() şeklinde yazıp satırın sonuna '\n' koymak)
            Console.Write("Bu satır en alttadır\n");
            Console.ReadLine();
        }
    }
}
