namespace pryCalvetEtapa6
{
    partial class frmEtapa6
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.tmrMovimiento = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(12, 471);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(12, 500);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 1;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblContador
            // 
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContador.Location = new System.Drawing.Point(96, 500);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(100, 23);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Contador : 0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(96, 474);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // tmrMovimiento
            // 
            this.tmrMovimiento.Interval = 50;
            this.tmrMovimiento.Tick += new System.EventHandler(this.tmrMovimiento_Tick);
            // 
            // frmEtapa6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(872, 535);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtapa6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Timer tmrMovimiento;
    }
}

