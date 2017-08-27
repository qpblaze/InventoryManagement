namespace InventoryManagement
{
    partial class ManageStores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameL = new System.Windows.Forms.Label();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.storesDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.categoryName);
            this.panel1.Controls.Add(this.nameL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 96);
            this.panel1.TabIndex = 68;
            // 
            // categoryName
            // 
            this.categoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.categoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryName.ForeColor = System.Drawing.Color.White;
            this.categoryName.isPassword = false;
            this.categoryName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.categoryName.LineIdleColor = System.Drawing.Color.Silver;
            this.categoryName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.categoryName.LineThickness = 3;
            this.categoryName.Location = new System.Drawing.Point(13, 38);
            this.categoryName.Margin = new System.Windows.Forms.Padding(4);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(482, 41);
            this.categoryName.TabIndex = 42;
            this.categoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameL
            // 
            this.nameL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameL.AutoSize = true;
            this.nameL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.nameL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameL.ForeColor = System.Drawing.Color.Silver;
            this.nameL.Location = new System.Drawing.Point(10, 18);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(93, 16);
            this.nameL.TabIndex = 41;
            this.nameL.Text = "Store Name";
            // 
            // delete
            // 
            this.delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.BorderRadius = 0;
            this.delete.ButtonText = "Delete";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledColor = System.Drawing.Color.Gray;
            this.delete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.ForeColor = System.Drawing.Color.Silver;
            this.delete.Iconcolor = System.Drawing.Color.Transparent;
            this.delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("delete.Iconimage")));
            this.delete.Iconimage_right = null;
            this.delete.Iconimage_right_Selected = null;
            this.delete.Iconimage_Selected = null;
            this.delete.IconRightVisible = true;
            this.delete.IconRightZoom = 0D;
            this.delete.IconVisible = true;
            this.delete.IconZoom = 60D;
            this.delete.IsTab = false;
            this.delete.Location = new System.Drawing.Point(307, 102);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(97, 41);
            this.delete.TabIndex = 72;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.BorderRadius = 0;
            this.edit.ButtonText = "Edit";
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.DisabledColor = System.Drawing.Color.Gray;
            this.edit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.ForeColor = System.Drawing.Color.Silver;
            this.edit.Iconcolor = System.Drawing.Color.Transparent;
            this.edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("edit.Iconimage")));
            this.edit.Iconimage_right = null;
            this.edit.Iconimage_right_Selected = null;
            this.edit.Iconimage_Selected = null;
            this.edit.IconRightVisible = true;
            this.edit.IconRightZoom = 0D;
            this.edit.IconVisible = true;
            this.edit.IconZoom = 60D;
            this.edit.IsTab = false;
            this.edit.Location = new System.Drawing.Point(212, 102);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(87, 41);
            this.edit.TabIndex = 70;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // storesDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.storesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.storesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.storesDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.storesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.storesDGV.ColumnHeadersHeight = 30;
            this.storesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.storesDGV.DoubleBuffered = true;
            this.storesDGV.EnableHeadersVisualStyles = false;
            this.storesDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.storesDGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.storesDGV.Location = new System.Drawing.Point(4, 149);
            this.storesDGV.Name = "storesDGV";
            this.storesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.storesDGV.Size = new System.Drawing.Size(508, 217);
            this.storesDGV.TabIndex = 71;
            this.storesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storesDGV_CellClick);
            // 
            // add
            // 
            this.add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.BorderRadius = 0;
            this.add.ButtonText = "Add";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.DisabledColor = System.Drawing.Color.Gray;
            this.add.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.ForeColor = System.Drawing.Color.Silver;
            this.add.Iconcolor = System.Drawing.Color.Transparent;
            this.add.Iconimage = ((System.Drawing.Image)(resources.GetObject("add.Iconimage")));
            this.add.Iconimage_right = null;
            this.add.Iconimage_right_Selected = null;
            this.add.Iconimage_Selected = null;
            this.add.IconRightVisible = true;
            this.add.IconRightZoom = 0D;
            this.add.IconVisible = true;
            this.add.IconZoom = 60D;
            this.add.IsTab = false;
            this.add.Location = new System.Drawing.Point(112, 102);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(92, 41);
            this.add.TabIndex = 69;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ManageStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.storesDGV);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Stores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageStores_FormClosing);
            this.Load += new System.EventHandler(this.ManageStores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox categoryName;
        private System.Windows.Forms.Label nameL;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid storesDGV;
        private Bunifu.Framework.UI.BunifuFlatButton add;
    }
}