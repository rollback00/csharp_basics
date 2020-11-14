using System;
using System.Collections.Generic;

namespace csharp_basics
{
  class Program
  {
    static void Main(string[] args)
    {
           var john = new Student
      {
        FirstName = "John",
        LastName = "Doe"
      };

      var jane = new Student
      {
        FirstName = "Jane",
        LastName = "Doe"
      };


      var peter = new Teacher
      {
        FirstName = "Peter",
        LastName = "Ayittah"
      };

      var niki = new Teacher
      {
        FirstName = "Niki",
        LastName = "Lauda"
      };

      var students = new List<Student> { john, jane };
      var teachers = new List<Teacher> { peter, niki };

      var people = new List<Person> { john, niki };


      foreach (var person in people)
      {
        Console.WriteLine(person.Greeting());
        Console.WriteLine();
      }
    }
  }
}
