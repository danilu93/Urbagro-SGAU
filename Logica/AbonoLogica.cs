using Modelo.Modelos;
using EntityFramework.Datos;
using Modelo.Enums;

namespace Logica
{

    // Clase AbonoLogica que contiene la lógica de negocio para manejar las aplicaciones de abonos
    public class AbonoLogica
    {
        private AbonoDatos abonoDatos = new();

        // Método para obtener la lista de todas las aplicaciones de abonos
        public List<Abono> ListaAbonos()
        {
            return abonoDatos.ListaAbonos(); // Llama al método de datos para obtener la lista de aplicaciones de abonos
        }

        // Método para obtener la lista de aplicaciones de abonos por planta
        public List<Abono> ListaPorPlanta(int plantaId)
        {
            if (plantaId <= 0)
                throw new ArgumentException("Id de la planta inválido."); // Verifica que el ID de la planta sea un número positivo
            return abonoDatos.ListaPorPlanta(plantaId); // Llama al método de datos para obtener la lista de aplicaciones de abonos por planta
        }

        //  Método para obtener una aplicación de abono por su ID
        public Abono? ObtenerAbono(int abonoId)
        {
            if (abonoId <= 0)
                throw new ArgumentException("Id del abono inválido."); // Verifica que el ID del abono sea un número positivo
            var abono = abonoDatos.ObtenerAbono(abonoId); // Llama al método de datos para obtener la aplicación de abono por su ID
            if (abono == null)
                throw new Exception("Aplicación del abono no encontrada."); // Verifica que la aplicación de abono exista en la base de datos
            return abono;
        }

        // Método para agregar una nueva aplicación de abono
        public void AgregarAbono(Abono abono)
        {
            if (abono == null)
                throw new ArgumentNullException(nameof(abono), "El abono no puede ser nulo.");
            if (abono.PlantaId <= 0) // Verifica que el ID de la planta sea un número positivo
                throw new ArgumentException("Id de la planta inválido.");
            if (!Enum.IsDefined(typeof(TipoAbono), abono.TipoAbono)) // Verifica que el tipo de abono sea un valor válido del enum
                throw new ArgumentException("Tipo de abono inválido");
            if (abono.FechaAbono == default) // Verifica que la fecha de abono no sea la fecha por defecto
                throw new ArgumentException("Fecha de abono obligatoria.");
            if (abono.CantidadAbono <= 0) // Verifica que la cantidad de abono sea un número positivo
                throw new ArgumentException("Cantidad de abono debe ser mayor a cero.");

            bool resultado = abonoDatos.AgregarAbono(abono); // Llama al método de datos para agregar la aplicación de abono a la base de datos
            if (!resultado) // Si el método AgregarAbono devuelve false, significa que hubo un error al agregar la aplicación de abono
            {
                throw new Exception("Error al agregar la aplicación del abono."); // Lanza una excepción si hubo un error al agregar la aplicación del abono
            }
        }

        // Método para editar una aplicación de abono existente
        public void EditarAbono(Abono abono)
        {
            if (abono == null)
                throw new ArgumentNullException(nameof(abono), "El abono no puede ser nulo.");
            if (abono.AbonoId <= 0) // Verifica que el ID del abono sea un número positivo
                throw new ArgumentException("Id del abono inválido.");
            if (!Enum.IsDefined(typeof(TipoAbono), abono.TipoAbono)) // Verifica que el tipo de abono sea un valor válido del enum
                throw new ArgumentException("Tipo de abono inválido");
            if (abono.FechaAbono == default) // Verifica que la fecha de aplicación no sea la fecha por defecto
                throw new ArgumentException("Fecha de aplicación obligatoria.");
            if (abono.CantidadAbono <= 0) // Verifica que la cantidad de abono sea un número positivo
                throw new ArgumentException("Cantidad de abono debe ser mayor a cero.");

            bool resultado = abonoDatos.EditarAbono(abono); // Llama al método de datos para editar la aplicación de abono en la base de datos

            if (!resultado) // Si el método EditarAbono devuelve false, significa que hubo un error al editar la aplicación del abono
            {
                throw new Exception("Error al editar la aplicación del abono."); // Lanza una excepción si hubo un error al editar la aplicación del abono
            }
        }

        // Método para eliminar una aplicación de abono por su ID
        public void EliminarAbono(int abonoId)
        {
            if (abonoId <= 0) // Verifica que el ID del abono sea un número positivo
                throw new ArgumentException("Id del abono inválido.");

            bool resultado = abonoDatos.EliminarAbono(abonoId); // Llama al método de datos para eliminar la aplicación de abono de la base de datos

            if (!resultado) // Si el método EliminarAbono devuelve false, significa que hubo un error al eliminar la aplicación de abono
            {
                throw new Exception("Error al eliminar la aplicación del abono."); // Lanza una excepción si hubo un error al eliminar la aplicación de abono
            }
        }
    }
}

