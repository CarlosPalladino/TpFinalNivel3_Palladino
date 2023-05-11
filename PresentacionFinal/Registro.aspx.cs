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

            //string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            //    if (Request.QueryString["id"] != null)
            //{
            //    UsersMetodos usersMetodos = new UsersMetodos();
            //    // List<Users> lista = usersMetodos.listar(id);
            //    // Users seleccionado = lista[0];
            //    Users seleccionado = (usersMetodos.listar(id))[0];
            //    txtNombre.Text = seleccionado.Nombre;
            //    txtApellido.Text = seleccionado.Apellido;
            //    txtEmail.Text = seleccionado.Email;
            //    txtPassword.Text = seleccionado.Pass;
            //    txtImagen.Text = seleccionado.UrlImagenPerfil;

            //}




            //     if (Seguridad.Logueado(Session["usuarios"]))
            //  {

            //   Users user  =  (Users)Session["usuario"];
            //  txtEmail.ReadOnly = true;
            //
            //                txtNombre.Text = user.Nombre;
            //                  txtApellido.Text = user.Apellido;
            //                    if (!string.IsNullOrEmpty(user.UrlImagenPerfil))

            //   imgNuevoPerfil.ImageUrl = "~/images/" + user.UrlImagenPerfil;


            //          }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            UsersMetodos metodos = new UsersMetodos();
            try
            {
                string ruta = Server.MapPath("./images/");
                Users usuario = new Users();
                usuario.Nombre = txtNombre.Text;
                usuario.Pass = txtPassword.Text;
                usuario.Email = txtEmail.Text; 
                usuario.UrlImagenPerfil = "pefil-" + usuario.Email + ".jpg";
                usuario.Admin = chkAdmin.Checked;
                txtImage.PostedFile.SaveAs(ruta + "perfil-" + usuario.Email + ".jpg");
                usuario.Apellido = txtApellido.Text;


                Session.Add("usuarios", usuario);
                metodos.Nuevo(usuario);
                Response.Redirect("Catalogo.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("Error.aspx", false);
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
                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);
            }
        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            try
            {

            imgNuevoPerfil.ImageUrl = txtImagen.Text;
            }
            catch (Exception ex)
            { 
                Session.Add("error", ex); Response.Redirect("error.aspx", false);
            }
        }

     
    }
}