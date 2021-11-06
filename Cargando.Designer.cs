
namespace WindowsFormsApp5_ESTE
{
    partial class Cargando
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
            this.vueltas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vueltas
            // 
            this.vueltas.Location = new System.Drawing.Point(113, 55);
            this.vueltas.Multiline = true;
            this.vueltas.Name = "vueltas";
            this.vueltas.ReadOnly = true;
            this.vueltas.Size = new System.Drawing.Size(584, 338);
            this.vueltas.TabIndex = 0;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vueltas);
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vueltas;
    }
}