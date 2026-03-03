// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : Empleado.cs
// Capa     : BLL (Business Logic Layer)
// Propósito: Clase base abstracta que representa un empleado genérico.
//            La idea es que sea la base para las clases Planta y Temporal, que heredan de ella.
// ─────────────────────────────────────────────────────────────────────────────

namespace GestionEmpleados.BLL
{
    public abstract class Empleado : IEmpleado
    {
        // ─────────────────────────────────────────────────────────────────
        // Atributos comunes a todos los empleados
        // Las clases hijas heredan estas propiedades automáticamente
        // ─────────────────────────────────────────────────────────────────

        //Identificador único del empleado en la base de datos.
        public int EmpleadoId { get; set; }

        //Nombre del empleado.
        public string Nombre { get; set; }

        //Apellido del empleado.
        public string Apellido { get; set; }

        //Sueldo base del empleado.
        public decimal Sueldo { get; set; }

        //Cargo que ocupa el empleado en la empresa.
        public string Cargo { get; set; }

        // ─────────────────────────────────────────────────────────────────
        // Constructor
        // ─────────────────────────────────────────────────────────────────

        //Siempre se usa protected para que solo las clases hijas puedan crear instancias de Empleado.
        protected Empleado(int empleadoId, string nombre, string apellido,
                           decimal sueldo, string cargo)
        {
            EmpleadoId = empleadoId;
            Nombre = nombre;
            Apellido = apellido;
            Sueldo = sueldo;
            Cargo = cargo;
        }

        // ─────────────────────────────────────────────────────────────────
        // Implementación de IEmpleado — Sobrecarga de Metodos
        // ─────────────────────────────────────────────────────────────────

        //Calcula el sueldo considerando solo el sueldo base.
        public decimal CalcularSueldo(decimal sueldoBase)
        {
            return sueldoBase;
        }

        //Calcula el sueldo considerando el sueldo base y un bono adicional.
        public decimal CalcularSueldo(decimal sueldoBase, decimal bono)
        {
            return sueldoBase + bono;
        }

        // ─────────────────────────────────────────────────────────────────
        // Método abstracto
        // ─────────────────────────────────────────────────────────────────

        // Método abstracto que obliga a las clases hijas a implementar su propia versión de este método.
        // La idea es que cada tipo de empleado (Planta, Temporal) pueda devolver su tipo específico.
        public abstract string ObtenerTipo();
    }
}