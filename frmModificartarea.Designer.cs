namespace proyecto1
{
    partial class frmModificartarea
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbxNombretarea = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.rbnTareaporrealizar = new System.Windows.Forms.RadioButton();
            this.rbnTareaproceso = new System.Windows.Forms.RadioButton();
            this.rbnTareacompletada = new System.Windows.Forms.RadioButton();
            this.btnGuardarcambios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtFechaentrega = new System.Windows.Forms.DateTimePicker();
            this.lblIdTarea = new System.Windows.Forms.Label();
            this.tbxIdtarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(375, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 19);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // tbxNombretarea
            // 
            this.tbxNombretarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxNombretarea.Location = new System.Drawing.Point(141, 56);
            this.tbxNombretarea.Name = "tbxNombretarea";
            this.tbxNombretarea.Size = new System.Drawing.Size(220, 20);
            this.tbxNombretarea.TabIndex = 4;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(141, 149);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(396, 123);
            this.tbxDescripcion.TabIndex = 5;
            // 
            // rbnTareaporrealizar
            // 
            this.rbnTareaporrealizar.AutoSize = true;
            this.rbnTareaporrealizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTareaporrealizar.Location = new System.Drawing.Point(378, 53);
            this.rbnTareaporrealizar.Name = "rbnTareaporrealizar";
            this.rbnTareaporrealizar.Size = new System.Drawing.Size(159, 23);
            this.rbnTareaporrealizar.TabIndex = 6;
            this.rbnTareaporrealizar.TabStop = true;
            this.rbnTareaporrealizar.Text = "Tarea por realizar";
            this.rbnTareaporrealizar.UseVisualStyleBackColor = true;
            // 
            // rbnTareaproceso
            // 
            this.rbnTareaproceso.AutoSize = true;
            this.rbnTareaproceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTareaproceso.Location = new System.Drawing.Point(378, 88);
            this.rbnTareaproceso.Name = "rbnTareaproceso";
            this.rbnTareaproceso.Size = new System.Drawing.Size(159, 23);
            this.rbnTareaproceso.TabIndex = 7;
            this.rbnTareaproceso.TabStop = true;
            this.rbnTareaproceso.Text = "Tarea en proceso";
            this.rbnTareaproceso.UseVisualStyleBackColor = true;
            // 
            // rbnTareacompletada
            // 
            this.rbnTareacompletada.AutoSize = true;
            this.rbnTareacompletada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTareacompletada.Location = new System.Drawing.Point(378, 121);
            this.rbnTareacompletada.Name = "rbnTareacompletada";
            this.rbnTareacompletada.Size = new System.Drawing.Size(162, 23);
            this.rbnTareacompletada.TabIndex = 8;
            this.rbnTareacompletada.TabStop = true;
            this.rbnTareacompletada.Text = "Tarea completada";
            this.rbnTareacompletada.UseVisualStyleBackColor = true;
            // 
            // btnGuardarcambios
            // 
            this.btnGuardarcambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarcambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarcambios.Location = new System.Drawing.Point(193, 298);
            this.btnGuardarcambios.Name = "btnGuardarcambios";
            this.btnGuardarcambios.Size = new System.Drawing.Size(127, 34);
            this.btnGuardarcambios.TabIndex = 9;
            this.btnGuardarcambios.Text = "Guardar";
            this.btnGuardarcambios.UseVisualStyleBackColor = false;
            this.btnGuardarcambios.Click += new System.EventHandler(this.btnGuardarcambios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(350, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(15, 104);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(120, 19);
            this.lblFechaEntrega.TabIndex = 11;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // dtFechaentrega
            // 
            this.dtFechaentrega.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtFechaentrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaentrega.Location = new System.Drawing.Point(141, 104);
            this.dtFechaentrega.Name = "dtFechaentrega";
            this.dtFechaentrega.Size = new System.Drawing.Size(220, 26);
            this.dtFechaentrega.TabIndex = 12;
            // 
            // lblIdTarea
            // 
            this.lblIdTarea.AutoSize = true;
            this.lblIdTarea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTarea.Location = new System.Drawing.Point(12, 9);
            this.lblIdTarea.Name = "lblIdTarea";
            this.lblIdTarea.Size = new System.Drawing.Size(65, 19);
            this.lblIdTarea.TabIndex = 14;
            this.lblIdTarea.Text = "idTarea";
            this.lblIdTarea.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxIdtarea
            // 
            this.tbxIdtarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxIdtarea.Enabled = false;
            this.tbxIdtarea.Location = new System.Drawing.Point(141, 12);
            this.tbxIdtarea.Name = "tbxIdtarea";
            this.tbxIdtarea.Size = new System.Drawing.Size(220, 20);
            this.tbxIdtarea.TabIndex = 15;
            // 
            // frmModificartarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 359);
            this.Controls.Add(this.tbxIdtarea);
            this.Controls.Add(this.lblIdTarea);
            this.Controls.Add(this.dtFechaentrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarcambios);
            this.Controls.Add(this.rbnTareacompletada);
            this.Controls.Add(this.rbnTareaproceso);
            this.Controls.Add(this.rbnTareaporrealizar);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombretarea);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmModificartarea";
            this.Text = "Modificar Tarea";
            this.Load += new System.EventHandler(this.frmModificartarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbxNombretarea;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.RadioButton rbnTareaporrealizar;
        private System.Windows.Forms.RadioButton rbnTareaproceso;
        private System.Windows.Forms.RadioButton rbnTareacompletada;
        private System.Windows.Forms.Button btnGuardarcambios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtFechaentrega;
        private System.Windows.Forms.Label lblIdTarea;
        private System.Windows.Forms.TextBox tbxIdtarea;
    }
}