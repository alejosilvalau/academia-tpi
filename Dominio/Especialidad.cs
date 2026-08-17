namespace Dominio
{
    public class Especialidad : BusinessEntity
    {
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
