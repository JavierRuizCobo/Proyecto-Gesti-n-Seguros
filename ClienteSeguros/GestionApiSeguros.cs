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
    public class GestionApiSeguros
    {

        private static HttpClient httpClient;

        public GestionApiSeguros()
        {

            httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("http://localhost:1532/api/Seguros/");

        }

        public async Task<DataTable> obtenerSeguros()
        {

            var response = await httpClient.GetAsync("");

            var resultado = await response.Content.ReadAsStringAsync();

            var dataTable = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));

            return dataTable;
        }

        public async Task<string> eliminarSeguro(string id)
        {

            var responseDelete = await httpClient.DeleteAsync(id);

            var resultadoEliminacion = await responseDelete.Content.ReadAsStringAsync();

            return resultadoEliminacion;

        }

        public async Task<string> añadirSeguro(Seguro cliente)
        {

            var texto = JsonConvert.SerializeObject(cliente);

            var content = new StringContent(texto, Encoding.UTF8, "application/json");

            var responsePost = await httpClient.PostAsync("posts", content);

            var resultado = await responsePost.Content.ReadAsStringAsync();

            return resultado;
        }

        public async Task<string> actualizarSeguro(string idSeguro, Seguro seguro)
        {
            var texto = JsonConvert.SerializeObject(seguro);

            var content = new StringContent(texto, Encoding.UTF8, "application/json");

            var responsePut = await httpClient.PutAsync(idSeguro, content);

            var resultadoActualizacion = await responsePut.Content.ReadAsStringAsync();

            return resultadoActualizacion;

        }
    }
}
