namespace HotelskaRecepcija
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownSobe = new System.Windows.Forms.ToolStripDropDownButton();
            this.pregledajDostupneSobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.popisGostijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervirajNovuSobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownSobe,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(576, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownSobe
            // 
            this.toolStripDropDownSobe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownSobe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajDostupneSobeToolStripMenuItem,
            this.rezervirajNovuSobuToolStripMenuItem});
            this.toolStripDropDownSobe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownSobe.Image")));
            this.toolStripDropDownSobe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownSobe.Name = "toolStripDropDownSobe";
            this.toolStripDropDownSobe.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownSobe.Text = "Sobe";
            // 
            // pregledajDostupneSobeToolStripMenuItem
            // 
            this.pregledajDostupneSobeToolStripMenuItem.Name = "pregledajDostupneSobeToolStripMenuItem";
            this.pregledajDostupneSobeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pregledajDostupneSobeToolStripMenuItem.Text = "Pregledaj dostupne sobe";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisGostijuToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // popisGostijuToolStripMenuItem
            // 
            this.popisGostijuToolStripMenuItem.Name = "popisGostijuToolStripMenuItem";
            this.popisGostijuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.popisGostijuToolStripMenuItem.Text = "Popis gostiju";
            // 
            // rezervirajNovuSobuToolStripMenuItem
            // 
            this.rezervirajNovuSobuToolStripMenuItem.Name = "rezervirajNovuSobuToolStripMenuItem";
            this.rezervirajNovuSobuToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rezervirajNovuSobuToolStripMenuItem.Text = "Rezerviraj novu sobu";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 440);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Homepage";
            this.Text = "Home page";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownSobe;
        private System.Windows.Forms.ToolStripMenuItem pregledajDostupneSobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervirajNovuSobuToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem popisGostijuToolStripMenuItem;
    }
}

