namespace csharp_basics
{
  class Student : Person
  {
    public override bool Verified { get; set; } = false;

    public override string Greeting(string signature = "Hello") => $"{signature}, I'm {FullName}! A student";

  }
}
