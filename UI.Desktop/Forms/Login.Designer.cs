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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblAcademia = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            //
            // panelLeft
            //
            this.panelLeft.BackColor = MaterialColors.PrimaryDark;
            this.panelLeft.Controls.Add(this.lblAcademia);
            this.panelLeft.Controls.Add(this.lblSubtitulo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 380);
            this.panelLeft.TabIndex = 0;
            //
            // lblAcademia
            //
            this.lblAcademia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAcademia.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAcademia.ForeColor = MaterialColors.Accent;
            this.lblAcademia.Location = new System.Drawing.Point(0, 80);
            this.lblAcademia.Name = "lblAcademia";
            this.lblAcademia.Size = new System.Drawing.Size(280, 60);
            this.lblAcademia.TabIndex = 0;
            this.lblAcademia.Text = "ACADEMIA";
            this.lblAcademia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = Color.FromArgb(176, 190, 197);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 140);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(280, 30);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Sistema de Gestion Academica";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // panelRight
            //
            this.panelRight.BackColor = MaterialColors.Background;
            this.panelRight.Controls.Add(this.tableLayoutPanel3);
            this.panelRight.Controls.Add(this.txtUsuario);
            this.panelRight.Controls.Add(this.txtClave);
            this.panelRight.Controls.Add(this.btnIniciarSesion);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(280, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(420, 380);
            this.panelRight.TabIndex = 1;
            //
            // tableLayoutPanel3
            //
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCerrar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMinimizar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(420, 45);
            this.tableLayoutPanel3.TabIndex = 7;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = MaterialColors.TextPrimary;
            this.lblTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LOGIN";
            //
            // btnCerrar
            //
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = MaterialColors.Error;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = MaterialColors.Error;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = MaterialColors.TextSecondary;
            this.btnCerrar.Location = new System.Drawing.Point(390, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 45);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // btnMinimizar
            //
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = MaterialColors.TextSecondary;
            this.btnMinimizar.Location = new System.Drawing.Point(360, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 45);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            //
            // txtUsuario
            //
            this.txtUsuario.BackColor = MaterialColors.Surface;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = MaterialColors.TextSecondary;
            this.txtUsuario.Location = new System.Drawing.Point(40, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 32);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txt_EnterLeave);
            this.txtUsuario.Leave += new System.EventHandler(this.txt_EnterLeave);
            //
            // txtClave
            //
            this.txtClave.BackColor = MaterialColors.Surface;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtClave.ForeColor = MaterialColors.TextSecondary;
            this.txtClave.Location = new System.Drawing.Point(40, 130);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(340, 32);
            this.txtClave.TabIndex = 4;
            this.txtClave.Text = "Contrasena";
            this.txtClave.Enter += new System.EventHandler(this.txt_EnterLeave);
            this.txtClave.Leave += new System.EventHandler(this.txt_EnterLeave);
            //
            // btnIniciarSesion
            //
            this.btnIniciarSesion.BackColor = MaterialColors.Accent;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = MaterialColors.TextPrimary;
            this.btnIniciarSesion.Location = new System.Drawing.Point(40, 190);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(340, 42);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            //
            // Login
            //
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appLogin_MouseDown);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
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
