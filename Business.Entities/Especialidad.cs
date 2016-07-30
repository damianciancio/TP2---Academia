﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        private string _descripcion;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                this._descripcion = value;
            }

            
        }
        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
