using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSeguros.Forms
{
    public partial class FormularioContratos : Form
    {
        public FormularioContratos()
        {
            InitializeComponent();
        }

        private static GestionApiContratos gestionApiContratosSeguros = new GestionApiContratos();
        private static GestionApiClientes gestionApiClientes = new GestionApiClientes();
        private static GestionApiSeguros GestionApiSeguros = new GestionApiSeguros();

        private async void FormularioContratosSeguros_Load(object sender, EventArgs e)
        {
            await mostrarContratos();
            await mostrarClientes();
            await mostrarSeguros();

        }

        private async Task mostrarContratos()
        {
            var dataTable = await gestionApiContratosSeguros.obtenerContratos();

            dtgMostrarContratos.DataSource = dataTable;
        }

        private async Task mostrarSeguros()
        {
            var datosSeguros = await GestionApiSeguros.obtenerSeguros();

            dtgMostrarSeguros.DataSource = datosSeguros;
        }

        private async Task mostrarClientes()
        {
            var datosClientes = await gestionApiClientes.obtenerClientes();
            
            dtgMostrarClientes.DataSource = datosClientes;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnEliminarContrato_Click(object sender, EventArgs e)
        {
            string idContrato = dtgMostrarContratos.CurrentRow.Cells["id"].Value.ToString();

            var resultadoEliminacion = await gestionApiContratosSeguros.eliminarContratos(idContrato);

            MessageBox.Show(resultadoEliminacion);

            await mostrarContratos();
        }
        private async void btnAñadirContrato_Click(object sender, EventArgs e)
        {
            try
            {
                Contrato contrato = rellernarContrato();

                var respuestaInsercion = await gestionApiContratosSeguros.añadirContrato(contrato);

                MessageBox.Show(respuestaInsercion);

                await mostrarContratos();

            }
            catch (Exception ex) {

                MessageBox.Show("Seleciona un cliente y un seguro");
            }
        }

        private Contrato rellernarContrato()
        {
            Contrato contrato = new Contrato();

            contrato.idCliente = dtgMostrarClientes.CurrentRow.Cells["idCliente"].Value.ToString();

            contrato.idSeguro = dtgMostrarSeguros.CurrentRow.Cells["idSeguro"].Value.ToString();

            contrato.fechaContratacion = DateTime.Now;

            return contrato;
        }

        
    }
}
