using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegObjEncontrado_Click(object sender, EventArgs e)
        {
            frmObjetoEncontrado objeto = new frmObjetoEncontrado();
            objeto.Show();
        }

        private void btnRegDatosPropietario_Click(object sender, EventArgs e)
        {
            frmPropietario propietario = new frmPropietario();
            propietario.Show();
        }
    }
}
