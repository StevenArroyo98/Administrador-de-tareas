namespace proyecto1
{
    partial class frmAdministradordetareas
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
            this.btnTareasporrealizar = new System.Windows.Forms.Button();
            this.btnTareasenprogreso = new System.Windows.Forms.Button();
            this.btnTareascompletadas = new System.Windows.Forms.Button();
            this.btnSaliarAdministradorTareas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoVerdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulAmarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareasporrealizar
            // 
            this.btnTareasporrealizar.BackColor = System.Drawing.Color.Silver;
            this.btnTareasporrealizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasporrealizar.Location = new System.Drawing.Point(165, 159);
            this.btnTareasporrealizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTareasporrealizar.Name = "btnTareasporrealizar";
            this.btnTareasporrealizar.Size = new System.Drawing.Size(414, 57);
            this.btnTareasporrealizar.TabIndex = 0;
            this.btnTareasporrealizar.Text = "Por Realizar";
            this.btnTareasporrealizar.UseVisualStyleBackColor = false;
            this.btnTareasporrealizar.Click += new System.EventHandler(this.btnTareasporrealizar_Click);
            // 
            // btnTareasenprogreso
            // 
            this.btnTareasenprogreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTareasenprogreso.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnTareasenprogreso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareasenprogreso.ForeColor = System.Drawing.Color.Red;
            this.btnTareasenprogreso.Location = new System.Drawing.Point(165, 224);
            this.btnTareasenprogreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnTareasenprogreso.Name = "btnTareasenprogreso";
            this.btnTareasenprogreso.Size = new System.Drawing.Size(414, 57);
            this.btnTareasenprogreso.TabIndex = 1;
            this.btnTareasenprogreso.Text = "En Progreso";
            this.btnTareasenprogreso.UseVisualStyleBackColor = false;
            this.btnTareasenprogreso.Click += new System.EventHandler(this.btnTareasenprogreso_Click);
            // 
            // btnTareascompletadas
            // 
            this.btnTareascompletadas.BackColor = System.Drawing.Color.Blue;
            this.btnTareascompletadas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTareascompletadas.FlatAppearance.BorderSize = 0;
            this.btnTareascompletadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareascompletadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTareascompletadas.Location = new System.Drawing.Point(165, 289);
            this.btnTareascompletadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTareascompletadas.Name = "btnTareascompletadas";
            this.btnTareascompletadas.Size = new System.Drawing.Size(414, 57);
            this.btnTareascompletadas.TabIndex = 2;
            this.btnTareascompletadas.Text = "Completadas";
            this.btnTareascompletadas.UseVisualStyleBackColor = false;
            this.btnTareascompletadas.Click += new System.EventHandler(this.btnTareascompletadas_Click);
            // 
            // btnSaliarAdministradorTareas
            // 
            this.btnSaliarAdministradorTareas.BackColor = System.Drawing.Color.Red;
            this.btnSaliarAdministradorTareas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSaliarAdministradorTareas.FlatAppearance.BorderSize = 0;
            this.btnSaliarAdministradorTareas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaliarAdministradorTareas.Location = new System.Drawing.Point(165, 386);
            this.btnSaliarAdministradorTareas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaliarAdministradorTareas.Name = "btnSaliarAdministradorTareas";
            this.btnSaliarAdministradorTareas.Size = new System.Drawing.Size(414, 57);
            this.btnSaliarAdministradorTareas.TabIndex = 3;
            this.btnSaliarAdministradorTareas.Text = "Salir";
            this.btnSaliarAdministradorTareas.UseVisualStyleBackColor = false;
            this.btnSaliarAdministradorTareas.Click += new System.EventHandler(this.btnSaliarAdministradorTareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de tareas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoVerdeToolStripMenuItem,
            this.azulAmarilloToolStripMenuItem,
            this.personalizadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // rojoVerdeToolStripMenuItem
            // 
            this.rojoVerdeToolStripMenuItem.Name = "rojoVerdeToolStripMenuItem";
            this.rojoVerdeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rojoVerdeToolStripMenuItem.Text = "Rojo-Verde";
            // 
            // azulAmarilloToolStripMenuItem
            // 
            this.azulAmarilloToolStripMenuItem.Name = "azulAmarilloToolStripMenuItem";
            this.azulAmarilloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.azulAmarilloToolStripMenuItem.Text = "Azul- Amarillo";
            this.azulAmarilloToolStripMenuItem.Click += new System.EventHandler(this.azulAmarilloToolStripMenuItem_Click);
            // 
            // personalizadosToolStripMenuItem
            // 
            this.personalizadosToolStripMenuItem.Name = "personalizadosToolStripMenuItem";
            this.personalizadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalizadosToolStripMenuItem.Text = "Personalizados";
            // 
            // frmAdministradordetareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaliarAdministradorTareas);
            this.Controls.Add(this.btnTareascompletadas);
            this.Controls.Add(this.btnTareasenprogreso);
            this.Controls.Add(this.btnTareasporrealizar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdministradordetareas";
            this.Text = "Administrador De Tareas";
            this.Load += new System.EventHandler(this.frmAdministradordetareas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTareasporrealizar;
        private System.Windows.Forms.Button btnTareasenprogreso;
        private System.Windows.Forms.Button btnTareascompletadas;
        private System.Windows.Forms.Button btnSaliarAdministradorTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoVerdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulAmarilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

