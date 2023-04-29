using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscosDatos;
using Soluciones;
using Datos;

namespace PresentacionFinal
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                string ruta = Server.MapPath("./images/");
                Users usuario = new Users();
                txtImage.PostedFile.SaveAs(ruta + "perfil-" + usuario.Email);

            }
            catch (Exception ex)
            {
            // Session.Add("")   
                throw ex;
            }
        }
    }
}