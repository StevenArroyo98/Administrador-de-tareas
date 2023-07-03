using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class frmModificartarea : Form
    {
        static string cadena = "Data Source = PC-STEVEN\\SQLEXPRESS; Initial Catalog= AdministradorTareas; Integrated Security = True";

        public frmModificartarea(string idTarea, string nombreTarea, string fechaEntrega, string estadoTarea, string descripcionTarea)
        {
            InitializeComponent();
            tbxIdtarea.Text = idTarea;
            tbxNombretarea.Text = nombreTarea;
            DateTime fecha;
            if (DateTime.TryParseExact(fechaEntrega, "yyyy-M-d H:m:s", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                dtFechaentrega.Value = fecha;
            }
            tbxDescripcion.Text = descripcionTarea;
            if (estadoTarea == "TAREA POR REALIZAR")
            {
                rbnTareaporrealizar.Checked = true;
                rbnTareaproceso.Checked = false;
                rbnTareacompletada.Checked = false;
            }
            else if (estadoTarea == "TAREA EN PROCESO")
            {
                rbnTareaproceso.Checked = true;
                rbnTareaporrealizar.Checked = false;
                rbnTareacompletada.Checked = false;
            }
            else
            {
                rbnTareaproceso.Checked = false;
                rbnTareaporrealizar.Checked = false;
                rbnTareacompletada.Checked = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmModificartarea_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarcambios_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string estado = "";
                if (rbnTareacompletada.Checked == true)
                {
                    estado = "TAREA COMPLETADA";
                }
                else if (rbnTareaproceso.Checked == true)
                {
                    estado = "TAREA EN PROCESO";
                }
                else
                {
                    estado = "TAREA POR REALIZAR";
                }
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        conexion.Open();

                        string consulta = "UPDATE tarea SET nombreTarea = '" + tbxNombretarea.Text + "', fechaEntrega = '" + dtFechaentrega.Text +
                            "', descripcion = '" + tbxDescripcion.Text + "', estado = '" + estado + "' WHERE idTarea = " + int.Parse(tbxIdtarea.Text) + ";";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@nombreTarea", tbxNombretarea.Text);
                        comando.Parameters.AddWithValue("@fechaEntrega", dtFechaentrega.Text);
                        comando.Parameters.AddWithValue("@descripcion", tbxDescripcion.Text);
                        comando.Parameters.AddWithValue("@estado", estado);
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Los datos se modificaron correctamente");
                       
                        conexion.Close();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar datos porque: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Se cancelo la modificacion de datos de la tarea");
                frmTareasprogreso frmTareasprogreso = new frmTareasprogreso();
                frmTareasprogreso.Show();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
