namespace csharp_basics
{
  class Teacher : Person
  {
    public Teacher(string firstName, string lastName) : base(firstName, lastName) { }

    public override string Greeting(string signature = "Hello") => $"{signature}, I'm {FullName}! A teacher";

  }
}
