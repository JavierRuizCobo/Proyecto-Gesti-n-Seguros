using ClienteSeguros.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSeguros
{
    public partial class FormularioPrograma : Form
    {
        public FormularioPrograma()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {

            if (activeForm != null) { 
                activeForm.Close();
            }

            activeForm= childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormularioCliente());
        }

        private void btnSeguros_Click(object sender, EventArgs e)
        {
            openChildForm(new FormularioSeguros());
        }

        private void btnContratarSeguro_Click(object sender, EventArgs e)
        {

            openChildForm(new FormularioContratos());
        }
    }
}
