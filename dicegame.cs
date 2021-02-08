using System;

public class DiceGame
{
  public static void Main()
  {
    Random throwDice = new Random();

    Console.WriteLine("Here we go! Lets start the dice-game! 100 throws!");
    Console.WriteLine("");

    int counter = 1;
    int countDoubles = 0;

    while (counter<=100)
    {
      int dice1 = throwDice.Next(1,7);
      int dice2 = throwDice.Next(1,7);

      Console.WriteLine($@"Toss number {counter}
Dice 1 was a {dice1} and Dice 2 was a {dice2}");

      if (dice1 == dice2)
      {
        Console.WriteLine($"Wow! Lucky! Double {dice1}:es!");
        Console.WriteLine("------------------------------------------------");
        countDoubles++;
      }
      else{
        Console.WriteLine("------------------------------------------------");
      }
      counter++;
    }
    Console.WriteLine($"Wow! You got {countDoubles} doubles!");
  }
}
