using Logica;
using Modelo.Modelos;


namespace Sgau
{
    // Control de usuario para gestionar los riegos asociados a las plantas, permitiendo visualizar, editar y eliminar los riegos registrados en el sistema
    public partial class RiegosControl : UserControl
    {
        private int plantaId; // Variable para almacenar el ID de la planta asociada a los riegos
        private IrrigacionLogica irrigacionLogica = new(); // Instancia de la clase IrrigacionLogica para acceder a los métodos relacionados con los riegos
        private Irrigacion? riegoSeleccionado; // Variable para almacenar el riego seleccionado en la lista de riegos
        private bool esRiegoGlobal;

        // Constructor del control de riegos para cargar la lista completa de riegos sin filtrar por planta
        public RiegosControl()
        {
            InitializeComponent();
            esRiegoGlobal = true;
            CargarTodosLosRiegos(); // Cargar la lista completa de riegos al inicializar el control

            dgvRiegos.ClearSelection();
            riegoSeleccionado = null; // Asegurar que no haya ningún riego seleccionado al cargar la lista completa de riegos
        }

        // Constructor del control de riegos para cargar la lista de riegos filtrada por el ID de la planta
        public RiegosControl(int plantaId)
        {
            InitializeComponent();
            this.plantaId = plantaId; // Asignar el ID de la planta al constructor del control
            esRiegoGlobal = false;

            CargarRiegos(); // Cargar la lista de riegos al inicializar el control

            dgvRiegos.ClearSelection();
            riegoSeleccionado = null; // Asegurar que no haya ningún riego seleccionado al cargar la lista de riegos filtrada por planta

        }

        // Método para cargar la lista de riegos en el DataGridView
        private void RiegosControl_Carga()
        {
            if (esRiegoGlobal)
                CargarTodosLosRiegos(); // Cargar la lista completa de riegos si el control se ha inicializado sin un ID de planta específico
            else
                CargarRiegos(); // Cargar la lista de riegos filtrada por planta si el control se ha inicializado con un ID de planta específico
        }

        // Método para configurar las columnas del DataGridView
        private void ConfigurarDataGridView()
        {
            if (dgvRiegos.Columns.Contains("Planta"))
                dgvRiegos.Columns["Planta"].Visible = false; // Ocultar la columna de planta si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("PlantaId"))
                dgvRiegos.Columns["PlantaId"].Visible = false; // Ocultar la columna de ID de planta si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("RiegoId"))
                dgvRiegos.Columns["RiegoId"].Visible = false; // Ocultar la columna de ID del riego si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("NombrePlanta"))
                dgvRiegos.Columns["NombrePlanta"].HeaderText = "Planta"; // Cambiar el encabezado de la columna de nombre de planta a "Planta" si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("MetodoRiego"))
                dgvRiegos.Columns["MetodoRiego"].HeaderText = "Método de Riego"; // Cambiar el encabezado de la columna de metodo de riego a "Metodo de Riego" si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("CantidadRiego"))
                dgvRiegos.Columns["CantidadRiego"].HeaderText = "Cantidad de Riego"; // Cambiar el encabezado de la columna de cantidad de reigo a "Cantidad de Riego" si existe en el DataGridView
            if (dgvRiegos.Columns.Contains("FechaRiego"))
                dgvRiegos.Columns["FechaRiego"].HeaderText = "Fecha de Riego"; // Cambiar el encabezado de la columna de fecha de riego a "Fecha de Riego" si existe en el DataGridView
        }

        // Método para cargar la lista completa de riegos en el DataGridView
        private void CargarTodosLosRiegos()
        {
            try
            {
                dgvRiegos.DataSource = irrigacionLogica.ListaIrrigaciones(); // Cargar la lista completa de riegos en el DataGridView
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los riegos: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar los riegos
            }
        }

        // Método para cargar la lista de riegos filtrada por el ID de la planta en el DataGridView
        private void CargarRiegos()
        {
            try
            {
                dgvRiegos.DataSource = irrigacionLogica.ListaPorPlanta(plantaId); // Cargar la lista de riegos en el DataGridView filtrada por el ID de la planta
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los riegos: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar los riegos
            }
        }

        // Evento que selecciona una fila en el DataGridView para actualizar la variable de riego seleccionado con el riego correspondiente a la fila seleccionada
        private void dgvRiegos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRiegos.CurrentRow != null) // Verificar que se haya seleccionado una fila válida en el DataGridView
            {
                riegoSeleccionado = dgvRiegos.CurrentRow.DataBoundItem as Irrigacion; // Obtener el riego seleccionado a partir de la fila seleccionada en el DataGridView
            }
        }

        // Evento que abre el formulario de riego para editar el riego seleccionado
        private void btnEditarRiego_Click(object sender, EventArgs e)
        {
            if (riegoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un riego para editar."); // Mostrar un mensaje si no se ha seleccionado ningún riego para editar
                return;
            }

            FormRiego formRiego = new FormRiego(riegoSeleccionado); // Crear una instancia del formulario de riego, pasando el riego seleccionado para editar

            if (formRiego.ShowDialog() == DialogResult.OK)
                RiegosControl_Carga(); // Recargar la lista de riegos después de editar un riego
        }

        // Evento que elimina el riego seleccionado después de confirmar la acción con el usuario
        private void btnEliminarRiego_Click(object sender, EventArgs e)
        {
            if (riegoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un riego para eliminar."); // Mostrar un mensaje si no se ha seleccionado ningún riego para eliminar
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este riego?", "Confirmar eliminación", MessageBoxButtons.YesNo); // Mostrar un mensaje de confirmación antes de eliminar el riego

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    irrigacionLogica.EliminarIrrigacion(riegoSeleccionado.RiegoId); // Llamar al método de lógica para eliminar el riego seleccionado
                    RiegosControl_Carga(); // Recargar la lista de riegos después de eliminar el riego
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el riego: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al eliminar el riego
                }
            }
        }

        // Evento que muestra la información de la planta asociada al riego seleccionado en un cuadro de mensaje o en una nueva vista
        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            if (riegoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un riego para ver su información."); // Mostrar un mensaje si no se ha seleccionado ningún riego para ver su información
                return;
            }

            var parentForm = this.FindForm() as MainForm; // Obtener el formulario padre del control para mostrar la información del riego en un cuadro de mensaje

            if (parentForm != null)
            {
                parentForm.CargarVista(new PlantasControl(
                    new List<Planta> { riegoSeleccionado.Planta }
                    )); // Cargar la vista de plantas en el formulario padre, pasando una lista con la planta asociada al riego seleccionado para mostrar su información
            }
        }
    }
}
