namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccountsList = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                return;
            }
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);

            BankAccountsList.Add(bankAccount);
            RefreshGrid();
            OwnerTxt.Text = "";
        }

        private void RefreshGrid()
        {
            BankAccountGird.DataSource = null;
            BankAccountGird.DataSource = BankAccountsList;
        }

       

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGird.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountGird.SelectedRows[0]
                    .DataBoundItem as BankAccount;
                //selectedBankAccount.Balance += AmountNum.Value;
                string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGird.SelectedRows.Count == 1 & AmountNum.Value > 0) 
            { 
                BankAccount selectedBankAccount = BankAccountGird.SelectedRows[0]
                    .DataBoundItem as BankAccount;
                //selectedBankAccount.Balance -= AmountNum.Value;
                string message = selectedBankAccount.WithDraw(AmountNum.Value);  
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
