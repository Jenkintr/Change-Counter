using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCounterApp
{
    public partial class changeCounter : Form
    {
        //Constant fields
        const decimal PENNY_VALUE = 0.01m;
        const decimal NICKEL_VALUE = 0.05m;
        const decimal DIME_VALUE = 0.10m;
        const decimal QUARTER_VALUE = 0.25m;

        //Field Variable to hold the total:
        private decimal total = 0m;

        public changeCounter()
        {
            InitializeComponent();
        }

        private void oneCentPictureBox_Click(object sender, EventArgs e)
        {
            //Add penny to total and format as currency.
            total += PENNY_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add nickel to total & format to currency.
            total += NICKEL_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add dime to total & format to currency.
            total += DIME_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add quarter to total & format to currency.
            total += QUARTER_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the total and the output controls
            totalLabel.Text = "";
            total = 0m;
        }
    }
}
