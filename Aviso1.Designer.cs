
namespace WindowsFormsApp5_ESTE
{
    partial class Aviso1
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
            this.aviso = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aviso
            // 
            this.aviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviso.ForeColor = System.Drawing.SystemColors.Control;
            this.aviso.Location = new System.Drawing.Point(12, 66);
            this.aviso.Multiline = true;
            this.aviso.Name = "aviso";
            this.aviso.ReadOnly = true;
            this.aviso.Size = new System.Drawing.Size(447, 134);
            this.aviso.TabIndex = 0;
            this.aviso.TextChanged += new System.EventHandler(this.aviso_TextChanged);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(186, 246);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(126, 33);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(344, 246);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(126, 33);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Aviso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.aviso);
            this.Name = "Aviso1";
            this.Text = "Aviso1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aviso;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Cerrar;
    }
}