namespace TelerikWinFormsBasic
{
    partial class RadForm1
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radMenu3 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radMenu4 = new Telerik.WinControls.UI.RadMenu();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu3
            // 
            this.radMenu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radMenu3.Dock = System.Windows.Forms.DockStyle.None;
            this.radMenu3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem11});
            this.radMenu3.Location = new System.Drawing.Point(-6, 1);
            this.radMenu3.Name = "radMenu3";
            this.radMenu3.Size = new System.Drawing.Size(1213, 30);
            this.radMenu3.TabIndex = 0;
            this.radMenu3.Text = "radMenu3";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "";
            this.radMenuItem9.Click += new System.EventHandler(this.radMenuItem9_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Giới thiệu";
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "radMenuItem11";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Green;
            this.radGroupBox1.HeaderText = "Quản lí nhân viên";
            this.radGroupBox1.Location = new System.Drawing.Point(-6, 37);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(163, 139);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Quản lí nhân viên";
            this.radGroupBox1.ThemeName = "Office2007Black";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click_1);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.Green;
            this.radGroupBox2.HeaderText = "Quản lí hàng hóa";
            this.radGroupBox2.Location = new System.Drawing.Point(-6, 182);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(163, 151);
            this.radGroupBox2.TabIndex = 2;
            this.radGroupBox2.Text = "Quản lí hàng hóa";
            this.radGroupBox2.ThemeName = "Office2007Black";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.BackColor = System.Drawing.Color.Green;
            this.radGroupBox3.HeaderText = "Thống kê";
            this.radGroupBox3.Location = new System.Drawing.Point(-6, 339);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(163, 168);
            this.radGroupBox3.TabIndex = 4;
            this.radGroupBox3.Text = "Thống kê";
            this.radGroupBox3.ThemeName = "Office2007Black";
            // 
            // radMenu4
            // 
            this.radMenu4.BackColor = System.Drawing.Color.Green;
            this.radMenu4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radMenu4.Location = new System.Drawing.Point(0, 578);
            this.radMenu4.Name = "radMenu4";
            this.radMenu4.Size = new System.Drawing.Size(839, 20);
            this.radMenu4.TabIndex = 5;
            this.radMenu4.Text = "radMenu4";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(187, 62);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(643, 412);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // RadForm1
            // 
            this.ClientSize = new System.Drawing.Size(839, 598);
            this.Controls.Add(this.radMenu4);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radMenu3);
            this.DoubleBuffered = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.radMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadMenu radMenu2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenu radMenu3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadMenu radMenu4;
        private Telerik.WinControls.UI.RadGridView radGridView1;

    }
}