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

        public DataTable GetAllCursos()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT c.ID, c.AnioCalendario, c.Cupo, " +
                "m.Descripcion AS Materia, " +
                "com.Descripcion AS Comision " +
                "FROM Cursos c " +
                "INNER JOIN Materias m ON c.MateriaId = m.ID " +
                "INNER JOIN Comisiones com ON c.ComisionId = com.ID " +
                "ORDER BY c.ID", connection);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetCursoDetalle(int cursoId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT c.ID, c.AnioCalendario, c.Cupo, " +
                "m.Descripcion AS DescripcionMateria, " +
                "com.Descripcion AS DescripcionComision, " +
                "p.Nombre, p.Apellido, p.Legajo " +
                "FROM Cursos c " +
                "INNER JOIN Materias m ON c.MateriaId = m.ID " +
                "INNER JOIN Comisiones com ON c.ComisionId = com.ID " +
                "LEFT JOIN AlumnoInscripciones ai ON c.ID = ai.CursoId " +
                "LEFT JOIN Personas p ON ai.AlumnoId = p.ID " +
                "WHERE c.ID = @CursoId", connection);

            command.Parameters.AddWithValue("@CursoId", cursoId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetAllPlanes()
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT p.ID, p.Descripcion, " +
                "e.Descripcion AS Especialidad, " +
                "e.ID AS IDEspecialidad " +
                "FROM Planes p " +
                "INNER JOIN Especialidades e ON p.EspecialidadId = e.ID " +
                "ORDER BY p.ID", connection);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetPlanDetalle(int planId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(
                "SELECT p.ID, p.Descripcion, " +
                "e.Descripcion AS DescripcionEspecialidad, " +
                "e.ID AS IDEspecialidad " +
                "FROM Planes p " +
                "INNER JOIN Especialidades e ON p.EspecialidadId = e.ID " +
                "WHERE p.ID = @PlanId", connection);

            command.Parameters.AddWithValue("@PlanId", planId);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
