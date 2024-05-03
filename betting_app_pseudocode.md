# Betting App Pseudocode

```pseudocode
Float odds = 0.75;

Class Player
    // Fields
    Integer balance = 100;

    // Methods
    Public int Module getBalance()
        return balance;
    End Module

    Public void Module decreaseBalance(amount)
        balance = balance - amount
        Display "Your updated balance is {balance}"
    End Module

    Public void Module increaseBalance(amount)
        balance = balance + amount
        Display "Your updated balance is {balance}"
    End Module
End Class

While (Player.getBalance() > 0)
    Display odds;
    Display Player.getBalance();
    Prompt player to enter amount to bet;
    Process amount (Convert input from String to Integer);
    Process amount = amount * 2;
    If (amount <= balance and balance > 0)
        Get random Integer random from 0 to 1;
        If (random > odds)
            Player.decreaseBalance(amount);
            Display 'Bad luck you lose!'
            Display Player.getBalance()
        End if
        Else (random < odds)
            Player.increaseBalance(amount);
            Display 'You win!';
            Display Player.getBalance();
        End else
    End If
End While
Else
    Display "Sorry my friend house always win!!"
End Else

