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
    public partial class VentanaPrincipal : Form
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-RGCQJI5I\\SQLEXPRESS; database=ProyectoSQL; integrated security=true");

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Campos Ingreso = new Campos(conexion);
            Ingreso.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = conexion)
            {
                string cadena = "select sum(monto) as suma_ingresos from Variables where tipo='Ingreso';";
                string sumaIngresos;
                string sumaGastos;

                using (SqlCommand suma = new SqlCommand(cadena, conn))
                {
                    conn.Open();

                    sumaIngresos = Convert.ToString(suma.ExecuteScalar());

                    lblIngresos.Text = $"${sumaIngresos}";

                }

                cadena = "select sum(monto) as suma_gastos from Variables where tipo='Gasto';";

                using (SqlCommand suma = new SqlCommand(cadena, conn))
                {
                    

                    sumaGastos = Convert.ToString(suma.ExecuteScalar());

                    lblGastos.Text = $"${sumaGastos}";

                }

                lblSaldo.Text = $"${Convert.ToDouble(sumaIngresos)- Convert.ToDouble(sumaGastos)}";

            }

        }

        private void btnBurger_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            desplegar();
            
        }

        private void sideBar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        public void desplegar()
        {
            sideBar.Width = 94;
            btnConfig.Visible = true;
            btnUser.Visible = true;
            btnEditar.Visible = true;
            btnGraf.Visible = true;
        }

        public void plegar()
        {
            sideBar.Width = 47;
            btnConfig.Visible = false;
            btnUser.Visible = false;
            btnEditar.Visible = false;
            btnGraf.Visible = false;
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            desplegar();
        }

        private void btnGraf_MouseHover(object sender, EventArgs e)
        {
            desplegar();
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            desplegar();
        }

        private void btnConfig_MouseHover(object sender, EventArgs e)
        {
            desplegar();
        }

        private void VentanaPrincipal_MouseHover(object sender, EventArgs e)
        {
            plegar();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }
    }
}
