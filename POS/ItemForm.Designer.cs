namespace POS
{
    partial class ItemForm
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
            this.tl = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.MaskedTextBox();
            this.tl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tl
            // 
            this.tl.ColumnCount = 2;
            this.tl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl.Controls.Add(this.lblNombre, 0, 0);
            this.tl.Controls.Add(this.lblValor, 0, 1);
            this.tl.Controls.Add(this.tbNombre, 1, 0);
            this.tl.Controls.Add(this.btnCrear, 0, 3);
            this.tl.Controls.Add(this.btnCancelar, 1, 3);
            this.tl.Controls.Add(this.ckActivo, 1, 2);
            this.tl.Controls.Add(this.lblActivo, 0, 2);
            this.tl.Controls.Add(this.tbValor, 1, 1);
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Location = new System.Drawing.Point(0, 0);
            this.tl.Name = "tl";
            this.tl.RowCount = 4;
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.Size = new System.Drawing.Size(450, 150);
            this.tl.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(219, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Location = new System.Drawing.Point(3, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(219, 26);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombre
            // 
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.Location = new System.Drawing.Point(228, 3);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(219, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrear.Location = new System.Drawing.Point(3, 75);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(219, 72);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(228, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 72);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Checked = true;
            this.ckActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckActivo.Location = new System.Drawing.Point(228, 55);
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Size = new System.Drawing.Size(15, 14);
            this.ckActivo.TabIndex = 6;
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivo.Location = new System.Drawing.Point(3, 52);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(219, 20);
            this.lblActivo.TabIndex = 3;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbValor
            // 
            this.tbValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbValor.Location = new System.Drawing.Point(228, 29);
            this.tbValor.Mask = "999999";
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(219, 20);
            this.tbValor.TabIndex = 5;
            // 
            // ItemForm
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Controls.Add(this.tl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemForm_FormClosing);
            this.tl.ResumeLayout(false);
            this.tl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.MaskedTextBox tbValor;
    }
}