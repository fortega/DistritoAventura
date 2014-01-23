namespace POS
{
    partial class PrepagoSaldoInsuficiente
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
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnRedcompra = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.tlBotones.SuspendLayout();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 3;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlBotones.Controls.Add(this.btnRedcompra, 0, 0);
            this.tlBotones.Controls.Add(this.btnEfectivo, 1, 0);
            this.tlBotones.Controls.Add(this.btnCancelar, 2, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(3, 228);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBotones.Size = new System.Drawing.Size(286, 42);
            this.tlBotones.TabIndex = 0;
            // 
            // btnRedcompra
            // 
            this.btnRedcompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedcompra.Location = new System.Drawing.Point(3, 3);
            this.btnRedcompra.Name = "btnRedcompra";
            this.btnRedcompra.Size = new System.Drawing.Size(88, 36);
            this.btnRedcompra.TabIndex = 0;
            this.btnRedcompra.Text = "RedCompra";
            this.btnRedcompra.UseVisualStyleBackColor = true;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEfectivo.Location = new System.Drawing.Point(97, 3);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(91, 36);
            this.btnEfectivo.TabIndex = 1;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(194, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.tlBotones, 0, 1);
            this.tlMain.Controls.Add(this.lblSaldo, 0, 0);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlMain.Size = new System.Drawing.Size(292, 273);
            this.tlMain.TabIndex = 1;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaldo.Location = new System.Drawing.Point(3, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(286, 225);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo: ";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrepagoSaldoInsuficiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrepagoSaldoInsuficiente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saldo Insuficiente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrepagoSaldoInsuficiente_FormClosing);
            this.tlBotones.ResumeLayout(false);
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.Button btnRedcompra;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        public System.Windows.Forms.Label lblSaldo;
    }
}