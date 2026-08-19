namespace UI.Desktop.Forms.Cursos
{
    partial class CursoDesktop
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblID = new Label();
            txtID = new TextBox();
            lblAnioCalendario = new Label();
            txtAnioCalendario = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblCupo = new Label();
            txtCupo = new TextBox();
            lblMateria = new Label();
            cbxMateria = new ComboBox();
            lblComision = new Label();
            cbxComision = new ComboBox();
            panelBotones = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAnioCalendario, 2, 0);
            tableLayoutPanel1.Controls.Add(txtAnioCalendario, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescripcion, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCupo, 2, 1);
            tableLayoutPanel1.Controls.Add(txtCupo, 3, 1);
            tableLayoutPanel1.Controls.Add(lblMateria, 0, 2);
            tableLayoutPanel1.Controls.Add(cbxMateria, 1, 2);
            tableLayoutPanel1.Controls.Add(lblComision, 2, 2);
            tableLayoutPanel1.Controls.Add(cbxComision, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(560, 219);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(117, 117, 117);
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(114, 56);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Dock = DockStyle.Fill;
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.ForeColor = Color.FromArgb(33, 33, 33);
            txtID.Location = new Point(123, 4);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(154, 30);
            txtID.TabIndex = 1;
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.Dock = DockStyle.Fill;
            lblAnioCalendario.Font = new Font("Segoe UI", 10F);
            lblAnioCalendario.ForeColor = Color.FromArgb(117, 117, 117);
            lblAnioCalendario.Location = new Point(283, 0);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(114, 56);
            lblAnioCalendario.TabIndex = 2;
            lblAnioCalendario.Text = "Año Calendario";
            lblAnioCalendario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAnioCalendario
            // 
            txtAnioCalendario.BackColor = Color.White;
            txtAnioCalendario.BorderStyle = BorderStyle.FixedSingle;
            txtAnioCalendario.Dock = DockStyle.Fill;
            txtAnioCalendario.Font = new Font("Segoe UI", 10F);
            txtAnioCalendario.ForeColor = Color.FromArgb(33, 33, 33);
            txtAnioCalendario.Location = new Point(403, 4);
            txtAnioCalendario.Margin = new Padding(3, 4, 3, 4);
            txtAnioCalendario.Name = "txtAnioCalendario";
            txtAnioCalendario.Size = new Size(154, 30);
            txtAnioCalendario.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(117, 117, 117);
            lblDescripcion.Location = new Point(3, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(114, 56);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(33, 33, 33);
            txtDescripcion.Location = new Point(123, 60);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(154, 30);
            txtDescripcion.TabIndex = 5;
            // 
            // lblCupo
            // 
            lblCupo.Dock = DockStyle.Fill;
            lblCupo.Font = new Font("Segoe UI", 10F);
            lblCupo.ForeColor = Color.FromArgb(117, 117, 117);
            lblCupo.Location = new Point(283, 56);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(114, 56);
            lblCupo.TabIndex = 6;
            lblCupo.Text = "Cupo";
            lblCupo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCupo
            // 
            txtCupo.BackColor = Color.White;
            txtCupo.BorderStyle = BorderStyle.FixedSingle;
            txtCupo.Dock = DockStyle.Fill;
            txtCupo.Font = new Font("Segoe UI", 10F);
            txtCupo.ForeColor = Color.FromArgb(33, 33, 33);
            txtCupo.Location = new Point(403, 60);
            txtCupo.Margin = new Padding(3, 4, 3, 4);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(154, 30);
            txtCupo.TabIndex = 7;
            // 
            // lblMateria
            // 
            lblMateria.Dock = DockStyle.Fill;
            lblMateria.Font = new Font("Segoe UI", 10F);
            lblMateria.ForeColor = Color.FromArgb(117, 117, 117);
            lblMateria.Location = new Point(3, 112);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(114, 107);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "Materia";
            lblMateria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxMateria
            // 
            cbxMateria.BackColor = Color.White;
            cbxMateria.Dock = DockStyle.Fill;
            cbxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMateria.FlatStyle = FlatStyle.Flat;
            cbxMateria.Font = new Font("Segoe UI", 10F);
            cbxMateria.ForeColor = Color.FromArgb(33, 33, 33);
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new Point(123, 116);
            cbxMateria.Margin = new Padding(3, 4, 3, 4);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new Size(154, 31);
            cbxMateria.TabIndex = 9;
            cbxMateria.ValueMember = "ID";
            // 
            // lblComision
            // 
            lblComision.Dock = DockStyle.Fill;
            lblComision.Font = new Font("Segoe UI", 10F);
            lblComision.ForeColor = Color.FromArgb(117, 117, 117);
            lblComision.Location = new Point(283, 112);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(114, 107);
            lblComision.TabIndex = 10;
            lblComision.Text = "Comisión";
            lblComision.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxComision
            // 
            cbxComision.BackColor = Color.White;
            cbxComision.Dock = DockStyle.Fill;
            cbxComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxComision.FlatStyle = FlatStyle.Flat;
            cbxComision.Font = new Font("Segoe UI", 10F);
            cbxComision.ForeColor = Color.FromArgb(33, 33, 33);
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new Point(403, 116);
            cbxComision.Margin = new Padding(3, 4, 3, 4);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new Size(154, 31);
            cbxComision.TabIndex = 11;
            cbxComision.ValueMember = "ID";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 219);
            panelBotones.Margin = new Padding(3, 4, 3, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(560, 62);
            panelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(144, 164, 174);
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(360, 0);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 62);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 193, 7);
            btnAceptar.Dock = DockStyle.Right;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Location = new Point(460, 0);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 62);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CursoDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(560, 281);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBotones);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(3, 5, 3, 5);
            Name = "CursoDesktop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Curso";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAnioCalendario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
