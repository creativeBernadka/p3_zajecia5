using System;

namespace Polecenie2
{
    class Book
    {
        public string Title;
        public string Author;
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;
            int c = 10;
            Book[,,] warehouse = new Book[a,b,c];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        warehouse[i, j, k] = new Book("Potop", "Henryk Sienkiewicz");
                    }
                }
            }

            warehouse[1, 3, 7].Title = "Wiedzmin";
            warehouse[1, 3, 7].Author = "Andrzej Sapkowski";
            Console.WriteLine("Podaj szukana fraze:");
            string phrase = Console.ReadLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        if ((warehouse[i, j, k].Title == phrase) || (warehouse[i, j, k].Author.Contains(phrase)))
                        {
                            Console.WriteLine(
                                warehouse[i, j, k].Author + " " + warehouse[i, j, k].Title + 
                                "\n regal: " + (i+1) + " polka: " + (j+1) + " miejsce: " + (k+1)
                                );
                        };
                    }
                }
            }
        }
    }
}
