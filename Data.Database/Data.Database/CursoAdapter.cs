using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        /*
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from materias " +
                    "inner join planes on materias.id_plan = planes.id_plan " +
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Plan pa = new Plan();
                    Curso cu = new Curso();
                    Especialidad es = new Especialidad();
         
                    
                    cursos.Add(cu);
                }
                drCursos.Close();
            }
            catch (Exception Exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar las cursos", Exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Materia GetOne(int ID)
        {
            Materia ma = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from materias " +
                    "inner join planes on materias.id_plan = planes.id_plan " +
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad " +
                    "where id_materia = @id", SqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                if (drMaterias.Read())
                {
                    Plan pa = new Plan();
                    Especialidad es = new Especialidad();
                    ma.ID = (int)drMaterias["id_materia"];
                    ma.DescMateria = (string)drMaterias["desc_materia"];
                    ma.HsSemanales = (int)drMaterias["hs_semanales"];
                    ma.HsTotales = (int)drMaterias["hs_totales"];
                    ma.IdPlan = (int)drMaterias["id_plan"];
                    pa.ID = (int)drMaterias["id_plan"];
                    pa.Descripcion = (string)drMaterias["desc_plan"];
                    es.ID = (int)drMaterias["id_especialidad"];
                    es.Descripcion = (string)drMaterias["desc_especialidad"];
                    pa.Especialidad = es;
                    ma.Plan = pa;
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo conectar a la base de datos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return ma;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se puede eliminar, usuario malintencionado", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso curso)
        {

            if (curso.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(curso);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

        public void Update(Curso ma)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("update materias set desc_materia = @descripcion, " +
                    "materias.hs_semanales = @hsSemanales, materias.hs_totales = @hsTotales, materias.id_plan = @idPlan " +
                    "where id_materia = @id", SqlConn);
                cmdMateria.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = ma.DescMateria;
                cmdMateria.Parameters.Add("@hsSemanales", SqlDbType.Decimal).Value = ma.HsSemanales;
                cmdMateria.Parameters.Add("@hsTotales", SqlDbType.Decimal).Value = ma.HsTotales;
                cmdMateria.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = ma.Plan.ID;
                cmdMateria.Parameters.Add("@id", SqlDbType.Decimal).Value = ma.ID;
                cmdMateria.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo actualizar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Curso ma)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert materias (desc_especialidad, hs_semanales, hs_totales, id_plan) " +
                "values (@descripcion, @hsSemanales, @hsTotales, @idPlan) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = ma.DescMateria;
                cmdInsert.Parameters.Add("@hsSemanales", SqlDbType.Decimal).Value = ma.HsSemanales;
                cmdInsert.Parameters.Add("@hsTotales", SqlDbType.Decimal).Value = ma.HsTotales;
                cmdInsert.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = ma.Plan.ID;
                ma.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear nueva materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        } */
    }
}
