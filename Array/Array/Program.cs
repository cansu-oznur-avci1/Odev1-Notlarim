using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] siparisNo = new string[3]; //3 tane memory ayırdık

            //siparisNo[0] = "INZ123";
            //siparisNo[1] = "GOOGLE2";
            //siparisNo[2] = "GOOGLE3";

            //siparisNo[0] = "INZ345"; //değiştirdik

            string[] siparisNo = { "birinciSiparis", "ikinciSiparis", "ucuncuSiparis" };
            //bu şekilde de array tanımlaması yapılabilir

            Console.WriteLine(siparisNo[1]); //ikinciSiparis

            Console.WriteLine(siparisNo.Length); //arrayin uzunluğuna ulaşabilirim

            foreach (string siparis in siparisNo) //dönmek istediğim tip, ismi, ve nereden alınacağı
            { 
                Console.WriteLine(siparis); //3 kere dönecek(stringleri yazacak)
            }


            int[] fiyat = { 250, 300, 700 };
            int toplamFiyat = 0;
            int say = 0;
            foreach(var tekilFiyat in fiyat)
            {
                toplamFiyat += tekilFiyat;
                say++; //döngüye kaç kez girdiyse onu sayacak.
            }

            Console.WriteLine(toplamFiyat + " "  + say);
            Console.ReadLine();
        }
    }
}
