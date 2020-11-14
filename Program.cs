using System;
using System.Collections.Generic;

namespace csharp_basics
{
  class Program
  {
    static void Main(string[] args)
    {
      var john = new Student("John", "Doe");
      var niki = new Teacher("Niki", "Lauda");

      var people = new List<Person> { john, niki };

      foreach (var person in people)
      {
        //Console.WriteLine(person.Greeting());
        Console.WriteLine(person.Greeting());
        Console.WriteLine(person.VerifiedStatus);
        Console.WriteLine();
      }

      niki.Verified = true;
      Console.WriteLine($"Name: {niki.FullName}\nVerified Status: {niki.Verified}");
    }
  }
}
