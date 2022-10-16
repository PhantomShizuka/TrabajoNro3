namespace TrabajoNro3
{
    partial class EjerPro2
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
            this.CbxYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.DgvOrden = new System.Windows.Forms.DataGridView();
            this.DgvDetalleOrden = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // CbxYear
            // 
            this.CbxYear.FormattingEnabled = true;
            this.CbxYear.Location = new System.Drawing.Point(59, 11);
            this.CbxYear.Name = "CbxYear";
            this.CbxYear.Size = new System.Drawing.Size(121, 23);
            this.CbxYear.TabIndex = 1;
            this.CbxYear.SelectedIndexChanged += new System.EventHandler(this.CbxYear_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 250);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvOrden);
            this.groupBox2.Location = new System.Drawing.Point(16, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvDetalleOrden);
            this.groupBox3.Location = new System.Drawing.Point(16, 557);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 250);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle-Orden";
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleado.Location = new System.Drawing.Point(6, 22);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.Size = new System.Drawing.Size(528, 222);
            this.DgvEmpleado.TabIndex = 0;
            this.DgvEmpleado.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleado_RowEnter);
            // 
            // DgvOrden
            // 
            this.DgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrden.Location = new System.Drawing.Point(6, 22);
            this.DgvOrden.Name = "DgvOrden";
            this.DgvOrden.Size = new System.Drawing.Size(528, 222);
            this.DgvOrden.TabIndex = 0;
            this.DgvOrden.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.DgvOrden_CellStateChanged);
            // 
            // DgvDetalleOrden
            // 
            this.DgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleOrden.Location = new System.Drawing.Point(6, 22);
            this.DgvDetalleOrden.Name = "DgvDetalleOrden";
            this.DgvDetalleOrden.Size = new System.Drawing.Size(528, 222);
            this.DgvDetalleOrden.TabIndex = 0;
            // 
            // EjerPro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 817);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbxYear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EjerPro2";
            this.Text = "EjerPro2";
            this.Load += new System.EventHandler(this.EjerPro2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.DataGridView DgvOrden;
        private System.Windows.Forms.DataGridView DgvDetalleOrden;
    }
}