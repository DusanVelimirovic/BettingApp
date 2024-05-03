using System.Numerics;

namespace BettingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double odds = .75;

            // Instantiate player object
            Player player = new Player();

            // Main Betting flow
            while(player.getBalance() > 0)
            {
                // Display odds
                Console.WriteLine("Odds are: " + odds);

                // Display player current balance
                Console.WriteLine("You current balance is: " + player.getBalance());

                // Prompt player to enter amount to bet

                Console.Write("Enter an amount to bet: ");

                string amountToBet = Console.ReadLine();

                int.TryParse(amountToBet, out int amount);

                amount *= 2;

                if (amount <= player.getBalance() && player.getBalance() > 0)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 2); // Generates a random integer between 0 (inclusive) and 2 (exclusive)
                    if (randomNumber > odds)
                    {
                        player.decreaseBalance(amount);
                        Console.Write("Bad luck you lose!");
                        Console.WriteLine("Your current balance is: " + player.getBalance());
                    }
                    if (randomNumber < odds)
                    {
                        player.increaseBalance(amount);
                        Console.Write("You win!");
                        Console.WriteLine("You current balance is: " + player.getBalance());
                    }

                }
            }
            Console.WriteLine("Sorry my friend house always win!!");







        }
    }
}
