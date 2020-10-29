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
    public partial class GastosDialogs : basaDialog
    {
        public GastosDialogs()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (fechaDateTimePicker.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la fecha en que se registra el gasto", fechaDateTimePicker);
            if (formapagoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione la forma en que se llevara acabo el pago", formapagoComboBox);
            if (categoriaComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor ingrese la categoria en la cual se presentan los gastos", categoriaComboBox);
            if (subcategoriaComboBox.SelectedIndex < 0)
                return (NotificacionDeValidacion("Por favor ingrese la Subcategoria de donde provienen los gastos", subcategoriaComboBox));
            if (descripcionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba uuna breve descripcion de los gastos realizados", descripcionTextBox);

            return true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void formapagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
