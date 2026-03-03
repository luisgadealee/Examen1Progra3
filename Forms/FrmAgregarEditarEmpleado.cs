// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : FrmAgregarEditarEmpleado.cs
// Capa     : Forms (Presentación)
// Propósito: Formulario secundario para agregar o editar un empleado.
//            Si recibe ID = 0 está en modo Agregar.
//            Si recibe un ID válido está en modo Editar.
// Patrón   : Consume EmpleadoFacade (Facade) de la capa BLL.
// ─────────────────────────────────────────────────────────────────────────────

using System;
using System.Windows.Forms;
using GestionEmpleados.BLL;
using GestionEmpleados.DAL;

namespace GestionEmpleados.Forms
{
    public partial class FrmAgregarEditarEmpleado : Form
    {
        // ─────────────────────────────────────────────────────────────────
        // Atributos
        // ─────────────────────────────────────────────────────────────────

        // Solamente se asigna una vez en el constructor, por eso se declara como readonly.
        // Y es para recibir la instancia de EmpleadoFacade creada en el formulario principal, para usarla en los métodos de este formulario secundario.
        private readonly EmpleadoFacade _empleadoFacade;

        //La idea del ID es que si es 0 el formulario se abre en modo Agregar,
        //y si es un ID válido se abre en modo Editar, cargando los datos del empleado correspondiente.
        private readonly int _empleadoId;

        // ─────────────────────────────────────────────────────────────────
        // Constructor
        // ─────────────────────────────────────────────────────────────────

        // No inicializa la Facade aquí porque se recibe como parámetro desde el formulario principal,
        // donde ya se creó la instancia de EmpleadoFacade.
        public FrmAgregarEditarEmpleado(EmpleadoFacade empleadoFacade, int empleadoId)
        {
            InitializeComponent();
            _empleadoFacade = empleadoFacade;
            _empleadoId = empleadoId;
        }

        // ─────────────────────────────────────────────────────────────────
        // Eventos del formulario
        // ─────────────────────────────────────────────────────────────────

        // Cuando se carga el fomrulario, se agregan los items en el combo box
        // Con esto podemos si o si que el combo box tenga solo los 2 parametros que necesitamos
        private void FrmAgregarEditarEmpleado_Load(object sender, EventArgs e)
        {
            // Carga las opciones del ComboBox
            cmbTipo.Items.Add("Planta");
            cmbTipo.Items.Add("Temporal");
            cmbTipo.SelectedIndex = 0;

            // Si el ID es 0 es modo Agregar, si no es modo Editar
            if (_empleadoId == 0)
            {
                this.Text = "Agregar Empleado";
            }
            else
            {
                this.Text = "Editar Empleado";
                CargarDatosEmpleado();
            }
        }

        // ─────────────────────────────────────────────────────────────────
        // Eventos de los controles
        // ─────────────────────────────────────────────────────────────────

        /// <summary>
        /// Permite solo números y el punto decimal en el campo Sueldo.
        /// </summary>
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, backspace y un solo punto decimal
            bool esNumero = char.IsDigit(e.KeyChar);
            bool esBackspace = e.KeyChar == (char)Keys.Back;
            bool esPunto = e.KeyChar == '.' && !txtSueldo.Text.Contains(".");

            e.Handled = !(esNumero || esBackspace || esPunto);
        }

        /// <summary>
        /// Guarda el empleado en la base de datos (agregar o editar).
        /// </summary>
        /// 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text.Trim());
            string cargo = txtCargo.Text.Trim();
            string tipo = cmbTipo.SelectedItem.ToString();

            if (_empleadoId == 0)
            {
                // Modo Agregar
                _empleadoFacade.Agregar(nombre, apellido, sueldo, cargo, tipo);
                MessageBox.Show(
                    "Empleado agregado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Modo Editar
                _empleadoFacade.Editar(_empleadoId, nombre, apellido,
                                       sueldo, cargo, tipo);
                MessageBox.Show(
                    "Empleado editado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            // Cierra el formulario secundario y regresa al principal
            this.Close();
        }

        /// <summary>
        /// Cierra el formulario sin guardar cambios.
        /// </summary>
        /// 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ─────────────────────────────────────────────────────────────────
        // Métodos privados
        // ─────────────────────────────────────────────────────────────────

        /// <summary>
        /// Carga los datos del empleado en los campos cuando está en modo Editar.
        /// </summary>
        private void CargarDatosEmpleado()
        {
            Empleados empleado = _empleadoFacade.ObtenerPorId(_empleadoId);

            if (empleado == null) return;

            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtSueldo.Text = empleado.Sueldo.ToString();
            txtCargo.Text = empleado.Cargo;
            cmbTipo.SelectedItem = empleado.TipoEmpleado;
        }

        /// <summary>
        /// Valida que todos los campos tengan contenido antes de guardar.
        /// </summary>
        /// <returns>True si todos los campos son válidos, false si alguno está vacío</returns>
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("El sueldo es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSueldo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("El cargo es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Focus();
                return false;
            }
            return true;
        }    
    }
}