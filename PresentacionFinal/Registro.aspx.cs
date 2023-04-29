using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscosDatos;
using Datos;
using Soluciones;

namespace PresentacionFinal
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            UserMetodos metodos = new UserMetodos();
            try
            {
                string ruta = Server.MapPath("./images/");
                Users usuario = new Users();
                usuario.fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                usuario.nombre = txtNombre.Text;
                usuario.pass =txtPassword.Text;
                usuario.email =txtEmail.Text;
                usuario.UrlImagenPerfil = "pefil-" + usuario.email + ".jpg";
                txtImage.PostedFile.SaveAs(ruta + "perfil-" + usuario.email +".jpg");
                usuario.apellido =txtApellido.Text;

                metodos.Nuevo(usuario);
                Response.Redirect("Catalogo.aspx", false);
      //      usuario.Admin = metodos.isAdmin();
            }
            catch (Exception ex)
            {
                Session.Add("Error.aspx",false);   
                throw ex;
            }
        }
    }
}