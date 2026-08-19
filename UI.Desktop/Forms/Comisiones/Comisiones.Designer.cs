namespace UI.Desktop.Forms.Comisiones
{
    partial class Comisiones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            //
            // toolStrip1
            //
            this.toolStrip1.BackColor = MaterialColors.PrimaryDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            //
            // tsbAgregar
            //
            this.tsbAgregar.BackColor = MaterialColors.PrimaryDark;
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbAgregar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(27, 37);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            //
            // tsbEditar
            //
            this.tsbEditar.BackColor = MaterialColors.PrimaryDark;
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEditar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(47, 37);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            //
            // tsbEliminar
            //
            this.tsbEliminar.BackColor = MaterialColors.PrimaryDark;
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEliminar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(62, 37);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            //
            // dgvComisiones
            //
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.BackgroundColor = MaterialColors.Surface;
            this.dgvComisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComisiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComisiones.ColumnHeadersDefaultCellStyle.BackColor = MaterialColors.PrimaryDark;
            this.dgvComisiones.ColumnHeadersDefaultCellStyle.ForeColor = MaterialColors.TextOnPrimary;
            this.dgvComisiones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvComisiones.ColumnHeadersDefaultCellStyle.SelectionBackColor = MaterialColors.PrimaryDark;
            this.dgvComisiones.ColumnHeadersHeight = 40;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDescripcion,
            this.colAnioEspecialidad,
            this.colPlan});
            this.dgvComisiones.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvComisiones.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvComisiones.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvComisiones.DefaultCellStyle.SelectionBackColor = MaterialColors.Accent;
            this.dgvComisiones.DefaultCellStyle.SelectionForeColor = MaterialColors.TextPrimary;
            this.dgvComisiones.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.EnableHeadersVisualStyles = false;
            this.dgvComisiones.GridColor = MaterialColors.Border;
            this.dgvComisiones.Location = new System.Drawing.Point(0, 40);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersVisible = false;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(800, 410);
            this.dgvComisiones.TabIndex = 1;
            this.dgvComisiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            //
            // colID
            //
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            //
            // colDescripcion
            //
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            //
            // colAnioEspecialidad
            //
            this.colAnioEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAnioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.colAnioEspecialidad.HeaderText = "Año Especialidad";
            this.colAnioEspecialidad.Name = "colAnioEspecialidad";
            this.colAnioEspecialidad.ReadOnly = true;
            //
            // colPlan
            //
            this.colPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlan.DataPropertyName = "Plan";
            this.colPlan.HeaderText = "Plan";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            //
            // Comisiones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvComisiones);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
    }
}
