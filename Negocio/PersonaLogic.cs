using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Negocio
{
    public class PersonaLogic : Negocio
    {
        public PersonaAdapter PersonaData
        {
            get;
            set;
        }

        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        public List<Persona> GetAll()
        {
            try
            {
                return PersonaData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Persona GetOne(int ID)
        {
            try
            {
                return PersonaData.GetOne(ID);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

        public void Save(Persona pe)
        {
            PersonaData.Save(pe);
        }
    }
}
