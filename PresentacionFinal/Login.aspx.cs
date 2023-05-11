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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsersMetodos metodos = new UsersMetodos();
            Users usuarios = new Users();

            try
            {
                usuarios.Email = txtEmail.Text;
                usuarios.Pass = txtPassword.Text;
                if (metodos.Login(usuarios))
                {
                    Session.Add("usuarios", usuarios);
                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    Session.Add("Error.aspx", "user o pass incorrecto ");
                    Response.Redirect("Error.aspx", false);
                }


            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);

            }
        }


    }
}