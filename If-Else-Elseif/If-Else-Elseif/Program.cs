using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20 ye kadar sayı olan bir zar
            // 15-20 araasında büyük zarar
            // 10-15 arasında orta boyut zarar
            // 5-10 zarar yok
            // 0-5 kendime zarar
            //4. veya 5. zar 18 üstünde gelirse, ek zarar vereceğiz

            Random zar = new Random(); //static olmayan bir fonksiyon olduğu için instantiate etmem gerek.

            int birinciAtis = zar.Next(1, 21); //Next() = belirli aralıkta sayı döndürüyor
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            Console.WriteLine(birinciAtis + " " + ikinciAtis + " " + ucuncuAtis + " " + dorduncuAtis + " " + besinciAtis);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis)/3f; //ilk üç sayının ortalaması

            if(ortalama > 15)
            {
                Console.WriteLine("Büyük Zarar Verdin");
            }else if (ortalama > 10 && ortalama <= 15)
            {
                Console.WriteLine("Orta Zarar Verdin");
            }else if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar Yok");
            }else if (ortalama <= 5 && ortalama > 2)
            {
                Console.WriteLine("Kendine Zarar Verdin");
            }
            else
            {
                Console.WriteLine("2 den küçük olduğunda çalışır.");
            }

            //Nested if örneği
            if(ortalama >= 10)
            {
                Console.WriteLine("Ortalama 10 un üzerinde");
                if(birinciAtis > 12)
                {
                    Console.WriteLine("Birinci atış 12 nin üzerinde");
                    if(ikinciAtis > 15)
                    {
                        Console.WriteLine("Nested if örneği");
                    }
                }
            }

            // or da kullanılabilir
            if ((dorduncuAtis >= 18 || besinciAtis >= 18))
            {
                Console.WriteLine("Ek Zarar Verdiniz");
            }








            Console.WriteLine(ortalama);
            Console.ReadLine();
        }
    }
}
