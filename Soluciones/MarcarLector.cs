using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace DiscosDatos
{
    public class MarcarLector
    {
        public List<Marcas> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marcas> lista = new List<Marcas>();
            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
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

    }
}
