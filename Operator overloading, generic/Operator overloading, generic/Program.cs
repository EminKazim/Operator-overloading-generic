using System;

namespace Operator_overloading__generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayItems<Person> people = new ArrayItems<Person>();
            people.Add(new Person("Hezret","Niftelizade", 25));
            people.Add(new Person("Reshad", "Qasimzade", 11));
            Person person2 = new Person("Sadiq", "Abdullayev", 9);
            people.Add(person2);
            Person person1 = new Person("Filankes", "Filankesov", 33);
            
            people.GetAll();

            Console.WriteLine(person1>person2);
        }
    }
}
