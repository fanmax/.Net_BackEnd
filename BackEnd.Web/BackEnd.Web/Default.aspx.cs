using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BackEnd.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLerPessoas_Click(object sender, EventArgs e)
        {
            DataTable dt = BackEnd_NG.PessoasNG.ObterPessoas();
            gvwPessoas.DataSource = dt;
            gvwPessoas.DataBind();


        }
    }
}