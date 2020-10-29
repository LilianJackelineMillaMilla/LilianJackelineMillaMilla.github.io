using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace clasesvirtualesprogramacion
{
    class admconexion
    {
        // Dar acceso público al objeto para administrar la conexión con la BD
        public MySqlConnection oconexion;
        /* Función para abrir una conexión,si el estado de la misma es abierto, 
         entonces que esta sea cerrado para abrir una nueva conexión*/
        public bool AbrirConexion()
        {
            bool conectado = false;
            string servidor = "localhost", puerto = "3306";
            string usuario = "root", contraseña = "root", BD = "clasesvirtuales";
            string CadenaConexion = string.Format("datasource = {0};port = {1};username = {2}; password = {3}; database = {4}",servidor,puerto,usuario,contraseña,BD);
            try
            {
                if (oconexion != null && oconexion.State == ConnectionState.Open)
                    oconexion.Close();

                oconexion = new MySqlConnection(CadenaConexion);
                    oconexion.Open();
                    conectado = true;
                
            }
            catch (MySqlException Exeption)
            {
                MessageBox.Show(Exeption.Message,"Error en conexión",MessageBoxButtons.OK,MessageBoxIcon.Information);
                conectado = false;
            }

            return conectado;
        }

        public bool SelectData (string SQL, DataTable Tabla)
        { 
            bool ejecucionCorrecta = false;

            if (this.AbrirConexion() == true)
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(SQL, oconexion);
                    da.Fill(Tabla);
                    ejecucionCorrecta = true;
                    oconexion.Close();
                }
                catch (MySqlException Exepcion)
                {
                    MessageBox.Show(Exepcion.Message, "Error en SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ejecucionCorrecta = false;
                }
            }
                return ejecucionCorrecta;

            }

        public bool AccionSQL(string SQL)
        {
            bool ejeccionCorrrecta = false;
            if(this.AbrirConexion()== true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(SQL,oconexion);
                    cmd.ExecuteNonQuery();
                    ejeccionCorrrecta =true;
                    oconexion.Close();
                }
                catch (MySqlException Exception)
                {
                    MessageBox.Show(Exception.Message, "Error en SQL acción",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ejeccionCorrrecta = false;
                }
            }
            return ejeccionCorrrecta;
        }
    }
}
