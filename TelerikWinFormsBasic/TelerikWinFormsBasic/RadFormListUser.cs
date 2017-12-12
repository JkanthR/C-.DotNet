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
            radGridView1.ShowGroupPanel = false;
        }

        private void RadFormListUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOINT_OF_SALEDataSet1.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.pOINT_OF_SALEDataSet1.USER);

        }
    }
}
