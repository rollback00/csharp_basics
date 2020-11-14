namespace csharp_basics
{
  public abstract class Person
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public abstract bool Verified { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public abstract string Greeting(string signature = "Hi");

  }
}
