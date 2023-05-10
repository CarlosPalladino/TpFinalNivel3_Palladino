using DiscosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Configuration;

namespace Soluciones
{
    public class UsersMetodos
    {
        public List<Users> listar(string id = "")
        {
            AccesoDatos datos = new AccesoDatos();
            List<Users> lista = new List<Users>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion = new SqlConnection(ConfigurationManager.AppSettings["cadenaConexion"]);
                comando.CommandType = System.Data.CommandType.Text;
                datos.setearConsulta("select Id ,UrlImagenPerfil,Nombre,Apellido ,Email,Password,Admin and ");
                if (id != null)
                    comando.CommandText += "and id = " + id;
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Users user = new Users();

                    user.id = (int)lector["id"];
                    user.UrlImagenPerfil = (string)lector["UrlImagenPerfil"];
                    user.Nombre = (string)lector["nombre"];
                    user.Apellido = (string)lector["apellido"];
                    user.Admin = (bool)lector["admin"];
                    user.Pass = (string)lector["pass"];

                    lista.Add(user);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

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


        public void Actualizar(Users user)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update Users set UrlImagenPerfil = @imagen,Nombre = @nombre,Apellido= @apellido ,Password = @pass Where id =@id ");
                datos.setearParametro("@imagen", user.UrlImagenPerfil);
                datos.setearParametro("@nombre", user.Nombre);
                datos.setearParametro("@apellido", user.Apellido);
                datos.setearParametro("@pass", user.Pass);

                datos.ejecutarLectura();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Login(Users usuario)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select  Id, Email, Pass ,Admin from users  where Email = @email And Pass = @pass ");
                datos.setearParametro("@email", usuario.Email);
                datos.setearParametro("@pass", usuario.Pass);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    usuario.id = (int)datos.Lector["id"];

                    usuario.Admin = (bool)datos.Lector["admin"];

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.cerrarLectura();
            }


        }

        public bool Admin()
        {

            Users usuario = new Users();
            try
            {
                // el que lleva el email es txtEmail. 



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
