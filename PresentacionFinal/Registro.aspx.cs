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

            UsersMetodos metodos = new UsersMetodos();
            try
           {
                string ruta = Server.MapPath("./images/");
                Users usuario = new Users();
                usuario.Nombre = txtNombre.Text;
                usuario.Pass =txtPassword.Text;
                usuario.Email =txtEmail.Text; // aca iria el otro
                usuario.UrlImagenPerfil = "pefil-" + usuario.Email + ".jpg";
                usuario.Admin = chkAdmin.Checked;
                txtImage.PostedFile.SaveAs(ruta + "perfil-" + usuario.Email +".jpg");
                usuario.Apellido =txtApellido.Text;

                metodos.Nuevo(usuario);
                Response.Redirect("Catalogo.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("Error.aspx",false);   
                throw ex;
            }
        }

        protected void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Users user = new Users();   
                if (chkAdmin.Checked)
                {
                    user.Admin = true;

                }
                else
                {
                    user.Admin = false;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}