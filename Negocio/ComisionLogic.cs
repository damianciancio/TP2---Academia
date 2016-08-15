using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Negocio
{
    public class ComisionLogic : Negocio
    {
        public ComisionAdapter ComisionData
        {
            get; set;
        }
        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }
        public List<Comision> GetAll()
        {
            try
            {
                return ComisionData.GetAll();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public Comision GetOne(int ID)
        {
            try
            {
                return ComisionData.GetOne(ID);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public void Delete (int ID)
        {
            try
            {
                ComisionData.Delete(ID);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public void Save(Comision co)
        {
            try
            {
                ComisionData.Save(co);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
