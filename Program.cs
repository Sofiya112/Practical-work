using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        using System;

        class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Возраст: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Иван", "Иванов", 30);
            person1.DisplayInfo();
            Console.ReadKey();
        }

    }

    
}
