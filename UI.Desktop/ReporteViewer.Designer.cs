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
            panelTop = new Panel();
            btnDescargar = new Button();
            btnGenerar = new Button();
            cbxSelector = new ComboBox();
            lblSelector = new Label();
            panelViewer = new Panel();
            lblAviso = new Label();
            panelTop.SuspendLayout();
            panelViewer.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(55, 71, 79);
            panelTop.Controls.Add(btnDescargar);
            panelTop.Controls.Add(btnGenerar);
            panelTop.Controls.Add(cbxSelector);
            panelTop.Controls.Add(lblSelector);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10, 12, 10, 12);
            panelTop.Size = new Size(1000, 75);
            panelTop.TabIndex = 0;
            // 
            // btnDescargar
            // 
            btnDescargar.BackColor = Color.FromArgb(96, 125, 139);
            btnDescargar.FlatAppearance.BorderSize = 0;
            btnDescargar.FlatStyle = FlatStyle.Flat;
            btnDescargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDescargar.ForeColor = Color.White;
            btnDescargar.Location = new Point(695, 19);
            btnDescargar.Margin = new Padding(3, 4, 3, 4);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(130, 40);
            btnDescargar.TabIndex = 3;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = false;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(255, 193, 7);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.FromArgb(33, 33, 33);
            btnGenerar.Location = new Point(550, 19);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(130, 40);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar PDF";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cbxSelector
            // 
            cbxSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSelector.FlatStyle = FlatStyle.Flat;
            cbxSelector.Font = new Font("Segoe UI", 10F);
            cbxSelector.FormattingEnabled = true;
            cbxSelector.Location = new Point(89, 23);
            cbxSelector.Margin = new Padding(3, 4, 3, 4);
            cbxSelector.Name = "cbxSelector";
            cbxSelector.Size = new Size(450, 31);
            cbxSelector.TabIndex = 1;
            // 
            // lblSelector
            // 
            lblSelector.AutoSize = true;
            lblSelector.Font = new Font("Segoe UI", 10F);
            lblSelector.ForeColor = Color.White;
            lblSelector.Location = new Point(8, 26);
            lblSelector.Name = "lblSelector";
            lblSelector.Size = new Size(74, 23);
            lblSelector.TabIndex = 0;
            lblSelector.Text = "Persona:";
            // 
            // panelViewer
            // 
            panelViewer.BackColor = Color.FromArgb(245, 245, 245);
            panelViewer.Controls.Add(lblAviso);
            panelViewer.Dock = DockStyle.Fill;
            panelViewer.Location = new Point(0, 75);
            panelViewer.Margin = new Padding(3, 4, 3, 4);
            panelViewer.Name = "panelViewer";
            panelViewer.Padding = new Padding(10, 12, 10, 12);
            panelViewer.Size = new Size(1000, 800);
            panelViewer.TabIndex = 1;
            // 
            // lblAviso
            // 
            lblAviso.Dock = DockStyle.Fill;
            lblAviso.Font = new Font("Segoe UI", 12F);
            lblAviso.ForeColor = Color.Gray;
            lblAviso.Location = new Point(10, 12);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(980, 776);
            lblAviso.TabIndex = 0;
            lblAviso.Text = "Presione \"Generar PDF\" para visualizar el reporte.";
            lblAviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReporteViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 875);
            Controls.Add(panelViewer);
            Controls.Add(panelTop);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ReporteViewer";
            Text = "Reporte";
            Load += ReporteViewer_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelViewer.ResumeLayout(false);
            ResumeLayout(false);
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
