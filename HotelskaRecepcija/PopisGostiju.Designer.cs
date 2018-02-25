namespace HotelskaRecepcija
{
    partial class PopisGostiju
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Prezime});
            this.listView1.Location = new System.Drawing.Point(32, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 456);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Popis svih gostiju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Popis trenutnih gostiju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ime
            // 
            this.Ime.Text = "Prezime";
            this.Ime.Width = 197;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Ime";
            this.Prezime.Width = 194;
            // 
            // PopisGostiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 506);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "PopisGostiju";
            this.Text = "PopisGostiju";
            this.Shown += new System.EventHandler(this.PopisGostiju_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
    }
}