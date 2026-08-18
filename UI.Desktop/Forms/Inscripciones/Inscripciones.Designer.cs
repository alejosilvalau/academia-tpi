namespace UI.Desktop.Forms.Inscripciones
{
    partial class Inscripciones
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
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // toolStrip1
            //
            this.toolStrip1.BackColor = MaterialColors.PrimaryDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 40);
            this.toolStrip1.TabIndex = 0;
            //
            // tsbAgregar
            //
            this.tsbAgregar.BackColor = MaterialColors.PrimaryDark;
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbAgregar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(35, 37);
            this.tsbAgregar.Text = "+";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            //
            // tsbEditar
            //
            this.tsbEditar.BackColor = MaterialColors.PrimaryDark;
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEditar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(55, 37);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            //
            // tsbEliminar
            //
            this.tsbEliminar.BackColor = MaterialColors.PrimaryDark;
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEliminar.ForeColor = MaterialColors.TextOnPrimary;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(65, 37);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            //
            // dgvInscripciones
            //
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscripciones.BackgroundColor = MaterialColors.Surface;
            this.dgvInscripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInscripciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInscripciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInscripciones.ColumnHeadersHeight = 40;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DescripcionMateria,
            this.Condicion,
            this.Nota,
            this.Legajo});
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.EnableHeadersVisualStyles = false;
            this.dgvInscripciones.GridColor = MaterialColors.Border;
            this.dgvInscripciones.Location = new System.Drawing.Point(0, 40);
            this.dgvInscripciones.MultiSelect = false;
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.RowHeadersVisible = false;
            this.dgvInscripciones.RowHeadersWidth = 51;
            this.dgvInscripciones.RowTemplate.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvInscripciones.RowTemplate.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvInscripciones.RowTemplate.DefaultCellStyle.SelectionBackColor = MaterialColors.Primary;
            this.dgvInscripciones.RowTemplate.DefaultCellStyle.SelectionForeColor = MaterialColors.TextOnPrimary;
            this.dgvInscripciones.RowTemplate.Height = 35;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(800, 410);
            this.dgvInscripciones.TabIndex = 1;
            //
            // ID
            //
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            //
            // DescripcionMateria
            //
            this.DescripcionMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionMateria.DataPropertyName = "DescripcionMateria";
            this.DescripcionMateria.HeaderText = "Materia";
            this.DescripcionMateria.MinimumWidth = 200;
            this.DescripcionMateria.Name = "DescripcionMateria";
            this.DescripcionMateria.ReadOnly = true;
            //
            // Condicion
            //
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.MinimumWidth = 120;
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            //
            // Nota
            //
            this.Nota.DataPropertyName = "Nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 80;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            //
            // Legajo
            //
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 100;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            //
            // Inscripciones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInscripciones);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.Inscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}
