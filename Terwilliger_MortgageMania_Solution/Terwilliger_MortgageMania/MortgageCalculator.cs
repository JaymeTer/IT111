using System;
using System.Windows.Forms;

namespace Terwilliger_MortgageMania
{
    public partial class MortgageCalculator : Form
    {
        // Makes sure the calculation has happened to enable the Reset button
        private bool calculationPerformed = false;

        public MortgageCalculator()
        {
            InitializeComponent();

            // Makes the reset button grey out
            Reset.Enabled = false;

            // Set the form to be non-resizable
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Attach the Resize event handler
            Resize += MortgageCalculator_Resize;
        }

        // Resize event handler to prevent maximizing to full screen
        private void MortgageCalculator_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Spawns the "Other" text box
        private void AppOther_CheckedChanged(object sender, EventArgs e)
        {
            TxtOther.Visible = AppOther.Checked;
            TxtOther.Enabled = AppOther.Checked;
        }

        //The calculate button where all the action is
        private void Calculate_Click(object sender, EventArgs e)
        {
            // Top of error box
            string errorMessage = "Errors found:\n";

            // principle error
            if (!decimal.TryParse(TxtPrincipal.Text, out _))
                errorMessage += "- Please enter a valid principal amount\n";

            // term option error
            if (!(App15Year.Checked || App30Year.Checked || (AppOther.Checked && int.TryParse(TxtOther.Text, out int otherLoanYears) && otherLoanYears >= 5 && otherLoanYears <= 40)))
                errorMessage += "- Please select a valid term option\n";

            // rate error
            if (InterestDrop.SelectedItem == null)
                errorMessage += "- Please select an interest rate\n";

            // Spawns the error box
            if (errorMessage != "Errors found:\n")
            {
                AppErrorBox.Text = errorMessage;
                return;
            }

            // Cleans out the error box
            AppErrorBox.Text = string.Empty;

            // get values, make sure they are numbers
            if (!decimal.TryParse(TxtPrincipal.Text, out decimal principal))
            {
                AppErrorBox.Text = "Please enter a valid principal amount.";
                return;
            }

            // get the interest rate
            if (!decimal.TryParse(InterestDrop.SelectedItem.ToString(), out decimal interestRate))
            {
                AppErrorBox.Text = "Please select a valid interest rate.";
                return;
            }

            interestRate /= 100;

            // get the number of payments
            int numberOfPayments;
            if (App15Year.Checked)
                numberOfPayments = 15 * 12;
            else if (App30Year.Checked)
                numberOfPayments = 30 * 12;
            else if (AppOther.Checked && int.TryParse(TxtOther.Text, out int otherYears))
                numberOfPayments = otherYears * 12;
            else
            {
                AppErrorBox.Text = "Please select a valid loan term.";
                return;
            }

            // get the mortgage payment using the formula ((this took forever to get right))
            decimal monthlyPayment = principal * (interestRate / 12) * (decimal)Math.Pow(1 + (double)(interestRate / 12), numberOfPayments) /
                                     ((decimal)Math.Pow(1 + (double)(interestRate / 12), numberOfPayments) - 1);

            // Show monthly payment
            AppPayment.Text = $"Monthly Payment is {monthlyPayment:C}";

            // ungreys reset button
            Reset.Enabled = true;

            //lets it know a calculation has happened
            calculationPerformed = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // Reset!
            TxtPrincipal.Text = string.Empty;
            InterestDrop.SelectedIndex = -1;
            App15Year.Checked = false;
            App30Year.Checked = false;
            AppOther.Checked = false;
            TxtOther.Text = string.Empty;
            AppErrorBox.Text = string.Empty;
            AppPayment.Text = string.Empty;

            // Greys it back out
            Reset.Enabled = false;

            // Lets it know its waiting for a calculation again
            calculationPerformed = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Exit
            Application.Exit();
        }

        private void MortgageCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
