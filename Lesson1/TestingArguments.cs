using System;

public class Class1
{
    public Testing_arguments()
    {
        {
            Add(2, 4);
            Console.ReadKey();
        }

        static void Add(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("wynikiem działania jest" + wynik);
        }
    }
}
