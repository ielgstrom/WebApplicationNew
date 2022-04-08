using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplicationNew.Clases;

namespace WebApplicationNew.DAL
{
    public class DALUser
    {
        DBInitializer DBinit = null;
        public DALUser()
        {
            DBinit = new DBInitializer();
        }
        public User findUser(User usuarioAMirar)
        {
            try
            {

            string sql = @"SELECT * FROM USUARIO
                    WHERE EMAIL=@pEmail AND Password=@pPassword";
            SqlCommand cmd = new SqlCommand(sql, DBinit.Connection);
            SqlParameter pMail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 50);
            pMail.Value = usuarioAMirar.mail;
            SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.VarChar, 50);
            pPassword.Value = usuarioAMirar.password;
            cmd.Parameters.Add(pMail);
            cmd.Parameters.Add(pPassword);
             SqlDataReader datos = cmd.ExecuteReader();
                if (datos.HasRows) return new User(usuarioAMirar.mail, usuarioAMirar.nombre, usuarioAMirar.password);
                else return null;
            }
            catch (Exception rt)
            {
                Console.WriteLine("Error al buscar: " + rt);
                return null;
            }

        }
    }
}