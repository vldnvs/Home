using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace logCalculator
{
    public partial class HypeLog : Form
    {
        public double total = 0;

        public int logBase;
        public int logArgument;



        public HypeLog()
        {
            InitializeComponent();
        }

        private void takeValues()
        {
            logBase = Convert.ToInt32(firstBase.Text);
            logArgument = Convert.ToInt32(firstArgument.Text);
        }

        private void insertValue(char operation)
        {
            string result = string.Format("log({0})({1})", logBase, logArgument);
            outputBox.Text += result + " " + operation;
        }

        private void clearLogarithm()
        {
            firstBase.Text = string.Empty;
            firstArgument.Text = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            if (total == 0 && checkFields())
            {
                takeValues();
                outputBox.Text = Math.Log(logArgument, logBase).ToString();
                errorLabel.Text = "Õ‡ÊÏËÚÂ —≈";
            }
            else
            {
                outputBox.Text = total.ToString();
                Console.WriteLine(total);
            }


        }

        private bool checkFields()
        {
            if (firstBase.Text == string.Empty && firstArgument.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                takeValues();

                total += Math.Log(logArgument, logBase);
                insertValue('+');
                clearLogarithm();
                errorLabel.Text = string.Empty;
            }

            else
            {
                errorLabel.Text = "Œÿ»¡ ¿ («¿œŒÀÕ»“≈ ÀŒ√¿–»‘Ã)";
            }


        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                takeValues();

                total -= Math.Log(logArgument, logBase);

                insertValue('-');
                clearLogarithm();
                errorLabel.Text = string.Empty;
            }

            else
            {
                errorLabel.Text = "Œÿ»¡ ¿ («¿œŒÀÕ»“≈ ÀŒ√¿–»‘Ã)";
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            total = 0;
            firstBase.Text = string.Empty;
            firstArgument.Text = string.Empty;
            outputBox.Text = string.Empty;
            errorLabel.Text = string.Empty;
        }
    }
}