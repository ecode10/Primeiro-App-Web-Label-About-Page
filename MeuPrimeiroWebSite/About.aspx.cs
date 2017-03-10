using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuPrimeiroWebSite
{
    public partial class About : Page
    {
        private int idade;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                idade = 22;
                lblIdade.Text = idade.ToString();
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblIdade.Text = txtIdade.Text;
        }
    }
}