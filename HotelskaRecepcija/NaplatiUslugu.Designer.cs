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
            this.cijenaUsluge = new System.Windows.Forms.DomainUpDown();
            this.cijena = new System.Windows.Forms.Label();
            this.IzdajRacun = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Usluga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iznos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ukupno = new System.Windows.Forms.Label();
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
            this.Naplati.Location = new System.Drawing.Point(62, 261);
            this.Naplati.Name = "Naplati";
            this.Naplati.Size = new System.Drawing.Size(105, 49);
            this.Naplati.TabIndex = 3;
            this.Naplati.Text = "Naplati";
            this.Naplati.UseVisualStyleBackColor = true;
            this.Naplati.Click += new System.EventHandler(this.Naplati_Click);
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
            // cijenaUsluge
            // 
            this.cijenaUsluge.Location = new System.Drawing.Point(185, 199);
            this.cijenaUsluge.Name = "cijenaUsluge";
            this.cijenaUsluge.Size = new System.Drawing.Size(220, 22);
            this.cijenaUsluge.TabIndex = 7;
            this.cijenaUsluge.Text = "Cijena";
            // 
            // cijena
            // 
            this.cijena.AutoSize = true;
            this.cijena.Location = new System.Drawing.Point(59, 204);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(51, 17);
            this.cijena.TabIndex = 8;
            this.cijena.Text = "Cijena:";
            // 
            // IzdajRacun
            // 
            this.IzdajRacun.Location = new System.Drawing.Point(243, 261);
            this.IzdajRacun.Name = "IzdajRacun";
            this.IzdajRacun.Size = new System.Drawing.Size(100, 49);
            this.IzdajRacun.TabIndex = 9;
            this.IzdajRacun.Text = "Račun";
            this.IzdajRacun.UseVisualStyleBackColor = true;
            this.IzdajRacun.Click += new System.EventHandler(this.IzdajRacun_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Usluga,
            this.Iznos});
            this.listView1.Location = new System.Drawing.Point(85, 354);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 210);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Usluga
            // 
            this.Usluga.Text = "Usluga";
            this.Usluga.Width = 182;
            // 
            // Iznos
            // 
            this.Iznos.Text = "Cijena";
            this.Iznos.Width = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ukupno:";
            // 
            // ukupno
            // 
            this.ukupno.AutoSize = true;
            this.ukupno.Location = new System.Drawing.Point(222, 603);
            this.ukupno.Name = "ukupno";
            this.ukupno.Size = new System.Drawing.Size(0, 17);
            this.ukupno.TabIndex = 12;
            // 
            // NaplatiUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 692);
            this.Controls.Add(this.ukupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IzdajRacun);
            this.Controls.Add(this.cijena);
            this.Controls.Add(this.cijenaUsluge);
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
        private System.Windows.Forms.DomainUpDown cijenaUsluge;
        private System.Windows.Forms.Label cijena;
        private System.Windows.Forms.Button IzdajRacun;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Usluga;
        private System.Windows.Forms.ColumnHeader Iznos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ukupno;
    }
}