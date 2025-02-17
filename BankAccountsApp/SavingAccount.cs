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

        public SavingAccount(string owner , decimal interstRate) : base(owner + "("+interstRate+"%")
        {
            InterestRate = interstRate; 
        }
    }
}
