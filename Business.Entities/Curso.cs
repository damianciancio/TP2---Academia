using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Curso : BusinessEntity
    {
        private int _idMateria;

        public int IdMateria
        {
            get { return _idMateria; }
            set { _idMateria = value; }
        }
        private Materia materia;

        internal Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        private int _idComision;

        public int IdComision
        {
            get { return _idComision; }
            set { _idComision = value; }
        }
        private Comision comision;

        internal Comision Comision
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
