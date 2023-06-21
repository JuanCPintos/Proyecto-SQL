namespace Proyecto_SQL
{
    partial class VentanaPrincipal
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnGraf = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new Proyecto_SQL.NewButton();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo Total";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.Window;
            this.lblSaldo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(345, 94);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(82, 32);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "$0.00";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.BackColor = System.Drawing.SystemColors.Window;
            this.lblIngresos.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(190, 217);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(82, 32);
            this.lblIngresos.TabIndex = 7;
            this.lblIngresos.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresos";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.BackColor = System.Drawing.SystemColors.Window;
            this.lblGastos.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(502, 217);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(82, 32);
            this.lblGastos.TabIndex = 9;
            this.lblGastos.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gastos";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.sideBar.Controls.Add(this.btnEditar);
            this.sideBar.Controls.Add(this.btnUser);
            this.sideBar.Controls.Add(this.btnConfig);
            this.sideBar.Controls.Add(this.btnBurger);
            this.sideBar.Controls.Add(this.btnGraf);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(47, 450);
            this.sideBar.TabIndex = 13;
            this.sideBar.MouseLeave += new System.EventHandler(this.sideBar_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnEditar.Image = global::Proyecto_SQL.Properties.Resources.bx_edit_alt_1;
            this.btnEditar.Location = new System.Drawing.Point(25, 146);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 47);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseHover += new System.EventHandler(this.btnEditar_MouseHover);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnConfig.Image = global::Proyecto_SQL.Properties.Resources.Gear;
            this.btnConfig.Location = new System.Drawing.Point(25, 393);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(43, 47);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Visible = false;
            this.btnConfig.MouseHover += new System.EventHandler(this.btnConfig_MouseHover);
            // 
            // btnBurger
            // 
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnBurger.Image = global::Proyecto_SQL.Properties.Resources.VectorBurger;
            this.btnBurger.Location = new System.Drawing.Point(3, 3);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(43, 37);
            this.btnBurger.TabIndex = 11;
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            this.btnBurger.MouseHover += new System.EventHandler(this.btnBurger_MouseHover);
            // 
            // btnGraf
            // 
            this.btnGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnGraf.Image = global::Proyecto_SQL.Properties.Resources.bx_line_chart_1;
            this.btnGraf.Location = new System.Drawing.Point(26, 231);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(43, 47);
            this.btnGraf.TabIndex = 14;
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Visible = false;
            this.btnGraf.MouseHover += new System.EventHandler(this.btnGraf_MouseHover);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnUser.Image = global::Proyecto_SQL.Properties.Resources.bxs_id_card_1;
            this.btnUser.Location = new System.Drawing.Point(24, 320);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(43, 47);
            this.btnUser.TabIndex = 13;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseHover += new System.EventHandler(this.btnUser_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_SQL.Properties.Resources.Rectangle_9;
            this.pictureBox3.Location = new System.Drawing.Point(423, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_SQL.Properties.Resources.Rectangle_9;
            this.pictureBox2.Location = new System.Drawing.Point(118, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_SQL.Properties.Resources.Rectangle_8__1_;
            this.pictureBox1.Location = new System.Drawing.Point(118, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Proyecto_SQL.Properties.Resources.Vector;
            this.btnAgregar.Location = new System.Drawing.Point(327, 295);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 123);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.MouseHover += new System.EventHandler(this.VentanaPrincipal_MouseHover);
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewButton btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnGraf;
        private System.Windows.Forms.Button btnUser;
    }
}