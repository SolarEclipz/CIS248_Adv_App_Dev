using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sturdevant_s_Application
{
    public partial class EoDCalculator : UserControl
    {
        public EoDCalculator()
        {
            InitializeComponent();
        }

        // vars used in this app
        const decimal MAX_IN_TILL = 500.00m;        // used cont since that is the max we want

        // keep things easy vars
        decimal dollarBills = 0;
        decimal changeCoins = 0.0m;
        decimal rightSideAmounts = 0.0m;

        // left side of app
        decimal noHundred = 0;
        decimal noFifty = 0;
        decimal noTwenty = 0;
        decimal noTen = 0;
        decimal noFive = 0;
        decimal noOne = 0;
        decimal noQtr = 0.0m;
        decimal noDime = 0.0m;
        decimal noNickel = 0.0m;
        decimal noPenny = 0.0m;

        // right side of app
        decimal bankRoll = 0.0m;
        decimal checkAmount = 0.0m;
        decimal ccAmount = 0.0m;
        decimal otherAmount = 0.0m;
        decimal saeDeposit = 0.0m;
        decimal grandTotal = 0.0m;
        decimal removeTill = 0.0m;

        public void getTotals()
        {
            // parse left side into decimal and * amount to get actual total.
            noHundred = decimal.Parse(tbx_HundredD.Text) * 100;
            noFifty = decimal.Parse(tbx_FiftyD.Text) * 50;
            noTwenty = decimal.Parse(tbx_TwentyD.Text) * 20;
            noTen = decimal.Parse(tbx_TenD.Text) * 10;
            noFive = decimal.Parse(tbx_FiveD.Text) * 5;
            noOne = decimal.Parse(tbx_OneD.Text) * 1;
            noQtr = decimal.Parse(tbx_QtrC.Text) * 0.25m;
            noDime = decimal.Parse(tbx_DimeC.Text) * 0.10m;
            noNickel = decimal.Parse(tbx_NickelC.Text) * 0.05m;
            noPenny = decimal.Parse(tbx_PennieC.Text) * 0.01m;
            // convert right side into decimal
            bankRoll = decimal.Parse(tbx_BankrollAmt.Text);
            //checkAmount = decimal.Parse(tbx_ChecksAmt.Text);
            ccAmount = decimal.Parse(tbx_CCAmt.Text);
            otherAmount = decimal.Parse(tbx_OtherAmt.Text);
            saeDeposit = decimal.Parse(tbx_SAE_Deposit.Text);
        }

        public void convert_To_Qty()
        {
            noHundred = int.Parse(tbx_HundredD.Text) / 100;
            noFifty = int.Parse(tbx_FiftyD.Text) / 50;
            noTwenty = int.Parse(tbx_TwentyD.Text) / 20;
            noTen = int.Parse(tbx_TenD.Text) / 10;
            noFive = int.Parse(tbx_FiveD.Text) / 5;
            noOne = int.Parse(tbx_OneD.Text) / 1;
            noQtr = int.Parse(tbx_QtrC.Text) / 0.25m;
            noDime = int.Parse(tbx_DimeC.Text) / 0.10m;
            noNickel = int.Parse(tbx_NickelC.Text) / 0.05m;
            noPenny = int.Parse(tbx_PennieC.Text) / 0.01m;

            // convert right side into decimal
            bankRoll = decimal.Parse(tbx_BankrollAmt.Text);
            //checkAmount = decimal.Parse(tbx_ChecksAmt.Text);
            ccAmount = decimal.Parse(tbx_CCAmt.Text);
            otherAmount = decimal.Parse(tbx_OtherAmt.Text);
            saeDeposit = decimal.Parse(tbx_SAE_Deposit.Text);
            int noHundredInt = Decimal.ToInt32(noHundred);

            tbx_HundredD.Text = noHundred.ToString();
            //tbx_HundredD.Text = noHundredInt.ToString();
            //tbx_FiftyD.Text = noFifty.ToString();
            //tbx_TwentyD.Text = noTwenty.ToString();
            //tbx_TenD.Text = noTen.ToString();
            //tbx_FiveD.Text = noFive.ToString();
            //tbx_OneD.Text = noOne.ToString();
            //tbx_QtrC.Text = noQtr.ToString();
            //tbx_DimeC.Text = noDime.ToString();
            //tbx_NickelC.Text = noNickel.ToString();
            //tbx_PennieC.Text = noPenny.ToString();
            //tbx_OtherAmt.Text = otherAmount.ToString();
        }

        public void convert_To_Dollars()
        {
            // Once hitting "Calculate" Convert number qty to dollar amount
            tbx_HundredD.Text = noHundred.ToString();
            tbx_FiftyD.Text = noFifty.ToString();
            tbx_TwentyD.Text = noTwenty.ToString();
            tbx_TenD.Text = noTen.ToString();
            tbx_FiveD.Text = noFive.ToString();
            tbx_OneD.Text = noOne.ToString();
            tbx_QtrC.Text = noQtr.ToString();
            tbx_DimeC.Text = noDime.ToString();
            tbx_NickelC.Text = noNickel.ToString();
            tbx_PennieC.Text = noPenny.ToString();
            tbx_OtherAmt.Text = otherAmount.ToString();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            //convert_To_Dollars();
            //convert_To_Qty();
            getTotals();


            // Adds the total from CheckList box
            for (int ck = 0; ck < ChecksList.Items.Count; ck++)
            {
                checkAmount += Convert.ToDecimal(ChecksList.Items[ck]);
            }
            tbx_ChecksAmt.Text = checkAmount.ToString("c");

            // adds each group up
            dollarBills = noHundred + noFifty + noTwenty + noTen + noFive + noOne;
            changeCoins = noQtr + noDime + noNickel + noPenny + bankRoll + otherAmount;
            rightSideAmounts = checkAmount + ccAmount + saeDeposit;
            grandTotal = dollarBills + changeCoins + rightSideAmounts - MAX_IN_TILL;

            // outputs total and the amount to remove from the till
            tbx_GrandTotal.Text = grandTotal.ToString("c");
            removeTill = (dollarBills + changeCoins) - MAX_IN_TILL;

            // RemoveFrom till, if text is red, you didn't add right
            // text is green you need to remove money
            // text is black dont remove anything
            if (removeTill > 0)
            {
                tbx_RemoveTill.ForeColor = Color.Green;
                tbx_RemoveTill.Text = removeTill.ToString("c");
            }
            else if (removeTill < 0)
            {
                tbx_RemoveTill.ForeColor = Color.Red;
                tbx_RemoveTill.Text = removeTill.ToString("c");
            }
            else
            {
                tbx_RemoveTill.Text = removeTill.ToString("c");
            }
        }

        private void Chk_Add_Button_Click(object sender, EventArgs e)
        {
            if (this.tbx_ChecksAmt.Text != "")
            {
                ChecksList.Items.Add(this.tbx_ChecksAmt.Text);
                this.tbx_ChecksAmt.Focus();
                this.tbx_ChecksAmt.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbx_ChecksAmt.Focus();
            }
        }

        private void Btn_RemoveCk_Click(object sender, EventArgs e)
        {
            if (this.ChecksList.SelectedIndex >= 0)
            {
                this.ChecksList.Items.RemoveAt(this.ChecksList.SelectedIndex);
            }
        }

        private void Btn_ClearCk_Click(object sender, EventArgs e)
        {
            ChecksList.Items.Clear();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbx_EoD_Calc.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Cbx_ShowTotals_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ShowTotals.Checked == false)
            {
                convert_To_Qty();
            }
            else
            {
                convert_To_Dollars();
            }
        }
    }
}
