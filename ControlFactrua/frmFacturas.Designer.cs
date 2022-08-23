namespace ControlFactrua
{
    partial class frmFacturas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lvEstadistica = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de facturas ";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(21, 57);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(371, 23);
            this.txtVendedor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevaFactura);
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.btnRegistrarItem);
            this.groupBox1.Location = new System.Drawing.Point(21, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de facturas ";
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Location = new System.Drawing.Point(469, 54);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(123, 23);
            this.btnNuevaFactura.TabIndex = 13;
            this.btnNuevaFactura.Text = "Otra factura";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(341, 54);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(114, 23);
            this.txtUnidades.TabIndex = 15;
            // 
            // txtNumFact
            // 
            this.txtNumFact.Location = new System.Drawing.Point(6, 55);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(104, 23);
            this.txtNumFact.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "No Factura ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de licencia ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Unidades ";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Cobre",
            "Bronce",
            "Silver",
            "Gold"});
            this.cboTipo.Location = new System.Drawing.Point(129, 54);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(180, 23);
            this.cboTipo.TabIndex = 4;
            this.cboTipo.Text = "(Seleccione licencia)";
            // 
            // btnRegistrarItem
            // 
            this.btnRegistrarItem.Location = new System.Drawing.Point(469, 25);
            this.btnRegistrarItem.Name = "btnRegistrarItem";
            this.btnRegistrarItem.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarItem.TabIndex = 3;
            this.btnRegistrarItem.Text = "Registrar item";
            this.btnRegistrarItem.UseVisualStyleBackColor = true;
            this.btnRegistrarItem.Click += new System.EventHandler(this.btnRegistrarItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(490, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Listado de registros";
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.Location = new System.Drawing.Point(21, 216);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(599, 138);
            this.lvRegistro.TabIndex = 12;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num. Factura";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo de  licencia";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidades";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estadistica de venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Monto total";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(456, 367);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 15);
            this.lblMonto.TabIndex = 15;
            this.lblMonto.Text = "label11";
            // 
            // lvEstadistica
            // 
            this.lvEstadistica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstadistica.GridLines = true;
            this.lvEstadistica.Location = new System.Drawing.Point(21, 385);
            this.lvEstadistica.Name = "lvEstadistica";
            this.lvEstadistica.Size = new System.Drawing.Size(400, 155);
            this.lvEstadistica.TabIndex = 16;
            this.lvEstadistica.UseCompatibleStateImageBehavior = false;
            this.lvEstadistica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo de licencia";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total unidades";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Monto total";
            this.columnHeader7.Width = 100;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(545, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 552);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvEstadistica);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturas";
            this.Text = "Control de registro de facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtVendedor;
        private GroupBox groupBox1;
        private Button btnNuevaFactura;
        private TextBox txtUnidades;
        private TextBox txtNumFact;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboTipo;
        private Button btnRegistrarItem;
        private Label label2;
        private Label label3;
        private Label lblFecha;
        private Label label8;
        private ListView lvRegistro;
        private Label label9;
        private Label label10;
        private Label lblMonto;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lvEstadistica;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnSalir;
    }
}