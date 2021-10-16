using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Actividad1.Repositories;
using Actividad1.Domain;
using System.Collections.Generic;

/* 
    Universidad Tecnológica Metropolitana
    Aplicaciones Web Orientadas a Objetos
    Docente: Chuc Uc Joel Ivan
    Actividad: Actividad 1
    Alumno: Daniel Francisco Puch Ceballos
    Cuatrimestre: 4
    Parcial: 1
    Grupo: A
*/

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [Route("Get/Person/All")]
        public IActionResult GetPersonAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonAll();
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("Get/Person/Fields")]
        public IActionResult GetPersonFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonFields();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/ById/{id}")]
        public IActionResult GetPersonById(int id)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonById(id);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/ByGender/{gender}")]
        public IActionResult GetPersonByGender(string gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonByGender(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/ByGenderAndAge/{gender}/{age}")]
        public IActionResult GetPersonByGenderAndAge(string gender, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonByGenderAndAge(gender, age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Diferences/PersonJob/{job}")]
        public IActionResult DiferencesPersonJob(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.DiferencesPersonJob(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Distinct/Job")]
        public IActionResult DistinctJob()
        {
            var repository = new PersonRepository();
            var persons = repository.DistinctJob();
            return Ok(persons);
        }

        [HttpGet]
        [Route("Contains/PersonFirstName/{contains}")]
        public IActionResult ContainsPersonFirstName(string contains)
        {
            var repository = new PersonRepository();
            var persons = repository.ContainsPersonFirstName(contains);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/ByAges/{agesString}")]
        public IActionResult GetPersonByAges(string agesString)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonByAges(agesString);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/RangeAge/{minAge}/{maxAge}")]
        public IActionResult GetPersonRangeAge(int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonRangeAge(minAge, maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/Ordered/{job}")]
        public IActionResult GetPersonOrdered(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonOrdered(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/OrderedDes/{job}")]
        public IActionResult GetPersonOrderedDescending(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonOrderedDescending(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Count/Person/ByGender/{gender}")]
        public IActionResult CountPersonByGender(string gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPersonByGender(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Exist/Person/{lastName}")]
        public IActionResult ExistPerson(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(lastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Get/Person/{id}")]
        public IActionResult GetPerson(int id)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(id);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Take/Person/ByJob/{job}/{take}")]
        public IActionResult TakePersonByJob(int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePersonByJob(take, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("TakeLast/Person/ByJob/{job}/{take}")]
        public IActionResult TakeLastPersonByJob(int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.TakeLastPersonByJob(take, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Skip/Person/ByJob/{job}/{skip}")]
        public IActionResult SkipPersonByJob(int skip, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPersonByJob(skip, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("SkipAndTake/Person/ByJob/{job}/{skip}/{take}")]
        public IActionResult SkipAndTakePersonByJob(int skip, int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipAndTakePersonByJob(skip, take, job);
            return Ok(persons);
        }
    }
}