using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasesvirtualesprogramacion.Froms
{
    public partial class frmGastosList : Form
    {
        admconexion oconexion = new admconexion();
        public frmGastosList()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Dialogs.GastosDialogs frmNuevo = new Dialogs.GastosDialogs();
            frmNuevo.fechaDateTimePicker.Focus();
            frmNuevo.ShowDialog();
            if (frmNuevo.DialogResult == DialogResult.OK)
            {
                string sqlInsert = string.Format("Insert Into gastos (fecha,categoria,subcategoria,descripcion,valor,formapago) values ('{0}','{1}','{2}','{3}','{4}','{5}')", frmNuevo.fechaDateTimePicker.Value.ToString("yyyy-MM-dd"), frmNuevo.categoriaComboBox.Text, frmNuevo.subcategoriaComboBox.Text, frmNuevo.descripcionTextBox.Text.Trim(),frmNuevo.valorNumericUpDown.Text,frmNuevo.formapagoComboBox.Text);
                if (oconexion.AccionSQL(sqlInsert) == true)
                {
                    this.frmGastosList_Load(null, null);
                    MessageBox.Show("La información de los gastos ha sido almacenada correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gastosDataGridView.Focus();
                }
              }
            }
    
        private void frmGastosList_Load(object sender, EventArgs e)
        {
            dsClasesVirtuales.gastos.Clear();
            string SelectSQL = "Select * from gastos";
            if (oconexion.SelectData(SelectSQL, dsClasesVirtuales.gastos) != true)
            {
                MessageBox.Show("No se ha podido cargar ningun dato de gastos contacte el departamento de desarrollo tecnico", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gastosBindingSource.Count > 0)
            {
                if (MessageBox.Show("Asegurese de querer eliminar la informacón de este gasto.Desesa eliminar permanente este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                    Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                    string sqlDelete = string.Format("delete from gastos where id = {0}", ID);
                    if (oconexion.AccionSQL(sqlDelete) == true)
                    {
                        this.frmGastosList_Load(null, null);
                        MessageBox.Show("La información del gasto ha sido eliminada correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No hay información para eliminar un registro.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gastosBindingSource.Count > 0)
            {
                Dialogs.GastosDialogs frmEditar = new Dialogs.GastosDialogs();
                DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                frmEditar.fechaDateTimePicker.Value = Convert.ToDateTime(Fila.Cells[1].Value.ToString());
                frmEditar.categoriaComboBox.Text = Fila.Cells[2].Value.ToString();
                frmEditar.subcategoriaComboBox.Text = Fila.Cells[3].Value.ToString();
                frmEditar.descripcionTextBox.Text = Fila.Cells[4].Value.ToString();
                frmEditar.valorNumericUpDown.Value = Convert.ToDecimal(Fila.Cells[5].Value.ToString());
                frmEditar.formapagoComboBox.Text = Fila.Cells[6].Value.ToString();
                frmEditar.fechaDateTimePicker.Focus();
                frmEditar.ShowDialog();
                if (frmEditar.DialogResult == DialogResult.OK)
                {
                    string sqlUpdate = string.Format("update gastos set fecha ='{0}',categoria ='{1}',subcategoria ='{2}',descripcion ='{3}',valor ='{4}',formapago='{5}' where id = {6}", frmEditar.fechaDateTimePicker.Value.ToString("yyyy-MM-dd"), frmEditar.categoriaComboBox.Text,frmEditar.subcategoriaComboBox.Text,
                        frmEditar.descripcionTextBox.Text.Trim(),frmEditar.valorNumericUpDown.Value.ToString(), frmEditar.formapagoComboBox.Text,ID);
                    if (oconexion.AccionSQL(sqlUpdate) == true)
                    {
                        this.frmGastosList_Load(null, null);
                        MessageBox.Show("La información del Gasto fue actualizada Correctamenta", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();
                    }
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmdBuscar.SelectedIndex < 0)
            {
                MessageBox.Show("debe selecionar una valor para buscar un gasto ya sea por categoria,subcategoria o descripcion", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdBuscar.Focus();
                return;
            }
            else
            {
                if (txtCriterio.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor ingrese un criterio para realizar la busqueda de los gastos", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCriterio.Focus();
                }
                else
                {
                    string sqlSelect = string.Empty;
                    switch (cmdBuscar.SelectedIndex)
                    {
                        case 0://categoria
                            sqlSelect = string.Format("Select * from gastos where categoria = '{0}'", txtCriterio.Text.Trim());
                            break;
                        case 1://subcategoria
                            sqlSelect = string.Format("Select * from gastos where subcategoria = '{0}'", txtCriterio.Text.Trim());
                            break;
                        default://descripcion
                            sqlSelect = string.Format("Select * from gastos where descripcion like '{0}%'", txtCriterio.Text.Trim());
                            break;
                    }
                    dsClasesVirtuales.gastos.Clear();
                    if (oconexion.SelectData(sqlSelect, dsClasesVirtuales.gastos) == true)
                        gastosDataGridView.Focus();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gastosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
  }
  
    

