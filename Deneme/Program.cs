using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade1 = "ifade1";
            string ifade2 = "ifade2";
            string sabit = "kullanımı";

            OutKullan(out ifade1, sabit);
            Console.WriteLine(ifade1);
            Console.WriteLine("");
            Console.WriteLine("--------");
            RefKullan(ref ifade2, sabit);
            Console.WriteLine(ifade2);
        }

        static void OutKullan(out string a, string b)
        {
            a = "Out";
            Console.WriteLine(a + " " + b);
        }

        static void RefKullan(ref string c, string d)
        {
            Console.WriteLine(c + " " + d);
        }
    }
}
