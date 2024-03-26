using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            double t = 1.0 / (1.0 + 0.5 * Math.Abs(x));
            double tau = t * Math.Exp(-Math.Pow(x, 2) - 1.26551223 + t * (1.00002368 + t * (0.37409196 + t * (0.09678418 + t * (-0.18628806 + t * (0.27886807 + t * (-1.13520398 + t * (1.48851587 + t * (-0.82215223 + t * 0.17087277)))))))));
            double erf = x >= 0 ? 1 - tau : tau - 1;
            return erf;
        }

        private void PerformCalculation_Click(object sender, EventArgs e)
        {
            double callOptionPrice = 0.0; // Определяем переменную перед блоком try

            try
            {
                double S = double.Parse(stockPriceTextBox.Text);
                double K = double.Parse(strikePriceTextBox.Text);
                double r = double.Parse(interestRateTextBox.Text);
                double sigma = double.Parse(volatilityTextBox.Text);
                double T = double.Parse(timeTextBox.Text);

                // Очищаем существующие данные на графике
                chart1.Series["OptionPrice"].Points.Clear();

                // Добавляем данные на график
                for (double t = 0.1; t <= T; t += 0.1)
                {
                    double d1 = (Math.Log(S / K) + (r + 0.5 * Math.Pow(sigma, 2)) * t) / (sigma * Math.Sqrt(t));
                    double d2 = d1 - sigma * Math.Sqrt(t);

                    double Nd1 = NormalDistribution(d1);
                    double Nd2 = NormalDistribution(d2);

                    callOptionPrice = S * Nd1 - K * Math.Exp(-r * t) * Nd2; // Присваиваем значение переменной
                    chart1.Series["OptionPrice"].Points.AddXY(t, callOptionPrice);
                }

                resultLabel.Text = callOptionPrice.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }   
        
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Option Price";
            chart1.Series.Add("OptionPrice");
            chart1.Series["OptionPrice"].ChartType = SeriesChartType.Line;
        }
    }
}
