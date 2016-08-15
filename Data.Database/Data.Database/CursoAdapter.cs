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
        
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos " +
                    "inner join materias on materias.id_materia = curso.id_materia " +
                    "inner join comisiones on comisiones.id_id_comision = cursos.id_comision "+
                    "inner join planes on planes.id_plan = materias.id_plan "+
                    "inner join especialidades on planes.id_especialidad = especialidades.id_especialidad", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cu = new Curso();
                    Materia ma = new Materia();
                    Comision co = new Comision();
                    Plan pl = new Plan();
                    Especialidad es = new Especialidad();
                    cu.ID = (int)drCursos["id_curso"];
                    cu.AnioCalendario = (int)drCursos["anio_calendario"];
                    cu.Cupo = (int)drCursos["cupo"];
                    ma.ID = (int)drCursos["id_materia"];
                    ma.DescMateria = (string)drCursos["desc_materia"];
                    co.ID = (int)drCursos["id_comision"];
                    co.DescComision = (string)drCursos["desc_comision"];
                    co.IdPlan = (int)drCursos["id_plan"];
                    
                    pl.ID = (int)drCursos["id_plan"];
                    pl.Descripcion = (string)drCursos["desc_plan"];
                    es.ID = (int)drCursos["id_especialidad"];
                    es.Descripcion = (string)drCursos["desc_especialidad"];
                    co.Plan = pl;
                    ma.Plan = pl;
                    pl.Especialidad = es;
                    cu.Comision = co;
                    cu.Materia = ma;
                    

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

        public Curso GetOne(int ID)
        {
            Curso cu = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos " +
                    "inner join materias on materias.id_materia = curso.id_materia " +
                    "inner join comisiones on comisiones.id_id_comision = cursos.id_comision " +
                    "inner join planes on planes.id_plan = materias.id_plan " +
                    "inner join especialidades on planes.id_especialidad = especialidades.id_especialidad "+
                    "where cursos.id_curso = @id", SqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                if (drCursos.Read())
                {
                    Materia ma = new Materia();
                    Comision co = new Comision();
                    Plan pl = new Plan();
                    Especialidad es = new Especialidad();
                    cu.ID = (int)drCursos["id_curso"];
                    cu.AnioCalendario = (int)drCursos["anio_calendario"];
                    cu.Cupo = (int)drCursos["cupo"];
                    ma.ID = (int)drCursos["id_materia"];
                    ma.DescMateria = (string)drCursos["desc_materia"];
                    co.ID = (int)drCursos["id_comision"];
                    co.DescComision = (string)drCursos["desc_comision"];
                    co.IdPlan = (int)drCursos["id_plan"];

                    pl.ID = (int)drCursos["id_plan"];
                    pl.Descripcion = (string)drCursos["desc_plan"];
                    es.ID = (int)drCursos["id_especialidad"];
                    es.Descripcion = (string)drCursos["desc_especialidad"];
                    co.Plan = pl;
                    ma.Plan = pl;
                    pl.Especialidad = es;
                    cu.Comision = co;
                    cu.Materia = ma;
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
            return cu;
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

        public void Update(Curso cu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("update cursos set cursos.id_materia = @idMateria, " +
                    "cursos.id_comision = @idComision, cursos.anio_calendario = @anioCalendario, cursos.cupo = @cupo " +
                    "where cursos.id_curso = @id", SqlConn);
                cmdMateria.Parameters.Add("@id_materia", SqlDbType.VarChar, 50).Value = cu.Materia.ID;
                cmdMateria.Parameters.Add("@idComision", SqlDbType.Decimal).Value = cu.Comision.ID;
                cmdMateria.Parameters.Add("@anioCalendario", SqlDbType.Decimal).Value = cu.AnioCalendario;
                cmdMateria.Parameters.Add("@cupo", SqlDbType.Decimal).Value = cu.Cupo;
                cmdMateria.Parameters.Add("@id", SqlDbType.Decimal).Value = cu.ID;
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

        public void Insert(Curso cu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert cursos (id_materia, id_comision, anio_calendario, cupo) " +
                "values (@idMateria, @idComision, @anioCalendario, @cupo) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@id_materia", SqlDbType.VarChar, 50).Value = cu.Materia.ID;
                cmdInsert.Parameters.Add("@idComision", SqlDbType.Decimal).Value = cu.Comision.ID;
                cmdInsert.Parameters.Add("@anioCalendario", SqlDbType.Decimal).Value = cu.AnioCalendario;
                cmdInsert.Parameters.Add("@cupo", SqlDbType.Decimal).Value = cu.Cupo;
                cu.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
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
        } 
    }
}
