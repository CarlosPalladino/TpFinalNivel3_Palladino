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
        public bool filtroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            filtroAvanzado = chkAvanzado.Checked;
            if (!IsPostBack)
            {
                Metodos datos = new Metodos();
                dgv.DataSource = datos.listar();
                dgv.DataBind();


            }



        }

        protected void dgv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgv.PageIndex = e.NewPageIndex;
            dgv.DataBind();
        }

        protected void dgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgv.SelectedDataKey.Value.ToString();
            Response.Redirect("NuevoArticulo.aspx?id=" + id);
        }



       


        protected void chkAvanzado_CheckedChanged1(object sender, EventArgs e)
        {
            filtroAvanzado = chkAvanzado.Checked;

        }

        protected void dllCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlCriterio.Items.Clear();

            if (ddlCampo.SelectedItem.ToString() == "Precio")
            {
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("menor a");
                ddlCriterio.Items.Add("igual a");
            }
            else
            {
                ddlCriterio.Items.Add("Empieza con");
                ddlCriterio.Items.Add("Termia con");
                ddlCriterio.Items.Add("Contiene ..");

            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos metodo = new Metodos();
                dgv.DataSource = metodo.Filtro(ddlCampo.SelectedItem.ToString(),
                    ddlCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text);
                dgv.DataBind();


            }
            catch (Exception)
            {
                Session.Add("error.asppx", false);

            }
        }
    }
}