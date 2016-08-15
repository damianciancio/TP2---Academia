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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public Materia MateriaActual
        {
            get; set;
        }
        public MateriaDesktop(ModoForm md) : this()
        {
            this.Modo = md;
        }
        public MateriaDesktop(int ID, ModoForm md) : this()
        {
            this.Modo = md;
            MateriaLogic ml = new MateriaLogic();
            MateriaActual = ml.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIdMateria.Text = MateriaActual.ID.ToString();
            this.txtDescMateria.Text = MateriaActual.DescMateria;
            this.txtHsSemanales.Text = MateriaActual.HsSemanales.ToString();
            this.txtHsTotales.Text = MateriaActual.HsTotales.ToString();
            this.cmbPlanes.SelectedItem = MateriaActual.Plan;
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta)
            {
                MateriaActual = new Materia();
            }
            else
            {
                MateriaActual.ID = int.Parse(txtIdMateria.Text);
            }
            try
            {
                MateriaActual.DescMateria = txtDescMateria.Text;
                MateriaActual.HsSemanales = int.Parse(txtHsSemanales.Text);
                MateriaActual.HsTotales = int.Parse(txtHsTotales.Text);
                MateriaActual.Plan = (Plan)cmbPlanes.SelectedItem;
            }
            catch (Exception Ex)
            {
                this.Notificar("La hora debe ser un numero entero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (Modo)
            {
                case ModoForm.Alta:
                    MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    MateriaActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic esL = new MateriaLogic();
            try
            {
                esL.Save(MateriaActual);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public override bool Validar()
        {
            bool valido = true;

            if (txtDescMateria.Text == "")
            {
                valido = false;
            }
            if (txtHsSemanales.Text == "")
            {
                valido = false;
            }
            if (txtHsTotales.Text == "")
            {
                valido = false;
            }
            if (cmbPlanes.SelectedItem == null)
            {
                valido = false;
            }
            return valido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
