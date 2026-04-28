using Microsoft.EntityFrameworkCore;
using Modelo.Modelos;
using Modelo.Enums;

namespace EntityFramework.Datos
{
    // Clase que maneja las operaciones de datos relacionadas con la entidad Irrigacion
    public class IrrigacionDatos
    {

        // Método para obtener la lista completa de irrigaciones, incluyendo la información de la planta asociada a cada riego
        public List<Irrigacion> ListaIrrigaciones() 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Irrigacion // Acceso a la tabla Irrigaciones
                        .Include(r => r.Planta) 
                        .ToList(); // Convierte el resultado a una lista y lo retorna
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la lista de riegos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la lista de riegos. ", ex);
                }
            }
        }

        // Método para obtener la lista de irrigaciones por planta, ordenada por fecha de riego de forma descendente
        public List<Irrigacion> ListaPorPlanta(int plantaId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Irrigacion // Acceso a la tabla Irrigaciones
                        .Where(r => r.PlantaId == plantaId)
                        .OrderByDescending(r => r.FechaRiego)
                        .ToList(); // Convierte el resultado a una lista y lo retorna
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la lista de riegos por planta. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la lista de riegos por planta. ", ex);
                }
            }
        }

        // Método para obtener un riego específico por su ID, incluyendo la información de la planta asociada
        public Irrigacion? ObtenerIrrigacion(int riegoId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Irrigacion // Acceso a la tabla Irrigaciones
                        .FirstOrDefault(r => r.RiegoId == riegoId);
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener el riego. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener el riego. ", ex);
                }
            }
        }

        // Método para agregar un nuevo riego a la base de datos
        public bool AgregarIrrigacion(Irrigacion irrigacion) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    context.Irrigacion.Add(irrigacion); // Se agrega el nuevo riego al contexto
                    return context.SaveChanges() > 0; // Se guardan los cambios en la base de datos y se retorna true si se guardó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al agregar el riego a la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al agregar el riego. ", ex);
            }
        }

        // Método para editar un riego existente en la base de datos
        public bool EditarIrrigacion(Irrigacion irrigacion) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var irrigacionExistente = context.Irrigacion.Find(irrigacion.RiegoId); // Se busca el riego existente por su ID

                    if (irrigacionExistente == null)
                        return false;

                    irrigacionExistente.MetodoRiego = irrigacion.MetodoRiego; // Se actualiza el método de riego
                    irrigacionExistente.FechaRiego = irrigacion.FechaRiego; // Se actualiza la fecha del riego
                    irrigacionExistente.CantidadRiego = irrigacion.CantidadRiego; // Se actualiza la cantidad del riego

                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la planta se editó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al editar el riego en la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al editar el riego. ", ex);
            }
        }

        // Método para eliminar un riego de la base de datos por su ID
        public bool EliminarIrrigacion(int riegoId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var irrigacion = context.Irrigacion.Find(riegoId); // Se busca el riego por su ID
                    if (irrigacion == null)
                        return false; // Se retorna false si el reigo no se encuentra

                    context.Irrigacion.Remove(irrigacion); // Se elimina el riego del contexto
                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la planta se eliminó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al eliminar el riego de la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al eliminar el riego. ", ex);
            }
        }
    }
    
}
