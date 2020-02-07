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
    public partial class MainFormBank : Form
    {
        public MainFormBank()
        {
            InitializeComponent();
        }

        private void MainFormBank_Load(object sender, EventArgs e)
        {
            pbWallet.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWallet.Load(@"../../Res/wallet.PNG");
        }
    }
}
