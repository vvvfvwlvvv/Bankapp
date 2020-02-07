using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMoneyInPocket
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }
        Calculate calc = new Calculate();
        private void CalculateForm_Load(object sender, EventArgs e)
        {
            pbWallet.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWallet.Load(@"../../Res/wallet.PNG");
            tbSum.Text = (trackSum.Value * 10000).ToString();
            tbSrok.Text = (trackSrok.Value * 30).ToString();
            tbEveryMonthPayment.Text = (trackEveryMonth.Value * 10000).ToString();
        }

        private void TrackSum_Scroll(object sender, EventArgs e)
        {
            tbSum.Text = (trackSum.Value * 10000).ToString();
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
        }

        private void TrackSrok_Scroll(object sender, EventArgs e)
        {
            tbSrok.Text = (trackSrok.Value * 30).ToString();
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
        }

        private void TrackEveryMonth_Scroll(object sender, EventArgs e)
        {
            tbEveryMonthPayment.Text = (trackEveryMonth.Value * 10000).ToString();
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text), int.Parse(tbEveryMonthPayment.Text)).ToString("0.00");
        }
    }
}
