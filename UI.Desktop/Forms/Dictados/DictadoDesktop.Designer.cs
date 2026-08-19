namespace UI.Desktop.Forms.Dictados
{
    partial class DictadoDesktop
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
            lblCurso = new Label();
            cbxCursos = new ComboBox();
            lblDocente = new Label();
            cbxDocentes = new ComboBox();
            lblCargo = new Label();
            cbxTiposCargos = new ComboBox();
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCurso, 0, 1);
            tableLayoutPanel1.Controls.Add(cbxCursos, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDocente, 0, 2);
            tableLayoutPanel1.Controls.Add(cbxDocentes, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCargo, 0, 3);
            tableLayoutPanel1.Controls.Add(cbxTiposCargos, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 15, 20, 15);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(460, 276);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(117, 117, 117);
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(114, 56);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = MaterialColors.ReadOnlyBack;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.ForeColor = Color.FromArgb(33, 33, 33);
            txtID.Location = new Point(123, 4);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(334, 30);
            txtID.TabIndex = 1;
            // 
            // lblCurso
            // 
            lblCurso.Anchor = AnchorStyles.Right;
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 10F);
            lblCurso.ForeColor = Color.FromArgb(117, 117, 117);
            lblCurso.Location = new Point(3, 56);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(114, 56);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso:";
            // 
            // cbxCursos
            // 
            cbxCursos.BackColor = Color.White;
            cbxCursos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCursos.Font = new Font("Segoe UI", 10F);
            cbxCursos.ForeColor = Color.FromArgb(33, 33, 33);
            cbxCursos.FormattingEnabled = true;
            cbxCursos.Location = new Point(123, 60);
            cbxCursos.Margin = new Padding(3, 4, 3, 4);
            cbxCursos.Name = "cbxCursos";
            cbxCursos.Size = new Size(334, 31);
            cbxCursos.TabIndex = 3;
            cbxCursos.DisplayMember = "Descripcion";
            cbxCursos.ValueMember = "ID";
            // 
            // lblDocente
            // 
            lblDocente.Anchor = AnchorStyles.Right;
            lblDocente.AutoSize = true;
            lblDocente.Font = new Font("Segoe UI", 10F);
            lblDocente.ForeColor = Color.FromArgb(117, 117, 117);
            lblDocente.Location = new Point(3, 112);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(114, 56);
            lblDocente.TabIndex = 4;
            lblDocente.Text = "Docente:";
            // 
            // cbxDocentes
            // 
            cbxDocentes.BackColor = Color.White;
            cbxDocentes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxDocentes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDocentes.Font = new Font("Segoe UI", 10F);
            cbxDocentes.ForeColor = Color.FromArgb(33, 33, 33);
            cbxDocentes.FormattingEnabled = true;
            cbxDocentes.Location = new Point(123, 116);
            cbxDocentes.Margin = new Padding(3, 4, 3, 4);
            cbxDocentes.Name = "cbxDocentes";
            cbxDocentes.Size = new Size(334, 31);
            cbxDocentes.TabIndex = 5;
            cbxDocentes.DisplayMember = "NombreCompleto";
            cbxDocentes.ValueMember = "ID";
            // 
            // lblCargo
            // 
            lblCargo.Anchor = AnchorStyles.Right;
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 10F);
            lblCargo.ForeColor = Color.FromArgb(117, 117, 117);
            lblCargo.Location = new Point(3, 168);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(114, 108);
            lblCargo.TabIndex = 6;
            lblCargo.Text = "Cargo:";
            // 
            // cbxTiposCargos
            // 
            cbxTiposCargos.BackColor = Color.White;
            cbxTiposCargos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxTiposCargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTiposCargos.Font = new Font("Segoe UI", 10F);
            cbxTiposCargos.ForeColor = Color.FromArgb(33, 33, 33);
            cbxTiposCargos.FormattingEnabled = true;
            cbxTiposCargos.Location = new Point(123, 172);
            cbxTiposCargos.Margin = new Padding(3, 4, 3, 4);
            cbxTiposCargos.Name = "cbxTiposCargos";
            cbxTiposCargos.Size = new Size(334, 31);
            cbxTiposCargos.TabIndex = 7;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 276);
            panelBotones.Margin = new Padding(3, 4, 3, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(460, 60);
            panelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(144, 164, 174);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 144, 156);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(125, 10);
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 193, 7);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Location = new Point(235, 10);
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 40);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // DictadoDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(460, 338);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBotones);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(3, 5, 3, 5);
            Name = "DictadoDesktop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dictado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.ComboBox cbxDocentes;
        private System.Windows.Forms.ComboBox cbxTiposCargos;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
