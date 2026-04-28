using Modelo.Modelos;
using Logica;
using System.Diagnostics;
using Modelo.Enums;


namespace Sgau
{
    // Formulario principal de la aplicación
    public partial class MainForm : Form
    {
        // Constructor del formulario principal
        public MainForm()
        {
            InitializeComponent();

            this.Opacity = 0.98; // Establecer la opacidad del formulario al 98%\

        }

        // Agrega eventos para la carga del formulario
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (SesionAbierta.UsuarioIniciado != null) // Verificar si hay un usuario iniciado en la sesión
            {

                lblBienvenida.Text = $"Bienvenid@, {SesionAbierta.UsuarioIniciado.NombreUsuario}"; // Mostrar el nombre del usuario en la etiqueta de bienvenida
            }
            else
            {
                MessageBox.Show("No hay un usuario iniciado. Por favor, inicie sesión.");


            }

            cmbBuscar.Items.Add("Nombre de planta"); // Agregar opciones al ComboBox de búsqueda
            cmbBuscar.Items.Add("Tipo de planta");
            cmbBuscar.SelectedIndex = 0; // Establecer la primera opción como seleccionada por defecto


        }

        // Agrega eventos para el botón de cerrar sesión
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SesionAbierta.CerrarSesion(); // Cerrar la sesión actual

            this.Close(); // Cerrar el formulario principal para volver a la pantalla de inicio de sesión

        }

        // Método para cargar una vista específica en el panel contenedor
        public void CargarVista(UserControl vista)
        {
            panelContenedor.Controls.Clear(); // Limpiar el panel contenedor
            vista.Dock = DockStyle.Fill; // Establecer la vista para que ocupe todo el espacio del panel
            panelContenedor.Controls.Add(vista); // Agregar la vista al panel contenedor
        }

        private PlantaLogica plantaLogica = new(); // Instancia de la clase PlantaLogica para acceder a los métodos relacionados con las plantas

        // Agrega eventos para el botón de búsqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string TextoBusqueda = txtBuscar.Text.Trim(); // Obtener el texto de búsqueda ingresado por el usuario

                if (string.IsNullOrEmpty(TextoBusqueda))
                {
                    MessageBox.Show("Ingrese algo para buscar"); // Mostrar un mensaje si el campo de búsqueda está vacío
                    return;
                }

                var filtroBusqueda = cmbBuscar.SelectedItem.ToString(); // Obtener la opción seleccionada en el ComboBox

                List<Planta> resultadosBusqueda; // Variable para almacenar los resultados de la búsqueda

                if (filtroBusqueda == "Nombre de planta")
                {
                    resultadosBusqueda = plantaLogica.BuscarPorNombre(TextoBusqueda); // Buscar plantas por nombre
                }
                else if (filtroBusqueda == "Tipo de planta")
                {
                    if (!Enum.TryParse<TipoPlanta>(TextoBusqueda, true, out var tipoPlanta))
                    {
                        MessageBox.Show("Ingrese un tipo de planta válido (Frutal, Ornamental, Helecho, Suculenta, Follaje, Hortaliza)"); // Mostrar un mensaje si el tipo de planta no es válido
                        return;
                    }

                    resultadosBusqueda = plantaLogica.BuscarPorTipo(tipoPlanta); // Buscar plantas por tipo
                }
                else
                {
                    resultadosBusqueda = plantaLogica.ListaPlantas(); // Si no se selecciona un filtro válido, mostrar todas las plantas
                }
                CargarVista(new PlantasControl(resultadosBusqueda)); // Cargar la vista de plantas con los resultados de la búsqueda
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción durante la búsqueda
            }
        }

        // Agrega eventos para el botón de dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CargarVista(new DashboardControl()); // Cargar la vista del dashboard al hacer clic en el botón correspondiente
        }

        // Agrega eventos para el botón de plantas
        private void btnPlantas_Click(object sender, EventArgs e)
        {
            CargarVista(new PlantasControl()); // Cargar la vista de plantas al hacer clic en el botón correspondiente
        }

        // Agrega eventos para el botón de riegos
        private void btnRiego_Click(object sender, EventArgs e)
        {
            CargarVista(new RiegosControl()); // Cargar la vista de todos los riegos al hacer clic en el botón correspondiente

        }

        // Agrega eventos para el botón de abonos
        private void btnAbono_Click(object sender, EventArgs e)
        {
            int plantaId = 0; // Aquí deberías obtener el ID de la planta seleccionada para mostrar los abonos correspondientes
            CargarVista(new AbonosControl()); // Cargar la vista de todos losabonos al hacer clic en el botón correspondiente

        }
    }
}
