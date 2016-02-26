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
    public partial class frmPropietario : Form
    {
        private nPropietario gpropietario = new nPropietario();
        private nObjetoEncontrado gobjeto = new nObjetoEncontrado();

        ObjetoEncontrado objeto = null;
        Propietario propietario = null;
        int idpropietario;

        public frmPropietario()
        {
            InitializeComponent();
            MostrarPropietarios();
            MostrarObjeto();
        }

        private void MostrarObjeto()
        {
            cboObjeto.DataSource = gobjeto.Listarobjeto();
        }

        private void MostrarPropietarios()
        {
            dgPropietarios.DataSource = gpropietario.Listarpropietario();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboObjeto.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtFechaDevolucion.Text != "")
            {
                MessageBox.Show(gpropietario.Registrarpropietario(txtNombre.Text, txtApellidos.Text, objeto.IdObjetoEncontrado, objeto.Fecha, txtFechaDevolucion.Text));
                MostrarPropietarios();
            }
            else
            {
                MessageBox.Show("Debe escoger un objeto, ingresar los datos del propietario y la fecha que se está devolviendo.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgPropietarios.SelectedRows.Count > 0)
            {
                MessageBox.Show(gpropietario.Modificarpropietario(idpropietario, txtNombre.Text, txtApellidos.Text, objeto.IdObjetoEncontrado, objeto.Fecha, txtFechaDevolucion.Text));
                MostrarPropietarios();
            }
            else
            {
                MessageBox.Show("Por favor, debe seleccionar un propietario.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgPropietarios.SelectedRows.Count > 0)
            {
                MessageBox.Show(gpropietario.Eliminarpropietario(idpropietario));
                MostrarPropietarios();
            }
            else
            {
                MessageBox.Show("Por favor, debe seleccionar un propietario de la lista.");
            }
        }

        private void cboObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objeto = cboObjeto.SelectedItem as ObjetoEncontrado;
        }

        private void dgPropietarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPropietarios.SelectedRows.Count > 0)
                idpropietario = (int)dgPropietarios.CurrentRow.Cells[0].Value;
        }

        private void frmPropietario_Load(object sender, EventArgs e){}

        private void frmPropietario_MouseClick(object sender, MouseEventArgs e) {}

        private void dgPropietarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dgPropietarios.CurrentRow.Index;
            txtNombre.Text = Convert.ToString(dgPropietarios.Rows[fila].Cells[1].Value);
            txtApellidos.Text = Convert.ToString(dgPropietarios.Rows[fila].Cells[2].Value);
            cboObjeto.Text = Convert.ToString(dgPropietarios.Rows[fila].Cells[3].Value);
            txtFechaDevolucion.Text = Convert.ToString(dgPropietarios.Rows[fila].Cells[5].Value);
        }
    }
}
