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
    public class GestionApiContratos
    {

        private static HttpClient httpClient;

        public GestionApiContratos()
        {

            httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("http://localhost:1532/api/Contratos/");

        }

        public async Task<DataTable> obtenerContratos()
        {

            var response = await httpClient.GetAsync("");

            var resultado = await response.Content.ReadAsStringAsync();

            var dataTable = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));

            return dataTable;
        }

        public async Task<string> añadirContrato(Contrato contato) {

            var texto = JsonConvert.SerializeObject(contato);

            var content = new StringContent(texto, Encoding.UTF8, "application/json");

            var responsePost = await httpClient.PostAsync("posts", content);

            var resultadoInsercion = await responsePost.Content.ReadAsStringAsync();

            return resultadoInsercion;
        }

        public async Task<string> eliminarContratos(string id)
        {

            var responseDelete = await httpClient.DeleteAsync(id);

            var resultadoEliminacion = await responseDelete.Content.ReadAsStringAsync();

            return resultadoEliminacion;

        }
    }
}
