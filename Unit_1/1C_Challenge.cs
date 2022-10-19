{
  static void Main(string[] args)
    {
      string[] candy = {"Kitkat", "Snickers", "Skittles", "Reeces"};
      for (int i = 0; i < candy.Length; i++) 
      {
        Console.WriteLine(candy[i]);
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {1, 2, 3, 4};
      Console.WriteLine(myNumbers.Max());  // largest value
      Console.WriteLine(myNumbers.Min());  // smallest value
      Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
    }
  }
