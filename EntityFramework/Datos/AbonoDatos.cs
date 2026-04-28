using EntityFramework.Datos;
using Microsoft.EntityFrameworkCore;
using Modelo.Enums;
using Modelo.Modelos;

namespace EntityFramework.Datos
{

    // Clase que maneja las operaciones de datos relacionadas con la entidad Abono
    public class AbonoDatos
    {

        public List<Abono> ListaAbonos() // Método para obtener la lista de aplicación de abono
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Abono // Acceso a la tabla Abono
                        .Include(r => r.Planta)
                        .ToList(); // Convierte el resultado a una lista y lo retorna
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la lista de aplicación de abono. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la lista de aplicación de abono. ", ex);
                }
            }
        }

        // Método para obtener la lista de aplicación de abono por planta
        public List<Abono> ListaPorPlanta(int plantaId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Abono // Acceso a la tabla Abono
                        .Where(r => r.PlantaId == plantaId)
                        .OrderByDescending(r => r.FechaAbono)
                        .ToList(); // Convierte el resultado a una lista y lo retorna
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la lista de aplicación de abono por planta. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la lista de aplicación de abono por planta. ", ex);
                }
            }
        }

        // Método para obtener la aplicación de abono específico por su Id
        public Abono? ObtenerAbono(int abonoId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    return context.Abono // Acceso a la tabla Abono
                        .FirstOrDefault(r => r.AbonoId == abonoId);
                }
                // El bloque using asegura que el contexto se cierre correctamente después de su uso, incluso si ocurre una excepción.
            }
            catch (InvalidOperationException ex) // Se capturan excepciones específicas relacionadas con operaciones inválidas en Entity Framework
            {
                throw new InvalidOperationException("Error al obtener la aplicación de abono. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                {
                    throw new Exception("Error inesperado al obtener la aplicación de abono. ", ex);
                }
            }
        }

        // Método para agregar una nueva aplicación de abono a la base de datos
        public bool AgregarAbono(Abono abono) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    context.Abono.Add(abono); // Se agrega la nueva aplicación de abono al contexto
                    return context.SaveChanges() > 0; // Se guardan los cambios en la base de datos y se retorna true si se guardó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al agregar la aplicación de abono a la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al agregar la aplicación de abono. ", ex);
            }
        }

        // Método para editar una aplicación de abono existente en la base de datos
        public bool EditarAbono(Abono abono) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var abonoExistente = context.Abono.Find(abono.AbonoId); // Se busca la aplicación de abono existente por su ID

                    if (abonoExistente == null)
                        return false;

                    abonoExistente.TipoAbono = abono.TipoAbono; // Se actualiza el tipo de abono      
                    abonoExistente.FechaAbono = abono.FechaAbono; // Se actualiza la fecha de aplicación de abono
                    abonoExistente.CantidadAbono = abono.CantidadAbono; // Se actualiza la cantidad de abono

                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la aplicación de abono se editó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al editar la aplicación de abono en la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al editar la aplicación de abono. ", ex);
            }
        }

        // Método para eliminar una aplicación de abono de la base de datos por su ID
        public bool EliminarAbono(int abonoId) 
        {
            try
            {
                using (var context = new Conexion.AppDbContext())
                {
                    var abono = context.Abono.Find(abonoId); // Se busca la aplicación de abono por su ID
                    if (abono == null)
                        return false; // Se retorna false si la aplicación de abono no se encuentra

                    context.Abono.Remove(abono); // Se elimina la aplicación de abono del contexto
                    context.SaveChanges(); // Se guardan los cambios en la base de datos
                    return true; // Se retorna true si la aplicación de abono se eliminó correctamente
                }
            }
            catch (DbUpdateException ex) // Se capturan excepciones relacionadas con la actualización de la base de datos
            {
                throw new DbUpdateException("Error al eliminar la aplicación de abono de la base de datos. ", ex);
            }
            catch (Exception ex) // Se captura cualquier otra excepción inesperada
            {
                throw new Exception("Error inesperado al eliminar la aplicación de abono. ", ex);
            }
        }
    }

}