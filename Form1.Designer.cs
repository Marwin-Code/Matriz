namespace ExamenBanTrab
{
    partial class frmMatriz
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
            this.grdMatriz = new System.Windows.Forms.DataGridView();
            this.txtMatrizC = new System.Windows.Forms.TextBox();
            this.aux1 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMatriz
            // 
            this.grdMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMatriz.Location = new System.Drawing.Point(54, 107);
            this.grdMatriz.Name = "grdMatriz";
            this.grdMatriz.Size = new System.Drawing.Size(687, 306);
            this.grdMatriz.TabIndex = 0;
            // 
            // txtMatrizC
            // 
            this.txtMatrizC.Location = new System.Drawing.Point(678, 12);
            this.txtMatrizC.Name = "txtMatrizC";
            this.txtMatrizC.Size = new System.Drawing.Size(100, 20);
            this.txtMatrizC.TabIndex = 1;
            // 
            // aux1
            // 
            this.aux1.Location = new System.Drawing.Point(678, 38);
            this.aux1.Name = "aux1";
            this.aux1.Size = new System.Drawing.Size(100, 20);
            this.aux1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(51, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(20, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = ".";
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(399, 419);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(75, 23);
            this.btnOperacion.TabIndex = 4;
            this.btnOperacion.Text = "Siguiente>>";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(678, 64);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(625, 67);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(27, 13);
            this.Valor.TabIndex = 6;
            this.Valor.Text = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "total";
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(678, 88);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 20);
            this.txtTotal2.TabIndex = 7;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(13, 138);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(24, 25);
            this.lblAyuda.TabIndex = 9;
            this.lblAyuda.Text = "#";
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.aux1);
            this.Controls.Add(this.txtMatrizC);
            this.Controls.Add(this.grdMatriz);
            this.Name = "frmMatriz";
            this.Text = "Prototipo";
            this.Load += new System.EventHandler(this.frmMatriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMatriz;
        private System.Windows.Forms.TextBox txtMatrizC;
        private System.Windows.Forms.TextBox aux1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Label lblAyuda;
    }
}

