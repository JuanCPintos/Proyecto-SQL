namespace Proyecto_SQL
{
    partial class Editar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMonto = new Proyecto_SQL.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pickerFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtGasto = new System.Windows.Forms.RadioButton();
            this.rbtIngreso = new System.Windows.Forms.RadioButton();
            this.txtDetalle = new Proyecto_SQL.RJTextBox();
            this.txtId = new Proyecto_SQL.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new Proyecto_SQL.NewButton();
            this.btnActualizar = new Proyecto_SQL.NewButton();
            this.btnEliminar = new Proyecto_SQL.NewButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Window;
            this.txtMonto.BorderColor = System.Drawing.SystemColors.Window;
            this.txtMonto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.txtMonto.BorderRadius = 15;
            this.txtMonto.BorderSize = 2;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Black;
            this.txtMonto.Location = new System.Drawing.Point(525, 127);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(7);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.Size = new System.Drawing.Size(257, 36);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Detalle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monto:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Otro",
            "Alquiler",
            "Servicio",
            "Alimento",
            "Ocio"});
            this.cmbCategoria.Location = new System.Drawing.Point(567, 256);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(227, 29);
            this.cmbCategoria.TabIndex = 17;
            this.cmbCategoria.Text = "Otro";
            // 
            // pickerFecha
            // 
            this.pickerFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerFecha.CustomFormat = "dd/MM/yyyy";
            this.pickerFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerFecha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pickerFecha.Location = new System.Drawing.Point(566, 311);
            this.pickerFecha.Name = "pickerFecha";
            this.pickerFecha.Size = new System.Drawing.Size(228, 28);
            this.pickerFecha.TabIndex = 16;
            this.pickerFecha.Value = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGasto);
            this.groupBox1.Controls.Add(this.rbtIngreso);
            this.groupBox1.Location = new System.Drawing.Point(487, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 61);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbtGasto
            // 
            this.rbtGasto.AutoSize = true;
            this.rbtGasto.Checked = true;
            this.rbtGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtGasto.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGasto.Location = new System.Drawing.Point(187, 19);
            this.rbtGasto.Name = "rbtGasto";
            this.rbtGasto.Size = new System.Drawing.Size(82, 25);
            this.rbtGasto.TabIndex = 1;
            this.rbtGasto.TabStop = true;
            this.rbtGasto.Text = "Gasto";
            this.rbtGasto.UseVisualStyleBackColor = true;
            // 
            // rbtIngreso
            // 
            this.rbtIngreso.AutoSize = true;
            this.rbtIngreso.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtIngreso.Location = new System.Drawing.Point(38, 19);
            this.rbtIngreso.Name = "rbtIngreso";
            this.rbtIngreso.Size = new System.Drawing.Size(92, 25);
            this.rbtIngreso.TabIndex = 0;
            this.rbtIngreso.Text = "Ingreso";
            this.rbtIngreso.UseVisualStyleBackColor = true;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetalle.BorderColor = System.Drawing.SystemColors.Window;
            this.txtDetalle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.txtDetalle.BorderRadius = 15;
            this.txtDetalle.BorderSize = 2;
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.Black;
            this.txtDetalle.Location = new System.Drawing.Point(533, 362);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Multiline = false;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Padding = new System.Windows.Forms.Padding(7);
            this.txtDetalle.PasswordChar = false;
            this.txtDetalle.Size = new System.Drawing.Size(262, 36);
            this.txtDetalle.TabIndex = 14;
            this.txtDetalle.Texts = "";
            this.txtDetalle.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.txtId.BorderRadius = 15;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(525, 22);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(262, 36);
            this.txtId.TabIndex = 19;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 40;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(417, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(365, 41);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(417, 405);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(246, 41);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(241)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(241)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnEliminar.Location = new System.Drawing.Point(669, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 40);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pickerFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJTextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DateTimePicker pickerFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtGasto;
        private System.Windows.Forms.RadioButton rbtIngreso;
        private RJTextBox txtDetalle;
        private RJTextBox txtId;
        private System.Windows.Forms.Label label6;
        private NewButton btnBuscar;
        private NewButton btnActualizar;
        private NewButton btnEliminar;
    }
}