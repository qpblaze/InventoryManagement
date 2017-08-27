namespace InventoryManagement
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 145);
            this.panel1.TabIndex = 40;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.password.LineIdleColor = System.Drawing.Color.Silver;
            this.password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(13, 62);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(319, 41);
            this.password.TabIndex = 39;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // logInBtn
            // 
            this.logInBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.logInBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.logInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInBtn.BorderRadius = 0;
            this.logInBtn.ButtonText = "Log In";
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logInBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInBtn.ForeColor = System.Drawing.Color.Silver;
            this.logInBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logInBtn.Iconimage = null;
            this.logInBtn.Iconimage_right = null;
            this.logInBtn.Iconimage_right_Selected = null;
            this.logInBtn.Iconimage_Selected = null;
            this.logInBtn.IconRightVisible = true;
            this.logInBtn.IconRightZoom = 0D;
            this.logInBtn.IconVisible = true;
            this.logInBtn.IconZoom = 90D;
            this.logInBtn.IsTab = false;
            this.logInBtn.Location = new System.Drawing.Point(106, 164);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.logInBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.logInBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logInBtn.selected = false;
            this.logInBtn.Size = new System.Drawing.Size(128, 45);
            this.logInBtn.TabIndex = 45;
            this.logInBtn.Text = "Log In";
            this.logInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logInBtn.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 230);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuFlatButton logInBtn;
    }
}