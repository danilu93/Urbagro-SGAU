using Logica;
using Modelo.Modelos;
using Modelo.Enums;

namespace Sgau
{
    // Formulario para agregar o editar un riego asociado a una planta
    public partial class FormRiego : Form
    {
        private IrrigacionLogica irrigacionLogica = new(); // Instancia de la clase IrrigacionLogica para acceder a los métodos relacionados con los riegos
        private int plantaId; // Variable para almacenar el ID de la planta asociada al riego
        private Irrigacion? riegoEditar; // Variable para almacenar el riego que se va a editar

        // Constructor del formulario de riego para agregar un nuevo riego
        public FormRiego(int plantaId)
        {
            InitializeComponent();
            this.Opacity = 0.98; // Establecer la opacidad del formulario al 98%\

            this.plantaId = plantaId; // Asignar el ID de la planta al constructor del formulario

            CargarMetodosRiego(); // Cargar los métodos de riego en el ComboBox

            this.AcceptButton = btnGuardarRiego; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarRiego; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape



        }

        // Constructor del formulario de riego para editar un riego existente
        public FormRiego(Irrigacion riego)
        {
            InitializeComponent();
            riegoEditar = riego;
            plantaId = riego.PlantaId; // Asignar el ID de la planta al constructor del formulario

            CargarMetodosRiego(); // Cargar los métodos de riego en el ComboBox
            CargarDatos(); // Cargar los datos del riego en los controles del formulario para su edición

            this.AcceptButton = btnGuardarRiego; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarRiego; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape

        }

        // Método para cargar los métodos de riego en el ComboBox
        private void CargarMetodosRiego()
        {
            cmbMetodoRiego.DataSource = Enum.GetValues(typeof(MetodoRiego)); // Cargar los métodos de riego en el ComboBox a partir del enum MetodoRiego
        }

        // Método para cargar los datos de un riego en los controles del formulario
        private void CargarDatos()
        {
            if (riegoEditar != null) // Verificar que se haya asignado un riego para editar
            {
                cmbMetodoRiego.SelectedItem = riegoEditar.MetodoRiego; // Seleccionar el método de riego en el ComboBox
                dtpFechaRiego.Value = riegoEditar.FechaRiego; // Cargar la fecha del riego en el DateTimePicker
                numCantidadRiego.Value = riegoEditar.CantidadRiego; // Cargar la cantidad de agua del riego en el NumericUpDown
            }
        }

        // Evento para manejar el clic en el botón de guardar
        private void btnGuardarRiego_Click(object sender, EventArgs e)
        {
            try
            {
                if (riegoEditar == null)
                {
                    Irrigacion irrigacion = new Irrigacion
                    {
                        PlantaId = plantaId, // Asignar el ID de la planta al nuevo riego
                        MetodoRiego = (MetodoRiego)cmbMetodoRiego.SelectedItem, // Obtener el método de riego seleccionado en el ComboBox
                        FechaRiego = dtpFechaRiego.Value, // Obtener la fecha del riego del DateTimePicker
                        CantidadRiego = numCantidadRiego.Value // Obtener la cantidad de agua del riego del NumericUpDown
                    };

                    irrigacionLogica.AgregarIrrigacion(irrigacion); // Llamar al método para agregar el nuevo riego a la base de datos
                    MessageBox.Show("Riego agregado exitosamente."); // Mostrar un mensaje de éxito al usuario
                }
                else
                {
                    riegoEditar.MetodoRiego = (MetodoRiego)cmbMetodoRiego.SelectedItem; // Actualizar el método de riego del riego a editar
                    riegoEditar.FechaRiego = dtpFechaRiego.Value; // Actualizar la fecha del riego del riego a editar
                    riegoEditar.CantidadRiego = numCantidadRiego.Value; // Actualizar la cantidad de agua del riego del riego a editar

                    irrigacionLogica.EditarIrrigacion(riegoEditar); // Llamar al método para actualizar el riego en la base de datos
                    MessageBox.Show("Riego actualizado exitosamente."); // Mostrar un mensaje de éxito al usuario
                }

                this.Close(); // Cerrar el formulario después de guardar los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el riego: {ex.Message}"); // Mostrar un mensaje de error al usuario en caso de que ocurra una excepción
            }
        }

        // Evento para manejar el clic en el botón de cancelar
        private void btnCancelarRiego_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario sin guardar cambios
        }
    }
}
