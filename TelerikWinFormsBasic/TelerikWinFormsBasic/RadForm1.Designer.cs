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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOINT_OF_SALEDataSet = new TelerikWinFormsBasic.POINT_OF_SALEDataSet();
            this.uSERTableAdapter = new TelerikWinFormsBasic.POINT_OF_SALEDataSetTableAdapters.USERTableAdapter();
            this.radMenu5 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem23 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem24 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuUser = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem26 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem27 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem28 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanelUser = new Telerik.WinControls.UI.RadPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOINT_OF_SALEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.pOINT_OF_SALEDataSet;
            // 
            // pOINT_OF_SALEDataSet
            // 
            this.pOINT_OF_SALEDataSet.DataSetName = "POINT_OF_SALEDataSet";
            this.pOINT_OF_SALEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // radMenu5
            // 
            this.radMenu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radMenu5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem23,
            this.radMenuItem24,
            this.radMenuUser,
            this.radMenuItem26,
            this.radMenuItem27,
            this.radMenuItem28});
            this.radMenu5.Location = new System.Drawing.Point(0, 0);
            this.radMenu5.Name = "radMenu5";
            this.radMenu5.Size = new System.Drawing.Size(926, 30);
            this.radMenu5.TabIndex = 0;
            this.radMenu5.Text = "radMenu5";
            // 
            // radMenuItem23
            // 
            this.radMenuItem23.Name = "radMenuItem23";
            this.radMenuItem23.Text = "radMenuItem23";
            // 
            // radMenuItem24
            // 
            this.radMenuItem24.Name = "radMenuItem24";
            this.radMenuItem24.Text = "radMenuItem24";
            // 
            // radMenuUser
            // 
            this.radMenuUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuUser.Name = "radMenuUser";
            this.radMenuUser.Text = "Users";
            this.radMenuUser.Click += new System.EventHandler(this.radMenuUser_Click);
            // 
            // radMenuItem26
            // 
            this.radMenuItem26.Name = "radMenuItem26";
            this.radMenuItem26.Text = "radMenuItem26";
            // 
            // radMenuItem27
            // 
            this.radMenuItem27.Name = "radMenuItem27";
            this.radMenuItem27.Text = "radMenuItem27";
            // 
            // radMenuItem28
            // 
            this.radMenuItem28.Name = "radMenuItem28";
            this.radMenuItem28.Text = "radMenuItem28";
            // 
            // radPanelUser
            // 
            this.radPanelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelUser.Location = new System.Drawing.Point(0, 30);
            this.radPanelUser.Name = "radPanelUser";
            this.radPanelUser.Size = new System.Drawing.Size(926, 704);
            this.radPanelUser.TabIndex = 1;
            this.radPanelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanelUser_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon-person-add-128.png");
            this.imageList1.Images.SetKeyName(1, "download.png");
            // 
            // RadForm1
            // 
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 734);
            this.Controls.Add(this.radPanelUser);
            this.Controls.Add(this.radMenu5);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOINT_OF_SALEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUser)).EndInit();
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
        private POINT_OF_SALEDataSet pOINT_OF_SALEDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private POINT_OF_SALEDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private Telerik.WinControls.UI.RadMenu radMenu5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem23;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem24;
        private Telerik.WinControls.UI.RadMenuItem radMenuUser;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem26;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem27;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem28;
        private Telerik.WinControls.UI.RadPanel radPanelUser;
        private System.Windows.Forms.ImageList imageList1;
    }
}