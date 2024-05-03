using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    internal class Player
    {
        public int balance = 100;

        public int getBalance()
        {
            // Console.WriteLine("You current balance is: " + balance );
            return balance;
        }

        public void decreaseBalance (int amount)
        {
            balance -= amount;
            Console.WriteLine("You current balance is: " + balance);
        }
        public void increaseBalance(int amount)
        {
            balance += amount;
            Console.WriteLine("You current balance is: " + balance);
        }
    }
}
