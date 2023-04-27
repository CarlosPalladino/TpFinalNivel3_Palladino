using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Datos;
using DiscosDatos;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionFinal
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Metodos datos = new Metodos();
            dgv.DataSource = datos.listar();
            dgv.DataBind();




        }

        protected void dgv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgv.PageIndex = e.NewPageIndex;
            dgv.DataBind();
        }

        protected void dgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgv.SelectedDataKey.Value.ToString();
            Response.Redirect("NuevoArticulo.aspx?id=" + id);
        }
    }
}