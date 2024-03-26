using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackScholes_for_TPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stockPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void strikePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void interestRateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void volatilityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private double NormalDistribution(double x)
        {
            double erf = SpecialFunction.Erf(x / Math.Sqrt(2));
            return 0.5 * (1 + erf);
        }

        private void PerformCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                double S = double.Parse(stockPriceTextBox.Text);
                double K = double.Parse(strikePriceTextBox.Text);
                double r = double.Parse(interestRateTextBox.Text);
                double sigma = double.Parse(volatilityTextBox.Text);
                double T = double.Parse(timeTextBox.Text);

                double d1 = (Math.Log(S / K) + (r + 0.5 * Math.Pow(sigma, 2)) * T) / (sigma * Math.Sqrt(T));
                double d2 = d1 - sigma * Math.Sqrt(T);

                double Nd1 = NormalDistribution(d1);
                double Nd2 = NormalDistribution(d2);

                double callOptionPrice = S * Nd1 - K * Math.Exp(-r * T) * Nd2;

                resultLabel.Text = callOptionPrice.ToString("0.00");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
