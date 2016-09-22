using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class TipoPersonaAdapter : Adapter
    {
        public List<TipoPersona> GetAll()
        {
            List<TipoPersona> tiposPersona = new List<TipoPersona>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdTiposPersona = new SqlCommand("select * from tipo_persona", SqlConn);
                SqlDataReader drTiposPersona = cmdTiposPersona.ExecuteReader();
                while (drTiposPersona.Read())
                {
                    TipoPersona tp = new TipoPersona();
                    tp.ID = (int)drTiposPersona["id_tipo_persona"];
                    tp.TipoPersonaDesc = (string)drTiposPersona["desc_tipo_persona"];
                    tiposPersona.Add(tp);
                }
                drTiposPersona.Close();
            }
            catch (Exception Exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los tipos de persona", Exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return tiposPersona;
        }

        public TipoPersona GetOne(int ID)
        {
            TipoPersona tp = new TipoPersona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdTiposPersona = new SqlCommand("select * from tipo_persona where id_tipo_persona = @id", SqlConn);
                cmdTiposPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drTiposPersona = cmdTiposPersona.ExecuteReader();
                if (drTiposPersona.Read())
                {
                   tp.ID = (int)drTiposPersona["tipo_persona.id_tipo_persona"];
                   tp.TipoPersonaDesc = (string)drTiposPersona["tipo_persona.desc_tipo_persona"];
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
            return tp;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete tipo_persona where id_tipo_persona=@id", SqlConn);
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

        public void Save(TipoPersona tpersona)
        {

            if (tpersona.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(tpersona);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            else if (tpersona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(tpersona.ID);
            }
            else if (tpersona.State == BusinessEntity.States.Modified)
            {
                this.Update(tpersona);
            }
           tpersona.State = BusinessEntity.States.Unmodified;
        }

        public void Update(TipoPersona pe)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand("update tipo_persona set desc_tipo_persona = @desc where id_tipo_persona = @id", SqlConn);
                cmdPersona.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = pe.TipoPersonaDesc;
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

        public void Insert(TipoPersona pe)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert tipo_persona (desc_tipo_persona) " +
                "values (@desc) select @@identity", SqlConn);
                cmdInsert.Parameters.Add("@desc", SqlDbType.Decimal).Value = pe.TipoPersonaDesc;
                pe.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear nuevo Tipo Persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
