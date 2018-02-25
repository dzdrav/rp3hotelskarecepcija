namespace HotelskaRecepcija
{
    partial class NaplatiUslugu
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
            this.naplatiIme = new System.Windows.Forms.Label();
            this.prezimeGosta = new System.Windows.Forms.Label();
            this.uslugaNpl = new System.Windows.Forms.Label();
            this.Naplati = new System.Windows.Forms.Button();
            this.imeGostaNaplati = new System.Windows.Forms.TextBox();
            this.prezimeGostaNaplati = new System.Windows.Forms.TextBox();
            this.naplataUsluge = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // naplatiIme
            // 
            this.naplatiIme.AutoSize = true;
            this.naplatiIme.Location = new System.Drawing.Point(59, 43);
            this.naplatiIme.Name = "naplatiIme";
            this.naplatiIme.Size = new System.Drawing.Size(73, 17);
            this.naplatiIme.TabIndex = 0;
            this.naplatiIme.Text = "Ime gosta:";
            // 
            // prezimeGosta
            // 
            this.prezimeGosta.AutoSize = true;
            this.prezimeGosta.Location = new System.Drawing.Point(59, 92);
            this.prezimeGosta.Name = "prezimeGosta";
            this.prezimeGosta.Size = new System.Drawing.Size(105, 17);
            this.prezimeGosta.TabIndex = 1;
            this.prezimeGosta.Text = "Prezime Gosta:";
            // 
            // uslugaNpl
            // 
            this.uslugaNpl.AutoSize = true;
            this.uslugaNpl.Location = new System.Drawing.Point(59, 144);
            this.uslugaNpl.Name = "uslugaNpl";
            this.uslugaNpl.Size = new System.Drawing.Size(56, 17);
            this.uslugaNpl.TabIndex = 2;
            this.uslugaNpl.Text = "Usluga:";
            // 
            // Naplati
            // 
            this.Naplati.Location = new System.Drawing.Point(155, 208);
            this.Naplati.Name = "Naplati";
            this.Naplati.Size = new System.Drawing.Size(105, 49);
            this.Naplati.TabIndex = 3;
            this.Naplati.Text = "Naplati";
            this.Naplati.UseVisualStyleBackColor = true;
            // 
            // imeGostaNaplati
            // 
            this.imeGostaNaplati.Location = new System.Drawing.Point(198, 38);
            this.imeGostaNaplati.Name = "imeGostaNaplati";
            this.imeGostaNaplati.Size = new System.Drawing.Size(100, 22);
            this.imeGostaNaplati.TabIndex = 4;
            // 
            // prezimeGostaNaplati
            // 
            this.prezimeGostaNaplati.Location = new System.Drawing.Point(198, 92);
            this.prezimeGostaNaplati.Name = "prezimeGostaNaplati";
            this.prezimeGostaNaplati.Size = new System.Drawing.Size(100, 22);
            this.prezimeGostaNaplati.TabIndex = 5;
            // 
            // naplataUsluge
            // 
            this.naplataUsluge.Location = new System.Drawing.Point(198, 144);
            this.naplataUsluge.Name = "naplataUsluge";
            this.naplataUsluge.Size = new System.Drawing.Size(208, 22);
            this.naplataUsluge.TabIndex = 6;
            this.naplataUsluge.Text = "Usluga";
            this.naplataUsluge.Wrap = true;
            // 
            // NaplatiUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 404);
            this.Controls.Add(this.naplataUsluge);
            this.Controls.Add(this.prezimeGostaNaplati);
            this.Controls.Add(this.imeGostaNaplati);
            this.Controls.Add(this.Naplati);
            this.Controls.Add(this.uslugaNpl);
            this.Controls.Add(this.prezimeGosta);
            this.Controls.Add(this.naplatiIme);
            this.Name = "NaplatiUslugu";
            this.Text = "NaplatiUslugu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naplatiIme;
        private System.Windows.Forms.Label prezimeGosta;
        private System.Windows.Forms.Label uslugaNpl;
        private System.Windows.Forms.Button Naplati;
        private System.Windows.Forms.TextBox imeGostaNaplati;
        private System.Windows.Forms.TextBox prezimeGostaNaplati;
        private System.Windows.Forms.DomainUpDown naplataUsluge;
    }
}