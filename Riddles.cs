using System;
using System.Collections.Generic;
using System.Linq;

public class Riddles
{
  public static void Main()
  {
    Console.WriteLine("Would you like to battle the Sphinx? (y/n)");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AskRiddles();
    }
    else
    {
      Console.WriteLine("Goodbye");
    }
  }

  static void AskRiddles()
  {
    Random rand = new Random();
    Dictionary<string, string> riddleDictionary = new Dictionary<string, string> () { {"I run all around the pasture but never move. What am I?", "fence"}, {"What has roots as nobody sees, is taller than trees, up, up it goes, and yet never grows?", "mountain"}, {"Voiceless it cries, wingless flutters, toothless bites, mouthless mutters.", "wind"}, {"The more of this there is, the less you see.", "darkness"}, {"It stalks the countryside with ears that can't hear.", "corn"} };

    bool alive = true;
    while (riddleDictionary.Count > 0 && alive)
    {
      KeyValuePair<string, string> riddleKey = riddleDictionary.ElementAt(rand.Next(riddleDictionary.Count));
      string question = riddleKey.Key;
      string answer = riddleKey.Value;

      if (AskQuestion(question, answer))
      {
        Console.WriteLine("Correct. You shall pass.");
        riddleDictionary.Remove(question);
      }
      else
      {
        Console.WriteLine("Incorrect.");
        Console.WriteLine("*User gets eaten.*");
        alive = false;
      }
    }

    if (alive)
    {
      Console.WriteLine("You defeated the Sphinx!");
    }
  }

  private static bool AskQuestion(string question, string answer)
  {
    Console.WriteLine(question);
    string riddleAnswer = Console.ReadLine().ToLower();
    return riddleAnswer == answer;
  }
}