using System;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        string a, b;
        bool trueFalse;
        static void Main(string[] args)
        {
            int menu, i, x;
            string a, text;
            int[] table = { 1, 3, 5, 7, 9, 11 };
            string[] data = { "Lubie", "placki", "ciotki", "zosi", "t", "co" };
            int[] table2 = new int[36];
            int[] table3 = new int[5];

            start:
            Console.WriteLine("Podaj wartość z menu, którą chcesz sprawdzić: \n" +
                "1. Wyyswietlanie napisu przy pomocy while \n"
                + "2. Uzupełnianie tablicy \n");
            menu = int.Parse(Console.ReadLine());
            
          //  Console.Clear();
          // przebudowac menu, sprawdzic indeksacje 
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ile razy chcesz wyswietlic podany napis: ");
                    a = Console.ReadLine();
                    i = int.Parse(a);
                    x = 0;
                    Console.WriteLine("Podaj napis");
                    text = Console.ReadLine();
                    Console.WriteLine("\n");
                    while (x < i)
                    {
                        Console.WriteLine(text);
                        x++;
                    }
                    goto start;

                case 2:
                    // do dokonczenia - testowania 
                    
                    Console.WriteLine("Podaj, do jakiej wartosci chcesz wypelnic tablice: ");
                    a = Console.ReadLine();
                    x = int.Parse(a);
                    for (i = 1; i < x; i++)
                    {
                        table[i] = i + 1;
                    }
                    Console.WriteLine("Czy chcesz wyswietlic zawartosc tablicy?  Y/N");
                    a = Console.ReadLine();
                    if (a == "y")
                    {
                        foreach (int item in table)
                            Console.WriteLine("To elementy tablicy {[]}", item);
                    }
                    else 
                    {
                        Console.WriteLine("To nie ");
                    }

                    goto start;

                case 3:
                    i = 0;
                    foreach (int item in table)
                    {
                        if (item < 5)
                            Console.WriteLine("Elementy mniejsze to: {0}", item);

                    }
                    break;

                case 4:
                    foreach (string item in data)
                    {
                        if (item.Length < 3)
                            Console.WriteLine(item);
                    }
                    break;

                case 5:
                    i = 0;
                    while (i < 5)
                    {
                        table3[i] = i++;
                    }
                    foreach (int item in table3)
                        Console.WriteLine("Elementy talbicy to: {0}", item);
                    break;
            }
            Console.ReadKey();
        }
    }
}

