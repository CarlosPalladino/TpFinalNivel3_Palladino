using DiscosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using static System.Net.Mime.MediaTypeNames;

namespace Soluciones
{
    public class UsersMetodos
    {


        public void Nuevo(Users users)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO Users (UrlImagenPerfil, Email, Pass, Nombre, Apellido,Admin) VALUES (@UrlImagenPerfil, @Email, @Pass, @Nombre, @Apellido ,@Admin )");
                datos.setearParametro("@UrlImagenPerfil", users.UrlImagenPerfil);
                datos.setearParametro("@Email", users.Email);
                datos.setearParametro("@Pass", users.Pass);
                datos.setearParametro("@Nombre", users.Nombre);
                datos.setearParametro("@Apellido", users.Apellido);
                datos.setearParametro("Admin", users.Admin);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



        public bool Admin()
        {

            Users usuario = new Users();
            try
            {

                if (usuario.Email.Contains("@admin.com"))

                    usuario.Admin = true;
                else

                {
                    usuario.Admin = false;  
                }
                return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }



}
