using DiscosDatos;
using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionFinal
{
    public partial class NuevoArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            try
            {

                if (!IsPostBack)
                {
                    CategoriaLector lector = new CategoriaLector();
                    MarcarLector marcar = new MarcarLector();

                    List<Marcas> lista = marcar.listar();
                    ddlMarca.DataSource = lista;
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();

                
                    List<Categorias> cat = lector.listar();
                 //   CategoriaLector lector = new CategoriaLector();
                   // List<Categorias> listaCategorias = lector.listar();
                    ddlCategorias.DataSource = lector.listar();
                    ddlCategorias.DataValueField = "Id";
                    ddlCategorias.DataTextField = "Descripcion";
                    ddlCategorias.DataBind();
                }

            }
            catch (Exception ex)
            {

                Session.Add("Error.aspx", false);
                    }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos nuevo = new Articulos();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.ImagenUrl =txtImagenUrl.Text;
            nuevo.Precio =decimal.Parse(txtPrecio.Text.ToString());
            

        }


        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}