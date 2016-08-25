using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Negocio;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso CursoActual;

        public CursoDesktop()
        {
            InitializeComponent();

            List<Comision> _listComisiones = new List<Comision>();
            _listComisiones.Add(new Comision());
            _listComisiones.AddRange(new ComisionLogic().GetAll());

            cmbComision.DataSource = _listComisiones;
            cmbComision.DisplayMember = "DescComision";
            cmbComision.ValueMember = "ID";

            actMaterias(0);
        }

        private void actMaterias(int idComision)
        {
            List<Materia> _listMaterias = new List<Materia>();
            _listMaterias.Add(new Materia());
            if (0 == idComision)
            {
                cmbMaterias.Enabled = false;
            }
            else
            {
                _listMaterias.AddRange(new MateriaLogic().GetAll(/* TODO: Implementar un filtro mejor */));
                cmbMaterias.Enabled = true;
            }

            cmbMaterias.DataSource = _listMaterias;
            cmbMaterias.DisplayMember = "DescMateria";
            cmbMaterias.ValueMember = "ID";

        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idComision = ((Comision)this.cmbComision.SelectedItem).ID;
            actMaterias(idComision);

            return;
        }



    }
}
