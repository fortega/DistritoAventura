namespace POS
{
    partial class BuscarPersona
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
            this.components = new System.ComponentModel.Container();
            this.gv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimeContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tlMain.SuspendLayout();
            this.tlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.ContextMenuStrip = this.contextMenuStrip1;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(3, 3);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(586, 322);
            this.gv.TabIndex = 0;
            this.gv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gv_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimeContratoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            // 
            // imprimeContratoToolStripMenuItem
            // 
            this.imprimeContratoToolStripMenuItem.Name = "imprimeContratoToolStripMenuItem";
            this.imprimeContratoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.imprimeContratoToolStripMenuItem.Text = "Imprime Contrato";
            this.imprimeContratoToolStripMenuItem.Click += new System.EventHandler(this.imprimeContratoToolStripMenuItem_Click);
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.gv, 0, 0);
            this.tlMain.Controls.Add(this.tlBotones, 0, 1);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlMain.Size = new System.Drawing.Size(592, 376);
            this.tlMain.TabIndex = 2;
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 2;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Controls.Add(this.btnSeleccionar, 0, 0);
            this.tlBotones.Controls.Add(this.btnContrato, 1, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(3, 331);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBotones.Size = new System.Drawing.Size(586, 42);
            this.tlBotones.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionar.Location = new System.Drawing.Point(3, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(287, 36);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContrato.Location = new System.Drawing.Point(296, 3);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(287, 36);
            this.btnContrato.TabIndex = 1;
            this.btnContrato.Text = "Reimprime Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.imprimeContratoToolStripMenuItem_Click);
            // 
            // BuscarPersona
            // 
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 376);
            this.Controls.Add(this.tlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "BuscarPersona";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Persona";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tlMain.ResumeLayout(false);
            this.tlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimeContratoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnContrato;


    }
}