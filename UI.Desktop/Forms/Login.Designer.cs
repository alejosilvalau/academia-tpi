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
            panelLeft.SuspendLayout();
            tlpCenter.SuspendLayout();
            pnlLabels.SuspendLayout();
            panelRight.SuspendLayout();
            tlpRight.SuspendLayout();
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
            lblSubtitulo.Text = "Sistema de Gestión Académica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(245, 245, 245);
            panelRight.Controls.Add(tlpRight);
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
            txtClave.Text = "Contraseña";
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
            btnIniciarSesion.Text = "Iniciar Sesión";
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
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLeft.ResumeLayout(false);
            tlpCenter.ResumeLayout(false);
            tlpCenter.PerformLayout();
            pnlLabels.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            tlpRight.ResumeLayout(false);
            tlpRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.Panel pnlLabels;
        private System.Windows.Forms.Label lblAcademia;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}
