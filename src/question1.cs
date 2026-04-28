using System;

class LuckyGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("==============");
        Console.WriteLine("TRY YOUR LUCK");
        Console.WriteLine("==============\n");

        // FIX: replace int.Parse with a validated helper since it can crash on bad input hence increasing code robustness
        int totalRounds = ReadPositiveInt("Enter number of rounds: ");

        int totalScore = 0;
        int wins = 0, losses = 0, draws = 0;

        // IMPROVEMENT: secret number is now randomized, now making each game session unique
        GameLogic logic = new GameLogic();

        // this is cleaner than while(i <= n) since for loop is better when count is known
        for (int i = 1; i <= totalRounds; i++)
        {
            Console.WriteLine($"\n--- Round {i} of {totalRounds} ---");

            int result = logic.PlayRound();
            totalScore += result;

            // tracking outcomes separately gives us a proper breakdown at the end
            if (result == 1)       draws++;
            else if (result == 3)  wins++;
            else                   losses++;
        }

        Console.WriteLine("\n======= GAME OVER =======");
        // IMPROVEMENT: reveal secret number at end so that player knows what they were up against
        Console.WriteLine($"Secret Number was: {logic.SecretNumber}");
        // IMPROVEMENT: Win, draw,Lose breakdown instead of just a raw score...working on specificity
        Console.WriteLine($"Wins: {wins} | Draws: {draws} | Losses: {losses}");
        Console.WriteLine($"Final Score: {totalScore}");

    
        // LOGIC here is: positive total score = win, anything else = loss 
        Console.WriteLine(totalScore > 0
            ? "Congratulations!! You Win!"
            : "You Lose. Better luck next time!");
    }

    // FIX: reusable validated input which is an instance of reusability avoiding the copy pasting shii
    public static int ReadPositiveInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            // TryParse returns false instead of throwing which is safe for unexpected input
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                return value;

            Console.WriteLine("  Invalid input. Please enter a positive whole number.");
        }
    }
}

class GameLogic
{
    // FIX: was a magic number (= 4) buried in the class but now visible, configurable, and revealable
    public int SecretNumber { get; private set; }

    public GameLogic()
    {
        // IMPROVEMENT: random range 2–9 keeps division interesting. It avoids 0 or 1 edge cases
        SecretNumber = new Random().Next(2, 10);
    }

    public int PlayRound()
    {
        // FIX: these were instance fields before ....... they only live inside one method call, so local is correct
        int luckyNumber = LuckyGame.ReadPositiveInt("Enter your lucky number: ");

        // CORE LOGIC: remainder drives all three outcomes 
        int remainder = luckyNumber % SecretNumber;
        int score;

        if (remainder == 0)
        {
            // LOGIC: exactly divisible = draw → +1
            Console.WriteLine("  Draw! (+1)");
            score = 1;
        }
        else if (remainder % 2 == 0)
        {
            // LOGIC: remainder is non-zero but even = win → +3
            Console.WriteLine("  You won this round! (+3)");
            score = 3;
        }
        else
        {
            // LOGIC: remainder is odd = loss → -3 (score-=3 in original was a bug, should return -3 not decrement locally)
            Console.WriteLine("  You lost this round! (-3)");
            score = -3;
        }

        // shows remainder so player can start sensing the pattern (good for learning/debugging too)
        Console.WriteLine($"  Round score: {score} | Remainder was: {remainder}");
        return score;
    }
}

SHORTER SOLUTION ASSUMING THE SECRET NUMBER IS ONLY KNOWN BY THE PROGRAM AND THE PROGRAMMER
#include <stdio.h>
using System;

class Luckygame
{
    static void main()
    {
        int totalScore = 0;
        int secretNumber = 8;
        
        Console.Write("Enter the number of rounds you wish to play: ");
        int rounds = int.Parse(Console.ReadLine());
        
        for (int i; i <= rounds; i++)
        {
            Console.Write("Round {0}: Enter you lucky number: ", i);
            luckynumber = int.Parse(Console.ReadLine());
            
            int remaind = luckynumber % secretNumber;
            
            if (remaind == 0)
            {
                totalScore += 1; 
            }
            if (remaind% 2 == 0)
            {
                totalScore +=3;
            }
            else
            {
                totalScore -=3;
            }
        }
        if (totalScore > 0)
        {
            Console.WriteLine("Final Score: {0}, You wiinn", totalScore);
        }
        else
        {
            Console.WriteLine("Final Score: {0}, You lose", totalScore);
        }
    }
}
