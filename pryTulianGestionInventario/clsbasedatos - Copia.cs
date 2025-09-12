using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryTulianGestionInventario
{
    internal class clsconexionBDsql
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Ventas2;User Id='';Password='';Trusted_Connection=True";
        //string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDatos\\DataBase2.accdb";
        //conector
        SqlConnection coneccionBaseDatos;
        //OleDbConnection coneccionBaseDatos;
        //comando
        SqlCommand comandoBaseDatos;
        //OleDbCommand comandoBaseDatos;
        SqlCommand lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);
                //coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }
        public void Cargarcategorias(ComboBox listacategoria)
        {
            comandoBaseDatos = new SqlCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            comandoBaseDatos.CommandText =
                "SELECT marca_nombre FROM Productos";
            // lectorDataReader = comandoBaseDatos.ExecuteReader();

            //while (lectorDataReader.Read())
            {
                //listacategoria.Items.Add(lectorDataReader[0]);
            }


        }
        public void Agregarproductos(Int32 id, Int32 categoria, String nombre, String observaciones)
        {
            try
            {
                comandoBaseDatos = new SqlCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText =
                "INSERT INTO productos (id, categoria_de_producto, marca_nombre, observaciones) " +
                "VALUES (?, ?, ?, ?)";

                comandoBaseDatos.Parameters.AddWithValue("?", id);
                comandoBaseDatos.Parameters.AddWithValue("?", categoria);
                comandoBaseDatos.Parameters.AddWithValue("?", nombre);
                comandoBaseDatos.Parameters.AddWithValue("?", observaciones);
                comandoBaseDatos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un producto: " + ex.Message);
            }


        }
        public void Modificarproductos(Int32 id, Int32 categoria, String nombre, String observaciones)
        {
            try
            {
                comandoBaseDatos = new SqlCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText =
                    "UPDATE Productos SET categoria_de_producto = ?, marca_nombre = ?, observaciones = ? " +
                    "WHERE id = ?";

                comandoBaseDatos.Parameters.AddWithValue("?", categoria);
                comandoBaseDatos.Parameters.AddWithValue("?", nombre);
                comandoBaseDatos.Parameters.AddWithValue("?", observaciones);
                comandoBaseDatos.Parameters.AddWithValue("?", id);

                comandoBaseDatos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
        }

        public void Eliminarproductos(Int32 id)
        {
            try
            {
                comandoBaseDatos = new SqlCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText =
                    "DELETE FROM Productos WHERE id = ?";

                comandoBaseDatos.Parameters.AddWithValue("?", id);

                comandoBaseDatos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);

            }

        }


    }

}
