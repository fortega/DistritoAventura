namespace POS
{
    partial class NuevaPersona
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
            this.lblRut = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbRut = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tl
            // 
            this.tl.ColumnCount = 2;
            this.tl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl.Controls.Add(this.lblRut, 0, 0);
            this.tl.Controls.Add(this.lblApellido, 0, 1);
            this.tl.Controls.Add(this.lblNombre, 0, 2);
            this.tl.Controls.Add(this.lblNacimiento, 0, 3);
            this.tl.Controls.Add(this.lblEmail, 0, 4);
            this.tl.Controls.Add(this.tbRut, 1, 0);
            this.tl.Controls.Add(this.btnCrear, 0, 5);
            this.tl.Controls.Add(this.btnCancelar, 1, 5);
            this.tl.Controls.Add(this.tbApellido, 1, 1);
            this.tl.Controls.Add(this.tbNombre, 1, 2);
            this.tl.Controls.Add(this.tbEmail, 1, 4);
            this.tl.Controls.Add(this.dtNacimiento, 1, 3);
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Location = new System.Drawing.Point(0, 0);
            this.tl.Name = "tl";
            this.tl.RowCount = 6;
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl.Size = new System.Drawing.Size(600, 200);
            this.tl.TabIndex = 0;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRut.Location = new System.Drawing.Point(3, 0);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(294, 26);
            this.lblRut.TabIndex = 0;
            this.lblRut.Text = "RUT:";
            this.lblRut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApellido.Location = new System.Drawing.Point(3, 26);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(294, 26);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(294, 26);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNacimiento.Location = new System.Drawing.Point(3, 78);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(294, 26);
            this.lblNacimiento.TabIndex = 3;
            this.lblNacimiento.Text = "Nacimiento:";
            this.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(3, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(294, 26);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRut
            // 
            this.tbRut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRut.Location = new System.Drawing.Point(303, 3);
            this.tbRut.Name = "tbRut";
            this.tbRut.Size = new System.Drawing.Size(294, 20);
            this.tbRut.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrear.Location = new System.Drawing.Point(3, 133);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(294, 64);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(303, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(294, 64);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbApellido
            // 
            this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApellido.Location = new System.Drawing.Point(303, 29);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(294, 20);
            this.tbApellido.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.Location = new System.Drawing.Point(303, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(294, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmail.Location = new System.Drawing.Point(303, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(294, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNacimiento.Location = new System.Drawing.Point(303, 81);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(294, 20);
            this.dtNacimiento.TabIndex = 8;
            // 
            // NuevaPersona
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.tl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaPersona";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Persona";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevaPersona_FormClosing);
            this.tl.ResumeLayout(false);
            this.tl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tl;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
    }
}