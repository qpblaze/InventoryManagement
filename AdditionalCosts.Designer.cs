namespace InventoryManagement
{
    partial class AdditionalCosts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalCosts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.costTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.costL = new System.Windows.Forms.Label();
            this.infoTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.infoL = new System.Windows.Forms.Label();
            this.costsDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.totalL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.costTB);
            this.panel1.Controls.Add(this.costL);
            this.panel1.Controls.Add(this.infoTB);
            this.panel1.Controls.Add(this.infoL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 96);
            this.panel1.TabIndex = 68;
            // 
            // costTB
            // 
            this.costTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.costTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.costTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.costTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costTB.ForeColor = System.Drawing.Color.White;
            this.costTB.isPassword = false;
            this.costTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.costTB.LineIdleColor = System.Drawing.Color.Silver;
            this.costTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.costTB.LineThickness = 3;
            this.costTB.Location = new System.Drawing.Point(684, 38);
            this.costTB.Margin = new System.Windows.Forms.Padding(4);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(325, 41);
            this.costTB.TabIndex = 44;
            this.costTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // costL
            // 
            this.costL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.costL.AutoSize = true;
            this.costL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.costL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costL.ForeColor = System.Drawing.Color.Silver;
            this.costL.Location = new System.Drawing.Point(681, 18);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(41, 16);
            this.costL.TabIndex = 43;
            this.costL.Text = "Cost";
            // 
            // infoTB
            // 
            this.infoTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.infoTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infoTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoTB.ForeColor = System.Drawing.Color.White;
            this.infoTB.isPassword = false;
            this.infoTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.infoTB.LineIdleColor = System.Drawing.Color.Silver;
            this.infoTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.infoTB.LineThickness = 3;
            this.infoTB.Location = new System.Drawing.Point(103, 38);
            this.infoTB.Margin = new System.Windows.Forms.Padding(4);
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(573, 41);
            this.infoTB.TabIndex = 42;
            this.infoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // infoL
            // 
            this.infoL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoL.AutoSize = true;
            this.infoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.infoL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoL.ForeColor = System.Drawing.Color.Silver;
            this.infoL.Location = new System.Drawing.Point(102, 18);
            this.infoL.Name = "infoL";
            this.infoL.Size = new System.Drawing.Size(37, 16);
            this.infoL.TabIndex = 41;
            this.infoL.Text = "Info";
            // 
            // costsDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.costsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.costsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.costsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.costsDGV.ColumnHeadersHeight = 30;
            this.costsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.costsDGV.DoubleBuffered = true;
            this.costsDGV.EnableHeadersVisualStyles = false;
            this.costsDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.costsDGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.costsDGV.Location = new System.Drawing.Point(0, 165);
            this.costsDGV.Name = "costsDGV";
            this.costsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.costsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.costsDGV.Size = new System.Drawing.Size(1051, 304);
            this.costsDGV.TabIndex = 69;
            this.costsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDGV_CellClick);
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
            this.delete.Location = new System.Drawing.Point(856, 110);
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
            this.edit.Location = new System.Drawing.Point(761, 110);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(87, 41);
            this.edit.TabIndex = 71;
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
            this.add.Location = new System.Drawing.Point(661, 110);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(92, 41);
            this.add.TabIndex = 70;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // totalL
            // 
            this.totalL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalL.ForeColor = System.Drawing.Color.Red;
            this.totalL.Location = new System.Drawing.Point(960, 133);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(15, 18);
            this.totalL.TabIndex = 74;
            this.totalL.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(960, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 73;
            this.label5.Text = "Total";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label9.Location = new System.Drawing.Point(474, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Year";
            // 
            // yearCB
            // 
            this.yearCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yearCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearCB.ForeColor = System.Drawing.Color.Silver;
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Items.AddRange(new object[] {
            "All",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.yearCB.Location = new System.Drawing.Point(474, 125);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(180, 26);
            this.yearCB.TabIndex = 88;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.yearCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(288, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Month";
            // 
            // monthCB
            // 
            this.monthCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.monthCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCB.ForeColor = System.Drawing.Color.Silver;
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Items.AddRange(new object[] {
            "All",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCB.Location = new System.Drawing.Point(288, 125);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(180, 26);
            this.monthCB.TabIndex = 86;
            this.monthCB.SelectedIndexChanged += new System.EventHandler(this.monthCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(103, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Day";
            // 
            // dayCB
            // 
            this.dayCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dayCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.dayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayCB.ForeColor = System.Drawing.Color.Silver;
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "29",
            "30",
            "31"});
            this.dayCB.Location = new System.Drawing.Point(103, 125);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(180, 26);
            this.dayCB.TabIndex = 84;
            this.dayCB.SelectedIndexChanged += new System.EventHandler(this.dayCB_SelectedIndexChanged);
            // 
            // AdditionalCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 468);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.totalL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.costsDGV);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalCosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional Costs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdditionalCosts_FormClosing);
            this.Load += new System.EventHandler(this.AdditionalCosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox infoTB;
        private System.Windows.Forms.Label infoL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox costTB;
        private System.Windows.Forms.Label costL;
        private Bunifu.Framework.UI.BunifuCustomDataGrid costsDGV;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dayCB;
    }
}