using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;

        }

        public string Owner { get; set; }
        // Guid --> to create globally unique identifier {Unique ID}
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
        

        // Encapsulation 
        public virtual string Deposit(decimal amount)
        {
            if(amount <= 0) 
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML Deposit Limit Reached.";
            Balance += amount;
            return "Deposit completed successfully .";
            
        }


        public string WithDraw(decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "You don't have enough money.";
           
            Balance -= amount;
            return "Withdraw completed successfully .";

        }
    }
   
}