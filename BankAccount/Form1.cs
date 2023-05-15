using System.Runtime.CompilerServices;

namespace BankAccount
{
    public partial class Form1 : Form
    {

        private Account _account = new Account();

        private Currency[] _currencies = { new Currency("RUB"), new Currency("TJS"), new Currency("JPY") };

        private float balance = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void CountUpdater()
        {

            Currency balanceCurrency = _currencies[AccountCurrencyBox.SelectedIndex];

            BalanceTextBox.Text = (balance / balanceCurrency.multiplier).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in _currencies)
            {
                AccountCurrencyBox.Items.Add(item.name);
                TransactionCurrencyBox.Items.Add(item.name);
            }

            
            BalanceTextBox.Text = _account.GetMoneyOnAccount().ToString();
            BalanceTextBox.ReadOnly = true;

            AccountCurrencyBox.SelectedIndex = 0;

            TransactionCurrencyBox.SelectedIndex = 0;

            TransactionTextBox.Text = "0";

            CountUpdater();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            float toDeposit = float.Parse(TransactionTextBox.Text);

            Currency transferCurrency = _currencies[TransactionCurrencyBox.SelectedIndex];

            Currency balanceCurrency = _currencies[AccountCurrencyBox.SelectedIndex];

            balance += toDeposit * transferCurrency.multiplier;


            BalanceTextBox.Text = (balance / balanceCurrency.multiplier).ToString();

            CountUpdater();
        }

        private void AccountCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency balanceCurrrency = _currencies[AccountCurrencyBox.SelectedIndex];

            BalanceTextBox.Text = (balance / balanceCurrrency.multiplier).ToString();

            CountUpdater();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            Currency balanceCurrrency = _currencies[TransactionCurrencyBox.SelectedIndex];

            float toWithdraw = float.Parse(TransactionTextBox.Text) * balanceCurrrency.multiplier;



            if (balance -  toWithdraw >= 0)
            {
                balance = balance - toWithdraw ;

                BalanceTextBox.Text = (balance * balanceCurrrency.multiplier).ToString();
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }

            CountUpdater();
        }


    }
}

//в общем нужно дописать чтобы комбобоксы отображались в зависимости от выбранногой валюты