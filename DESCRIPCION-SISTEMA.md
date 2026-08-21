# Academia TPI - Informe del Sistema

---

## Indice

1. Introduccion
2. Tecnologias utilizadas
3. Arquitectura
4. Analisis y Diseno
5. Fragmentos de codigo
6. Base de datos

---

## 1. Introduccion

El sistema **Academia TPI** permite registrar y administrar actividades academicas tales como inscripciones, registro de notas, generacion de informes, creacion de cursos, ABMC de diferentes entidades, asignacion de docentes a cursos, y reportes de rendimiento con graficos estadisticos.

El sistema puede ser utilizado por cualquier persona que posea un usuario con el rol de **Alumno**, **Docente** o **Administrador** (direccion academica).

El mismo se ejecuta en dos plataformas: una aplicacion de **escritorio** desarrollada en WinForms, y una aplicacion **web** desarrollada en Blazor Server. Los datos son almacenados en una base de datos **Microsoft SQL Server**, accedida mediante Entity Framework Core.

El disenio esta unificado en ambas plataformas y una vez que un usuario ingresa, solo puede realizar acciones permitidas segun su rol.

Los **Usuarios** poseen un usuario y contrasena, una Persona asociada, y pueden ser habilitados o inhabilitados.

Las **Personas** pueden tomar el rol de Administrador, Alumno, o Docente, y tienen datos en comun tales como Legajo, Nombre, Apellido, Direccion, entre otros. Las **Materias** pertenecen a un **Plan** y tienen cantidad de horas de cursado semanales y totales. Los **Planes** son de una **Especialidad**.

La relacion entre una Persona del tipo Docente y un Curso se llama **DocenteCurso** (Dictado). La relacion entre una Persona del tipo Alumno y un Curso se llama **AlumnoInscripcion** (Inscripcion).

### 1.1 Requerimientos funcionales

#### Autenticacion y Autorizacion

- Login con usuario y contrasena hasheada (PBKDF2-SHA256).
- Tres roles: Administrador, Docente, Alumno.
- Control de acceso por rol en cada funcionalidad.
- Sesion con expiracion (60 minutos en Web).

#### ABM de Entidades (Administrador)

- **Especialidades:** Alta, baja, modificacion y consulta. Validacion de descripcion no vacia.
- **Planes:** ABM con FK a Especialidad. Validacion de descripcion y especialidad valida.
- **Materias:** ABM con FK a Plan. Horas totales >= horas semanales.
- **Comisiones:** ABM con FK a Plan. Anio de especialidad entre 1 y 10.
- **Cursos:** ABM con FK a Materia y Comision. Unicidad (materia+comision+anio). Cupo >= cantidad de inscriptos.
- **Personas:** ABM con datos personales (nombre, apellido, legajo, tipo, email, telefono, direccion, fecha de nacimiento). Legajo unico. Alumnos requieren Plan asociado.
- **Usuarios:** ABM con nombre de usuario, contrasena hasheada, persona asociada y estado habilitado/deshabilitado. Username unico, maximo 15 caracteres, sin espacios. No se puede deshabilitar el ultimo administrador.

#### Dictados (Asignacion de Docentes a Cursos)

- Asignar un docente a un curso con un cargo (Profesor, Jefe de Catedra, Auxiliar).
- Validacion: docente debe ser de tipo Docente, no duplicar asignacion (mismo docente+curso+cargo).

#### Inscripciones

- Administrador: inscribir cualquier alumno a cualquier curso, eliminar inscripciones.
- Alumno: inscribirse a cursos disponibles, visualizar propias inscripciones.
- Validaciones: cupo disponible, no doble inscripcion en mismo curso.

#### Registro de Notas

- Docente: calificar alumnos en sus cursos asignados.
- Administrador: calificar en cualquier curso.
- Condiciones automaticas: nota >= 6 Aprobado, >= 4 Regular, < 4 Inscripto.

#### Reportes de Rendimiento

- Rendimiento Docente: estadisticas por curso (aprobados, regulares, sin nota) con grafico de barras agrupadas.
- Rendimiento Alumnos: rendimiento individual por materia con grafico de torta (distribucion de condiciones).
- Generacion automatica de PDF cuando el usuario es conocido (alumno o docente).
- Descarga con nombre descriptivo: `reporte-rendimiento-[tipo]-[legajo]-[nombre]-[apellido]-[fecha].pdf`.

### 1.2 Requerimientos no funcionales

#### Seguridad

- Contrasenas hasheadas con PBKDF2-SHA256 (10000 iteraciones, salt de 16 bytes).
- Comparacion con `CryptographicOperations.FixedTimeEquals` (proteccion contra timing attacks).
- Autorizacion por rol en cada endpoint y pagina.
- Proteccion contra deshabilitacion del ultimo administrador.

#### Rendimiento

- Consultas EF Core con `AsNoTracking` para lecturas.
- Eager loading explicito (`.Include()`) en repositorios especificos.
- Congelacion de grilla WinForms (`WM_SETREDRAW`) durante refresh para evitar parpadeo.
- Cache de `ClaimsPrincipal` en `SesionService` (Web).

#### Usabilidad

- Auto-refresh cada 5 segundos en ambas interfaces, preservando la fila seleccionada.
- Mensajes de feedback toast en Web (auto-dismiss 4 segundos).
- Validaciones en tiempo real con mensajes descriptivos.
- Traduccion automatica de errores de base de datos (FK, unique constraint) a mensajes amigables.

#### Mantenibilidad

- Arquitectura en capas con responsabilidades claras.
- Repositorio generico reutilizable.
- Service Layer con base abstracta y guards de autenticacion.
- Jerarquia de excepciones tipadas.
- Separacion de contexto de usuario (`IUsuarioContexto`) para Desktop y Web.

---

## 2. Tecnologias utilizadas

- **IDE:** Visual Studio 2022
- **Framework:** .NET 8.0
- **Motor de Base de Datos:** Microsoft SQL Server Express
- **Versionado de Codigo:** GitHub

### 2.1 Paquetes NuGet

| Paquete | Proyecto | Version | Uso |
|---------|----------|---------|-----|
| Entity Framework Core | Repositorio | 8.0.0 | ORM para acceso a datos |
| EF Core SqlServer | Repositorio | 8.0.0 | Provider SQL Server |
| Microsoft.Data.SqlClient | Repositorio | 7.0.2 | ADO.NET para consultas de reportes |
| FastReport.OpenSource | Repositorio, Servicios, UI.Desktop, UI.Web | 2026.2.3 | Motor de reportes y generacion de PDF |
| FastReport.OpenSource.Export.PdfSimple | Repositorio, UI.Web | 2026.2.3 | Exportacion a PDF |
| SkiaSharp | Repositorio | 2.88.8 | Generacion de graficos (barras, torta) |
| SkiaSharp.NativeAssets.Linux.NoDependencies | Repositorio | 2.88.8 | Soporte nativo Linux para SkiaSharp |
| Microsoft.Extensions.Configuration | Repositorio | 8.0.0 | Lectura de archivos de configuracion |
| Microsoft.Extensions.Configuration.Json | Repositorio | 8.0.0 | Lectura de appsettings.json |
| Microsoft.Web.WebView2 | UI.Desktop | 1.0.2903.40 | Visor de PDF integrado en WinForms |
| Microsoft.AspNetCore.Authentication.JwtBearer | UI.Web | 8.0.30 | Autenticacion JWT para Blazor Server |

### 2.2 Acceso a datos

El acceso a la base de datos se realiza mediante **Entity Framework Core 8.0**, lo que permite un codigo mas corto y limpio. Se utilizan repositorios genericos con eager loading explicito y consultas `AsNoTracking` para optimizar las lecturas.

Para los reportes se utiliza acceso directo via **ADO.NET** (`Microsoft.Data.SqlClient`) con `SqlConnection`/`SqlCommand` para obtener `DataTable` con datos agregados.

### 2.3 Motor de reportes

Se utiliza **FastReport.OpenSource** (version 2026.2.3) como motor de reportes. Los reportes se definen en archivos de plantilla `.frx` y se exportan a PDF mediante `PDFSimpleExport`.

Las plantillas se encuentran en `Repositorio/Reportes/`:
- `RendimientoDocenteReport.frx`: reporte de rendimiento docente.
- `RendimientoAlumnosReport.frx`: reporte de rendimiento de alumnos.

Los graficos estadisticos se generan con **SkiaSharp** (version 2.88.8):
- **Grafico de barras agrupadas** (`BarrasRendimientoDocente`): muestra la cantidad de Aprobados/Regulares/SinNota por curso.
- **Grafico de torta** (`TortaCondiciones`): muestra la distribucion porcentual de condiciones del alumno.

Ambos graficos se renderizan a 2x resolucion como PNG y se embeben como `PictureObject` dentro de las plantillas FastReport antes de la exportacion a PDF.

### 2.4 Otras tecnologias

- **Blazor Server** para la interfaz web (con componentes compartidos `AutoRefresh` y `MensajeFeedback`)
- **Windows Forms** para la interfaz de escritorio (con form base `ApplicationForm` y navegacion por paneles embebidos)
- **Microsoft.Web.WebView2** (1.0.2903.40) para visor de PDF integrado en Desktop
- **Autenticacion por cookies** (60 min expiracion) + **JWT** (HMAC-SHA256) en la capa web
- **PBKDF2-SHA256** (10000 iteraciones) para hash de contrasenas (implementacion propia en Utils)
- **CSS custom** (714 lineas) con estilos inspirados en Material Design, sidebar fijo, variables CSS

---

## 3. Arquitectura

La solucion implementa una **arquitectura basada en capas**.

### 3.1 Capas y proyectos

| Proyecto | Capa |
|----------|------|
| **Dominio** | Entidades de negocio |
| **Repositorio** | Capa de datos (EF Core + ADO.NET) |
| **Servicios** | Capa de negocios |
| **Utils** | Utilidades transversales |
| **UI.Desktop** | Capa de presentacion: Escritorio |
| **UI.Web** | Capa de presentacion: Web |

### 3.2 Diagrama de capas

```
+-------------------+     +-------------------+
|    UI.Desktop     |     |      UI.Web       |
|   (WinForms)      |     |  (Blazor Server)  |
+--------+----------+     +--------+----------+
         |                         |
         +------------+------------+
                      |
              +-------v--------+
              |    Servicios    |
              +-------+--------+
                      |
              +-------v--------+
              |   Repositorio   |
              +-------+--------+
                      |
              +-------v--------+
              |     Dominio     |
              +----------------+
                      |
              +-------v--------+
              |      Utils     |
              +----------------+
                      |
              +-------v--------+
              |  SQL Server    |
              +----------------+
```

### 3.3 Capa de Datos (Repositorio)

El proyecto **Repositorio** centraliza la conexion a la base de datos utilizando Microsoft SQL Server. El connection string se encuentra en `Repositorio/appsettings.Repositorio.json` y es leido via `ConfigurationBuilder` tanto por `AcademiaContext` (EF Core) como por `ReportesDatos` (ADO.NET).

Para la consulta de los datos se utiliza Entity Framework Core con un `DbContext` (`AcademiaContext`) que contiene 9 DbSets.

Se implementa un **repositorio generico** `Repositorio<T>` con interfaz `IRepositorio<T>` que ofrece operaciones CRUD basicas: `GetAll`, `GetOne`, `Add`, `Update`, `Delete`, `Save`, `Detach`.

Cada entidad tiene un repositorio especifico que extiende al generico y agrega metodos de eager loading con `.Include()`.

Para los reportes se accede directamente a la base via **ADO.NET** (`ReportesDatos.cs`) con `SqlConnection`/`SqlCommand` para obtener `DataTable` con datos agregados.

### 3.4 Capa de Negocios (Servicios)

El proyecto **Servicios** es la capa intermediaria entre la Presentacion y los Datos. Contiene una clase base abstracta `ServicioBase` que ofrece:

- **Guards de autenticacion:** `RequiereAutenticacion()`, `RequiereAdmin()`, `RequiereAdminOAlumno()`, `RequiereAdminODocente()`.
- **`Validar()`** para envolver logica de validacion.
- **`EjecutarPersistencia()`** para envolver operaciones de escritura con traduccion de errores de base de datos.

Se implementa una jerarquia de excepciones: `ServicioException` -> `AccesoNoAutorizadoException`, `ReglaNegocioException`, `ValidacionException`.

### 3.5 Componentes Transversales

- **Entidades:** El proyecto **Dominio** contiene la definicion de cada entidad. Todas extienden de `BusinessEntity` (ID + State). Las relaciones se configuran con Fluent API en el `AcademiaContext`.
- **Utils:** El proyecto **Utils** contiene utilidades generales: hash de contrasenas (PBKDF2-SHA256), validaciones regex (email, nombre, telefono), y helper de enums.

### 3.6 Capa de Presentacion

**Escritorio (UI.Desktop):** Aplicacion WinForms que inicia con un Login. Al iniciar sesion, redirige al usuario a un formulario principal con un sidebar de navegacion. Los forms se embeben dentro de un panel (`panelFormLoader`). Dispone de un timer de auto-refresh cada 5 segundos que preserva la fila seleccionada en las grillas.

**Web (UI.Web):** Aplicacion Blazor Server que utiliza un layout con sidebar fijo y topbar. La autenticacion se realiza con cookies y JWT. Los permisos se controlan por rol via `[Authorize(Roles="...")]`. Dispone de un componente `AutoRefresh` de 5 segundos en todas las paginas CRUD.

---

## 4. Analisis y Diseno

### 4.1 Login

**Escritorio:** Formulario con campos de usuario y contrasena, boton "Iniciar sesion", y label de "Academia TPI". Los campos tienen texto de placeholder que se oculta al enfocar.

**Web:** Pagina con layout dividido: marca "ACADEMIA" a la izquierda, formulario de login a la derecha con campos de usuario y contrasena. El login se realiza via JavaScript interop llamando a `POST /api/auth/login`.

### 4.2 Menu principal

**Escritorio:** Sidebar con perfil del usuario (nombre, tipo, legajo), botones de navegacion (Administracion, Inscripciones, Registrar Notas, Reportes, Inicio), y boton "Cerrar Sesion". El contenido se carga en un panel central. El dashboard muestra cards con acceso rapido a funcionalidades segun rol.

**Web:** Sidebar fijo con secciones colapsables (Administracion con 8 sub-items, Reportes con 2 items), links directos a Inscripciones y Registrar Notas. Topbar con titulo de pagina, legajo, nombre y tipo de usuario.

### 4.3 ABMC de entidades

Ambas plataformas siguen el mismo patron: tabla con datos, botones de Nuevo/Editar/Eliminar, y formulario para alta/modificacion. Las entidades administrables son:

- **Especialidades** (Descripcion)
- **Planes** (Descripcion, Especialidad FK)
- **Materias** (Descripcion, Plan FK, HorasSemanales, HorasTotales)
- **Comisiones** (Descripcion, AnioEspecialidad, Plan FK)
- **Cursos** (Materia FK, Comision FK, AnioCalendario, Cupo)
- **Personas** (Nombre, Apellido, Legajo, Tipo, FechaNacimiento, Email, Telefono, Direccion, Plan FK)
- **Usuarios** (NombreUsuario, Clave, Persona FK, Habilitado)

### 4.4 Dictados (Asignacion de Docentes a Cursos)

Permite asignar un docente a un curso con un cargo (Profesor, Jefe de Catedra, Auxiliar). Valida que el docente sea de tipo Docente y que no exista la misma asignacion.

### 4.5 Inscripciones

**Administrador:** Puede inscribir cualquier alumno a cualquier curso, y eliminar inscripciones. La vista permite filtrar por alumno.

**Alumno:** Puede inscribirse a cursos disponibles y visualizar sus propias inscripciones.

Se valida el cupo disponible y que no exista una inscripcion duplicada.

### 4.6 Registro de Notas

**Docente:** Puede calificar alumnos en sus cursos asignados.

**Administrador:** Puede calificar en cualquier curso.

La condicion se asigna automaticamente segun la nota: >= 6 Aprobado, >= 4 Regular, < 4 Inscripto.

### 4.7 Reportes de Rendimiento

- **Rendimiento Docente:** Estadisticas de un docente (alumnos, promedio, distribucion de condiciones por curso). Incluye grafico de barras agrupadas (Aprobados/Regulares/SinNota por curso).
- **Rendimiento Alumnos:** Rendimiento de un alumno (materias cursadas, notas, condicion). Incluye grafico de torta (distribucion de condiciones).
- **Formato:** PDF generado con FastReport, visualizable en WebView2 (Desktop) o iframe (Web).
- **Nombre de archivo:** `reporte-rendimiento-[docente|alumno]-{Legajo}-{Nombre}-{Apellido}-{fecha}.pdf`.
- Cuando el usuario ya es conocido (alumno o docente), el reporte se genera automaticamente al acceder.

---

## 5. Fragmentos de codigo

### 5.1 Repositorio Generico

```csharp
public class Repositorio<T> : IRepositorio<T> where T : class
{
    protected readonly AcademiaContext _context;

    public List<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking().ToList();
    }

    public T? GetOne(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Add(T entity) => _context.Set<T>().Add(entity);

    public void Update(T entity) => _context.Set<T>().Update(entity);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);

    public void Save()
    {
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }
}
```

### 5.2 Servicio Base con Auth Guards

```csharp
public abstract class ServicioBase
{
    protected readonly IUsuarioContexto _usuarioContexto;

    protected void RequiereAutenticacion()
    {
        if (_usuarioContexto.ObtenerUsuarioActual() == null)
            throw new AccesoNoAutorizadoException("Debe estar autenticado.");
    }

    protected void RequiereAdmin()
    {
        RequiereAutenticacion();
        if (TipoUsuarioActual != Persona.TiposPersonas.Administrador)
            throw new AccesoNoAutorizadoException("Se requiere rol Administrador.");
    }

    protected void EjecutarPersistencia(Action accion, string mensajeError)
    {
        try { accion(); }
        catch (DbUpdateException ex)
        {
            throw ErrorDbTraductor.Traducir(ex, mensajeError);
        }
    }
}
```

### 5.3 Contexto Entity Framework con Seed Data

```csharp
public class AcademiaContext : DbContext
{
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Comision> Comisiones { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<DocenteCurso> DocenteCursos { get; set; }
    public DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // FK con DeleteBehavior.Restrict
        // Propiedades navigacionales con PropertyAccessMode.Field
        // SeedData: 5 Especialidades, 8 Planes, 12 Materias,
        // 12 Comisiones, 10 Cursos, 13 Personas, 12 Usuarios
    }
}
```

### 5.4 Hash de contrasenas

```csharp
public static class PasswordHasher
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 10000;

    public static string Hash(string password)
    {
        using var salt = new Rfc2898DeriveBytes(
            Encoding.UTF8.GetBytes(password),
            SaltSize, Iterations, HashAlgorithmName.SHA256);
        var key = salt.GetBytes(KeySize);
        var saltBytes = salt.Salt;
        return Convert.ToBase64String(
            new byte[] { 0x01 }
            .Concat(saltBytes).Concat(key).ToArray());
    }

    public static bool Verify(string password, string hash)
    {
        // Decodifica salt + key, re-hash y compara con FixedTimeEquals
    }
}
```

---

## 6. Base de datos

### 6.1 Tablas principales

| Tabla | Descripcion |
|-------|-------------|
| `Especialidades` | Especialidades academicas |
| `Planes` | Planes de estudio por especialidad |
| `Materias` | Materias por plan con horas semanales y totales |
| `Comisiones` | Comisiones por plan con anio de especialidad |
| `Cursos` | Vinculan materia + comision + anio con cupo |
| `Personas` | Alumnos, docentes y administradores |
| `Usuarios` | Credenciales de acceso vinculadas a personas |
| `DocenteCursos` | Asignacion de docentes a cursos con cargo |
| `AlumnoInscripciones` | Inscripciones con condicion y nota |

### 6.2 Relaciones

```
Especialidad 1---N Plan
Plan 1---N Materia
Plan 1---N Comision
Materia 1---N Curso
Comision 1---N Curso
Persona 1---N Usuario
Persona 1---N DocenteCurso
Curso 1---N DocenteCurso
Persona 1---N AlumnoInscripcion
Curso 1---N AlumnoInscripcion
```

### 6.3 Datos de prueba (Seed Data)

| Entidad | Cantidad |
|---------|----------|
| Especialidades | 5 |
| Planes | 8 |
| Comisiones | 12 |
| Materias | 12 |
| Cursos | 10 |
| Personas | 13 (1 admin, 4 docentes, 8 alumnos) |
| Usuarios | 12 |
| DocenteCursos | 6 |
| AlumnoInscripciones | 37 |

### 6.4 Configuracion del Connection String

El connection string se encuentra centralizado en `Repositorio/appsettings.Repositorio.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=Academia;TrustServerCertificate=True;Trusted_Connection=True;"
  }
}
```

Es leido via `ConfigurationBuilder` tanto por `AcademiaContext` (EF Core) como por `ReportesDatos` (ADO.NET). El archivo se llama `appsettings.Repositorio.json` (y no `appsettings.json`) para evitar colision con el `appsettings.json` de UI.Web. Para cambiar la base de datos, solo es necesario modificar este archivo.
