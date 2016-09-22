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
    public partial class PersonaDesktop : ApplicationForm
    {
      

        public Persona PersonaActual
        {
            get;set;
        }

        public PersonaDesktop(ModoForm md) : this()
        {
            this.Modo = md;
        }
        public PersonaDesktop(int ID, ModoForm md) : this()
        {
           /* this.Modo = md;
            PersonaLogic pl = new PersonaLogic();
            PersonaActual = pl.GetOne(ID);
            MapearDeDatos();*/
        }

        public override void MapearDeDatos()
        {
            this.txtNombre.Text = PersonaActual.Nombre;
            this.txtApellido.Text = PersonaActual.Apellido;
            this.txtDireccion.Text = PersonaActual.Direccion;
            this.txtMail.Text = PersonaActual.Email;
            this.txtLegajo.Text = PersonaActual.Legajo.ToString();
            this.dtpFecNac.Value = PersonaActual.FechaNac;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }

        }

        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                PersonaActual = new Persona();
            }
            else
            {

               PersonaActual.ID = int.Parse(txtID.Text);
            }

            PersonaActual.Nombre = this.txtNombre.Text;
            PersonaActual.Apellido = this.txtApellido.Text;
            PersonaActual.Direccion =this.txtDireccion.Text;
            PersonaActual.Email = this.txtMail.Text;
            int a;
            if(int.TryParse(this.txtLegajo.Text, out a))
            {
                PersonaActual.Legajo = a;
            }
            else
	        {
                throw new Exception("Ingrese legajo válido"); 
	        }
            PersonaActual.FechaNac = this.dtpFecNac.Value;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    PersonaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    PersonaActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }


        public PersonaDesktop() : base ()
        {
            InitializeComponent();

            List<TipoPersona> _listTipoPersona = new List<TipoPersona>();
            _listTipoPersona.Add(new TipoPersona());
            _listTipoPersona.AddRange(new TipoPersonaLogic().GetAll());

            cmbTipoPersona.DataSource = _listTipoPersona;
            cmbTipoPersona.DisplayMember = "TipoPersonaDesc";
            cmbTipoPersona.ValueMember = "ID";

            List<Especialidad> carreras = new List<Especialidad>();
            carreras.Add(new Especialidad());
            carreras.AddRange((new EspecialidadLogic()).GetAll());
            cmbCarrera.DataSource = carreras;
            cmbCarrera.DisplayMember = "Descripcion";
            cmbCarrera.ValueMember = "ID";

            actPlanes(0);


        }

        private void actPlanes(int idEspecialidad)
        {
            List<Plan> planes = new List<Plan>();
            planes.Add(new Plan());
            if (0 == idEspecialidad)
            {
                cmbPlan.Enabled = false;
            }
            else
            {
                planes.AddRange(new PlanLogic().GetAll(idEspecialidad));
                cmbPlan.Enabled = true;
            }

            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "ID";

        }

        private void cmbCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCarrera.SelectedIndex != 0 )
            {
                actPlanes(((Especialidad)cmbCarrera.SelectedValue).ID);
            }

        }

       /* public override void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic esL = new PersonaLogic();
            try
            {
                esL.Save(PersonaActual);
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
                _listMaterias.AddRange(new MateriaLogic().GetAll(/* TODO: Implementar un filtro mejor ));
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
        }*/
    }
}
