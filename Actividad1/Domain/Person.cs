using System;

namespace Actividad1.Domain
{
    public record Person(int Id, string FirstName, string LastName, string Email, string Gender, string Job, int Age);
}