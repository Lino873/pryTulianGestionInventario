using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace pryTulianGestionInventario
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            clsconexionBDsql conexion = new clsconexionBDsql();
            conexion.ConectarBD();
            conexion.Cargarcategorias(cbxcategoria);


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            clsconexionBD conexion = new clsconexionBD();
            conexion.ConectarBD();
            conexion.Agregarproductos(Convert.ToInt32(txtcodigo.Text), Convert.ToInt32(cbxcategoria.Text), txtnombre.Text, txtdescripcion.Text);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            clsconexionBD conexion = new clsconexionBD();
            conexion.ConectarBD();
            conexion.Modificarproductos(Convert.ToInt32(txtcodigo.Text), Convert.ToInt32(cbxcategoria.Text), txtnombre.Text, txtdescripcion.Text);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clsconexionBD conexion = new clsconexionBD();
            conexion.ConectarBD();
            conexion.Eliminarproductos(Convert.ToInt32(txtcodigo.Text));
        }   
    }
}
