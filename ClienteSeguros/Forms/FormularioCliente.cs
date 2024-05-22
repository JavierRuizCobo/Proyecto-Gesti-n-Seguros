using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSeguros
{
    public partial class FormularioCliente : Form
    {
        static GestionApiClientes gestionApiClientes = new GestionApiClientes();
        public FormularioCliente()
        {
            InitializeComponent();
            
        }
        private async void FormularioCliente_Load(object sender, EventArgs e)
        {
            panelMostrarClientes.DataSource = await gestionApiClientes.obtenerClientes();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string idCliente = panelMostrarClientes.CurrentRow.Cells["idCliente"].Value.ToString();

            var resultadoEliminacion = await gestionApiClientes.eliminarCliente(idCliente);

            panelMostrarClientes.DataSource = await gestionApiClientes.obtenerClientes();

            MessageBox.Show(resultadoEliminacion);
        }
        
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = panelMostrarClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            maskedTextBoxDNI.Text = panelMostrarClientes.CurrentRow.Cells["DNI"].Value.ToString();
            maskedTextBoxTelefono.Text = panelMostrarClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxCorreo.Text = panelMostrarClientes.CurrentRow.Cells["Correo"].Value.ToString();

            btnAñadirCliente.Visible= false;
        }
        
        private async void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            Cliente elCliente = rellenarCliente();

            var resultadoInsercion = await gestionApiClientes.añadirCliente(elCliente);

            MessageBox.Show(resultadoInsercion);

            panelMostrarClientes.DataSource = await gestionApiClientes.obtenerClientes();

            vaciarTextBox();
        }

        private async void btnActualizarCliente_Click(object sender, EventArgs e)
        {

            var cliente = rellenarCliente();

            string idCliente = panelMostrarClientes.CurrentRow.Cells["idCliente"].Value.ToString();
            
            var resultadoActualizacion = await gestionApiClientes.actualizarCliente(idCliente, cliente);

            MessageBox.Show(resultadoActualizacion);

            panelMostrarClientes.DataSource = await gestionApiClientes.obtenerClientes();

            btnAñadirCliente.Visible = true;

            vaciarTextBox();

        }

        private Cliente rellenarCliente()
        {
            var elCliente = new Cliente();

            elCliente.DNI = maskedTextBoxDNI.Text;
            elCliente.nombre = textBoxNombre.Text;
            elCliente.telefono = maskedTextBoxTelefono.Text;
            elCliente.correo = textBoxCorreo.Text;

            return elCliente;
        }
        
        private void vaciarTextBox()
        {
            maskedTextBoxDNI.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            maskedTextBoxTelefono.Text = string.Empty;
            textBoxCorreo.Text = string.Empty;
        }

    }
}
