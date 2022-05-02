using System;
using System.Collections.Generic;
using System.Linq;

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
    Random rand = new Random();
    Dictionary<string, string> riddleDictionary = new Dictionary<string, string> () { {"I run all around the pasture but never move. What am I?", "fence"}, {"What has roots as nobody sees, is taller than trees, up, up it goes, and yet never grows?", "mountain"}, {"Voiceless it cries, wingless flutters, toothless bites, mouthless mutters.", "wind"} };

    KeyValuePair<string, string> riddleKey = riddleDictionary.ElementAt(rand.Next(riddleDictionary.Count));
    string question = riddleKey.Key;
    string answer = riddleKey.Value;

    Console.WriteLine(question);
    string riddleAnswer = Console.ReadLine().ToLower();
    if (riddleAnswer == answer)
    {
      Console.WriteLine("Correct. You shall pass.");
      KeyValuePair<string, string> riddleKey2 = riddleDictionary.ElementAt(rand.Next(riddleDictionary.Count));
      string question2 = riddleKey2.Key;
      string answer2 = riddleKey2.Value;
      Console.WriteLine(question2);
      string riddleAnswer2 = Console.ReadLine().ToLower();
      if (riddleAnswer2 == answer2)
      {
        Console.WriteLine("Correct. You shall pass.");
        KeyValuePair<string, string> riddleKey3 = riddleDictionary.ElementAt(rand.Next(riddleDictionary.Count));
        string question3 = riddleKey3.Key;
        string answer3 = riddleKey3.Value;
        Console.WriteLine(question3);
        string riddleAnswer3 = Console.ReadLine().ToLower();
        if (riddleAnswer3 == answer3)
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