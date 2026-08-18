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
            tlpCenter = new TableLayoutPanel();
            pnlLabels = new Panel();
            lblAcademia = new Label();
            lblSubtitulo = new Label();
            panelRight = new Panel();
            tlpRight = new TableLayoutPanel();
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIniciarSesion = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panelLeft.SuspendLayout();
            tlpCenter.SuspendLayout();
            pnlLabels.SuspendLayout();
            panelRight.SuspendLayout();
            tlpRight.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(69, 90, 100);
            panelLeft.Controls.Add(tlpCenter);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(280, 475);
            panelLeft.TabIndex = 0;
            // 
            // tlpCenter
            // 
            tlpCenter.ColumnCount = 1;
            tlpCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCenter.Controls.Add(pnlLabels, 0, 1);
            tlpCenter.Dock = DockStyle.Fill;
            tlpCenter.Location = new Point(0, 0);
            tlpCenter.Name = "tlpCenter";
            tlpCenter.RowCount = 3;
            tlpCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCenter.RowStyles.Add(new RowStyle());
            tlpCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCenter.Size = new Size(280, 475);
            tlpCenter.TabIndex = 0;
            // 
            // pnlLabels
            // 
            pnlLabels.AutoSize = true;
            pnlLabels.Controls.Add(lblAcademia);
            pnlLabels.Controls.Add(lblSubtitulo);
            pnlLabels.Dock = DockStyle.Fill;
            pnlLabels.Location = new Point(3, 181);
            pnlLabels.Name = "pnlLabels";
            pnlLabels.Size = new Size(274, 113);
            pnlLabels.TabIndex = 0;
            // 
            // lblAcademia
            // 
            lblAcademia.Dock = DockStyle.Top;
            lblAcademia.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAcademia.ForeColor = Color.FromArgb(255, 193, 7);
            lblAcademia.Location = new Point(0, 38);
            lblAcademia.Name = "lblAcademia";
            lblAcademia.Size = new Size(274, 75);
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
            lblSubtitulo.Size = new Size(274, 38);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestion Academica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(245, 245, 245);
            panelRight.Controls.Add(tlpRight);
            panelRight.Controls.Add(tableLayoutPanel3);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(280, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(420, 475);
            panelRight.TabIndex = 1;
            // 
            // tlpRight
            // 
            tlpRight.ColumnCount = 3;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.Controls.Add(lblTitulo, 1, 1);
            tlpRight.Controls.Add(txtUsuario, 1, 3);
            tlpRight.Controls.Add(txtClave, 1, 5);
            tlpRight.Controls.Add(btnIniciarSesion, 1, 7);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(0, 40);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 9;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.RowStyles.Add(new RowStyle());
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tlpRight.RowStyles.Add(new RowStyle());
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpRight.RowStyles.Add(new RowStyle());
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRight.RowStyles.Add(new RowStyle());
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.Size = new Size(420, 435);
            tlpRight.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitulo.Location = new Point(73, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LOGIN";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Top;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.ForeColor = Color.FromArgb(117, 117, 117);
            txtUsuario.Location = new Point(73, 170);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 32);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txt_EnterLeave;
            txtUsuario.Leave += txt_EnterLeave;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Dock = DockStyle.Top;
            txtClave.Font = new Font("Segoe UI", 11F);
            txtClave.ForeColor = Color.FromArgb(117, 117, 117);
            txtClave.Location = new Point(73, 222);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(274, 32);
            txtClave.TabIndex = 4;
            txtClave.Text = "Contrasena";
            txtClave.Enter += txt_EnterLeave;
            txtClave.Leave += txt_EnterLeave;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(255, 193, 7);
            btnIniciarSesion.Dock = DockStyle.Top;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIniciarSesion.ForeColor = Color.FromArgb(33, 33, 33);
            btnIniciarSesion.Location = new Point(73, 282);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(274, 48);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnCerrar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnMinimizar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(420, 40);
            tableLayoutPanel3.TabIndex = 7;
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
            btnCerrar.Location = new Point(387, 0);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 40);
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
            btnMinimizar.Location = new Point(354, 0);
            btnMinimizar.Margin = new Padding(0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(33, 40);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
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
            tlpCenter.ResumeLayout(false);
            tlpCenter.PerformLayout();
            pnlLabels.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            tlpRight.ResumeLayout(false);
            tlpRight.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.Panel pnlLabels;
        private System.Windows.Forms.Label lblAcademia;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}
