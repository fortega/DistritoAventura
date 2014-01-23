namespace POS
{
    partial class MantItems
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.tlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.dg, 0, 0);
            this.tlMain.Controls.Add(this.tlBotones, 0, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlMain.Size = new System.Drawing.Size(592, 376);
            this.tlMain.TabIndex = 0;
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
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(586, 322);
            this.dg.TabIndex = 0;
            this.dg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dg_MouseDoubleClick);
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 2;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Controls.Add(this.btnNuevo, 0, 0);
            this.tlBotones.Controls.Add(this.btnEditar, 1, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(3, 331);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Size = new System.Drawing.Size(586, 42);
            this.tlBotones.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(287, 36);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Location = new System.Drawing.Point(296, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(287, 36);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // MantItems
            // 
            this.AcceptButton = this.btnNuevo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 376);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MantItems";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenedor Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantItems_FormClosing);
            this.tlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.tlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
    }
}