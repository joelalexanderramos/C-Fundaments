using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    public class PeopleRepository
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Koening", StartDate = DateTime.Parse("10/17/1975"), Rating = 3 },
                new Person() { FirstName = "Dylan", LastName = "Hunt", StartDate = DateTime.Parse("10/17/1975"), Rating = 2 },
                new Person() { FirstName = "John", LastName = "Crichton", StartDate = DateTime.Parse("10/17/1975"), Rating =  4} ,
                new Person() { FirstName = "Dave", LastName = "Lister", StartDate = DateTime.Parse("10/17/1975"), Rating = 4 },
                new Person() { FirstName = "John", LastName = "Sheridan", StartDate = DateTime.Parse("10/17/1975"), Rating = 5 },
                new Person() { FirstName = "Dante", LastName = "Montana", StartDate = DateTime.Parse("10/17/1975"), Rating = 3 },
                new Person() { FirstName = "Isaac", LastName = "Gampu", StartDate = DateTime.Parse("10/17/1975"), Rating = 5 }
            };

            return people;
        }


    }
}
