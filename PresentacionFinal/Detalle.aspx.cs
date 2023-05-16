using Datos;
using DiscosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionFinal
{
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.Logueado(Session["usuarios"]))
                Response.Redirect("Login.aspx", false);
            

            txtId.Enabled = false;
            ddlCategorias.Enabled = false;
            ddlMarca.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false; 
            txtImagenUrl.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            try
            {

                CategoriaLector categoria = new CategoriaLector();
                MarcarLector marca = new MarcarLector();

                if (!IsPostBack)
                {


                    List<Marcas> list = marca.listar();
                    ddlMarca.DataSource = list;
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();


                    List<Categorias> lista = categoria.listar();

                    ddlCategorias.DataSource = lista;
                    ddlCategorias.DataValueField = "Id";
                    ddlCategorias.DataTextField = "Descripcion";
                    ddlCategorias.DataBind();
                }
                if (Request.QueryString["id"] != null)
                {

                    Metodos metodo = new Metodos();
                    List<Articulos> lista = metodo.listar(Request.QueryString["id"].ToString());
                    Articulos seleccion = lista[0];
                    txtId.Text = seleccion.Id.ToString();
                    txtNombre.Text = seleccion.Nombre;
                    txtDescripcion.Text = seleccion.Descripcion;
                    txtCodigo.Text = seleccion.Codigo;
                    txtPrecio.Text = seleccion.Precio.ToString();

                    ddlCategorias.SelectedValue = seleccion.Categoria.Id.ToString();
                    ddlMarca.SelectedValue = seleccion.Marcas.Id.ToString();
                    txtImagenUrl_TextChanged(sender, e);
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex); Response.Redirect("error.aspx", false);
            }
        }

        protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                imgArticulo.ImageUrl = txtImagenUrl.Text;
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);
            }
        }
    }
    }

 
