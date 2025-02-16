namespace BankAccountsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGird = new DataGridView();
            DepositeBtn = new Button();
            WithdrawBtn = new Button();
            buttonCreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGird).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 277);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(113, 26);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(216, 35);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(113, 275);
            AmountNum.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(216, 35);
            AmountNum.TabIndex = 3;
            AmountNum.UseWaitCursor = true;
            AmountNum.ValueChanged += AmountNum_ValueChanged;
            // 
            // BankAccountGird
            // 
            BankAccountGird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGird.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGird.Location = new Point(374, 26);
            BankAccountGird.Name = "BankAccountGird";
            BankAccountGird.Size = new Size(476, 284);
            BankAccountGird.TabIndex = 4;
            // 
            // DepositeBtn
            // 
            DepositeBtn.Location = new Point(374, 327);
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.Size = new Size(240, 62);
            DepositeBtn.TabIndex = 6;
            DepositeBtn.Text = "Deposit";
            DepositeBtn.UseVisualStyleBackColor = true;
            DepositeBtn.Click += DepositeBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(620, 327);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(230, 62);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // buttonCreateAccountBtn
            // 
            buttonCreateAccountBtn.Location = new Point(113, 82);
            buttonCreateAccountBtn.Name = "buttonCreateAccountBtn";
            buttonCreateAccountBtn.Size = new Size(216, 62);
            buttonCreateAccountBtn.TabIndex = 8;
            buttonCreateAccountBtn.Text = "Create account";
            buttonCreateAccountBtn.UseVisualStyleBackColor = true;
            buttonCreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 448);
            Controls.Add(buttonCreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositeBtn);
            Controls.Add(BankAccountGird);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Bank Accounts Manager";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {
            // ضع هنا الكود المطلوب عند تغيير القيمة
        }

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGird;
        private Button DepositeBtn;
        private Button WithdrawBtn;
        private Button buttonCreateAccountBtn;
    }
}
