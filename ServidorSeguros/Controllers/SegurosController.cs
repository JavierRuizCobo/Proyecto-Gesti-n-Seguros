using GestionBaseDeDatos;
using Modelos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace ServidorSeguros.Controllers
{
    public class SegurosController : ApiController
    {

        private static GestionTablaSeguros gestionTablaSeguros = new GestionTablaSeguros();


        // GET api/<controller>/5
        public async Task<Seguro> Get(string id)
        {
            return null;
        }

        // GET api/<controller>
        public async Task<DataTable> Get() {

            return await gestionTablaSeguros.obtenerSeguros();
        }

        // POST api/<controller>
        public async Task<string> Post([FromBody] Seguro seguro)
        {
            return await gestionTablaSeguros.insertarSeguro(seguro);
        }

        // PUT api/<controller>/5
        public async Task<string> Put(string id, [FromBody] Seguro seguro)
        {

            return await gestionTablaSeguros.actualizarSeguro(int.Parse(id), seguro);
        }

        // DELETE api/<controller>/5
        public async Task<string> Delete(string id)
        {
            return await gestionTablaSeguros.eliminarSeguro(int.Parse(id));
        }
    }
}