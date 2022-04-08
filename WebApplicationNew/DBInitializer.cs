using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows;

namespace WebApplicationNew
{
    public class DBInitializer
    {
        SqlConnection _connection = null;
        public DBInitializer()
        {
            try
            {
                _connection = new SqlConnection("Data Source=217.71.207.123,54321;Initial Catalog=Ignasi_Diagramas;Persist Security Info=True;User ID=sa;Password=123456789");
                _connection.Open();
            }
            catch (Exception r)
            {
                MessageBox.Show("Error al iniciar la BBDD: " + r.Message);
            }
        }
        public void Disconnect() { _connection.Close(); }
        public SqlConnection Connection { get => _connection; }
    }
}