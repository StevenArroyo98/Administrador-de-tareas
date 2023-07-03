using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class frmAgregartareaProceso : Form
    {
        static string cadena = "Data Source = PC-STEVEN\\SQLEXPRESS; Initial Catalog= AdministradorTareas; Integrated Security = True";
        public frmAgregartareaProceso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de que deseas insertar una nueva tarea?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DateTime fechaCreacion = DateTime.Now;
                string fechaCreacionString = fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        conexion.Open();

                        string consulta = "INSERT INTO tarea (nombreTarea, fechaCreacion, fechaEntrega, descripcion, estado)" +
                                          "VALUES (@nombreTarea, @fechaCreacion, @fechaEntrega, @descripcion, @estado)";

                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@nombreTarea", txbNombre.Text);
                        comando.Parameters.AddWithValue("@fechaCreacion", fechaCreacionString);
                        comando.Parameters.AddWithValue("@fechaEntrega", DateTime.Parse(dtFechaentrega.Text));
                        comando.Parameters.AddWithValue("@descripcion", txbDescripcion.Text);
                        comando.Parameters.AddWithValue("@estado", "TAREA EN PROCESO");

                        comando.ExecuteNonQuery();
                        Console.WriteLine("Los datos se añadieron correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al añadir datos porque: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Se cancelo el ingreso de una nueva tarea en progreso");
                frmTareasprogreso frmTareasprogreso = new frmTareasprogreso();
                frmTareasprogreso.Show();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
