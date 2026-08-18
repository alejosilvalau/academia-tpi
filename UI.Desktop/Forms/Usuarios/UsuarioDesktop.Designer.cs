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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.cbxPersona = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClave, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHabilitado, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPersona, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxPersona, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // lblID
            //
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.ForeColor = MaterialColors.TextSecondary;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 45);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtID
            //
            this.txtID.BackColor = MaterialColors.Surface;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.ForeColor = MaterialColors.TextPrimary;
            this.txtID.Location = new System.Drawing.Point(93, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(314, 30);
            this.txtID.TabIndex = 1;
            //
            // lblUsuario
            //
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = MaterialColors.TextSecondary;
            this.lblUsuario.Location = new System.Drawing.Point(3, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 45);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtUsuario
            //
            this.txtUsuario.BackColor = MaterialColors.Surface;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.ForeColor = MaterialColors.TextPrimary;
            this.txtUsuario.Location = new System.Drawing.Point(93, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(314, 30);
            this.txtUsuario.TabIndex = 3;
            //
            // lblClave
            //
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClave.ForeColor = MaterialColors.TextSecondary;
            this.lblClave.Location = new System.Drawing.Point(3, 90);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(84, 45);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtClave
            //
            this.txtClave.BackColor = MaterialColors.Surface;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClave.ForeColor = MaterialColors.TextPrimary;
            this.txtClave.Location = new System.Drawing.Point(93, 100);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(314, 30);
            this.txtClave.TabIndex = 5;
            //
            // lblHabilitado
            //
            this.lblHabilitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHabilitado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHabilitado.ForeColor = MaterialColors.TextSecondary;
            this.lblHabilitado.Location = new System.Drawing.Point(3, 135);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(84, 45);
            this.lblHabilitado.TabIndex = 6;
            this.lblHabilitado.Text = "Habilitado";
            this.lblHabilitado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // chkHabilitado
            //
            this.chkHabilitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHabilitado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHabilitado.ForeColor = MaterialColors.TextPrimary;
            this.chkHabilitado.Location = new System.Drawing.Point(93, 138);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(314, 39);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.UseVisualStyleBackColor = true;
            //
            // lblPersona
            //
            this.lblPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersona.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPersona.ForeColor = MaterialColors.TextSecondary;
            this.lblPersona.Location = new System.Drawing.Point(3, 180);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(84, 45);
            this.lblPersona.TabIndex = 8;
            this.lblPersona.Text = "Persona";
            this.lblPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cbxPersona
            //
            this.cbxPersona.BackColor = MaterialColors.Surface;
            this.cbxPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPersona.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPersona.ForeColor = MaterialColors.TextPrimary;
            this.cbxPersona.FormattingEnabled = true;
            this.cbxPersona.Location = new System.Drawing.Point(93, 183);
            this.cbxPersona.Name = "cbxPersona";
            this.cbxPersona.Size = new System.Drawing.Size(314, 31);
            this.cbxPersona.TabIndex = 9;
            //
            // panelBotones
            //
            this.panelBotones.BackColor = MaterialColors.Background;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnAceptar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 300);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(450, 50);
            this.panelBotones.TabIndex = 1;
            //
            // btnAceptar
            //
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = MaterialColors.Accent;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = MaterialColors.TextPrimary;
            this.btnAceptar.Location = new System.Drawing.Point(240, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = MaterialColors.CancelBtn;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(120, 144, 156);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnCancelar.Location = new System.Drawing.Point(345, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // UsuarioDesktop
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
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
