using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Funciones;

namespace Presentacion
{
    public partial class frmObjetoEncontrado : Form
    {
        nObjetoEncontrado go = new nObjetoEncontrado();
        ObjetoEncontrado objetoseleccionado = null;
        int codobjeto;
        public frmObjetoEncontrado()
        {
            InitializeComponent();
            MostrarObjetos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreObjeto.Text != "" && txtFechaIngreso.Text != "")
            {
                MessageBox.Show(go.Registrarobjeto(txtNombreObjeto.Text,txtFechaIngreso.Text));
                MostrarObjetos();
            }
            else
            {
                MessageBox.Show("Debe ingresar un objeto y la fecha que se encontró.");
            }
        }

        private void MostrarObjetos()
        {
            dgObjetos.DataSource = go.Listarobjeto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgObjetos.SelectedRows.Count > 0)
            {
                MessageBox.Show(go.Modificarobjeto(codobjeto, txtNombreObjeto.Text,txtFechaIngreso.Text));
                MostrarObjetos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un objeto de la lista.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgObjetos.SelectedRows.Count > 0)
            {
                MessageBox.Show(go.Eliminarobjeto(codobjeto));
                MostrarObjetos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un objeto.");
            }
        }

        private void dgObjetos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgObjetos.SelectedRows.Count > 0)
                codobjeto = (int)dgObjetos.CurrentRow.Cells[0].Value;
        }

        private void dgObjetos_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dgObjetos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dgObjetos.CurrentRow.Index;
            txtNombreObjeto.Text = Convert.ToString(dgObjetos.Rows[fila].Cells[1].Value);
            txtFechaIngreso.Text = Convert.ToString(dgObjetos.Rows[fila].Cells[2].Value);
        }
    }
}
