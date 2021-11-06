
namespace WindowsFormsApp5_ESTE
{
    partial class Tablero
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
            this.Volver = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.TextBox();
            this.Siguiente_tablero = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(310, 376);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(164, 39);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(566, 376);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(164, 39);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // imprimir
            // 
            this.imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Location = new System.Drawing.Point(207, 58);
            this.imprimir.Multiline = true;
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Size = new System.Drawing.Size(382, 301);
            this.imprimir.TabIndex = 2;
            this.imprimir.TextChanged += new System.EventHandler(this.imprimir_TextChanged);
            // 
            // Siguiente_tablero
            // 
            this.Siguiente_tablero.Location = new System.Drawing.Point(53, 376);
            this.Siguiente_tablero.Name = "Siguiente_tablero";
            this.Siguiente_tablero.Size = new System.Drawing.Size(164, 39);
            this.Siguiente_tablero.TabIndex = 3;
            this.Siguiente_tablero.Text = "Siguiente tablero";
            this.Siguiente_tablero.UseVisualStyleBackColor = true;
            this.Siguiente_tablero.Click += new System.EventHandler(this.Siguiente_tablero_Click);
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(207, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Size = new System.Drawing.Size(382, 38);
            this.Titulo.TabIndex = 4;
            this.Titulo.TextChanged += new System.EventHandler(this.Titulo_TextChanged);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Siguiente_tablero);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Volver);
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.TextBox imprimir;
        private System.Windows.Forms.Button Siguiente_tablero;
        private System.Windows.Forms.TextBox Titulo;
    }
}