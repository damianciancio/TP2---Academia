using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        
        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        
        private Comision comision;

        public Comision Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        private int _anioCalendario;

        public int AnioCalendario
        {
            get { return _anioCalendario; }
            set { _anioCalendario = value; }
        }
        private int cupo;

        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
    }
}
