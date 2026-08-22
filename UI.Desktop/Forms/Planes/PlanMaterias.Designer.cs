namespace UI.Desktop.Forms.Planes
{
    partial class PlanMaterias
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStripMaestro = new System.Windows.Forms.ToolStrip();
            this.tsbAgregarPlan = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarPlan = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarPlan = new System.Windows.Forms.ToolStripButton();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.colPlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanFillSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripDetalle = new System.Windows.Forms.ToolStrip();
            this.tsbAgregarMateria = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarMateria = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarMateria = new System.Windows.Forms.ToolStripButton();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.colMateriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaHsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaHsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateriaFillSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.toolStripDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer.Panel1.Controls.Add(this.dgvPlanes);
            this.splitContainer.Panel1.Controls.Add(this.toolStripMaestro);
            this.splitContainer.Panel2.Controls.Add(this.dgvMaterias);
            this.splitContainer.Panel2.Controls.Add(this.toolStripDetalle);
            this.splitContainer.Size = new System.Drawing.Size(700, 500);
            this.splitContainer.SplitterDistance = 230;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 0;
            // 
            // toolStripMaestro
            // 
            this.toolStripMaestro.BackColor = MaterialColors.PrimaryDark;
            this.toolStripMaestro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMaestro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarPlan,
            this.tsbEditarPlan,
            this.tsbEliminarPlan});
            this.toolStripMaestro.Location = new System.Drawing.Point(0, 0);
            this.toolStripMaestro.Name = "toolStripMaestro";
            this.toolStripMaestro.Size = new System.Drawing.Size(700, 40);
            this.toolStripMaestro.TabIndex = 1;
            // 
            // tsbAgregarPlan
            // 
            this.tsbAgregarPlan.BackColor = MaterialColors.PrimaryDark;
            this.tsbAgregarPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAgregarPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbAgregarPlan.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbAgregarPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarPlan.Name = "tsbAgregarPlan";
            this.tsbAgregarPlan.Size = new System.Drawing.Size(42, 37);
            this.tsbAgregarPlan.Text = "Agregar";
            this.tsbAgregarPlan.Click += new System.EventHandler(this.tsbAgregarPlan_Click);
            // 
            // tsbEditarPlan
            // 
            this.tsbEditarPlan.BackColor = MaterialColors.PrimaryDark;
            this.tsbEditarPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditarPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEditarPlan.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEditarPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarPlan.Name = "tsbEditarPlan";
            this.tsbEditarPlan.Size = new System.Drawing.Size(55, 37);
            this.tsbEditarPlan.Text = "Editar";
            this.tsbEditarPlan.Click += new System.EventHandler(this.tsbEditarPlan_Click);
            // 
            // tsbEliminarPlan
            // 
            this.tsbEliminarPlan.BackColor = MaterialColors.PrimaryDark;
            this.tsbEliminarPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminarPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEliminarPlan.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEliminarPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarPlan.Name = "tsbEliminarPlan";
            this.tsbEliminarPlan.Size = new System.Drawing.Size(65, 37);
            this.tsbEliminarPlan.Text = "Eliminar";
            this.tsbEliminarPlan.Click += new System.EventHandler(this.tsbEliminarPlan_Click);
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.BackgroundColor = MaterialColors.Surface;
            this.dgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle.BackColor = MaterialColors.PrimaryDark;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPlanes.ColumnHeadersDefaultCellStyle.ForeColor = MaterialColors.TextOnPrimary;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle.SelectionBackColor = MaterialColors.PrimaryDark;
            this.dgvPlanes.ColumnHeadersHeight = 40;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlanID,
            this.colPlanDescripcion,
            this.colPlanEspecialidad,
            this.colPlanFillSpacer});
            this.dgvPlanes.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvPlanes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPlanes.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvPlanes.DefaultCellStyle.SelectionBackColor = MaterialColors.Accent;
            this.dgvPlanes.DefaultCellStyle.SelectionForeColor = MaterialColors.TextPrimary;
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanes.EnableHeadersVisualStyles = false;
            this.dgvPlanes.GridColor = MaterialColors.Border;
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersVisible = false;
            this.dgvPlanes.RowTemplate.Height = 35;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(700, 190);
            this.dgvPlanes.TabIndex = 0;
            this.dgvPlanes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellDoubleClick);
            this.dgvPlanes.SelectionChanged += new System.EventHandler(this.dgvPlanes_SelectionChanged);
            // 
            // colPlanID
            // 
            this.colPlanID.DataPropertyName = "ID";
            this.colPlanID.HeaderText = "ID";
            this.colPlanID.MinimumWidth = 60;
            this.colPlanID.Name = "colPlanID";
            this.colPlanID.ReadOnly = true;
            this.colPlanID.Width = 60;
            // 
            // colPlanDescripcion
            // 
            this.colPlanDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlanDescripcion.DataPropertyName = "Descripcion";
            this.colPlanDescripcion.HeaderText = "Descripción";
            this.colPlanDescripcion.MinimumWidth = 150;
            this.colPlanDescripcion.Name = "colPlanDescripcion";
            this.colPlanDescripcion.ReadOnly = true;
            // 
            // colPlanEspecialidad
            // 
            this.colPlanEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlanEspecialidad.DataPropertyName = "Especialidad";
            this.colPlanEspecialidad.HeaderText = "Especialidad";
            this.colPlanEspecialidad.MinimumWidth = 150;
            this.colPlanEspecialidad.Name = "colPlanEspecialidad";
            this.colPlanEspecialidad.ReadOnly = true;
            // 
            // colPlanFillSpacer
            // 
            this.colPlanFillSpacer.HeaderText = "";
            this.colPlanFillSpacer.MinimumWidth = 5;
            this.colPlanFillSpacer.Name = "colPlanFillSpacer";
            this.colPlanFillSpacer.ReadOnly = true;
            this.colPlanFillSpacer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // toolStripDetalle
            // 
            this.toolStripDetalle.BackColor = MaterialColors.PrimaryDark;
            this.toolStripDetalle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarMateria,
            this.tsbEditarMateria,
            this.tsbEliminarMateria});
            this.toolStripDetalle.Location = new System.Drawing.Point(0, 0);
            this.toolStripDetalle.Name = "toolStripDetalle";
            this.toolStripDetalle.Size = new System.Drawing.Size(700, 40);
            this.toolStripDetalle.TabIndex = 1;
            // 
            // tsbAgregarMateria
            // 
            this.tsbAgregarMateria.BackColor = MaterialColors.PrimaryDark;
            this.tsbAgregarMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAgregarMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbAgregarMateria.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbAgregarMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarMateria.Name = "tsbAgregarMateria";
            this.tsbAgregarMateria.Size = new System.Drawing.Size(42, 37);
            this.tsbAgregarMateria.Text = "Agregar";
            this.tsbAgregarMateria.Click += new System.EventHandler(this.tsbAgregarMateria_Click);
            // 
            // tsbEditarMateria
            // 
            this.tsbEditarMateria.BackColor = MaterialColors.PrimaryDark;
            this.tsbEditarMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditarMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEditarMateria.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEditarMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarMateria.Name = "tsbEditarMateria";
            this.tsbEditarMateria.Size = new System.Drawing.Size(55, 37);
            this.tsbEditarMateria.Text = "Editar";
            this.tsbEditarMateria.Click += new System.EventHandler(this.tsbEditarMateria_Click);
            // 
            // tsbEliminarMateria
            // 
            this.tsbEliminarMateria.BackColor = MaterialColors.PrimaryDark;
            this.tsbEliminarMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminarMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbEliminarMateria.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEliminarMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarMateria.Name = "tsbEliminarMateria";
            this.tsbEliminarMateria.Size = new System.Drawing.Size(65, 37);
            this.tsbEliminarMateria.Text = "Eliminar";
            this.tsbEliminarMateria.Click += new System.EventHandler(this.tsbEliminarMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.BackgroundColor = MaterialColors.Surface;
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle.BackColor = MaterialColors.PrimaryDark;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMaterias.ColumnHeadersDefaultCellStyle.ForeColor = MaterialColors.TextOnPrimary;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle.SelectionBackColor = MaterialColors.PrimaryDark;
            this.dgvMaterias.ColumnHeadersHeight = 40;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMateriaID,
            this.colMateriaDescripcion,
            this.colMateriaHsSemanales,
            this.colMateriaHsTotales,
            this.colMateriaFillSpacer});
            this.dgvMaterias.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvMaterias.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMaterias.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvMaterias.DefaultCellStyle.SelectionBackColor = MaterialColors.Accent;
            this.dgvMaterias.DefaultCellStyle.SelectionForeColor = MaterialColors.TextPrimary;
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.EnableHeadersVisualStyles = false;
            this.dgvMaterias.GridColor = MaterialColors.Border;
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.RowTemplate.Height = 35;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(700, 224);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
            // 
            // colMateriaID
            // 
            this.colMateriaID.DataPropertyName = "ID";
            this.colMateriaID.HeaderText = "ID";
            this.colMateriaID.MinimumWidth = 60;
            this.colMateriaID.Name = "colMateriaID";
            this.colMateriaID.ReadOnly = true;
            this.colMateriaID.Width = 60;
            // 
            // colMateriaDescripcion
            // 
            this.colMateriaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMateriaDescripcion.DataPropertyName = "Descripcion";
            this.colMateriaDescripcion.HeaderText = "Descripción";
            this.colMateriaDescripcion.MinimumWidth = 150;
            this.colMateriaDescripcion.Name = "colMateriaDescripcion";
            this.colMateriaDescripcion.ReadOnly = true;
            // 
            // colMateriaHsSemanales
            // 
            this.colMateriaHsSemanales.DataPropertyName = "HorasSemanales";
            this.colMateriaHsSemanales.HeaderText = "Hs Sem.";
            this.colMateriaHsSemanales.MinimumWidth = 80;
            this.colMateriaHsSemanales.Name = "colMateriaHsSemanales";
            this.colMateriaHsSemanales.ReadOnly = true;
            this.colMateriaHsSemanales.Width = 80;
            // 
            // colMateriaHsTotales
            // 
            this.colMateriaHsTotales.DataPropertyName = "HorasTotales";
            this.colMateriaHsTotales.HeaderText = "Hs Tot.";
            this.colMateriaHsTotales.MinimumWidth = 80;
            this.colMateriaHsTotales.Name = "colMateriaHsTotales";
            this.colMateriaHsTotales.ReadOnly = true;
            this.colMateriaHsTotales.Width = 80;
            // 
            // colMateriaFillSpacer
            // 
            this.colMateriaFillSpacer.HeaderText = "";
            this.colMateriaFillSpacer.MinimumWidth = 5;
            this.colMateriaFillSpacer.Name = "colMateriaFillSpacer";
            this.colMateriaFillSpacer.ReadOnly = true;
            this.colMateriaFillSpacer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PlanMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "PlanMaterias";
            this.Text = "Plan / Materias";
            this.Load += new System.EventHandler(this.PlanMaterias_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStripMaestro.ResumeLayout(false);
            this.toolStripMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.toolStripDetalle.ResumeLayout(false);
            this.toolStripDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStripMaestro;
        private System.Windows.Forms.ToolStripButton tsbAgregarPlan;
        private System.Windows.Forms.ToolStripButton tsbEditarPlan;
        private System.Windows.Forms.ToolStripButton tsbEliminarPlan;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanFillSpacer;
        private System.Windows.Forms.ToolStrip toolStripDetalle;
        private System.Windows.Forms.ToolStripButton tsbAgregarMateria;
        private System.Windows.Forms.ToolStripButton tsbEditarMateria;
        private System.Windows.Forms.ToolStripButton tsbEliminarMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaHsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaHsTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateriaFillSpacer;
    }
}
