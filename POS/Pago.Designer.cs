namespace POS
{
    partial class Pago
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
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrepago = new System.Windows.Forms.Button();
            this.btnRedCompra = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.tlMain.SuspendLayout();
            this.tlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.tlBotones, 0, 1);
            this.tlMain.Controls.Add(this.dg, 0, 0);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlMain.Size = new System.Drawing.Size(548, 409);
            this.tlMain.TabIndex = 0;
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 4;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlBotones.Controls.Add(this.btnPrepago, 0, 0);
            this.tlBotones.Controls.Add(this.btnRedCompra, 1, 0);
            this.tlBotones.Controls.Add(this.btnEfectivo, 2, 0);
            this.tlBotones.Controls.Add(this.btnCancelar, 3, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(3, 364);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBotones.Size = new System.Drawing.Size(542, 42);
            this.tlBotones.TabIndex = 0;
            // 
            // btnPrepago
            // 
            this.btnPrepago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrepago.Location = new System.Drawing.Point(3, 3);
            this.btnPrepago.Name = "btnPrepago";
            this.btnPrepago.Size = new System.Drawing.Size(129, 36);
            this.btnPrepago.TabIndex = 0;
            this.btnPrepago.Text = "Prepago";
            this.btnPrepago.UseVisualStyleBackColor = true;
            this.btnPrepago.Click += new System.EventHandler(this.btnPrepago_Click);
            // 
            // btnRedCompra
            // 
            this.btnRedCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedCompra.Location = new System.Drawing.Point(138, 3);
            this.btnRedCompra.Name = "btnRedCompra";
            this.btnRedCompra.Size = new System.Drawing.Size(129, 36);
            this.btnRedCompra.TabIndex = 1;
            this.btnRedCompra.Text = "RedCompra";
            this.btnRedCompra.UseVisualStyleBackColor = true;
            this.btnRedCompra.Click += new System.EventHandler(this.btnRedCompra_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEfectivo.Location = new System.Drawing.Point(273, 3);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(129, 36);
            this.btnEfectivo.TabIndex = 2;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(408, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(3, 3);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(542, 355);
            this.dg.TabIndex = 1;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(548, 409);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Pago";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pago";
            this.tlMain.ResumeLayout(false);
            this.tlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnPrepago;
        private System.Windows.Forms.Button btnRedCompra;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnCancelar;
    }
}