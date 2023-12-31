﻿using System;
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
    public partial class frmTareascompletadas : Form
    {
        static string cadena = "Data Source = PC-STEVEN\\SQLEXPRESS; Initial Catalog= AdministradorTareas; Integrated Security = True";

        public frmTareascompletadas()
        {
            InitializeComponent();
        }

        private void frmTareascompletadas_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();

                    string query = "SELECT * FROM tarea WHERE estado ='TAREA COMPLETADA';";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreTarea = reader.GetString(1);
                                string tareaCompleta = nombreTarea;
                                lstbTareascompletadas.Items.Add(tareaCompleta);
                                Console.WriteLine("Datos ingresados al listbox correctamente");
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar datos al listbox porque: " + ex.Message);
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmAgregartareacompletada frmAgregartareacompletada = new frmAgregartareacompletada();
            frmAgregartareacompletada.Show();
            this.Close();
        }

        private void lstbTareascompletadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    string query = "SELECT * FROM tarea where '" + lstbTareascompletadas.Text + "'= nombreTarea;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tbxIdtarea.Text = reader.GetInt32(0).ToString();
                                tbxNombre.Text = reader.GetString(1);
                                DateTime fechaEntrega = reader.GetDateTime(3);
                                tbxFechaentrega.Text = fechaEntrega.ToString();
                                tbxDescripcion.Text = reader.GetString(4);
                                tbxEstado.Text = reader.GetString(5);
                                Console.WriteLine("Datos seleccionados correctamente");
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al seleccionar datos del listbox porque: " + ex.Message);
            }
        }

        private void btnModificartarea_Click(object sender, EventArgs e)
        {
            frmModificartarea frmModificartarea = new frmModificartarea(tbxIdtarea.Text, tbxNombre.Text, tbxFechaentrega.Text, tbxEstado.Text, tbxDescripcion.Text);
            frmModificartarea.Show();
        }

        private void btnBorrarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que deseas borrar los datos?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        connection.Open();
                        string query = "Delete FROM tarea where '" + lstbTareascompletadas.Text + "'= nombreTarea;";
                        using (SqlCommand commando = new SqlCommand(query, connection))
                        {
                            int filasAfectadas = commando.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                Console.WriteLine("Se han borrado los datos correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se han encontrado registros para borrar.");
                            }
                        }
                        connection.Close();
                        frmTareascompletadas frmTareascompletadas = new frmTareascompletadas();
                        frmTareascompletadas.Show();
                        this.Close();
                    }
                }
                else
                {
                    Console.WriteLine("Se cancelo borrar datos de la tarea");
                    frmTareascompletadas frmTareascompletadas = new frmTareascompletadas();
                    frmTareascompletadas.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar datos porque: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
