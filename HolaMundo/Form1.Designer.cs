namespace HolaMundo
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
            this.BotonHelloWorld = new System.Windows.Forms.Button();
            this.LabelHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonHelloWorld
            // 
            this.BotonHelloWorld.Location = new System.Drawing.Point(299, 88);
            this.BotonHelloWorld.Name = "BotonHelloWorld";
            this.BotonHelloWorld.Size = new System.Drawing.Size(75, 23);
            this.BotonHelloWorld.TabIndex = 0;
            this.BotonHelloWorld.Text = "Click Me";
            this.BotonHelloWorld.UseVisualStyleBackColor = true;
            this.BotonHelloWorld.Click += new System.EventHandler(this.BotonHelloWorld_Click);
            // 
            // LabelHello
            // 
            this.LabelHello.AutoSize = true;
            this.LabelHello.Location = new System.Drawing.Point(330, 261);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(44, 16);
            this.LabelHello.TabIndex = 1;
            this.LabelHello.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelHello);
            this.Controls.Add(this.BotonHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonHelloWorld;
        private System.Windows.Forms.Label LabelHello;
    }
}

