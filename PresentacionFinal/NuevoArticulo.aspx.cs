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
        public bool ConfirmarEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.Logueado(Session["usuarios"]))
            
                Response.Redirect("Login.aspx", false);
            
            txtId.Enabled = false;
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
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                if ( id !="" && !IsPostBack)
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos metodos = new Metodos();

                Articulos nuevo = new Articulos();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.ImagenUrl = txtImagenUrl.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text.ToString());
                nuevo.Codigo = txtCodigo.Text;

                nuevo.Marcas = new Marcas();
                nuevo.Marcas.Id = int.Parse(ddlMarca.SelectedValue);

                nuevo.Categoria = new Categorias();
                nuevo.Categoria.Id = int.Parse(ddlCategorias.SelectedValue);

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    metodos.modificar(nuevo);
                }
                else
                {
                    metodos.agregar(nuevo);

                }
                Response.Redirect("Catalogo.aspx", false);
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



        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            ConfirmarEliminacion = true;

        }

        protected void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkConfirmarEliminacion.Checked)
                {

                    Metodos metodo = new Metodos();
                    metodo.eliminar(int.Parse(txtId.Text));
                    Response.Redirect("Catalogo.aspx", false);
                }


            }
            catch (Exception)
            {
                Session.Add("Error.aspx", false);
                throw;
            }
        }
    }
}