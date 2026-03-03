// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : IEmpleado.cs
// Capa     : BLL (Business Logic Layer)
// Propósito: Define el contrato que todos los tipos de empleado
//            deben cumplir. Es como un contrato por eso si o si se tiene que cumplir
// ─────────────────────────────────────────────────────────────────────────────

namespace GestionEmpleados.BLL
{
    public interface IEmpleado
    {
        //Calcula el sueldo del empleado considerando solo el sueldo base.
        decimal CalcularSueldo(decimal sueldoBase);

        //calcula el sueldo del empleado considerando el sueldo base y un bono adicional.
        decimal CalcularSueldo(decimal sueldoBase, decimal bono);
    }
}