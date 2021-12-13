using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_overloading__generic
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname, int age)
        {
            Age = age;
            Name = name;
            Surname = surname;

        }
        public static bool operator >(Person person1, Person person2)
        {
            return person1.Age > person2.Age;
        }

        public static bool operator <(Person person1, Person person2)
        {
            return person1.Age < person2.Age;
        }
    }
}
