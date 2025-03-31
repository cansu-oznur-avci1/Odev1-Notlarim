using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiOperasyonlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cm den inch e çevirme (1 inch = 2.54 cm)
            //m2 den sqfeet e çevirme (1 sqfeet = 0.092903 m2) (1 m2 = 10.764 sqfeet)
            //150 cm olan bir ağacım 1000m2 arazimde tek başına duruyor. (cümlesini çevirerek yazalım)


            int cm_amount = 150;
            int m2_amount = 1000;
            float cm_to_inch = (float)(cm_amount / 2.54); //150 /2.54 = 59,05511
            float m2_to_sqfeet = (float)(m2_amount / 0.092903); //1000/0.093 = 10.752,6881

            Console.WriteLine(cm_to_inch+" inch olan bir ağacım "+m2_to_sqfeet+" sqfeet arazimde tek başına duruyor.");
            Console.WriteLine((cm_amount / 2.54f) + " inch olan bir ağacım " + (m2_amount * 10.764f) + " sqfeet arazimde tek başına duruyor."); // 2. yol
            Console.ReadLine();
        }
    }
}
