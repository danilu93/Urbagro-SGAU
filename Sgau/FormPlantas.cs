using Modelo.Modelos;
using Logica;
using Modelo.Enums;

namespace Sgau
{

    // Formulario para agregar o editar plantas
    public partial class FormPlantas : Form
    {
        private PlantaLogica plantaLogica = new(); // Instancia de la clase PlantaLogica para acceder a los métodos relacionados con las plantas
        private Planta? plantaEditar; // Variable para almacenar la planta que se va a editar

        // Constructor del formulario de plantas
        public FormPlantas()
        {
            InitializeComponent();
            this.Opacity = 0.98; // Establecer la opacidad del formulario al 98%\

            CargarTipos(); // Cargar los tipos de plantas en el ComboBox

            this.AcceptButton = btnGuardarPlanta; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarPlanta; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape

        }

        // Constructor del formulario de plantas para editar una planta existente
        public FormPlantas(Planta planta)
        {
            InitializeComponent();
            CargarTipos(); // Cargar los tipos de plantas en el ComboBox

            plantaEditar = planta; // Asignar la planta que se va a editar a la variable plantaEditar
            CargarDatos(planta); // Cargar los datos de la planta en los controles del formulario para su edición

            this.AcceptButton = btnGuardarPlanta; // Establecer el botón de guardar como el botón predeterminado para que se active al presionar Enter
            this.CancelButton = btnCancelarPlanta; // Establecer el botón de cancelar como el botón predeterminado para que se active al presionar Escape

        }

        // Método para cargar los tipos de plantas en el ComboBox
        private void CargarTipos()
        {
            cmbTipoPlanta.DataSource = Enum.GetValues(typeof(TipoPlanta)); // Cargar los tipos de plantas en el ComboBox a partir del enum TipoPlanta
        }

        // Método para cargar los datos de una planta en los controles del formulario
        private void CargarDatos(Planta planta)
        {
            txtNombrePlanta.Text = planta.NombrePlanta; // Cargar el nombre de la planta en el TextBox
            txtNombreCientifico.Text = planta.NombreCientifico; // Cargar el nombre científico de la planta en el TextBox
            cmbTipoPlanta.SelectedItem = planta.TipoPlanta; // Seleccionar el tipo de planta en el ComboBox
            txtDescripcion.Text = planta.Descripcion; // Cargar la descripción de la planta en el TextBox
            txtMetodoSiembra.Text = planta.MetodoSiembra; // Cargar el método de siembra de la planta en el TextBox
            dtpFechaSiembra.Value = planta.FechaSiembra; // Cargar la fecha de siembra de la planta en el DateTimePicker
        }

        // Evento del botón para guardar la planta
        private void btnGuardarPlanta_Click(object sender, EventArgs e)
        {
            try
            {
                Planta planta;

                if (plantaEditar != null) // Si se está editando una planta existente
                {
                    planta = plantaEditar; // Utilizar la planta existente para actualizar sus datos
                }
                else // Si se está creando una nueva planta
                {
                    planta = new Planta(); // Crear una nueva instancia de Planta

                }

                planta.NombrePlanta = txtNombrePlanta.Text.Trim(); // Asignar el nombre de la planta desde el TextBox
                planta.NombreCientifico = txtNombreCientifico.Text.Trim(); // Asignar el nombre científico de la planta desde el TextBox
                planta.TipoPlanta = (TipoPlanta)cmbTipoPlanta.SelectedItem; // Asignar el tipo de planta desde el ComboBox
                planta.Descripcion = txtDescripcion.Text.Trim(); // Asignar la descripción de la planta desde el TextBox
                planta.MetodoSiembra = txtMetodoSiembra.Text.Trim(); // Asignar el método de siembra de la planta desde el TextBox
                planta.FechaSiembra = dtpFechaSiembra.Value; // Asignar la fecha de siembra de la planta desde el DateTimePicker

                if (plantaEditar != null)
                    
                    plantaLogica.EditarPlanta(planta); // Si se está creando una nueva planta, agregarla a la lógica de plantas

                else
                    plantaLogica.AgregarPlanta(planta); // Si se está editando, agregar la planta actualizada a la lógica de plantas

                MessageBox.Show("Planta guardada exitosamente."); // Mostrar un mensaje de éxito al guardar la planta

                this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo como OK para indicar que se guardó correctamente
                this.Close(); // Cerrar el formulario después de guardar la planta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la planta: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al guardar la planta
            }
        }

        // Evento del botón para cancelar la edición o creación de la planta
        private void btnCancelarPlanta_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario sin guardar los cambios
        }
    }
}
