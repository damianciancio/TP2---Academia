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
    class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas " +
                    "inner join planes on personas.id_plan = planes.id_plan "+
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad", SqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Plan pa = new Plan();
                    Persona pe = new Persona();
                    Especialidad es = new Especialidad();
                    pe.ID = (int)drPersonas["personas.id_persona"];
                    pe.Nombre = (string)drPersonas["personas.nombre"];
                    pe.Apellido = (string)drPersonas["personas.apellido"];
                    pe.Direccion = (string)drPersonas["personas.direccion"];
                    pe.Telefono = (string)drPersonas["personas.telefono"];
                    pe.FechaNac = (DateTime)drPersonas["personas.fecha_nac"];
                    pe.Email = (string)drPersonas["personas.email"];
                    pe.Legajo = (int)drPersonas["personas.legajo"];
                    pe.TipoPersona = (int)drPersonas["personas.tipo_persona"];
                    pe.IdPlan = pa.ID = (int)drPersonas["materias.id_plan"];
                    pa.ID = (int)drPersonas["materias.id_plan"];
                    pa.Descripcion = (string)drPersonas["desc_plan"];
                    es.ID = (int)drPersonas["materias.id_especialidad"];
                    es.Descripcion = (string)drPersonas["desc_especialidad"];
                    pa.Especialidad = es;
                    pe.Plan = pa;
                    personas.Add(pe);
                }
                drPersonas.Close();
            }
            catch (Exception Exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar las personas", Exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return personas;
        }

        public Persona GetOne(int ID)
        {
            Persona pe = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas " +
                    "inner join planes on personas.id_plan = planes.id_plan " +
                    "inner join especialidades on especialidades.id_especialidad = planes.id_especialidad " +
                    "where id_persona = @id", SqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    Plan pa = new Plan();
                     Especialidad es = new Especialidad();
                    pe.ID = (int)drPersonas["personas.id_persona"];
                    pe.Nombre = (string)drPersonas["personas.nombre"];
                    pe.Apellido = (string)drPersonas["personas.apellido"];
                    pe.Direccion = (string)drPersonas["personas.direccion"];
                    pe.Telefono = (string)drPersonas["personas.telefono"];
                    pe.FechaNac = (DateTime)drPersonas["personas.fecha_nac"];
                    pe.Email = (string)drPersonas["personas.email"];
                    pe.Legajo = (int)drPersonas["personas.legajo"];
                    pe.TipoPersona = (int)drPersonas["personas.tipo_persona"];
                    pe.IdPlan = pa.ID = (int)drPersonas["materias.id_plan"];
                    pa.ID = (int)drPersonas["materias.id_plan"];
                    pa.Descripcion = (string)drPersonas["desc_plan"];
                    es.ID = (int)drPersonas["materias.id_especialidad"];
                    es.Descripcion = (string)drPersonas["desc_especialidad"];
                    pa.Especialidad = es;
                    pe.Plan = pa;
                }
            }
            catch (Exception Exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo conectar", Exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return pe;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id", SqlConn);
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

        public void Save(Persona persona)
        {

            if (persona.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(persona);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            else if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        public void Update(Persona pe)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand("update personas set nombre = @nombre, " +
                    "apellido = @apellido, direccion = @direccion, personas.id_plan = @idPlan " +
                    "telefono = @telefono, email = @email, fecha_nac = @fechaNac, tipo_persona = @tipoPersona " +
                    "legajo = @legajo where id_persona = @id", SqlConn);
                cmdPersona.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pe.Nombre;
                cmdPersona.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pe.Apellido;
                cmdPersona.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pe.Direccion;
                cmdPersona.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pe.Email;
                cmdPersona.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pe.Telefono;
                cmdPersona.Parameters.Add("@legajo", SqlDbType.Decimal).Value = pe.Legajo;
                cmdPersona.Parameters.Add("@tipoPersona", SqlDbType.Decimal).Value = pe.TipoPersona;
                cmdPersona.Parameters.Add("@fechaNac",SqlDbType.DateTime).Value = pe.FechaNac;
                cmdPersona.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = pe.Plan.ID;
                cmdPersona.Parameters.Add("@id", SqlDbType.Decimal).Value = pe.ID;
                cmdPersona.ExecuteNonQuery();
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

        public void Insert(Persona pe)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert materias (nombre, apellido, direccion, email, telefono, legajo, tipo_persona, fecha_nac, id_plan) " +
                "values (@nombre, @apellido, @direccion, @email, @telefono, @legajo, @tipoPersona, @fechaNac, @idPlan) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pe.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pe.Apellido;
                cmdInsert.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pe.Direccion;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pe.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pe.Telefono;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.Decimal).Value = pe.Legajo;
                cmdInsert.Parameters.Add("@tipoPersona", SqlDbType.Decimal).Value = pe.TipoPersona;
                cmdInsert.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = pe.FechaNac;
                cmdInsert.Parameters.Add("@idPlan", SqlDbType.Decimal).Value = pe.Plan.ID;
                pe.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear nueva Persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
