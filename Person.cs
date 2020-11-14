using System.Collections.Generic;

namespace csharp_basics
{
  public abstract class Person
  {
    public Person(string firstName, string lastName, bool verified = false)
    {
      FirstName = firstName;
      LastName = lastName;
      Verified = verified;
    }

    public string FirstName { get; }

    public string LastName { get; }

    public bool Verified { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public string VerifiedStatus => $"Verified status: {Verified}";

    public abstract string Greeting(string signature = "Hi");
  }
}
