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
    public class ClientesController : ApiController
    {
        private static GestionTablaClientes gestionTablaClientes = new GestionTablaClientes();


        // GET api/<controller>/5
        public async Task<Cliente> Get(string id)
        {

            return null;
        }

        // GET api/<controller>
        public async Task<DataTable> Get()
        {
            return await gestionTablaClientes.obtenerClientes();
        }

        // POST api/<controller>
        public async Task<string> Post([FromBody] Cliente cliente)
        {

            return await gestionTablaClientes.insertarCliente(cliente);
        }

        // PUT api/<controller>/5
        public async Task<string> Put(string id, [FromBody] Cliente cliente)
        {
            return await gestionTablaClientes.actualizarCliente(int.Parse(id), cliente);
        }

        // DELETE api/<controller>/5
        public async Task<string> Delete(string id)
        {
            return await gestionTablaClientes.eliminarCliente(int.Parse(id));
        }
    }
}