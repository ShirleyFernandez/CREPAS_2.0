
namespace CREPAS_2._0
{
    partial class PEDIDOS_PRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEDIDOS_PRINCIPAL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tomarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosCocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCuentasAbiertasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elRinconcitoDataSet5 = new CREPAS_2._0.ElRinconcitoDataSet5();
            this.label2 = new System.Windows.Forms.Label();
            this.mesas_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.view_CuentasAbiertasTableAdapter = new CREPAS_2._0.ElRinconcitoDataSet5TableAdapters.View_CuentasAbiertasTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCuentasAbiertasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elRinconcitoDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.tomarPedidoToolStripMenuItem,
            this.pedidosCocinaToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // tomarPedidoToolStripMenuItem
            // 
            this.tomarPedidoToolStripMenuItem.Name = "tomarPedidoToolStripMenuItem";
            this.tomarPedidoToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.tomarPedidoToolStripMenuItem.Text = "Tomar Pedido";
            this.tomarPedidoToolStripMenuItem.Click += new System.EventHandler(this.tomarPedidoToolStripMenuItem_Click);
            // 
            // pedidosCocinaToolStripMenuItem
            // 
            this.pedidosCocinaToolStripMenuItem.Name = "pedidosCocinaToolStripMenuItem";
            this.pedidosCocinaToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.pedidosCocinaToolStripMenuItem.Text = "Pedidos Cocina";
            this.pedidosCocinaToolStripMenuItem.Click += new System.EventHandler(this.pedidosCocinaToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarNuevoUsuarioToolStripMenuItem
            // 
            this.agregarNuevoUsuarioToolStripMenuItem.Name = "agregarNuevoUsuarioToolStripMenuItem";
            this.agregarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.agregarNuevoUsuarioToolStripMenuItem.Text = "Agregar nuevo usuario";
            this.agregarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Editar usuario";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.salirToolStripMenuItem.Text = "Eliminar usuario";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, -21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "CANTIDAD:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 551);
            this.panel1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 72);
            this.label10.TabIndex = 3;
            this.label10.Text = "Hola, aqui puedes\r\nver los pedidos \r\npendientes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = " PEDIDOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuentaDataGridViewTextBoxColumn,
            this.mesaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewCuentasAbiertasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(377, 203);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(365, 309);
            this.dataGridView1.TabIndex = 31;
            // 
            // idCuentaDataGridViewTextBoxColumn
            // 
            this.idCuentaDataGridViewTextBoxColumn.DataPropertyName = "idCuenta";
            this.idCuentaDataGridViewTextBoxColumn.HeaderText = "idCuenta";
            this.idCuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCuentaDataGridViewTextBoxColumn.Name = "idCuentaDataGridViewTextBoxColumn";
            this.idCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCuentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesaDataGridViewTextBoxColumn
            // 
            this.mesaDataGridViewTextBoxColumn.DataPropertyName = "mesa";
            this.mesaDataGridViewTextBoxColumn.HeaderText = "mesa";
            this.mesaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesaDataGridViewTextBoxColumn.Name = "mesaDataGridViewTextBoxColumn";
            this.mesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesaDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewCuentasAbiertasBindingSource
            // 
            this.viewCuentasAbiertasBindingSource.DataMember = "View_CuentasAbiertas";
            this.viewCuentasAbiertasBindingSource.DataSource = this.elRinconcitoDataSet5;
            // 
            // elRinconcitoDataSet5
            // 
            this.elRinconcitoDataSet5.DataSetName = "ElRinconcitoDataSet5";
            this.elRinconcitoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "MESAS ABIERTAS";
            // 
            // mesas_box
            // 
            this.mesas_box.FormattingEnabled = true;
            this.mesas_box.Location = new System.Drawing.Point(323, 112);
            this.mesas_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mesas_box.Name = "mesas_box";
            this.mesas_box.Size = new System.Drawing.Size(249, 24);
            this.mesas_box.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 25);
            this.button1.TabIndex = 34;
            this.button1.Text = "AGREGAR MESA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Agregar nueva mesa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Entrar a mesa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_CuentasAbiertasTableAdapter
            // 
            this.view_CuentasAbiertasTableAdapter.ClearBeforeFill = true;
            // 
            // PEDIDOS_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(827, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mesas_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PEDIDOS_PRINCIPAL";
            this.Load += new System.EventHandler(this.PEDIDOS_PRINCIPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCuentasAbiertasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elRinconcitoDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tomarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosCocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mesas_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private ElRinconcitoDataSet5 elRinconcitoDataSet5;
        private System.Windows.Forms.BindingSource viewCuentasAbiertasBindingSource;
        private ElRinconcitoDataSet5TableAdapters.View_CuentasAbiertasTableAdapter view_CuentasAbiertasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDataGridViewTextBoxColumn;
    }
}