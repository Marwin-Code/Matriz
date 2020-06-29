namespace ExamenBanTrab
{
    partial class frmMatrizOperaciones
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
            this.sptContenedor = new System.Windows.Forms.SplitContainer();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.txtNotificacion = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.lblFila = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sptContenedor)).BeginInit();
            this.sptContenedor.Panel1.SuspendLayout();
            this.sptContenedor.Panel2.SuspendLayout();
            this.sptContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // sptContenedor
            // 
            this.sptContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptContenedor.Location = new System.Drawing.Point(0, 0);
            this.sptContenedor.Name = "sptContenedor";
            // 
            // sptContenedor.Panel1
            // 
            this.sptContenedor.Panel1.Controls.Add(this.btnInicio);
            this.sptContenedor.Panel1.Controls.Add(this.btnOperacion);
            this.sptContenedor.Panel1.Controls.Add(this.txtNotificacion);
            this.sptContenedor.Panel1.Controls.Add(this.txtFila);
            this.sptContenedor.Panel1.Controls.Add(this.lblFila);
            this.sptContenedor.Panel1.Controls.Add(this.txtTotal);
            this.sptContenedor.Panel1.Controls.Add(this.lblValor);
            // 
            // sptContenedor.Panel2
            // 
            this.sptContenedor.Panel2.Controls.Add(this.grdDatos);
            this.sptContenedor.Size = new System.Drawing.Size(800, 450);
            this.sptContenedor.SplitterDistance = 353;
            this.sptContenedor.TabIndex = 0;
            // 
            // btnOperacion
            // 
            this.btnOperacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOperacion.Location = new System.Drawing.Point(96, 399);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(75, 23);
            this.btnOperacion.TabIndex = 5;
            this.btnOperacion.Text = "Siguiente >>";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // txtNotificacion
            // 
            this.txtNotificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificacion.Location = new System.Drawing.Point(12, 105);
            this.txtNotificacion.Multiline = true;
            this.txtNotificacion.Name = "txtNotificacion";
            this.txtNotificacion.Size = new System.Drawing.Size(322, 277);
            this.txtNotificacion.TabIndex = 4;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(144, 49);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(76, 20);
            this.txtFila.TabIndex = 3;
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(12, 56);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(129, 13);
            this.lblFila.TabIndex = 2;
            this.lblFila.Text = "Total Fila 1 y 2 Columna 2";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(144, 22);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 25);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(27, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "total";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(443, 450);
            this.grdDatos.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.Location = new System.Drawing.Point(193, 399);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmMatrizOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sptContenedor);
            this.Name = "frmMatrizOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones de Matriz";
            this.Load += new System.EventHandler(this.frmMatrizOperaciones_Load);
            this.sptContenedor.Panel1.ResumeLayout(false);
            this.sptContenedor.Panel1.PerformLayout();
            this.sptContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptContenedor)).EndInit();
            this.sptContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptContenedor;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.TextBox txtNotificacion;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Button btnInicio;
    }
}