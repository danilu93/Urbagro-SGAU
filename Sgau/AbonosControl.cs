using Logica;
using Modelo.Modelos;

namespace Sgau
{
    // Control de usuario para gestionar los abonos asociados a las plantas 
    public partial class AbonosControl : UserControl
    {
        private int plantaId; // Variable para almacenar el ID de la planta asociada a los abonos
        private AbonoLogica abonoLogica = new(); // Instancia de la clase AbonoLogica para acceder a los métodos relacionados con los abonos
        private Abono? abonoSeleccionado; // Variable para almacenar el abono seleccionado en la lista de abonos
        private bool esAbonoGlobal;

        // Constructor del control de usuario para gestionar los abonos, con sobrecarga para permitir la inicialización sin un ID de planta específico o con un ID de planta específico
        public AbonosControl()
        {
            InitializeComponent();
            esAbonoGlobal = true; // Indicar que el control se ha inicializado sin un ID de planta específico, lo que significa que se mostrarán todos los abonos


            CargarTodosLosAbonos(); // Cargar la lista completa de abonos al inicializar el control

            dgvAbonos.ClearSelection();
            abonoSeleccionado = null; // Asegurar que no haya ningún abono seleccionado al cargar la lista completa de abonos

        }

        // Constructor del control de usuario para gestionar los abonos, con un ID de planta específico para mostrar solo los abonos relacionados con esa planta
        public AbonosControl(int plantaId)
        {
            InitializeComponent();
            this.plantaId = plantaId; // Asignar el ID de la planta al constructor del control
            esAbonoGlobal = false; // Indicar que el control se ha inicializado con un ID de planta específico, lo que significa que se mostrarán solo los abonos relacionados con esa planta

            CargarAbonos(); // Cargar la lista de abonos al inicializar el control
            dgvAbonos.ClearSelection();
            abonoSeleccionado = null; // Asegurar que no haya ningún abono seleccionado al cargar la lista de abonos
        }

        // Método para cargar los abonos en el DataGridView
        private void AbonosControl_Carga()
        {
            if (esAbonoGlobal)
                CargarTodosLosAbonos(); // Cargar la lista completa de abonos si el control se ha inicializado sin un ID de planta específico
            else
                CargarAbonos(); // Cargar la lista de abonos filtrada por planta si el control se ha inicializado con un ID de planta específico
        }

        // Método para configurar el DataGridView después de cargar los abonos
        private void ConfigurarDataGridView()
        {
            if (dgvAbonos.Columns.Contains("Planta"))
                dgvAbonos.Columns["Planta"].Visible = false; // Ocultar la columna de planta si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("PlantaId"))
                dgvAbonos.Columns["PlantaId"].Visible = false; // Ocultar la columna de ID de planta si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("AbonoId"))
                dgvAbonos.Columns["AbonoId"].Visible = false; // Ocultar la columna de ID del abono si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("NombrePlanta"))
                dgvAbonos.Columns["NombrePlanta"].HeaderText = "Planta"; // Cambiar el encabezado de la columna de nombre de planta a "Planta" si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("TipoAbono"))
                dgvAbonos.Columns["TipoAbono"].HeaderText = "Tipo de Abono"; // Cambiar el encabezado de la columna de tipo de abono a "Tipo de Abono" si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("CantidadAbono"))
                dgvAbonos.Columns["CantidadAbono"].HeaderText = "Cantidad de Abono"; // Cambiar el encabezado de la columna de cantidad de abono a "Cantidad de Abono" si existe en el DataGridView
            if (dgvAbonos.Columns.Contains("FechaAbono"))
                dgvAbonos.Columns["FechaAbono"].HeaderText = "Fecha de Abono"; // Cambiar el encabezado de la columna de fecha de abono a "Fecha de Abono" si existe en el DataGridView
        }

        // Método para cargar todos los abonos en el DataGridView sin fitrar por planta
        private void CargarTodosLosAbonos()
        {
            try
            {
                dgvAbonos.DataSource = abonoLogica.ListaAbonos(); // Cargar la lista completa de abonos en el DataGridView
                ConfigurarDataGridView(); // Configurar el DataGridView después de cargar los abonos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los abonos: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar los abonos
            }
        }

        // Método para cargar los abonos en el DataGridView filtrados por el ID de la planta
        private void CargarAbonos()
        {
            try
            {
                dgvAbonos.DataSource = abonoLogica.ListaPorPlanta(plantaId); // Cargar la lista de abonos en el DataGridView filtrada por el ID de la planta
                ConfigurarDataGridView(); // Configurar el DataGridView después de cargar los abonos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los abonos: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar los abonos
            }
        }

        // Event que selecciona el abono actual en el DataGridView y lo asigna a la variable abonoSeleccionado para su posterior edición o eliminación
        private void dgvAbonos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAbonos.CurrentRow != null) // Verificar que se haya seleccionado una fila válida en el DataGridView
            {
                abonoSeleccionado = dgvAbonos.CurrentRow.DataBoundItem as Abono; // Obtener el abono seleccionado a partir de la fila seleccionada en el DataGridView
            }
        }

        // Evento que abre el formulario de abono para editar el abono seleccionado
        private void btnEditarAbono_Click(object sender, EventArgs e)
        {
            if (abonoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un abono para editar."); // Mostrar un mensaje si no se ha seleccionado ningún abono para editar
                return;
            }

            FormAbono formAbono = new FormAbono(abonoSeleccionado); // Crear una instancia del formulario de abono, pasando el abono seleccionado para editar

            if (formAbono.ShowDialog() == DialogResult.OK)
                AbonosControl_Carga(); // Recargar la lista de abonos después de editar un abono existente

        }

        // Evento que elimina el abono seleccionado después de confirmar la acción con el usuario

        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            if (abonoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un abono para eliminar."); // Mostrar un mensaje si no se ha seleccionado ningún abono para eliminar
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este abono?", "Confirmar eliminación", MessageBoxButtons.YesNo); // Mostrar un mensaje de confirmación antes de eliminar el abono

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    abonoLogica.EliminarAbono(abonoSeleccionado.AbonoId); // Eliminar el abono seleccionado utilizando su ID
                    AbonosControl_Carga(); // Recargar la lista de abonos después de eliminar el abono
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el abono: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al eliminar el abono
                }
            }

        }

        // Evento que muestra la información de la planta asociada al abono seleccionado en un cuadro de mensaje o en una nueva vista
        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            if (abonoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un abono para ver su información."); // Mostrar un mensaje si no se ha seleccionado ningún abono para ver su información
                return;
            }

            var parentForm = this.FindForm() as MainForm; // Obtener el formulario padre del control para mostrar la información del abono en un cuadro de mensaje

            if (parentForm != null)
            {
                parentForm.CargarVista(new PlantasControl(
                    new List<Planta> { abonoSeleccionado.Planta }
                    )); // Cargar la vista de plantas en el formulario padre, pasando una lista con la planta asociada al abono seleccionado para mostrar su información
            }

        }
        
    }
}

