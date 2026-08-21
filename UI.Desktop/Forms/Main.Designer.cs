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
            panelDashboard = new Panel();
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnNotas = new Button();
            btnInscripcion = new Button();
            btnAdministracion = new Button();
            panelPerfil = new Panel();
            lblLegajo = new Label();
            lblTipo = new Label();
            lblUsuario = new Label();
            panelTop = new Panel();
            lblTitulo = new Label();
            panelFormLoader = new Panel();
            panelSubMenu = new Panel();
            btnReportesRendimientoDocente = new Button();
            btnReportesRendimientoAlumnos = new Button();
            btnABMUsuarios = new Button();
            btnABMPersonas = new Button();
            btnABMEspecialidades = new Button();
            btnABMDictados = new Button();
btnABMCursos = new Button();
            btnABMComisiones = new Button();
            btnABMPlanMaterias = new Button();
            panelBottom = new Panel();
            btnActualizar = new Button();
            btnSalir = new Button();
            panelMenu.SuspendLayout();
            panelPerfil.SuspendLayout();
            panelTop.SuspendLayout();
            panelSubMenu.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.AutoScroll = false;
            panelDashboard.BackColor = Color.FromArgb(245, 245, 245);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(220, 62);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Padding = new Padding(20);
            panelDashboard.Size = new Size(780, 626);
            panelDashboard.TabIndex = 5;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(55, 71, 79);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnNotas);
            panelMenu.Controls.Add(btnInscripcion);
            panelMenu.Controls.Add(btnAdministracion);
            panelMenu.Controls.Add(panelPerfil);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 750);
            panelMenu.TabIndex = 0;
            panelMenu.Click += panelOutside_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(255, 193, 7);
            btnCerrarSesion.Location = new Point(0, 690);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 10, 20, 10);
            btnCerrarSesion.Size = new Size(220, 60);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "  Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 328);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10);
            btnReportes.Size = new Size(220, 61);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "  Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Visible = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnNotas
            // 
            btnNotas.AutoSize = true;
            btnNotas.Dock = DockStyle.Top;
            btnNotas.FlatAppearance.BorderSize = 0;
            btnNotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnNotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnNotas.FlatStyle = FlatStyle.Flat;
            btnNotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNotas.ForeColor = Color.White;
            btnNotas.Location = new Point(0, 267);
            btnNotas.Margin = new Padding(3, 4, 3, 4);
            btnNotas.Name = "btnNotas";
            btnNotas.Padding = new Padding(10);
            btnNotas.Size = new Size(220, 61);
            btnNotas.TabIndex = 3;
            btnNotas.Text = "  Registrar Notas";
            btnNotas.TextAlign = ContentAlignment.MiddleLeft;
            btnNotas.UseVisualStyleBackColor = false;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.AutoSize = true;
            btnInscripcion.Dock = DockStyle.Top;
            btnInscripcion.FlatAppearance.BorderSize = 0;
            btnInscripcion.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnInscripcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnInscripcion.FlatStyle = FlatStyle.Flat;
            btnInscripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInscripcion.ForeColor = Color.White;
            btnInscripcion.Location = new Point(0, 206);
            btnInscripcion.Margin = new Padding(3, 4, 3, 4);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Padding = new Padding(10);
            btnInscripcion.Size = new Size(220, 61);
            btnInscripcion.TabIndex = 2;
            btnInscripcion.Text = "  Inscripción";
            btnInscripcion.TextAlign = ContentAlignment.MiddleLeft;
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.AutoSize = true;
            btnAdministracion.Dock = DockStyle.Top;
            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnAdministracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnAdministracion.FlatStyle = FlatStyle.Flat;
            btnAdministracion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdministracion.ForeColor = Color.White;
            btnAdministracion.Location = new Point(0, 145);
            btnAdministracion.Margin = new Padding(3, 4, 3, 4);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Padding = new Padding(10);
            btnAdministracion.Size = new Size(220, 61);
            btnAdministracion.TabIndex = 1;
            btnAdministracion.Text = "  Administración";
            btnAdministracion.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministracion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdministracion.UseVisualStyleBackColor = false;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.FromArgb(69, 90, 100);
            panelPerfil.Controls.Add(lblLegajo);
            panelPerfil.Controls.Add(lblTipo);
            panelPerfil.Controls.Add(lblUsuario);
            panelPerfil.Dock = DockStyle.Top;
            panelPerfil.Location = new Point(0, 0);
            panelPerfil.Margin = new Padding(3, 4, 3, 4);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(220, 145);
            panelPerfil.TabIndex = 0;
            // 
            // lblLegajo
            // 
            lblLegajo.Dock = DockStyle.Top;
            lblLegajo.Font = new Font("Segoe UI", 8.5F);
            lblLegajo.ForeColor = Color.FromArgb(180, 180, 180);
            lblLegajo.Location = new Point(0, 75);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(220, 20);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "Legajo";
            lblLegajo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.Dock = DockStyle.Top;
            lblTipo.Font = new Font("Segoe UI", 9F);
            lblTipo.ForeColor = Color.FromArgb(255, 193, 7);
            lblTipo.Location = new Point(0, 44);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(220, 31);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(220, 44);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(96, 125, 139);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(220, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(780, 62);
            panelTop.TabIndex = 1;
            panelTop.Click += panelOutside_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(93, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // panelFormLoader
            // 
            panelFormLoader.BackColor = Color.FromArgb(245, 245, 245);
            panelFormLoader.Dock = DockStyle.Fill;
            panelFormLoader.Location = new Point(220, 62);
            panelFormLoader.Margin = new Padding(3, 4, 3, 4);
            panelFormLoader.Name = "panelFormLoader";
            panelFormLoader.Padding = new Padding(10, 12, 10, 12);
            panelFormLoader.Size = new Size(780, 626);
            panelFormLoader.TabIndex = 2;
            panelFormLoader.Click += panelOutside_Click;
            panelFormLoader.ControlAdded += panelFormLoader_ControlAdded;
            panelFormLoader.ControlRemoved += panelFormLoader_ControlRemoved;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(48, 63, 71);
            panelSubMenu.Controls.Add(btnReportesRendimientoDocente);
            panelSubMenu.Controls.Add(btnReportesRendimientoAlumnos);
            panelSubMenu.Controls.Add(btnABMUsuarios);
            panelSubMenu.Controls.Add(btnABMPersonas);
            panelSubMenu.Controls.Add(btnABMEspecialidades);
            panelSubMenu.Controls.Add(btnABMDictados);
panelSubMenu.Controls.Add(btnABMCursos);
            panelSubMenu.Controls.Add(btnABMComisiones);
            panelSubMenu.Controls.Add(btnABMPlanMaterias);
            panelSubMenu.Location = new Point(220, 62);
            panelSubMenu.Margin = new Padding(3, 4, 3, 4);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(200, 625);
            panelSubMenu.TabIndex = 3;
            panelSubMenu.Visible = false;
            // 
            // btnReportesRendimientoDocente
            // 
            btnReportesRendimientoDocente.AutoSize = true;
            btnReportesRendimientoDocente.Dock = DockStyle.Top;
            btnReportesRendimientoDocente.FlatAppearance.BorderSize = 0;
            btnReportesRendimientoDocente.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnReportesRendimientoDocente.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnReportesRendimientoDocente.FlatStyle = FlatStyle.Flat;
            btnReportesRendimientoDocente.Font = new Font("Segoe UI", 9F);
            btnReportesRendimientoDocente.ForeColor = Color.White;
            btnReportesRendimientoDocente.Location = new Point(0, 468);
            btnReportesRendimientoDocente.Margin = new Padding(3, 4, 3, 4);
            btnReportesRendimientoDocente.Name = "btnReportesRendimientoDocente";
            btnReportesRendimientoDocente.Padding = new Padding(15, 8, 15, 8);
            btnReportesRendimientoDocente.Size = new Size(200, 52);
            btnReportesRendimientoDocente.TabIndex = 9;
            btnReportesRendimientoDocente.Text = "Rendimiento Docente";
            btnReportesRendimientoDocente.TextAlign = ContentAlignment.MiddleLeft;
            btnReportesRendimientoDocente.Visible = false;
            btnReportesRendimientoDocente.Click += btnReportesRendimientoDocente_Click;
            // 
            // btnReportesRendimientoAlumnos
            // 
            btnReportesRendimientoAlumnos.AutoSize = true;
            btnReportesRendimientoAlumnos.Dock = DockStyle.Top;
            btnReportesRendimientoAlumnos.FlatAppearance.BorderSize = 0;
            btnReportesRendimientoAlumnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnReportesRendimientoAlumnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnReportesRendimientoAlumnos.FlatStyle = FlatStyle.Flat;
            btnReportesRendimientoAlumnos.Font = new Font("Segoe UI", 9F);
            btnReportesRendimientoAlumnos.ForeColor = Color.White;
            btnReportesRendimientoAlumnos.Location = new Point(0, 416);
            btnReportesRendimientoAlumnos.Margin = new Padding(3, 4, 3, 4);
            btnReportesRendimientoAlumnos.Name = "btnReportesRendimientoAlumnos";
            btnReportesRendimientoAlumnos.Padding = new Padding(15, 8, 15, 8);
            btnReportesRendimientoAlumnos.Size = new Size(200, 52);
            btnReportesRendimientoAlumnos.TabIndex = 8;
            btnReportesRendimientoAlumnos.Text = "Rendimiento Alumnos";
            btnReportesRendimientoAlumnos.TextAlign = ContentAlignment.MiddleLeft;
            btnReportesRendimientoAlumnos.Visible = false;
            btnReportesRendimientoAlumnos.Click += btnReportesRendimientoAlumnos_Click;
            // 
            // btnABMUsuarios
            // 
            btnABMUsuarios.AutoSize = true;
            btnABMUsuarios.Dock = DockStyle.Top;
            btnABMUsuarios.FlatAppearance.BorderSize = 0;
            btnABMUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMUsuarios.FlatStyle = FlatStyle.Flat;
            btnABMUsuarios.Font = new Font("Segoe UI", 9F);
            btnABMUsuarios.ForeColor = Color.White;
            btnABMUsuarios.Location = new Point(0, 364);
            btnABMUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnABMUsuarios.Name = "btnABMUsuarios";
            btnABMUsuarios.Padding = new Padding(15, 8, 15, 8);
            btnABMUsuarios.Size = new Size(200, 52);
            btnABMUsuarios.TabIndex = 7;
            btnABMUsuarios.Text = "Usuarios";
            btnABMUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnABMUsuarios.Visible = false;
            btnABMUsuarios.Click += btnABMUsuarios_Click;
            // 
            // btnABMPersonas
            // 
            btnABMPersonas.AutoSize = true;
            btnABMPersonas.Dock = DockStyle.Top;
            btnABMPersonas.FlatAppearance.BorderSize = 0;
            btnABMPersonas.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMPersonas.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMPersonas.FlatStyle = FlatStyle.Flat;
            btnABMPersonas.Font = new Font("Segoe UI", 9F);
            btnABMPersonas.ForeColor = Color.White;
            btnABMPersonas.Location = new Point(0, 260);
            btnABMPersonas.Margin = new Padding(3, 4, 3, 4);
            btnABMPersonas.Name = "btnABMPersonas";
            btnABMPersonas.Padding = new Padding(15, 8, 15, 8);
            btnABMPersonas.Size = new Size(200, 52);
            btnABMPersonas.TabIndex = 4;
            btnABMPersonas.Text = "Personas";
            btnABMPersonas.TextAlign = ContentAlignment.MiddleLeft;
            btnABMPersonas.Visible = false;
            btnABMPersonas.Click += btnABMPersonas_Click;
            // 
            // btnABMEspecialidades
            // 
            btnABMEspecialidades.AutoSize = true;
            btnABMEspecialidades.Dock = DockStyle.Top;
            btnABMEspecialidades.FlatAppearance.BorderSize = 0;
            btnABMEspecialidades.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMEspecialidades.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMEspecialidades.FlatStyle = FlatStyle.Flat;
            btnABMEspecialidades.Font = new Font("Segoe UI", 9F);
            btnABMEspecialidades.ForeColor = Color.White;
            btnABMEspecialidades.Location = new Point(0, 156);
            btnABMEspecialidades.Margin = new Padding(3, 4, 3, 4);
            btnABMEspecialidades.Name = "btnABMEspecialidades";
            btnABMEspecialidades.Padding = new Padding(15, 8, 15, 8);
            btnABMEspecialidades.Size = new Size(200, 52);
            btnABMEspecialidades.TabIndex = 2;
            btnABMEspecialidades.Text = "Especialidades";
            btnABMEspecialidades.TextAlign = ContentAlignment.MiddleLeft;
            btnABMEspecialidades.Visible = false;
            btnABMEspecialidades.Click += btnABMEspecialidades_Click;
            // 
            // btnABMDictados
            // 
            btnABMDictados.AutoSize = true;
            btnABMDictados.Dock = DockStyle.Top;
            btnABMDictados.FlatAppearance.BorderSize = 0;
            btnABMDictados.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMDictados.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMDictados.FlatStyle = FlatStyle.Flat;
            btnABMDictados.Font = new Font("Segoe UI", 9F);
            btnABMDictados.ForeColor = Color.White;
            btnABMDictados.Location = new Point(0, 104);
            btnABMDictados.Margin = new Padding(3, 4, 3, 4);
            btnABMDictados.Name = "btnABMDictados";
            btnABMDictados.Padding = new Padding(15, 8, 15, 8);
            btnABMDictados.Size = new Size(200, 52);
            btnABMDictados.TabIndex = 6;
            btnABMDictados.Text = "Dictados";
            btnABMDictados.TextAlign = ContentAlignment.MiddleLeft;
            btnABMDictados.Visible = false;
            btnABMDictados.Click += btnABMDictados_Click;
            // 
            // btnABMCursos
            // 
            btnABMCursos.AutoSize = true;
            btnABMCursos.Dock = DockStyle.Top;
            btnABMCursos.FlatAppearance.BorderSize = 0;
            btnABMCursos.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMCursos.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMCursos.FlatStyle = FlatStyle.Flat;
            btnABMCursos.Font = new Font("Segoe UI", 9F);
            btnABMCursos.ForeColor = Color.White;
            btnABMCursos.Location = new Point(0, 52);
            btnABMCursos.Margin = new Padding(3, 4, 3, 4);
            btnABMCursos.Name = "btnABMCursos";
            btnABMCursos.Padding = new Padding(15, 8, 15, 8);
            btnABMCursos.Size = new Size(200, 52);
            btnABMCursos.TabIndex = 1;
            btnABMCursos.Text = "Cursos";
            btnABMCursos.TextAlign = ContentAlignment.MiddleLeft;
            btnABMCursos.Visible = false;
            btnABMCursos.Click += btnABMCursos_Click;
            // 
            // btnABMComisiones
            // 
            btnABMComisiones.AutoSize = true;
            btnABMComisiones.Dock = DockStyle.Top;
            btnABMComisiones.FlatAppearance.BorderSize = 0;
            btnABMComisiones.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMComisiones.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMComisiones.FlatStyle = FlatStyle.Flat;
            btnABMComisiones.Font = new Font("Segoe UI", 9F);
            btnABMComisiones.ForeColor = Color.White;
            btnABMComisiones.Location = new Point(0, 0);
            btnABMComisiones.Margin = new Padding(3, 4, 3, 4);
            btnABMComisiones.Name = "btnABMComisiones";
            btnABMComisiones.Padding = new Padding(15, 8, 15, 8);
            btnABMComisiones.Size = new Size(200, 52);
            btnABMComisiones.TabIndex = 0;
            btnABMComisiones.Text = "Comisiones";
btnABMComisiones.TextAlign = ContentAlignment.MiddleLeft;
            btnABMComisiones.Visible = false;
            btnABMComisiones.Click += btnABMComisiones_Click;
            // 
            // btnABMPlanMaterias
            // 
            btnABMPlanMaterias.AutoSize = true;
            btnABMPlanMaterias.Dock = DockStyle.Top;
            btnABMPlanMaterias.FlatAppearance.BorderSize = 0;
            btnABMPlanMaterias.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnABMPlanMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnABMPlanMaterias.FlatStyle = FlatStyle.Flat;
            btnABMPlanMaterias.Font = new Font("Segoe UI", 9F);
            btnABMPlanMaterias.ForeColor = Color.White;
            btnABMPlanMaterias.Location = new Point(0, 520);
            btnABMPlanMaterias.Margin = new Padding(3, 4, 3, 4);
            btnABMPlanMaterias.Name = "btnABMPlanMaterias";
            btnABMPlanMaterias.Padding = new Padding(15, 8, 15, 8);
            btnABMPlanMaterias.Size = new Size(200, 52);
            btnABMPlanMaterias.TabIndex = 10;
            btnABMPlanMaterias.Text = "Plan/Materias";
            btnABMPlanMaterias.TextAlign = ContentAlignment.MiddleLeft;
            btnABMPlanMaterias.Visible = false;
            btnABMPlanMaterias.Click += btnABMPlanMaterias_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(69, 90, 100);
            panelBottom.Controls.Add(btnActualizar);
            panelBottom.Controls.Add(btnSalir);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(220, 688);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(780, 62);
            panelBottom.TabIndex = 4;
            panelBottom.Visible = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Dock = DockStyle.Right;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F);
            btnActualizar.ForeColor = Color.FromArgb(255, 193, 7);
            btnActualizar.Location = new Point(503, 0);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(157, 62);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Refrescar Datos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 90, 100);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 125, 139);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(660, 0);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 62);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Cerrar Vista";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 750);
            Controls.Add(panelDashboard);
            Controls.Add(panelFormLoader);
            Controls.Add(panelSubMenu);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academia TPI";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelPerfil.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSubMenu.ResumeLayout(false);
            panelSubMenu.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnReportesRendimientoDocente;
        private System.Windows.Forms.Button btnReportesRendimientoAlumnos;
        private System.Windows.Forms.Button btnABMUsuarios;
        private System.Windows.Forms.Button btnABMPersonas;
        private System.Windows.Forms.Button btnABMEspecialidades;
        private System.Windows.Forms.Button btnABMDictados;
        private System.Windows.Forms.Button btnABMCursos;
        private System.Windows.Forms.Button btnABMComisiones;
        private System.Windows.Forms.Button btnABMPlanMaterias;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDashboard;
    }
}
