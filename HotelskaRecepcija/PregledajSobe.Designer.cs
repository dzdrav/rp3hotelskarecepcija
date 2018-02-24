namespace HotelskaRecepcija
{
    partial class PregledajSobe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledajSobe));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label cIJENA_NOCENJALabel;
            System.Windows.Forms.Label kATLabel;
            System.Windows.Forms.Label aPARTMANLabel;
            this.buttonPrethodna = new System.Windows.Forms.Button();
            this.buttonSljedeca = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.splitContainerUpper = new System.Windows.Forms.SplitContainer();
            this.groupBoxKarakteristike = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hR_DatabaseDataSet = new HotelskaRecepcija.HR_DatabaseDataSet();
            this.hR_SOBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_SOBETableAdapter = new HotelskaRecepcija.HR_DatabaseDataSetTableAdapters.HR_SOBETableAdapter();
            this.tableAdapterManager = new HotelskaRecepcija.HR_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.hR_SOBEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hR_SOBEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cIJENA_NOCENJATextBox = new System.Windows.Forms.TextBox();
            this.kATTextBox = new System.Windows.Forms.TextBox();
            this.aPARTMANCheckBox = new System.Windows.Forms.CheckBox();
            this.hRKARAKTSOBABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_KARAKT_SOBATableAdapter = new HotelskaRecepcija.HR_DatabaseDataSetTableAdapters.HR_KARAKT_SOBATableAdapter();
            idLabel = new System.Windows.Forms.Label();
            cIJENA_NOCENJALabel = new System.Windows.Forms.Label();
            kATLabel = new System.Windows.Forms.Label();
            aPARTMANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUpper)).BeginInit();
            this.splitContainerUpper.Panel2.SuspendLayout();
            this.splitContainerUpper.SuspendLayout();
            this.groupBoxKarakteristike.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_SOBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_SOBEBindingNavigator)).BeginInit();
            this.hR_SOBEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRKARAKTSOBABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrethodna
            // 
            this.buttonPrethodna.Location = new System.Drawing.Point(3, 3);
            this.buttonPrethodna.Name = "buttonPrethodna";
            this.buttonPrethodna.Size = new System.Drawing.Size(75, 23);
            this.buttonPrethodna.TabIndex = 6;
            this.buttonPrethodna.Text = "Prethodna";
            this.buttonPrethodna.UseVisualStyleBackColor = true;
            // 
            // buttonSljedeca
            // 
            this.buttonSljedeca.Location = new System.Drawing.Point(84, 3);
            this.buttonSljedeca.Name = "buttonSljedeca";
            this.buttonSljedeca.Size = new System.Drawing.Size(75, 23);
            this.buttonSljedeca.TabIndex = 7;
            this.buttonSljedeca.Text = "Sljedeća";
            this.buttonSljedeca.UseVisualStyleBackColor = true;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZatvori.Location = new System.Drawing.Point(122, 3);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 9;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            this.splitContainerBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.splitContainerUpper);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerBody.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerBody.Size = new System.Drawing.Size(599, 400);
            this.splitContainerBody.SplitterDistance = 350;
            this.splitContainerBody.TabIndex = 15;
            // 
            // splitContainerUpper
            // 
            this.splitContainerUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUpper.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUpper.Name = "splitContainerUpper";
            this.splitContainerUpper.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerUpper.Panel2
            // 
            this.splitContainerUpper.Panel2.Controls.Add(this.groupBoxKarakteristike);
            this.splitContainerUpper.Size = new System.Drawing.Size(599, 350);
            this.splitContainerUpper.SplitterDistance = 32;
            this.splitContainerUpper.TabIndex = 0;
            // 
            // groupBoxKarakteristike
            // 
            this.groupBoxKarakteristike.Controls.Add(idLabel);
            this.groupBoxKarakteristike.Controls.Add(this.idTextBox);
            this.groupBoxKarakteristike.Controls.Add(cIJENA_NOCENJALabel);
            this.groupBoxKarakteristike.Controls.Add(this.cIJENA_NOCENJATextBox);
            this.groupBoxKarakteristike.Controls.Add(kATLabel);
            this.groupBoxKarakteristike.Controls.Add(this.kATTextBox);
            this.groupBoxKarakteristike.Controls.Add(aPARTMANLabel);
            this.groupBoxKarakteristike.Controls.Add(this.aPARTMANCheckBox);
            this.groupBoxKarakteristike.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxKarakteristike.Location = new System.Drawing.Point(0, 0);
            this.groupBoxKarakteristike.Name = "groupBoxKarakteristike";
            this.groupBoxKarakteristike.Size = new System.Drawing.Size(298, 314);
            this.groupBoxKarakteristike.TabIndex = 8;
            this.groupBoxKarakteristike.TabStop = false;
            this.groupBoxKarakteristike.Text = "Karakteristike sobe";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonZatvori);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(399, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 46);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonPrethodna);
            this.flowLayoutPanel1.Controls.Add(this.buttonSljedeca);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 46);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // hR_DatabaseDataSet
            // 
            this.hR_DatabaseDataSet.DataSetName = "HR_DatabaseDataSet";
            this.hR_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_SOBEBindingSource
            // 
            this.hR_SOBEBindingSource.DataMember = "HR_SOBE";
            this.hR_SOBEBindingSource.DataSource = this.hR_DatabaseDataSet;
            // 
            // hR_SOBETableAdapter
            // 
            this.hR_SOBETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HR_GOSTITableAdapter = null;
            this.tableAdapterManager.HR_KARAKT_SOBATableAdapter = this.hR_KARAKT_SOBATableAdapter;
            this.tableAdapterManager.HR_NOCENJATableAdapter = null;
            this.tableAdapterManager.HR_RACUNITableAdapter = null;
            this.tableAdapterManager.HR_SOBETableAdapter = this.hR_SOBETableAdapter;
            this.tableAdapterManager.HR_USLUGETableAdapter = null;
            this.tableAdapterManager.HR_VRSTE_KARAKTTableAdapter = null;
            this.tableAdapterManager.HR_VRSTE_USLUGATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelskaRecepcija.HR_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hR_SOBEBindingNavigator
            // 
            this.hR_SOBEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hR_SOBEBindingNavigator.BindingSource = this.hR_SOBEBindingSource;
            this.hR_SOBEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hR_SOBEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hR_SOBEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hR_SOBEBindingNavigatorSaveItem});
            this.hR_SOBEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hR_SOBEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hR_SOBEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hR_SOBEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hR_SOBEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hR_SOBEBindingNavigator.Name = "hR_SOBEBindingNavigator";
            this.hR_SOBEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hR_SOBEBindingNavigator.Size = new System.Drawing.Size(599, 25);
            this.hR_SOBEBindingNavigator.TabIndex = 16;
            this.hR_SOBEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hR_SOBEBindingNavigatorSaveItem
            // 
            this.hR_SOBEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hR_SOBEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hR_SOBEBindingNavigatorSaveItem.Image")));
            this.hR_SOBEBindingNavigatorSaveItem.Name = "hR_SOBEBindingNavigatorSaveItem";
            this.hR_SOBEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hR_SOBEBindingNavigatorSaveItem.Text = "Save Data";
            this.hR_SOBEBindingNavigatorSaveItem.Click += new System.EventHandler(this.hR_SOBEBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hR_SOBEBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(118, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // cIJENA_NOCENJALabel
            // 
            cIJENA_NOCENJALabel.AutoSize = true;
            cIJENA_NOCENJALabel.Location = new System.Drawing.Point(12, 57);
            cIJENA_NOCENJALabel.Name = "cIJENA_NOCENJALabel";
            cIJENA_NOCENJALabel.Size = new System.Drawing.Size(100, 13);
            cIJENA_NOCENJALabel.TabIndex = 2;
            cIJENA_NOCENJALabel.Text = "CIJENA NOCENJA:";
            // 
            // cIJENA_NOCENJATextBox
            // 
            this.cIJENA_NOCENJATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hR_SOBEBindingSource, "CIJENA_NOCENJA", true));
            this.cIJENA_NOCENJATextBox.Location = new System.Drawing.Point(118, 54);
            this.cIJENA_NOCENJATextBox.Name = "cIJENA_NOCENJATextBox";
            this.cIJENA_NOCENJATextBox.Size = new System.Drawing.Size(104, 20);
            this.cIJENA_NOCENJATextBox.TabIndex = 3;
            // 
            // kATLabel
            // 
            kATLabel.AutoSize = true;
            kATLabel.Location = new System.Drawing.Point(12, 83);
            kATLabel.Name = "kATLabel";
            kATLabel.Size = new System.Drawing.Size(31, 13);
            kATLabel.TabIndex = 4;
            kATLabel.Text = "KAT:";
            // 
            // kATTextBox
            // 
            this.kATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hR_SOBEBindingSource, "KAT", true));
            this.kATTextBox.Location = new System.Drawing.Point(118, 80);
            this.kATTextBox.Name = "kATTextBox";
            this.kATTextBox.Size = new System.Drawing.Size(104, 20);
            this.kATTextBox.TabIndex = 5;
            // 
            // aPARTMANLabel
            // 
            aPARTMANLabel.AutoSize = true;
            aPARTMANLabel.Location = new System.Drawing.Point(12, 111);
            aPARTMANLabel.Name = "aPARTMANLabel";
            aPARTMANLabel.Size = new System.Drawing.Size(70, 13);
            aPARTMANLabel.TabIndex = 6;
            aPARTMANLabel.Text = "APARTMAN:";
            // 
            // aPARTMANCheckBox
            // 
            this.aPARTMANCheckBox.AutoSize = true;
            this.aPARTMANCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hR_SOBEBindingSource, "APARTMAN", true));
            this.aPARTMANCheckBox.Location = new System.Drawing.Point(118, 106);
            this.aPARTMANCheckBox.Name = "aPARTMANCheckBox";
            this.aPARTMANCheckBox.Size = new System.Drawing.Size(109, 17);
            this.aPARTMANCheckBox.TabIndex = 7;
            this.aPARTMANCheckBox.Text = "Soba je apartman";
            this.aPARTMANCheckBox.UseVisualStyleBackColor = true;
            // 
            // hRKARAKTSOBABindingSource
            // 
            this.hRKARAKTSOBABindingSource.DataMember = "HR_KARAKT_SOBA";
            this.hRKARAKTSOBABindingSource.DataSource = this.hR_DatabaseDataSet;
            // 
            // hR_KARAKT_SOBATableAdapter
            // 
            this.hR_KARAKT_SOBATableAdapter.ClearBeforeFill = true;
            // 
            // PregledajSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonZatvori;
            this.ClientSize = new System.Drawing.Size(599, 400);
            this.Controls.Add(this.hR_SOBEBindingNavigator);
            this.Controls.Add(this.splitContainerBody);
            this.Name = "PregledajSobe";
            this.Text = "Pregledaj sobe";
            this.Load += new System.EventHandler(this.PregledajSobe_Load);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            this.splitContainerUpper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUpper)).EndInit();
            this.splitContainerUpper.ResumeLayout(false);
            this.groupBoxKarakteristike.ResumeLayout(false);
            this.groupBoxKarakteristike.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_SOBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_SOBEBindingNavigator)).EndInit();
            this.hR_SOBEBindingNavigator.ResumeLayout(false);
            this.hR_SOBEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRKARAKTSOBABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPrethodna;
        private System.Windows.Forms.Button buttonSljedeca;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainerUpper;
        private System.Windows.Forms.GroupBox groupBoxKarakteristike;
        private HR_DatabaseDataSet hR_DatabaseDataSet;
        private System.Windows.Forms.BindingSource hR_SOBEBindingSource;
        private HR_DatabaseDataSetTableAdapters.HR_SOBETableAdapter hR_SOBETableAdapter;
        private HR_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hR_SOBEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hR_SOBEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox cIJENA_NOCENJATextBox;
        private System.Windows.Forms.TextBox kATTextBox;
        private System.Windows.Forms.CheckBox aPARTMANCheckBox;
        private HR_DatabaseDataSetTableAdapters.HR_KARAKT_SOBATableAdapter hR_KARAKT_SOBATableAdapter;
        private System.Windows.Forms.BindingSource hRKARAKTSOBABindingSource;
    }
}