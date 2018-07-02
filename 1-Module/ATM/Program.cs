using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Robert MoskVodka";
            string greeting = "Hello To World Cup, I´m " + name + " your personal ATM.";

            Console.WriteLine(greeting);
            Console.WriteLine(@"What you wanna do? 
            1 - Money
            2 - Deposit
            3 - Withdraw");
           
            string action = Console.ReadLine();

            bool showMeMyMoney = action == "1" || action.Equals("MoNeY",  StringComparison.OrdinalIgnoreCase); // if the value of action is '1' is going to be true, if not is going to e false
            bool depositMoney = action == "2" || action.Equals("Deposit",  StringComparison.OrdinalIgnoreCase); // if the value of action is '1' is going to be true, if not is going to e false
            bool widthDrawMoney = action == "3" || action.Equals("Withdraw",  StringComparison.OrdinalIgnoreCase); // if the value of action is '1' is going to be true, if not is going to e false

            //int balance = 5000; //absolute values
            float balance = 5_000.556f;

            var pt_BR = new System.Globalization.CultureInfo("pt-BR");
        
            if (showMeMyMoney)
            {
                Console.WriteLine(string.Format(pt_BR, "{0:c} (in reais)", balance ));
            }
            else if (depositMoney)
            {
                Console.WriteLine("Entre with the amount to deposit:");
                string deposit = Console.ReadLine();
                float new_balance  = balance + Convert.ToSingle(deposit);

                balance = new_balance;
                Console.WriteLine(string.Format(pt_BR, "Your new balance is equals to {0:c}!", new_balance));
            }
            else if(widthDrawMoney)
            {
                Console.WriteLine("Entre with the amount to withdraw:");
                string deposit = Console.ReadLine();
                float new_balance  = balance - Convert.ToSingle(deposit);

                balance = new_balance;
                Console.WriteLine(string.Format(pt_BR, "Your new balance is equals to {0:c}!", new_balance));
            }
            else
            {
                Console.WriteLine(" Pick of the the fucking choices! Your moron!");
            }
        }
    }
}
