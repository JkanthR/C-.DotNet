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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radMenuSell = new Telerik.WinControls.UI.RadMenuItem();
            this.Products = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem15 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem16 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanelMenu = new Telerik.WinControls.UI.RadPanel();
            this.radMenu = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem17 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem18 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem19 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem20 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem21 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem22 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMenu)).BeginInit();
            this.radPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuSell
            // 
            this.radMenuSell.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuSell.Image = null;
            this.radMenuSell.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenuSell.ImageIndex = -1;
            this.radMenuSell.Name = "radMenuSell";
            this.radMenuSell.Text = "Sell";
            this.radMenuSell.Click += new System.EventHandler(this.radMenuSell_Click);
            // 
            // Products
            // 
            this.Products.Name = "Products";
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "Employees";
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Customors";
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "Statistical";
            // 
            // radMenuItem15
            // 
            this.radMenuItem15.Name = "radMenuItem15";
            this.radMenuItem15.Text = "Store";
            // 
            // radMenuItem16
            // 
            this.radMenuItem16.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.radMenuItem16.Enabled = false;
            this.radMenuItem16.ImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.radMenuItem16.Name = "radMenuItem16";
            this.radMenuItem16.PopupDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radMenuItem16.Text = "Your profile";
            this.radMenuItem16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPanelMenu
            // 
            this.radPanelMenu.Controls.Add(this.radMenu);
            this.radPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.radPanelMenu.Name = "radPanelMenu";
            this.radPanelMenu.Size = new System.Drawing.Size(1165, 42);
            this.radPanelMenu.TabIndex = 1;
            // 
            // radMenu
            // 
            this.radMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.radMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSell,
            this.Products,
            this.radMenuItem12,
            this.radMenuItem13,
            this.radMenuItem14,
            this.radMenuItem15,
            this.radMenuItem16,
            this.radMenuItem17,
            this.radMenuItem18,
            this.radMenuItem19,
            this.radMenuItem20,
            this.radMenuItem21,
            this.radMenuItem22});
            this.radMenu.Location = new System.Drawing.Point(0, 3);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(1162, 57);
            this.radMenu.TabIndex = 0;
            this.radMenu.Text = "radMenu5";
            // 
            // radMenuItem17
            // 
            this.radMenuItem17.Name = "radMenuItem17";
            this.radMenuItem17.Text = "radMenuItem17";
            // 
            // radMenuItem18
            // 
            this.radMenuItem18.Name = "radMenuItem18";
            this.radMenuItem18.Text = "radMenuItem18";
            // 
            // radMenuItem19
            // 
            this.radMenuItem19.Name = "radMenuItem19";
            this.radMenuItem19.Text = "radMenuItem19";
            // 
            // radMenuItem20
            // 
            this.radMenuItem20.Name = "radMenuItem20";
            this.radMenuItem20.Text = "radMenuItem20";
            // 
            // radMenuItem21
            // 
            this.radMenuItem21.Name = "radMenuItem21";
            this.radMenuItem21.Text = "radMenuItem21";
            // 
            // radMenuItem22
            // 
            this.radMenuItem22.Name = "radMenuItem22";
            this.radMenuItem22.Text = "radMenuItem22";
            // 
            // RadForm1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 608);
            this.Controls.Add(this.radPanelMenu);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMenu)).EndInit();
            this.radPanelMenu.ResumeLayout(false);
            this.radPanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

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
        private Telerik.WinControls.UI.RadMenu radMenu4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.UI.RadMenu radMenu3;
        private Telerik.WinControls.UI.RadMenuItem radMenuSell;
        private Telerik.WinControls.UI.RadMenuItem Products;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem12;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem14;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem15;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem16;
        private Telerik.WinControls.UI.RadPanel radPanelMenu;
        private Telerik.WinControls.UI.RadMenu radMenu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem17;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem18;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem19;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem20;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem21;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem22;

    }
}