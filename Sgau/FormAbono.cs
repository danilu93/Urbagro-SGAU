using Logica;
using Modelo.Modelos;   
using Modelo.Enums;

namespace Sgau
{
    // Formulario para agregar o editar un abono asociado a una planta
    public partial class FormAbono : Form
    {
        private AbonoLogica abonoLogica = new(); // Instancia de la clase AbonoLogica para acceder a los métodos relacionados con los abonos
        private int plantaId; // Variable para almacenar el ID de la planta asociada al abono
        private Abono? abonoEditar; // Variable para almacenar el abono que se va a editar

        // Constructor para agregar un nuevo abono, recibe el ID de la planta como parámetro
        public FormAbono(int plantaId)
        {
            InitializeComponent();
            this.Opacity = 0.98; // Establecer la opacidad del formulario al 98%\

            this.plantaId = plantaId; // Asignar el ID de la planta al constructor del formulario


            CargarTiposAbono(); // Cargar los tipos de abono en el ComboBox

            this.AcceptButton = btnGuardarAbono; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarAbono; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape


        }

        // Constructor adicional para editar un abono existente, recibe el abono a editar como parámetro
        public FormAbono(Abono abono)
        {
            InitializeComponent();

            abonoEditar = abono;
            plantaId = abono.PlantaId; // Asignar el ID de la planta al constructor del formulario

            CargarTiposAbono(); // Cargar los tipos de abono en el ComboBox
            CargarDatos(); // Cargar los datos del abono en los controles del formulario para su edición

            this.AcceptButton = btnGuardarAbono; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarAbono; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape

        }

        // Método para cargar los tipos de abono en el ComboBox a partir del enum TipoAbono
        private void CargarTiposAbono()
        {
            cmbTipoAbono.DataSource = Enum.GetValues(typeof(TipoAbono)); // Cargar los tipos de abono en el ComboBox a partir del enum TipoAbono
        }

        // Método para cargar los datos del abono en los controles del formulario para su edición
        private void CargarDatos()
        {
            if (abonoEditar != null) // Verificar que se haya asignado un abono para editar
            {
                cmbTipoAbono.SelectedItem = abonoEditar.TipoAbono; // Seleccionar el tipo de abono en el ComboBox
                dtpFechaAbono.Value = abonoEditar.FechaAbono; // Cargar la fecha del abono en el DateTimePicker
                numCantidadAbono.Value = abonoEditar.CantidadAbono; // Cargar la cantidad del abono en el NumericUpDown
            }
        }

        // Método para manejar el evento de clic en el botón de guardar
        private void btnGuardarAbono_Click(object sender, EventArgs e)
        {
            try
            {
                if (abonoEditar == null)
                {
                    Abono abono = new Abono
                    {
                        PlantaId = plantaId, // Asignar el ID de la planta al nuevo abono
                        TipoAbono = (TipoAbono)cmbTipoAbono.SelectedItem, // Obtener el tipo de abono seleccionado en el ComboBox
                        FechaAbono = dtpFechaAbono.Value, // Obtener la fecha del abono del DateTimePicker
                        CantidadAbono = numCantidadAbono.Value // Obtener la cantidad del abono del NumericUpDown
                    };

                    abonoLogica.AgregarAbono(abono); // Llamar al método para agregar el nuevo abono a la base de datos
                    MessageBox.Show("Abono agregado exitosamente."); // Mostrar mensaje de éxito
                }
                else
                {
                    abonoEditar.TipoAbono = (TipoAbono)cmbTipoAbono.SelectedItem; // Actualizar el tipo de abono del abono a editar
                    abonoEditar.FechaAbono = dtpFechaAbono.Value; // Actualizar la fecha del abono del DateTimePicker
                    abonoEditar.CantidadAbono = numCantidadAbono.Value; // Actualizar la cantidad del abono del NumericUpDown

                    abonoLogica.EditarAbono(abonoEditar); // Llamar al método para actualizar el abono en la base de datos
                    MessageBox.Show("Abono actualizado exitosamente."); // Mostrar mensaje de éxito
                }
                this.Close(); // Cerrar el formulario después de guardar los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el abono: {ex.Message}"); // Mostrar mensaje de error en caso de que ocurra una excepción al guardar el abono
            }
        }

        // Método para manejar el evento de clic en el botón de cancelar
        private void btnCancelarAbono_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario sin guardar cambios al hacer clic en el botón de cancelar
        }
    }
}
