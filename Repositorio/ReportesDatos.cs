using System.Data;
using Microsoft.Data.SqlClient;

namespace Repositorio
{
    public class ReportesDatos
    {
        private readonly string _connectionString;

        public ReportesDatos()
        {
            _connectionString = "Server=localhost\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public ReportesDatos(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetDocentes()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT ID, Nombre, Apellido, Legajo " +
                "FROM Personas " +
                "WHERE Tipo = 2 " +
                "ORDER BY Apellido, Nombre", connection);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAlumnos()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT ID, Nombre, Apellido, Legajo " +
                "FROM Personas " +
                "WHERE Tipo = 1 " +
                "ORDER BY Apellido, Nombre", connection);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAlumnosDeDocente(int docenteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT DISTINCT p.ID, p.Nombre, p.Apellido, p.Legajo " +
                "FROM AlumnoInscripciones ai " +
                "INNER JOIN Personas p ON ai.AlumnoId = p.ID " +
                "INNER JOIN DocenteCursos dc ON ai.CursoId = dc.CursoId " +
                "WHERE dc.DocenteId = @DocenteId " +
                "ORDER BY p.Apellido, p.Nombre", connection);

            command.Parameters.AddWithValue("@DocenteId", docenteId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataRow? GetPersona(int personaId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT ID, Nombre, Apellido, Legajo, Tipo " +
                "FROM Personas " +
                "WHERE ID = @PersonaId", connection);

            command.Parameters.AddWithValue("@PersonaId", personaId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public DataTable GetRendimientoDocente(int docenteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT dc.DocenteId, " +
                "m.Descripcion AS Materia, " +
                "com.Descripcion AS Comision, " +
                "c.AnioCalendario AS Anio, " +
                "dc.Cargo, " +
                "COUNT(ai.ID) AS Inscriptos, " +
                "SUM(CASE WHEN ai.Condicion = 2 THEN 1 ELSE 0 END) AS Aprobados, " +
                "SUM(CASE WHEN ai.Condicion = 1 THEN 1 ELSE 0 END) AS Regulares, " +
                "SUM(CASE WHEN ai.Condicion = 0 THEN 1 ELSE 0 END) AS SinNota, " +
                "CASE WHEN SUM(CASE WHEN ai.Nota IS NOT NULL THEN 1 ELSE 0 END) > 0 " +
                "     THEN CAST(SUM(ai.Nota) AS float) / SUM(CASE WHEN ai.Nota IS NOT NULL THEN 1 ELSE 0 END) " +
                "     ELSE NULL END AS Promedio " +
                "FROM DocenteCursos dc " +
                "INNER JOIN Cursos c ON dc.CursoId = c.ID " +
                "INNER JOIN Materias m ON c.MateriaId = m.ID " +
                "INNER JOIN Comisiones com ON c.ComisionId = com.ID " +
                "LEFT JOIN AlumnoInscripciones ai ON c.ID = ai.CursoId " +
                "WHERE dc.DocenteId = @DocenteId " +
                "GROUP BY dc.DocenteId, m.Descripcion, com.Descripcion, c.AnioCalendario, dc.Cargo, c.ID " +
                "ORDER BY c.AnioCalendario, m.Descripcion, com.Descripcion", connection);

            command.Parameters.AddWithValue("@DocenteId", docenteId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetRendimientoAlumno(int alumnoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT ai.AlumnoId, " +
                "p.Nombre, p.Apellido, p.Legajo, " +
                "m.Descripcion AS Materia, " +
                "com.Descripcion AS Comision, " +
                "c.AnioCalendario AS Anio, " +
                "ai.Nota, ai.Condicion " +
                "FROM AlumnoInscripciones ai " +
                "INNER JOIN Personas p ON ai.AlumnoId = p.ID " +
                "INNER JOIN Cursos c ON ai.CursoId = c.ID " +
                "INNER JOIN Materias m ON c.MateriaId = m.ID " +
                "INNER JOIN Comisiones com ON c.ComisionId = com.ID " +
                "WHERE ai.AlumnoId = @AlumnoId " +
                "ORDER BY c.AnioCalendario, m.Descripcion", connection);

            command.Parameters.AddWithValue("@AlumnoId", alumnoId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetRendimientoAlumnosDeDocente(int docenteId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT ai.AlumnoId, " +
                "p.Nombre, p.Apellido, p.Legajo, " +
                "m.Descripcion AS Materia, " +
                "com.Descripcion AS Comision, " +
                "c.AnioCalendario AS Anio, " +
                "ai.Nota, ai.Condicion " +
                "FROM AlumnoInscripciones ai " +
                "INNER JOIN Personas p ON ai.AlumnoId = p.ID " +
                "INNER JOIN Cursos c ON ai.CursoId = c.ID " +
                "INNER JOIN Materias m ON c.MateriaId = m.ID " +
                "INNER JOIN Comisiones com ON c.ComisionId = com.ID " +
                "INNER JOIN DocenteCursos dc ON ai.CursoId = dc.CursoId " +
                "WHERE dc.DocenteId = @DocenteId " +
                "ORDER BY p.Apellido, p.Nombre, c.AnioCalendario, m.Descripcion", connection);

            command.Parameters.AddWithValue("@DocenteId", docenteId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
