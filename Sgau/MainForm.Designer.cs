namespace Sgau
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTop = new Panel();
            cmbBuscar = new ComboBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblBienvenida = new Label();
            btnLogOut = new Button();
            panelMenu = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnPlantas = new Button();
            btnDashboard = new Button();
            btnAbono = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRiego = new Button();
            panelContenedor = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkOliveGreen;
            panelTop.Controls.Add(cmbBuscar);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(lblBienvenida);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1904, 107);
            panelTop.TabIndex = 0;
            // 
            // cmbBuscar
            // 
            cmbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(406, 62);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(121, 23);
            cmbBuscar.TabIndex = 22;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(108, 62);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(292, 23);
            txtBuscar.TabIndex = 21;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Transparent;
            btnBuscar.Location = new Point(63, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(27, 26);
            btnBuscar.TabIndex = 20;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(565, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(668, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1687, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(1758, 23);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 15);
            lblBienvenida.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(63, 872);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(41, 41);
            btnLogOut.TabIndex = 2;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkOliveGreen;
            panelMenu.Controls.Add(label9);
            panelMenu.Controls.Add(label8);
            panelMenu.Controls.Add(label7);
            panelMenu.Controls.Add(label6);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(btnPlantas);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(btnAbono);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnRiego);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 107);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(125, 934);
            panelMenu.TabIndex = 1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FloralWhite;
            label9.Location = new Point(28, 360);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 22;
            label9.Text = "Menu";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FloralWhite;
            label8.Location = new Point(7, 32);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 21;
            label8.Text = "Principal";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FloralWhite;
            label7.Location = new Point(22, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 20;
            label7.Text = "Menu ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FloralWhite;
            label6.Location = new Point(38, 718);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 19;
            label6.Text = "Lista";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(28, 565);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 18;
            label5.Text = "Riegos";
            // 
            // btnPlantas
            // 
            btnPlantas.BackColor = Color.Transparent;
            btnPlantas.BackgroundImage = (Image)resources.GetObject("btnPlantas.BackgroundImage");
            btnPlantas.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlantas.FlatAppearance.BorderSize = 0;
            btnPlantas.FlatStyle = FlatStyle.Flat;
            btnPlantas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlantas.ForeColor = Color.Transparent;
            btnPlantas.Location = new Point(22, 276);
            btnPlantas.Name = "btnPlantas";
            btnPlantas.Size = new Size(82, 81);
            btnPlantas.TabIndex = 12;
            btnPlantas.UseVisualStyleBackColor = false;
            btnPlantas.Click += btnPlantas_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Location = new Point(22, 105);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(82, 81);
            btnDashboard.TabIndex = 13;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAbono
            // 
            btnAbono.BackColor = Color.Transparent;
            btnAbono.BackgroundImage = (Image)resources.GetObject("btnAbono.BackgroundImage");
            btnAbono.BackgroundImageLayout = ImageLayout.Stretch;
            btnAbono.FlatAppearance.BorderSize = 0;
            btnAbono.FlatStyle = FlatStyle.Flat;
            btnAbono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbono.ForeColor = Color.Transparent;
            btnAbono.Location = new Point(22, 634);
            btnAbono.Name = "btnAbono";
            btnAbono.Size = new Size(82, 81);
            btnAbono.TabIndex = 17;
            btnAbono.UseVisualStyleBackColor = false;
            btnAbono.Click += btnAbono_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(18, 743);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 16;
            label4.Text = "Abonos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(38, 540);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 15;
            label3.Text = "Lista";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(12, 189);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 14;
            label2.Text = "Dashboard";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(24, 384);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 13;
            label1.Text = "Plantas";
            // 
            // btnRiego
            // 
            btnRiego.BackColor = Color.Transparent;
            btnRiego.BackgroundImage = (Image)resources.GetObject("btnRiego.BackgroundImage");
            btnRiego.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiego.FlatAppearance.BorderSize = 0;
            btnRiego.FlatStyle = FlatStyle.Flat;
            btnRiego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiego.ForeColor = Color.Transparent;
            btnRiego.Location = new Point(22, 456);
            btnRiego.Name = "btnRiego";
            btnRiego.Size = new Size(82, 81);
            btnRiego.TabIndex = 11;
            btnRiego.UseVisualStyleBackColor = false;
            btnRiego.Click += btnRiego_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FloralWhite;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(125, 107);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1779, 934);
            panelContenedor.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Menu Principal";
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelMenu;
        private Panel panelContenedor;
        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private Button btnLogOut;
        private PictureBox pictureBox2;
        private Button btnRiego;
        private Button btnBusqueda;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button btnAbono;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private ComboBox cmbBuscar;
        private Button btnPlantas;
        private Button btnDashboard;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}