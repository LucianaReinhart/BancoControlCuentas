namespace BancoControlCuentas
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
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnExtraccion = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidadDepositos = new System.Windows.Forms.Label();
            this.lblCantidadExtraccion = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescubierto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(502, 76);
            this.btnDeposito.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(141, 59);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnExtraccion
            // 
            this.btnExtraccion.Location = new System.Drawing.Point(502, 170);
            this.btnExtraccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtraccion.Name = "btnExtraccion";
            this.btnExtraccion.Size = new System.Drawing.Size(141, 59);
            this.btnExtraccion.TabIndex = 2;
            this.btnExtraccion.Text = "Extracción";
            this.btnExtraccion.UseVisualStyleBackColor = true;
            this.btnExtraccion.Click += new System.EventHandler(this.btnExtraccion_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(130, 136);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(108, 20);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Ingrese monto:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 23);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo: ";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(246, 133);
            this.textBoxMonto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(132, 27);
            this.textBoxMonto.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 336);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 44);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidadDepositos
            // 
            this.lblCantidadDepositos.AutoSize = true;
            this.lblCantidadDepositos.Location = new System.Drawing.Point(15, 65);
            this.lblCantidadDepositos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDepositos.Name = "lblCantidadDepositos";
            this.lblCantidadDepositos.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadDepositos.TabIndex = 7;
            this.lblCantidadDepositos.Click += new System.EventHandler(this.lblCantidadDepositos_Click);
            // 
            // lblCantidadExtraccion
            // 
            this.lblCantidadExtraccion.AutoSize = true;
            this.lblCantidadExtraccion.Location = new System.Drawing.Point(15, 102);
            this.lblCantidadExtraccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadExtraccion.Name = "lblCantidadExtraccion";
            this.lblCantidadExtraccion.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadExtraccion.TabIndex = 8;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(283, 26);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(262, 25);
            this.lblBanco.TabIndex = 9;
            this.lblBanco.Text = "BANCO - CONTROL CUENTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.lblCantidadDepositos);
            this.groupBox1.Controls.Add(this.lblCantidadExtraccion);
            this.groupBox1.Location = new System.Drawing.Point(134, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblDescubierto
            // 
            this.lblDescubierto.AutoSize = true;
            this.lblDescubierto.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescubierto.Location = new System.Drawing.Point(131, 404);
            this.lblDescubierto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescubierto.Name = "lblDescubierto";
            this.lblDescubierto.Size = new System.Drawing.Size(430, 15);
            this.lblDescubierto.TabIndex = 9;
            this.lblDescubierto.Text = "La cuenta puede tener saldo negativo de hasta $50.000 para girar en descubierto.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 453);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescubierto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnExtraccion);
            this.Controls.Add(this.btnDeposito);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(824, 492);
            this.MinimumSize = new System.Drawing.Size(824, 492);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco - Control Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnExtraccion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidadDepositos;
        private System.Windows.Forms.Label lblCantidadExtraccion;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescubierto;
    }
}

