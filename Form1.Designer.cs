
namespace guia4ejer3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstTablaMultiplicar = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Tabla";
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(67, 63);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(150, 36);
            this.btnMostrarTabla.TabIndex = 1;
            this.btnMostrarTabla.Text = "Mostrar Tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(130, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // lstTablaMultiplicar
            // 
            this.lstTablaMultiplicar.HideSelection = false;
            this.lstTablaMultiplicar.Location = new System.Drawing.Point(116, 136);
            this.lstTablaMultiplicar.Name = "lstTablaMultiplicar";
            this.lstTablaMultiplicar.Size = new System.Drawing.Size(324, 251);
            this.lstTablaMultiplicar.TabIndex = 3;
            this.lstTablaMultiplicar.UseCompatibleStateImageBehavior = false;
            this.lstTablaMultiplicar.View = System.Windows.Forms.View.List;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(324, 63);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstTablaMultiplicar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTabla;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListView lstTablaMultiplicar;
        private System.Windows.Forms.Button btnSalir;
    }
}

