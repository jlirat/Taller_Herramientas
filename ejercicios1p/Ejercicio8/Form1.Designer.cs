namespace Ejercicio8
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.areaTrabajo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.areaTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // areaTrabajo
            // 
            this.areaTrabajo.Location = new System.Drawing.Point(6, 12);
            this.areaTrabajo.Name = "areaTrabajo";
            this.areaTrabajo.Size = new System.Drawing.Size(1577, 304);
            this.areaTrabajo.TabIndex = 0;
            this.areaTrabajo.TabStop = false;
            this.areaTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.areaTrabajo_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 328);
            this.Controls.Add(this.areaTrabajo);
            this.Name = "frmPrincipal";
            this.Text = "Juego de la Tortuga";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrincipal_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.areaTrabajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox areaTrabajo;
        private System.Windows.Forms.Timer timer1;
    }
}

