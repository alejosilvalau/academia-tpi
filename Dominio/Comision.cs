namespace Dominio
{
    public class Comision : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AnioEspecialidad { get; set; }

        public int PlanId { get; set; }
        private Plan _plan;
        public virtual Plan Plan
        {
            get
            {
                return _plan;
            }
            set
            {
                if (value != null)
                {
                    _plan = value;
                    PlanId = value.ID;
                }
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
