using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_SQL
{
    public partial class Campos : Form
    {
        //SqlConnection conexion;
        SqlConnection conexion = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true");

        double monto;
        string tipo;
        string categoria;
        string fecha;
        string detalle;



        public Campos()
        {
            InitializeComponent();
        }
        //public Campos(SqlConnection conexion)
        //{
        //    InitializeComponent();
        //    this.conexion = conexion;

        //}

        public string Fecha()
        {
            return $"{pickerFecha.Value.Year}/{pickerFecha.Value.Month}/{pickerFecha.Value.Day}";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = conexion)
            {
                conn.Open();

                monto = Convert.ToDouble(txtMonto.Texts);
                tipo = rbtGasto.Checked ? "Gasto" : "Ingreso";
                categoria = cmbCategoria.Text;
                fecha = Fecha();
                detalle = txtDetalle.Texts;


                string cadena ="INSERT INTO Variables(monto, tipo, categoria, fecha, detalle)" +
                    "values (@monto, @tipo, @categoria, @fecha, @detalle)";

                SqlCommand comando = new SqlCommand(cadena, conn);

                comando.Parameters.AddWithValue("@monto", monto);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@detalle", detalle);

                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron correctamente");



            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Quiere cerrar la pestaña actual?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
                this.Close();
        }

    }
}
