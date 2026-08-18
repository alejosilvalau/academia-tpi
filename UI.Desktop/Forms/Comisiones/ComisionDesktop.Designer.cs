namespace UI.Desktop.Forms.Comisiones
{
    partial class ComisionDesktop
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblAnioEspecialidad = new System.Windows.Forms.Label();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioEspecialidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAnioEspecialidad, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxPlan, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // lblID
            //
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblID.ForeColor = MaterialColors.TextPrimary;
            this.lblID.Location = new System.Drawing.Point(40, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 19);
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
            this.txtID.ForeColor = MaterialColors.TextSecondary;
            this.txtID.Location = new System.Drawing.Point(68, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 25);
            this.txtID.TabIndex = 1;
            //
            // lblDescripcion
            //
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcion.ForeColor = MaterialColors.TextPrimary;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(59, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Nombre:";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.BackColor = MaterialColors.Surface;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.ForeColor = MaterialColors.TextPrimary;
            this.txtDescripcion.Location = new System.Drawing.Point(68, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 25);
            this.txtDescripcion.TabIndex = 3;
            //
            // lblAnioEspecialidad
            //
            this.lblAnioEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAnioEspecialidad.AutoSize = true;
            this.lblAnioEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAnioEspecialidad.ForeColor = MaterialColors.TextPrimary;
            this.lblAnioEspecialidad.Location = new System.Drawing.Point(294, 8);
            this.lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            this.lblAnioEspecialidad.Size = new System.Drawing.Size(120, 19);
            this.lblAnioEspecialidad.TabIndex = 4;
            this.lblAnioEspecialidad.Text = "Anio Especialidad:";
            //
            // txtAnioEspecialidad
            //
            this.txtAnioEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioEspecialidad.BackColor = MaterialColors.Surface;
            this.txtAnioEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnioEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAnioEspecialidad.ForeColor = MaterialColors.TextPrimary;
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(420, 5);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(120, 25);
            this.txtAnioEspecialidad.TabIndex = 5;
            //
            // lblPlan
            //
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPlan.ForeColor = MaterialColors.TextPrimary;
            this.lblPlan.Location = new System.Drawing.Point(375, 38);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(39, 19);
            this.lblPlan.TabIndex = 6;
            this.lblPlan.Text = "Plan:";
            //
            // cbxPlan
            //
            this.cbxPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxPlan.BackColor = MaterialColors.Surface;
            this.cbxPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPlan.ForeColor = MaterialColors.TextPrimary;
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(420, 35);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(120, 25);
            this.cbxPlan.TabIndex = 7;
            //
            // panelBottom
            //
            this.panelBottom.BackColor = MaterialColors.Background;
            this.panelBottom.Controls.Add(this.btnCancelar);
            this.panelBottom.Controls.Add(this.btnAceptar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(15, 135);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(550, 45);
            this.panelBottom.TabIndex = 1;
            //
            // btnAceptar
            //
            this.btnAceptar.BackColor = MaterialColors.Accent;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 171, 0);
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = MaterialColors.TextPrimary;
            this.btnAceptar.Location = new System.Drawing.Point(350, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 45);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = MaterialColors.CancelBtn;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = MaterialColors.PrimaryDark;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = MaterialColors.PrimaryDark;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnCancelar.Location = new System.Drawing.Point(450, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // ComisionDesktop
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = MaterialColors.Background;
            this.ClientSize = new System.Drawing.Size(580, 195);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComisionDesktop";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comision";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblAnioEspecialidad;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
