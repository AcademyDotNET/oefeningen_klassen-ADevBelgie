using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{
    public enum AccountState { Geldig, Geblokkeerd}
    class Account
    {
        public string Naamveld { get; set; }
        public double Bedrag { get; set; }
        public string Rekeningnummer { get; set; }

        AccountState accountState = new AccountState();

        public Account()
        {
            Rekeningnummer = "";
            accountState = AccountState.Geldig;
            Bedrag = 0;
        }

        public int WithdrawFunds(double fund)
        {
            if (accountState == AccountState.Geblokkeerd)
            {
                Console.WriteLine("Account is geblokkeerd");
                return 0;
            }
            if (Bedrag>=fund)
            {
                Bedrag -= fund;
            }
            else
            {
                //withdrawing
                double tempBedrag = Bedrag;
                Bedrag = 0;

                //output isse to user
                Console.WriteLine("Not enough balance to withdrawn from.");
                Console.WriteLine($"only {tempBedrag} of {fund} was withdrawn");
                return (int)tempBedrag;
            }
            
            return Convert.ToInt32(Bedrag);
        }

        public void PayInFunds(double fund)
        {
            if (accountState == AccountState.Geblokkeerd)
            {
                Console.WriteLine("Account is geblokkeerd");
                return;
            }
            Bedrag += fund;
            return;
        }

        public void GetBalance()
        {
            Console.WriteLine($"{(Rekeningnummer == ""?"Rekening": Rekeningnummer)}: {Bedrag}");
            return;
        }

        public void ChangeState(AccountState currentAccountState)
        {
            accountState = currentAccountState;
            return;
        }
    }
}
