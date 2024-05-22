using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GestionBaseDeDatos
{
    public class GestionTablaContratos : GestionBaseDatos
    {
        public GestionTablaContratos() : base() { }

        public async Task<DataTable> obtenerContratos()
        {

            DataTable resultado = new DataTable();

            await mySqlConnection.OpenAsync();

            string cadena = "SELECT id, clientes.Nombre AS NombreCliente, clientes.DNI ,seguros.Nombre AS NombreSeguro, fechaContratacion\r\n" +
                "FROM contratos \r\n" +
                "INNER JOIN clientes \r\n" +
                "ON contratos.idCliente = clientes.idCliente \r\n" +
                "INNER JOIN seguros \r\n" +
                "ON contratos.idSeguro = seguros.idSeguro";

            MySqlCommand command = new MySqlCommand(cadena , mySqlConnection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            await dataAdapter.FillAsync(resultado);

            await mySqlConnection.CloseAsync();

            return resultado;
        }

        public async Task<string> eliminarContrato(int id) {
            
            string cadena = $"DELETE FROM contratos WHERE id= @id";

            await mySqlConnection.OpenAsync();

            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@id", id);

            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();

            return "Contrato eliminado";
        }

        public async Task<string> añadirContrato(Contrato contrato) {

            if (existenciaContrato(contrato) == true) return "Contrato ya existe";
          
            string cadena = $"INSERT INTO contratos ( idCliente, idSeguro, fechaContratacion) " +
                    $"VALUES (@idCliente, @idSeguro , @fechaContratacion)";

            await ejecutarComando(cadena, contrato);

            return "Contrato insertado";
        }

        private bool existenciaContrato(Contrato contrato) {
            string cadena = "SELECT COUNT(*) FROM contratos WHERE idCliente = @idCliente AND idSeguro= @idSeguro";

            mySqlConnection.OpenAsync();
            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@idCliente", int.Parse(contrato.idCliente));
            command.Parameters.AddWithValue("@idSeguro", int.Parse(contrato.idSeguro));

            int cantidadSeguros = Convert.ToInt32(command.ExecuteScalar());

            mySqlConnection.CloseAsync();

            if (cantidadSeguros > 0) return true;

            return false;
        }

        private static async Task ejecutarComando(string cadena, Contrato contrato)
        {
            await mySqlConnection.OpenAsync();

            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@idCliente", Convert.ToInt32(contrato.idCliente));
            command.Parameters.AddWithValue("@idSeguro", Convert.ToInt32(contrato.idSeguro));
            command.Parameters.AddWithValue("@fechaContratacion", contrato.fechaContratacion.ToString("yyyyMMdd"));

            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();
        }
    }
}
