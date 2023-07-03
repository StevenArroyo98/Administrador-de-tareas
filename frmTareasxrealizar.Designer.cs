namespace proyecto1
{
    partial class frmTareasxrealizar
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
            this.lstbTareasporrealizar = new System.Windows.Forms.ListBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnModificartarea = new System.Windows.Forms.Button();
            this.btnBorrarTarea = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxEstado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.tbxFechaentrega = new System.Windows.Forms.TextBox();
            this.lblNumeroTarea = new System.Windows.Forms.Label();
            this.tbxIdtarea = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbTareasporrealizar
            // 
            this.lstbTareasporrealizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbTareasporrealizar.FormattingEnabled = true;
            this.lstbTareasporrealizar.Location = new System.Drawing.Point(41, 37);
            this.lstbTareasporrealizar.Name = "lstbTareasporrealizar";
            this.lstbTareasporrealizar.Size = new System.Drawing.Size(527, 134);
            this.lstbTareasporrealizar.TabIndex = 0;
            this.lstbTareasporrealizar.SelectedIndexChanged += new System.EventHandler(this.lstbTareasporrealizar_SelectedIndexChanged);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarTarea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(41, 350);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(158, 30);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnModificartarea
            // 
            this.btnModificartarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificartarea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificartarea.Location = new System.Drawing.Point(227, 350);
            this.btnModificartarea.Name = "btnModificartarea";
            this.btnModificartarea.Size = new System.Drawing.Size(150, 30);
            this.btnModificartarea.TabIndex = 2;
            this.btnModificartarea.Text = "Modificar Tarea";
            this.btnModificartarea.UseVisualStyleBackColor = false;
            this.btnModificartarea.Click += new System.EventHandler(this.btnModificartarea_Click);
            // 
            // btnBorrarTarea
            // 
            this.btnBorrarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBorrarTarea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTarea.Location = new System.Drawing.Point(402, 350);
            this.btnBorrarTarea.Name = "btnBorrarTarea";
            this.btnBorrarTarea.Size = new System.Drawing.Size(150, 30);
            this.btnBorrarTarea.TabIndex = 3;
            this.btnBorrarTarea.Text = "Borrar Tarea";
            this.btnBorrarTarea.UseVisualStyleBackColor = false;
            this.btnBorrarTarea.Click += new System.EventHandler(this.btnBorrarTarea_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Location = new System.Drawing.Point(129, 209);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(125, 20);
            this.tbxNombre.TabIndex = 4;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Enabled = false;
            this.tbxDescripcion.Location = new System.Drawing.Point(378, 251);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(190, 65);
            this.tbxDescripcion.TabIndex = 5;
            // 
            // tbxEstado
            // 
            this.tbxEstado.Enabled = false;
            this.tbxEstado.Location = new System.Drawing.Point(129, 254);
            this.tbxEstado.Name = "tbxEstado";
            this.tbxEstado.Size = new System.Drawing.Size(125, 20);
            this.tbxEstado.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 209);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(38, 254);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(282, 261);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(41, 299);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(77, 13);
            this.lblFechaEntrega.TabIndex = 10;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // tbxFechaentrega
            // 
            this.tbxFechaentrega.Enabled = false;
            this.tbxFechaentrega.Location = new System.Drawing.Point(129, 296);
            this.tbxFechaentrega.Name = "tbxFechaentrega";
            this.tbxFechaentrega.Size = new System.Drawing.Size(125, 20);
            this.tbxFechaentrega.TabIndex = 11;
            // 
            // lblNumeroTarea
            // 
            this.lblNumeroTarea.AutoSize = true;
            this.lblNumeroTarea.Location = new System.Drawing.Point(282, 200);
            this.lblNumeroTarea.Name = "lblNumeroTarea";
            this.lblNumeroTarea.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroTarea.TabIndex = 12;
            this.lblNumeroTarea.Text = "Numero de tarea";
            // 
            // tbxIdtarea
            // 
            this.tbxIdtarea.Enabled = false;
            this.tbxIdtarea.Location = new System.Drawing.Point(378, 202);
            this.tbxIdtarea.Name = "tbxIdtarea";
            this.tbxIdtarea.Size = new System.Drawing.Size(100, 20);
            this.tbxIdtarea.TabIndex = 13;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(3, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(46, 31);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "<";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmTareasxrealizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 389);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbxIdtarea);
            this.Controls.Add(this.lblNumeroTarea);
            this.Controls.Add(this.tbxFechaentrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxEstado);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.btnBorrarTarea);
            this.Controls.Add(this.btnModificartarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.lstbTareasporrealizar);
            this.Name = "frmTareasxrealizar";
            this.Text = "Tareas Por Realizar";
            this.Load += new System.EventHandler(this.frmTareasxrealizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbTareasporrealizar;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnModificartarea;
        private System.Windows.Forms.Button btnBorrarTarea;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox tbxFechaentrega;
        private System.Windows.Forms.Label lblNumeroTarea;
        private System.Windows.Forms.TextBox tbxIdtarea;
        private System.Windows.Forms.Button btnVolver;
    }
}