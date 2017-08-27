namespace InventoryManagement
{
    partial class SalesAndProfit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesAndProfit));
            this.label3 = new System.Windows.Forms.Label();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.investedL = new System.Windows.Forms.Label();
            this.soldL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.profitL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productsGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.searchTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export = new Bunifu.Framework.UI.BunifuFlatButton();
            this.totalSpentL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.show = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.storeCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(561, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Supplier";
            // 
            // supplierCB
            // 
            this.supplierCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.supplierCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.supplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierCB.ForeColor = System.Drawing.Color.Silver;
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(564, 48);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(267, 26);
            this.supplierCB.TabIndex = 15;
            this.supplierCB.SelectedIndexChanged += new System.EventHandler(this.supplierCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(288, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category";
            // 
            // categoryCB
            // 
            this.categoryCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categoryCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryCB.ForeColor = System.Drawing.Color.Silver;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(291, 48);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(267, 26);
            this.categoryCB.TabIndex = 13;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(303, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Invested";
            // 
            // investedL
            // 
            this.investedL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.investedL.AutoSize = true;
            this.investedL.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.investedL.ForeColor = System.Drawing.Color.Red;
            this.investedL.Location = new System.Drawing.Point(305, 183);
            this.investedL.Name = "investedL";
            this.investedL.Size = new System.Drawing.Size(15, 18);
            this.investedL.TabIndex = 31;
            this.investedL.Text = "-";
            // 
            // soldL
            // 
            this.soldL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.soldL.AutoSize = true;
            this.soldL.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.soldL.ForeColor = System.Drawing.Color.Green;
            this.soldL.Location = new System.Drawing.Point(439, 183);
            this.soldL.Name = "soldL";
            this.soldL.Size = new System.Drawing.Size(15, 18);
            this.soldL.TabIndex = 33;
            this.soldL.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(439, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sold";
            // 
            // profitL
            // 
            this.profitL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profitL.AutoSize = true;
            this.profitL.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.profitL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.profitL.Location = new System.Drawing.Point(575, 183);
            this.profitL.Name = "profitL";
            this.profitL.Size = new System.Drawing.Size(15, 18);
            this.profitL.TabIndex = 35;
            this.profitL.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label10.Location = new System.Drawing.Point(575, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Profit";
            // 
            // productsGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.productsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productsGV.ColumnHeadersHeight = 30;
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsGV.DoubleBuffered = true;
            this.productsGV.EnableHeadersVisualStyles = false;
            this.productsGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.productsGV.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(174)))), ((int)(((byte)(183)))));
            this.productsGV.Location = new System.Drawing.Point(0, 209);
            this.productsGV.Name = "productsGV";
            this.productsGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productsGV.Size = new System.Drawing.Size(1115, 377);
            this.productsGV.TabIndex = 37;
            this.productsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGV_CellClick);
            this.productsGV.Sorted += new System.EventHandler(this.productsGV_Sorted);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTB.ForeColor = System.Drawing.Color.White;
            this.searchTB.isPassword = false;
            this.searchTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineIdleColor = System.Drawing.Color.Silver;
            this.searchTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineThickness = 3;
            this.searchTB.Location = new System.Drawing.Point(18, 33);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(266, 41);
            this.searchTB.TabIndex = 38;
            this.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTB.OnValueChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.searchTB);
            this.panel1.Controls.Add(this.storeCB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.categoryCB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.supplierCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 101);
            this.panel1.TabIndex = 39;
            // 
            // export
            // 
            this.export.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.export.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.export.BorderRadius = 0;
            this.export.ButtonText = "Export";
            this.export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export.DisabledColor = System.Drawing.Color.Gray;
            this.export.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export.ForeColor = System.Drawing.Color.Silver;
            this.export.Iconcolor = System.Drawing.Color.Transparent;
            this.export.Iconimage = ((System.Drawing.Image)(resources.GetObject("export.Iconimage")));
            this.export.Iconimage_right = null;
            this.export.Iconimage_right_Selected = null;
            this.export.Iconimage_Selected = null;
            this.export.IconRightVisible = true;
            this.export.IconRightZoom = 0D;
            this.export.IconVisible = true;
            this.export.IconZoom = 50D;
            this.export.IsTab = false;
            this.export.Location = new System.Drawing.Point(842, 107);
            this.export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.export.Name = "export";
            this.export.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.export.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.export.OnHoverTextColor = System.Drawing.Color.White;
            this.export.selected = false;
            this.export.Size = new System.Drawing.Size(179, 45);
            this.export.TabIndex = 46;
            this.export.Text = "Export";
            this.export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.export.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.export.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // totalSpentL
            // 
            this.totalSpentL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalSpentL.AutoSize = true;
            this.totalSpentL.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalSpentL.ForeColor = System.Drawing.Color.Red;
            this.totalSpentL.Location = new System.Drawing.Point(712, 183);
            this.totalSpentL.Name = "totalSpentL";
            this.totalSpentL.Size = new System.Drawing.Size(15, 18);
            this.totalSpentL.TabIndex = 48;
            this.totalSpentL.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(710, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Total Spent";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(93, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 78;
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
            "28",
            "29",
            "30",
            "31"});
            this.dayCB.Location = new System.Drawing.Point(93, 126);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(180, 26);
            this.dayCB.TabIndex = 77;
            this.dayCB.SelectedIndexChanged += new System.EventHandler(this.dayCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(278, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 81;
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
            this.monthCB.Location = new System.Drawing.Point(278, 126);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(180, 26);
            this.monthCB.TabIndex = 80;
            this.monthCB.SelectedIndexChanged += new System.EventHandler(this.monthCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label9.Location = new System.Drawing.Point(464, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 83;
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
            "All"});
            this.yearCB.Location = new System.Drawing.Point(464, 126);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(180, 26);
            this.yearCB.TabIndex = 82;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.yearCB_SelectedIndexChanged);
            // 
            // show
            // 
            this.show.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.BorderRadius = 0;
            this.show.ButtonText = "Profit per month";
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.DisabledColor = System.Drawing.Color.Gray;
            this.show.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show.ForeColor = System.Drawing.Color.Silver;
            this.show.Iconcolor = System.Drawing.Color.Transparent;
            this.show.Iconimage = null;
            this.show.Iconimage_right = null;
            this.show.Iconimage_right_Selected = null;
            this.show.Iconimage_Selected = null;
            this.show.IconRightVisible = true;
            this.show.IconRightZoom = 0D;
            this.show.IconVisible = true;
            this.show.IconZoom = 60D;
            this.show.IsTab = false;
            this.show.Location = new System.Drawing.Point(842, 160);
            this.show.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.show.Name = "show";
            this.show.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.show.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.show.OnHoverTextColor = System.Drawing.Color.White;
            this.show.selected = false;
            this.show.Size = new System.Drawing.Size(179, 41);
            this.show.TabIndex = 84;
            this.show.Text = "Profit per month";
            this.show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(834, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Store";
            // 
            // storeCB
            // 
            this.storeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.storeCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.storeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeCB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeCB.ForeColor = System.Drawing.Color.Silver;
            this.storeCB.FormattingEnabled = true;
            this.storeCB.Location = new System.Drawing.Point(837, 48);
            this.storeCB.Name = "storeCB";
            this.storeCB.Size = new System.Drawing.Size(267, 26);
            this.storeCB.TabIndex = 39;
            this.storeCB.SelectedIndexChanged += new System.EventHandler(this.storeCB_SelectedIndexChanged);
            // 
            // SalesAndProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 586);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.totalSpentL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.export);
            this.Controls.Add(this.profitL);
            this.Controls.Add(this.investedL);
            this.Controls.Add(this.soldL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productsGV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesAndProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Profit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesAndProfit_FormClosing);
            this.Load += new System.EventHandler(this.SalesAndProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label investedL;
        private System.Windows.Forms.Label soldL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label profitL;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productsGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchTB;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton export;
        private System.Windows.Forms.Label totalSpentL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox yearCB;
        private Bunifu.Framework.UI.BunifuFlatButton show;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox storeCB;
    }
}