namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a game! Guess a number between 1-1000.");


            var r = new Random();  // set fav num to random so that game can be played multiple times
            var favNumber = r.Next(1, 1000);
            bool isWinner = false;

            do
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput == favNumber)
                {
                    Console.WriteLine("You win!");
                    isWinner = true;
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too low! Guess again.");

                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high! Guess again");
                }
            }
            while (!isWinner);

            Console.WriteLine($"The answer was {favNumber}!");

        }
    }
}