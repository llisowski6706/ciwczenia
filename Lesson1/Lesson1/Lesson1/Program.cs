using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Person
    {
        public int number;
        public string nickname;
       public override string ToString()
        {
            return "Pesel: " + number + "   Name: " + nickname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string choice, choiceMenu, personalId, deletePesel, deleteId;
            string[] autor = {"Przykladowa tablica z autorem: Lukasz" };
            List<String> name = new List<string>();
            List<String> autors = new List<string>();
            List<int> pesel = new List<int>();
            List<Person> person = new List<Person>();


            start:
            Console.WriteLine("Wybierz pozycje z menu: \n 1. Dodaj Pracownika \n 2.Usun pracownika \n 3. Wyswietl pracownikow \n 4. Wyszukaj pracownika");
            choiceMenu = Console.ReadLine();
            int a = int.Parse(choiceMenu);

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Podaj nazwę pracownika: \n");
                    personalId = Console.ReadLine();
                    name.Add(personalId);
                    start1:
                    Console.WriteLine("Podaj pierwsze 6 cyfr pesel pracownika \n");
                    choice = Console.ReadLine();
                    int peselInfo = choice.Length;
                    int choicePesel = int.Parse(choice);
                    if (peselInfo > 6)
                    {
                        Console.WriteLine("Za dlugi ciag cyfr \n");
                        goto start1;
                    }
                    else if (peselInfo == 6)
                    {
                        pesel.Add(choicePesel);
                        person.Add(new Person {nickname = personalId ,number = choicePesel });
                    }
                    goto start;

                case 2:
                    start2:
                    Console.WriteLine("Wpisz pesel pracownika");
                    deletePesel = Console.ReadLine();
                    int b = int.Parse(deletePesel);
                    foreach (int item in pesel)
                        if (item != b)
                        {
                            Console.WriteLine("Nie znaleziono numeru pesel\n");
                            goto start2;
                        }
                    Console.WriteLine("Wpisz nazwe pracownika");
                    deleteId = Console.ReadLine();
                    person.Remove(new Person {number = b, nickname = deleteId});
                    Console.WriteLine("Pracownik został usunięty");
                    /*Zastosowanie foreach
                     * foreach (int item in pesel)
                        if (item == b)
                        {
                            person.Remove
                            Console.WriteLine("Usunięto pesel pracownika");
                        }
                        else if (item != b)
                        {
                            Console.WriteLine("Nie znaleziono numeru pesel\n");
                            goto start2;
                        }
                    start3:
                    Console.WriteLine("Wpisz imie i nazwisko, ktore podałeś przy dodawaniu pracownika: ");
                    deleteId = Console.ReadLine();
                    foreach (string names in name)
                        if (names == deleteId)
                        {
                            name.Remove(deleteId);
                            Console.WriteLine("Usunięto nazwę pracownika");
                        }
                        else if (names != deleteId)
                        {
                            Console.WriteLine("Wprowadz poprawną nazwę pracownika");
                            goto start3; 
                        }*/
                    goto start;
                case 3:
                    /* BLEDNe ZALOZENIE foreach (int item in pesel)
                      {
                          Console.WriteLine(item);
                      }
                      foreach (string names in name)
                      {
                          Console.WriteLine(names);
                      }
                      Console.WriteLine("\n Obecnie posiadasz zarejestrowanych " + pesel.Count + "pracownikow");*/
                    foreach (Person aperson in person)
                    {
                        Console.WriteLine(aperson);
                    }
                    Console.WriteLine("Ilosc pracownikow to " + person.Count);
                    autors.AddRange(autor);
                    foreach (string creator in autors)
                        Console.WriteLine(creator);

                    goto start;
                case 4:
                    Console.WriteLine("Wyszukaj pracownika");
                    personalId = Console.ReadLine();
                    foreach (string item in name)
                        if (item == personalId)
                        {
                            Console.WriteLine("Taki pracownik istnieje");
                        }
                        else if (item != personalId)
                        {
                            Console.WriteLine("Taki pracownik nie istnieje");
                        }
                    goto start;
            }
        } 
    }
}


