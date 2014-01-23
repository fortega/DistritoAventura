namespace POS.Pagos
{
    partial class RedCompra
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
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbTransaccion = new System.Windows.Forms.MaskedTextBox();
            this.tbAutorizacion = new System.Windows.Forms.MaskedTextBox();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 2;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.Controls.Add(this.lblTrans, 0, 0);
            this.tlMain.Controls.Add(this.lblAuto, 0, 1);
            this.tlMain.Controls.Add(this.btnOK, 0, 3);
            this.tlMain.Controls.Add(this.lblTipo, 0, 2);
            this.tlMain.Controls.Add(this.btnCancelar, 1, 3);
            this.tlMain.Controls.Add(this.cbTipo, 1, 2);
            this.tlMain.Controls.Add(this.tbTransaccion, 1, 0);
            this.tlMain.Controls.Add(this.tbAutorizacion, 1, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 4;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlMain.Size = new System.Drawing.Size(292, 128);
            this.tlMain.TabIndex = 0;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrans.Location = new System.Drawing.Point(3, 0);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(140, 26);
            this.lblTrans.TabIndex = 0;
            this.lblTrans.Text = "Transaccion:";
            this.lblTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuto.Location = new System.Drawing.Point(3, 26);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(140, 26);
            this.lblAuto.TabIndex = 1;
            this.lblAuto.Text = "Autorizacion:";
            this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(3, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 43);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Location = new System.Drawing.Point(3, 52);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(140, 27);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(149, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.cbTipo.Location = new System.Drawing.Point(149, 55);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(140, 21);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Tag = "Debito";
            // 
            // tbTransaccion
            // 
            this.tbTransaccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTransaccion.Location = new System.Drawing.Point(149, 3);
            this.tbTransaccion.Mask = "99999";
            this.tbTransaccion.Name = "tbTransaccion";
            this.tbTransaccion.Size = new System.Drawing.Size(140, 20);
            this.tbTransaccion.TabIndex = 3;
            this.tbTransaccion.ValidatingType = typeof(int);
            // 
            // tbAutorizacion
            // 
            this.tbAutorizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAutorizacion.Location = new System.Drawing.Point(149, 29);
            this.tbAutorizacion.Mask = "99999";
            this.tbAutorizacion.Name = "tbAutorizacion";
            this.tbAutorizacion.Size = new System.Drawing.Size(140, 20);
            this.tbAutorizacion.TabIndex = 4;
            this.tbAutorizacion.ValidatingType = typeof(int);
            // 
            // RedCompra
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(292, 128);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RedCompra";
            this.Text = "Pago RedCompra";
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.MaskedTextBox tbTransaccion;
        public System.Windows.Forms.MaskedTextBox tbAutorizacion;
    }
}