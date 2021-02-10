using System;
using System.Collections;
using System.Collections.Generic;

namespace Cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Llista<int> pesel = new Llista<int>();
            int[] test = { 1, 2, 3 };
            pesel.Add(5);
            pesel.Add(1111111);
            //   pesel.Remove(5);
            a = pesel.Count();
            foreach (int item in pesel)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(a);
            pesel.AddRange(test);
            Console.WriteLine("------------------");
            foreach (int item in pesel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
    
