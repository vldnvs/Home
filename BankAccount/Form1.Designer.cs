namespace BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DepositButton = new Button();
            WithdrawButton = new Button();
            AccountCurrencyBox = new ComboBox();
            TransactionCurrencyBox = new ComboBox();
            TransactionTextBox = new TextBox();
            BalanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "Состояние счета";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 321);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Транзакция";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 88);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Баланс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 132);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Валюта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 390);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Сумма";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 427);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Валюта";
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(57, 478);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(102, 30);
            DepositButton.TabIndex = 6;
            DepositButton.Text = "Зачислить";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(199, 478);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(102, 30);
            WithdrawButton.TabIndex = 7;
            WithdrawButton.Text = "Снять";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // AccountCurrencyBox
            // 
            AccountCurrencyBox.FormattingEnabled = true;
            AccountCurrencyBox.Location = new Point(180, 124);
            AccountCurrencyBox.Name = "AccountCurrencyBox";
            AccountCurrencyBox.Size = new Size(121, 23);
            AccountCurrencyBox.TabIndex = 8;
            AccountCurrencyBox.SelectedIndexChanged += AccountCurrencyBox_SelectedIndexChanged;
            // 
            // TransactionCurrencyBox
            // 
            TransactionCurrencyBox.FormattingEnabled = true;
            TransactionCurrencyBox.Location = new Point(180, 419);
            TransactionCurrencyBox.Name = "TransactionCurrencyBox";
            TransactionCurrencyBox.Size = new Size(121, 23);
            TransactionCurrencyBox.TabIndex = 9;
            // 
            // TransactionTextBox
            // 
            TransactionTextBox.Location = new Point(180, 382);
            TransactionTextBox.Name = "TransactionTextBox";
            TransactionTextBox.Size = new Size(121, 23);
            TransactionTextBox.TabIndex = 10;
            // 
            // BalanceTextBox
            // 
            BalanceTextBox.Location = new Point(180, 80);
            BalanceTextBox.Name = "BalanceTextBox";
            BalanceTextBox.Size = new Size(121, 23);
            BalanceTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 545);
            Controls.Add(BalanceTextBox);
            Controls.Add(TransactionTextBox);
            Controls.Add(TransactionCurrencyBox);
            Controls.Add(AccountCurrencyBox);
            Controls.Add(WithdrawButton);
            Controls.Add(DepositButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button DepositButton;
        private Button WithdrawButton;
        private ComboBox AccountCurrencyBox;
        private ComboBox TransactionCurrencyBox;
        private TextBox TransactionTextBox;
        private TextBox BalanceTextBox;
    }
}