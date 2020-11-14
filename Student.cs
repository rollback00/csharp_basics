namespace csharp_basics
{
  class Student : Person, IPrint
  {
    public Student(string firstName, string lastName, bool verified = true) : base(firstName, lastName, verified) {}

    public override string Greeting(string signature = "Hello") => $"{signature}, I'm {FullName}! A student";

    string IPrint.Counter {get; set;}

  }
}
