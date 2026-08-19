using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Servicios.Excepciones;

namespace Servicios
{
    public static class ErrorDbTraductor
    {
        private const int SqlForeignKeyViolation = 547;
        private const int SqlUniqueConstraintViolation = 2601;
        private const int SqlUniqueKeyViolation = 2627;

        public static ServicioException Traducir(DbUpdateException ex)
        {
            var numero = ObtenerNumeroSql(ex);
            var mensaje = numero switch
            {
                SqlForeignKeyViolation =>
                    "No se puede eliminar o modificar el registro: hay entidades relacionadas que dependen de él.",
                SqlUniqueConstraintViolation or SqlUniqueKeyViolation =>
                    "Ya existe un registro con esos datos únicos (por ejemplo, legajo o nombre de usuario).",
                _ => "No se pudo completar la operación en la base de datos. Intente nuevamente."
            };
            return new ServicioException(mensaje, ex);
        }

        private static int? ObtenerNumeroSql(Exception ex)
        {
            var inner = ex.InnerException;
            if (inner == null) return null;
            var propiedadNumero = inner.GetType().GetProperty("Number");
            return propiedadNumero?.GetValue(inner) as int?;
        }
    }
}
