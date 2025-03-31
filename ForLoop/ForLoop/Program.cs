using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();// Her seferinde aç kapa yapmaması için loopun dışına yazdık


            //Array için
            string[] siparisNo =
            {
                "INZ001",
                "GOOGLE1",
                "APP01"
            };
        
            for (int i = siparisNo.Length-1; i>=0; i--)
            {
                Console.WriteLine(siparisNo[i]);
            }
            Console.ReadLine();// Her seferinde aç kapa yapmaması için loopun dışına yazdık


        }
    }
}
