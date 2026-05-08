using Modelo.Modelos;
using Logica;
using Modelo.Enums;

namespace Sgau
{
    // Formulario principal de la aplicación que maneja el inicio de sesión, registro y eliminación de usuarios
    public partial class Form1 : Form
    {
        // Instancia de la lógica de usuario para manejar las operaciones relacionadas con los usuarios
        private UsuarioLogica usuarioLogica = new();
        public Form1()
        {
            InitializeComponent();

            this.Opacity = 0.98; // Establecer la opacidad del formulario al 98%\


            // Aplicar efectos de hover a los botones en cada panel
            EfectoHover(panelLogin); 
            EfectoHover(panelRegister);
            EfectoHover(panelDelete);


        }

        // Evento que se ejecuta al cargar el formulario, muestra el panel de login y llena el ComboBox de roles
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPanel(panelLogin, btnLoginPanel); // Mostrar el panel de login al cargar el formulario
            cmbRol.DataSource = Enum.GetValues(typeof(Rol)); // Llenar el ComboBox con los valores del enum Rol
        }

        // Eventos de clic para los botones de vista que muestran el panel correspondiente
        private void btnLoginView_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelLogin, btnLoginPanel); // Mostrar el panel de login al hacer clic en el botón de login
        }

        // Eventos de clic para los botones de vista que muestran el panel correspondiente
        private void btnRegistrarView_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelRegister, btnRegistrarPanel); // Mostrar el panel de registro al hacer clic en el botón de registro
        }

        // Eventos de clic para los botones de vista que muestran el panel correspondiente
        private void btnDeleteView_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelDelete, btnEliminarPanel); // Mostrar el panel de eliminación al hacer clic en el botón de eliminación
        }

        // Método para mostrar un panel específico y establecer el botón predeterminado para ese panel
        private void MostrarPanel(Panel panel, Button btnDefault)
        {
            panelLogin.Visible = false; // Ocultar el panel de login
            panelRegister.Visible = false; // Ocultar el panel de registro
            panelDelete.Visible = false; // Ocultar el panel de eliminación

            panel.Visible = true; // Mostrar el panel seleccionado
            this.AcceptButton = btnDefault;

        }

        // Evento del botón de login que maneja el proceso de inicio de sesión
        private void btnLoginPanel_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelLogin, btnLoginPanel); // Asegurarse de que el panel de login esté visible y el botón de login sea el predeterminado

            try
            {
                // Intentar iniciar sesión con el usuario y contraseña proporcionados
                var usuario = usuarioLogica.Login(
                    txtUsuarioLogin.Text,
                    txtContrasenaLogin.Text);

                if (usuario != null) // Si el inicio de sesión es exitoso, guardar el usuario en sesión abierta y mostrar el formulario principal
                {
                    SesionAbierta.UsuarioIniciado = usuario; // Guardar el usuario en sesión abierta

                    // Mostrar el formulario principal y ocultar el formulario de inicio de sesión
                    this.Hide();
                    using (MainForm mainForm = new MainForm()) // Crear una instancia del formulario principal
                    {
                        mainForm.ShowDialog(); // Mostrar el formulario principal como un diálogo modal
                    }
                    this.Show(); // Volver a mostrar el formulario de inicio de sesión después de cerrar el formulario principal


                    LimpiarControles(panelLogin); // Limpiar los controles del panel de login después de cerrar el formulario principal
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar un mensaje de error si el inicio de sesión falla
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar un mensaje de error si ocurre una excepción durante el proceso de inicio de sesión
            }

        }

        // Evento del botón de registro que maneja el proceso de registro de un nuevo usuario
        private void btnRegistrarPanel_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelRegister, btnRegistrarPanel); // Asegurarse de que el panel de registro esté visible y el botón de registro sea el predeterminado

            try
            {
                // Crear un nuevo usuario con los datos proporcionados en el formulario de registro
                var nuevoUsuario = new Usuario
                {
                    // UserId se asignará automáticamente en la lógica de usuario, por lo que no se establece aquí
                    NombreUsuario = txtUsuarioRegistrar.Text, // Establecer el nombre de usuario con el valor del TextBox correspondiente
                    Contrasena = txtContrasenaRegistrar.Text, // Establecer la contraseña con el valor del TextBox correspondiente
                    Email = txtEmail.Text, // Establecer el correo electrónico con el valor del TextBox correspondiente
                    Rol = (Rol)cmbRol.SelectedItem, // Establecer el rol con el valor seleccionado en el ComboBox de roles
                    Activo = true // Establecer el estado del usuario como activo
                };
                usuarioLogica.RegistrarUsuario(nuevoUsuario); // Llamar al método de la lógica de usuario para registrar el nuevo usuario
                MessageBox.Show($"Usuario '{nuevoUsuario.NombreUsuario}' registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar un mensaje de éxito si el registro es exitoso

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar un mensaje de error si ocurre una excepción durante el proceso de registro
            }
            LimpiarControles(panelRegister); // Limpiar los controles del panel de registro después de intentar registrar el usuario
        }

        // Evento del botón de eliminación que maneja el proceso de eliminación de un usuario existente
        private void btnEliminarPanel_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelDelete, btnEliminarPanel); // Asegurarse de que el panel de eliminación esté visible y el botón de eliminación sea el predeterminado

            try
            {
                // Llamar al método de la lógica de usuario para eliminar el usuario con el nombre de usuario proporcionado
                usuarioLogica.EliminarUsuario(txtEliminarUsuario.Text);

                MessageBox.Show($"Usuario '{txtEliminarUsuario.Text}' eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarControles(panelDelete); // Limpiar los controles del panel de eliminación después de intentar eliminar el usuario
        }

        // Método recursivo para limpiar los controles de un panel específico
        private void LimpiarControles(Control parent)
        {
            // Recorrer todos los controles hijos del control padre
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox) // Si el control es un TextBox, establecer su texto a vacío
                    c.Text = ""; 
                else if (c.HasChildren) // Si el control tiene hijos, llamar recursivamente al método para limpiar sus controles
                    LimpiarControles(c);
            }
        }

        // Método para aplicar efectos de hover a los botones dentro de un panel específico, cambiando el color de fondo en diferentes eventos del mouse
        private void EfectoHover(Panel panel)
        {
            foreach (Control c in panel.Controls) // Recorrer todos los controles dentro del panel
            {

                if (c is Button btn) // Si el control es un botón, aplicar los efectos de hover
                {

                    btn.FlatStyle = FlatStyle.Flat; // Establecer el estilo del botón a plano para mejorar la apariencia de los efectos de hover

                    btn.MouseEnter += (s, e) => // Cambiar el color de fondo del botón a un tono más claro cuando el mouse entra en el área del botón
                    {
                        btn.BackColor = Color.DarkSeaGreen; // Cambiar el color de fondo del botón a un tono más claro cuando el mouse entra en el área del botón
                    };
                    btn.MouseLeave += (s, e) => // Restaurar el color de fondo del botón cuando el mouse sale del área del botón
                    {
                        btn.BackColor = Color.IndianRed; // Restaurar el color de fondo del botón a su color original cuando el mouse sale del área del botón
                    };
                    btn.MouseDown += (s, e) => // Cambiar el color de fondo del botón a un tono más oscuro cuando se hace clic en el botón
                    {
                        btn.BackColor = Color.SeaGreen; // Cambiar el color de fondo del botón a un tono más oscuro cuando se hace clic en el botón
                    };
                    btn.MouseUp += (s, e) => // Restaurar el color de fondo del botón a un tono más claro cuando se suelta el clic en el botón
                    {
                        btn.BackColor = Color.DarkSeaGreen; // Restaurar el color de fondo del botón a un tono más claro cuando se suelta el clic en el botón
                    };
                }
            }
        }

    }

}
