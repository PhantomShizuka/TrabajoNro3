namespace TrabajoNro3
{
    partial class EjerPro3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblRegistro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvOrdenes = new System.Windows.Forms.DataGridView();
            this.GbxDetalleOrden = new System.Windows.Forms.GroupBox();
            this.DgvDetalleOrdenes = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTotalVenta = new System.Windows.Forms.TextBox();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnAdelante = new System.Windows.Forms.Button();
            this.BtnFin = new System.Windows.Forms.Button();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenes)).BeginInit();
            this.GbxDetalleOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Location = new System.Drawing.Point(795, 15);
            this.LblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(105, 15);
            this.LblRegistro.TabIndex = 8;
            this.LblRegistro.Text = "Registro 01 de 99";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvOrdenes);
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(907, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes";
            // 
            // DgvOrdenes
            // 
            this.DgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenes.Location = new System.Drawing.Point(7, 22);
            this.DgvOrdenes.Name = "DgvOrdenes";
            this.DgvOrdenes.Size = new System.Drawing.Size(893, 166);
            this.DgvOrdenes.TabIndex = 0;
            this.DgvOrdenes.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DgvOrdenes_CellStateChanged);
            // 
            // GbxDetalleOrden
            // 
            this.GbxDetalleOrden.Controls.Add(this.DgvDetalleOrdenes);
            this.GbxDetalleOrden.Location = new System.Drawing.Point(13, 307);
            this.GbxDetalleOrden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxDetalleOrden.Name = "GbxDetalleOrden";
            this.GbxDetalleOrden.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxDetalleOrden.Size = new System.Drawing.Size(907, 200);
            this.GbxDetalleOrden.TabIndex = 10;
            this.GbxDetalleOrden.TabStop = false;
            this.GbxDetalleOrden.Text = "Detalle Orden #";
            // 
            // DgvDetalleOrdenes
            // 
            this.DgvDetalleOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleOrdenes.Location = new System.Drawing.Point(7, 22);
            this.DgvDetalleOrdenes.Name = "DgvDetalleOrdenes";
            this.DgvDetalleOrdenes.Size = new System.Drawing.Size(893, 172);
            this.DgvDetalleOrdenes.TabIndex = 0;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(141, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(256, 23);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtTotalVenta
            // 
            this.TxtTotalVenta.Enabled = false;
            this.TxtTotalVenta.Location = new System.Drawing.Point(141, 53);
            this.TxtTotalVenta.Name = "TxtTotalVenta";
            this.TxtTotalVenta.Size = new System.Drawing.Size(256, 23);
            this.TxtTotalVenta.TabIndex = 11;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Location = new System.Drawing.Point(783, 48);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(30, 23);
            this.BtnInicio.TabIndex = 12;
            this.BtnInicio.Text = "<<";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(819, 48);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(30, 23);
            this.BtnAtras.TabIndex = 12;
            this.BtnAtras.Text = "<";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnAdelante
            // 
            this.BtnAdelante.Location = new System.Drawing.Point(855, 48);
            this.BtnAdelante.Name = "BtnAdelante";
            this.BtnAdelante.Size = new System.Drawing.Size(30, 23);
            this.BtnAdelante.TabIndex = 12;
            this.BtnAdelante.Text = ">";
            this.BtnAdelante.UseVisualStyleBackColor = true;
            this.BtnAdelante.Click += new System.EventHandler(this.BtnAdelante_Click);
            // 
            // BtnFin
            // 
            this.BtnFin.Location = new System.Drawing.Point(891, 48);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(30, 23);
            this.BtnFin.TabIndex = 12;
            this.BtnFin.Text = ">>";
            this.BtnFin.UseVisualStyleBackColor = true;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Enabled = false;
            this.TxtApellidos.Location = new System.Drawing.Point(476, 12);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(256, 23);
            this.TxtApellidos.TabIndex = 11;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Location = new System.Drawing.Point(476, 53);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(256, 23);
            this.TxtFecha.TabIndex = 11;
            // 
            // EjerPro3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 518);
            this.Controls.Add(this.BtnFin);
            this.Controls.Add(this.BtnAdelante);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtTotalVenta);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.GbxDetalleOrden);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EjerPro3";
            this.Text = "EjerPro3";
            this.Load += new System.EventHandler(this.EjerPro3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenes)).EndInit();
            this.GbxDetalleOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvOrdenes;
        private System.Windows.Forms.GroupBox GbxDetalleOrden;
        private System.Windows.Forms.DataGridView DgvDetalleOrdenes;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTotalVenta;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnAdelante;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtFecha;
    }
}