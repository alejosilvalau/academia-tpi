namespace UI.Desktop.Forms.Dictados
{
    partial class Dictados
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(750, 40);
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
            // dgvDocentes
            //
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.BackgroundColor = MaterialColors.Surface;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDocentes.ColumnHeadersHeight = 40;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Curso,
            this.Docente,
            this.Cargo});
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes.EnableHeadersVisualStyles = false;
            this.dgvDocentes.GridColor = MaterialColors.Border;
            this.dgvDocentes.Location = new System.Drawing.Point(0, 40);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.RowHeadersWidth = 51;
            this.dgvDocentes.RowTemplate.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvDocentes.RowTemplate.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvDocentes.RowTemplate.DefaultCellStyle.SelectionBackColor = MaterialColors.Primary;
            this.dgvDocentes.RowTemplate.DefaultCellStyle.SelectionForeColor = MaterialColors.TextOnPrimary;
            this.dgvDocentes.RowTemplate.Height = 35;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(750, 410);
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.TabIndex = 1;
            //
            // ID
            //
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 60;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            //
            // Curso
            //
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 200;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            //
            // Docente
            //
            this.Docente.DataPropertyName = "Docente";
            this.Docente.HeaderText = "Docente";
            this.Docente.MinimumWidth = 200;
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            //
            // Cargo
            //
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 120;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            //
            // Dictados
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dictados";
            this.Text = "Dictados";
            this.Load += new System.EventHandler(this.Dictados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}
