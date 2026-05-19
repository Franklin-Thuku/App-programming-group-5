using System;

class LuckyGame
{
    public static void Run()
    {
        Console.WriteLine("==============");
        Console.WriteLine("TRY YOUR LUCK");
        Console.WriteLine("==============\n");

        int totalRounds = ReadPositiveInt("Enter number of rounds: ");

        int totalScore = 0;
        int wins = 0, losses = 0, draws = 0;

        GameLogic logic = new GameLogic();

        for (int i = 1; i <= totalRounds; i++)
        {
            Console.WriteLine($"\n--- Round {i} of {totalRounds} ---");

            int result = logic.PlayRound();
            totalScore += result;

            if (result == 1)       draws++;
            else if (result == 3)  wins++;
            else                   losses++;
        }

        Console.WriteLine("\n======= GAME OVER =======");
        Console.WriteLine($"Secret Number was: {logic.SecretNumber}");
        Console.WriteLine($"Wins: {wins} | Draws: {draws} | Losses: {losses}");
        Console.WriteLine($"Final Score: {totalScore}");
        Console.WriteLine(totalScore > 0
            ? "Congratulations!! You Win!"
            : "You Lose. Better luck next time!");
    }

    public static int ReadPositiveInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                return value;

            Console.WriteLine("  Invalid input. Please enter a positive whole number.");
        }
    }
}

class GameLogic
{
    public int SecretNumber { get; private set; }

    public GameLogic()
    {
        SecretNumber = new Random().Next(2, 10);
    }

    public int PlayRound()
    {
        int luckyNumber = LuckyGame.ReadPositiveInt("Enter your lucky number: ");
        int remainder = luckyNumber % SecretNumber;
        int score;

        if (remainder == 0)
        {
            Console.WriteLine("  Draw! (+1)");
            score = 1;
        }
        else if (remainder % 2 == 0)
        {
            Console.WriteLine("  You won this round! (+3)");
            score = 3;
        }
        else
        {
            Console.WriteLine("  You lost this round! (-3)");
            score = -3;
        }

        Console.WriteLine($"  Round score: {score} | Remainder was: {remainder}");
        return score;
    }
}

