namespace HotelskaRecepcija
{
    partial class DodajNovogGostaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelprezime = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodavanje novog gosta";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(22, 100);
            this.labelIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(30, 17);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime";
            // 
            // labelprezime
            // 
            this.labelprezime.AutoSize = true;
            this.labelprezime.Location = new System.Drawing.Point(22, 171);
            this.labelprezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprezime.Name = "labelprezime";
            this.labelprezime.Size = new System.Drawing.Size(59, 17);
            this.labelprezime.TabIndex = 2;
            this.labelprezime.Text = "Prezime";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(151, 95);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(151, 168);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrezime.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(151, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajNovogGostaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelprezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajNovogGostaForm";
            this.Text = "DodajNovogGostaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelprezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}