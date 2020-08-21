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
    public partial class NewRek : Form
    {
        private string[] Soorten = new string[] { "Debit", "Credit", "Spaar" };
        public NewRek()
        {
            InitializeComponent();
        }
        private void NewRek_Load(object sender, EventArgs e)
        {
            cbSoort.Items.AddRange(Soorten);
            cbSoort.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        }

    }
}
