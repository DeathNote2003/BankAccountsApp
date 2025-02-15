namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount("Khaled Abd_Elhanan");

            BankAccount bankAccount2 = new BankAccount("Mohamed Abd_Elhanan");

            BankAccount bankAccount3 = new BankAccount("Ahmed Abd_Elhanan");
            
            

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountGird.DataSource = bankAccounts;
        }

    }
}
