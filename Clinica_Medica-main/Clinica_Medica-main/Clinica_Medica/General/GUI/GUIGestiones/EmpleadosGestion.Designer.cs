namespace General.GUI
{
    partial class EmpleadosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Insertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.VistaPrevia = new System.Windows.Forms.ToolStripButton();
            this.dtbEmpleado = new System.Windows.Forms.DataGridView();
            this.ID_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSS_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbEmpleado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 87);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Empleados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Insertar,
            this.toolStripSeparator1,
            this.Modificar,
            this.toolStripSeparator2,
            this.Eliminar,
            this.txtFiltro,
            this.toolStripLabel1,
            this.VistaPrevia});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(35, 97);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1174, 48);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Insertar
            // 
            this.Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Insertar.Image")));
            this.Insertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(82, 45);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(97, 45);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.White;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 45);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFiltro.BackColor = System.Drawing.Color.Snow;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFiltro.Size = new System.Drawing.Size(250, 48);
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 45);
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("VistaPrevia.Image")));
            this.VistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VistaPrevia.Name = "VistaPrevia";
            this.VistaPrevia.Size = new System.Drawing.Size(105, 45);
            this.VistaPrevia.Text = "VistaPrevia";
            this.VistaPrevia.Click += new System.EventHandler(this.VistaPrevia_Click);
            // 
            // dtbEmpleado
            // 
            this.dtbEmpleado.AllowUserToAddRows = false;
            this.dtbEmpleado.AllowUserToDeleteRows = false;
            this.dtbEmpleado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dtbEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtbEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtbEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dtbEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtbEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtbEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtbEmpleado.ColumnHeadersHeight = 30;
            this.dtbEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtbEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_empleado,
            this.DUI_Empleado,
            this.ISSS_Empleado,
            this.NombresEmpleado,
            this.ApellidosEmpleado,
            this.TelefonoEmpleado,
            this.FechaNacEmpleado,
            this.Correo,
            this.Cargo,
            this.Linea1,
            this.Linea2,
            this.ID_Cargo,
            this.ID_Direccion});
            this.dtbEmpleado.EnableHeadersVisualStyles = false;
            this.dtbEmpleado.GridColor = System.Drawing.SystemColors.Control;
            this.dtbEmpleado.Location = new System.Drawing.Point(36, 159);
            this.dtbEmpleado.MultiSelect = false;
            this.dtbEmpleado.Name = "dtbEmpleado";
            this.dtbEmpleado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtbEmpleado.RowHeadersVisible = false;
            this.dtbEmpleado.RowHeadersWidth = 51;
            this.dtbEmpleado.RowTemplate.Height = 24;
            this.dtbEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbEmpleado.Size = new System.Drawing.Size(1174, 441);
            this.dtbEmpleado.TabIndex = 6;
            // 
            // ID_empleado
            // 
            this.ID_empleado.DataPropertyName = "ID_empleado";
            this.ID_empleado.HeaderText = "ID";
            this.ID_empleado.MinimumWidth = 6;
            this.ID_empleado.Name = "ID_empleado";
            this.ID_empleado.ReadOnly = true;
            this.ID_empleado.Width = 55;
            // 
            // DUI_Empleado
            // 
            this.DUI_Empleado.DataPropertyName = "DUI_Empleado";
            this.DUI_Empleado.HeaderText = "DUI";
            this.DUI_Empleado.MinimumWidth = 6;
            this.DUI_Empleado.Name = "DUI_Empleado";
            this.DUI_Empleado.ReadOnly = true;
            this.DUI_Empleado.Width = 67;
            // 
            // ISSS_Empleado
            // 
            this.ISSS_Empleado.DataPropertyName = "ISSS_Empleado";
            this.ISSS_Empleado.HeaderText = "ISSS";
            this.ISSS_Empleado.MinimumWidth = 6;
            this.ISSS_Empleado.Name = "ISSS_Empleado";
            this.ISSS_Empleado.ReadOnly = true;
            this.ISSS_Empleado.Width = 70;
            // 
            // NombresEmpleado
            // 
            this.NombresEmpleado.DataPropertyName = "NombresEmpleado";
            this.NombresEmpleado.HeaderText = "Nombre";
            this.NombresEmpleado.MinimumWidth = 6;
            this.NombresEmpleado.Name = "NombresEmpleado";
            this.NombresEmpleado.ReadOnly = true;
            this.NombresEmpleado.Width = 101;
            // 
            // ApellidosEmpleado
            // 
            this.ApellidosEmpleado.DataPropertyName = "ApellidosEmpleado";
            this.ApellidosEmpleado.HeaderText = "Apellido";
            this.ApellidosEmpleado.MinimumWidth = 6;
            this.ApellidosEmpleado.Name = "ApellidosEmpleado";
            this.ApellidosEmpleado.ReadOnly = true;
            // 
            // TelefonoEmpleado
            // 
            this.TelefonoEmpleado.DataPropertyName = "TelefonoEmpleado";
            this.TelefonoEmpleado.HeaderText = "Telefono";
            this.TelefonoEmpleado.MinimumWidth = 6;
            this.TelefonoEmpleado.Name = "TelefonoEmpleado";
            this.TelefonoEmpleado.ReadOnly = true;
            this.TelefonoEmpleado.Width = 103;
            // 
            // FechaNacEmpleado
            // 
            this.FechaNacEmpleado.DataPropertyName = "FechaNacEmpleado";
            this.FechaNacEmpleado.HeaderText = "FechaNacimiento";
            this.FechaNacEmpleado.MinimumWidth = 6;
            this.FechaNacEmpleado.Name = "FechaNacEmpleado";
            this.FechaNacEmpleado.ReadOnly = true;
            this.FechaNacEmpleado.Width = 171;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 90;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 84;
            // 
            // Linea1
            // 
            this.Linea1.DataPropertyName = "Linea1";
            this.Linea1.HeaderText = "Linea1";
            this.Linea1.MinimumWidth = 6;
            this.Linea1.Name = "Linea1";
            this.Linea1.ReadOnly = true;
            this.Linea1.Width = 85;
            // 
            // Linea2
            // 
            this.Linea2.DataPropertyName = "Linea2";
            this.Linea2.HeaderText = "Linea2";
            this.Linea2.MinimumWidth = 6;
            this.Linea2.Name = "Linea2";
            this.Linea2.ReadOnly = true;
            this.Linea2.Width = 87;
            // 
            // ID_Cargo
            // 
            this.ID_Cargo.DataPropertyName = "ID_Cargo";
            this.ID_Cargo.HeaderText = "ID_Cargo";
            this.ID_Cargo.MinimumWidth = 6;
            this.ID_Cargo.Name = "ID_Cargo";
            this.ID_Cargo.ReadOnly = true;
            this.ID_Cargo.Width = 108;
            // 
            // ID_Direccion
            // 
            this.ID_Direccion.DataPropertyName = "ID_Direccion";
            this.ID_Direccion.HeaderText = "ID_Direccion";
            this.ID_Direccion.MinimumWidth = 6;
            this.ID_Direccion.Name = "ID_Direccion";
            this.ID_Direccion.ReadOnly = true;
            this.ID_Direccion.Width = 133;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalEmpleados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1245, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "Número de Doctores:";
            // 
            // TotalEmpleados
            // 
            this.TotalEmpleados.Name = "TotalEmpleados";
            this.TotalEmpleados.Size = new System.Drawing.Size(17, 20);
            this.TotalEmpleados.Text = "0";
            this.TotalEmpleados.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // EmpleadosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 629);
            this.Controls.Add(this.dtbEmpleado);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "EmpleadosGestion";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.EmpleadosGestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbEmpleado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Insertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtbEmpleado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalEmpleados;
        private System.Windows.Forms.ToolStripButton VistaPrevia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSS_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Direccion;
        private System.Windows.Forms.Label label3;
    }
}