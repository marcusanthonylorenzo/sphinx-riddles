using System;

public class Riddles
{
  public static void Main()
  {
    Console.WriteLine("Would you like to battle the Sphinx?");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("I run all around the pasture but never move. What am I?");
      string riddleAnswer = Console.ReadLine().ToLower();
      if (riddleAnswer == "fence")
      {
        Console.WriteLine("Correct. You shall pass.");
      } else {
        Console.WriteLine("Incorrect.");
        Console.WriteLine("*User gets eaten.*");
      }
    }
    else {
      Console.WriteLine("You have no choice but to enter `y`.");
      Main();
    }
  }

}

/*
  What has roots as nobody sees,
  Is taller than trees,
  Up, up it goes,
  And yet never grows?

  - mountain
*/