# Academia TPI

## Índice
1. [Introducción](#introducción)
   - [Plataformas](#plataformas)
   - [Roles](#roles)
   - [Funcionalidades Principales](#funcionalidades-principales)
   - [Requisitos no Funcionales](#requisitos-no-funcionales)
2. [Capturas de Pantalla](#capturas-de-pantalla)
   - [Interfaz de Escritorio](#interfaz-de-escritorio)
   - [Interfaz Web](#interfaz-web)
3. [Modelo de Datos](#modelo-de-datos)
4. [Modelo de Clases](#modelo-de-clases)
5. [Arquitectura](#arquitectura)
   - [Patrones Clave](#patrones-clave)
6. [API REST y Swagger](#api-rest-y-swagger)
7. [Tecnologías Utilizadas](#tecnologías-utilizadas)
   - [Paquetes NuGet](#paquetes-nuget)
8. [Configuración en Local](#configuración-en-local)
   - [Credenciales de Prueba](#credenciales-de-prueba)

## Introducción
**Academia TPI** es un sistema para la administración de actividades académicas: inscripciones, registro de notas, asignación de docentes a cursos, CRUD de entidades, y reportes de rendimiento con gráficos estadísticos.

### Plataformas
| | |
|---|---|
| **Escritorio** | WinForms (.NET 8.0) |
| **Web** | Blazor Server |
| **API** | Minimal API (.NET 8.0) + Swagger |
| **Base de datos** | Microsoft SQL Server + Entity Framework Core |

### Roles
| Rol | Permisos |
|-----|----------|
| **Administrador** | CRUD de todas las entidades, inscripciones, calificaciones |
| **Docente** | Calificar alumnos en cursos asignados, ver reportes propios |
| **Alumno** | Inscribirse a cursos, ver inscripciones y reportes propios |

### Funcionalidades Principales
- **CRUD:** Especialidades, Planes, Materias, Comisiones, Cursos, Personas, Usuarios
- **Dictados:** Asignación de docentes a cursos con cargo (Profesor, Jefe de Cátedra, Auxiliar)
- **Inscripciones:** Alta/baja con validación de cupo y duplicados
- **Registro de Notas:** Condición automática (Aprobado ≥6, Regular ≥4, Inscripto <4)
- **Reportes:** Rendimiento docente (barras) y de alumnos (torta) en PDF con FastReport + SkiaSharp

### Requisitos no Funcionales
- **Seguridad:** Hash PBKDF2-SHA256, autorización por rol, protección contra timing attacks
- **Rendimiento:** `AsNoTracking`, eager loading explícito, cache de `ClaimsPrincipal`
- **Usabilidad:** Auto-refresh 5s, validaciones en tiempo real, feedback toast, traducción de errores DB
- **Mantenibilidad:** Arquitectura en capas, repositorio genérico, service layer con guards de auth

## Capturas de Pantalla
### Interfaz de Escritorio
#### Login
![login-desktop](./capturas/desktop/login.png)
#### Menú de Acceso
![menu-de-acceso-desktop](./capturas/desktop/menu-de-acceso.png)
#### CRUD de Entidades
![crud-entidades-desktop](./capturas/desktop/crud-entidades.png)
![crud-entidades-dialog-desktop](./capturas/desktop/crud-entidades-dialog.png)
#### Inscripciones
![inscripciones-desktop](./capturas/desktop/inscripciones.png)
![inscripciones-dialog-desktop](./capturas/desktop/inscripciones-dialog.png)
#### Registro de Notas
![registrar-notas-desktop](./capturas/desktop/registrar-notas.png)
![registrar-notas-dialog-desktop](./capturas/desktop/registrar-notas-dialog.png)
#### Generación de Reportes
![reportes-rendimiento-alumnos-desktop](./capturas/desktop/reportes-rendimiento-alumnos.png)
![reportes-rendimiento-docentes-desktop](./capturas/desktop/reportes-rendimiento-docentes.png)

### Interfaz Web
#### Login
![login-web](./capturas/web/login.png)
#### Menú de Acceso
![menu-de-acceso-web](./capturas/web/menu-de-acceso.png)
#### CRUD de Entidades
![crud-entidades-web](./capturas/web/crud-entidades.png)
#### Inscripciones
![inscripciones-web](./capturas/web/inscripciones.png)
![inscripciones-dialog-web](./capturas/web/inscripciones-dialog.png)
#### Registro de Notas
![registrar-notas-web](./capturas/web/registrar-notas.png)
![registrar-notas-dialog-web](./capturas/web/registrar-notas-dialog.png)
#### Generación de Reportes
![reportes-rendimiento-alumnos-web](./capturas/web/reportes-rendimiento-alumnos.png)
![reportes-rendimiento-docentes-web](./capturas/web/reportes-rendimiento-docentes.png)

## Modelo de Datos
![modelo-de-datos](./capturas/modelo-de-datos.png)

## Modelo de Clases
![modelo-de-clases](./capturas/modelo-de-clases.jpg)

## Arquitectura
Arquitectura en capas con 7 proyectos.

![diagrama-de-arquitectura](./capturas/diagrama-de-arquitectura.png)

| Proyecto | Capa | Responsabilidad |
|----------|------|-----------------|
| **Dominio** | Modelo | Entidades de negocio, enums, relaciones EF |
| **Repositorio** | Datos | DbContext, repositorio genérico, ADO.NET para reportes |
| **Servicios** | Negocio | Lógica de negocio, validaciones, guards de auth |
| **Utils** | Transversal | Hash de contrasenas, regex, helpers de enums |
| **UI.Desktop** | Presentación | WinForms con sidebar y navegación por paneles |
| **UI.Web** | Presentación | Blazor Server con layout, auth por cookies+JWT |
| **UI.Api** | Presentación | Minimal API REST con Swagger, auth por JWT |

### Patrones Clave

- **Repositorio genérico** `Repositorio<T>` con CRUD reutilizable
- **Service Layer** con `ServicioBase` abstracto y guards (`RequiereAdmin`, `RequiereAutenticacion`)
- **Traducción de errores DB** a mensajes amigables (FK, unique constraint)
- **`IUsuarioContexto`** para abstraer el contexto de usuario entre Desktop y Web
- **CRUD Maestro/Detalle:** Formulario `PlanMaterias` con grilla superior (Plan) e inferior (Materias) sincronizadas por selección (Solo disponible en Desktop)

## API REST y Swagger
El proyecto **UI.Api** (Minimal API .NET 8.0) expone todos los servicios como endpoints REST con documentación interactiva en Swagger. Permite probar el sistema independientemente de las interfaces (WinForms/Blazor).

### Cómo ejecutar
```
dotnet run --project UI.Api
```
Abrir http://localhost:5006/swagger (o https://localhost:7103/swagger).

### Autenticación
1. Ejecutar `POST /api/auth/login` con las credenciales de prueba (ej. `lferreyra` / `admin123`).
2. Copiar el `token` devuelto.
3. Click en **Authorize** y pegar el token. Los endpoints protegidos muestran candado y envían el token automáticamente.
4. El endpoint `/api/auth/login` es público (sin candado).

### Endpoints
| Grupo | Endpoints |
|-------|-----------|
| Especialidades | `GET/POST /api/especialidades`, `GET/PUT/DELETE /api/especialidades/{id}` |
| Planes | CRUD + `GET /api/planes/por-especialidad/{especialidadId}` |
| Materias | CRUD + `GET /api/materias/por-plan/{planId}` |
| Comisiones | CRUD + `GET /api/comisiones/por-plan/{planId}` |
| Cursos | CRUD + `GET /api/cursos/por-materia-comision?materiaId&comisionId` |
| Personas | CRUD + `GET /api/personas/por-tipo/{tipo}`, `GET /api/personas/por-legajo/{legajo}` |
| Usuarios | CRUD + `GET /api/usuarios/por-usuario/{nombreUsuario}` |
| DocenteCurso | CRUD + `GET /api/docentes-cursos/por-docente/{docenteId}`, `por-curso/{cursoId}`, `POST /api/docentes-cursos/asignar` |
| Inscripciones | CRUD + `GET /api/inscripciones/por-alumno/{alumnoId}`, `por-curso/{cursoId}`, `POST /api/inscripciones/inscribir` |
| Reportes | `GET /api/reportes/docentes`, `alumnos`, `alumnos-de-docente/{docenteId}` y PDFs de rendimiento (`/rendimiento-.../pdf`) |

Los permisos se validan igual que en las interfaces: los guards de `ServicioBase` devuelven `401` (no autenticado) o `403` (rol sin permisos) según el token.

## Tecnologías Utilizadas
| Categoría | Tecnología | Versión |
|-----------|-----------|---------|
| **Framework** | .NET | 8.0 |
| **IDE** | Visual Studio | 2022 |
| **Base de datos** | Microsoft SQL Server Express | — |
| **Web** | Blazor Server | — |
| **API** | Minimal API + Swagger | — |
| **Escritorio** | Windows Forms | — |

### Paquetes NuGet

| Paquete | Proyecto | Versión | Uso |
|---------|----------|---------|-----|
| Entity Framework Core | Repositorio | 8.0.0 | ORM para acceso a datos |
| EF Core SqlServer | Repositorio | 8.0.0 | Provider SQL Server |
| Microsoft.Data.SqlClient | Repositorio | 7.0.2 | ADO.NET para consultas de reportes |
| FastReport.OpenSource | Repositorio, Servicios, UI.Desktop, UI.Web | 2026.2.3 | Motor de reportes y generación de PDF |
| FastReport.OpenSource.Export.PdfSimple | Repositorio, UI.Web | 2026.2.3 | Exportación a PDF |
| SkiaSharp | Repositorio | 2.88.8 | Generación de gráficos (barras, torta) |
| SkiaSharp.NativeAssets.Linux.NoDependencies | Repositorio | 2.88.8 | Soporte nativo Linux para SkiaSharp |
| Microsoft.Extensions.Configuration | Repositorio | 8.0.0 | Lectura de archivos de configuración |
| Microsoft.Extensions.Configuration.Json | Repositorio | 8.0.0 | Lectura de appsettings.json |
| Microsoft.Web.WebView2 | UI.Desktop | 1.0.2903.40 | Visor de PDF integrado en WinForms |
| Microsoft.AspNetCore.Authentication.JwtBearer | UI.Web, UI.Api | 8.0.30 | Autenticación JWT (Blazor Server y API REST) |
| Swashbuckle.AspNetCore | UI.Api | 6.6.2 | Documentación Swagger / OpenAPI |

## Configuración en Local
El connection string está en `Repositorio/appsettings.Repositorio.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=Academia;TrustServerCertificate=True;Trusted_Connection=True;"
  }
}
```

Si tu instancia de SQL Server se llama distinto, cambiá el Server. La base de datos se crea automáticamente al iniciar (schema + datos de prueba via EnsureCreated()).

### Credenciales de Prueba
| Usuario   | Contraseña | Tipo          | Acceso                |
|-----------|------------|---------------|-----------------------|
| lferreyra | admin123   | Administrador | Todo (CRUD + Reportes) |
| vrios     | doc2024    | Docente       | Registrar Notas       |
| clopez    | alu2024    | Alumno        | Inscripciones         |

Hay más usuarios de prueba en el archivo de [CREDENCIALES.md](./CREDENCIALES.md).
