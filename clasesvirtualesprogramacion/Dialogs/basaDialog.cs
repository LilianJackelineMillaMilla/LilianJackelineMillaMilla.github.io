using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasesvirtualesprogramacion.Dialogs
{
    public partial class basaDialog : Form
    {
        protected ErrorProvider erp = new ErrorProvider();
        public basaDialog()
        {
            InitializeComponent();
        }

        private void basaDialog_Load(object sender, EventArgs e)
        {
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool ValidarEntrada()
        {
            return true;
        }

        public bool NotificacionDeValidacion(string messege, Control objeto)
        {
            MessageBox.Show(messege, "Informacion sin ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (objeto != null)
                objeto.Focus();
            erp.SetError(objeto, messege);
            return false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada() == false)
                return;
            DialogResult = DialogResult.OK;
        }


    }
}
