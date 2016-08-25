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
                string query = "select * from comisiones " +
                    "inner join planes on planes.id_plan = comisiones.id_plan " +
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad";
                SqlCommand cmdComisiones = new SqlCommand(query, SqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    Comision co = new Comision();
                    Plan pl = new Plan();
                    Especialidad es = new Especialidad();
                    co.ID = (int)drComisiones["id_comision"];
                    co.DescComision = (string)drComisiones["desc_comision"];
                    co.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    co.IdPlan = (int)drComisiones["id_plan"];
                    pl.ID = (int)drComisiones["id_plan"];
                    pl.Descripcion = (string)drComisiones["desc_plan"];
                    es.ID = (int)drComisiones["id_especialidad"];
                    es.Descripcion = (string)drComisiones["desc_especialidad"];
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

        public Comision GetOne(int ID)
        {
            Comision co = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from comisiones " +
                    "inner join planes on planes.id_plan = comisiones.id_plan " +
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad "+
                    "where comision.id_comision = @id", SqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Decimal).Value = ID;
                SqlDataReader drComisiones = cmdMaterias.ExecuteReader();
                if (drComisiones.Read())
                {
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
                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al recuperar de la base de datos", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return co;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Decimal).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception ("No se puede eliminar, usuario mal intencionado",Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(comision);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
        public void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("update comisiones set "+
                    "comisiones.desc_comision = @descComision, comisiones.anio_especialidad =@anioEspecialidad"+
                    "comisiones.id_plan = @idPlan where comisiones.id_comision = @id", SqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Decimal).Value = comision.ID;
                cmdComision.Parameters.Add("@descComision", SqlDbType.VarChar).Value = comision.DescComision;
                cmdComision.Parameters.Add("@anioEspecialidad", SqlDbType.Decimal).Value = comision.AnioEspecialidad;
                cmdComision.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = comision.Plan.ID;
                cmdComision.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception("No se pudo actualizar la comision", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Comision co)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert comisiones (desc_comision, anio_especialidad, id_plan) " +
                "values (@descComision, @anioEspecialidad, @idPlan) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@id", SqlDbType.Decimal).Value = co.ID;
                cmdInsert.Parameters.Add("@descComision", SqlDbType.VarChar).Value = co.DescComision;
                cmdInsert.Parameters.Add("@anioEspecialidad", SqlDbType.Decimal).Value = co.AnioEspecialidad;
                cmdInsert.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = co.Plan.ID;
                co.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                throw new Exception ("No se pudo insertar en la base de datos", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
