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
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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

        async private void radButtonLogin_Click(object sender, EventArgs e)
        {
           /*
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
             */
            if ( radTextName.Text == "" || radTextPassword.Text == "")
            {
                MessageBox.Show("Please fill name or password!");
                return;
            }
            
            HttpConnect connect = new HttpConnect();
            LoginDTO login = new LoginDTO(radTextName.Text, radTextPassword.Text);
            try
            {
                HttpResponseMessage reponse = await connect.PostAsJsonAsync("PosServer/api/user/login", login);
                if (reponse.IsSuccessStatusCode)
                {
                    var responseContent = await reponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    JObject s =  JObject.Parse(responseContent.ToString());
                    this.Hide();
                    RadFormAdmin fm = new RadFormAdmin(s["token"].ToString());
                    fm.Show();
                }
                else
                {
                    var responseContent = await reponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Console.WriteLine(responseContent);
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch (Exception ex)
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
