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
        Bank myBank;
        public MainRekening()
        {
            InitializeComponent();
        }

        private void MainRekening_Load(object sender, EventArgs e)
        {
            myBank = new Bank();

            cbRekeningen.DataSource = myBank.RekList;

        }

        private void btnNewRek_Click(object sender, EventArgs e)
        {
            NewRek newRekForm = new NewRek();

        }

        private void cbRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: {myBank.RekList[cbRekeningen.SelectedIndex].Saldo.ToString()}";
        }

        private void btnOverschrijving_Click(object sender, EventArgs e)
        {
            OverschrijvingsForm overschrijvingsForm = new OverschrijvingsForm();

            if (overschrijvingsForm.ShowDialog() == DialogResult.OK)
            {
                myBank.RekList[cbRekeningen.SelectedIndex].Saldo -= overschrijvingsForm.Bedrag; 
            }

        }
    }
}
