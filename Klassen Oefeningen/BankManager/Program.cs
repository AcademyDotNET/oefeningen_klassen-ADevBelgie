using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankManager\n");

            Account rekening1 = new Account();
            Account rekening2 = new Account();

            //withdraw and fund 
            rekening1.WithdrawFunds(20);
            rekening1.PayInFunds(100);
            rekening1.WithdrawFunds(20);
            rekening1.WithdrawFunds(100);

            //give money and test account state
            rekening2.PayInFunds(100);
            rekening2.ChangeState(AccountState.Geblokkeerd);
            rekening2.WithdrawFunds(50);
            rekening2.ChangeState(AccountState.Geldig);

            //transfer
            rekening1.GetBalance();
            rekening2.GetBalance();
            rekening1.PayInFunds(rekening2.WithdrawFunds(50));
            rekening1.GetBalance();
            rekening2.GetBalance();
        }
    }
}
