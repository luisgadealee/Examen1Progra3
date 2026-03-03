namespace GestionEmpleados.Forms
{
    partial class FrmAgregarEditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarEmpleado));
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoAgreEdita = new System.Windows.Forms.Label();
            this.lblCargoAgreEdita = new System.Windows.Forms.Label();
            this.lblSueldoAgreEdita = new System.Windows.Forms.Label();
            this.lblApelliAgreEdita = new System.Windows.Forms.Label();
            this.lblNomAgreEdita = new System.Windows.Forms.Label();
            this.lblTituloCRUD = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBotonesCRUD = new System.Windows.Forms.Panel();
            this.grpDatosEmpleado.SuspendLayout();
            this.pnlBotonesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpDatosEmpleado.Controls.Add(this.cmbTipo);
            this.grpDatosEmpleado.Controls.Add(this.txtCargo);
            this.grpDatosEmpleado.Controls.Add(this.txtSueldo);
            this.grpDatosEmpleado.Controls.Add(this.txtApellido);
            this.grpDatosEmpleado.Controls.Add(this.txtNombre);
            this.grpDatosEmpleado.Controls.Add(this.lblTipoAgreEdita);
            this.grpDatosEmpleado.Controls.Add(this.lblCargoAgreEdita);
            this.grpDatosEmpleado.Controls.Add(this.lblSueldoAgreEdita);
            this.grpDatosEmpleado.Controls.Add(this.lblApelliAgreEdita);
            this.grpDatosEmpleado.Controls.Add(this.lblNomAgreEdita);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.Location = new System.Drawing.Point(73, 79);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Size = new System.Drawing.Size(429, 431);
            this.grpDatosEmpleado.TabIndex = 0;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos del Empleado";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(48, 362);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(357, 38);
            this.cmbTipo.TabIndex = 9;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(48, 290);
            this.txtCargo.MaxLength = 100;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(357, 35);
            this.txtCargo.TabIndex = 8;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(48, 219);
            this.txtSueldo.MaxLength = 10;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(357, 35);
            this.txtSueldo.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(48, 148);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(357, 35);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 74);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 35);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTipoAgreEdita
            // 
            this.lblTipoAgreEdita.AutoSize = true;
            this.lblTipoAgreEdita.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAgreEdita.Location = new System.Drawing.Point(17, 328);
            this.lblTipoAgreEdita.Name = "lblTipoAgreEdita";
            this.lblTipoAgreEdita.Size = new System.Drawing.Size(61, 30);
            this.lblTipoAgreEdita.TabIndex = 4;
            this.lblTipoAgreEdita.Text = "Tipo:";
            // 
            // lblCargoAgreEdita
            // 
            this.lblCargoAgreEdita.AutoSize = true;
            this.lblCargoAgreEdita.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoAgreEdita.Location = new System.Drawing.Point(17, 257);
            this.lblCargoAgreEdita.Name = "lblCargoAgreEdita";
            this.lblCargoAgreEdita.Size = new System.Drawing.Size(76, 30);
            this.lblCargoAgreEdita.TabIndex = 3;
            this.lblCargoAgreEdita.Text = "Cargo:";
            // 
            // lblSueldoAgreEdita
            // 
            this.lblSueldoAgreEdita.AutoSize = true;
            this.lblSueldoAgreEdita.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoAgreEdita.Location = new System.Drawing.Point(17, 186);
            this.lblSueldoAgreEdita.Name = "lblSueldoAgreEdita";
            this.lblSueldoAgreEdita.Size = new System.Drawing.Size(83, 30);
            this.lblSueldoAgreEdita.TabIndex = 2;
            this.lblSueldoAgreEdita.Text = "Sueldo:";
            // 
            // lblApelliAgreEdita
            // 
            this.lblApelliAgreEdita.AutoSize = true;
            this.lblApelliAgreEdita.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelliAgreEdita.Location = new System.Drawing.Point(17, 112);
            this.lblApelliAgreEdita.Name = "lblApelliAgreEdita";
            this.lblApelliAgreEdita.Size = new System.Drawing.Size(97, 30);
            this.lblApelliAgreEdita.TabIndex = 1;
            this.lblApelliAgreEdita.Text = "Apellido:";
            // 
            // lblNomAgreEdita
            // 
            this.lblNomAgreEdita.AutoSize = true;
            this.lblNomAgreEdita.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAgreEdita.Location = new System.Drawing.Point(16, 41);
            this.lblNomAgreEdita.Name = "lblNomAgreEdita";
            this.lblNomAgreEdita.Size = new System.Drawing.Size(98, 30);
            this.lblNomAgreEdita.TabIndex = 0;
            this.lblNomAgreEdita.Text = "Nombre:";
            // 
            // lblTituloCRUD
            // 
            this.lblTituloCRUD.AutoSize = true;
            this.lblTituloCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCRUD.Location = new System.Drawing.Point(114, 9);
            this.lblTituloCRUD.Name = "lblTituloCRUD";
            this.lblTituloCRUD.Size = new System.Drawing.Size(364, 40);
            this.lblTituloCRUD.TabIndex = 1;
            this.lblTituloCRUD.Text = "Agregar / Editar Empleado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(21, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 59);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(261, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 59);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlBotonesCRUD
            // 
            this.pnlBotonesCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlBotonesCRUD.Controls.Add(this.btnCancelar);
            this.pnlBotonesCRUD.Controls.Add(this.btnGuardar);
            this.pnlBotonesCRUD.Location = new System.Drawing.Point(73, 528);
            this.pnlBotonesCRUD.Name = "pnlBotonesCRUD";
            this.pnlBotonesCRUD.Size = new System.Drawing.Size(429, 100);
            this.pnlBotonesCRUD.TabIndex = 4;
            // 
            // FrmAgregarEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 653);
            this.Controls.Add(this.pnlBotonesCRUD);
            this.Controls.Add(this.lblTituloCRUD);
            this.Controls.Add(this.grpDatosEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarEditarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion Empleado";
            this.Load += new System.EventHandler(this.FrmAgregarEditarEmpleado_Load);
            this.grpDatosEmpleado.ResumeLayout(false);
            this.grpDatosEmpleado.PerformLayout();
            this.pnlBotonesCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.Label lblTituloCRUD;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBotonesCRUD;
        private System.Windows.Forms.Label lblTipoAgreEdita;
        private System.Windows.Forms.Label lblCargoAgreEdita;
        private System.Windows.Forms.Label lblSueldoAgreEdita;
        private System.Windows.Forms.Label lblApelliAgreEdita;
        private System.Windows.Forms.Label lblNomAgreEdita;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtApellido;
    }
}