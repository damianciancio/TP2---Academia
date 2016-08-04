using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Business.Entities.Comision>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones " +
                    "inner join planes on planes.id_plan = comisiones.id_plan "+
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad", SqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    Comision co = new Comision();
                    Plan pl = new Plan();
                    Especialidad es = new Especialidad();
                    co.ID = (int)drComisiones["comisiones.id_comision"];
                    co.DescComision = (string)drComisiones["desc_comision"];
                    co.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    co.IdPlan = (int)drComisiones["comisiones.id_plan"];
                    pl.ID = (int)drComisiones["planes.id_plan"];
                    pl.Descripcion = (string)drComisiones["planes.desc_plan"];
                    es.ID = (int)drComisiones["especialidades.id_especialidad"];
                    es.Descripcion = (string)drComisiones["especialidades.desc_especialidad"];
                    pl.Especialidad = es;
                    co.Plan = pl;
                    comisiones.Add(co);
                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {

                throw new Exception("Error al recuperar las comisiones", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }      
    }
}
