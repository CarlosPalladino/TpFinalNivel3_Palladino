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

        protected void dgv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgv_PageIndexChanged(object sender, EventArgs e)
        {

        }
    }
}