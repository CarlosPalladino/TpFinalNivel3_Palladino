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
    public partial class _Default : Page
    {

        public List<Articulos> articulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            articulos = metodo.listar();

            repetidor.DataSource = articulos;
            repetidor.DataBind();


        }
    }
}