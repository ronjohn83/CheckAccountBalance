using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_CheckAccountBalance
{
    public partial class Form1 : Form
    {
        double balance = 0;
        static int totalDeposits;
        static double totalDepositAmounts;
        static int totalChecks;
        static double totalAmountOfChecks;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdDeposit.Checked)
            {
                Deposit(TransactionAmount());
            }
            if (rdCheck.Checked)
            {
                WithDrawal(TransactionAmount());
            }
            if (rdServiceCharge.Checked)
            {
                ServiceCharge(TransactionAmount());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            balance = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total number of deposits: " + totalDeposits +
                "\n Total amount of deposits: " + totalDepositAmounts.ToString("C") +
                "\n Total number of checks: " + totalChecks +
                "\n Total amount of checks: " + totalAmountOfChecks.ToString(""));
        }

        private double TransactionAmount()
        {
            double amount;
            bool valid = double.TryParse(txtAmount.Text, out amount);
            if (valid)
                return amount;
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                return 0;
            }
        }

        private void Deposit(double deposit)
        {
            balance += deposit;
            totalDeposits++;
            totalDepositAmounts += deposit;
            ShowBalance();
        }

        private void WithDrawal(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                totalChecks++;
                totalAmountOfChecks += amount;
            }
            else
            {
                balance -= 10;
                MessageBox.Show("Insufficient Funds");
            }
            ShowBalance();
        }

        private void ServiceCharge(double serviceCharge)
        {

            if (balance >= serviceCharge)
            {
                balance -= serviceCharge;
                totalChecks++;
            }
            else
                MessageBox.Show("The transaction cannot be completed because the balanace would be less than zero.");

            ShowBalance();
        }

        private void ShowBalance()
        {
            lblBalance.Text = balance.ToString("C");
            txtAmount.Clear();
        }
    }
}
