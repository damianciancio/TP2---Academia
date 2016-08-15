using Negocio;

namespace UI.Desktop
{
    partial class MateriaDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlMateriasDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblDescMat = new System.Windows.Forms.Label();
            this.lblHsSemanales = new System.Windows.Forms.Label();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.Plan = new System.Windows.Forms.Label();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlMateriasDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMateriasDesktop
            // 
            this.tlMateriasDesktop.ColumnCount = 2;
            this.tlMateriasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMateriasDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMateriasDesktop.Controls.Add(this.lblIDMateria, 0, 0);
            this.tlMateriasDesktop.Controls.Add(this.lblDescMat, 0, 1);
            this.tlMateriasDesktop.Controls.Add(this.lblHsSemanales, 0, 2);
            this.tlMateriasDesktop.Controls.Add(this.lblHsTotales, 0, 3);
            this.tlMateriasDesktop.Controls.Add(this.Plan, 0, 4);
            this.tlMateriasDesktop.Controls.Add(this.txtDescMateria, 1, 1);
            this.tlMateriasDesktop.Controls.Add(this.txtHsSemanales, 1, 2);
            this.tlMateriasDesktop.Controls.Add(this.txtHsTotales, 1, 3);
            this.tlMateriasDesktop.Controls.Add(this.cmbPlanes, 1, 4);
            this.tlMateriasDesktop.Controls.Add(this.txtIdMateria, 1, 0);
            this.tlMateriasDesktop.Controls.Add(this.btnAceptar, 0, 5);
            this.tlMateriasDesktop.Controls.Add(this.btnCancelar, 1, 5);
            this.tlMateriasDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMateriasDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlMateriasDesktop.Name = "tlMateriasDesktop";
            this.tlMateriasDesktop.RowCount = 6;
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMateriasDesktop.Size = new System.Drawing.Size(934, 422);
            this.tlMateriasDesktop.TabIndex = 0;
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(48, 6);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(56, 13);
            this.lblIDMateria.TabIndex = 0;
            this.lblIDMateria.Text = "ID Materia";
            // 
            // lblDescMat
            // 
            this.lblDescMat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescMat.AutoSize = true;
            this.lblDescMat.Location = new System.Drawing.Point(3, 32);
            this.lblDescMat.Name = "lblDescMat";
            this.lblDescMat.Size = new System.Drawing.Size(101, 13);
            this.lblDescMat.TabIndex = 1;
            this.lblDescMat.Text = "Descripcion Materia";
            // 
            // lblHsSemanales
            // 
            this.lblHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHsSemanales.AutoSize = true;
            this.lblHsSemanales.Location = new System.Drawing.Point(14, 58);
            this.lblHsSemanales.Name = "lblHsSemanales";
            this.lblHsSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHsSemanales.TabIndex = 2;
            this.lblHsSemanales.Text = "Horas Semanales";
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(31, 84);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(73, 13);
            this.lblHsTotales.TabIndex = 3;
            this.lblHsTotales.Text = "Horas Totales";
            // 
            // Plan
            // 
            this.Plan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Plan.AutoSize = true;
            this.Plan.Location = new System.Drawing.Point(76, 111);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(28, 13);
            this.Plan.TabIndex = 4;
            this.Plan.Text = "Plan";
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdMateria.Location = new System.Drawing.Point(110, 3);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.ReadOnly = true;
            this.txtIdMateria.Size = new System.Drawing.Size(100, 20);
            this.txtIdMateria.TabIndex = 5;
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescMateria.Location = new System.Drawing.Point(110, 29);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(100, 20);
            this.txtDescMateria.TabIndex = 6;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsSemanales.Location = new System.Drawing.Point(110, 55);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(100, 20);
            this.txtHsSemanales.TabIndex = 7;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsTotales.Location = new System.Drawing.Point(110, 81);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(100, 20);
            this.txtHsTotales.TabIndex = 8;
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(110, 107);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanes.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(110, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriasDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 422);
            this.Controls.Add(this.tlMateriasDesktop);
            this.Name = "MateriasDesktop";
            this.Text = "MateriasDesktop";
            this.tlMateriasDesktop.ResumeLayout(false);
            this.tlMateriasDesktop.PerformLayout();
            this.ResumeLayout(false);
            PlanLogic pl = new PlanLogic();
            this.cmbPlanes.DataSource = pl.GetAll();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMateriasDesktop;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblDescMat;
        private System.Windows.Forms.Label lblHsSemanales;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.Label Plan;
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}