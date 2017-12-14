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
    public partial class RadFormAdmin : Telerik.WinControls.UI.RadForm
    {
        public static string token ;
        public RadFormAdmin(string token1)
        {
            InitializeComponent();
            token = token1;
            
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOINT_OF_SALEDataSet.USER' table. You can move, or remove it, as needed.
        
        }
        private void radPanelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureCaregory_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadFormCatogery catogery = new RadFormCatogery();
            catogery.Show();
        }

        
    }
}
