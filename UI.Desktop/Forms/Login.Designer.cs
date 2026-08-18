namespace UI.Desktop
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblAcademia = new Label();
            lblSubtitulo = new Label();
            panelRight = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblTitulo = new Label();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIniciarSesion = new Button();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(69, 90, 100);
            panelLeft.Controls.Add(lblAcademia);
            panelLeft.Controls.Add(lblSubtitulo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 475);
            panelLeft.TabIndex = 0;
            // 
            // lblAcademia
            // 
            lblAcademia.Dock = DockStyle.Top;
            lblAcademia.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAcademia.ForeColor = Color.FromArgb(255, 193, 7);
            lblAcademia.Location = new Point(0, 38);
            lblAcademia.Name = "lblAcademia";
            lblAcademia.Size = new Size(280, 75);
            lblAcademia.TabIndex = 0;
            lblAcademia.Text = "ACADEMIA";
            lblAcademia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(176, 190, 197);
            lblSubtitulo.Location = new Point(0, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 38);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestion Academica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(245, 245, 245);
            panelRight.Controls.Add(tableLayoutPanel3);
            panelRight.Controls.Add(txtUsuario);
            panelRight.Controls.Add(txtClave);
            panelRight.Controls.Add(btnIniciarSesion);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(280, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(420, 475);
            panelRight.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCerrar, 2, 0);
            tableLayoutPanel3.Controls.Add(btnMinimizar, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(420, 56);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LOGIN";
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 47, 47);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 47, 47);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(117, 117, 117);
            btnCerrar.Location = new Point(387, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 56);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 90, 100);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMinimizar.ForeColor = Color.FromArgb(117, 117, 117);
            btnMinimizar.Location = new Point(351, 4);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 56);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.ForeColor = Color.FromArgb(117, 117, 117);
            txtUsuario.Location = new Point(40, 100);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(340, 32);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txt_EnterLeave;
            txtUsuario.Leave += txt_EnterLeave;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 11F);
            txtClave.ForeColor = Color.FromArgb(117, 117, 117);
            txtClave.Location = new Point(40, 162);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(340, 32);
            txtClave.TabIndex = 4;
            txtClave.Text = "Contrasena";
            txtClave.Enter += txt_EnterLeave;
            txtClave.Leave += txt_EnterLeave;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(255, 193, 7);
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIniciarSesion.ForeColor = Color.FromArgb(33, 33, 33);
            btnIniciarSesion.Location = new Point(40, 238);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(340, 52);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // Login
            // 
            AcceptButton = btnIniciarSesion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 475);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += appLogin_MouseDown;
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAcademia;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}
