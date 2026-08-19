namespace UI.Desktop.Forms.Usuarios
{
    partial class UsuarioDesktop
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            lblHabilitado = new Label();
            chkHabilitado = new CheckBox();
            lblPersona = new Label();
            cbxPersona = new ComboBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsuario, 1, 1);
            tableLayoutPanel1.Controls.Add(lblClave, 0, 2);
            tableLayoutPanel1.Controls.Add(txtClave, 1, 2);
            tableLayoutPanel1.Controls.Add(lblHabilitado, 0, 3);
            tableLayoutPanel1.Controls.Add(chkHabilitado, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPersona, 0, 4);
            tableLayoutPanel1.Controls.Add(cbxPersona, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(450, 376);
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
            lblID.Size = new Size(84, 56);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Anchor = AnchorStyles.Left;
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.ForeColor = Color.FromArgb(33, 33, 33);
            txtID.Location = new Point(93, 4);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(354, 30);
            txtID.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(117, 117, 117);
            lblUsuario.Location = new Point(3, 56);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 56);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Anchor = AnchorStyles.Left;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.FromArgb(33, 33, 33);
            txtUsuario.Location = new Point(93, 60);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(354, 30);
            txtUsuario.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.Right;
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F);
            lblClave.ForeColor = Color.FromArgb(117, 117, 117);
            lblClave.Location = new Point(3, 112);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(84, 56);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Anchor = AnchorStyles.Left;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.ForeColor = Color.FromArgb(33, 33, 33);
            txtClave.Location = new Point(93, 116);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(354, 30);
            txtClave.TabIndex = 5;
            // 
            // lblHabilitado
            // 
            lblHabilitado.Anchor = AnchorStyles.Right;
            lblHabilitado.AutoSize = true;
            lblHabilitado.Font = new Font("Segoe UI", 10F);
            lblHabilitado.ForeColor = Color.FromArgb(117, 117, 117);
            lblHabilitado.Location = new Point(3, 168);
            lblHabilitado.Name = "lblHabilitado";
            lblHabilitado.Size = new Size(84, 56);
            lblHabilitado.TabIndex = 6;
            lblHabilitado.Text = "Habilitado:";
            // 
            // chkHabilitado
            // 
            chkHabilitado.Anchor = AnchorStyles.Left;
            chkHabilitado.Font = new Font("Segoe UI", 10F);
            chkHabilitado.ForeColor = Color.FromArgb(33, 33, 33);
            chkHabilitado.Location = new Point(93, 172);
            chkHabilitado.Margin = new Padding(3, 4, 3, 4);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(354, 48);
            chkHabilitado.TabIndex = 7;
            chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblPersona
            // 
            lblPersona.Anchor = AnchorStyles.Right;
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Segoe UI", 10F);
            lblPersona.ForeColor = Color.FromArgb(117, 117, 117);
            lblPersona.Location = new Point(3, 224);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(84, 152);
            lblPersona.TabIndex = 8;
            lblPersona.Text = "Persona:";
            // 
            // cbxPersona
            // 
            cbxPersona.BackColor = Color.White;
            cbxPersona.DisplayMember = "ID";
            cbxPersona.Anchor = AnchorStyles.Left;
            cbxPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPersona.FlatStyle = FlatStyle.Flat;
            cbxPersona.Font = new Font("Segoe UI", 10F);
            cbxPersona.ForeColor = Color.FromArgb(33, 33, 33);
            cbxPersona.FormattingEnabled = true;
            cbxPersona.Location = new Point(93, 228);
            cbxPersona.Margin = new Padding(3, 4, 3, 4);
            cbxPersona.Name = "cbxPersona";
            cbxPersona.Size = new Size(354, 31);
            cbxPersona.TabIndex = 9;
            cbxPersona.ValueMember = "ID";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(245, 245, 245);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 376);
            panelBotones.Margin = new Padding(3, 4, 3, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 60);
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
            btnCancelar.Location = new Point(120, 10);
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
            btnAceptar.Location = new Point(230, 10);
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 40);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // UsuarioDesktop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(450, 438);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBotones);
            Margin = new Padding(3, 5, 3, 5);
            Name = "UsuarioDesktop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.ComboBox cbxPersona;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

    }
}
