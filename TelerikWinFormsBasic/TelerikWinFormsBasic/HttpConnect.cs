using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
namespace TelerikWinFormsBasic
{
    class HttpConnect: HttpClient
    {
        public string linkService { get; set; }
        public HttpConnect()
        {
            this.linkService = "http://192.168.21.22";
            this.BaseAddress = new Uri(this.linkService);
            this.DefaultRequestHeaders.Accept.Clear();
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
