using System;

class luckyGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("==============");
        Console.WriteLine("TRY YOUR LUCK");
        Console.WriteLine("==============");

        string trialString;
        int trialInt; 
        Console.Write("Enter number of trials: ");
        trialString = Console.ReadLine();
        trialInt = int.Parse(trialString);

        int totalScore = 0;
        int i = 1;
        gameLogic logic = new gameLogic();

        while(i <= trialInt)
        {
            Console.WriteLine($"\n--- Trial {i} ---");

            totalScore += logic.AskForNumber();
            i++;
        }

        Console.WriteLine($"\nGame Over! Final Score: {totalScore}");
    
          if(totalScore > 0)
        {
            Console.WriteLine("Congratulations!! You Win");
        }
        else
        {
            Console.WriteLine("You Loose");
        }
            
    }
      
}

class gameLogic
{
    string luckyString;
    int luckyInt;
     int secretNumber = 4;
    public int AskForNumber()
    {
    

    Console.Write("Enter your lucky number: "); 
    luckyString = Console.ReadLine();
    luckyInt = int.Parse(luckyString);

    int rem = luckyInt % secretNumber;
    int score = 0;
         
        
            if(rem == 0){
                Console.WriteLine("Draw!");
                score+=1;

            }

            else if(rem % 2 == 0){
                Console.WriteLine("Hooray! You Won this round!");
                score+=3;
                
            }
            
            else{
                Console.WriteLine("You Lost this round!");
                score-=3;
                
            }

       
        Console.WriteLine("Your score for this trial is {0}", score);

         return score;
    }
}
