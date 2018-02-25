namespace HotelskaRecepcija
{
    partial class novoZaduzenje
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
            this.imeIzmj = new System.Windows.Forms.Label();
            this.prIzm = new System.Windows.Forms.Label();
            this.zaduzenjeIzm = new System.Windows.Forms.Label();
            this.pocetni = new System.Windows.Forms.Label();
            this.krajnji = new System.Windows.Forms.Label();
            this.smjizm = new System.Windows.Forms.Label();
            this.imeIzmjena = new System.Windows.Forms.TextBox();
            this.prezimeIzmjena = new System.Windows.Forms.TextBox();
            this.zaduzenjeIzmjena = new System.Windows.Forms.TextBox();
            this.smjenaIzmjena = new System.Windows.Forms.TextBox();
            this.pocetak = new System.Windows.Forms.DateTimePicker();
            this.krajZaduz = new System.Windows.Forms.DateTimePicker();
            this.izmjena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imeIzmj
            // 
            this.imeIzmj.AutoSize = true;
            this.imeIzmj.Location = new System.Drawing.Point(60, 38);
            this.imeIzmj.Name = "imeIzmj";
            this.imeIzmj.Size = new System.Drawing.Size(34, 17);
            this.imeIzmj.TabIndex = 0;
            this.imeIzmj.Text = "&Ime:";
            // 
            // prIzm
            // 
            this.prIzm.AutoSize = true;
            this.prIzm.Location = new System.Drawing.Point(60, 88);
            this.prIzm.Name = "prIzm";
            this.prIzm.Size = new System.Drawing.Size(59, 17);
            this.prIzm.TabIndex = 1;
            this.prIzm.Text = "&Prezime";
            // 
            // zaduzenjeIzm
            // 
            this.zaduzenjeIzm.AutoSize = true;
            this.zaduzenjeIzm.Location = new System.Drawing.Point(60, 137);
            this.zaduzenjeIzm.Name = "zaduzenjeIzm";
            this.zaduzenjeIzm.Size = new System.Drawing.Size(79, 17);
            this.zaduzenjeIzm.TabIndex = 2;
            this.zaduzenjeIzm.Text = "&Zaduženje:";
            // 
            // pocetni
            // 
            this.pocetni.AutoSize = true;
            this.pocetni.Location = new System.Drawing.Point(60, 186);
            this.pocetni.Name = "pocetni";
            this.pocetni.Size = new System.Drawing.Size(31, 17);
            this.pocetni.TabIndex = 3;
            this.pocetni.Text = "Od:";
            // 
            // krajnji
            // 
            this.krajnji.AutoSize = true;
            this.krajnji.Location = new System.Drawing.Point(60, 248);
            this.krajnji.Name = "krajnji";
            this.krajnji.Size = new System.Drawing.Size(30, 17);
            this.krajnji.TabIndex = 4;
            this.krajnji.Text = "Do:";
            // 
            // smjizm
            // 
            this.smjizm.AutoSize = true;
            this.smjizm.Location = new System.Drawing.Point(60, 299);
            this.smjizm.Name = "smjizm";
            this.smjizm.Size = new System.Drawing.Size(55, 17);
            this.smjizm.TabIndex = 5;
            this.smjizm.Text = "&Smjena";
            // 
            // imeIzmjena
            // 
            this.imeIzmjena.Location = new System.Drawing.Point(219, 33);
            this.imeIzmjena.Name = "imeIzmjena";
            this.imeIzmjena.Size = new System.Drawing.Size(100, 22);
            this.imeIzmjena.TabIndex = 6;
            // 
            // prezimeIzmjena
            // 
            this.prezimeIzmjena.Location = new System.Drawing.Point(219, 83);
            this.prezimeIzmjena.Name = "prezimeIzmjena";
            this.prezimeIzmjena.Size = new System.Drawing.Size(100, 22);
            this.prezimeIzmjena.TabIndex = 7;
            // 
            // zaduzenjeIzmjena
            // 
            this.zaduzenjeIzmjena.Location = new System.Drawing.Point(219, 132);
            this.zaduzenjeIzmjena.Name = "zaduzenjeIzmjena";
            this.zaduzenjeIzmjena.Size = new System.Drawing.Size(100, 22);
            this.zaduzenjeIzmjena.TabIndex = 8;
            // 
            // smjenaIzmjena
            // 
            this.smjenaIzmjena.Location = new System.Drawing.Point(219, 294);
            this.smjenaIzmjena.Name = "smjenaIzmjena";
            this.smjenaIzmjena.Size = new System.Drawing.Size(100, 22);
            this.smjenaIzmjena.TabIndex = 9;
            // 
            // pocetak
            // 
            this.pocetak.Location = new System.Drawing.Point(219, 186);
            this.pocetak.Name = "pocetak";
            this.pocetak.Size = new System.Drawing.Size(200, 22);
            this.pocetak.TabIndex = 10;
            // 
            // krajZaduz
            // 
            this.krajZaduz.Location = new System.Drawing.Point(219, 243);
            this.krajZaduz.Name = "krajZaduz";
            this.krajZaduz.Size = new System.Drawing.Size(200, 22);
            this.krajZaduz.TabIndex = 11;
            // 
            // izmjena
            // 
            this.izmjena.Location = new System.Drawing.Point(127, 346);
            this.izmjena.Name = "izmjena";
            this.izmjena.Size = new System.Drawing.Size(113, 36);
            this.izmjena.TabIndex = 12;
            this.izmjena.Text = "Izmijeni";
            this.izmjena.UseVisualStyleBackColor = true;
            this.izmjena.Click += new System.EventHandler(this.izmjena_Click);
            // 
            // novoZaduzenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 458);
            this.Controls.Add(this.izmjena);
            this.Controls.Add(this.krajZaduz);
            this.Controls.Add(this.pocetak);
            this.Controls.Add(this.smjenaIzmjena);
            this.Controls.Add(this.zaduzenjeIzmjena);
            this.Controls.Add(this.prezimeIzmjena);
            this.Controls.Add(this.imeIzmjena);
            this.Controls.Add(this.smjizm);
            this.Controls.Add(this.krajnji);
            this.Controls.Add(this.pocetni);
            this.Controls.Add(this.zaduzenjeIzm);
            this.Controls.Add(this.prIzm);
            this.Controls.Add(this.imeIzmj);
            this.Name = "novoZaduzenje";
            this.Text = "novoZaduzenje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeIzmj;
        private System.Windows.Forms.Label prIzm;
        private System.Windows.Forms.Label zaduzenjeIzm;
        private System.Windows.Forms.Label pocetni;
        private System.Windows.Forms.Label krajnji;
        private System.Windows.Forms.Label smjizm;
        private System.Windows.Forms.TextBox imeIzmjena;
        private System.Windows.Forms.TextBox prezimeIzmjena;
        private System.Windows.Forms.TextBox zaduzenjeIzmjena;
        private System.Windows.Forms.TextBox smjenaIzmjena;
        private System.Windows.Forms.DateTimePicker pocetak;
        private System.Windows.Forms.DateTimePicker krajZaduz;
        private System.Windows.Forms.Button izmjena;
    }
}