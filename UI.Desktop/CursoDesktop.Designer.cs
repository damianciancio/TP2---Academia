namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlpCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlpCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCurso
            // 
            this.tlpCurso.ColumnCount = 5;
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpCurso.Controls.Add(this.lblId, 0, 0);
            this.tlpCurso.Controls.Add(this.lblAnio, 0, 1);
            this.tlpCurso.Controls.Add(this.lblCupo, 0, 2);
            this.tlpCurso.Controls.Add(this.lblComision, 2, 1);
            this.tlpCurso.Controls.Add(this.lblMateria, 2, 2);
            this.tlpCurso.Controls.Add(this.txtId, 1, 0);
            this.tlpCurso.Controls.Add(this.txtAnio, 1, 1);
            this.tlpCurso.Controls.Add(this.txtCupo, 1, 2);
            this.tlpCurso.Controls.Add(this.cmbComision, 3, 1);
            this.tlpCurso.Controls.Add(this.cmbMaterias, 3, 2);
            this.tlpCurso.Controls.Add(this.btnGuardar, 2, 3);
            this.tlpCurso.Controls.Add(this.btnSalir, 4, 3);
            this.tlpCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurso.Location = new System.Drawing.Point(0, 0);
            this.tlpCurso.Name = "tlpCurso";
            this.tlpCurso.RowCount = 4;
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurso.Size = new System.Drawing.Size(350, 106);
            this.tlpCurso.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(3, 31);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(79, 13);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(3, 56);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 2;
            this.lblCupo.Text = "Cupo";
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(152, 31);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 3;
            this.lblComision.Text = "Comision";
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(152, 56);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtAnio
            // 
            this.txtAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnio.Location = new System.Drawing.Point(88, 28);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(58, 20);
            this.txtAnio.TabIndex = 6;
            // 
            // txtCupo
            // 
            this.txtCupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCupo.Location = new System.Drawing.Point(88, 53);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(58, 20);
            this.txtCupo.TabIndex = 7;
            // 
            // cmbComision
            // 
            this.tlpCurso.SetColumnSpan(this.cmbComision, 2);
            this.cmbComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(207, 28);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.Size = new System.Drawing.Size(140, 21);
            this.cmbComision.TabIndex = 8;
            this.cmbComision.SelectedIndexChanged += new System.EventHandler(this.cmbComision_SelectedIndexChanged);
            // 
            // cmbMaterias
            // 
            this.tlpCurso.SetColumnSpan(this.cmbMaterias, 2);
            this.cmbMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(207, 53);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(140, 21);
            this.cmbMaterias.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCurso.SetColumnSpan(this.btnGuardar, 2);
            this.btnGuardar.Location = new System.Drawing.Point(190, 78);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Gaurdar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 78);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 106);
            this.Controls.Add(this.tlpCurso);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tlpCurso.ResumeLayout(false);
            this.tlpCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCurso;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.ComboBox cmbComision;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}