using System;

namespace HelloApp
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("hello everyone");
      greetWhite();
      greetBlack();
    }
    
    public static void greetWhite()
    {
      Console.WriteLine("hello white");
    }
    
    public static void greetBlack()
    {
      Console.WriteLine("hello black");
    }
  }
}