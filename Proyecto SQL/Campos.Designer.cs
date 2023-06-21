namespace Proyecto_SQL
{
    partial class Campos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtGasto = new System.Windows.Forms.RadioButton();
            this.rbtIngreso = new System.Windows.Forms.RadioButton();
            this.pickerFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new Proyecto_SQL.NewButton();
            this.btnGuardar = new Proyecto_SQL.NewButton();
            this.txtDetalle = new Proyecto_SQL.RJTextBox();
            this.txtMonto = new Proyecto_SQL.RJTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGasto);
            this.groupBox1.Controls.Add(this.rbtIngreso);
            this.groupBox1.Location = new System.Drawing.Point(243, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rbtGasto
            // 
            this.rbtGasto.AutoSize = true;
            this.rbtGasto.Checked = true;
            this.rbtGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtGasto.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGasto.Location = new System.Drawing.Point(211, 19);
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
            this.rbtIngreso.Location = new System.Drawing.Point(48, 19);
            this.rbtIngreso.Name = "rbtIngreso";
            this.rbtIngreso.Size = new System.Drawing.Size(92, 25);
            this.rbtIngreso.TabIndex = 0;
            this.rbtIngreso.Text = "Ingreso";
            this.rbtIngreso.UseVisualStyleBackColor = true;
            // 
            // pickerFecha
            // 
            this.pickerFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerFecha.CustomFormat = "dd/MM/yyyy";
            this.pickerFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerFecha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pickerFecha.Location = new System.Drawing.Point(243, 188);
            this.pickerFecha.Name = "pickerFecha";
            this.pickerFecha.Size = new System.Drawing.Size(339, 28);
            this.pickerFecha.TabIndex = 12;
            this.pickerFecha.Value = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
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
            this.cmbCategoria.Location = new System.Drawing.Point(243, 133);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(339, 29);
            this.cmbCategoria.TabIndex = 13;
            this.cmbCategoria.Text = "Otro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(241)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(241)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnCancelar.Location = new System.Drawing.Point(491, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 40;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(291, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(194, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtDetalle.Location = new System.Drawing.Point(243, 239);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Multiline = false;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Padding = new System.Windows.Forms.Padding(7);
            this.txtDetalle.PasswordChar = false;
            this.txtDetalle.Size = new System.Drawing.Size(340, 36);
            this.txtDetalle.TabIndex = 7;
            this.txtDetalle.Texts = "";
            this.txtDetalle.UnderlinedStyle = false;
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
            this.txtMonto.Location = new System.Drawing.Point(243, 8);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(7);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.Size = new System.Drawing.Size(340, 36);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = false;
            // 
            // Campos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(600, 357);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pickerFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Campos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJTextBox txtMonto;
        private RJTextBox txtDetalle;
        private NewButton btnGuardar;
        private NewButton btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtGasto;
        private System.Windows.Forms.RadioButton rbtIngreso;
        private System.Windows.Forms.DateTimePicker pickerFecha;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}