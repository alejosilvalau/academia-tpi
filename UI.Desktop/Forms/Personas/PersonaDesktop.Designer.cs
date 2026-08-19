namespace UI.Desktop.Forms.Personas
{
    partial class PersonaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = MaterialColors.Surface;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLegajo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLegajo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEMail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEMail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDireccion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTipo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxPlan, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNacimiento, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNacimiento, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblID.ForeColor = MaterialColors.TextSecondary;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(134, 45);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.BackColor = MaterialColors.Surface;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.ForeColor = MaterialColors.TextPrimary;
            this.txtID.Location = new System.Drawing.Point(143, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(134, 30);
            this.txtID.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.ForeColor = MaterialColors.TextSecondary;
            this.lblNombre.Location = new System.Drawing.Point(283, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 45);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BackColor = MaterialColors.Surface;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = MaterialColors.TextPrimary;
            this.txtNombre.Location = new System.Drawing.Point(423, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApellido.ForeColor = MaterialColors.TextSecondary;
            this.lblApellido.Location = new System.Drawing.Point(3, 45);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(134, 45);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.BackColor = MaterialColors.Surface;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.ForeColor = MaterialColors.TextPrimary;
            this.txtApellido.Location = new System.Drawing.Point(143, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 30);
            this.txtApellido.TabIndex = 5;
            // 
            // lblLegajo
            // 
            this.lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLegajo.ForeColor = MaterialColors.TextSecondary;
            this.lblLegajo.Location = new System.Drawing.Point(283, 45);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(134, 45);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLegajo.BackColor = MaterialColors.Surface;
            this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLegajo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLegajo.ForeColor = MaterialColors.TextPrimary;
            this.txtLegajo.Location = new System.Drawing.Point(423, 55);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(134, 30);
            this.txtLegajo.TabIndex = 7;
            // 
            // lblEMail
            // 
            this.lblEMail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEMail.ForeColor = MaterialColors.TextSecondary;
            this.lblEMail.Location = new System.Drawing.Point(3, 90);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(134, 45);
            this.lblEMail.TabIndex = 8;
            this.lblEMail.Text = "E-Mail:";
            // 
            // txtEMail
            // 
            this.txtEMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEMail.BackColor = MaterialColors.Surface;
            this.txtEMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEMail.ForeColor = MaterialColors.TextPrimary;
            this.txtEMail.Location = new System.Drawing.Point(143, 100);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(134, 30);
            this.txtEMail.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefono.ForeColor = MaterialColors.TextSecondary;
            this.lblTelefono.Location = new System.Drawing.Point(283, 90);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(134, 45);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.BackColor = MaterialColors.Surface;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.ForeColor = MaterialColors.TextPrimary;
            this.txtTelefono.Location = new System.Drawing.Point(423, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 30);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDireccion.ForeColor = MaterialColors.TextSecondary;
            this.lblDireccion.Location = new System.Drawing.Point(3, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(134, 45);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.BackColor = MaterialColors.Surface;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.ForeColor = MaterialColors.TextPrimary;
            this.txtDireccion.Location = new System.Drawing.Point(143, 145);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(134, 30);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipo.ForeColor = MaterialColors.TextSecondary;
            this.lblTipo.Location = new System.Drawing.Point(283, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(134, 45);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxTipo.BackColor = MaterialColors.Surface;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTipo.ForeColor = MaterialColors.TextPrimary;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(423, 143);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(134, 31);
            this.cbxTipo.TabIndex = 15;
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPlan.ForeColor = MaterialColors.TextSecondary;
            this.lblPlan.Location = new System.Drawing.Point(3, 180);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(134, 45);
            this.lblPlan.TabIndex = 16;
            this.lblPlan.Text = "Plan:";
            // 
            // cbxPlan
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxPlan, 3);
            this.cbxPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxPlan.BackColor = MaterialColors.Surface;
            this.cbxPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPlan.ForeColor = MaterialColors.TextPrimary;
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(143, 188);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(414, 31);
            this.cbxPlan.TabIndex = 17;
            this.cbxPlan.ValueMember = "ID";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaNacimiento.ForeColor = MaterialColors.TextSecondary;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(3, 225);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(134, 45);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtpFechaNacimiento, 3);
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(143, 233);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(414, 30);
            this.dtpFechaNacimiento.TabIndex = 19;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = MaterialColors.Background;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnAceptar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 310);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(600, 50);
            this.panelBotones.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = MaterialColors.Accent;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = MaterialColors.TextPrimary;
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Location = new System.Drawing.Point(305, 8);
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
            this.btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(195, 8);
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PersonaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "PersonaDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persona";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
