namespace numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int numberToGuess = random.Next(1, 101); 
                int numberOfTries = 0;
                bool numberGuessed = false;

                Console.WriteLine("Welcome to the Guess Number Game!");
                Console.WriteLine("You Will Be Asked To Guess A Number To Win The Game");
                Console.WriteLine("---------------------------------------------------");

                while (!numberGuessed)
                {
                    Console.Write("Enter a guess number between 1 to 100: ");
                    int playerGuess = int.Parse(Console.ReadLine());
                    numberOfTries++;

                    if (playerGuess < numberToGuess)
                    {
                        Console.WriteLine("Oops! Sorry, too low.");
                    }
                    else if (playerGuess > numberToGuess)
                    {
                        Console.WriteLine("Oops! Sorry, too high.");
                    }
                    else
                    {
                        Console.WriteLine("Yayyy! Your Guessed Number is Correct.");
                        Console.WriteLine($"You took {numberOfTries} tries! You Win the Game.");
                        numberGuessed = true;
                    }
                }

                
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();
                playAgain = response == "y";
            }

            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
    
}
