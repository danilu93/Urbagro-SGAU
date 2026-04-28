namespace Sgau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelContenedor = new Panel();
            panelRegister = new Panel();
            cmbRol = new ComboBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtContrasenaRegistrar = new TextBox();
            label6 = new Label();
            btnRegistrarPanel = new Button();
            txtUsuarioRegistrar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panelDelete = new Panel();
            btnEliminarPanel = new Button();
            txtEliminarUsuario = new TextBox();
            label10 = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panelLogin = new Panel();
            btnLoginPanel = new Button();
            txtContrasenaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBotones = new Panel();
            btnDeleteView = new Button();
            btnRegistrarView = new Button();
            btnLoginView = new Button();
            pictureBox2 = new PictureBox();
            panelContenedor.SuspendLayout();
            panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FloralWhite;
            panelContenedor.Controls.Add(panelRegister);
            panelContenedor.Controls.Add(panelDelete);
            panelContenedor.Controls.Add(panelLogin);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(830, 775);
            panelContenedor.TabIndex = 0;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(cmbRol);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(txtEmail);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(txtContrasenaRegistrar);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(btnRegistrarPanel);
            panelRegister.Controls.Add(txtUsuarioRegistrar);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(pictureBox3);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Padding = new Padding(20);
            panelRegister.Size = new Size(830, 775);
            panelRegister.TabIndex = 2;
            panelRegister.Visible = false;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(278, 547);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(296, 25);
            cmbRol.TabIndex = 14;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(90, 547);
            label8.Name = "label8";
            label8.Size = new Size(166, 25);
            label8.TabIndex = 13;
            label8.Text = "Rol:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(276, 497);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 25);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(90, 497);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 11;
            label7.Text = "Email:";
            // 
            // txtContrasenaRegistrar
            // 
            txtContrasenaRegistrar.BackColor = SystemColors.Window;
            txtContrasenaRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenaRegistrar.Location = new Point(276, 451);
            txtContrasenaRegistrar.Name = "txtContrasenaRegistrar";
            txtContrasenaRegistrar.Size = new Size(298, 25);
            txtContrasenaRegistrar.TabIndex = 10;
            txtContrasenaRegistrar.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(90, 451);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 9;
            label6.Text = "Contraseña:";
            // 
            // btnRegistrarPanel
            // 
            btnRegistrarPanel.BackColor = Color.IndianRed;
            btnRegistrarPanel.FlatStyle = FlatStyle.Flat;
            btnRegistrarPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarPanel.ForeColor = SystemColors.Window;
            btnRegistrarPanel.Location = new Point(616, 665);
            btnRegistrarPanel.Name = "btnRegistrarPanel";
            btnRegistrarPanel.Size = new Size(177, 54);
            btnRegistrarPanel.TabIndex = 8;
            btnRegistrarPanel.Text = "Registrar";
            btnRegistrarPanel.UseVisualStyleBackColor = false;
            btnRegistrarPanel.Click += btnRegistrarPanel_Click;
            // 
            // txtUsuarioRegistrar
            // 
            txtUsuarioRegistrar.BackColor = SystemColors.Window;
            txtUsuarioRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioRegistrar.Location = new Point(276, 401);
            txtUsuarioRegistrar.Name = "txtUsuarioRegistrar";
            txtUsuarioRegistrar.Size = new Size(298, 25);
            txtUsuarioRegistrar.TabIndex = 6;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 401);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 4;
            label5.Text = "Nombre de Usuario:";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(345, 333);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 3;
            label4.Text = "Registrar Usuario";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(361, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(btnEliminarPanel);
            panelDelete.Controls.Add(txtEliminarUsuario);
            panelDelete.Controls.Add(label10);
            panelDelete.Controls.Add(label9);
            panelDelete.Controls.Add(pictureBox4);
            panelDelete.Dock = DockStyle.Fill;
            panelDelete.Location = new Point(0, 0);
            panelDelete.Name = "panelDelete";
            panelDelete.Padding = new Padding(20);
            panelDelete.Size = new Size(830, 775);
            panelDelete.TabIndex = 3;
            panelDelete.Visible = false;
            // 
            // btnEliminarPanel
            // 
            btnEliminarPanel.BackColor = Color.IndianRed;
            btnEliminarPanel.FlatStyle = FlatStyle.Flat;
            btnEliminarPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPanel.ForeColor = SystemColors.Window;
            btnEliminarPanel.Location = new Point(616, 665);
            btnEliminarPanel.Name = "btnEliminarPanel";
            btnEliminarPanel.Size = new Size(177, 54);
            btnEliminarPanel.TabIndex = 9;
            btnEliminarPanel.Text = "Eliminar Usuario";
            btnEliminarPanel.UseVisualStyleBackColor = false;
            btnEliminarPanel.Click += btnEliminarPanel_Click;
            // 
            // txtEliminarUsuario
            // 
            txtEliminarUsuario.BackColor = SystemColors.Window;
            txtEliminarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEliminarUsuario.Location = new Point(90, 459);
            txtEliminarUsuario.Name = "txtEliminarUsuario";
            txtEliminarUsuario.Size = new Size(298, 25);
            txtEliminarUsuario.TabIndex = 7;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(80, 414);
            label10.Name = "label10";
            label10.Size = new Size(166, 25);
            label10.TabIndex = 5;
            label10.Text = "Nombre de Usuario:";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(361, 306);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 4;
            label9.Text = "Eliminar Usuario";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(361, 221);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(104, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnLoginPanel);
            panelLogin.Controls.Add(txtContrasenaLogin);
            panelLogin.Controls.Add(txtUsuarioLogin);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(20);
            panelLogin.Size = new Size(830, 775);
            panelLogin.TabIndex = 1;
            // 
            // btnLoginPanel
            // 
            btnLoginPanel.BackColor = Color.IndianRed;
            btnLoginPanel.FlatStyle = FlatStyle.Flat;
            btnLoginPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginPanel.ForeColor = SystemColors.Window;
            btnLoginPanel.Location = new Point(616, 665);
            btnLoginPanel.Name = "btnLoginPanel";
            btnLoginPanel.Size = new Size(177, 54);
            btnLoginPanel.TabIndex = 7;
            btnLoginPanel.Text = "Ingresar";
            btnLoginPanel.UseVisualStyleBackColor = false;
            btnLoginPanel.Click += btnLoginPanel_Click;
            // 
            // txtContrasenaLogin
            // 
            txtContrasenaLogin.BackColor = SystemColors.Window;
            txtContrasenaLogin.Location = new Point(196, 559);
            txtContrasenaLogin.Name = "txtContrasenaLogin";
            txtContrasenaLogin.Size = new Size(298, 23);
            txtContrasenaLogin.TabIndex = 6;
            txtContrasenaLogin.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = SystemColors.Window;
            txtUsuarioLogin.Location = new Point(196, 454);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(298, 23);
            txtUsuarioLogin.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 522);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 426);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 333);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 2;
            label1.Text = "Inicio de Sesión";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FloralWhite;
            panelBotones.Controls.Add(btnDeleteView);
            panelBotones.Controls.Add(btnRegistrarView);
            panelBotones.Controls.Add(btnLoginView);
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Location = new Point(0, 136);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(830, 60);
            panelBotones.TabIndex = 0;
            // 
            // btnDeleteView
            // 
            btnDeleteView.BackColor = Color.IndianRed;
            btnDeleteView.FlatAppearance.BorderSize = 0;
            btnDeleteView.FlatStyle = FlatStyle.Flat;
            btnDeleteView.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteView.ForeColor = Color.White;
            btnDeleteView.Location = new Point(619, 13);
            btnDeleteView.Name = "btnDeleteView";
            btnDeleteView.Size = new Size(172, 34);
            btnDeleteView.TabIndex = 2;
            btnDeleteView.Text = "Eliminar Usuario";
            btnDeleteView.UseVisualStyleBackColor = false;
            btnDeleteView.Click += btnDeleteView_Click;
            // 
            // btnRegistrarView
            // 
            btnRegistrarView.BackColor = Color.IndianRed;
            btnRegistrarView.FlatAppearance.BorderSize = 0;
            btnRegistrarView.FlatStyle = FlatStyle.Flat;
            btnRegistrarView.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarView.ForeColor = Color.Transparent;
            btnRegistrarView.Location = new Point(33, 13);
            btnRegistrarView.Name = "btnRegistrarView";
            btnRegistrarView.Size = new Size(172, 34);
            btnRegistrarView.TabIndex = 1;
            btnRegistrarView.Text = "Registrar";
            btnRegistrarView.UseVisualStyleBackColor = false;
            btnRegistrarView.Click += btnRegistrarView_Click;
            // 
            // btnLoginView
            // 
            btnLoginView.BackColor = Color.IndianRed;
            btnLoginView.FlatAppearance.BorderSize = 0;
            btnLoginView.FlatStyle = FlatStyle.Flat;
            btnLoginView.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginView.ForeColor = Color.White;
            btnLoginView.Location = new Point(326, 13);
            btnLoginView.Name = "btnLoginView";
            btnLoginView.Size = new Size(172, 34);
            btnLoginView.TabIndex = 0;
            btnLoginView.Text = "Iniciar Sesión";
            btnLoginView.UseVisualStyleBackColor = false;
            btnLoginView.Click += btnLoginView_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(830, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(830, 775);
            Controls.Add(panelBotones);
            Controls.Add(pictureBox2);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            Load += Form1_Load;
            panelContenedor.ResumeLayout(false);
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBotones;
        private Panel panelLogin;
        private Panel panelRegister;
        private Button btnDeleteView;
        private Button btnRegistrarView;
        private Button btnLoginView;
        private Panel panelDelete;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtContrasenaLogin;
        private TextBox txtUsuarioLogin;
        private Button btnLoginPanel;
        private Button btnRegistrarPanel;
        private TextBox txtUsuarioRegistrar;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtContrasenaRegistrar;
        private Label label6;
        private ComboBox cmbRol;
        private Button btnEliminarPanel;
        private TextBox txtEliminarUsuario;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox4;
    }
}
