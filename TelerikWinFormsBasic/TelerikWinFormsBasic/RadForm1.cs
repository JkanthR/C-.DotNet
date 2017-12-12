using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TelerikWinFormsBasic
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        private int roler;
        public RadForm1(int roler)
        {
            this.roler = roler;
            InitializeComponent();
            
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOINT_OF_SALEDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.pOINT_OF_SALEDataSet.USER);
        
        }

        private void radMenuUser_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            radPanelUser.Controls.Clear();
            RadFormListUser listUser = new RadFormListUser();
            listUser.TopLevel = false;
            radPanelUser.Controls.Add(listUser);
            listUser.Show();
            
        }

        private void radPanelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
