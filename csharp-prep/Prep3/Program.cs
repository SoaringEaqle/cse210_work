using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            //Console.Write("What is the magic number? ");
            //String magicNumber = Console.ReadLine();
            Random rand = new Random();
            int num = rand.Next(1, 11);

            int guess;
            int guesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guesses++;


                if (num == guess)
                {
                    Console.WriteLine($"You guessed it in {guesses} tries!");
                    
                }
                else if (num > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }
            while(num != guess);
            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
            
        } 
        while (response == "yes");
    }
}