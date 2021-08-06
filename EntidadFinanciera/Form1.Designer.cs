namespace EntidadFinanciera
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
            this.grillaTitulares = new System.Windows.Forms.DataGridView();
            this.grillaTarjetas = new System.Windows.Forms.DataGridView();
            this.grillaTarjetasTitular = new System.Windows.Forms.DataGridView();
            this.btnAsignarTarjeta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaTitular = new System.Windows.Forms.Button();
            this.btnBajaTitular = new System.Windows.Forms.Button();
            this.btnModTitular = new System.Windows.Forms.Button();
            this.btnAltaTarjeta = new System.Windows.Forms.Button();
            this.btnBajaTarjeta = new System.Windows.Forms.Button();
            this.btnModTarjeta = new System.Windows.Forms.Button();
            this.textBoxNroDoc = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNroTarjeta = new System.Windows.Forms.TextBox();
            this.textBoxFechaOtorgamiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFechaVencimiento = new System.Windows.Forms.TextBox();
            this.btnLimpiarFormTitular = new System.Windows.Forms.Button();
            this.btnLimpiarFormTarjeta = new System.Windows.Forms.Button();
            this.btnQuitarAsignacionTarjeta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.btnGenerarConsumoARS = new System.Windows.Forms.Button();
            this.btnGenerarConsumoUSD = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRealizarPagoARS = new System.Windows.Forms.Button();
            this.btnRealizarPagoUSD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTitulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasTitular)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaTitulares
            // 
            this.grillaTitulares.AllowUserToAddRows = false;
            this.grillaTitulares.AllowUserToDeleteRows = false;
            this.grillaTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTitulares.Location = new System.Drawing.Point(35, 40);
            this.grillaTitulares.Margin = new System.Windows.Forms.Padding(2);
            this.grillaTitulares.Name = "grillaTitulares";
            this.grillaTitulares.ReadOnly = true;
            this.grillaTitulares.RowHeadersWidth = 49;
            this.grillaTitulares.RowTemplate.Height = 24;
            this.grillaTitulares.Size = new System.Drawing.Size(450, 200);
            this.grillaTitulares.TabIndex = 0;
            this.grillaTitulares.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTitulares_RowEnter);
            // 
            // grillaTarjetas
            // 
            this.grillaTarjetas.AllowUserToAddRows = false;
            this.grillaTarjetas.AllowUserToDeleteRows = false;
            this.grillaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetas.Location = new System.Drawing.Point(617, 40);
            this.grillaTarjetas.Margin = new System.Windows.Forms.Padding(2);
            this.grillaTarjetas.Name = "grillaTarjetas";
            this.grillaTarjetas.ReadOnly = true;
            this.grillaTarjetas.RowHeadersWidth = 49;
            this.grillaTarjetas.Size = new System.Drawing.Size(545, 200);
            this.grillaTarjetas.TabIndex = 1;
            this.grillaTarjetas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarjetas_RowEnter);
            // 
            // grillaTarjetasTitular
            // 
            this.grillaTarjetasTitular.AllowUserToAddRows = false;
            this.grillaTarjetasTitular.AllowUserToDeleteRows = false;
            this.grillaTarjetasTitular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetasTitular.Location = new System.Drawing.Point(35, 452);
            this.grillaTarjetasTitular.Margin = new System.Windows.Forms.Padding(2);
            this.grillaTarjetasTitular.Name = "grillaTarjetasTitular";
            this.grillaTarjetasTitular.ReadOnly = true;
            this.grillaTarjetasTitular.RowHeadersWidth = 49;
            this.grillaTarjetasTitular.Size = new System.Drawing.Size(818, 200);
            this.grillaTarjetasTitular.TabIndex = 2;
            // 
            // btnAsignarTarjeta
            // 
            this.btnAsignarTarjeta.Location = new System.Drawing.Point(512, 54);
            this.btnAsignarTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarTarjeta.Name = "btnAsignarTarjeta";
            this.btnAsignarTarjeta.Size = new System.Drawing.Size(82, 56);
            this.btnAsignarTarjeta.TabIndex = 3;
            this.btnAsignarTarjeta.Text = "Asignar Tarjeta";
            this.btnAsignarTarjeta.UseVisualStyleBackColor = true;
            this.btnAsignarTarjeta.Click += new System.EventHandler(this.btnAsignarTarjeta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TARJETAS ASIGNADAS A TITULAR";
            // 
            // btnAltaTitular
            // 
            this.btnAltaTitular.Location = new System.Drawing.Point(239, 256);
            this.btnAltaTitular.Name = "btnAltaTitular";
            this.btnAltaTitular.Size = new System.Drawing.Size(78, 23);
            this.btnAltaTitular.TabIndex = 6;
            this.btnAltaTitular.Text = "Alta";
            this.btnAltaTitular.UseVisualStyleBackColor = true;
            this.btnAltaTitular.Click += new System.EventHandler(this.btnAltaTitular_Click);
            // 
            // btnBajaTitular
            // 
            this.btnBajaTitular.Location = new System.Drawing.Point(323, 256);
            this.btnBajaTitular.Name = "btnBajaTitular";
            this.btnBajaTitular.Size = new System.Drawing.Size(78, 23);
            this.btnBajaTitular.TabIndex = 7;
            this.btnBajaTitular.Text = "Baja";
            this.btnBajaTitular.UseVisualStyleBackColor = true;
            this.btnBajaTitular.Click += new System.EventHandler(this.btnBajaTitular_Click);
            // 
            // btnModTitular
            // 
            this.btnModTitular.Location = new System.Drawing.Point(407, 256);
            this.btnModTitular.Name = "btnModTitular";
            this.btnModTitular.Size = new System.Drawing.Size(78, 23);
            this.btnModTitular.TabIndex = 8;
            this.btnModTitular.Text = "Modificación";
            this.btnModTitular.UseVisualStyleBackColor = true;
            this.btnModTitular.Click += new System.EventHandler(this.btnModTitular_Click);
            // 
            // btnAltaTarjeta
            // 
            this.btnAltaTarjeta.Location = new System.Drawing.Point(917, 256);
            this.btnAltaTarjeta.Name = "btnAltaTarjeta";
            this.btnAltaTarjeta.Size = new System.Drawing.Size(76, 23);
            this.btnAltaTarjeta.TabIndex = 9;
            this.btnAltaTarjeta.Text = "Alta";
            this.btnAltaTarjeta.UseVisualStyleBackColor = true;
            this.btnAltaTarjeta.Click += new System.EventHandler(this.btnAltaTarjeta_Click);
            // 
            // btnBajaTarjeta
            // 
            this.btnBajaTarjeta.Location = new System.Drawing.Point(1001, 256);
            this.btnBajaTarjeta.Name = "btnBajaTarjeta";
            this.btnBajaTarjeta.Size = new System.Drawing.Size(76, 23);
            this.btnBajaTarjeta.TabIndex = 10;
            this.btnBajaTarjeta.Text = "Baja";
            this.btnBajaTarjeta.UseVisualStyleBackColor = true;
            this.btnBajaTarjeta.Click += new System.EventHandler(this.btnBajaTarjeta_Click);
            // 
            // btnModTarjeta
            // 
            this.btnModTarjeta.Location = new System.Drawing.Point(1083, 256);
            this.btnModTarjeta.Name = "btnModTarjeta";
            this.btnModTarjeta.Size = new System.Drawing.Size(76, 23);
            this.btnModTarjeta.TabIndex = 11;
            this.btnModTarjeta.Text = "Modificación";
            this.btnModTarjeta.UseVisualStyleBackColor = true;
            this.btnModTarjeta.Click += new System.EventHandler(this.btnModTarjeta_Click);
            // 
            // textBoxNroDoc
            // 
            this.textBoxNroDoc.Location = new System.Drawing.Point(127, 284);
            this.textBoxNroDoc.Name = "textBoxNroDoc";
            this.textBoxNroDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroDoc.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(127, 310);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 12;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(127, 336);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido";
            // 
            // textBoxNroTarjeta
            // 
            this.textBoxNroTarjeta.Location = new System.Drawing.Point(727, 258);
            this.textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            this.textBoxNroTarjeta.Size = new System.Drawing.Size(136, 20);
            this.textBoxNroTarjeta.TabIndex = 12;
            // 
            // textBoxFechaOtorgamiento
            // 
            this.textBoxFechaOtorgamiento.Location = new System.Drawing.Point(727, 312);
            this.textBoxFechaOtorgamiento.Name = "textBoxFechaOtorgamiento";
            this.textBoxFechaOtorgamiento.Size = new System.Drawing.Size(136, 20);
            this.textBoxFechaOtorgamiento.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número de tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Otorgamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Vencimiento";
            // 
            // textBoxFechaVencimiento
            // 
            this.textBoxFechaVencimiento.Location = new System.Drawing.Point(727, 337);
            this.textBoxFechaVencimiento.Name = "textBoxFechaVencimiento";
            this.textBoxFechaVencimiento.Size = new System.Drawing.Size(136, 20);
            this.textBoxFechaVencimiento.TabIndex = 12;
            // 
            // btnLimpiarFormTitular
            // 
            this.btnLimpiarFormTitular.Location = new System.Drawing.Point(166, 362);
            this.btnLimpiarFormTitular.Name = "btnLimpiarFormTitular";
            this.btnLimpiarFormTitular.Size = new System.Drawing.Size(60, 30);
            this.btnLimpiarFormTitular.TabIndex = 6;
            this.btnLimpiarFormTitular.Text = "Limpiar";
            this.btnLimpiarFormTitular.UseVisualStyleBackColor = true;
            this.btnLimpiarFormTitular.Click += new System.EventHandler(this.btnLimpiarFormTitular_Click);
            // 
            // btnLimpiarFormTarjeta
            // 
            this.btnLimpiarFormTarjeta.Location = new System.Drawing.Point(803, 367);
            this.btnLimpiarFormTarjeta.Name = "btnLimpiarFormTarjeta";
            this.btnLimpiarFormTarjeta.Size = new System.Drawing.Size(60, 30);
            this.btnLimpiarFormTarjeta.TabIndex = 6;
            this.btnLimpiarFormTarjeta.Text = "Limpiar";
            this.btnLimpiarFormTarjeta.UseVisualStyleBackColor = true;
            this.btnLimpiarFormTarjeta.Click += new System.EventHandler(this.btnLimpiarFormTarjeta_Click);
            // 
            // btnQuitarAsignacionTarjeta
            // 
            this.btnQuitarAsignacionTarjeta.Location = new System.Drawing.Point(512, 133);
            this.btnQuitarAsignacionTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarAsignacionTarjeta.Name = "btnQuitarAsignacionTarjeta";
            this.btnQuitarAsignacionTarjeta.Size = new System.Drawing.Size(82, 56);
            this.btnQuitarAsignacionTarjeta.TabIndex = 14;
            this.btnQuitarAsignacionTarjeta.Text = "Quitar Asignación Tarjeta";
            this.btnQuitarAsignacionTarjeta.UseVisualStyleBackColor = true;
            this.btnQuitarAsignacionTarjeta.Click += new System.EventHandler(this.btnQuitarAsignacionTarjeta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tipo de documento";
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(127, 257);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoDoc.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(646, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tipo de tarjeta";
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(727, 284);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(136, 21);
            this.comboBoxTipoTarjeta.TabIndex = 15;
            // 
            // btnGenerarConsumoARS
            // 
            this.btnGenerarConsumoARS.Location = new System.Drawing.Point(903, 294);
            this.btnGenerarConsumoARS.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarConsumoARS.Name = "btnGenerarConsumoARS";
            this.btnGenerarConsumoARS.Size = new System.Drawing.Size(124, 39);
            this.btnGenerarConsumoARS.TabIndex = 3;
            this.btnGenerarConsumoARS.Text = "Generar Consumo $";
            this.btnGenerarConsumoARS.UseVisualStyleBackColor = true;
            this.btnGenerarConsumoARS.Click += new System.EventHandler(this.btnGenerarConsumoARS_Click);
            // 
            // btnGenerarConsumoUSD
            // 
            this.btnGenerarConsumoUSD.Location = new System.Drawing.Point(1035, 293);
            this.btnGenerarConsumoUSD.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarConsumoUSD.Name = "btnGenerarConsumoUSD";
            this.btnGenerarConsumoUSD.Size = new System.Drawing.Size(124, 39);
            this.btnGenerarConsumoUSD.TabIndex = 14;
            this.btnGenerarConsumoUSD.Text = "Generar Consumo U$S";
            this.btnGenerarConsumoUSD.UseVisualStyleBackColor = true;
            this.btnGenerarConsumoUSD.Click += new System.EventHandler(this.btnGenerarConsumoUSD_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "TITULARES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(612, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "TARJETAS";
            // 
            // btnRealizarPagoARS
            // 
            this.btnRealizarPagoARS.Location = new System.Drawing.Point(903, 342);
            this.btnRealizarPagoARS.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizarPagoARS.Name = "btnRealizarPagoARS";
            this.btnRealizarPagoARS.Size = new System.Drawing.Size(124, 39);
            this.btnRealizarPagoARS.TabIndex = 3;
            this.btnRealizarPagoARS.Text = "Realizar Pago $";
            this.btnRealizarPagoARS.UseVisualStyleBackColor = true;
            this.btnRealizarPagoARS.Click += new System.EventHandler(this.btnRealizarPagoARS_Click);
            // 
            // btnRealizarPagoUSD
            // 
            this.btnRealizarPagoUSD.Location = new System.Drawing.Point(1035, 342);
            this.btnRealizarPagoUSD.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizarPagoUSD.Name = "btnRealizarPagoUSD";
            this.btnRealizarPagoUSD.Size = new System.Drawing.Size(124, 39);
            this.btnRealizarPagoUSD.TabIndex = 14;
            this.btnRealizarPagoUSD.Text = "Realizar Pago U$S";
            this.btnRealizarPagoUSD.UseVisualStyleBackColor = true;
            this.btnRealizarPagoUSD.Click += new System.EventHandler(this.btnRealizarPagoUSD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.comboBoxTipoTarjeta);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.btnRealizarPagoUSD);
            this.Controls.Add(this.btnGenerarConsumoUSD);
            this.Controls.Add(this.btnQuitarAsignacionTarjeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFechaVencimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxFechaOtorgamiento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNroTarjeta);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNroDoc);
            this.Controls.Add(this.btnModTarjeta);
            this.Controls.Add(this.btnBajaTarjeta);
            this.Controls.Add(this.btnAltaTarjeta);
            this.Controls.Add(this.btnModTitular);
            this.Controls.Add(this.btnBajaTitular);
            this.Controls.Add(this.btnLimpiarFormTarjeta);
            this.Controls.Add(this.btnLimpiarFormTitular);
            this.Controls.Add(this.btnAltaTitular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRealizarPagoARS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarConsumoARS);
            this.Controls.Add(this.btnAsignarTarjeta);
            this.Controls.Add(this.grillaTarjetasTitular);
            this.Controls.Add(this.grillaTarjetas);
            this.Controls.Add(this.grillaTitulares);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTitulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasTitular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaTitulares;
        private System.Windows.Forms.DataGridView grillaTarjetas;
        private System.Windows.Forms.DataGridView grillaTarjetasTitular;
        private System.Windows.Forms.Button btnAsignarTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaTitular;
        private System.Windows.Forms.Button btnBajaTitular;
        private System.Windows.Forms.Button btnModTitular;
        private System.Windows.Forms.Button btnAltaTarjeta;
        private System.Windows.Forms.Button btnBajaTarjeta;
        private System.Windows.Forms.Button btnModTarjeta;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox textBoxNroDoc;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNroTarjeta;
        private System.Windows.Forms.TextBox textBoxFechaOtorgamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFechaVencimiento;
        private System.Windows.Forms.Button btnLimpiarFormTitular;
        private System.Windows.Forms.Button btnLimpiarFormTarjeta;
        private System.Windows.Forms.Button btnQuitarAsignacionTarjeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.Button btnGenerarConsumoARS;
        private System.Windows.Forms.Button btnGenerarConsumoUSD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRealizarPagoARS;
        private System.Windows.Forms.Button btnRealizarPagoUSD;
    }
}

