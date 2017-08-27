namespace InventoryManagement
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameL = new System.Windows.Forms.Label();
            this.description = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.descriptionL = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.categoryL = new System.Windows.Forms.Label();
            this.supplierL = new System.Windows.Forms.Label();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.minStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.minL = new System.Windows.Forms.Label();
            this.stock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stockL = new System.Windows.Forms.Label();
            this.buyingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buyingL = new System.Windows.Forms.Label();
            this.sellingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellingL = new System.Windows.Forms.Label();
            this.stockIn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.addStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productsGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryCBS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supplierCBS = new System.Windows.Forms.ComboBox();
            this.storeL = new System.Windows.Forms.Label();
            this.storeCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeCBS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.name.LineIdleColor = System.Drawing.Color.Silver;
            this.name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(128, 28);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(334, 41);
            this.name.TabIndex = 1;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameL
            // 
            this.nameL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameL.AutoSize = true;
            this.nameL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.nameL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameL.ForeColor = System.Drawing.Color.Silver;
            this.nameL.Location = new System.Drawing.Point(125, 8);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(50, 16);
            this.nameL.TabIndex = 39;
            this.nameL.Text = "Name";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.isPassword = false;
            this.description.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.description.LineIdleColor = System.Drawing.Color.Silver;
            this.description.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.description.LineThickness = 3;
            this.description.Location = new System.Drawing.Point(473, 28);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(360, 41);
            this.description.TabIndex = 2;
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descriptionL
            // 
            this.descriptionL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.descriptionL.AutoSize = true;
            this.descriptionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.descriptionL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionL.ForeColor = System.Drawing.Color.Silver;
            this.descriptionL.Location = new System.Drawing.Point(470, 8);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(90, 16);
            this.descriptionL.TabIndex = 41;
            this.descriptionL.Text = "Description";
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
            this.categoryCB.Location = new System.Drawing.Point(128, 166);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(332, 26);
            this.categoryCB.TabIndex = 7;
            // 
            // categoryL
            // 
            this.categoryL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categoryL.AutoSize = true;
            this.categoryL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.categoryL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryL.ForeColor = System.Drawing.Color.Silver;
            this.categoryL.Location = new System.Drawing.Point(125, 137);
            this.categoryL.Name = "categoryL";
            this.categoryL.Size = new System.Drawing.Size(75, 16);
            this.categoryL.TabIndex = 44;
            this.categoryL.Text = "Category";
            // 
            // supplierL
            // 
            this.supplierL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.supplierL.AutoSize = true;
            this.supplierL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.supplierL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierL.ForeColor = System.Drawing.Color.Silver;
            this.supplierL.Location = new System.Drawing.Point(470, 137);
            this.supplierL.Name = "supplierL";
            this.supplierL.Size = new System.Drawing.Size(67, 16);
            this.supplierL.TabIndex = 46;
            this.supplierL.Text = "Supplier";
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
            this.supplierCB.Location = new System.Drawing.Point(473, 166);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(360, 26);
            this.supplierCB.TabIndex = 8;
            // 
            // minStock
            // 
            this.minStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.minStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minStock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minStock.ForeColor = System.Drawing.Color.White;
            this.minStock.isPassword = false;
            this.minStock.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.minStock.LineIdleColor = System.Drawing.Color.Silver;
            this.minStock.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.minStock.LineThickness = 3;
            this.minStock.Location = new System.Drawing.Point(130, 92);
            this.minStock.Margin = new System.Windows.Forms.Padding(4);
            this.minStock.Name = "minStock";
            this.minStock.Size = new System.Drawing.Size(335, 41);
            this.minStock.TabIndex = 5;
            this.minStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // minL
            // 
            this.minL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.minL.AutoSize = true;
            this.minL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.minL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minL.ForeColor = System.Drawing.Color.Silver;
            this.minL.Location = new System.Drawing.Point(125, 72);
            this.minL.Name = "minL";
            this.minL.Size = new System.Drawing.Size(94, 16);
            this.minL.TabIndex = 47;
            this.minL.Text = "Minim stock";
            // 
            // stock
            // 
            this.stock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stock.ForeColor = System.Drawing.Color.White;
            this.stock.isPassword = false;
            this.stock.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.stock.LineIdleColor = System.Drawing.Color.Silver;
            this.stock.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.stock.LineThickness = 3;
            this.stock.Location = new System.Drawing.Point(473, 92);
            this.stock.Margin = new System.Windows.Forms.Padding(4);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(360, 41);
            this.stock.TabIndex = 6;
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stockL
            // 
            this.stockL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stockL.AutoSize = true;
            this.stockL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.stockL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stockL.ForeColor = System.Drawing.Color.Silver;
            this.stockL.Location = new System.Drawing.Point(470, 73);
            this.stockL.Name = "stockL";
            this.stockL.Size = new System.Drawing.Size(48, 16);
            this.stockL.TabIndex = 49;
            this.stockL.Text = "Stock";
            // 
            // buyingPrice
            // 
            this.buyingPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.buyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buyingPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buyingPrice.ForeColor = System.Drawing.Color.White;
            this.buyingPrice.isPassword = false;
            this.buyingPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buyingPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.buyingPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buyingPrice.LineThickness = 3;
            this.buyingPrice.Location = new System.Drawing.Point(841, 28);
            this.buyingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.buyingPrice.Name = "buyingPrice";
            this.buyingPrice.Size = new System.Drawing.Size(159, 41);
            this.buyingPrice.TabIndex = 3;
            this.buyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buyingL
            // 
            this.buyingL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buyingL.AutoSize = true;
            this.buyingL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.buyingL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buyingL.ForeColor = System.Drawing.Color.Silver;
            this.buyingL.Location = new System.Drawing.Point(838, 9);
            this.buyingL.Name = "buyingL";
            this.buyingL.Size = new System.Drawing.Size(98, 16);
            this.buyingL.TabIndex = 51;
            this.buyingL.Text = "Buying Price";
            // 
            // sellingPrice
            // 
            this.sellingPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sellingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.sellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellingPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellingPrice.ForeColor = System.Drawing.Color.White;
            this.sellingPrice.isPassword = false;
            this.sellingPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sellingPrice.LineIdleColor = System.Drawing.Color.Silver;
            this.sellingPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sellingPrice.LineThickness = 3;
            this.sellingPrice.Location = new System.Drawing.Point(1008, 28);
            this.sellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.Size = new System.Drawing.Size(147, 41);
            this.sellingPrice.TabIndex = 4;
            this.sellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellingL
            // 
            this.sellingL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sellingL.AutoSize = true;
            this.sellingL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.sellingL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellingL.ForeColor = System.Drawing.Color.Silver;
            this.sellingL.Location = new System.Drawing.Point(1005, 8);
            this.sellingL.Name = "sellingL";
            this.sellingL.Size = new System.Drawing.Size(105, 16);
            this.sellingL.TabIndex = 53;
            this.sellingL.Text = "Selling Perice";
            // 
            // stockIn
            // 
            this.stockIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.stockIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockIn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stockIn.ForeColor = System.Drawing.Color.White;
            this.stockIn.isPassword = false;
            this.stockIn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.stockIn.LineIdleColor = System.Drawing.Color.Silver;
            this.stockIn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.stockIn.LineThickness = 3;
            this.stockIn.Location = new System.Drawing.Point(840, 92);
            this.stockIn.Margin = new System.Windows.Forms.Padding(4);
            this.stockIn.Name = "stockIn";
            this.stockIn.Size = new System.Drawing.Size(191, 41);
            this.stockIn.TabIndex = 12;
            this.stockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(837, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Stock In";
            // 
            // addStock
            // 
            this.addStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addStock.BorderRadius = 0;
            this.addStock.ButtonText = "Stock";
            this.addStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStock.DisabledColor = System.Drawing.Color.Gray;
            this.addStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStock.ForeColor = System.Drawing.Color.Silver;
            this.addStock.Iconcolor = System.Drawing.Color.Transparent;
            this.addStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("addStock.Iconimage")));
            this.addStock.Iconimage_right = null;
            this.addStock.Iconimage_right_Selected = null;
            this.addStock.Iconimage_Selected = null;
            this.addStock.IconRightVisible = true;
            this.addStock.IconRightZoom = 0D;
            this.addStock.IconVisible = true;
            this.addStock.IconZoom = 60D;
            this.addStock.IsTab = false;
            this.addStock.Location = new System.Drawing.Point(1039, 92);
            this.addStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addStock.Name = "addStock";
            this.addStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addStock.OnHoverTextColor = System.Drawing.Color.White;
            this.addStock.selected = false;
            this.addStock.Size = new System.Drawing.Size(116, 41);
            this.addStock.TabIndex = 13;
            this.addStock.Text = "Stock";
            this.addStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addStock.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addStock.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStock.Click += new System.EventHandler(this.addStock_Click);
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
            this.add.Location = new System.Drawing.Point(905, 219);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(92, 41);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.edit.Location = new System.Drawing.Point(1005, 219);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(87, 41);
            this.edit.TabIndex = 10;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edit.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
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
            this.delete.Location = new System.Drawing.Point(1100, 219);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(97, 41);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.productsGV.Location = new System.Drawing.Point(0, 266);
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
            this.productsGV.Size = new System.Drawing.Size(1253, 334);
            this.productsGV.TabIndex = 63;
            this.productsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGV_CellClick);
            this.productsGV.Sorted += new System.EventHandler(this.productsGV_Sorted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.storeL);
            this.panel1.Controls.Add(this.storeCB);
            this.panel1.Controls.Add(this.export);
            this.panel1.Controls.Add(this.buyingL);
            this.panel1.Controls.Add(this.buyingPrice);
            this.panel1.Controls.Add(this.sellingPrice);
            this.panel1.Controls.Add(this.addStock);
            this.panel1.Controls.Add(this.sellingL);
            this.panel1.Controls.Add(this.supplierL);
            this.panel1.Controls.Add(this.stockIn);
            this.panel1.Controls.Add(this.categoryCB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.categoryL);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.supplierCB);
            this.panel1.Controls.Add(this.stockL);
            this.panel1.Controls.Add(this.minStock);
            this.panel1.Controls.Add(this.minL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 210);
            this.panel1.TabIndex = 64;
            // 
            // export
            // 
            this.export.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.export.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
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
            this.export.Location = new System.Drawing.Point(1039, 147);
            this.export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.export.Name = "export";
            this.export.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.export.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.export.OnHoverTextColor = System.Drawing.Color.White;
            this.export.selected = false;
            this.export.Size = new System.Drawing.Size(116, 45);
            this.export.TabIndex = 56;
            this.export.Text = "Export";
            this.export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.export.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.export.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTB.BackColor = System.Drawing.SystemColors.Control;
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.searchTB.isPassword = false;
            this.searchTB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineIdleColor = System.Drawing.Color.Silver;
            this.searchTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchTB.LineThickness = 3;
            this.searchTB.Location = new System.Drawing.Point(67, 235);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(203, 26);
            this.searchTB.TabIndex = 70;
            this.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTB.OnValueChanged += new System.EventHandler(this.searchTB_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(64, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(274, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Category";
            // 
            // categoryCBS
            // 
            this.categoryCBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryCBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.categoryCBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryCBS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryCBS.ForeColor = System.Drawing.Color.Silver;
            this.categoryCBS.FormattingEnabled = true;
            this.categoryCBS.Location = new System.Drawing.Point(277, 234);
            this.categoryCBS.Name = "categoryCBS";
            this.categoryCBS.Size = new System.Drawing.Size(203, 26);
            this.categoryCBS.TabIndex = 65;
            this.categoryCBS.SelectedIndexChanged += new System.EventHandler(this.categoryCBS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(483, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Supplier";
            // 
            // supplierCBS
            // 
            this.supplierCBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supplierCBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.supplierCBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierCBS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierCBS.ForeColor = System.Drawing.Color.Silver;
            this.supplierCBS.FormattingEnabled = true;
            this.supplierCBS.Location = new System.Drawing.Point(486, 234);
            this.supplierCBS.Name = "supplierCBS";
            this.supplierCBS.Size = new System.Drawing.Size(203, 26);
            this.supplierCBS.TabIndex = 67;
            this.supplierCBS.SelectedIndexChanged += new System.EventHandler(this.supplierCBS_SelectedIndexChanged);
            // 
            // storeL
            // 
            this.storeL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.storeL.AutoSize = true;
            this.storeL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.storeL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeL.ForeColor = System.Drawing.Color.Silver;
            this.storeL.Location = new System.Drawing.Point(838, 137);
            this.storeL.Name = "storeL";
            this.storeL.Size = new System.Drawing.Size(47, 16);
            this.storeL.TabIndex = 58;
            this.storeL.Text = "Store";
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
            this.storeCB.Location = new System.Drawing.Point(839, 166);
            this.storeCB.Name = "storeCB";
            this.storeCB.Size = new System.Drawing.Size(192, 26);
            this.storeCB.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(692, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Store";
            // 
            // storeCBS
            // 
            this.storeCBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.storeCBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.storeCBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeCBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeCBS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeCBS.ForeColor = System.Drawing.Color.Silver;
            this.storeCBS.FormattingEnabled = true;
            this.storeCBS.Location = new System.Drawing.Point(695, 234);
            this.storeCBS.Name = "storeCBS";
            this.storeCBS.Size = new System.Drawing.Size(203, 26);
            this.storeCBS.TabIndex = 71;
            this.storeCBS.SelectedIndexChanged += new System.EventHandler(this.storeCBS_SelectedIndexChanged);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.storeCBS);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplierCBS);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productsGV);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageProducts_FormClosing);
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label nameL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox description;
        private System.Windows.Forms.Label descriptionL;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label categoryL;
        private System.Windows.Forms.Label supplierL;
        private System.Windows.Forms.ComboBox supplierCB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox minStock;
        private System.Windows.Forms.Label minL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stock;
        private System.Windows.Forms.Label stockL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buyingPrice;
        private System.Windows.Forms.Label buyingL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellingPrice;
        private System.Windows.Forms.Label sellingL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stockIn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton addStock;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid productsGV;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryCBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox supplierCBS;
        private Bunifu.Framework.UI.BunifuFlatButton export;
        private System.Windows.Forms.Label storeL;
        private System.Windows.Forms.ComboBox storeCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox storeCBS;
    }
}