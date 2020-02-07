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

        public double IncomeClassic(double sum, int srok, int payment)
        {
            for (int countMontn = 1; countMontn <= srok; countMontn++)
            {
                //sum += payment;
                return sum = srok * Math.Pow((1 + ((5*30)/100*365)), srok/30);
            }
            return sum;
        }

        public double IncomeOptimal(double sum, int srok, int payment)
        {
            for (int countMontn = 1; countMontn <= srok; countMontn++)
            {
                sum += payment;
                sum += sum * 0.6;
            }
            return sum;
        }
    }
}
