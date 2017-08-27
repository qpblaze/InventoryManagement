namespace InventoryManagement
{
    partial class ManageSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSuppliers));
            this.suppliersDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameL = new System.Windows.Forms.Label();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suppliersDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.suppliersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.suppliersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.suppliersDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.suppliersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppliersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.suppliersDGV.ColumnHeadersHeight = 30;
            this.suppliersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDGV.DoubleBuffered = true;
            this.suppliersDGV.EnableHeadersVisualStyles = false;
            this.suppliersDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.suppliersDGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.suppliersDGV.Location = new System.Drawing.Point(0, 149);
            this.suppliersDGV.Name = "suppliersDGV";
            this.suppliersDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDGV.Size = new System.Drawing.Size(508, 217);
            this.suppliersDGV.TabIndex = 64;
            this.suppliersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDGV_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.nameL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 96);
            this.panel1.TabIndex = 65;
            // 
            // nameTB
            // 
            this.nameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTB.ForeColor = System.Drawing.Color.White;
            this.nameTB.isPassword = false;
            this.nameTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.nameTB.LineIdleColor = System.Drawing.Color.Silver;
            this.nameTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.nameTB.LineThickness = 3;
            this.nameTB.Location = new System.Drawing.Point(13, 38);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(482, 41);
            this.nameTB.TabIndex = 42;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.nameL.Size = new System.Drawing.Size(113, 16);
            this.nameL.TabIndex = 41;
            this.nameL.Text = "Supplier Name";
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
            this.edit.Location = new System.Drawing.Point(208, 102);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(87, 41);
            this.edit.TabIndex = 63;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
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
            this.add.Location = new System.Drawing.Point(108, 102);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(92, 41);
            this.add.TabIndex = 62;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.delete.Location = new System.Drawing.Point(303, 102);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(97, 41);
            this.delete.TabIndex = 66;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.suppliersDGV);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageSuppliers_FormClosing);
            this.Load += new System.EventHandler(this.ManageSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid suppliersDGV;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTB;
        private System.Windows.Forms.Label nameL;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
    }
}