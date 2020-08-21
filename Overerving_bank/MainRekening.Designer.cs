namespace Overerving_bank
{
    partial class MainRekening
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbRekeningen = new System.Windows.Forms.ComboBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnOverschrijving = new System.Windows.Forms.Button();
            this.btnNewRek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRekeningen
            // 
            this.cbRekeningen.FormattingEnabled = true;
            this.cbRekeningen.Location = new System.Drawing.Point(13, 13);
            this.cbRekeningen.Name = "cbRekeningen";
            this.cbRekeningen.Size = new System.Drawing.Size(230, 21);
            this.cbRekeningen.TabIndex = 0;
            this.cbRekeningen.SelectedIndexChanged += new System.EventHandler(this.cbRekeningen_SelectedIndexChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(284, 16);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(82, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo: € 10.000";
            // 
            // btnOverschrijving
            // 
            this.btnOverschrijving.Location = new System.Drawing.Point(263, 50);
            this.btnOverschrijving.Name = "btnOverschrijving";
            this.btnOverschrijving.Size = new System.Drawing.Size(167, 23);
            this.btnOverschrijving.TabIndex = 2;
            this.btnOverschrijving.Text = "Nieuwe Overschrijving";
            this.btnOverschrijving.UseVisualStyleBackColor = true;
            this.btnOverschrijving.Click += new System.EventHandler(this.btnOverschrijving_Click);
            // 
            // btnNewRek
            // 
            this.btnNewRek.Location = new System.Drawing.Point(263, 89);
            this.btnNewRek.Name = "btnNewRek";
            this.btnNewRek.Size = new System.Drawing.Size(167, 23);
            this.btnNewRek.TabIndex = 3;
            this.btnNewRek.Text = "Nieuwe Rekening";
            this.btnNewRek.UseVisualStyleBackColor = true;
            this.btnNewRek.Click += new System.EventHandler(this.btnNewRek_Click);
            // 
            // MainRekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 126);
            this.Controls.Add(this.btnNewRek);
            this.Controls.Add(this.btnOverschrijving);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.cbRekeningen);
            this.Name = "MainRekening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainRekening";
            this.Load += new System.EventHandler(this.MainRekening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRekeningen;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnOverschrijving;
        private System.Windows.Forms.Button btnNewRek;
    }
}