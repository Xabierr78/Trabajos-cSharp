namespace CastingNumeros
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
            this.labelEntero = new System.Windows.Forms.Label();
            this.labelReal = new System.Windows.Forms.Label();
            this.labelResultadoDoble = new System.Windows.Forms.Label();
            this.labelResultadoMitad = new System.Windows.Forms.Label();
            this.btnEntero = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxEntero = new System.Windows.Forms.TextBox();
            this.textBoxReal = new System.Windows.Forms.TextBox();
            this.textBoxDoble = new System.Windows.Forms.TextBox();
            this.textBoxMitad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEntero
            // 
            this.labelEntero.AutoSize = true;
            this.labelEntero.Location = new System.Drawing.Point(90, 57);
            this.labelEntero.Name = "labelEntero";
            this.labelEntero.Size = new System.Drawing.Size(148, 16);
            this.labelEntero.TabIndex = 0;
            this.labelEntero.Text = "Dime un numero entero:";
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(90, 130);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(133, 16);
            this.labelReal.TabIndex = 1;
            this.labelReal.Text = "Dime un numero real:";
            // 
            // labelResultadoDoble
            // 
            this.labelResultadoDoble.AutoSize = true;
            this.labelResultadoDoble.Location = new System.Drawing.Point(90, 277);
            this.labelResultadoDoble.Name = "labelResultadoDoble";
            this.labelResultadoDoble.Size = new System.Drawing.Size(148, 16);
            this.labelResultadoDoble.TabIndex = 2;
            this.labelResultadoDoble.Text = "El doble del numero es:";
            // 
            // labelResultadoMitad
            // 
            this.labelResultadoMitad.AutoSize = true;
            this.labelResultadoMitad.Location = new System.Drawing.Point(90, 353);
            this.labelResultadoMitad.Name = "labelResultadoMitad";
            this.labelResultadoMitad.Size = new System.Drawing.Size(149, 16);
            this.labelResultadoMitad.TabIndex = 3;
            this.labelResultadoMitad.Text = "La mitad del numero es:";
            // 
            // btnEntero
            // 
            this.btnEntero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEntero.Location = new System.Drawing.Point(537, 50);
            this.btnEntero.Name = "btnEntero";
            this.btnEntero.Size = new System.Drawing.Size(90, 38);
            this.btnEntero.TabIndex = 4;
            this.btnEntero.Text = "Convertir";
            this.btnEntero.UseVisualStyleBackColor = true;
            this.btnEntero.Click += new System.EventHandler(this.btnEntero_Click);
            // 
            // btnReal
            // 
            this.btnReal.Location = new System.Drawing.Point(537, 123);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(90, 38);
            this.btnReal.TabIndex = 5;
            this.btnReal.Text = "Convertir";
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(537, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBoxEntero
            // 
            this.textBoxEntero.Location = new System.Drawing.Point(308, 54);
            this.textBoxEntero.Name = "textBoxEntero";
            this.textBoxEntero.Size = new System.Drawing.Size(113, 22);
            this.textBoxEntero.TabIndex = 7;
            this.textBoxEntero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxReal
            // 
            this.textBoxReal.Location = new System.Drawing.Point(308, 127);
            this.textBoxReal.Name = "textBoxReal";
            this.textBoxReal.Size = new System.Drawing.Size(113, 22);
            this.textBoxReal.TabIndex = 8;
            this.textBoxReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDoble
            // 
            this.textBoxDoble.Location = new System.Drawing.Point(308, 271);
            this.textBoxDoble.Name = "textBoxDoble";
            this.textBoxDoble.Size = new System.Drawing.Size(113, 22);
            this.textBoxDoble.TabIndex = 9;
            this.textBoxDoble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMitad
            // 
            this.textBoxMitad.Location = new System.Drawing.Point(308, 346);
            this.textBoxMitad.Name = "textBoxMitad";
            this.textBoxMitad.Size = new System.Drawing.Size(113, 22);
            this.textBoxMitad.TabIndex = 10;
            this.textBoxMitad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMitad);
            this.Controls.Add(this.textBoxDoble);
            this.Controls.Add(this.textBoxReal);
            this.Controls.Add(this.textBoxEntero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnEntero);
            this.Controls.Add(this.labelResultadoMitad);
            this.Controls.Add(this.labelResultadoDoble);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.labelEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEntero;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Label labelResultadoDoble;
        private System.Windows.Forms.Label labelResultadoMitad;
        private System.Windows.Forms.Button btnEntero;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxEntero;
        private System.Windows.Forms.TextBox textBoxReal;
        private System.Windows.Forms.TextBox textBoxDoble;
        private System.Windows.Forms.TextBox textBoxMitad;
    }
}

