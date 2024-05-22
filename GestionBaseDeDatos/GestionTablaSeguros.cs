using Modelos;
using MySql.Data.MySqlClient;
using System;

using System.Data;
using System.Threading.Tasks;

namespace GestionBaseDeDatos
{
    public class GestionTablaSeguros : GestionBaseDatos
    {

        public GestionTablaSeguros() : base() { }
        public async Task<DataTable> obtenerSeguros()
        {

            DataTable resultado = new DataTable();

            await mySqlConnection.OpenAsync();

            MySqlCommand command = new MySqlCommand("SELECT * FROM seguros", mySqlConnection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

            await dataAdapter.FillAsync(resultado);

            await mySqlConnection.CloseAsync();

            return resultado;
            
        }

        public async Task<string> eliminarSeguro(int id)
        {
            
            string cadena = $"DELETE FROM seguros WHERE idSeguro=@id; DELETE FROM contratos WHERE idSeguro=@id";

            await mySqlConnection.OpenAsync();
            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@id", id);

            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();

            return "Seguro eliminado";
        }

        public async Task<string> insertarSeguro(Seguro seguro)
        {
            if (comprobarDatos(seguro) == false) return "Rellena todos los campos correctamente";

            string cadena = $"INSERT INTO seguros ( Nombre, Precio, Descripcion) " +
                    $"VALUES (@Nombre, @Precio, @Descripcion)";

            await ejecutarComando(cadena, seguro);

            return "Seguro insertado";

        }

        public async Task<string> actualizarSeguro(int id, Seguro seguro)
        {
            if (comprobarDatos(seguro) == false) return "Rellena todos los campos correctamente";

            string cadena = $"UPDATE seguros SET Nombre = @Nombre, Precio = @Precio, Descripcion= @Descripcion " +
                $"WHERE idSeguro = {id}";
            await ejecutarComando(cadena,seguro) ;

            return $"Seguro con id: {id} actualizado";
        }

        private static async Task ejecutarComando(string cadena, Seguro seguro)
        {
            await mySqlConnection.OpenAsync();
            MySqlCommand command = new MySqlCommand(cadena, mySqlConnection);
            command.Parameters.AddWithValue("@Nombre", seguro.nombre);
            command.Parameters.AddWithValue("@Precio", seguro.precio);
            command.Parameters.AddWithValue("@Descripcion", seguro.descripcion);

            await command.ExecuteNonQueryAsync();

            await mySqlConnection.CloseAsync();
        }

        private bool comprobarDatos(Seguro seguro)
        {
            if (seguro.nombre.Equals("") || seguro.precio.Equals("") || seguro.descripcion.Equals("")) return false;

            try { 
                Convert.ToInt32(seguro.precio);
            } 
            catch { return false; }

            return true;
        }

       

        
    }
}
