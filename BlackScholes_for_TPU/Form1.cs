using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BlackScholes_for_TPU
{
    public partial class Form1 : Form
    {
        private OptionCalculator calculator = new OptionCalculator();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация графика
            chart1.Series.Clear();
            chart1.Series.Add("CallOptionPrice");
            chart1.Series["CallOptionPrice"].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Title = "Time (t)";
            chart1.ChartAreas[0].AxisY.Title = "Call Option Price";
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

                chart1.Series["CallOptionPrice"].Points.Clear();

                for (double t = 0.1; t <= T; t += 0.1)
                {
                    double callOptionPrice = calculator.CalculateCallOptionPrice(S, K, r, sigma, T, t);
                    chart1.Series["CallOptionPrice"].Points.AddXY(t, callOptionPrice);
                    resultLabel.Text = callOptionPrice.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
