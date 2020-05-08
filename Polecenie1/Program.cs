using System;

namespace Polecenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;
            int c = 10;
            string[,,] warehouse= new string[a,b,c];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        warehouse[i, j, k] = "Potop";
                    }
                }
            }

            warehouse[1, 3, 7] = "Wiedzmin";
            Console.WriteLine("Podaj szukany tytul:");
            string title = Console.ReadLine();
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        if (warehouse[i, j, k] == title)
                        {
                            Console.WriteLine(title + " regal: " + (i+1) + " polka: " + (j+1) + " miejsce: " + (k+1));
                        };
                    }
                }
            }
        }
    }
}
