using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Negocio
{
    public class MateriaLogic : Negocio
    {
        public MateriaAdapter MateriaData
        {
            get;
            set;
        }
        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }
        public List<Materia> GetAll()
        {
            try
            {
                return MateriaData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public Materia GetOne(int ID)
        {
            try
            {
                return MateriaData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Delete(int id)
        {
            try
            {
                MateriaData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            
        }
        public void Save(Materia mat)
        {
            try
            {
                MateriaData.Save(mat);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
