namespace HotelskaRecepcija
{
    partial class RezervirajUslugu
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
            this.imeRezerv = new System.Windows.Forms.Label();
            this.prezimRezerv = new System.Windows.Forms.Label();
            this.uslugaRezerv = new System.Windows.Forms.Label();
            this.datumRezerv = new System.Windows.Forms.Label();
            this.terminRezerv = new System.Windows.Forms.Label();
            this.imeGostaRezervacija = new System.Windows.Forms.TextBox();
            this.prezimeGostaRezervacija = new System.Windows.Forms.TextBox();
            this.terminRezervacija = new System.Windows.Forms.TextBox();
            this.uslugeRezervacija = new System.Windows.Forms.DomainUpDown();
            this.datumRezervacija = new System.Windows.Forms.DateTimePicker();
            this.RezervirajUsluga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imeRezerv
            // 
            this.imeRezerv.AutoSize = true;
            this.imeRezerv.Location = new System.Drawing.Point(32, 59);
            this.imeRezerv.Name = "imeRezerv";
            this.imeRezerv.Size = new System.Drawing.Size(69, 17);
            this.imeRezerv.TabIndex = 0;
            this.imeRezerv.Text = "Ime gosta";
            // 
            // prezimRezerv
            // 
            this.prezimRezerv.AutoSize = true;
            this.prezimRezerv.Location = new System.Drawing.Point(32, 103);
            this.prezimRezerv.Name = "prezimRezerv";
            this.prezimRezerv.Size = new System.Drawing.Size(102, 17);
            this.prezimRezerv.TabIndex = 1;
            this.prezimRezerv.Text = "Prezime gosta:";
            // 
            // uslugaRezerv
            // 
            this.uslugaRezerv.AutoSize = true;
            this.uslugaRezerv.Location = new System.Drawing.Point(32, 144);
            this.uslugaRezerv.Name = "uslugaRezerv";
            this.uslugaRezerv.Size = new System.Drawing.Size(56, 17);
            this.uslugaRezerv.TabIndex = 2;
            this.uslugaRezerv.Text = "Usluga:";
            // 
            // datumRezerv
            // 
            this.datumRezerv.AutoSize = true;
            this.datumRezerv.Location = new System.Drawing.Point(32, 190);
            this.datumRezerv.Name = "datumRezerv";
            this.datumRezerv.Size = new System.Drawing.Size(53, 17);
            this.datumRezerv.TabIndex = 3;
            this.datumRezerv.Text = "Datum:";
            // 
            // terminRezerv
            // 
            this.terminRezerv.AutoSize = true;
            this.terminRezerv.Location = new System.Drawing.Point(32, 239);
            this.terminRezerv.Name = "terminRezerv";
            this.terminRezerv.Size = new System.Drawing.Size(56, 17);
            this.terminRezerv.TabIndex = 4;
            this.terminRezerv.Text = "Termin:";
            // 
            // imeGostaRezervacija
            // 
            this.imeGostaRezervacija.Location = new System.Drawing.Point(197, 54);
            this.imeGostaRezervacija.Name = "imeGostaRezervacija";
            this.imeGostaRezervacija.Size = new System.Drawing.Size(100, 22);
            this.imeGostaRezervacija.TabIndex = 5;
            // 
            // prezimeGostaRezervacija
            // 
            this.prezimeGostaRezervacija.Location = new System.Drawing.Point(197, 103);
            this.prezimeGostaRezervacija.Name = "prezimeGostaRezervacija";
            this.prezimeGostaRezervacija.Size = new System.Drawing.Size(100, 22);
            this.prezimeGostaRezervacija.TabIndex = 6;
            // 
            // terminRezervacija
            // 
            this.terminRezervacija.Location = new System.Drawing.Point(197, 234);
            this.terminRezervacija.Name = "terminRezervacija";
            this.terminRezervacija.Size = new System.Drawing.Size(100, 22);
            this.terminRezervacija.TabIndex = 7;
            // 
            // uslugeRezervacija
            // 
            this.uslugeRezervacija.Location = new System.Drawing.Point(197, 144);
            this.uslugeRezervacija.Name = "uslugeRezervacija";
            this.uslugeRezervacija.Size = new System.Drawing.Size(206, 22);
            this.uslugeRezervacija.TabIndex = 8;
            this.uslugeRezervacija.Text = "Usluga";
            this.uslugeRezervacija.Wrap = true;
            // 
            // datumRezervacija
            // 
            this.datumRezervacija.Location = new System.Drawing.Point(197, 185);
            this.datumRezervacija.Name = "datumRezervacija";
            this.datumRezervacija.Size = new System.Drawing.Size(200, 22);
            this.datumRezervacija.TabIndex = 9;
            // 
            // RezervirajUsluga
            // 
            this.RezervirajUsluga.Location = new System.Drawing.Point(116, 293);
            this.RezervirajUsluga.Name = "RezervirajUsluga";
            this.RezervirajUsluga.Size = new System.Drawing.Size(117, 43);
            this.RezervirajUsluga.TabIndex = 10;
            this.RezervirajUsluga.Text = "Rezerviraj";
            this.RezervirajUsluga.UseVisualStyleBackColor = true;
            this.RezervirajUsluga.Click += new System.EventHandler(this.RezervirajUsluga_Click);
            // 
            // RezervirajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 404);
            this.Controls.Add(this.RezervirajUsluga);
            this.Controls.Add(this.datumRezervacija);
            this.Controls.Add(this.uslugeRezervacija);
            this.Controls.Add(this.terminRezervacija);
            this.Controls.Add(this.prezimeGostaRezervacija);
            this.Controls.Add(this.imeGostaRezervacija);
            this.Controls.Add(this.terminRezerv);
            this.Controls.Add(this.datumRezerv);
            this.Controls.Add(this.uslugaRezerv);
            this.Controls.Add(this.prezimRezerv);
            this.Controls.Add(this.imeRezerv);
            this.Name = "RezervirajUslugu";
            this.Text = "RezervirajUslugu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeRezerv;
        private System.Windows.Forms.Label prezimRezerv;
        private System.Windows.Forms.Label uslugaRezerv;
        private System.Windows.Forms.Label datumRezerv;
        private System.Windows.Forms.Label terminRezerv;
        private System.Windows.Forms.TextBox imeGostaRezervacija;
        private System.Windows.Forms.TextBox prezimeGostaRezervacija;
        private System.Windows.Forms.TextBox terminRezervacija;
        private System.Windows.Forms.DomainUpDown uslugeRezervacija;
        private System.Windows.Forms.DateTimePicker datumRezervacija;
        private System.Windows.Forms.Button RezervirajUsluga;
    }
}