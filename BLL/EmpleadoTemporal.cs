// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : EmpleadoTemporal.cs
// Capa     : BLL (Business Logic Layer)
// Propósito: Representa un empleado de planta con contrato indefinido.
// ─────────────────────────────────────────────────────────────────────────────

namespace GestionEmpleados.BLL
{
    //Herencia aplicada: EmpleadoPlanta hereda de Empleado, lo que significa que tiene todas las propiedades y métodos de Empleado.
    public class EmpleadoTemporal : Empleado
    {
        // ─────────────────────────────────────────────────────────────────
        // Constructor
        // ─────────────────────────────────────────────────────────────────

        //Contructor que recibe todos los parámetros necesarios para inicializar un empleado de planta.
        // Llama al constructor de la clase base (Empleado) para inicializar los atributos heredados.
        // Se le llama contructor por parametros porque recibe parametros para inicializar el objeto.
        public EmpleadoTemporal(int empleadoId, string nombre, string apellido,
                              decimal sueldo, string cargo)
            : base(empleadoId, nombre, apellido, sueldo, cargo)
        {
        }

        // ─────────────────────────────────────────────────────────────────
        // Implementación del método abstracto
        // ─────────────────────────────────────────────────────────────────

        // La idea es que cada tipo de empleado pueda devolver su tipo específico, en este caso "Empleado Planta".
        public override string ObtenerTipo()
        {
            return "Empleado Temporal";
        }
    }
}