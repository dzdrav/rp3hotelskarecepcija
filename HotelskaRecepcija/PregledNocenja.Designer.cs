namespace HotelskaRecepcija
{
    partial class PregledNocenja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledNocenja));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.hR_NOCENJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.hR_NOCENJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_DatabaseDataSet1 = new HotelskaRecepcija.HR_DatabaseDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hR_NOCENJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hR_NOCENJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPregledNocenjaZatvori = new System.Windows.Forms.Button();
            this.hR_NOCENJATableAdapter = new HotelskaRecepcija.HR_DatabaseDataSet1TableAdapters.HR_NOCENJATableAdapter();
            this.tableAdapterManager = new HotelskaRecepcija.HR_DatabaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJABindingNavigator)).BeginInit();
            this.hR_NOCENJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJADataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(577, 333);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.hR_NOCENJABindingNavigator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.hR_NOCENJADataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(577, 293);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // hR_NOCENJABindingNavigator
            // 
            this.hR_NOCENJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hR_NOCENJABindingNavigator.BindingSource = this.hR_NOCENJABindingSource;
            this.hR_NOCENJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hR_NOCENJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hR_NOCENJABindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hR_NOCENJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hR_NOCENJABindingNavigatorSaveItem});
            this.hR_NOCENJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hR_NOCENJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hR_NOCENJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hR_NOCENJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hR_NOCENJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hR_NOCENJABindingNavigator.Name = "hR_NOCENJABindingNavigator";
            this.hR_NOCENJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hR_NOCENJABindingNavigator.Size = new System.Drawing.Size(577, 25);
            this.hR_NOCENJABindingNavigator.TabIndex = 1;
            this.hR_NOCENJABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // hR_NOCENJABindingSource
            // 
            this.hR_NOCENJABindingSource.DataMember = "HR_NOCENJA";
            this.hR_NOCENJABindingSource.DataSource = this.hR_DatabaseDataSet1;
            // 
            // hR_DatabaseDataSet1
            // 
            this.hR_DatabaseDataSet1.DataSetName = "HR_DatabaseDataSet1";
            this.hR_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hR_NOCENJABindingNavigatorSaveItem
            // 
            this.hR_NOCENJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hR_NOCENJABindingNavigatorSaveItem.Enabled = false;
            this.hR_NOCENJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hR_NOCENJABindingNavigatorSaveItem.Image")));
            this.hR_NOCENJABindingNavigatorSaveItem.Name = "hR_NOCENJABindingNavigatorSaveItem";
            this.hR_NOCENJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hR_NOCENJABindingNavigatorSaveItem.Text = "Save Data";
            this.hR_NOCENJABindingNavigatorSaveItem.Click += new System.EventHandler(this.hR_NOCENJABindingNavigatorSaveItem_Click);
            // 
            // hR_NOCENJADataGridView
            // 
            this.hR_NOCENJADataGridView.AllowUserToAddRows = false;
            this.hR_NOCENJADataGridView.AutoGenerateColumns = false;
            this.hR_NOCENJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hR_NOCENJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hR_NOCENJADataGridView.DataSource = this.hR_NOCENJABindingSource;
            this.hR_NOCENJADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hR_NOCENJADataGridView.Location = new System.Drawing.Point(0, 0);
            this.hR_NOCENJADataGridView.Name = "hR_NOCENJADataGridView";
            this.hR_NOCENJADataGridView.ReadOnly = true;
            this.hR_NOCENJADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hR_NOCENJADataGridView.Size = new System.Drawing.Size(577, 264);
            this.hR_NOCENJADataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GOST_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "GOST_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOBA_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOBA_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATUM";
            this.dataGridViewTextBoxColumn4.HeaderText = "DATUM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CIJENA";
            this.dataGridViewTextBoxColumn5.HeaderText = "CIJENA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonPregledNocenjaZatvori);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonPregledNocenjaZatvori
            // 
            this.buttonPregledNocenjaZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPregledNocenjaZatvori.Location = new System.Drawing.Point(499, 3);
            this.buttonPregledNocenjaZatvori.Name = "buttonPregledNocenjaZatvori";
            this.buttonPregledNocenjaZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonPregledNocenjaZatvori.TabIndex = 1;
            this.buttonPregledNocenjaZatvori.Text = "Zatvori";
            this.buttonPregledNocenjaZatvori.UseVisualStyleBackColor = true;
            this.buttonPregledNocenjaZatvori.Click += new System.EventHandler(this.buttonPregledNocenjaZatvori_Click);
            // 
            // hR_NOCENJATableAdapter
            // 
            this.hR_NOCENJATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HR_GOSTITableAdapter = null;
            this.tableAdapterManager.HR_NOCENJATableAdapter = this.hR_NOCENJATableAdapter;
            this.tableAdapterManager.HR_OSOBLJETableAdapter = null;
            this.tableAdapterManager.HR_RACUNITableAdapter = null;
            this.tableAdapterManager.HR_SOBETableAdapter = null;
            this.tableAdapterManager.HR_USLUGETableAdapter = null;
            this.tableAdapterManager.HR_VRSTE_KARAKTTableAdapter = null;
            this.tableAdapterManager.HR_VRSTE_USLUGATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelskaRecepcija.HR_DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PregledNocenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonPregledNocenjaZatvori;
            this.ClientSize = new System.Drawing.Size(577, 333);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PregledNocenja";
            this.Text = "Pregled noćenja";
            this.Load += new System.EventHandler(this.PregledNocenja_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJABindingNavigator)).EndInit();
            this.hR_NOCENJABindingNavigator.ResumeLayout(false);
            this.hR_NOCENJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_NOCENJADataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPregledNocenjaZatvori;
        private HR_DatabaseDataSet1 hR_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource hR_NOCENJABindingSource;
        private HR_DatabaseDataSet1TableAdapters.HR_NOCENJATableAdapter hR_NOCENJATableAdapter;
        private HR_DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hR_NOCENJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hR_NOCENJABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hR_NOCENJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}