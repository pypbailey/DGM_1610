 class Program
  {
    static void Main(string[] args)
    {
      for (int i = 20; i < 30; i++) 
      {
        Console.WriteLine(i);
      }    
    }
  }

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 10; i <= 20; i = i + 1)
      {
        Console.WriteLine(i);
      }    
    }
  }
}

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] fruits = {"Apple", "Banana", "Orange", "Strawberry"};
      Console.WriteLine(fruits[0]);
    }
  }
}
