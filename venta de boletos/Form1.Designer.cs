namespace venta_de_boletos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Jornadas = new System.Windows.Forms.Label();
            this.label_Boletos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Comprar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Jornada = new System.Windows.Forms.ComboBox();
            this.textBox_Boletos = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Limpiar.ForeColor = System.Drawing.Color.White;
            this.button_Limpiar.Location = new System.Drawing.Point(220, 302);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 25;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Jornadas);
            this.groupBox1.Controls.Add(this.label_Boletos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_Nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_Precio);
            this.groupBox1.Location = new System.Drawing.Point(68, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label_Jornadas
            // 
            this.label_Jornadas.AutoSize = true;
            this.label_Jornadas.ForeColor = System.Drawing.Color.White;
            this.label_Jornadas.Location = new System.Drawing.Point(78, 98);
            this.label_Jornadas.Name = "label_Jornadas";
            this.label_Jornadas.Size = new System.Drawing.Size(14, 15);
            this.label_Jornadas.TabIndex = 11;
            this.label_Jornadas.Text = "0";
            // 
            // label_Boletos
            // 
            this.label_Boletos.AutoSize = true;
            this.label_Boletos.ForeColor = System.Drawing.Color.White;
            this.label_Boletos.Location = new System.Drawing.Point(78, 43);
            this.label_Boletos.Name = "label_Boletos";
            this.label_Boletos.Size = new System.Drawing.Size(14, 15);
            this.label_Boletos.TabIndex = 10;
            this.label_Boletos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Boletos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jornada:";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.Color.White;
            this.label_Nombre.Location = new System.Drawing.Point(78, 16);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(14, 15);
            this.label_Nombre.TabIndex = 6;
            this.label_Nombre.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio:";
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Precio.ForeColor = System.Drawing.Color.White;
            this.label_Precio.Location = new System.Drawing.Point(78, 69);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(15, 16);
            this.label_Precio.TabIndex = 4;
            this.label_Precio.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Venta de boletos";
            // 
            // button_Comprar
            // 
            this.button_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Comprar.ForeColor = System.Drawing.Color.White;
            this.button_Comprar.Location = new System.Drawing.Point(35, 302);
            this.button_Comprar.Name = "button_Comprar";
            this.button_Comprar.Size = new System.Drawing.Size(75, 23);
            this.button_Comprar.TabIndex = 14;
            this.button_Comprar.Text = "Comprar";
            this.button_Comprar.UseVisualStyleBackColor = true;
            this.button_Comprar.Click += new System.EventHandler(this.button_Comprar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Boletos";
            // 
            // comboBox_Jornada
            // 
            this.comboBox_Jornada.FormattingEnabled = true;
            this.comboBox_Jornada.Items.AddRange(new object[] {
            "Jornadas",
            "Dia",
            "Tarde ",
            "Noche"});
            this.comboBox_Jornada.Location = new System.Drawing.Point(118, 114);
            this.comboBox_Jornada.Name = "comboBox_Jornada";
            this.comboBox_Jornada.Size = new System.Drawing.Size(80, 21);
            this.comboBox_Jornada.TabIndex = 17;
            this.comboBox_Jornada.Text = "Jornadas";
            // 
            // textBox_Boletos
            // 
            this.textBox_Boletos.Location = new System.Drawing.Point(12, 114);
            this.textBox_Boletos.Name = "textBox_Boletos";
            this.textBox_Boletos.Size = new System.Drawing.Size(77, 20);
            this.textBox_Boletos.TabIndex = 16;
            this.textBox_Boletos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Boletos_KeyPress);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(79, 65);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(109, 20);
            this.textBox_Nombre.TabIndex = 22;
            this.textBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Cliente";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(234, 114);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(77, 20);
            this.textBox_Precio.TabIndex = 19;
            this.textBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Precio_KeyPress);
            // 
            // button_cerrar
            // 
            this.button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrar.ForeColor = System.Drawing.Color.White;
            this.button_cerrar.Location = new System.Drawing.Point(271, 13);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(40, 24);
            this.button_cerrar.TabIndex = 18;
            this.button_cerrar.Text = "X";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(323, 336);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Comprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Jornada);
            this.Controls.Add(this.textBox_Boletos);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.button_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Jornadas;
        private System.Windows.Forms.Label label_Boletos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Comprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Jornada;
        private System.Windows.Forms.TextBox textBox_Boletos;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button button_cerrar;
    }
}

