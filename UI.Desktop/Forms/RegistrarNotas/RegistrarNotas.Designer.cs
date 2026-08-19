namespace UI.Desktop.Forms.RegistrarNotas
{
    partial class RegistrarNotas
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.BackColor = MaterialColors.Surface;
            this.panelTop.Controls.Add(this.lblCurso);
            this.panelTop.Controls.Add(this.cbxCursos);
            this.panelTop.Controls.Add(this.lblNota);
            this.panelTop.Controls.Add(this.txtNota);
            this.panelTop.Controls.Add(this.btnGuardar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(800, 80);
            this.panelTop.TabIndex = 0;
            //
            // lblCurso
            //
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurso.ForeColor = MaterialColors.TextSecondary;
            this.lblCurso.Location = new System.Drawing.Point(20, 10);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(42, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            //
            // cbxCursos
            //
            this.cbxCursos.BackColor = MaterialColors.Surface;
            this.cbxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCursos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCursos.ForeColor = MaterialColors.TextPrimary;
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(20, 30);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(350, 31);
            this.cbxCursos.TabIndex = 1;
            this.cbxCursos.SelectedIndexChanged += new System.EventHandler(this.cbxCursos_SelectedIndexChanged);
            //
            // lblNota
            //
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNota.ForeColor = MaterialColors.TextSecondary;
            this.lblNota.Location = new System.Drawing.Point(400, 10);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(36, 15);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Nota";
            //
            // txtNota
            //
            this.txtNota.BackColor = MaterialColors.Surface;
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNota.ForeColor = MaterialColors.TextPrimary;
            this.txtNota.Location = new System.Drawing.Point(400, 30);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 30);
            this.txtNota.TabIndex = 3;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = MaterialColors.Accent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = MaterialColors.TextPrimary;
            this.btnGuardar.Location = new System.Drawing.Point(530, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Nota";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // dgvAlumnos
            //
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = MaterialColors.Surface;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnos.ColumnHeadersHeight = 40;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.BackColor = MaterialColors.PrimaryDark;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.ForeColor = MaterialColors.TextOnPrimary;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle.SelectionBackColor = MaterialColors.PrimaryDark;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Legajo,
            this.Condicion,
            this.Nota,
            this.FillSpacer});
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.GridColor = MaterialColors.Border;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 80);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvAlumnos.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvAlumnos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvAlumnos.DefaultCellStyle.SelectionBackColor = MaterialColors.Accent;
            this.dgvAlumnos.DefaultCellStyle.SelectionForeColor = MaterialColors.TextPrimary;
            this.dgvAlumnos.RowTemplate.Height = 35;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(800, 420);
            this.dgvAlumnos.TabIndex = 1;
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
            // Nombre
            //
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            //
            // Apellido
            //
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 150;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            //
            // Legajo
            //
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 100;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
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
            // FillSpacer
            //
            this.FillSpacer.HeaderText = "";
            this.FillSpacer.MinimumWidth = 5;
            this.FillSpacer.Name = "FillSpacer";
            this.FillSpacer.ReadOnly = true;
            this.FillSpacer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // RegistrarNotas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.panelTop);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "RegistrarNotas";
            this.Text = "Registrar Notas";
            this.Load += new System.EventHandler(this.RegistrarNotas_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillSpacer;
    }
}
