using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscosDatos;
using Soluciones;

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
            try
            {


            }
            catch (Exception )
            {
                Session.Add("Error.aspx", false);
                
            }
        }
    }
}