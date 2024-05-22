using GestionBaseDeDatos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ServidorSeguros.Controllers
{
    public class ContratosController : ApiController
    {

        private static GestionTablaContratos gestionTablaContratosSeguros = new GestionTablaContratos();

        // GET api/<controller>
        public async Task<DataTable> Get()
        {

            return await gestionTablaContratosSeguros.obtenerContratos();
        }
        // GET api/<controller>/5
        public async Task<Contrato> Get(int id)
        {
            return null;
        }

        // POST api/<controller>
        public async Task<string> Post([FromBody] Contrato contrato)
        {
            return await gestionTablaContratosSeguros.añadirContrato(contrato);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public async Task<string> Delete(string id)
        {
            return await gestionTablaContratosSeguros.eliminarContrato(int.Parse(id));
        }
    }
}