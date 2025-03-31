using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniClassOluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yeni inst = new Yeni(); //oluşturduğum classın instance ını oluşturup erişebilirim.

            inst.birinci = 20;
            inst.ikinci = 10;

            Console.WriteLine(inst.birinci + inst.ikinci); //bu şekilde ikisini ayrı ayrı da toplayabilirim

            Console.WriteLine(inst.toplama()); //ya da bu şekilde class içinde tanımladığım fonksiyonu da çağırabilirim.

            //10 un ikinci kuvveti
            Console.WriteLine("10 un 2. kuvveti = " + Math.Pow(10f,2f)); //Math te bir static fonksiyon Pow da üst alma için

            //en küçük değer
            Console.WriteLine("en küçük değer = " + Math.Min(20,10));

            //mutlak değer
            Console.WriteLine("mutlak değer = " + Math.Abs(-25.4f));

            Console.ReadLine(); //Console bir static class tır o yüzden onu instantiate etmeye gerek yok
            //Ama kendi ürettiğim static olmayan classı instantiate etmem gerekiyor.
        }

        class Yeni
        {
            public int birinci;
            public int ikinci;

            public int toplama()
            {
                return birinci + ikinci;
            }
        }
    }
}
