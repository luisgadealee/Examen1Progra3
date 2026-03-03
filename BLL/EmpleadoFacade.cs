// ─────────────────────────────────────────────────────────────────────────────
// Archivo  : EmpleadoFacade.cs
// Capa     : BLL (Business Logic Layer)
// Propósito: Intermediario entre los formularios y la base de datos para todo lo relacionado con empleados.
// Patrón   : Facade — se toma este patron ya que es una clase que actúa como intermediaria entre los formularios y la base de datos,
//            simplificando el acceso a los datos y ocultando la complejidad de Entity Framework.
//            Los formularios solo hablan con esta clase, nunca acceden directamente a Entity Framework ni a la base de datos.
// ─────────────────────────────────────────────────────────────────────────────

using System.Collections.Generic;
using System.Linq;
using GestionEmpleados.DAL;

namespace GestionEmpleados.BLL
{
    public class EmpleadoFacade
    {
        // ─────────────────────────────────────────────────────────────────
        // Atributos
        // ─────────────────────────────────────────────────────────────────

        // Conexión a la base de datos a través de Entity Framework.
        private readonly BD_GestionEmpleadosEntities _db;

        // ─────────────────────────────────────────────────────────────────
        // Constructor
        // ─────────────────────────────────────────────────────────────────

        // Inicializa la conexión a la base de datos.
        // La idea es que sea solo una instancia de BD_GestionEmpleadosEntities para toda la clase,
        // por eso se inicializa en el constructor.
        public EmpleadoFacade()
        {
            _db = new BD_GestionEmpleadosEntities();
        }

        // ─────────────────────────────────────────────────────────────────
        // Métodos públicos — CRUD
        // ─────────────────────────────────────────────────────────────────

        // Letra "R" de "Read" — obtiene todos los empleados de la base de datos y los devuelve como una lista de objetos Empleado.
        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();

            foreach (var e in _db.Empleados.ToList())
            {
                // Según el TipoEmpleado de la BD instancia la clase correcta
                // Monta la lista de empleados con objetos de tipo EmpleadoPlanta o EmpleadoTemporal según corresponda
                if (e.TipoEmpleado == "Planta")
                    lista.Add(new EmpleadoPlanta(e.EmpleadoId, e.Nombre,
                                                 e.Apellido, e.Sueldo, e.Cargo));
                else
                    lista.Add(new EmpleadoTemporal(e.EmpleadoId, e.Nombre,
                                                   e.Apellido, e.Sueldo, e.Cargo));
            }
            // Devuelve la lista de empleados al formulario que la solicitó
            return lista;
        }

        // La letra "C" de "Create" — agrega un nuevo empleado a la base de datos.
        public void Agregar(string nombre, string apellido,
                            decimal sueldo, string cargo, string tipoEmpleado)
        {
            var nuevoEmpleado = new Empleados
            {
                Nombre = nombre,
                Apellido = apellido,
                Sueldo = sueldo,
                Cargo = cargo,
                TipoEmpleado = tipoEmpleado
            };

            // Manera de agregar un nuevo registro a la base de datos con Entity Framework:
            // Se usa el método Add() del DbSet correspondiente (en este caso, Empleados) para agregar el nuevo objeto a la "cola" de cambios,
            _db.Empleados.Add(nuevoEmpleado);
            // Luego se llama a SaveChanges() para que Entity Framework ejecute la consulta SQL correspondiente y guarde el nuevo registro en la base de datos.
            _db.SaveChanges();
        }

        // La letra "U" de "Update" — edita un empleado existente en la base de datos.
        public void Editar(int empleadoId, string nombre, string apellido,
                           decimal sueldo, string cargo, string tipoEmpleado)
        {
            // Busca el empleado en la BD por su ID
            var empleado = _db.Empleados.Find(empleadoId);

            if (empleado == null) return;

            // Actualiza los campos con los nuevos valores
            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Sueldo = sueldo;
            empleado.Cargo = cargo;
            empleado.TipoEmpleado = tipoEmpleado;

            _db.SaveChanges();
        }

        // La letra "D" de "Delete" — elimina un empleado de la base de datos.
        public void Eliminar(int empleadoId)
        {
            // Busca el empleado en la BD por su ID
            var empleado = _db.Empleados.Find(empleadoId);

            if (empleado == null) return;

            // Manera de eliminar un registro de la base de datos con Entity Framework:
            _db.Empleados.Remove(empleado);
            _db.SaveChanges();
        }
    }
}