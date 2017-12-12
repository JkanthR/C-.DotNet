using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TelerikWinFormsBasic
{
    public partial class RadFormListUser : Telerik.WinControls.UI.RadForm
    {
        public RadFormListUser()
        {
            InitializeComponent();
            radGridViewUser.ShowGroupPanel = false;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void RadFormListUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOINT_OF_SALEDataSet1.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.pOINT_OF_SALEDataSet1.USER);

        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            radGridViewUser.Visible = false;
            radPanelUserShow.Controls.Clear();
            RadCreatUser crateUser = new RadCreatUser();
            crateUser.TopLevel = false;
            radPanelUserShow.Controls.Add(crateUser);
            crateUser.Show();
        }
    }
}
