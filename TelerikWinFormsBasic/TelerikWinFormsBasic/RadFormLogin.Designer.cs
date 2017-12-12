namespace TelerikWinFormsBasic
{
    partial class RadFormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadFormLogin));
            this.radLabelName = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPassword = new Telerik.WinControls.UI.RadLabel();
            this.radButtonLogin = new Telerik.WinControls.UI.RadButton();
            this.radButtonExit = new Telerik.WinControls.UI.RadButton();
            this.radTextName = new Telerik.WinControls.UI.RadTextBox();
            this.radTextPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabelName
            // 
            this.radLabelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radLabelName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelName.Location = new System.Drawing.Point(74, 154);
            this.radLabelName.Name = "radLabelName";
            this.radLabelName.Size = new System.Drawing.Size(50, 23);
            this.radLabelName.TabIndex = 0;
            this.radLabelName.Text = "Name";
            this.radLabelName.Click += new System.EventHandler(this.radLabelName_Click);
            // 
            // radLabelPassword
            // 
            this.radLabelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radLabelPassword.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelPassword.Location = new System.Drawing.Point(74, 210);
            this.radLabelPassword.Name = "radLabelPassword";
            this.radLabelPassword.Size = new System.Drawing.Size(75, 23);
            this.radLabelPassword.TabIndex = 1;
            this.radLabelPassword.Text = "Password";
            // 
            // radButtonLogin
            // 
            this.radButtonLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonLogin.Location = new System.Drawing.Point(130, 282);
            this.radButtonLogin.Name = "radButtonLogin";
            this.radButtonLogin.Size = new System.Drawing.Size(110, 24);
            this.radButtonLogin.TabIndex = 2;
            this.radButtonLogin.Text = "Login";
            this.radButtonLogin.Click += new System.EventHandler(this.radButtonLogin_Click);
            // 
            // radButtonExit
            // 
            this.radButtonExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonExit.Location = new System.Drawing.Point(326, 282);
            this.radButtonExit.Name = "radButtonExit";
            this.radButtonExit.Size = new System.Drawing.Size(110, 24);
            this.radButtonExit.TabIndex = 3;
            this.radButtonExit.Text = "Exit";
            this.radButtonExit.Click += new System.EventHandler(this.radButtonExit_Click);
            // 
            // radTextName
            // 
            this.radTextName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radTextName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextName.Location = new System.Drawing.Point(195, 154);
            this.radTextName.Name = "radTextName";
            this.radTextName.Size = new System.Drawing.Size(222, 24);
            this.radTextName.TabIndex = 0;
            // 
            // radTextPassword
            // 
            this.radTextPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radTextPassword.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextPassword.Location = new System.Drawing.Point(195, 210);
            this.radTextPassword.Name = "radTextPassword";
            this.radTextPassword.PasswordChar = '*';
            this.radTextPassword.Size = new System.Drawing.Size(222, 25);
            this.radTextPassword.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(242, 76);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 28);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "LOGIN";
            // 
            // RadFormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 426);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTextPassword);
            this.Controls.Add(this.radTextName);
            this.Controls.Add(this.radButtonExit);
            this.Controls.Add(this.radButtonLogin);
            this.Controls.Add(this.radLabelPassword);
            this.Controls.Add(this.radLabelName);
            this.Name = "RadFormLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadFormLogin";
            this.Load += new System.EventHandler(this.RadFormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabelName;
        private Telerik.WinControls.UI.RadLabel radLabelPassword;
        private Telerik.WinControls.UI.RadButton radButtonLogin;
        private Telerik.WinControls.UI.RadButton radButtonExit;
        private Telerik.WinControls.UI.RadTextBox radTextName;
        private Telerik.WinControls.UI.RadTextBox radTextPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
