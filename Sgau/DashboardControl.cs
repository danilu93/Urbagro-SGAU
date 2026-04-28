using Logica;
using Modelo.Modelos;

namespace Sgau
{

    // Clase que representa el control del dashboard en la aplicación
    public partial class DashboardControl : UserControl
    {
        private PlantaLogica plantaLogica = new(); // Instancia de la clase PlantaLogica para acceder a los métodos relacionados con las plantas
        private IrrigacionLogica irrigacionLogica = new(); // Instancia de la clase IrrigacionLogica para acceder a los métodos relacionados con los riegos
        private AbonoLogica abonoLogica = new(); // Instancia de la clase AbonoLogica para acceder a los métodos relacionados con los abonos

        // Constructor del control del dashboard
        public DashboardControl()
        {
            InitializeComponent();
            CargarDatos(); // Cargar los datos al inicializar el control
        }

        // Método para cargar los datos del dashboard
        private void CargarDatos()
        {
            try
            {
                var plantas = plantaLogica.ListaPlantas(); // Obtener la lista de plantas utilizando el método ListaPlantas() de PlantaLogica
                var riegos = irrigacionLogica.ListaIrrigaciones(); // Obtener la lista de riegos utilizando el método ListaRiegos() de IrrigacionLogica
                var abonos = abonoLogica.ListaAbonos(); // Obtener la lista de abonos utilizando el método ListaAbonos() de AbonoLogica

                lblTotalPlantas.Text = plantas.Count.ToString(); // Mostrar el total de plantas en el label correspondiente
                lblTotalRiegos.Text = riegos.Count.ToString(); // Mostrar el total de riegos en el label correspondiente
                lblTotalAbonos.Text = abonos.Count.ToString(); // Mostrar el total de abonos en el label correspondiente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del dashboard: {ex.Message}"); // Mostrar un mensaje de error si ocurre una excepción al cargar los datos del dashboard

            }
        }
    }
}
