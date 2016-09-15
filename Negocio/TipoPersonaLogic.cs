using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Negocio
{
    public class TipoPersonaLogic
    {
        public List<TipoPersona> GetAll()
        {
            TipoPersonaAdapter da = new TipoPersonaAdapter();
            return da.GetAll();
        }
    }
}
