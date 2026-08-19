namespace UI.Desktop
{
    partial class ReporteViewer
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSelector = new System.Windows.Forms.Label();
            this.cbxSelector = new System.Windows.Forms.ComboBox();
            this.panelViewer = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelViewer.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.panelTop.Controls.Add(this.btnDescargar);
            this.panelTop.Controls.Add(this.btnGenerar);
            this.panelTop.Controls.Add(this.cbxSelector);
            this.panelTop.Controls.Add(this.lblSelector);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(1000, 60);
            this.panelTop.TabIndex = 0;
            //
            // lblSelector
            //
            this.lblSelector.AutoSize = true;
            this.lblSelector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelector.ForeColor = System.Drawing.Color.White;
            this.lblSelector.Location = new System.Drawing.Point(15, 20);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(60, 19);
            this.lblSelector.TabIndex = 0;
            this.lblSelector.Text = "Persona:";
            //
            // cbxSelector
            //
            this.cbxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSelector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSelector.FormattingEnabled = true;
            this.cbxSelector.Location = new System.Drawing.Point(85, 17);
            this.cbxSelector.Name = "cbxSelector";
            this.cbxSelector.Size = new System.Drawing.Size(450, 25);
            this.cbxSelector.TabIndex = 1;
            //
            // btnGenerar
            //
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnGenerar.Location = new System.Drawing.Point(550, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 32);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar PDF";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            //
            // btnDescargar
            //
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(695, 15);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(130, 32);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Enabled = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            //
            // panelViewer
            //
            this.panelViewer.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelViewer.Controls.Add(this.lblAviso);
            this.panelViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewer.Location = new System.Drawing.Point(0, 60);
            this.panelViewer.Name = "panelViewer";
            this.panelViewer.Padding = new System.Windows.Forms.Padding(10);
            this.panelViewer.Size = new System.Drawing.Size(1000, 640);
            this.panelViewer.TabIndex = 1;
            //
            // lblAviso
            //
            this.lblAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAviso.ForeColor = System.Drawing.Color.Gray;
            this.lblAviso.Location = new System.Drawing.Point(10, 10);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(980, 620);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Presione \"Generar PDF\" para visualizar el reporte.";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ReporteViewer
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelViewer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "ReporteViewer";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteViewer_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelViewer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbxSelector;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.Panel panelViewer;
        private System.Windows.Forms.Label lblAviso;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
