// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : IEmpleado.cs
// Capa     : BLL (Business Logic Layer)
// Propósito: Define el contrato que todos los tipos de empleado
//            deben cumplir. Cualquier clase que implemente esta
//            interfaz DEBE tener el método CalcularSueldo.
// ─────────────────────────────────────────────────────────────────────────────

namespace GestionEmpleados.BLL
{
    /// <summary>
    /// Interfaz que define el comportamiento común de todos los empleados.
    /// Garantiza que cualquier tipo de empleado pueda calcular su sueldo.
    /// </summary>
    public interface IEmpleado
    {
        /// <summary>
        /// Calcula el sueldo del empleado dado un sueldo base.
        /// </summary>
        /// <param name="sueldoBase">Sueldo base del empleado</param>
        /// <returns>Sueldo calculado</returns>
        decimal CalcularSueldo(decimal sueldoBase);

        /// <summary>
        /// Calcula el sueldo del empleado considerando un bono adicional.
        /// Sobrecarga del método anterior.
        /// </summary>
        /// <param name="sueldoBase">Sueldo base del empleado</param>
        /// <param name="bono">Bono adicional a sumar</param>
        /// <returns>Sueldo calculado incluyendo el bono</returns>
        decimal CalcularSueldo(decimal sueldoBase, decimal bono);
    }
}