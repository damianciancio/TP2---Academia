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
        private Curso _cursoActual;

        public Curso CursoActual
        {
            get { return _cursoActual; }
            set { _cursoActual = value; }
        }

        public CursoDesktop(ModoForm md) : this()
        {
            this.Modo = md;
        }
        public CursoDesktop(int ID, ModoForm md) : this()
        {
            this.Modo = md;
            CursoLogic ml = new CursoLogic();
            CursoActual = ml.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = CursoActual.ID.ToString();
            this.txtAnio.Text = CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = CursoActual.Cupo.ToString();
            this.cmbComision.SelectedItem = CursoActual.Comision;
            this.cmbMaterias.SelectedItem = CursoActual.Materia;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnGuardar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    btnGuardar.Text = "Aceptar";
                    break;
                default:
                    break;
            }

        }

        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                CursoActual = new Curso();
            }
            else
            {

                CursoActual.ID = int.Parse(txtId.Text);
            }

            CursoActual.AnioCalendario = int.Parse(txtAnio.Text);
            CursoActual.Materia = (Materia)cmbMaterias.SelectedItem;
            CursoActual.Comision = (Comision)cmbComision.SelectedItem;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    CursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    CursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    CursoActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }


        public CursoDesktop() : base ()
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

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic esL = new CursoLogic();
            try
            {
                esL.Save(CursoActual);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
