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
        public List<IncomeKredit> incomeKredits = new List<IncomeKredit>();
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
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
        }

        private void TrackSrok_Scroll(object sender, EventArgs e)
        {
            tbSrok.Text = (trackSrok.Value * 30).ToString();
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
        }

        private void TrackEveryMonth_Scroll(object sender, EventArgs e)
        {
            tbEveryMonthPayment.Text = (trackEveryMonth.Value * 10000).ToString();
            lOptimalincome.Text = calc.IncomeOptimal(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lStabIncome.Text = calc.IncomeStable(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
            lClassicIncome.Text = calc.IncomeClassic(double.Parse(tbSum.Text), int.Parse(tbSrok.Text)).ToString("0.00");
        }

        private void bEqualsParam_Click(object sender, EventArgs e)
        {
            incomeKredits.Add(new IncomeKredit()
            {
                name = "Стабильный",
                income = double.Parse(lStabIncome.Text),
                percent = 8
                
            });
            incomeKredits.Add(new IncomeKredit()
            {
                name = "Оптимальный",
                income = double.Parse(lOptimalincome.Text),
                percent = 5
            });
            incomeKredits.Add(new IncomeKredit()
            {
                name = "Стандартный",
                income = double.Parse(lClassicIncome.Text),
                percent = 6
            });

            ComparisonIncome comparison = new ComparisonIncome();
            this.Hide();
            comparison.incomeKredits = incomeKredits;
            comparison.ShowDialog();
            this.Show();
        }
    }


}
