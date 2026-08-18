namespace UI.Desktop
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnReportesPlanes = new System.Windows.Forms.Button();
            this.btnReportesCursos = new System.Windows.Forms.Button();
            this.btnABMUsuarios = new System.Windows.Forms.Button();
            this.btnABMPlanes = new System.Windows.Forms.Button();
            this.btnABMPersonas = new System.Windows.Forms.Button();
            this.btnABMMaterias = new System.Windows.Forms.Button();
            this.btnABMEspecialidades = new System.Windows.Forms.Button();
            this.btnABMDictados = new System.Windows.Forms.Button();
            this.btnABMCursos = new System.Windows.Forms.Button();
            this.btnABMComisiones = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            //
            // panelMenu
            //
            this.panelMenu.BackColor = MaterialColors.SidebarBg;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnNotas);
            this.panelMenu.Controls.Add(this.btnInscripcion);
            this.panelMenu.Controls.Add(this.btnAdministracion);
            this.panelMenu.Controls.Add(this.panelPerfil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 600);
            this.panelMenu.TabIndex = 0;
            //
            // panelPerfil
            //
            this.panelPerfil.BackColor = MaterialColors.PrimaryDark;
            this.panelPerfil.Controls.Add(this.lblTipo);
            this.panelPerfil.Controls.Add(this.lblUsuario);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(220, 100);
            this.panelPerfil.TabIndex = 0;
            //
            // lblTipo
            //
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipo.ForeColor = MaterialColors.Accent;
            this.lblTipo.Location = new System.Drawing.Point(0, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(220, 25);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblUsuario
            //
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = MaterialColors.TextOnPrimary;
            this.lblUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(220, 35);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnAdministracion
            //
            this.btnAdministracion.AutoSize = true;
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdministracion.ForeColor = MaterialColors.TextOnPrimary;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 100);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnAdministracion.Size = new System.Drawing.Size(220, 48);
            this.btnAdministracion.TabIndex = 1;
            this.btnAdministracion.Text = "  Administracion";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            //
            // btnInscripcion
            //
            this.btnInscripcion.AutoSize = true;
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripcion.FlatAppearance.BorderSize = 0;
            this.btnInscripcion.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnInscripcion.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInscripcion.ForeColor = MaterialColors.TextOnPrimary;
            this.btnInscripcion.Location = new System.Drawing.Point(0, 148);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnInscripcion.Size = new System.Drawing.Size(220, 48);
            this.btnInscripcion.TabIndex = 2;
            this.btnInscripcion.Text = "  Inscripcion";
            this.btnInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.UseVisualStyleBackColor = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            //
            // btnNotas
            //
            this.btnNotas.AutoSize = true;
            this.btnNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnNotas.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotas.ForeColor = MaterialColors.TextOnPrimary;
            this.btnNotas.Location = new System.Drawing.Point(0, 196);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnNotas.Size = new System.Drawing.Size(220, 48);
            this.btnNotas.TabIndex = 3;
            this.btnNotas.Text = "  Registrar Notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            //
            // btnReportes
            //
            this.btnReportes.AutoSize = true;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnReportes.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = MaterialColors.TextOnPrimary;
            this.btnReportes.Location = new System.Drawing.Point(0, 244);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnReportes.Size = new System.Drawing.Size(220, 48);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = MaterialColors.Accent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 552);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnCerrarSesion.Size = new System.Drawing.Size(220, 48);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "  Cerrar Sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // panelTop
            //
            this.panelTop.BackColor = MaterialColors.Primary;
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(780, 50);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = MaterialColors.TextOnPrimary;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            //
            // btnMinimizar
            //
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = MaterialColors.PrimaryDark;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = MaterialColors.PrimaryDark;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnMinimizar.Location = new System.Drawing.Point(690, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 50);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            //
            // btnMaximizar
            //
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = MaterialColors.PrimaryDark;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = MaterialColors.PrimaryDark;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaximizar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnMaximizar.Location = new System.Drawing.Point(720, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 50);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "[]";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            //
            // btnCerrar
            //
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = MaterialColors.Error;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = MaterialColors.Error;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = MaterialColors.TextOnPrimary;
            this.btnCerrar.Location = new System.Drawing.Point(750, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // panelFormLoader
            //
            this.panelFormLoader.BackColor = MaterialColors.Background;
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(220, 50);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Padding = new System.Windows.Forms.Padding(10);
            this.panelFormLoader.Size = new System.Drawing.Size(780, 500);
            this.panelFormLoader.TabIndex = 2;
            this.panelFormLoader.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlAdded);
            this.panelFormLoader.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlRemoved);
            //
            // panelSubMenu
            //
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(48, 63, 71);
            this.panelSubMenu.Controls.Add(this.btnReportesPlanes);
            this.panelSubMenu.Controls.Add(this.btnReportesCursos);
            this.panelSubMenu.Controls.Add(this.btnABMUsuarios);
            this.panelSubMenu.Controls.Add(this.btnABMPlanes);
            this.panelSubMenu.Controls.Add(this.btnABMPersonas);
            this.panelSubMenu.Controls.Add(this.btnABMMaterias);
            this.panelSubMenu.Controls.Add(this.btnABMEspecialidades);
            this.panelSubMenu.Controls.Add(this.btnABMDictados);
            this.panelSubMenu.Controls.Add(this.btnABMCursos);
            this.panelSubMenu.Controls.Add(this.btnABMComisiones);
            this.panelSubMenu.Location = new System.Drawing.Point(220, 50);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(200, 500);
            this.panelSubMenu.TabIndex = 3;
            this.panelSubMenu.Visible = false;
            //
            // btnABMComisiones
            //
            this.btnABMComisiones.AutoSize = true;
            this.btnABMComisiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMComisiones.FlatAppearance.BorderSize = 0;
            this.btnABMComisiones.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMComisiones.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMComisiones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMComisiones.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMComisiones.Location = new System.Drawing.Point(0, 0);
            this.btnABMComisiones.Name = "btnABMComisiones";
            this.btnABMComisiones.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMComisiones.Size = new System.Drawing.Size(200, 40);
            this.btnABMComisiones.TabIndex = 0;
            this.btnABMComisiones.Text = "Comisiones";
            this.btnABMComisiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMComisiones.Visible = false;
            this.btnABMComisiones.Click += new System.EventHandler(this.btnABMComisiones_Click);
            //
            // btnABMCursos
            //
            this.btnABMCursos.AutoSize = true;
            this.btnABMCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMCursos.FlatAppearance.BorderSize = 0;
            this.btnABMCursos.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMCursos.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMCursos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMCursos.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMCursos.Location = new System.Drawing.Point(0, 40);
            this.btnABMCursos.Name = "btnABMCursos";
            this.btnABMCursos.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMCursos.Size = new System.Drawing.Size(200, 40);
            this.btnABMCursos.TabIndex = 1;
            this.btnABMCursos.Text = "Cursos";
            this.btnABMCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMCursos.Visible = false;
            this.btnABMCursos.Click += new System.EventHandler(this.btnABMCursos_Click);
            //
            // btnABMEspecialidades
            //
            this.btnABMEspecialidades.AutoSize = true;
            this.btnABMEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnABMEspecialidades.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMEspecialidades.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMEspecialidades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMEspecialidades.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMEspecialidades.Location = new System.Drawing.Point(0, 80);
            this.btnABMEspecialidades.Name = "btnABMEspecialidades";
            this.btnABMEspecialidades.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMEspecialidades.Size = new System.Drawing.Size(200, 40);
            this.btnABMEspecialidades.TabIndex = 2;
            this.btnABMEspecialidades.Text = "Especialidades";
            this.btnABMEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMEspecialidades.Visible = false;
            this.btnABMEspecialidades.Click += new System.EventHandler(this.btnABMEspecialidades_Click);
            //
            // btnABMMaterias
            //
            this.btnABMMaterias.AutoSize = true;
            this.btnABMMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMMaterias.FlatAppearance.BorderSize = 0;
            this.btnABMMaterias.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMMaterias.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMMaterias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMMaterias.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMMaterias.Location = new System.Drawing.Point(0, 120);
            this.btnABMMaterias.Name = "btnABMMaterias";
            this.btnABMMaterias.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMMaterias.Size = new System.Drawing.Size(200, 40);
            this.btnABMMaterias.TabIndex = 3;
            this.btnABMMaterias.Text = "Materias";
            this.btnABMMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMMaterias.Visible = false;
            this.btnABMMaterias.Click += new System.EventHandler(this.btnABMMaterias_Click);
            //
            // btnABMPersonas
            //
            this.btnABMPersonas.AutoSize = true;
            this.btnABMPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMPersonas.FlatAppearance.BorderSize = 0;
            this.btnABMPersonas.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMPersonas.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMPersonas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMPersonas.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMPersonas.Location = new System.Drawing.Point(0, 160);
            this.btnABMPersonas.Name = "btnABMPersonas";
            this.btnABMPersonas.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMPersonas.Size = new System.Drawing.Size(200, 40);
            this.btnABMPersonas.TabIndex = 4;
            this.btnABMPersonas.Text = "Personas";
            this.btnABMPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMPersonas.Visible = false;
            this.btnABMPersonas.Click += new System.EventHandler(this.btnABMPersonas_Click);
            //
            // btnABMPlanes
            //
            this.btnABMPlanes.AutoSize = true;
            this.btnABMPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMPlanes.FlatAppearance.BorderSize = 0;
            this.btnABMPlanes.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMPlanes.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMPlanes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMPlanes.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMPlanes.Location = new System.Drawing.Point(0, 200);
            this.btnABMPlanes.Name = "btnABMPlanes";
            this.btnABMPlanes.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMPlanes.Size = new System.Drawing.Size(200, 40);
            this.btnABMPlanes.TabIndex = 5;
            this.btnABMPlanes.Text = "Planes";
            this.btnABMPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMPlanes.Visible = false;
            this.btnABMPlanes.Click += new System.EventHandler(this.btnABMPlanes_Click);
            //
            // btnABMDictados
            //
            this.btnABMDictados.AutoSize = true;
            this.btnABMDictados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMDictados.FlatAppearance.BorderSize = 0;
            this.btnABMDictados.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMDictados.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMDictados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMDictados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMDictados.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMDictados.Location = new System.Drawing.Point(0, 240);
            this.btnABMDictados.Name = "btnABMDictados";
            this.btnABMDictados.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMDictados.Size = new System.Drawing.Size(200, 40);
            this.btnABMDictados.TabIndex = 6;
            this.btnABMDictados.Text = "Dictados";
            this.btnABMDictados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMDictados.Visible = false;
            this.btnABMDictados.Click += new System.EventHandler(this.btnABMDictados_Click);
            //
            // btnABMUsuarios
            //
            this.btnABMUsuarios.AutoSize = true;
            this.btnABMUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMUsuarios.FlatAppearance.BorderSize = 0;
            this.btnABMUsuarios.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnABMUsuarios.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnABMUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnABMUsuarios.ForeColor = MaterialColors.TextOnPrimary;
            this.btnABMUsuarios.Location = new System.Drawing.Point(0, 280);
            this.btnABMUsuarios.Name = "btnABMUsuarios";
            this.btnABMUsuarios.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnABMUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnABMUsuarios.TabIndex = 7;
            this.btnABMUsuarios.Text = "Usuarios";
            this.btnABMUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMUsuarios.Visible = false;
            this.btnABMUsuarios.Click += new System.EventHandler(this.btnABMUsuarios_Click);
            //
            // btnReportesCursos
            //
            this.btnReportesCursos.AutoSize = true;
            this.btnReportesCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesCursos.FlatAppearance.BorderSize = 0;
            this.btnReportesCursos.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnReportesCursos.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnReportesCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesCursos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportesCursos.ForeColor = MaterialColors.TextOnPrimary;
            this.btnReportesCursos.Location = new System.Drawing.Point(0, 320);
            this.btnReportesCursos.Name = "btnReportesCursos";
            this.btnReportesCursos.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnReportesCursos.Size = new System.Drawing.Size(200, 40);
            this.btnReportesCursos.TabIndex = 8;
            this.btnReportesCursos.Text = "Reportes Cursos";
            this.btnReportesCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesCursos.Visible = false;
            this.btnReportesCursos.Click += new System.EventHandler(this.btnReportesCursos_Click);
            //
            // btnReportesPlanes
            //
            this.btnReportesPlanes.AutoSize = true;
            this.btnReportesPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesPlanes.FlatAppearance.BorderSize = 0;
            this.btnReportesPlanes.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnReportesPlanes.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnReportesPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesPlanes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportesPlanes.ForeColor = MaterialColors.TextOnPrimary;
            this.btnReportesPlanes.Location = new System.Drawing.Point(0, 360);
            this.btnReportesPlanes.Name = "btnReportesPlanes";
            this.btnReportesPlanes.Padding = new System.Windows.Forms.Padding(15, 6, 15, 6);
            this.btnReportesPlanes.Size = new System.Drawing.Size(200, 40);
            this.btnReportesPlanes.TabIndex = 9;
            this.btnReportesPlanes.Text = "Reportes Planes";
            this.btnReportesPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesPlanes.Visible = false;
            this.btnReportesPlanes.Click += new System.EventHandler(this.btnReportesPlanes_Click);
            //
            // panelBottom
            //
            this.panelBottom.BackColor = MaterialColors.PrimaryDark;
            this.panelBottom.Controls.Add(this.btnActualizar);
            this.panelBottom.Controls.Add(this.btnSalir);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(220, 550);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(780, 50);
            this.panelBottom.TabIndex = 4;
            this.panelBottom.Visible = false;
            //
            // btnActualizar
            //
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnActualizar.ForeColor = MaterialColors.Accent;
            this.btnActualizar.Location = new System.Drawing.Point(620, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 50);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // btnSalir
            //
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = MaterialColors.SidebarHover;
            this.btnSalir.FlatAppearance.MouseOverBackColor = MaterialColors.SidebarHover;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.ForeColor = MaterialColors.TextOnPrimary;
            this.btnSalir.Location = new System.Drawing.Point(700, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 50);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // Main
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia TPI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPerfil.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            this.panelSubMenu.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnReportesPlanes;
        private System.Windows.Forms.Button btnReportesCursos;
        private System.Windows.Forms.Button btnABMUsuarios;
        private System.Windows.Forms.Button btnABMPlanes;
        private System.Windows.Forms.Button btnABMPersonas;
        private System.Windows.Forms.Button btnABMMaterias;
        private System.Windows.Forms.Button btnABMEspecialidades;
        private System.Windows.Forms.Button btnABMDictados;
        private System.Windows.Forms.Button btnABMCursos;
        private System.Windows.Forms.Button btnABMComisiones;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}
