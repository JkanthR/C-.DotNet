using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using System.Data;

namespace TelerikWinFormsBasic
{
    public partial class RadFormLogin : Telerik.WinControls.UI.RadForm
    {
        public RadFormLogin()
        {
            InitializeComponent();
        }

        private void radLabelName_Click(object sender, EventArgs e)
        {

        }

        private void radButtonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ED015WILSON\SQLEXPRESS;Initial Catalog=POINT_OF_SALE;User ID=wilson;Password=wilson123");
            try 
            {
                conn.Open();
                string tk = radTextName.Text;
                string mk = radTextPassword.Text;
                string sql = "select *from [USER] where USERNAME='"+tk+"' and PASSWORD='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read()== true) 
                {
                    this.Hide();
                    RadForm1 homeForm = new RadForm1(1);
                    homeForm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }

        }

        private void radButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RadFormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
