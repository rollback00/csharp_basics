namespace csharp_basics
{
  class Student : Person
  {
    public Student(string firstName, string lastName, bool verified = true) : base(firstName, lastName, verified) {}

    public override string Greeting(string signature = "Hello") => $"{signature}, I'm {FullName}! A student";

  }
}
