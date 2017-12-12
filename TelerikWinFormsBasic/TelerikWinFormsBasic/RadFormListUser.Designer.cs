namespace TelerikWinFormsBasic
{
    partial class RadFormListUser
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanelUserShow = new Telerik.WinControls.UI.RadPanel();
            this.radGridViewUser = new Telerik.WinControls.UI.RadGridView();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOINT_OF_SALEDataSet1 = new TelerikWinFormsBasic.POINT_OF_SALEDataSet1();
            this.radPanelListUser = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.uSERTableAdapter = new TelerikWinFormsBasic.POINT_OF_SALEDataSet1TableAdapters.USERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUserShow)).BeginInit();
            this.radPanelUserShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUser.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOINT_OF_SALEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelListUser)).BeginInit();
            this.radPanelListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radTextBox2);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radTextBox1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(200, 687);
            this.radPanel1.TabIndex = 2;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(3, 211);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(197, 25);
            this.radTextBox2.TabIndex = 2;
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
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(0, 90);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(197, 25);
            this.radTextBox1.TabIndex = 1;
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
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(222, 38);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(135, 32);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Employeers";
            // 
            // radPanelUserShow
            // 
            this.radPanelUserShow.Controls.Add(this.radGridViewUser);
            this.radPanelUserShow.Location = new System.Drawing.Point(202, 101);
            this.radPanelUserShow.Name = "radPanelUserShow";
            this.radPanelUserShow.Size = new System.Drawing.Size(763, 600);
            this.radPanelUserShow.TabIndex = 2;
            // 
            // radGridViewUser
            // 
            this.radGridViewUser.Location = new System.Drawing.Point(1, 0);
            // 
            // 
            // 
            this.radGridViewUser.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewUser.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "USERNAME";
            gridViewTextBoxColumn1.HeaderText = "USERNAME";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.MaxWidth = 250;
            gridViewTextBoxColumn1.MinWidth = 250;
            gridViewTextBoxColumn1.Name = "USERNAME";
            gridViewTextBoxColumn1.Width = 250;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "PHONE";
            gridViewDecimalColumn1.HeaderText = "PHONE";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.MaxWidth = 200;
            gridViewDecimalColumn1.MinWidth = 200;
            gridViewDecimalColumn1.Name = "PHONE";
            gridViewDecimalColumn1.Width = 200;
            gridViewTextBoxColumn2.FieldName = "ADDRESS";
            gridViewTextBoxColumn2.HeaderText = "ADDRESS";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.MaxWidth = 250;
            gridViewTextBoxColumn2.MinWidth = 250;
            gridViewTextBoxColumn2.Name = "ADDRESS";
            gridViewTextBoxColumn2.Width = 250;
            this.radGridViewUser.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2});
            this.radGridViewUser.MasterTemplate.DataSource = this.uSERBindingSource;
            this.radGridViewUser.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewUser.Name = "radGridViewUser";
            this.radGridViewUser.ReadOnly = true;
            this.radGridViewUser.Size = new System.Drawing.Size(763, 600);
            this.radGridViewUser.TabIndex = 3;
            this.radGridViewUser.Text = "radGridView1";
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.pOINT_OF_SALEDataSet1;
            // 
            // pOINT_OF_SALEDataSet1
            // 
            this.pOINT_OF_SALEDataSet1.DataSetName = "POINT_OF_SALEDataSet1";
            this.pOINT_OF_SALEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radPanelListUser
            // 
            this.radPanelListUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radPanelListUser.Controls.Add(this.radPanelUserShow);
            this.radPanelListUser.Controls.Add(this.radButton1);
            this.radPanelListUser.Controls.Add(this.radLabel3);
            this.radPanelListUser.Controls.Add(this.radPanel1);
            this.radPanelListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelListUser.Location = new System.Drawing.Point(0, 0);
            this.radPanelListUser.Name = "radPanelListUser";
            this.radPanelListUser.Size = new System.Drawing.Size(968, 687);
            this.radPanelListUser.TabIndex = 2;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.White;
            this.radButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(785, 47);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(108, 36);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Add User";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // RadFormListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 687);
            this.Controls.Add(this.radPanelListUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadFormListUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadFormListUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RadFormListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUserShow)).EndInit();
            this.radPanelUserShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUser.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOINT_OF_SALEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelListUser)).EndInit();
            this.radPanelListUser.ResumeLayout(false);
            this.radPanelListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanelUserShow;
        private Telerik.WinControls.UI.RadGridView radGridViewUser;
        private Telerik.WinControls.UI.RadPanel radPanelListUser;
        private POINT_OF_SALEDataSet1 pOINT_OF_SALEDataSet1;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private POINT_OF_SALEDataSet1TableAdapters.USERTableAdapter uSERTableAdapter;
        private Telerik.WinControls.UI.RadButton radButton1;

    }
}
