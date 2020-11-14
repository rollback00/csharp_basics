using System;
using System.Collections.Generic;

namespace csharp_basics
{
  class Program
  {
    static void Main(string[] args)
    {
      var students = new List<Student>();
      var teachers = new List<Teacher>();

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

      students.Add(john);
      students.Add(jane);

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

      teachers.Add(peter);
      teachers.Add(niki);


      foreach (var student in students)
      {
        Console.WriteLine(student.Greeting());
      }

      Console.WriteLine();

      foreach (var teacher in teachers)
      {
        Console.WriteLine(teacher.Greeting());
      }

      //var person = new Person();

    }
  }
}
