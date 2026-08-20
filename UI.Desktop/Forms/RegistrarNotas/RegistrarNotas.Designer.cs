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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelTop = new Panel();
            lblCurso = new Label();
            cbxCursos = new ComboBox();
            lblNota = new Label();
            txtNota = new TextBox();
            btnGuardar = new Button();
            dgvAlumnos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Legajo = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            FillSpacer = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblCurso);
            panelTop.Controls.Add(cbxCursos);
            panelTop.Controls.Add(lblNota);
            panelTop.Controls.Add(txtNota);
            panelTop.Controls.Add(btnGuardar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(20, 25, 20, 25);
            panelTop.Size = new Size(1435, 100);
            panelTop.TabIndex = 0;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 9F);
            lblCurso.ForeColor = Color.FromArgb(117, 117, 117);
            lblCurso.Location = new Point(20, 12);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(46, 20);
            lblCurso.TabIndex = 0;
            lblCurso.Text = "Curso";
            // 
            // cbxCursos
            // 
            cbxCursos.BackColor = Color.White;
            cbxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCursos.FlatStyle = FlatStyle.Flat;
            cbxCursos.Font = new Font("Segoe UI", 10F);
            cbxCursos.ForeColor = Color.FromArgb(33, 33, 33);
            cbxCursos.FormattingEnabled = true;
            cbxCursos.Location = new Point(20, 38);
            cbxCursos.Margin = new Padding(3, 4, 3, 4);
            cbxCursos.Name = "cbxCursos";
            cbxCursos.Size = new Size(350, 31);
            cbxCursos.TabIndex = 1;
            cbxCursos.SelectedIndexChanged += cbxCursos_SelectedIndexChanged;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 9F);
            lblNota.ForeColor = Color.FromArgb(117, 117, 117);
            lblNota.Location = new Point(400, 12);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(42, 20);
            lblNota.TabIndex = 2;
            lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.White;
            txtNota.BorderStyle = BorderStyle.FixedSingle;
            txtNota.Font = new Font("Segoe UI", 10F);
            txtNota.ForeColor = Color.FromArgb(33, 33, 33);
            txtNota.Location = new Point(400, 38);
            txtNota.Margin = new Padding(3, 4, 3, 4);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 30);
            txtNota.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 193, 7);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(33, 33, 33);
            btnGuardar.Location = new Point(530, 31);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 50);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Nota";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 239, 241);
            dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.BackgroundColor = Color.White;
            dgvAlumnos.BorderStyle = BorderStyle.None;
            dgvAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(69, 90, 100);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(69, 90, 100);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAlumnos.ColumnHeadersHeight = 40;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Legajo, Condicion, Nota, FillSpacer });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 193, 7);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.GridColor = Color.FromArgb(176, 190, 197);
            dgvAlumnos.Location = new Point(0, 100);
            dgvAlumnos.Margin = new Padding(3, 4, 3, 4);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(1435, 604);
            dgvAlumnos.TabIndex = 1;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 150;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 150;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Legajo";
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 100;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.HeaderText = "Condicion";
            Condicion.MinimumWidth = 120;
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 80;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // FillSpacer
            // 
            FillSpacer.HeaderText = "";
            FillSpacer.MinimumWidth = 6;
            FillSpacer.Name = "FillSpacer";
            FillSpacer.ReadOnly = true;
            FillSpacer.Resizable = DataGridViewTriState.False;
            // 
            // RegistrarNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1435, 704);
            Controls.Add(dgvAlumnos);
            Controls.Add(panelTop);
            Margin = new Padding(3, 5, 3, 5);
            Name = "RegistrarNotas";
            Text = "Registrar Notas";
            Load += RegistrarNotas_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
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
