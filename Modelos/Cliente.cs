using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {

        public int idCliente { get; set; }
        public string DNI { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public override string ToString()
        {
            return $"DNI: {DNI} , Nombre: {nombre}, Teléfono: {telefono}";
        }
    }
}
