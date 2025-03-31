using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ESCAPE CHARACTERS
            \n => newline
            \t => tab kadar boşluk
            \" => " yazdırmak için
            \' => ' yazdırmak için
            \\ => \ yazdırmak için
            @ => string olarak yazdırabilmek için
            \u1234 => unicode olarak yazdırmak için
            */

            Console.WriteLine("--1--");
            Console.WriteLine("Hello\nWorld");
            //Hello
            //World

            Console.WriteLine("--2--");
            Console.WriteLine("Hello\tWorld");
            //Hello     World

            Console.WriteLine("--3--");
            Console.WriteLine("\"Hello World\"");
            //"Hello World"

            Console.WriteLine("--4--");
            Console.WriteLine("c:\\users\\canoz\\appdata");
            Console.WriteLine(@"c:\users\canoz\appdata"); //2. yol
            //c:\users\canoz\appdata
            Console.ReadLine();
        }
    }
}
