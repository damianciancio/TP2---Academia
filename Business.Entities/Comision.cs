using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private string _descComision;

        public string DescComision
        {
            get { return _descComision; }
            set { _descComision = value; }
        }
        private int _anioEspecialidad;

        public int AnioEspecialidad
        {
            get { return _anioEspecialidad; }
            set { _anioEspecialidad = value; }
        }
        private int _idPlan;

        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }

        private Plan _plan;
        public Plan Plan
        {
            get;
            set;
        }

    }
}
