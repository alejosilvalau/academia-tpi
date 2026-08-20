namespace UI.Desktop.Forms.Cursos
{
    partial class CursoDialog
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(txtAnioCalendario, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescripcion, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCupo, 2, 1);
            tableLayoutPanel1.Controls.Add(txtCupo, 3, 1);
            tableLayoutPanel1.Controls.Add(lblMateria, 0, 2);
            tableLayoutPanel1.Controls.Add(cbxMateria, 1, 2);
            tableLayoutPanel1.Controls.Add(lblComision, 2, 2);
            tableLayoutPanel1.Controls.Add(cbxComision, 3, 2);
            tableLayoutPanel1.Controls.Add(lblAnioCalendario, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 15, 20, 15);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(649, 185);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(117, 117, 117);
            lblID.Location = new Point(106, 31);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtID.BackColor = Color.FromArgb(238, 238, 238);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.ForeColor = Color.FromArgb(33, 33, 33);
            txtID.Location = new Point(143, 28);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(168, 30);
            txtID.TabIndex = 1;
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.Anchor = AnchorStyles.Right;
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Font = new Font("Segoe UI", 10F);
            lblAnioCalendario.ForeColor = Color.FromArgb(117, 117, 117);
            lblAnioCalendario.Location = new Point(319, 31);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(132, 23);
            lblAnioCalendario.TabIndex = 2;
            lblAnioCalendario.Text = "Año Calendario:";
            // 
            // txtAnioCalendario
            // 
            txtAnioCalendario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAnioCalendario.BackColor = Color.White;
            txtAnioCalendario.BorderStyle = BorderStyle.FixedSingle;
            txtAnioCalendario.Font = new Font("Segoe UI", 10F);
            txtAnioCalendario.ForeColor = Color.FromArgb(33, 33, 33);
            txtAnioCalendario.Location = new Point(457, 28);
            txtAnioCalendario.Margin = new Padding(3, 4, 3, 4);
            txtAnioCalendario.Name = "txtAnioCalendario";
            txtAnioCalendario.Size = new Size(169, 30);
            txtAnioCalendario.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(117, 117, 117);
            lblDescripcion.Location = new Point(35, 87);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(102, 23);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.FromArgb(238, 238, 238);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(33, 33, 33);
            txtDescripcion.Location = new Point(143, 84);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(168, 30);
            txtDescripcion.TabIndex = 5;
            // 
            // lblCupo
            // 
            lblCupo.Anchor = AnchorStyles.Right;
            lblCupo.AutoSize = true;
            lblCupo.Font = new Font("Segoe UI", 10F);
            lblCupo.ForeColor = Color.FromArgb(117, 117, 117);
            lblCupo.Location = new Point(396, 87);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(55, 23);
            lblCupo.TabIndex = 6;
            lblCupo.Text = "Cupo:";
            // 
            // txtCupo
            // 
            txtCupo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCupo.BackColor = Color.White;
            txtCupo.BorderStyle = BorderStyle.FixedSingle;
            txtCupo.Font = new Font("Segoe UI", 10F);
            txtCupo.ForeColor = Color.FromArgb(33, 33, 33);
            txtCupo.Location = new Point(457, 84);
            txtCupo.Margin = new Padding(3, 4, 3, 4);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(169, 30);
            txtCupo.TabIndex = 7;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.Right;
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 10F);
            lblMateria.ForeColor = Color.FromArgb(117, 117, 117);
            lblMateria.Location = new Point(65, 143);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(72, 23);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "Materia:";
            // 
            // cbxMateria
            // 
            cbxMateria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxMateria.BackColor = Color.White;
            cbxMateria.DisplayMember = "Descripcion";
            cbxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMateria.Font = new Font("Segoe UI", 10F);
            cbxMateria.ForeColor = Color.FromArgb(33, 33, 33);
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new Point(143, 139);
            cbxMateria.Margin = new Padding(3, 4, 3, 4);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new Size(168, 31);
            cbxMateria.TabIndex = 9;
            cbxMateria.ValueMember = "ID";
            // 
            // lblComision
            // 
            lblComision.Anchor = AnchorStyles.Right;
            lblComision.AutoSize = true;
            lblComision.Font = new Font("Segoe UI", 10F);
            lblComision.ForeColor = Color.FromArgb(117, 117, 117);
            lblComision.Location = new Point(366, 143);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(85, 23);
            lblComision.TabIndex = 10;
            lblComision.Text = "Comisión:";
            // 
            // cbxComision
            // 
            cbxComision.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxComision.BackColor = Color.White;
            cbxComision.DisplayMember = "Descripcion";
            cbxComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxComision.Font = new Font("Segoe UI", 10F);
            cbxComision.ForeColor = Color.FromArgb(33, 33, 33);
            cbxComision.FormattingEnabled = true;
            cbxComision.Location = new Point(457, 139);
            cbxComision.Margin = new Padding(3, 4, 3, 4);
            cbxComision.Name = "cbxComision";
            cbxComision.Size = new Size(169, 31);
            cbxComision.TabIndex = 11;
            cbxComision.ValueMember = "ID";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 185);
            panelBotones.Margin = new Padding(3, 4, 3, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(649, 60);
            panelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(144, 164, 174);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(219, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.BackColor = Color.FromArgb(255, 193, 7);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Location = new Point(329, 10);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 40);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CursoDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(649, 245);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBotones);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CursoDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Curso";
            Load += CursoDialog_Load;
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
