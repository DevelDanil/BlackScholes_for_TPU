using System;

namespace BlackScholes_for_TPU
{
    public class OptionCalculator
    {
        private double NormalDistribution(double x)
        {
            double t = 1.0 / (1.0 + 0.5 * Math.Abs(x));
            double tau = t * Math.Exp(-Math.Pow(x, 2) - 1.26551223 + t * (1.00002368 + t * (0.37409196 + t * (0.09678418 + t * (-0.18628806 + t * (0.27886807 + t * (-1.13520398 + t * (1.48851587 + t * (-0.82215223 + t * 0.17087277)))))))));
            double erf = x >= 0 ? 1 - tau : tau - 1;
            return erf;
        }

        public double CalculateCallOptionPrice(double S, double K, double r, double sigma, double T, double t)
        {
            double d1 = (Math.Log(S / K) + (r + 0.5 * Math.Pow(sigma, 2)) * t) / (sigma * Math.Sqrt(t));
            double d2 = d1 - sigma * Math.Sqrt(t);

            double Nd1 = NormalDistribution(d1);
            double Nd2 = NormalDistribution(d2);

            return S * Nd1 - K * Math.Exp(-r * t) * Nd2;
        }
    }
}
