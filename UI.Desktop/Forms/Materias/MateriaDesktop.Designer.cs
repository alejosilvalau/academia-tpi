namespace UI.Desktop.Forms.Materias
{
    partial class MateriaDesktop
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
            lblHsSemanales = new Label();
            txtHsSemanales = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblHsTotales = new Label();
            txtHsTotales = new TextBox();
            lblPlan = new Label();
            cbxPlan = new ComboBox();
            panelBottom = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(lblHsSemanales, 2, 0);
            tableLayoutPanel1.Controls.Add(txtHsSemanales, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescripcion, 1, 1);
            tableLayoutPanel1.Controls.Add(lblHsTotales, 2, 1);
            tableLayoutPanel1.Controls.Add(txtHsTotales, 3, 1);
            tableLayoutPanel1.Controls.Add(lblPlan, 0, 2);
            tableLayoutPanel1.Controls.Add(cbxPlan, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 19, 20, 19);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(580, 178);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(33, 33, 33);
            lblID.Location = new Point(69, 30);
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
            txtID.ForeColor = Color.FromArgb(117, 117, 117);
            txtID.Location = new Point(106, 26);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(147, 30);
            txtID.TabIndex = 1;
            // 
            // lblHsSemanales
            // 
            lblHsSemanales.Anchor = AnchorStyles.Right;
            lblHsSemanales.AutoSize = true;
            lblHsSemanales.Font = new Font("Segoe UI", 10F);
            lblHsSemanales.ForeColor = Color.FromArgb(33, 33, 33);
            lblHsSemanales.Location = new Point(259, 30);
            lblHsSemanales.Name = "lblHsSemanales";
            lblHsSemanales.Size = new Size(144, 23);
            lblHsSemanales.TabIndex = 2;
            lblHsSemanales.Text = "Horas Semanales:";
            // 
            // txtHsSemanales
            // 
            txtHsSemanales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHsSemanales.BackColor = Color.White;
            txtHsSemanales.BorderStyle = BorderStyle.FixedSingle;
            txtHsSemanales.Font = new Font("Segoe UI", 10F);
            txtHsSemanales.ForeColor = Color.FromArgb(33, 33, 33);
            txtHsSemanales.Location = new Point(409, 26);
            txtHsSemanales.Margin = new Padding(3, 4, 3, 4);
            txtHsSemanales.Name = "txtHsSemanales";
            txtHsSemanales.Size = new Size(148, 30);
            txtHsSemanales.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(33, 33, 33);
            lblDescripcion.Location = new Point(23, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 23);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(33, 33, 33);
            txtDescripcion.Location = new Point(106, 71);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(147, 30);
            txtDescripcion.TabIndex = 5;
            // 
            // lblHsTotales
            // 
            lblHsTotales.Anchor = AnchorStyles.Right;
            lblHsTotales.AutoSize = true;
            lblHsTotales.Font = new Font("Segoe UI", 10F);
            lblHsTotales.ForeColor = Color.FromArgb(33, 33, 33);
            lblHsTotales.Location = new Point(288, 75);
            lblHsTotales.Name = "lblHsTotales";
            lblHsTotales.Size = new Size(115, 23);
            lblHsTotales.TabIndex = 6;
            lblHsTotales.Text = "Horas Totales:";
            // 
            // txtHsTotales
            // 
            txtHsTotales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHsTotales.BackColor = Color.White;
            txtHsTotales.BorderStyle = BorderStyle.FixedSingle;
            txtHsTotales.Font = new Font("Segoe UI", 10F);
            txtHsTotales.ForeColor = Color.FromArgb(33, 33, 33);
            txtHsTotales.Location = new Point(409, 71);
            txtHsTotales.Margin = new Padding(3, 4, 3, 4);
            txtHsTotales.Name = "txtHsTotales";
            txtHsTotales.Size = new Size(148, 30);
            txtHsTotales.TabIndex = 7;
            // 
            // lblPlan
            // 
            lblPlan.Anchor = AnchorStyles.Right;
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 10F);
            lblPlan.ForeColor = Color.FromArgb(33, 33, 33);
            lblPlan.Location = new Point(53, 122);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(47, 23);
            lblPlan.TabIndex = 8;
            lblPlan.Text = "Plan:";
            // 
            // cbxPlan
            // 
            cbxPlan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbxPlan.BackColor = Color.White;
            tableLayoutPanel1.SetColumnSpan(cbxPlan, 3);
            cbxPlan.DisplayMember = "Descripcion";
            cbxPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPlan.Font = new Font("Segoe UI", 10F);
            cbxPlan.ForeColor = Color.FromArgb(33, 33, 33);
            cbxPlan.FormattingEnabled = true;
            cbxPlan.Location = new Point(106, 118);
            cbxPlan.Margin = new Padding(3, 4, 3, 4);
            cbxPlan.Name = "cbxPlan";
            cbxPlan.Size = new Size(451, 31);
            cbxPlan.TabIndex = 9;
            cbxPlan.ValueMember = "ID";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(245, 245, 245);
            panelBottom.Controls.Add(btnCancelar);
            panelBottom.Controls.Add(btnAceptar);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 178);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(580, 56);
            panelBottom.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(144, 164, 174);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 90, 100);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(185, 6);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 44);
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
            btnAceptar.Location = new Point(295, 6);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 44);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // MateriaDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(580, 234);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBottom);
            Margin = new Padding(3, 5, 3, 5);
            Name = "MateriaDesktop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Materia";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblHsSemanales;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}
