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
            this.BotonHelloWorld.BackColor = System.Drawing.Color.Black;
            this.BotonHelloWorld.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonHelloWorld.FlatAppearance.BorderSize = 2;
            this.BotonHelloWorld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BotonHelloWorld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BotonHelloWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHelloWorld.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHelloWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonHelloWorld.Location = new System.Drawing.Point(296, 274);
            this.BotonHelloWorld.Name = "BotonHelloWorld";
            this.BotonHelloWorld.Size = new System.Drawing.Size(197, 59);
            this.BotonHelloWorld.TabIndex = 0;
            this.BotonHelloWorld.Text = "Click Me";
            this.BotonHelloWorld.UseVisualStyleBackColor = false;
            this.BotonHelloWorld.Click += new System.EventHandler(this.BotonHelloWorld_Click);
            // 
            // LabelHello
            // 
            this.LabelHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHello.Font = new System.Drawing.Font("Roboto", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHello.Location = new System.Drawing.Point(166, 35);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(469, 154);
            this.LabelHello.TabIndex = 1;
            this.LabelHello.Click += new System.EventHandler(this.LabelHello_Click);
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

        }

        #endregion

        private System.Windows.Forms.Button BotonHelloWorld;
        private System.Windows.Forms.Label LabelHello;
    }
}

