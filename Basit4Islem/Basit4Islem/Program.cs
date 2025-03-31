using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit4Islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplama = 58 + 55;
            int cıkarma = 58 - 55;
            int carpma = 58 * 55;
            int i_bolme = 58 / 55; //integer olduğu için bölmenin sonucundaki tam sayı kısmını gösterir.
            float f_bolme = 58f / 55; //float olduğu için tüm sonucu gösterir.(f yi en az birine(ikisine de koyabiliriz) eklemem gerekir aksi halde integerdaki gibi olur sonuç)
            Console.WriteLine("Toplam: " + toplama + "\nÇıkarma: " + cıkarma + "\nÇarpma: " + carpma + "\nİnteger Bölme: " + i_bolme +"\nFloat Bölme: "+f_bolme);

            int ilkSayi = 58;
            int ikinciSayi = 55;
            float bolme = (float)ilkSayi / ikinciSayi;//typecasting yaptık aksi halde integer olarak kabul eder.
            Console.WriteLine("Typecasting Bölme: "+bolme);

            int mod = ilkSayi % ikinciSayi; //mod alma
            Console.WriteLine("Mod: " + mod);

            //İşlem Önceliği --> () > Power > çarpma ve bölme soldan sağa > toplama ve çıkarma soldan sağa
            int ornek1 = 5 + 6 * 7; //5 + 42 = 47
            int ornek2 = (5 + 6) * 5; //11 * 5 = 55
            Console.WriteLine(ornek1);
            Console.WriteLine(ornek2);

            int ucuncuSayi = ilkSayi + 5; //(63)
            Console.WriteLine(ucuncuSayi);
            ucuncuSayi += 10; //ucuncuSayi = ucuncuSayi + 10 (73)
            Console.WriteLine(ucuncuSayi);
            ucuncuSayi -= 10; //(63)
            Console.WriteLine(ucuncuSayi);
            ucuncuSayi *= 2; //63*2 = 126
            Console.WriteLine(ucuncuSayi);
            ucuncuSayi /= 3; //126/3 = 42
            Console.WriteLine(ucuncuSayi);

            int dorduncuSayi = 5;
            dorduncuSayi++; //5+1
            Console.WriteLine(dorduncuSayi);
            dorduncuSayi--; //6-1
            Console.WriteLine(dorduncuSayi);
            Console.WriteLine(++dorduncuSayi); //şekinde de yazılabilir önce artır sonra yaz anlamında(önce: 6, sonra:6)
            Console.WriteLine(dorduncuSayi++); //bu şekilde olursa da önce yaz sonra artır anlamında(önce:6, sonra:7)
            Console.WriteLine(dorduncuSayi);
            Console.ReadLine();
        }
    }
}
