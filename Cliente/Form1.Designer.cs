namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstadoTrajeMadre = new System.Windows.Forms.Label();
            this.lblConexionPrimaria = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEstadoProcesador = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVelocidadProcesador = new System.Windows.Forms.Label();
            this.lblAnchoProcesador = new System.Windows.Forms.Label();
            this.lblNombreProcesador = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblNombreBios = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPrimariaSO = new System.Windows.Forms.Label();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.lblSistemaOperativo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTemperaturaActual = new System.Windows.Forms.Label();
            this.lblEstadoTemp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbxDiscoDuro = new System.Windows.Forms.ListBox();
            this.btnServidor2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(716, 27);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarMensaje.TabIndex = 1;
            this.btnEnviarMensaje.Text = "Servidor 1";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(817, 16);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(375, 622);
            this.txtResultado.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(85, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "..";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(85, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(13, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstadoTrajeMadre);
            this.groupBox2.Controls.Add(this.lblConexionPrimaria);
            this.groupBox2.Controls.Add(this.lblIdProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(23, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 115);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tarjeta Madre";
            // 
            // lblEstadoTrajeMadre
            // 
            this.lblEstadoTrajeMadre.AutoSize = true;
            this.lblEstadoTrajeMadre.Location = new System.Drawing.Point(147, 88);
            this.lblEstadoTrajeMadre.Name = "lblEstadoTrajeMadre";
            this.lblEstadoTrajeMadre.Size = new System.Drawing.Size(13, 13);
            this.lblEstadoTrajeMadre.TabIndex = 7;
            this.lblEstadoTrajeMadre.Text = "..";
            // 
            // lblConexionPrimaria
            // 
            this.lblConexionPrimaria.AutoSize = true;
            this.lblConexionPrimaria.Location = new System.Drawing.Point(147, 61);
            this.lblConexionPrimaria.Name = "lblConexionPrimaria";
            this.lblConexionPrimaria.Size = new System.Drawing.Size(13, 13);
            this.lblConexionPrimaria.TabIndex = 6;
            this.lblConexionPrimaria.Text = "..";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(147, 32);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(13, 13);
            this.lblIdProducto.TabIndex = 5;
            this.lblIdProducto.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Conexion Primaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID del Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEstadoProcesador);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblVelocidadProcesador);
            this.groupBox3.Controls.Add(this.lblAnchoProcesador);
            this.groupBox3.Controls.Add(this.lblNombreProcesador);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(23, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 140);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesador";
            // 
            // lblEstadoProcesador
            // 
            this.lblEstadoProcesador.AutoSize = true;
            this.lblEstadoProcesador.Location = new System.Drawing.Point(133, 108);
            this.lblEstadoProcesador.Name = "lblEstadoProcesador";
            this.lblEstadoProcesador.Size = new System.Drawing.Size(13, 13);
            this.lblEstadoProcesador.TabIndex = 15;
            this.lblEstadoProcesador.Text = "..";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Estado";
            // 
            // lblVelocidadProcesador
            // 
            this.lblVelocidadProcesador.AutoSize = true;
            this.lblVelocidadProcesador.Location = new System.Drawing.Point(133, 82);
            this.lblVelocidadProcesador.Name = "lblVelocidadProcesador";
            this.lblVelocidadProcesador.Size = new System.Drawing.Size(13, 13);
            this.lblVelocidadProcesador.TabIndex = 13;
            this.lblVelocidadProcesador.Text = "..";
            // 
            // lblAnchoProcesador
            // 
            this.lblAnchoProcesador.AutoSize = true;
            this.lblAnchoProcesador.Location = new System.Drawing.Point(133, 55);
            this.lblAnchoProcesador.Name = "lblAnchoProcesador";
            this.lblAnchoProcesador.Size = new System.Drawing.Size(13, 13);
            this.lblAnchoProcesador.TabIndex = 12;
            this.lblAnchoProcesador.Text = "..";
            // 
            // lblNombreProcesador
            // 
            this.lblNombreProcesador.AutoSize = true;
            this.lblNombreProcesador.Location = new System.Drawing.Point(133, 26);
            this.lblNombreProcesador.Name = "lblNombreProcesador";
            this.lblNombreProcesador.Size = new System.Drawing.Size(13, 13);
            this.lblNombreProcesador.TabIndex = 11;
            this.lblNombreProcesador.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Velocidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ancho";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nombre del producto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblVersion);
            this.groupBox4.Controls.Add(this.lblNombreBios);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(23, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 83);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bios";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(133, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(13, 13);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "..";
            // 
            // lblNombreBios
            // 
            this.lblNombreBios.AutoSize = true;
            this.lblNombreBios.Location = new System.Drawing.Point(133, 25);
            this.lblNombreBios.Name = "lblNombreBios";
            this.lblNombreBios.Size = new System.Drawing.Size(13, 13);
            this.lblNombreBios.TabIndex = 15;
            this.lblNombreBios.Text = "..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Version";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Bios";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPrimariaSO);
            this.groupBox5.Controls.Add(this.lblOrganizacion);
            this.groupBox5.Controls.Add(this.lblSistemaOperativo);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(23, 519);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 111);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sistema Operativo";
            // 
            // lblPrimariaSO
            // 
            this.lblPrimariaSO.AutoSize = true;
            this.lblPrimariaSO.Location = new System.Drawing.Point(132, 81);
            this.lblPrimariaSO.Name = "lblPrimariaSO";
            this.lblPrimariaSO.Size = new System.Drawing.Size(13, 13);
            this.lblPrimariaSO.TabIndex = 19;
            this.lblPrimariaSO.Text = "..";
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Location = new System.Drawing.Point(132, 54);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(13, 13);
            this.lblOrganizacion.TabIndex = 18;
            this.lblOrganizacion.Text = "..";
            // 
            // lblSistemaOperativo
            // 
            this.lblSistemaOperativo.AutoSize = true;
            this.lblSistemaOperativo.Location = new System.Drawing.Point(132, 25);
            this.lblSistemaOperativo.Name = "lblSistemaOperativo";
            this.lblSistemaOperativo.Size = new System.Drawing.Size(13, 13);
            this.lblSistemaOperativo.TabIndex = 17;
            this.lblSistemaOperativo.Text = "..";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Primaria";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Organizacion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Sistema Operativo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTemperaturaActual);
            this.groupBox6.Controls.Add(this.lblEstadoTemp);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(371, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 76);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Temperatura";
            // 
            // lblTemperaturaActual
            // 
            this.lblTemperaturaActual.AutoSize = true;
            this.lblTemperaturaActual.Location = new System.Drawing.Point(115, 54);
            this.lblTemperaturaActual.Name = "lblTemperaturaActual";
            this.lblTemperaturaActual.Size = new System.Drawing.Size(13, 13);
            this.lblTemperaturaActual.TabIndex = 9;
            this.lblTemperaturaActual.Text = "..";
            // 
            // lblEstadoTemp
            // 
            this.lblEstadoTemp.AutoSize = true;
            this.lblEstadoTemp.Location = new System.Drawing.Point(115, 29);
            this.lblEstadoTemp.Name = "lblEstadoTemp";
            this.lblEstadoTemp.Size = new System.Drawing.Size(13, 13);
            this.lblEstadoTemp.TabIndex = 8;
            this.lblEstadoTemp.Text = "..";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Temperatura";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Estado del Producto";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbxDiscoDuro);
            this.groupBox7.Location = new System.Drawing.Point(371, 121);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 355);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Disco Duro";
            // 
            // lbxDiscoDuro
            // 
            this.lbxDiscoDuro.FormattingEnabled = true;
            this.lbxDiscoDuro.Location = new System.Drawing.Point(21, 36);
            this.lbxDiscoDuro.Name = "lbxDiscoDuro";
            this.lbxDiscoDuro.Size = new System.Drawing.Size(287, 290);
            this.lbxDiscoDuro.TabIndex = 0;
            // 
            // btnServidor2
            // 
            this.btnServidor2.Location = new System.Drawing.Point(716, 57);
            this.btnServidor2.Name = "btnServidor2";
            this.btnServidor2.Size = new System.Drawing.Size(75, 23);
            this.btnServidor2.TabIndex = 10;
            this.btnServidor2.Text = "Servidor 2";
            this.btnServidor2.UseVisualStyleBackColor = true;
            this.btnServidor2.Click += new System.EventHandler(this.btnServidor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 732);
            this.Controls.Add(this.btnServidor2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEstadoTrajeMadre;
        private System.Windows.Forms.Label lblConexionPrimaria;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEstadoProcesador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblVelocidadProcesador;
        private System.Windows.Forms.Label lblAnchoProcesador;
        private System.Windows.Forms.Label lblNombreProcesador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblNombreBios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblPrimariaSO;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.Label lblSistemaOperativo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTemperaturaActual;
        private System.Windows.Forms.Label lblEstadoTemp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbxDiscoDuro;
        private System.Windows.Forms.Button btnServidor2;
    }
}

