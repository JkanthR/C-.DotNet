using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWinFormsBasic.Model
{
    class Catogery
    {
         [JsonProperty(PropertyName = "ID")]
        private string ID { get; set; }
         [JsonProperty(PropertyName = "Name")]
        private string Name { get; set; }
         [JsonProperty(PropertyName = "Introduce")]
        private string Introduce { get; set; }
        public Catogery()
        {
           
        }
    }
}
