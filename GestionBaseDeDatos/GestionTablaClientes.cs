using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace GestionBaseDeDatos
{
    public class GestionTablaClientes : GestionBaseDatos
    {

        public GestionTablaClientes() :base() { } 
        public async Task<DataTable> obtenerClientes()
        {

            DataTable resultado = new DataTable();

            
            await mySqlConnection.OpenAsync();

            MySqlCommand command = new MySqlCommand("SELECT * FROM clientes", mySqlConnection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            await dataAdapter.FillAsync(resultado);

            await mySqlConnection.CloseAsync();

            return resultado;
   
        }

        public async Task<string> eliminarCliente(int id)
        {
               
            string cadena = $"DELETE FROM clientes WHERE idCliente=@id; DELETE FROM contratos WHERE idCliente = @id";

            await mySqlConnection.OpenAsync();
            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@id", id);
            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();

            return "Cliente eliminado";
        }

        public async Task<string> insertarCliente(Cliente cliente)
        {
            if (comprobarDatos(cliente) == false) return "Rellena todos los campos";

            if (existenciaCliente(cliente.DNI) == true) return "Cliente ya existe";

            string cadena = $"INSERT INTO clientes ( Nombre, DNI, Telefono, Correo) " +
                    $"VALUES (@Nombre,@DNI, @Telefono , @Correo)";

            await ejecutarComando(cadena, cliente);

            return "Cliente insertado";

        }

        public async Task<string> actualizarCliente(int id, Cliente cliente)
        {

            if (comprobarDatos(cliente) == false) return "Rellena todos los campos";

            string cadena = $"UPDATE Clientes SET Telefono = @Telefono, Nombre = @Nombre, DNI = @DNI, Correo = @Correo WHERE idCliente = {id}";

            await ejecutarComando(cadena, cliente);

            return $"Cliente con id: {id} actualizado";
        }

        private static async Task ejecutarComando(string cadena, Cliente cliente)
        {
            await mySqlConnection.OpenAsync();

            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@Nombre", cliente.nombre);
            command.Parameters.AddWithValue("@DNI", cliente.DNI);
            command.Parameters.AddWithValue("@Telefono", cliente.telefono);
            command.Parameters.AddWithValue("@Correo", cliente.correo);

            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();
        }

        private bool comprobarDatos(Cliente cliente)
        {
            if (cliente.DNI.Equals("") || cliente.nombre.Equals("") || cliente.telefono.Equals("") || cliente.correo.Equals("")) return false;

            return true;
        }

        private bool existenciaCliente(string DNI) {

            string cadena = "SELECT COUNT(*) FROM clientes WHERE DNI = @DNI";

            mySqlConnection.OpenAsync();
            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@DNI", DNI);
            
            int cantidadClientes = Convert.ToInt32(command.ExecuteScalar());

            mySqlConnection.CloseAsync();

            if (cantidadClientes>0) return true;

            return false;
        }
    }
}
