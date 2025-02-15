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
            AccountNumber=Guid.NewGuid();
            Balance = 0;

        }
        public string Owner {  get; set; }

        // Guid --> to create globally unique identifier {Unique ID}
        public Guid AccountNumber {  get; set; }

        public decimal Balance {  get; set; }
       
    }
}
