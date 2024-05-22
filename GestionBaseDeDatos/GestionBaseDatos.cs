using System;
using MySql.Data.MySqlClient;


namespace GestionBaseDeDatos
{
    public class GestionBaseDatos
    {

        protected static MySqlConnection mySqlConnection;

        public GestionBaseDatos()
        {
            mySqlConnection= new MySqlConnection("server = localhost; database = basedatos_aseguradora; uid = root; pwd = ;");

        }

    }
}
