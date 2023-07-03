using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proyecto1
{
    public class ConeccionDb
    {
        static string cadena = "Data Source = PC-STEVEN\\SQLEXPRESS; Initial Catalog= AdministradorTareas; Integrated Security = True";
        public SqlConnection coneccion = new SqlConnection(cadena);



        public void abrir()
        {
            try
            {
                coneccion.Open();
                Console.WriteLine("Coneccion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }
        public void cerrar()
        {
            try
            {
                coneccion.Close();
                Console.WriteLine("Coneccion cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la coneccion " + ex.Message);
            }
        }

    }
}
