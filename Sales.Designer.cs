namespace InventoryManagement
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAndProfitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalCostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.productsGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.storeCB = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.additionalCostsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.storesToolStripMenuItem,
            this.salesAndProfitToolStripMenuItem1});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addProductToolStripMenuItem.Text = "Manage";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // salesAndProfitToolStripMenuItem1
            // 
            this.salesAndProfitToolStripMenuItem1.Name = "salesAndProfitToolStripMenuItem1";
            this.salesAndProfitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salesAndProfitToolStripMenuItem1.Text = "Sales and Profit";
            this.salesAndProfitToolStripMenuItem1.Click += new System.EventHandler(this.salesAndProfitToolStripMenuItem1_Click);
            // 
            // additionalCostsToolStripMenuItem
            // 
            this.additionalCostsToolStripMenuItem.Name = "additionalCostsToolStripMenuItem";
            this.additionalCostsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.additionalCostsToolStripMenuItem.Text = "Additional Costs";
            this.additionalCostsToolStripMenuItem.Click += new System.EventHandler(this.additionalCostsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.storeCB);
            this.panel1.Controls.Add(this.searchTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.categoryCB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.supplierCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 95);
            this.panel1.TabIndex = 40;
            // 
            // searchTB
            // 
            this.searchTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTB.ForeColor = System.Drawing.Color.Silver;
            this.searchTB.isPassword = false;
            this.searchTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineIdleColor = System.Drawing.Color.Silver;
            this.searchTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineThickness = 3;
            this.searchTB.Location = new System.Drawing.Point(13, 32);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(247, 36);
            this.searchTB.TabIndex = 38;
            this.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTB.OnValueChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(264, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category";
            // 
            // categoryCB
            // 
            this.categoryCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryCB.ForeColor = System.Drawing.Color.Silver;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(267, 42);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(267, 26);
            this.categoryCB.TabIndex = 13;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(537, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Supplier";
            // 
            // supplierCB
            // 
            this.supplierCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supplierCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierCB.ForeColor = System.Drawing.Color.Silver;
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(540, 42);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(267, 26);
            this.supplierCB.TabIndex = 15;
            this.supplierCB.SelectedIndexChanged += new System.EventHandler(this.supplierCB_SelectedIndexChanged);
            // 
            // productsGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.productsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsGV.ColumnHeadersHeight = 30;
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsGV.DoubleBuffered = true;
            this.productsGV.EnableHeadersVisualStyles = false;
            this.productsGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.productsGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.productsGV.Location = new System.Drawing.Point(0, 125);
            this.productsGV.Name = "productsGV";
            this.productsGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsGV.Size = new System.Drawing.Size(1095, 400);
            this.productsGV.TabIndex = 41;
            this.productsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGV_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(810, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Store";
            // 
            // storeCB
            // 
            this.storeCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.storeCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.storeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeCB.ForeColor = System.Drawing.Color.Silver;
            this.storeCB.FormattingEnabled = true;
            this.storeCB.Location = new System.Drawing.Point(813, 42);
            this.storeCB.Name = "storeCB";
            this.storeCB.Size = new System.Drawing.Size(267, 26);
            this.storeCB.TabIndex = 39;
            this.storeCB.SelectedIndexChanged += new System.EventHandler(this.storeCB_SelectedIndexChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 525);
            this.Controls.Add(this.productsGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sales_FormClosing);
            this.Load += new System.EventHandler(this.Sales_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAndProfitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox supplierCB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productsGV;
        private System.Windows.Forms.ToolStripMenuItem additionalCostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox storeCB;
    }
}

