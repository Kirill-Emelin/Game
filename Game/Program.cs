namespace Game
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int answer = rand.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Guess the number between 1 and 100.");

            while (guess != answer)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < answer)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Too high, try again.");
                }
            }

            Console.WriteLine("Congratulations! You guessed the number in " + attempts + " attempts.");
        }
    }
}