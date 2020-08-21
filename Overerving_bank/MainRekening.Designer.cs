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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOverschrijving = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRekeningen
            // 
            this.cbRekeningen.FormattingEnabled = true;
            this.cbRekeningen.Location = new System.Drawing.Point(13, 13);
            this.cbRekeningen.Name = "cbRekeningen";
            this.cbRekeningen.Size = new System.Drawing.Size(230, 21);
            this.cbRekeningen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo: € 10.000";
            // 
            // btnOverschrijving
            // 
            this.btnOverschrijving.Location = new System.Drawing.Point(263, 50);
            this.btnOverschrijving.Name = "btnOverschrijving";
            this.btnOverschrijving.Size = new System.Drawing.Size(167, 23);
            this.btnOverschrijving.TabIndex = 2;
            this.btnOverschrijving.Text = "Nieuwe Overschrijving";
            this.btnOverschrijving.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nieuwe Rekening";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainRekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOverschrijving);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRekeningen);
            this.Name = "MainRekening";
            this.Text = "MainRekening";
            this.Load += new System.EventHandler(this.MainRekening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRekeningen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOverschrijving;
        private System.Windows.Forms.Button button1;
    }
}