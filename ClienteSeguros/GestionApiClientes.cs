using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClienteSeguros
{
    public class GestionApiClientes
    {
        private static HttpClient httpClient;

        public GestionApiClientes() {

            httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("http://localhost:1532/api/Clientes/");

        }

        public async Task<DataTable> obtenerClientes() {

            var response = await httpClient.GetAsync("");

            var resultado = await response.Content.ReadAsStringAsync();

            var dataTable = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));

            return dataTable;
        }

        public async Task<string> eliminarCliente(string id) {

            var responseDelete = await httpClient.DeleteAsync(id);

            var resultado = await responseDelete.Content.ReadAsStringAsync();

            return resultado;

        }

        public async Task<string> añadirCliente(Cliente cliente) {

            var texto = JsonConvert.SerializeObject(cliente);

            var content = new StringContent(texto, Encoding.UTF8, "application/json");

            var responsePost = await httpClient.PostAsync("posts", content);

            var resultado = await responsePost.Content.ReadAsStringAsync();

            return resultado;
        }

        public async Task<string> actualizarCliente(string idCliente,Cliente cliente) {

            var texto = JsonConvert.SerializeObject(cliente);

            var content = new StringContent(texto, Encoding.UTF8, "application/json");

            var responsePut = await httpClient.PutAsync(idCliente, content);

            var respuestaActualizacion = await responsePut.Content.ReadAsStringAsync();

            return respuestaActualizacion;
            ;
        }

    }
}
