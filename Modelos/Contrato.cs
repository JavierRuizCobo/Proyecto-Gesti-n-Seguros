using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Contrato
    {
        public string idCliente { get; set; }
        public string idSeguro { get; set; }

        public DateTime fechaContratacion { get; set; }
    }
}
