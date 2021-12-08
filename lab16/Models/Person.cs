using System;

namespace Persons.Models{

    public class Person{
        public int? PersonID {get; set;}
        public string? Lastname {get; set;}
        public string? FirstName {get; set;}
        public DateTime? HireDate{get; set;}
        public DateTime? EnrollmentDate{get; set;}
    }
}