using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingAccount : BankAccount
    {
       
        public decimal InterestRate { get; set; }   

        public SavingAccount(string owner , decimal interstRate) : base(owner + "("+interstRate+"%"+")")
        {
            InterestRate = interstRate; 
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML Deposit Limit Reached.";
            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount+interestAmount;
            return "Deposit completed successfully .";

        }
    }
}
