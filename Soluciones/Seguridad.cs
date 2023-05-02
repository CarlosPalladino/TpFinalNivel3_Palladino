using Datos;
using System;


namespace DiscosDatos
{
    public class Seguridad
    {

        public static bool Logueado(object users)
        {
            try
            {
                Users user = users != null ? (Users)users : null;
                if (user != null && user.id != 0)
                    return true;
                else 
                    return false;


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public static bool esAdmin(object users)
        {

            Users user = users != null ? (Users)users : null;
            return user != null ?  user.Admin :false ;
        }


    }
}
