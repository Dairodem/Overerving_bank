using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overerving_bank
{
    
    public partial class MainRekening : Form
    {

        public MainRekening()
        {
            InitializeComponent();
        }

        private void MainRekening_Load(object sender, EventArgs e)
        {
            Bank myBank = new Bank();

            cbRekeningen.DataSource = myBank.RekList;

        }
    }
}
