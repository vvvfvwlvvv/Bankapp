using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMoneyInPocket
{
    public class Calculate
    {
        public double IncomeStable(double sum, int srok)
        {
            return sum = ((sum * 8 * srok)/(365*100));
        }

        public double IncomeClassic(double sum, int srok)
        {
            return sum = ((sum * 8 * srok) / (365 * 100));
        }

        public double IncomeOptimal(double sum, int srok)
        {
            return sum = (sum * Math.Pow(1 + (5.00 * 30.00 / (100 * 365)), srok / 30)) - sum;
        }
    }
}
