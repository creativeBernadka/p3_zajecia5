using System;

namespace Polecenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] warehouse= new string[3,6,10];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        warehouse[i, j, k] = "Potop";
                    }
                }
            }

            warehouse[1, 3, 7] = "Wiedzmin";
            Console.WriteLine("Podaj szukany tytul:");
            string title = Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
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