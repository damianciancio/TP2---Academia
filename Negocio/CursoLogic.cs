using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Negocio
{
    public class CursoLogic : Negocio
    {
        public CursoAdapter CursoData
        {
            get;
            set;
        }

        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            try
            {
                return CursoData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Curso GetOne(int ID)
        {
            try
            {
                return CursoData.GetOne(ID);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }

        public void Save(Curso cu)
        {
            CursoData.Save(cu);
        }
    }
}
