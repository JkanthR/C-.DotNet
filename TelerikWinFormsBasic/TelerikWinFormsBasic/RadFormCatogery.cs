using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace TelerikWinFormsBasic
{
    public partial class RadFormCatogery : Telerik.WinControls.UI.RadForm
    {
        HttpConnect connect = new HttpConnect();
        private List<Model.Catogery> catogery;
        public RadFormCatogery()
        {
            GetCatogeryAsync();
            var source = new BindingSource();
            source.DataSource = catogery;
            radGridView1.DataSource = source;
            InitializeComponent();
        }

        private void RadFormCatogery_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public async void GetCatogeryAsync()
        {
            RadFormCatogery catogerys = null;
            connect.DefaultRequestHeaders.Add("token", RadFormAdmin.token);
            HttpResponseMessage response = await connect.GetAsync("PosServer/api/Category");
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("recevie data form serve");
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    catogery = new List<Model.Catogery>();
                    catogery = JsonConvert.DeserializeObject<List<Model.Catogery>>(Json);
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Console.WriteLine(responseContent);
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
           
               
        }

        private void RadFormCatogery_Load(object sender, EventArgs e)
        {
        
        }

        public string Json { get; set; }
    }
}
