using DiscosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionFinal
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page is Catalogo || Page is NuevoArticulo)
            {
                Seguridad.Logueado(Session["usuarios"]);
                Session.Add("error", "a donde queres ir  ?");
            }

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Catalogo.aspx", false);
        }
    }
}