namespace Overerving_bank
{
    partial class OverschrijvingsForm
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
            this.cbNaarRek = new System.Windows.Forms.ComboBox();
            this.btnSchrijfOver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaarRek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numBedrag = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBedrag)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNaarRek
            // 
            this.cbNaarRek.FormattingEnabled = true;
            this.cbNaarRek.Location = new System.Drawing.Point(12, 87);
            this.cbNaarRek.Name = "cbNaarRek";
            this.cbNaarRek.Size = new System.Drawing.Size(255, 21);
            this.cbNaarRek.TabIndex = 0;
            // 
            // btnSchrijfOver
            // 
            this.btnSchrijfOver.Location = new System.Drawing.Point(11, 180);
            this.btnSchrijfOver.Name = "btnSchrijfOver";
            this.btnSchrijfOver.Size = new System.Drawing.Size(255, 31);
            this.btnSchrijfOver.TabIndex = 1;
            this.btnSchrijfOver.Text = "Schrijf over";
            this.btnSchrijfOver.UseVisualStyleBackColor = true;
            this.btnSchrijfOver.Click += new System.EventHandler(this.btnSchrijfOver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naar gekende rekening";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naar nieuwe rekening:";
            // 
            // txtNaarRek
            // 
            this.txtNaarRek.Location = new System.Drawing.Point(34, 129);
            this.txtNaarRek.Name = "txtNaarRek";
            this.txtNaarRek.Size = new System.Drawing.Size(233, 20);
            this.txtNaarRek.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BE";
            // 
            // numBedrag
            // 
            this.numBedrag.Location = new System.Drawing.Point(12, 43);
            this.numBedrag.Name = "numBedrag";
            this.numBedrag.Size = new System.Drawing.Size(255, 20);
            this.numBedrag.TabIndex = 8;
            this.numBedrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OverschrijvingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 223);
            this.Controls.Add(this.numBedrag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaarRek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchrijfOver);
            this.Controls.Add(this.cbNaarRek);
            this.Name = "OverschrijvingsForm";
            this.Text = "OverschrijvingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numBedrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNaarRek;
        private System.Windows.Forms.Button btnSchrijfOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaarRek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBedrag;
    }
}