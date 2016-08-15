using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _descMateria;

        public string DescMateria
        {
            get { return _descMateria; }
            set { _descMateria = value; }
        }
        private int _hsSemanales;

        public int HsSemanales
        {
            get { return _hsSemanales; }
            set { _hsSemanales = value; }
        }
        private int _hsTotales;

        public int HsTotales
        {
            get { return _hsTotales; }
            set { _hsTotales = value; }
        }
        
        private Plan plan;

        public Plan Plan
        {
            get { return plan; }
            set { plan = value; }
        }
    }
}
