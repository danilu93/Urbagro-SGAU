using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Modelo.Enums;

namespace EntityFramework.Datos
{
    // Clase que maneja las operaciones de datos relacionadas con la entidad Planta
    public class PlantaDatos
    {

        // Método para obtener la lista completa de plantas desde la base de datos
        public List<Planta> ListaPlantas() 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Plantas // Acceso a la tabla Plantas
                        .ToList(); // Convierte el resultado a una lista y lo retorna
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la lista de plantas. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la lista de plantas. ", ex);
                }
            }
        }

        // Método para obtener una planta específica por su ID desde la base de datos
        public Planta? ObtenerPlanta(int plantaId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Plantas
                        .FirstOrDefault(p => p.PlantaId == plantaId); // Se busca la planta con el ID especificado y se retorna, o null si no se encuentra
                }
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la planta. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al obtener la planta. ", ex);
            }
        }

        // Método para agregar una nueva planta a la base de datos
        public bool AgregarPlanta(Planta nuevaPlanta) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    context.Plantas.Add(nuevaPlanta); // Se agrega la nueva planta al contexto
                    return context.SaveChanges() > 0; // Se guardan los cambios en la base de datos y se retorna true si se guardó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al agregar la planta a la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al agregar la planta. ", ex);
            }
        }

        // Método para editar una planta existente en la base de datos
        public bool EditarPlanta(Planta planta) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var plantaExistente = context.Plantas.Find(planta.PlantaId); // Se busca la planta existente por su ID

                    if (plantaExistente == null)
                        return false;

                    plantaExistente.NombrePlanta = planta.NombrePlanta; // Se actualiza el nombre de la planta
                    plantaExistente.NombreCientifico = planta.NombreCientifico; // Se actualiza el nombre científico de la planta
                    plantaExistente.Descripcion = planta.Descripcion; // Se actualiza la descripción de la planta
                    plantaExistente.TipoPlanta = planta.TipoPlanta; // Se actualiza el tipo de planta
                    plantaExistente.FechaSiembra = planta.FechaSiembra; // Se actualiza la fecha de siembra de la planta
                    plantaExistente.MetodoSiembra = planta.MetodoSiembra; // Se actualiza el método de siembra de la planta

                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la planta se editó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al editar la planta en la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al editar la planta. ", ex);
            }
        }

        // Método para eliminar una planta de la base de datos por su ID
        public bool EliminarPlanta(int plantaId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var planta = context.Plantas.Find(plantaId); // Se busca la planta por su ID
                    if (planta == null)
                        return false; // Se retorna false si la planta no se encuentra

                    context.Plantas.Remove(planta); // Se elimina la planta del contexto
                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la planta se eliminó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al eliminar la planta de la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al eliminar la planta. ", ex);
            }
        }

        // Método para buscar plantas por su tipo en la base de datos
        public List<Planta> BuscarPorTipo(TipoPlanta tipo) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Plantas
                        .Where(p => p.TipoPlanta == tipo) // Se filtran las plantas por el tipo especificado
                        .ToList(); // Se convierte el resultado a una lista y se retorna
                }
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al buscar plantas por tipo. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al buscar plantas por tipo. ", ex);
            }
        }

        // Método para buscar plantas por su nombre en la base de datos
        public List<Planta> BuscarPorNombre(string nombre) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Plantas
                        .Where(p => p.NombrePlanta.Contains(nombre)) // Se filtran las plantas cuyo nombre contiene el texto especificado
                        .ToList(); // Se convierte el resultado a una lista y se retorna
                }
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al buscar plantas por nombre. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al buscar plantas por nombre. ", ex);
            }
        }

        // Método para verificar si una planta con un nombre específico ya existe en la base de datos
        public bool PlantaExiste(string nombrePlanta) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Plantas.Any(p => p.NombrePlanta == nombrePlanta); // Se verifica si existe alguna planta con el nombre especificado
                }
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al verificar la existencia de la planta. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al verificar la existencia de la planta. ", ex);
            }
        }
    }
}