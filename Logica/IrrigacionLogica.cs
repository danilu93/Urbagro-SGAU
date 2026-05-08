using Modelo.Modelos;
using EntityFramework.Datos;
using Modelo.Enums;

namespace Logica
{

    // Clase que contiene la lógica de negocio relacionada con los riegos
    public class IrrigacionLogica
    {
        private IrrigacionDatos irrigacionDatos = new();

        // Método para obtener la lista de riegos
        public List<Irrigacion> ListaIrrigaciones()
        {
            return irrigacionDatos.ListaIrrigaciones(); // Llama al método de datos para obtener la lista de riegos
        }

        // Método para obtener la lista de riegos por planta
        public List<Irrigacion> ListaPorPlanta(int plantaId)
        {
            if (plantaId <= 0)
                throw new ArgumentException("Id de la planta inválido."); // Verifica que el ID de la planta sea un número positivo
            return irrigacionDatos.ListaPorPlanta(plantaId); // Llama al método de datos para obtener la lista de riegos por planta
        }

        // Método para obtener un riego por su ID
        public Irrigacion? ObtenerIrrigacion(int riegoId)
        {
            if (riegoId <= 0)
                throw new ArgumentException("Id del riego inválido."); // Verifica que el ID del riego sea un número positivo
            var irrigacion = irrigacionDatos.ObtenerIrrigacion(riegoId); // Llama al método de datos para obtener el riego por su ID
            if (irrigacion == null)
                throw new Exception("Riego no encontrado."); // Verifica que el riego exista en la base de datos
            return irrigacion;
        }

        // Método para agregar un nuevo riego
        public void AgregarIrrigacion(Irrigacion irrigacion)
        {
            if (irrigacion == null)
                throw new ArgumentNullException(nameof(irrigacion), "El riego no puede ser nulo.");
            if (irrigacion.PlantaId <= 0) // Verifica que el ID de la planta sea un número positivo
                throw new ArgumentException("Id de la planta inválido.");
            if (!Enum.IsDefined(typeof(MetodoRiego), irrigacion.MetodoRiego)) // Verifica que el método de riego sea un valor válido del enum
                throw new ArgumentException("Método de riego inválido");
            if (irrigacion.FechaRiego == default) // Verifica que la fecha de riego no sea la fecha por defecto
                throw new ArgumentException("Fecha de riego obligatoria.");
            if (irrigacion.CantidadRiego <= 0) // Verifica que la cantidad de riego sea un número positivo
                throw new ArgumentException("Cantidad de riego debe ser mayor a cero.");

            bool resultado = irrigacionDatos.AgregarIrrigacion(irrigacion); // Llama al método de datos para agregar el riego a la base de datos
            if (!resultado) // Si el método AgregarIrrigacion devuelve false, significa que hubo un error al agregar el riego
            {
                throw new Exception("Error al agregar el riego."); // Lanza una excepción si hubo un error al agregar el riego
            }
        }

        // Método para editar un riego existente
        public void EditarIrrigacion(Irrigacion irrigacion)
        {
            if (irrigacion == null)
                throw new ArgumentNullException(nameof(irrigacion), "El riego no puede ser nulo.");
            if (irrigacion.RiegoId <= 0) // Verifica que el ID del riego sea un número positivo
                throw new ArgumentException("Id del riego inválido.");
            if (!Enum.IsDefined(typeof(MetodoRiego), irrigacion.MetodoRiego)) // Verifica que el método de riego sea un valor válido del enum
                throw new ArgumentException("Método de riego inválido");
            if (irrigacion.FechaRiego == default) // Verifica que la fecha de riego no sea la fecha por defecto
                throw new ArgumentException("Fecha de riego obligatoria.");
            if (irrigacion.CantidadRiego <= 0) // Verifica que la cantidad de riego sea un número positivo
                throw new ArgumentException("Cantidad de riego debe ser mayor a cero.");

            bool resultado = irrigacionDatos.EditarIrrigacion(irrigacion); // Llama al método de datos para editar el riego en la base de datos

            if (!resultado) // Si el método EditarIrrigacion devuelve false, significa que hubo un error al editar el riego
            {
                throw new Exception("Error al editar el riego."); // Lanza una excepción si hubo un error al editar el riego
            }
        }

        // Método para eliminar un riego por su ID
        public void EliminarIrrigacion(int riegoId)
        {
            if (riegoId <= 0) // Verifica que el ID del riego sea un número positivo
                throw new ArgumentException("Id del riego inválido.");

            bool resultado = irrigacionDatos.EliminarIrrigacion(riegoId); // Llama al método de datos para eliminar el riego de la base de datos

            if (!resultado) // Si el método EliminarIrrigacion devuelve false, significa que hubo un error al eliminar el riego
            {
                throw new Exception("Error al eliminar el riego."); // Lanza una excepción si hubo un error al eliminar el riego
            }
        }
    }
}
