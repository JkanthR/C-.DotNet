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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOINT_OF_SALEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUser)).BeginInit();
            this.radPanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
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
            this.radPanelUser.Controls.Add(this.radButton1);
            this.radPanelUser.Controls.Add(this.radLabel3);
            this.radPanelUser.Controls.Add(this.radGridView1);
            this.radPanelUser.Controls.Add(this.radPanel1);
            this.radPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelUser.Location = new System.Drawing.Point(0, 30);
            this.radPanelUser.Name = "radPanelUser";
            this.radPanelUser.Size = new System.Drawing.Size(926, 704);
            this.radPanelUser.TabIndex = 1;
            this.radPanelUser.Visible = false;
            this.radPanelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanelUser_Paint);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radTextBox2);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radTextBox1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Location = new System.Drawing.Point(0, 19);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(200, 688);
            this.radPanel1.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.radLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(0, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(200, 37);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Search";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(0, 90);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(197, 25);
            this.radTextBox1.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.radLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(0, 149);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(200, 37);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Roles";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(3, 211);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(197, 25);
            this.radTextBox2.TabIndex = 2;
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(206, 90);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn11.FieldName = "USERNAME";
            gridViewTextBoxColumn11.HeaderText = "USERNAME";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.MaxWidth = 250;
            gridViewTextBoxColumn11.MinWidth = 250;
            gridViewTextBoxColumn11.Name = "USERNAME";
            gridViewTextBoxColumn11.Width = 250;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.FieldName = "PHONE";
            gridViewDecimalColumn6.HeaderText = "PHONE";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.MaxWidth = 200;
            gridViewDecimalColumn6.MinWidth = 200;
            gridViewDecimalColumn6.Name = "PHONE";
            gridViewDecimalColumn6.Width = 200;
            gridViewTextBoxColumn12.FieldName = "ADDRESS";
            gridViewTextBoxColumn12.HeaderText = "ADDRESS";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.MaxWidth = 250;
            gridViewTextBoxColumn12.MinWidth = 250;
            gridViewTextBoxColumn12.Name = "ADDRESS";
            gridViewTextBoxColumn12.Width = 250;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn12});
            this.radGridView1.MasterTemplate.DataSource = this.uSERBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(720, 617);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(222, 38);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(135, 32);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Employeers";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.White;
            this.radButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.ImageList = this.imageList1;
            this.radButton1.Location = new System.Drawing.Point(785, 47);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(108, 36);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Add User";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
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
            this.radPanelUser.ResumeLayout(false);
            this.radPanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
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
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.ImageList imageList1;
    }
}