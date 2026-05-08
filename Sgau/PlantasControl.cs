using Logica;
using Modelo.Enums;
using Modelo.Modelos;

namespace Sgau
{

    /* Control de usuario para gestionar las plantas, incluyendo la visualización, búsqueda, adición, edición y eliminación de plantas, 
     * así como el acceso a los formularios de riegos y abonos relacionados con cada planta */
    public partial class PlantasControl : UserControl 
    {
        private PlantaLogica plantaLogica = new(); // Instancia de la clase PlantaLogica para acceder a los métodos relacionados con las plantas
        private Planta? plantaSeleccionada; // Variable para almacenar la planta seleccionada en la lista de plantas

        // // Constructor por defecto que inicializa el control y carga la lista de tipos de plantas y plantas
        public PlantasControl() 
        {
            InitializeComponent();

            dgvPlantas.SelectionChanged += dgvPlantas_SelectionChanged; // Evento para actualizar la planta seleccionada cada vez que cambie la selección en el DataGridView de plantas
            CargarTiposPlantas(); // Cargar la lista de tipos de plantas al inicializar el control
            CargarPlantas(); // Cargar la lista de plantas al inicializar el control
            dgvPlantas.ClearSelection(); // Limpiar la selección del DataGridView después de cargar las plantas para que no haya ninguna planta seleccionada por defecto
            plantaSeleccionada = null; // Asegurar que no haya ninguna planta seleccionada al cargar la lista de plantas

        }

        // Constructor que recibe una lista de plantas para mostrar en el DataGridView
        public PlantasControl(List<Planta> plantas) 
        {
            InitializeComponent();

            dgvPlantas.SelectionChanged += dgvPlantas_SelectionChanged; // Evento para actualizar la planta seleccionada cada vez que cambie la selección en el DataGridView de plantas
            CargarTiposPlantas(); // Cargar la lista de tipos de plantas al inicializar el control
            dgvPlantas.DataSource = plantas; // Cargar la lista de plantas proporcionada en el DataGridView

            dgvPlantas.ClearSelection(); // Limpiar la selección del DataGridView después de cargar las plantas para que no haya ninguna planta seleccionada por defecto
            plantaSeleccionada = null; // Asegurar que no haya ninguna planta seleccionada al cargar la lista de plantas


        }

        // Método para configurar las columnas del DataGridView de plantas, ocultando columnas innecesarias y estableciendo encabezados personalizados para las columnas relevantes
        private void ConfigurarDataGridView()
        {
            if (dgvPlantas.Columns.Contains("Planta"))
                dgvPlantas.Columns["Planta"].Visible = false; // Ocultar la columna de planta si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("PlantaId"))
                dgvPlantas.Columns["PlantaId"].Visible = false; // Ocultar la columna de ID de planta si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("NombrePlanta"))
                dgvPlantas.Columns["NombrePlanta"].HeaderText = "Planta"; // Cambiar el encabezado de la columna de nombre de planta a "Planta" si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("TipoPlanta"))
                dgvPlantas.Columns["TipoPlanta"].HeaderText = "Tipo de Planta"; // Cambiar el encabezado de la columna de tipo de planta a "Tipo de Planta" si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("NombreCientifico"))
                dgvPlantas.Columns["NombreCientifico"].HeaderText = "Nombre Científico"; // Cambiar el encabezado de la columna de nombre científico a "Nombre Científico" si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("MetodoSiembra"))
                dgvPlantas.Columns["MetodoSiembra"].HeaderText = "Método de Siembra"; // Cambiar el encabezado de la columna de método de siembra a "Método de Siembra" si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("FechaSiembra"))        
                dgvPlantas.Columns["FechaSiembra"].HeaderText = "Fecha de Siembra"; // Cambiar el encabezado de la columna de fecha de siembra a "Fecha de Siembra" si existe en el DataGridView
            if (dgvPlantas.Columns.Contains("Descripcion"))
                dgvPlantas.Columns["Descripcion"].HeaderText = "Descripción"; // Cambiar el encabezado de la columna de descripción a "Descripción" si existe en el DataGridView

        }


        // Método para cargar la lista de plantas en el DataGridView
        public void CargarPlantas() 
        {
            try
            {
                dgvPlantas.DataSource = plantaLogica.ListaPlantas(); // Cargar la lista de plantas en el DataGridView
                ConfigurarDataGridView(); // Configurar las columnas del DataGridView después de cargar las plantas para mostrar los encabezados personalizados y ocultar las columnas innecesarias 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las plantas: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar las plantas
            }
        }

        // Método para cargar la lista de tipos de plantas en el ComboBox
        private void CargarTiposPlantas() 
        {
            cmbTipoPlanta.Items.Clear(); // Limpiar el ComboBox de tipos de plantas
            cmbTipoPlanta.Items.Add("Todos"); // Agregar cada tipo de planta al ComboBox

            foreach (var tipo in Enum.GetValues(typeof(TipoPlanta)))
            {
                cmbTipoPlanta.Items.Add(tipo); // Agregar cada tipo de planta al ComboBox
            }
            cmbTipoPlanta.SelectedIndex = 0; // Establecer la primera opción como seleccionada por defecto
        }

        // Evento que se ejecuta al hacer clic en el botón de búsqueda para realizar la búsqueda de plantas según el nombre y tipo seleccionados
        private void Busqueda()
        {
            try
            {
                string nombreBusqueda = txtTipoPlanta.Text.Trim(); // Obtener el texto de búsqueda ingresado por el usuario
                var tipoSeleccionado = cmbTipoPlanta.SelectedItem.ToString(); // Obtener el tipo de planta seleccionado en el ComboBox

                List<Planta> resultadosBusqueda;

                bool filtroNombre = !string.IsNullOrEmpty(nombreBusqueda); // Verificar si se ha ingresado un nombre de planta para filtrar
                bool filtroTipo = tipoSeleccionado != "Todos"; // Verificar si se ha seleccionado un tipo de planta para filtrar

                if (filtroNombre && filtroTipo) // Si se han ingresado ambos filtros, filtrar por nombre y tipo de planta
                {
                    var tipoEnum = (TipoPlanta)Enum.Parse(typeof(TipoPlanta), tipoSeleccionado); // Convertir el tipo de planta seleccionado a su valor enum correspondiente
                    resultadosBusqueda = plantaLogica.BuscarPorNombre(nombreBusqueda) // Buscar por nombre de planta
                        .Where(p => p.TipoPlanta == tipoEnum) // Filtrar los resultados por el tipo de planta seleccionado
                        .ToList();
                }
                else if (filtroNombre) // Si solo se ha ingresado un nombre de planta, filtrar por nombre
                {
                    resultadosBusqueda = plantaLogica.BuscarPorNombre(nombreBusqueda);
                }
                else if (filtroTipo) // Si solo se ha seleccionado un tipo de planta, filtrar por tipo de planta
                {
                    var tipoEnum = (TipoPlanta)Enum.Parse(typeof(TipoPlanta), tipoSeleccionado);
                    resultadosBusqueda = plantaLogica.ListaPlantas()
                        .Where(p => p.TipoPlanta == tipoEnum)
                        .ToList();
                }
                else
                {
                    resultadosBusqueda = plantaLogica.ListaPlantas(); // Si no se ha ingresado ningún filtro, mostrar todas las plantas
                }
                dgvPlantas.DataSource = resultadosBusqueda; // Mostrar los resultados de la búsqueda en el DataGridView
                dgvPlantas.ClearSelection(); // Limpiar la selección del DataGridView después de mostrar los resultados de la búsqueda
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}");
            }


        }

        // Evento que se ejecuta al hacer clic en el botón de búsqueda para realizar la búsqueda de plantas según el nombre y tipo seleccionados
        private void btnTipoPlanta_Click(object sender, EventArgs e)
        {
            Busqueda(); // Llamar al método de búsqueda al hacer clic en el botón de búsqueda
        }

        // Evento que se ejecuta al presionar una tecla mientras el TextBox de búsqueda tiene el foco para realizar la búsqueda al presionar la tecla Enter
        private void txtTipoPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Si se presiona la tecla Enter mientras el TextBox de búsqueda tiene el foco, realizar la búsqueda
            {
                Busqueda(); // Llamar al método de búsqueda al presionar Enter
                            // e.Handled = true; // Marcar el evento como manejado para evitar que se realice una acción adicional al presionar Enter
            }
        }

        // Evento que se ejecuta cada vez que el texto del TextBox de búsqueda cambia para realizar una búsqueda en tiempo real
        private void txtTipoPlanta_TextChanged(object sender, EventArgs e)
        {
            Busqueda(); // Llamar al método de búsqueda cada vez que el texto del TextBox de búsqueda cambie para realizar una búsqueda en tiempo real
        }

        // Evento que se ejecuta cada vez que se cambia la selección del ComboBox de tipo de planta para realizar una búsqueda en tiempo real
        private void cmbTipoPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Busqueda(); // Llamar al método de búsqueda cada vez que se cambie la selección del ComboBox de tipo de planta para realizar una búsqueda en tiempo real
        }

        // Evento que se ejecuta cada vez que se cambia la selección en el DataGridView de plantas para actualizar la planta seleccionada
        private void dgvPlantas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlantas.CurrentRow != null) // Verificar que se haya seleccionado una fila válida del DataGridView
            {
                plantaSeleccionada = dgvPlantas.CurrentRow.DataBoundItem as Planta; // Obtener la planta seleccionada a partir de la fila seleccionada en el DataGridView
                // Aquí puedes realizar acciones adicionales con la planta seleccionada, como mostrar detalles o permitir su edición
            }
        }

        // Evento que ejecuta el botón de agregar una planta nueva
        private void btnAgregarPlanta_Click(object sender, EventArgs e)
        {
            FormPlantas formPlanta = new FormPlantas(); // Crear una instancia del formulario para agregar una nueva planta

            if (formPlanta.ShowDialog() == DialogResult.OK) // Mostrar el formulario como un diálogo modal y verificar si se hizo clic en el botón OK para agregar la planta
            {
                CargarPlantas(); // Recargar la lista de plantas después de agregar una nueva planta para mostrar la actualización en el DataGridView
            }
        }

        // Evento que ejecuta el botón de editar planta
        private void btnEditarPlanta_Click(object sender, EventArgs e)
        {
            if (plantaSeleccionada == null) // Verificar que se haya seleccionado una planta para editar
            {
                MessageBox.Show("Por favor, seleccione una planta para editar."); // Mostrar un mensaje de advertencia si no se ha seleccionado ninguna planta para editar
                return;
            }

            FormPlantas formPlanta = new FormPlantas(plantaSeleccionada); // Crear una instancia del formulario para editar la planta seleccionada, pasando la planta como parámetro

            if (formPlanta.ShowDialog() == DialogResult.OK) // Mostrar el formulario como un diálogo modal y verificar si se hizo clic en el botón OK para guardar los cambios de la planta editada
                CargarPlantas(); // Recargar la lista de plantas después de editar una planta para mostrar la actualización en el DataGridView
        }

        // Evento que ejecuta el botón de eliminar planta
        private void btnEliminarPlanta_Click(object sender, EventArgs e)
        {
            if (plantaSeleccionada == null) // Verificar que se haya seleccionado una planta para eliminar
            {
                MessageBox.Show("Por favor, seleccione una planta para eliminar."); // Mostrar un mensaje de advertencia si no se ha seleccionado ninguna planta para eliminar
                return;
            }
            var confirmacion = MessageBox.Show($"¿Estás seguro de que deseas eliminar la planta '{plantaSeleccionada.NombrePlanta}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Mostrar un mensaje de confirmación antes de eliminar la planta seleccionada

            if (confirmacion == DialogResult.Yes) // Verificar si el usuario confirmó la eliminación de la planta
            {
                try
                {
                    plantaLogica.EliminarPlanta(plantaSeleccionada.PlantaId); // Llamar al método de lógica para eliminar la planta seleccionada por su ID
                    CargarPlantas(); // Recargar la lista de plantas después de eliminar una planta para mostrar la actualización en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la planta: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al eliminar la planta
                }
            }
        }

        // Evento que ejecuta el botón de mostrar la lista de riegos de la planta seleccionada
        private void btnListaRiegos_Click(object sender, EventArgs e)
        {
            if (plantaSeleccionada == null) // Verificar que se haya seleccionado una planta para mostrar su lista de riegos
            {
                MessageBox.Show("Por favor, seleccione una planta primero."); // Mostrar un mensaje de advertencia si no se ha seleccionado ninguna planta.
                return;
            }

            FormRiego formRiegos = new FormRiego(plantaSeleccionada.PlantaId); // Crear una instancia del formulario para mostrar la lista de riegos de la planta seleccionada, pasando el ID de la planta como parámetro

            if (formRiegos.ShowDialog() == DialogResult.OK) // Mostrar el formulario como un diálogo modal y verificar si se hizo clic en el botón OK para cerrar el formulario de riegos
            {
                MessageBox.Show("Riegos agregados correctamente."); // Mostrar un mensaje de éxito después de cerrar el formulario de riegos, indicando que se han actualizado los riegos de la planta seleccionada
            }
        }

        // Evento que ejecuta el botón de mostrar la lista de abonos de la planta seleccionada
        private void btnListaAbonos_Click(object sender, EventArgs e)
        {
            if (plantaSeleccionada == null) // Verificar que se haya seleccionado una planta para mostrar su lista de abonos
            {
                MessageBox.Show("Por favor, seleccione una planta primero."); // Mostrar un mensaje de advertencia si no se ha seleccionado ninguna planta.
                return;
            }

            FormAbono formAbonos = new FormAbono(plantaSeleccionada.PlantaId); // Crear una instancia del formulario para mostrar la lista de abonos de la planta seleccionada, pasando el ID de la planta como parámetro

            if (formAbonos.ShowDialog() == DialogResult.OK) // Mostrar el formulario como un diálogo modal y verificar si se hizo clic en el botón OK para cerrar el formulario de abonos
            {
                MessageBox.Show("Abonos agregados correctamente."); // Mostrar un mensaje de éxito después de cerrar el formulario de abonos, indicando que se han actualizado los abonos de la planta seleccionada
            }

        }
    }
}

