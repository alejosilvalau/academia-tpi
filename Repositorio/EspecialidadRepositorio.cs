using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class EspecialidadRepositorio : Repositorio<Especialidad>, IRepositorio<Especialidad>
    {
        public EspecialidadRepositorio(AcademiaContext ctx) : base(ctx) { }
    }
}
