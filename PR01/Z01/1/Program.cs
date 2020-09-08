using System;
using System.Threading;

namespace pr01_z1_1
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;
      public Person(string _firstName, string _lastName, int _age)
      {
        firstName = _firstName;
        lastName = _lastName; age = _age;
      }
      public override string ToString()
      {
        return firstName + " " + lastName + ", age " + age;
      }

    }

    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen ", 32); 
      
      Console.WriteLine(p);
      Console.WriteLine("Hello Mario!");
      double ton = 0.65f;
      double times = 0.65f; 
      Console.Beep((int)(ton * 659), (int)(times * 125));
      Console.Beep((int)(ton * 659), (int)(times * 125));
      Thread.Sleep((int)(times * 125));
      Console.Beep((int)(ton * 659), (int)(times * 125));
      Thread.Sleep(167);
      Console.Beep((int)(ton * 523), (int)(times * 125));
      Console.Beep((int)(ton * 659), (int)(times * 125));
      Thread.Sleep((int)(times * 125));
      Console.Beep((int)(ton * 784), (int)(times * 125));
      Thread.Sleep(375);
      Console.Beep((int)(ton * 392), (int)(times * 125));
      Thread.Sleep(375);
      Console.Beep((int)(ton * 523), (int)(times * 125));
      Thread.Sleep(250);
      Console.Beep((int)(ton * 392), (int)(times * 125));
      Thread.Sleep(250);
      Console.Beep((int)(ton * 330), (int)(times * 125));
      Thread.Sleep(250);
      Console.Beep((int)(ton * 440), (int)(times * 125));
      Thread.Sleep((int)(times * 125));
      Console.Beep((int)(ton * 494), (int)(times * 125));
      Thread.Sleep((int)(times * 125));
      Console.Beep((int)(ton * 466), (int)(times * 125));
    }
  }
}
