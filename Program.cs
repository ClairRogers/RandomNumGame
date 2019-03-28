using System;

namespace randonum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to RandomGuess Number Game! What is your name?");
      string name = Console.ReadLine();
      System.Console.WriteLine($"Hello, {name}");
      Random randomTool = new Random();
      int ranNum = randomTool.Next(1, 101);
      bool playing = true;
      int tries = 0;
      while (playing)
      {
        // System.Console.WriteLine(ranNum);
        System.Console.WriteLine($"So far you have guessed {tries} tries(s)");
        tries++;
        Console.Write("Guess a number between 1 and 100: ");
        string strNum = Console.ReadLine();
        int num;
        if (Int32.TryParse(strNum, out num))
        {
          if (num > ranNum)
          {
            System.Console.WriteLine("Guess lower!");
          }
          else if (num < ranNum)
          {
            System.Console.WriteLine("Guess higher!");
          }
          else if (num == ranNum)
          {
            System.Console.WriteLine($"Congrats, you won! It only took {tries} guesses.");
            System.Console.WriteLine("Play again? (Press 'y' to continue and any other key to exit)");
            ConsoleKeyInfo decision = Console.ReadKey();
            if (decision.KeyChar == 'y')
            {
              tries = 0;
              ranNum = randomTool.Next(1, 101);
              Console.Clear();
            }
            else
            {
              playing = false;
            }
          }
        }
        else
        {
          System.Console.WriteLine("Please provide a valid number");
        }




      }
    }
  }
}
