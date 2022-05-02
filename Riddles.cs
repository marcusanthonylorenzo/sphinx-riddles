using System;

public class Riddles
{
  public static void Main()
  {
    Console.WriteLine("Would you like to battle the Sphinx?");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AskRiddles();
    }
    else {
      Console.WriteLine("You have no choice but to enter `y`.");
      Main();
    }
  }

  static void AskRiddles()
  {
    Console.WriteLine("I run all around the pasture but never move. What am I?");
      string riddleAnswer = Console.ReadLine().ToLower();
      if (riddleAnswer == "fence")
      {
        Console.WriteLine("Correct. You shall pass.");
        Console.WriteLine("What has roots as nobody sees, is taller than trees, up, up it goes, and yet never grows?");
        string riddleAnswer2 = Console.ReadLine().ToLower();
        if (riddleAnswer2 == "mountain")
        {
          Console.WriteLine("Correct. You shall pass.");
          Console.WriteLine("Voiceless it cries, wingless flutters, toothless bites, mouthless mutters.");
          string riddleAnswer3 = Console.ReadLine().ToLower();
          if (riddleAnswer3 == "wind")
          {
            Console.WriteLine("Correct. You have defeated the Sphinx!");
          } 
          else 
          {
            WrongAnswer();
          }
        } 
        else 
        {
          WrongAnswer();
        }
      } 
      else 
      {
        WrongAnswer();
      }
    
  }
  
  static void WrongAnswer()
  {
    Console.WriteLine("Incorrect.");
    Console.WriteLine("*User gets eaten.*");
    Main();
  }
}