namespace GestionEmpleados
{
    partial class FrmPrincipalEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalEmpleados));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotonesCRUD = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.grpCalculo = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultadoBono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.lblBono = new System.Windows.Forms.Label();
            this.lblResultadoBase = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.pnlBotonesCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.grpCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitulo.Location = new System.Drawing.Point(468, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion Empleados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBotonesCRUD
            // 
            this.pnlBotonesCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlBotonesCRUD.Controls.Add(this.btnEliminar);
            this.pnlBotonesCRUD.Controls.Add(this.btnEditar);
            this.pnlBotonesCRUD.Controls.Add(this.btnAgregar);
            this.pnlBotonesCRUD.Location = new System.Drawing.Point(219, 513);
            this.pnlBotonesCRUD.Name = "pnlBotonesCRUD";
            this.pnlBotonesCRUD.Size = new System.Drawing.Size(773, 100);
            this.pnlBotonesCRUD.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminar.Location = new System.Drawing.Point(552, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 61);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Blue;
            this.btnEditar.Location = new System.Drawing.Point(290, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(193, 61);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregar.Location = new System.Drawing.Point(36, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(193, 61);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(28, 131);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(773, 326);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // grpCalculo
            // 
            this.grpCalculo.BackColor = System.Drawing.Color.DarkGray;
            this.grpCalculo.Controls.Add(this.btnCalcular);
            this.grpCalculo.Controls.Add(this.lblResultadoBono);
            this.grpCalculo.Controls.Add(this.label1);
            this.grpCalculo.Controls.Add(this.txtBono);
            this.grpCalculo.Controls.Add(this.lblBono);
            this.grpCalculo.Controls.Add(this.lblResultadoBase);
            this.grpCalculo.Controls.Add(this.lblSueldoBase);
            this.grpCalculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCalculo.Location = new System.Drawing.Point(827, 131);
            this.grpCalculo.Name = "grpCalculo";
            this.grpCalculo.Size = new System.Drawing.Size(349, 326);
            this.grpCalculo.TabIndex = 4;
            this.grpCalculo.TabStop = false;
            this.grpCalculo.Text = "Calculo de Sueldo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcular.Location = new System.Drawing.Point(71, 246);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultadoBono
            // 
            this.lblResultadoBono.AutoSize = true;
            this.lblResultadoBono.BackColor = System.Drawing.Color.DarkGray;
            this.lblResultadoBono.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoBono.Location = new System.Drawing.Point(6, 206);
            this.lblResultadoBono.Name = "lblResultadoBono";
            this.lblResultadoBono.Size = new System.Drawing.Size(49, 28);
            this.lblResultadoBono.TabIndex = 5;
            this.lblResultadoBono.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sueldo con Bono:";
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(11, 124);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(332, 34);
            this.txtBono.TabIndex = 3;
            // 
            // lblBono
            // 
            this.lblBono.AutoSize = true;
            this.lblBono.BackColor = System.Drawing.Color.DarkGray;
            this.lblBono.ForeColor = System.Drawing.Color.Black;
            this.lblBono.Location = new System.Drawing.Point(6, 86);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(62, 28);
            this.lblBono.TabIndex = 2;
            this.lblBono.Text = "Bono:";
            // 
            // lblResultadoBase
            // 
            this.lblResultadoBase.AutoSize = true;
            this.lblResultadoBase.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoBase.Location = new System.Drawing.Point(133, 44);
            this.lblResultadoBase.Name = "lblResultadoBase";
            this.lblResultadoBase.Size = new System.Drawing.Size(49, 28);
            this.lblResultadoBase.TabIndex = 1;
            this.lblResultadoBase.Text = "0.00";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.BackColor = System.Drawing.Color.DarkGray;
            this.lblSueldoBase.ForeColor = System.Drawing.Color.Black;
            this.lblSueldoBase.Location = new System.Drawing.Point(6, 44);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(121, 28);
            this.lblSueldoBase.TabIndex = 0;
            this.lblSueldoBase.Text = "Sueldo Base:";
            // 
            // FrmPrincipalEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GestionEmpleados.Properties.Resources.kevin_laminto_7PqRZK6rbaE_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 625);
            this.Controls.Add(this.grpCalculo);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.pnlBotonesCRUD);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipalEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion Empleados";
            this.Load += new System.EventHandler(this.FrmPrincipalEmpleados_Load);
            this.pnlBotonesCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.grpCalculo.ResumeLayout(false);
            this.grpCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBotonesCRUD;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox grpCalculo;
        private System.Windows.Forms.Label lblBono;
        private System.Windows.Forms.Label lblResultadoBase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultadoBono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.Label lblSueldoBase;
    }
}

