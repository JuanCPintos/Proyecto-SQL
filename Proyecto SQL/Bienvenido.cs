﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SQL
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            VentanaPrincipal Ingresar = new VentanaPrincipal();
            Ingresar.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
