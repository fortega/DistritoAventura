namespace POS.Pagos
{
    partial class Prepago
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 2;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMain.Controls.Add(this.lblCodigo, 0, 0);
            this.tlMain.Controls.Add(this.tbCodigo, 1, 0);
            this.tlMain.Controls.Add(this.btnAceptar, 0, 1);
            this.tlMain.Controls.Add(this.btnCancelar, 1, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.Size = new System.Drawing.Size(392, 69);
            this.tlMain.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(190, 26);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCodigo.Location = new System.Drawing.Point(199, 3);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(190, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(3, 29);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(190, 37);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(199, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Prepago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(392, 69);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Prepago";
            this.Text = "Prepago";
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}