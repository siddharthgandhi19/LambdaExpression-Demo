using LambdaExpression_Demo;
using System;
using System.Collections.Generic;

namespace LambdaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIs_LeaaThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("123654789", "Sid", "Bhopal", 25));
            listPersonInCity.Add(new Person("852654789", "Lalit", "Vdisha", 25));

            listPersonInCity.Add(new Person("741654789", "Arpit", "Bangalore", 28));

            listPersonInCity.Add(new Person("196654789", "Ajay", "Pune", 24));

            listPersonInCity.Add(new Person("893654789", "Raju", "Bhilai", 65));

            listPersonInCity.Add(new Person("135654789", "Agrim", "Varanasi", 13));

        }

        private static void Retrieving_TopTwoRecord_ForAgeIs_LeaaThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "Age: " + person.Age );
            }

        }

        private static void CheckingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
                    Console.WriteLine("Yes, We have some teen-agers in the list");
            else
                Console.WriteLine("No, We dont have any teen-agers in the list");
        }
    }
}