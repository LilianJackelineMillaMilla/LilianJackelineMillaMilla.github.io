using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clasesvirtualesprogramacion.Dialogs;

namespace clasesvirtualesprogramacion.Dialogs
{
    public partial class EstudiantesDialog : basaDialog
    {
        public EstudiantesDialog()
        {
            InitializeComponent();
        }



        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (identidadTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba el numero de identidad del estudiante", identidadTextBox);
            if (sexoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione Femenino o Masculino para el Sexo del Estudiante",sexoComboBox);
            if (nombresTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor ingrese los nombres del Estudiante",nombresTextBox);
            if (apellidosTextBox.Text.Trim() == string.Empty)
                return (NotificacionDeValidacion("Por favor ingrese los apellidos del Estudiante",apellidosTextBox));
            if (direccionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la direccion donde vive el Estudiantes", direccionTextBox);

            return true;
        }

        private void apellidosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstudiantesDialog_Load(object sender, EventArgs e)
        {

        }

        private void obsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }
    }
}
