using System;

public class Class1
{
    void CompariseNumber()
    {

        Console.WriteLine("Podaj pierwszą liczbę");
        a = Console.ReadLine();
        Console.WriteLine("Podaj druga liczbe");
        b = Console.ReadLine();

        int num1 = int.Parse(a);
        int num2 = int.Parse(b);

        if (num1 > num2)
        {
            Console.WriteLine("liczba wieksza to " + num1);
        }
        else if (num1 == num2)
        {
            Console.WriteLine("liczba " + a + "jest rowna liczbie " + b);
        }
        else
        {
            Console.WriteLine("liczba wieksza to " + num2);
        }
        Console.ReadKey();
    }
}
