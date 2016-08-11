using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private DateTime _fechaNac;

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }
        private string _Email;
        
        public string Email
        {
          get { return _Email; }
          set { _Email = value; }
        }
        
        private int _legajo;

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        private int _tipoPersona;

        public int TipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }
        private int _idPlan;

        public int IdPlan
        {
            get { return _idPlan; }
            set { _idPlan = value; }
        }
        private Plan plan;

        public Plan Plan
        {
            get { return plan; }
            set { plan = value; }
        }
    }
}
