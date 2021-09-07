using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosTienda
{
    public class Base
    {
        MySqlConnection _conn;
        public Base(string s, string u, string p, string b)
        {
            _conn = new MySqlConnection(string.Format("server = {0}; user = {1}; password = {2}; database = {3}",s,u,p,b));
        }
        public string Comando()
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                _conn.Open();
                _conn.Close();
                return "Correcto";
            }
            catch (Exception ex)
            {
                _conn.Close();
                return ex.Message;
            }
        }
        public DataSet Mostrar(string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                _conn.Open();
                da.Fill(ds, tabla);
                _conn.Close();
                return ds;
            }
            catch (Exception)
            {
                _conn.Close();
                return ds;
            }
        }
    }
}
