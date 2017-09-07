using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    class Program
    {       
        static void Main(string[] args)
        {
            PeopleRepository peopleRepo = new PeopleRepository();

            //var people = peopleRepo.GetPeople();

            IEnumerable<Person> people;
            people = peopleRepo.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
