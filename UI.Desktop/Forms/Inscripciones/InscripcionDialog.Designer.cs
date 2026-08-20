namespace UI.Desktop.Forms.Inscripciones
{
    partial class InscripcionDialog
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
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cbxCondicion = new System.Windows.Forms.ComboBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillSpacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.BackColor = MaterialColors.Surface;
            this.panelTop.Controls.Add(this.lblAlumno);
            this.panelTop.Controls.Add(this.txtAlumno);
            this.panelTop.Controls.Add(this.lblCondicion);
            this.panelTop.Controls.Add(this.cbxCondicion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(600, 80);
            this.panelTop.TabIndex = 0;
            //
            // lblAlumno
            //
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlumno.ForeColor = MaterialColors.TextSecondary;
            this.lblAlumno.Location = new System.Drawing.Point(20, 10);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(56, 15);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            //
            // txtAlumno
            //
            this.txtAlumno.BackColor = MaterialColors.ReadOnlyBack;
            this.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlumno.Enabled = false;
            this.txtAlumno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlumno.ForeColor = MaterialColors.TextPrimary;
            this.txtAlumno.Location = new System.Drawing.Point(20, 30);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(280, 30);
            this.txtAlumno.TabIndex = 1;
            //
            // lblCondicion
            //
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCondicion.ForeColor = MaterialColors.TextSecondary;
            this.lblCondicion.Location = new System.Drawing.Point(320, 10);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(64, 15);
            this.lblCondicion.TabIndex = 2;
            this.lblCondicion.Text = "Condición";
            //
            // cbxCondicion
            //
            this.cbxCondicion.BackColor = MaterialColors.Surface;
            this.cbxCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCondicion.ForeColor = MaterialColors.TextPrimary;
            this.cbxCondicion.FormattingEnabled = true;
            this.cbxCondicion.Location = new System.Drawing.Point(320, 30);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.Size = new System.Drawing.Size(260, 31);
            this.cbxCondicion.TabIndex = 3;
            //
            // dgvCursos
            //
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AlternatingRowsDefaultCellStyle.BackColor = MaterialColors.RowAlternate;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.BackgroundColor = MaterialColors.Surface;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCursos.ColumnHeadersHeight = 40;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.AnioCalendario,
            this.Cupo,
            this.Materia,
            this.Comision,
            this.FillSpacer});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = MaterialColors.Border;
            this.dgvCursos.Location = new System.Drawing.Point(0, 80);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.DefaultCellStyle.BackColor = MaterialColors.Surface;
            this.dgvCursos.RowTemplate.DefaultCellStyle.ForeColor = MaterialColors.TextPrimary;
            this.dgvCursos.RowTemplate.DefaultCellStyle.SelectionBackColor = MaterialColors.Primary;
            this.dgvCursos.RowTemplate.DefaultCellStyle.SelectionForeColor = MaterialColors.TextOnPrimary;
            this.dgvCursos.RowTemplate.Height = 35;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(600, 270);
            this.dgvCursos.TabIndex = 1;
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
            // Descripcion
            //
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 200;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            //
            // AnioCalendario
            //
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año";
            this.AnioCalendario.MinimumWidth = 80;
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            //
            // Cupo
            //
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.MinimumWidth = 80;
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            //
            // Materia
            //
            this.Materia.DataPropertyName = "Materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 150;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            //
            // Comision
            //
            this.Comision.DataPropertyName = "Comision";
            this.Comision.HeaderText = "Comision";
            this.Comision.MinimumWidth = 120;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            //
            // FillSpacer
            //
            this.FillSpacer.HeaderText = "";
            this.FillSpacer.MinimumWidth = 5;
            this.FillSpacer.Name = "FillSpacer";
            this.FillSpacer.ReadOnly = true;
            this.FillSpacer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // panelBotones
            //
            this.panelBotones.BackColor = MaterialColors.Background;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnAceptar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 350);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(600, 50);
            this.panelBotones.TabIndex = 2;
            //
            // btnAceptar
            //
            this.btnAceptar.BackColor = MaterialColors.Accent;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = MaterialColors.TextPrimary;
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(305, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 35);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = MaterialColors.CancelBtn;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(195, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // InscripcionDialog
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "InscripcionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripción";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cbxCondicion;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillSpacer;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
