using System;

namespace table_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "0";
            Console.WriteLine(nombre);
        }
        static void calculer(out string nombre){


            for (int n = 1; n <= 100; n++)
            {
                int total = n * 5;
                nombre = nombre + "," + total;
            }

        }


    }
}
