namespace POS
{
    partial class Main
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
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlPersona = new System.Windows.Forms.TableLayoutPanel();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreRes = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tbRUT = new System.Windows.Forms.TextBox();
            this.tlInferior = new System.Windows.Forms.TableLayoutPanel();
            this.tlPagar = new System.Windows.Forms.TableLayoutPanel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flMantenedores = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManItems = new System.Windows.Forms.Button();
            this.btnMantPrepago = new System.Windows.Forms.Button();
            this.btnUltimasVentas = new System.Windows.Forms.Button();
            this.btnEnvioReporte = new System.Windows.Forms.Button();
            this.tlItems = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCantidad = new System.Windows.Forms.Label();
            this.lblItemValor = new System.Windows.Forms.Label();
            this.lblItemNombre = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tlMain.SuspendLayout();
            this.tlPersona.SuspendLayout();
            this.tlInferior.SuspendLayout();
            this.tlPagar.SuspendLayout();
            this.flMantenedores.SuspendLayout();
            this.tlItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.tlPersona, 0, 0);
            this.tlMain.Controls.Add(this.tlInferior, 0, 2);
            this.tlMain.Controls.Add(this.tlItems, 0, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 3;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlMain.Size = new System.Drawing.Size(681, 451);
            this.tlMain.TabIndex = 0;
            // 
            // tlPersona
            // 
            this.tlPersona.ColumnCount = 3;
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPersona.Controls.Add(this.lblRut, 0, 0);
            this.tlPersona.Controls.Add(this.lblNombre, 0, 1);
            this.tlPersona.Controls.Add(this.lblNombreRes, 1, 1);
            this.tlPersona.Controls.Add(this.btnBuscar, 2, 0);
            this.tlPersona.Controls.Add(this.btnNuevo, 2, 1);
            this.tlPersona.Controls.Add(this.tbRUT, 1, 0);
            this.tlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersona.Location = new System.Drawing.Point(3, 3);
            this.tlPersona.Name = "tlPersona";
            this.tlPersona.RowCount = 2;
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersona.Size = new System.Drawing.Size(675, 66);
            this.tlPersona.TabIndex = 0;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.Location = new System.Drawing.Point(3, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(91, 33);
            this.lblRut.TabIndex = 0;
            this.lblRut.Text = "RUT:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 33);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreRes
            // 
            this.lblNombreRes.AutoSize = true;
            this.lblNombreRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRes.Location = new System.Drawing.Point(138, 33);
            this.lblNombreRes.Name = "lblNombreRes";
            this.lblNombreRes.Size = new System.Drawing.Size(27, 33);
            this.lblNombreRes.TabIndex = 2;
            this.lblNombreRes.Text = "-";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(543, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(543, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 27);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tbRUT
            // 
            this.tbRUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRUT.Location = new System.Drawing.Point(138, 3);
            this.tbRUT.Name = "tbRUT";
            this.tbRUT.Size = new System.Drawing.Size(399, 26);
            this.tbRUT.TabIndex = 5;
            this.tbRUT.TextChanged += new System.EventHandler(this.tbRUT_TextChanged);
            // 
            // tlInferior
            // 
            this.tlInferior.ColumnCount = 3;
            this.tlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlInferior.Controls.Add(this.tlPagar, 2, 0);
            this.tlInferior.Controls.Add(this.flMantenedores, 0, 0);
            this.tlInferior.Controls.Add(this.lblTotal, 1, 0);
            this.tlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInferior.Location = new System.Drawing.Point(3, 358);
            this.tlInferior.Name = "tlInferior";
            this.tlInferior.RowCount = 1;
            this.tlInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInferior.Size = new System.Drawing.Size(675, 90);
            this.tlInferior.TabIndex = 2;
            // 
            // tlPagar
            // 
            this.tlPagar.ColumnCount = 2;
            this.tlPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPagar.Controls.Add(this.btnPagar, 0, 0);
            this.tlPagar.Controls.Add(this.btnCancelar, 1, 0);
            this.tlPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPagar.Location = new System.Drawing.Point(454, 3);
            this.tlPagar.Name = "tlPagar";
            this.tlPagar.RowCount = 1;
            this.tlPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPagar.Size = new System.Drawing.Size(218, 84);
            this.tlPagar.TabIndex = 0;
            // 
            // btnPagar
            // 
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(3, 3);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(124, 78);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(133, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 78);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // flMantenedores
            // 
            this.flMantenedores.Controls.Add(this.btnManItems);
            this.flMantenedores.Controls.Add(this.btnMantPrepago);
            this.flMantenedores.Controls.Add(this.btnUltimasVentas);
            this.flMantenedores.Controls.Add(this.btnEnvioReporte);
            this.flMantenedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flMantenedores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flMantenedores.Location = new System.Drawing.Point(3, 3);
            this.flMantenedores.Name = "flMantenedores";
            this.flMantenedores.Size = new System.Drawing.Size(216, 84);
            this.flMantenedores.TabIndex = 1;
            // 
            // btnManItems
            // 
            this.btnManItems.Location = new System.Drawing.Point(3, 3);
            this.btnManItems.Name = "btnManItems";
            this.btnManItems.Size = new System.Drawing.Size(90, 23);
            this.btnManItems.TabIndex = 0;
            this.btnManItems.Text = "Mant. Items";
            this.btnManItems.UseVisualStyleBackColor = true;
            this.btnManItems.Click += new System.EventHandler(this.btnManItems_Click);
            // 
            // btnMantPrepago
            // 
            this.btnMantPrepago.Location = new System.Drawing.Point(3, 32);
            this.btnMantPrepago.Name = "btnMantPrepago";
            this.btnMantPrepago.Size = new System.Drawing.Size(90, 23);
            this.btnMantPrepago.TabIndex = 1;
            this.btnMantPrepago.Text = "Mant. Prepago";
            this.btnMantPrepago.UseVisualStyleBackColor = true;
            // 
            // btnUltimasVentas
            // 
            this.btnUltimasVentas.Location = new System.Drawing.Point(99, 3);
            this.btnUltimasVentas.Name = "btnUltimasVentas";
            this.btnUltimasVentas.Size = new System.Drawing.Size(90, 23);
            this.btnUltimasVentas.TabIndex = 3;
            this.btnUltimasVentas.Text = "Ultimas Ventas";
            this.btnUltimasVentas.UseVisualStyleBackColor = true;
            // 
            // btnEnvioReporte
            // 
            this.btnEnvioReporte.Location = new System.Drawing.Point(99, 32);
            this.btnEnvioReporte.Name = "btnEnvioReporte";
            this.btnEnvioReporte.Size = new System.Drawing.Size(90, 23);
            this.btnEnvioReporte.TabIndex = 4;
            this.btnEnvioReporte.Text = "Envio Reporte";
            this.btnEnvioReporte.UseVisualStyleBackColor = true;
            // 
            // tlItems
            // 
            this.tlItems.AutoScroll = true;
            this.tlItems.BackColor = System.Drawing.Color.White;
            this.tlItems.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlItems.ColumnCount = 3;
            this.tlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlItems.Controls.Add(this.lblItemNombre, 0, 0);
            this.tlItems.Controls.Add(this.lblItemValor, 1, 0);
            this.tlItems.Controls.Add(this.lblItemCantidad, 2, 0);
            this.tlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlItems.Location = new System.Drawing.Point(3, 75);
            this.tlItems.Name = "tlItems";
            this.tlItems.RowCount = 1;
            this.tlItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlItems.Size = new System.Drawing.Size(675, 277);
            this.tlItems.TabIndex = 3;
            // 
            // lblItemCantidad
            // 
            this.lblItemCantidad.AutoSize = true;
            this.lblItemCantidad.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCantidad.Location = new System.Drawing.Point(455, 1);
            this.lblItemCantidad.Name = "lblItemCantidad";
            this.lblItemCantidad.Size = new System.Drawing.Size(216, 275);
            this.lblItemCantidad.TabIndex = 2;
            this.lblItemCantidad.Text = "Cantidad";
            this.lblItemCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemValor
            // 
            this.lblItemValor.AutoSize = true;
            this.lblItemValor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemValor.Location = new System.Drawing.Point(226, 1);
            this.lblItemValor.Name = "lblItemValor";
            this.lblItemValor.Size = new System.Drawing.Size(222, 275);
            this.lblItemValor.TabIndex = 1;
            this.lblItemValor.Text = "Valor";
            this.lblItemValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemNombre
            // 
            this.lblItemNombre.AutoSize = true;
            this.lblItemNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblItemNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNombre.Location = new System.Drawing.Point(4, 1);
            this.lblItemNombre.Name = "lblItemNombre";
            this.lblItemNombre.Size = new System.Drawing.Size(215, 275);
            this.lblItemNombre.TabIndex = 0;
            this.lblItemNombre.Text = "Nombre";
            this.lblItemNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(225, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 90);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(681, 451);
            this.Controls.Add(this.tlMain);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LasTacas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tlMain.ResumeLayout(false);
            this.tlPersona.ResumeLayout(false);
            this.tlPersona.PerformLayout();
            this.tlInferior.ResumeLayout(false);
            this.tlInferior.PerformLayout();
            this.tlPagar.ResumeLayout(false);
            this.flMantenedores.ResumeLayout(false);
            this.tlItems.ResumeLayout(false);
            this.tlItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.TableLayoutPanel tlPersona;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreRes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox tbRUT;
        private System.Windows.Forms.TableLayoutPanel tlInferior;
        private System.Windows.Forms.TableLayoutPanel tlPagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flMantenedores;
        private System.Windows.Forms.Button btnManItems;
        private System.Windows.Forms.Button btnMantPrepago;
        private System.Windows.Forms.Button btnUltimasVentas;
        private System.Windows.Forms.Button btnEnvioReporte;
        private System.Windows.Forms.TableLayoutPanel tlItems;
        private System.Windows.Forms.Label lblItemCantidad;
        private System.Windows.Forms.Label lblItemValor;
        private System.Windows.Forms.Label lblItemNombre;
        private System.Windows.Forms.Label lblTotal;
    }
}

