using Modelo.Modelos;
using EntityFramework.Datos;
using Modelo.Enums;


namespace Logica
{
    // Clase que contiene la lógica de negocio relacionada con las plantas
    public class PlantaLogica
    {
        // Instancia de la clase PlantaDatos para acceder a los métodos de datos relacionados con las plantas
        private PlantaDatos plantaDatos = new();

        // Método para obtener la lista de plantas
        public List<Planta> ListaPlantas()
        {
            return plantaDatos.ListaPlantas();
        }

        // Método para obtener una planta por su ID con validaciones
        public Planta ObtenerPlanta(int plantaId)
        {
            if (plantaId <= 0)
                throw new ArgumentException("Id de la planta inválido."); // Verifica que el ID de la planta sea un número positivo

            // Constructor de la clase PlantaDatos para acceder a los métodos de datos relacionados con las plantas
            var planta = plantaDatos.ObtenerPlanta(plantaId); // Llama al método de datos para obtener la planta por su ID

            if (planta == null)
                throw new Exception("Planta no encontrada."); // Verifica que la planta exista en la base de datos

            return planta;

        }

        // Método para agregar una planta con validaciones
        public void AgregarPlanta(Planta planta)
        {
            if (planta == null)
                throw new ArgumentNullException(nameof(planta), "La planta no puede ser nula.");
            if (string.IsNullOrWhiteSpace(planta.NombrePlanta)) // Verifica que el nombre de la planta no esté vacío o solo contenga espacios
                throw new ArgumentException("Nombre de planta obligatorio.");
            if (!Enum.IsDefined(typeof(TipoPlanta), planta.TipoPlanta)) // Verifica que el tipo de planta sea un valor válido del enum
                throw new ArgumentException("Tipo de planta inválido");
            if (planta.FechaSiembra == default) // Verifica que la fecha de siembra no sea la fecha por defecto
                throw new ArgumentException("Fecha de siembra obligatoria.");
            if (string.IsNullOrWhiteSpace(planta.MetodoSiembra)) // Verifica que el método de siembra no esté vacío o solo contenga espacios
                throw new ArgumentException("Método de siembra obligatorio.");
            if (plantaDatos.PlantaExiste(planta.NombrePlanta)) // Verifica que no exista una planta con el mismo nombre en la base de datos
                throw new Exception("Ya existe una planta con ese nombre.");

            bool resultado = plantaDatos.AgregarPlanta(planta); // Llama al método de datos para agregar la planta a la base de datos
            if (!resultado) // Si el método AgregarPlanta devuelve false, significa que hubo un error al agregar la planta
            {
                throw new Exception("Error al agregar la planta."); // Lanza una excepción si hubo un error al agregar la planta
            }
        }

        // Método para editar una planta con validaciones
        public void EditarPlanta(Planta planta)
        {
            if (planta == null)
                throw new ArgumentNullException(nameof(planta), "La planta no puede ser nula.");
            if (planta.PlantaId <= 0) // Verifica que el ID de la planta sea un número positivo
                throw new ArgumentException("Id de la planta inválido.");
            if (string.IsNullOrWhiteSpace(planta.NombrePlanta)) // Verifica que el nombre de la planta no esté vacío o solo contenga espacios
                throw new ArgumentException("Nombre de planta obligatorio.");
            if (!Enum.IsDefined(typeof(TipoPlanta), planta.TipoPlanta)) // Verifica que el tipo de planta sea un valor válido del enum
                throw new ArgumentException("Tipo de planta inválido");
            if (planta.FechaSiembra == default) // Verifica que la fecha de siembra no sea la fecha por defecto
                throw new ArgumentException("Fecha de siembra obligatoria.");
            if (plantaDatos.PlantaExiste(planta.NombrePlanta)) // Verifica que no exista otra planta con el mismo nombre
                throw new Exception("Ya existe otra planta con ese nombre.");

            bool resultado = plantaDatos.EditarPlanta(planta); // Llama al método de datos para editar la planta en la base de datos
            if (!resultado) // Si el método EditarPlanta devuelve false, significa que hubo un error al editar la planta
            {
                throw new Exception("Error al editar la planta."); // Lanza una excepción si hubo un error al editar la planta
            }
        }

        // Método para eliminar una planta con validaciones
        public void EliminarPlanta(int plantaId)
        {
            if (plantaId <= 0) // Verifica que el ID de la planta sea un número positivo
                throw new ArgumentException("Id de la planta inválido.");

            bool resultado = plantaDatos.EliminarPlanta(plantaId); // Llama al método de datos para eliminar la planta por su ID
            if (!resultado) // Si el método EliminarPlanta devuelve false, significa que hubo un error al eliminar la planta
            {
                throw new Exception("Error al eliminar la planta."); // Lanza una excepción si hubo un error al eliminar la planta
            }
        }

        // Método para obtener la lista de plantas por tipo con validaciones
        public List<Planta> BuscarPorTipo(TipoPlanta tipo)
        {
            if (!Enum.IsDefined(typeof(TipoPlanta), tipo)) // Verifica que el tipo de planta sea un valor válido del enum
                throw new ArgumentException("Tipo de planta inválido.");

            return plantaDatos.BuscarPorTipo(tipo);
        }

        // Método para obtener la lista de plantas por nombre con validaciones
        public List<Planta> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) // Verifica que el nombre no esté vacío o solo contenga espacios
                throw new ArgumentException("Nombre de planta inválido.");

            return plantaDatos.BuscarPorNombre(nombre);
        }
    }
}