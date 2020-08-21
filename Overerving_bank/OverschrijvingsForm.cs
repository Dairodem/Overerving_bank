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
    public partial class OverschrijvingsForm : Form
    {
        public string ToRek;
        public double Bedrag = 0;
        public OverschrijvingsForm()
        {
            InitializeComponent();
        }

        private void btnSchrijfOver_Click(object sender, EventArgs e)
        {
            if (txtNaarRek.Text.Length > 0)
            {
                ToRek = txtNaarRek.Text;
                Bedrag = (double)numBedrag.Value;

            }
            this.DialogResult = DialogResult.OK;
        }

    }
}
