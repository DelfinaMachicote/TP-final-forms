
namespace WindowsFormsApp5_ESTE
{
    partial class Main
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.calcular_costos = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(377, 351);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(117, 59);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // calcular_costos
            // 
            this.calcular_costos.Location = new System.Drawing.Point(524, 351);
            this.calcular_costos.Name = "calcular_costos";
            this.calcular_costos.Size = new System.Drawing.Size(117, 59);
            this.calcular_costos.TabIndex = 1;
            this.calcular_costos.Text = "Calcular costos";
            this.calcular_costos.UseVisualStyleBackColor = true;
            this.calcular_costos.Click += new System.EventHandler(this.calcular_costos_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(684, 351);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(96, 58);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.calcular_costos);
            this.Controls.Add(this.Iniciar);
            this.Name = "Main";
            this.Text = "Cobertura de tablero de ajedrez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button calcular_costos;
        private System.Windows.Forms.Button Cerrar;
    }
}

