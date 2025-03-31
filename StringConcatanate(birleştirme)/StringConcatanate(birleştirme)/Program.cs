using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatanate_birleştirme_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birinci = "Öznur";
            string ikinci = "Cansu " + birinci; //+ işareti ile stringleri birleştirebilirim
            string ücüncü = "Cansu " + birinci + " " + "AVCI"; //birden fazla string de birleştirilebilir.
            Console.WriteLine(ücüncü);

            string dorduncu = $"{birinci} {ikinci} bunun dışında elle de yazılabiliyor."; //interpolation(ekleme)
            Console.WriteLine(dorduncu);

            string besinci = $@"c:\users\canoz\{ikinci}\appdata";
            Console.WriteLine(besinci);
            Console.ReadLine();
        }
    }
}
