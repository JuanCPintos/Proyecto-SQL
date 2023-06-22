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
    public partial class Editar : Form
    {
        //SqlConnection conexion;
        SqlConnection conexion = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true");

        public Editar()
        {
            InitializeComponent();
        }
        public Editar(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = conexion)
            {
                
                string cadena = "SELECT * FROM Variables;";

                using(SqlDataAdapter ADAPTADOR = new SqlDataAdapter(cadena, conn))
                {
                    conn.Open();

                    DataSet conjunto = new DataSet();

                    ADAPTADOR.Fill(conjunto, "Variables");


                    dataGridView1.DataSource = conjunto;
                    dataGridView1.DataMember = "Variables";
                }

               
            }
        }

         

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true"))
            {
                conn.Open();
                int ID = Convert.ToInt32(txtId.Texts);
                string cadena = "select * from Variables where id_input = @id";

                SqlCommand comando = new SqlCommand(cadena, conn);
                comando.Parameters.AddWithValue("@id", ID);

                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    txtMonto.Texts = leer["Monto"].ToString();
                    txtDetalle.Texts = leer["Detalle"].ToString();
                    cmbCategoria.Text = leer["Categoria"].ToString();
                    pickerFecha.Text = leer["Fecha"].ToString();
                    rbtGasto.Checked = (leer["Tipo"].ToString() == "Gasto") ? true : false ;
                }

            }
        }

        public string Fecha()
        {
            return $"{pickerFecha.Value.Year}/{pickerFecha.Value.Month}/{pickerFecha.Value.Day}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true"))
            {
                conn.Open();
                int ID = Convert.ToInt32(txtId.Texts);

                double monto = Convert.ToDouble(txtMonto.Texts);
                string tipo = rbtGasto.Checked ? "Gasto" : "Ingreso";
                string categoria = cmbCategoria.Text;
                string fecha = Fecha();
                string detalle = txtDetalle.Texts;

                string cadena = "update Variables set monto=@monto, tipo=@tipo," +
                    " categoria=@categoria, fecha=@fecha,detalle=@detalle where id_input= @id ;";

                SqlCommand comando = new SqlCommand(cadena, conn);

                comando.Parameters.AddWithValue("@monto", monto);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@detalle", detalle);
                comando.Parameters.AddWithValue("@id", ID);


                comando.ExecuteNonQuery();


                MessageBox.Show("Los datos se actualizaron correctamente");
            }
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true"))
            {
                conn.Open();

                int ID = Convert.ToInt32(txtId.Texts);

                string cadena = "DELETE FROM Variables WHERE id_input = @id;";

                SqlCommand comando = new SqlCommand(cadena, conn);

                comando.Parameters.AddWithValue("@id", ID);

                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se eliminaron correctamente");


            }
            this.Close();
        }
    }
}
