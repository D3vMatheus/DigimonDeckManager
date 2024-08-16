using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.DDMDB
{
    internal class Connection
    {
        private string _cs = "Host=localhost:5433;Username=postgres;Password=postgres;Database=postgres";
        private NpgsqlConnection _con;

        public NpgsqlConnection OpenConnection()
        {
            if (_con == null)
                _con = new NpgsqlConnection(_cs);
            if (_con.State != System.Data.ConnectionState.Open)
                _con.Open();
            return _con;
        }

        public void CloseConnection()
        {
            if (_con != null && _con.State == System.Data.ConnectionState.Open)
                _con.Close();
        }
    }
}
