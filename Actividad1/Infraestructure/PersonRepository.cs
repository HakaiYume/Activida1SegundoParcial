using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Actividad1.Domain;
using System.Threading.Tasks;

namespace Actividad1.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }
        public IEnumerable<Person> GetPersonAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }
        public IEnumerable<Object> GetPersonFields()
        {
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1).Year,
                Correo = person.Email
            });

            return query;
        }
        public IEnumerable<Person> GetPersonById(int id)
        {
            var query = _persons.Where(person => person.Id == id);
            return query;
        }

        public IEnumerable<Person> GetPersonByGender(string gender)
        {
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }

        public IEnumerable<Person> GetPersonByGenderAndAge(string gender, int age)
        {
            var query = _persons.Where(person => person.Gender == gender && person.Age == age);
            return query;
        }
        public IEnumerable<Person> DiferencesPersonJob(string job)
        {
            var query = _persons.Where(person => person.Job != job);
            return query;
        }
        public IEnumerable<string> DistinctJob()
        {            
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }
        public IEnumerable<Person> ContainsPersonFirstName(string contains)
        {            
            var query = _persons.Where(person => person.FirstName.Contains(contains));
            return query;
        }
        public IEnumerable<Person> GetPersonByAges(string agesString)
        {
            var ages = agesString.Split(',').Select(Int32.Parse).ToList();
            var query = _persons.Where(Person => ages.Contains(Person.Age));
            return query;
        }
        public IEnumerable<Person> GetPersonRangeAge(int minAge, int maxAge)
        {
            var query = _persons.Where(Person => Person.Age >= minAge && Person.Age <= maxAge);
            return query;
        }
        public IEnumerable<Person> GetPersonOrdered(string job)
        {
            var query = _persons.Where(person => person.Job == job).OrderBy(person => person.LastName);
            return query;
        }

        public IEnumerable<Person> GetPersonOrderedDescending(string job)
        {
            var query = _persons.Where(person => person.Job == job).OrderByDescending(person => person.LastName);
            return query;
        }
        public int CountPersonByGender(string gender)
        {
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }
        public bool ExistPerson(string lastName)
        {
            var query = _persons.Exists(person => person.LastName == lastName);
            return query;
        }
        public Person GetPerson(int id)
        {
            var query = _persons.FirstOrDefault(person => person.Id == id);
            return query;
        }
        public IEnumerable<Person> TakePersonByJob(int take, string job)
        {
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }
        public IEnumerable<Person> TakeLastPersonByJob(int take, string job)
        {
            var query = _persons.Where(person => person.Job == job).TakeLast(take);
            return query;
        }
        public IEnumerable<Person> SkipPersonByJob(int skip, string job)
        {
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }
        public IEnumerable<Person> SkipAndTakePersonByJob(int skip, int take, string job)
        {
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }
    }
}