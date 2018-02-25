namespace HotelskaRecepcija
{
    partial class DodajZaposlenika
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
            this.imeNovogZaposlenika = new System.Windows.Forms.Label();
            this.PrezimeNovogZaposlenika = new System.Windows.Forms.Label();
            this.ZaduzenjeNovogZaposlenika = new System.Windows.Forms.Label();
            this.PocetakNovogZaduzenja = new System.Windows.Forms.Label();
            this.KrajNovogZaduzenja = new System.Windows.Forms.Label();
            this.SmjenaNovogZaposlenika = new System.Windows.Forms.Label();
            this.NovoIme = new System.Windows.Forms.TextBox();
            this.NovoPrezime = new System.Windows.Forms.TextBox();
            this.NovoZaduzenje = new System.Windows.Forms.TextBox();
            this.dodajNovogZaposlenika = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pocetakNovog = new System.Windows.Forms.DateTimePicker();
            this.krajNovog = new System.Windows.Forms.DateTimePicker();
            this.smjenaNovog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imeNovogZaposlenika
            // 
            this.imeNovogZaposlenika.AutoSize = true;
            this.imeNovogZaposlenika.Location = new System.Drawing.Point(33, 41);
            this.imeNovogZaposlenika.Name = "imeNovogZaposlenika";
            this.imeNovogZaposlenika.Size = new System.Drawing.Size(34, 17);
            this.imeNovogZaposlenika.TabIndex = 0;
            this.imeNovogZaposlenika.Text = "&Ime:";
            // 
            // PrezimeNovogZaposlenika
            // 
            this.PrezimeNovogZaposlenika.AutoSize = true;
            this.PrezimeNovogZaposlenika.Location = new System.Drawing.Point(33, 92);
            this.PrezimeNovogZaposlenika.Name = "PrezimeNovogZaposlenika";
            this.PrezimeNovogZaposlenika.Size = new System.Drawing.Size(63, 17);
            this.PrezimeNovogZaposlenika.TabIndex = 1;
            this.PrezimeNovogZaposlenika.Text = "&Prezime:";
            // 
            // ZaduzenjeNovogZaposlenika
            // 
            this.ZaduzenjeNovogZaposlenika.AutoSize = true;
            this.ZaduzenjeNovogZaposlenika.Location = new System.Drawing.Point(33, 142);
            this.ZaduzenjeNovogZaposlenika.Name = "ZaduzenjeNovogZaposlenika";
            this.ZaduzenjeNovogZaposlenika.Size = new System.Drawing.Size(79, 17);
            this.ZaduzenjeNovogZaposlenika.TabIndex = 2;
            this.ZaduzenjeNovogZaposlenika.Text = "&Zaduženje:";
            // 
            // PocetakNovogZaduzenja
            // 
            this.PocetakNovogZaduzenja.AutoSize = true;
            this.PocetakNovogZaduzenja.Location = new System.Drawing.Point(33, 198);
            this.PocetakNovogZaduzenja.Name = "PocetakNovogZaduzenja";
            this.PocetakNovogZaduzenja.Size = new System.Drawing.Size(31, 17);
            this.PocetakNovogZaduzenja.TabIndex = 3;
            this.PocetakNovogZaduzenja.Text = "Od:";
            // 
            // KrajNovogZaduzenja
            // 
            this.KrajNovogZaduzenja.AutoSize = true;
            this.KrajNovogZaduzenja.Location = new System.Drawing.Point(33, 243);
            this.KrajNovogZaduzenja.Name = "KrajNovogZaduzenja";
            this.KrajNovogZaduzenja.Size = new System.Drawing.Size(30, 17);
            this.KrajNovogZaduzenja.TabIndex = 4;
            this.KrajNovogZaduzenja.Text = "Do:";
            // 
            // SmjenaNovogZaposlenika
            // 
            this.SmjenaNovogZaposlenika.AutoSize = true;
            this.SmjenaNovogZaposlenika.Location = new System.Drawing.Point(33, 302);
            this.SmjenaNovogZaposlenika.Name = "SmjenaNovogZaposlenika";
            this.SmjenaNovogZaposlenika.Size = new System.Drawing.Size(55, 17);
            this.SmjenaNovogZaposlenika.TabIndex = 5;
            this.SmjenaNovogZaposlenika.Text = "&Smjena";
            // 
            // NovoIme
            // 
            this.NovoIme.Location = new System.Drawing.Point(255, 36);
            this.NovoIme.Name = "NovoIme";
            this.NovoIme.Size = new System.Drawing.Size(100, 22);
            this.NovoIme.TabIndex = 6;
            // 
            // NovoPrezime
            // 
            this.NovoPrezime.Location = new System.Drawing.Point(255, 87);
            this.NovoPrezime.Name = "NovoPrezime";
            this.NovoPrezime.Size = new System.Drawing.Size(100, 22);
            this.NovoPrezime.TabIndex = 7;
            // 
            // NovoZaduzenje
            // 
            this.NovoZaduzenje.Location = new System.Drawing.Point(255, 137);
            this.NovoZaduzenje.Name = "NovoZaduzenje";
            this.NovoZaduzenje.Size = new System.Drawing.Size(100, 22);
            this.NovoZaduzenje.TabIndex = 8;
            // 
            // dodajNovogZaposlenika
            // 
            this.dodajNovogZaposlenika.Location = new System.Drawing.Point(150, 365);
            this.dodajNovogZaposlenika.Name = "dodajNovogZaposlenika";
            this.dodajNovogZaposlenika.Size = new System.Drawing.Size(105, 41);
            this.dodajNovogZaposlenika.TabIndex = 12;
            this.dodajNovogZaposlenika.Text = "Dodaj";
            this.dodajNovogZaposlenika.UseVisualStyleBackColor = true;
            this.dodajNovogZaposlenika.Click += new System.EventHandler(this.dodajNovogZaposlenika_Click);
            // 
            // pocetakNovog
            // 
            this.pocetakNovog.Location = new System.Drawing.Point(255, 182);
            this.pocetakNovog.Name = "pocetakNovog";
            this.pocetakNovog.Size = new System.Drawing.Size(200, 22);
            this.pocetakNovog.TabIndex = 13;
            // 
            // krajNovog
            // 
            this.krajNovog.Location = new System.Drawing.Point(255, 238);
            this.krajNovog.Name = "krajNovog";
            this.krajNovog.Size = new System.Drawing.Size(200, 22);
            this.krajNovog.TabIndex = 14;
            // 
            // smjenaNovog
            // 
            this.smjenaNovog.Location = new System.Drawing.Point(255, 297);
            this.smjenaNovog.Name = "smjenaNovog";
            this.smjenaNovog.Size = new System.Drawing.Size(107, 22);
            this.smjenaNovog.TabIndex = 15;
            // 
            // DodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 434);
            this.Controls.Add(this.smjenaNovog);
            this.Controls.Add(this.krajNovog);
            this.Controls.Add(this.pocetakNovog);
            this.Controls.Add(this.dodajNovogZaposlenika);
            this.Controls.Add(this.NovoZaduzenje);
            this.Controls.Add(this.NovoPrezime);
            this.Controls.Add(this.NovoIme);
            this.Controls.Add(this.SmjenaNovogZaposlenika);
            this.Controls.Add(this.KrajNovogZaduzenja);
            this.Controls.Add(this.PocetakNovogZaduzenja);
            this.Controls.Add(this.ZaduzenjeNovogZaposlenika);
            this.Controls.Add(this.PrezimeNovogZaposlenika);
            this.Controls.Add(this.imeNovogZaposlenika);
            this.Name = "DodajZaposlenika";
            this.Text = "DodajZaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeNovogZaposlenika;
        private System.Windows.Forms.Label PrezimeNovogZaposlenika;
        private System.Windows.Forms.Label ZaduzenjeNovogZaposlenika;
        private System.Windows.Forms.Label PocetakNovogZaduzenja;
        private System.Windows.Forms.Label KrajNovogZaduzenja;
        private System.Windows.Forms.Label SmjenaNovogZaposlenika;
        private System.Windows.Forms.TextBox NovoIme;
        private System.Windows.Forms.TextBox NovoPrezime;
        private System.Windows.Forms.TextBox NovoZaduzenje;
        private System.Windows.Forms.Button dodajNovogZaposlenika;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker pocetakNovog;
        private System.Windows.Forms.DateTimePicker krajNovog;
        private System.Windows.Forms.TextBox smjenaNovog;
    }
}