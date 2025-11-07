using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Windows.Forms.DataVisualization.Charting;


namespace pryTulianGestionInventario
{
    internal class clsconexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDatos\\DataBase2.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                //MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }
        public void Cargarcategorias(ComboBox listacategoria)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            comandoBaseDatos.CommandText =
                "SELECT marca_nombre FROM Productos";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read())
            {
                listacategoria.Items.Add(lectorDataReader[0]);
            }


        }
        public void Agregarproductos(Int32 id, Int32 categoria, String nombre, String observaciones, Int32 precio, Int32 stock)
        {
            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText =
                "INSERT INTO productos (id, categoria_de_producto, marca_nombre, observaciones, precio, stock) " +
                "VALUES (?, ?, ?, ?, ?, ?)";

                comandoBaseDatos.Parameters.AddWithValue("?", id);
                comandoBaseDatos.Parameters.AddWithValue("?", categoria);
                comandoBaseDatos.Parameters.AddWithValue("?", nombre);
                comandoBaseDatos.Parameters.AddWithValue("?", observaciones);
                comandoBaseDatos.Parameters.AddWithValue("?", precio);
                comandoBaseDatos.Parameters.AddWithValue("?", stock);

                comandoBaseDatos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar un producto: " + ex.Message);
            }


        }
        public void Modificarproductos(Int32 id, Int32 categoria, String nombre, String observaciones, Int32 precio, Int32 stock)
        {
            try
            {
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                comandoBaseDatos.CommandText =
                    "UPDATE Productos SET categoria_de_producto = ?, marca_nombre = ?, observaciones = ?, precio = ?, stock = ? " +
                    "WHERE id = ?";
                comandoBaseDatos.Parameters.AddWithValue("?", id);
                comandoBaseDatos.Parameters.AddWithValue("?", categoria);
                comandoBaseDatos.Parameters.AddWithValue("?", nombre);
                comandoBaseDatos.Parameters.AddWithValue("?", observaciones);
                comandoBaseDatos.Parameters.AddWithValue("?", precio);
                comandoBaseDatos.Parameters.AddWithValue("?", stock);



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
                comandoBaseDatos = new OleDbCommand();
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
        public void BuscarProductos(String nombreBusqueda, DataGridView dgvProductos)
        {
            // Objeto que contendrá los resultados de la consulta
            DataTable dt = new DataTable();
            OleDbCommand comandoBaseDatos = new OleDbCommand();

            try
            {
                // 1. Configuración del comando
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;

                // La consulta SQL (la que ya tenías)
                comandoBaseDatos.CommandText = "SELECT Id, categoria_de_producto, marca_nombre, precio, stock FROM Productos WHERE categoria_de_producto LIKE ?";

                // 2. Parámetros de la consulta
                comandoBaseDatos.Parameters.AddWithValue("?", "%" + nombreBusqueda + "%");

                // 3. Ejecutar la consulta y llenar el DataTable
                OleDbDataAdapter da = new OleDbDataAdapter(comandoBaseDatos);
                da.Fill(dt);

                // 4. Asignar el DataTable como fuente de datos del DataGridView
                dgvProductos.DataSource = dt;

                // OPCIONAL: Ocultar el ID si no quieres que se muestre, 
                // pero lo necesitas internamente
                if (dgvProductos.Columns.Contains("Id"))
                {
                    dgvProductos.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Limpiar el DGV en caso de error
                dgvProductos.DataSource = null;
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }

        }
        public void GenerarReporte(Chart chart)
        {
            try
            {
                chart.Series.Clear();
                chart.Legends.Clear();

                // Configuración de la serie del gráfico
                Series serieStock = new Series("StockXCategoria");
                serieStock.ChartType = SeriesChartType.Pie;

                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;

                // 1. CORRECCIÓN CLAVE: Consulta SQL para sumar stock por categoría
                // ASUMIMOS que el nombre correcto es 'categoria_de_producto' y 'stock'
                comandoBaseDatos.CommandText =
                    "SELECT categoria_de_producto AS Categoria, SUM(stock) AS TotalStock " +
                    "FROM Productos " +
                    "GROUP BY categoria_de_producto";

                // 2. Ejecutar la consulta
                // NOTA: Asegúrate de que coneccionBaseDatos esté abierta antes de esta línea.
                lectorDataReader = comandoBaseDatos.ExecuteReader();

                // 3. CORRECCIÓN CLAVE: Lectura de datos usando los alias de la consulta SQL
                while (lectorDataReader.Read())
                {
                    // Leemos los valores usando los alias definidos en la consulta
                    string categoria = lectorDataReader["Categoria"].ToString();

                    // Usamos GetInt32 o GetValue si estás seguro del tipo, o Convert
                    int totalStock = Convert.ToInt32(lectorDataReader["TotalStock"]);

                    // Agregar el punto al gráfico
                    int pointIndex = serieStock.Points.AddXY(categoria, totalStock);

                    // Configuraciones de leyenda y etiqueta
                    serieStock.Points[pointIndex].LegendText = categoria;
                }

                // Cierre del DataReader
                if (lectorDataReader != null && !lectorDataReader.IsClosed)
                {
                    lectorDataReader.Close();
                }

                // 4. Configuración final del Chart
                chart.Series.Add(serieStock);

                // Agregar y configurar la Leyenda
                Legend reporteLegend = new Legend("Reporte");
                chart.Legends.Add(reporteLegend);
                serieStock.Legend = "Reporte";

                // Configuración de las etiquetas para mostrar el porcentaje
                serieStock.IsValueShownAsLabel = true;
                // La propiedad LabelFormat usa el valor real (TotalStock).
                // Si quieres mostrar el porcentaje, el control Chart maneja la etiqueta #PERCENT automáticamente.
                serieStock.Label = "#PERCENT";
                serieStock.LabelFormat = "P0"; // P0 es formato porcentaje sin decimales
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }

        }
    }

}
