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
    public partial class FormularioSeguros : Form
    {
        public FormularioSeguros()
        {
            InitializeComponent();
        }

        private static GestionApiSeguros gestionApiSeguros = new GestionApiSeguros();

        private async void FormularioSeguros_Load(object sender, EventArgs e)
        {
            dtgMostrarSeguros.DataSource = await gestionApiSeguros.obtenerSeguros();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminarSeguro_Click(object sender, EventArgs e)
        {
            string idSeguro = dtgMostrarSeguros.CurrentRow.Cells["idSeguro"].Value.ToString();

            var resultadoEliminacion = await gestionApiSeguros.eliminarSeguro(idSeguro);

            MessageBox.Show(resultadoEliminacion);

            dtgMostrarSeguros.DataSource = await gestionApiSeguros.obtenerSeguros();

        }

        private void btnEditarSeguro_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = dtgMostrarSeguros.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxPrecio.Text = dtgMostrarSeguros.CurrentRow.Cells["Precio"].Value.ToString();

            btnAñadirSeguro.Visible = false;
        }

        private async void btnAñadirSeguro_Click(object sender, EventArgs e)
        {
            Seguro seguro = rellenarSeguro();

            var resultadoInsercion = await gestionApiSeguros.añadirSeguro(seguro);

            MessageBox.Show(resultadoInsercion);

            dtgMostrarSeguros.DataSource = await gestionApiSeguros.obtenerSeguros();

            vaciarTextBox();
        }

        private async void btnActualizarSeguro_Click(object sender, EventArgs e)
        {
            var seguro = rellenarSeguro();

            string idSeguro = dtgMostrarSeguros.CurrentRow.Cells["idSeguro"].Value.ToString();

            var resultadoActualizacion = await gestionApiSeguros.actualizarSeguro(idSeguro, seguro);

            MessageBox.Show(resultadoActualizacion);

            btnAñadirSeguro.Visible = true;

            dtgMostrarSeguros.DataSource = await gestionApiSeguros.obtenerSeguros();

            vaciarTextBox();
        }

        private void vaciarTextBox()
        {
            textBoxNombre.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
        }

        private Seguro rellenarSeguro()
        {
            var seguro = new Seguro();

            seguro.nombre = textBoxNombre.Text;
            seguro.precio =textBoxPrecio.Text;
            seguro.descripcion=textBoxDescripcion.Text;

            return seguro;
        }

    }
}
