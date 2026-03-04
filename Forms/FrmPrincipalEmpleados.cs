// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : FrmPrincipalEmpleados.cs
// Capa     : Forms (Presentación)
// Propósito: Formulario principal del sistema. Muestra la lista de
//            empleados y permite agregar, editar y eliminar.
// Patrón   : Consume EmpleadoFacade (Facade) de la capa BLL.
// ─────────────────────────────────────────────────────────────────────────────

using System;
using System.Windows.Forms;
using GestionEmpleados.BLL;
using GestionEmpleados.Forms;

namespace GestionEmpleados
{
    public partial class FrmPrincipalEmpleados : Form
    {
        // ─────────────────────────────────────────────────────────────────
        // Atributos
        // ─────────────────────────────────────────────────────────────────

        // Instancia de la Facade para acceder a los métodos de la capa BLL relacionados con empleados.
        // Se declara como readonly porque solo se asigna una vez en el constructor y no cambia durante la vida del formulario.
        private readonly EmpleadoFacade _empleadoFacade;

        // ─────────────────────────────────────────────────────────────────
        // Constructor
        // ─────────────────────────────────────────────────────────────────

        // Se inicializa el formulario y se crea la instancia de EmpleadoFacade para usarla en los métodos del formulario.
        // Llamada del constructor Facade aquí para que esté disponible en todos los métodos del formulario, como los eventos de los botones.
        public FrmPrincipalEmpleados()
        {
            InitializeComponent();
            _empleadoFacade = new EmpleadoFacade();
        }

        // ─────────────────────────────────────────────────────────────────
        // Eventos del formulario
        // ─────────────────────────────────────────────────────────────────

        // Siempre que iniciamos el formulario, se carga la lista de empleados desde la base de datos para mostrarla en el DataGridView.
        private void FrmPrincipalEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        // ─────────────────────────────────────────────────────────────────
        // Eventos de los botones
        // ─────────────────────────────────────────────────────────────────

        // Abre el formulario secundario para agregar un nuevo empleado.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abre el formulario secundario en modo Agregar
            // El 0 indica que es un empleado nuevo, sin ID todavía
            var frm = new FrmAgregarEditarEmpleado(_empleadoFacade, 0);
            frm.ShowDialog();

            // Cuando el formulario secundario se cierra refresca la lista
            CargarEmpleados();
        }

        // Abre el formulario secundario para editar el empleado seleccionado.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un empleado para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtiene el ID del empleado seleccionado de la primera columna
            // Busca el ID por nombre de la columna para evitar problemas si se cambia el orden de las columnas en el DataGridView.
            int empleadoId = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["EmpleadoId"].Value);

            // Abre el formulario secundario en modo Editar con el ID
            var frm = new FrmAgregarEditarEmpleado(_empleadoFacade, empleadoId);
            frm.ShowDialog();

            // Refresca la lista al cerrar
            CargarEmpleados();
        }

        // Elimina el empleado seleccionado después de pedir confirmación.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un empleado para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Pide confirmación antes de eliminar
            var confirmacion = MessageBox.Show(
                "¿Estás seguro que deseas eliminar este empleado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            // Obtiene el ID y elimina
            // Busca el ID por nombre de la columna para evitar problemas si se cambia el orden de las columnas en el DataGridView.
            int empleadoId = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["EmpleadoId"].Value);
            _empleadoFacade.Eliminar(empleadoId);

            MessageBox.Show(
                "Empleado eliminado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEmpleados();
        }

        // ─────────────────────────────────────────────────────────────────
        // Métodos privados
        // ─────────────────────────────────────────────────────────────────

        // Carga la lista de empleados desde la base de datos y la muestra en el DataGridView.
        // Se puso aqui porque utiliza el método ObtenerTodos() de la Facade, que es el que se encarga de traer los
        // datos de la base de datos y convertirlos en objetos EmpleadoPlanta o EmpleadoTemporal según corresponda.
        // Y la responsabilidad de esta capa (Forms) es mostrar los datos, no obtenerlos, por eso el método ObtenerTodos()
        // se llama desde la Facade y no directamente desde el formulario.
        private void CargarEmpleados()
        {
            // Obtiene la lista desde la Facade
            var empleados = _empleadoFacade.ObtenerTodos();

            // Limpia el DataGridView antes de cargar
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            // Renombra las columnas para que se vean más presentables
            dgvEmpleados.Columns["EmpleadoId"].HeaderText = "ID";
            dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmpleados.Columns["Apellido"].HeaderText = "Apellido";
            dgvEmpleados.Columns["Sueldo"].HeaderText = "Sueldo";
            dgvEmpleados.Columns["Cargo"].HeaderText = "Cargo";

            // Agrega una columna adicional para mostrar el tipo de empleado (Planta o Temporal) usando el método ObtenerTipo() de cada objeto.
            if (dgvEmpleados.Columns["Tipo"] == null)
            {
                dgvEmpleados.Columns.Add("Tipo", "Tipo");
            }

            for (int i = 0; i < empleados.Count; i++)
            {
                dgvEmpleados.Rows[i].Cells["Tipo"].Value = empleados[i].ObtenerTipo();
            }

            // La idea de esto es simplemente ordenar cuando se recargue los empleados
            // para que siempre se muestren en el mismo orden, independientemente de cómo los traiga la base de datos.
            dgvEmpleados.Columns["EmpleadoId"].DisplayIndex = 0;
            dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
            dgvEmpleados.Columns["Apellido"].DisplayIndex = 2;
            dgvEmpleados.Columns["Sueldo"].DisplayIndex = 3;
            dgvEmpleados.Columns["Cargo"].DisplayIndex = 4;
            dgvEmpleados.Columns["Tipo"].DisplayIndex = 5;

            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Metodo para calcular el sueldo con bono del empleado seleccionado. Utiliza la sobrecarga de CalcularSueldo que recibe el bono.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Control de errores para asegurarse de que se ha seleccionado un empleado y
            // se ha ingresado un bono válido antes de intentar calcular el sueldo con bono.
            // Verifica que haya un empleado seleccionado
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona un empleado para calcular el sueldo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Verifica que el bono tenga un valor
            if (string.IsNullOrWhiteSpace(txtBono.Text))
            {
                MessageBox.Show(
                    "Ingresa un bono para calcular.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtiene el sueldo base y el bono
            decimal sueldoBase = Convert.ToDecimal(
                                 dgvEmpleados.SelectedRows[0].Cells["Sueldo"].Value);
            decimal bono = Convert.ToDecimal(txtBono.Text.Trim());

            // Obtiene el ID y tipo del empleado seleccionado
            int empleadoId = Convert.ToInt32(
                                 dgvEmpleados.SelectedRows[0].Cells["EmpleadoId"].Value);
            string tipoEmpleado = dgvEmpleados.SelectedRows[0].Cells["Tipo"].Value.ToString();

            // Instancia la clase correcta según el tipo
            // Aquí es donde la herencia cobra vida
            Empleado empleado;
            if (tipoEmpleado == "Empleado Planta")
                empleado = new EmpleadoPlanta(empleadoId, "", "", sueldoBase, "");
            else
                empleado = new EmpleadoTemporal(empleadoId, "", "", sueldoBase, "");

            // Llama a CalcularSueldo con bono — sobrecarga versión 2
            decimal sueldoConBono = empleado.CalcularSueldo(sueldoBase, bono);

            // Muestra el resultado
            lblResultadoBono.Text = $"${sueldoConBono}";

            // Pregunta si desea aplicar el bono al sueldo
            var confirmacion = MessageBox.Show(
                $"Sueldo base:     ${sueldoBase}\n" +
                $"Bono:            ${bono}\n" +
                $"Sueldo con bono: ${sueldoConBono}\n\n" +
                $"¿Desea aplicar el bono al sueldo del empleado?",
                "Aplicar Bono",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            // Aplica el bono actualizando el sueldo en la BD
            var emp = _empleadoFacade.ObtenerPorId(empleadoId);
            _empleadoFacade.Editar(emp.EmpleadoId, emp.Nombre, emp.Apellido,
                                   sueldoConBono, emp.Cargo, emp.TipoEmpleado);

            MessageBox.Show(
                "Bono aplicado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEmpleados();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0) return;

            // Obtiene el sueldo de la fila seleccionada
            var sueldo = dgvEmpleados.SelectedRows[0].Cells["Sueldo"].Value;

            // Muestra el sueldo base y resetea los otros campos
            lblResultadoBase.Text = $"${sueldo}";
            lblResultadoBono.Text = "$0.00";
            txtBono.Clear();
        }
    }
}