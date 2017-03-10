using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuPrimeiroWebSite
{
    public partial class _Default : Page
    {
        public int idade { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            idade = 22;
            Response.Write(idade);     
        }
    }
}