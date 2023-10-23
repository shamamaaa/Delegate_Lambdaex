using System;
using PersonTask24._10.Models;

namespace PersonTask24._10;
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Kamil", Surname = "Huseynov", Age = 25 },
            new Person { Name = "Shamama", Surname = "Quliyeva", Age = 19 },
            new Person { Name = "Sabuhi", Surname = "Camalzade", Age = 22 },
            new Person { Name = "Nermin", Surname = "Suleymanova", Age = 18 }
        };

        //Soyada baxan
        List<Person> checksurname = people.FindAll(n => n.Surname.EndsWith("ov") || n.Surname.EndsWith("ova"));
        Console.WriteLine("Soyadinda 'ov', 'ova' olanlar:");
        foreach (Person person in checksurname)
        {
            Console.WriteLine($"{person.Name} {person.Surname}");
        }

        Console.ReadLine();

        //Ada baxan
        Console.WriteLine("Axtardiginiz adi yazin:");
        string input = Console.ReadLine().Trim().ToLower();
        List<Person> checkname = people.FindAll(n => n.Name.Trim().ToLower() == input);
        Console.WriteLine($"Adi '{input}' olan adamlar:");
        foreach (Person person in checkname)
        {
            Console.WriteLine($"{person.Name} {person.Surname}");
        }

        Console.ReadLine();

        //Yasa baxan
        List<Person> checkage = people.FindAll(n => n.Age >=20);
        Console.WriteLine($"Yasi 20den boyuk adamlar:");
        foreach (Person person in checkage)
        {
            Console.WriteLine($"{person.Name} {person.Surname}");
        }

        Console.ReadLine();
    }
}

