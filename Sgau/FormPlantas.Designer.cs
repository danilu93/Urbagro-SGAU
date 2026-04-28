namespace Sgau
{
    partial class FormPlantas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlantas));
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            cmbTipoPlanta = new ComboBox();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label7 = new Label();
            txtNombreCientifico = new TextBox();
            label6 = new Label();
            txtNombrePlanta = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtMetodoSiembra = new TextBox();
            label2 = new Label();
            dtpFechaSiembra = new DateTimePicker();
            btnCancelarPlanta = new Button();
            btnGuardarPlanta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(834, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 278);
            label4.Name = "label4";
            label4.Size = new Size(157, 35);
            label4.TabIndex = 6;
            label4.Text = "Planta";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // cmbTipoPlanta
            // 
            cmbTipoPlanta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPlanta.FlatStyle = FlatStyle.Flat;
            cmbTipoPlanta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPlanta.FormattingEnabled = true;
            cmbTipoPlanta.Location = new Point(342, 439);
            cmbTipoPlanta.Name = "cmbTipoPlanta";
            cmbTipoPlanta.Size = new Size(296, 25);
            cmbTipoPlanta.TabIndex = 22;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(154, 489);
            label8.Name = "label8";
            label8.Size = new Size(166, 25);
            label8.TabIndex = 21;
            label8.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(342, 489);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(298, 23);
            txtDescripcion.TabIndex = 20;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(154, 439);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 19;
            label7.Text = "Tipo de Planta:";
            // 
            // txtNombreCientifico
            // 
            txtNombreCientifico.BackColor = SystemColors.Window;
            txtNombreCientifico.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCientifico.Location = new Point(340, 393);
            txtNombreCientifico.Name = "txtNombreCientifico";
            txtNombreCientifico.Size = new Size(298, 25);
            txtNombreCientifico.TabIndex = 18;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 393);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 17;
            label6.Text = "Nombre Cientifico:";
            // 
            // txtNombrePlanta
            // 
            txtNombrePlanta.BackColor = SystemColors.Window;
            txtNombrePlanta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePlanta.Location = new Point(340, 343);
            txtNombrePlanta.Name = "txtNombrePlanta";
            txtNombrePlanta.Size = new Size(298, 25);
            txtNombrePlanta.TabIndex = 16;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 343);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 15;
            label5.Text = "Nombre de la Planta:";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 584);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 25;
            label1.Text = "Fecha de Siembra:";
            // 
            // txtMetodoSiembra
            // 
            txtMetodoSiembra.BackColor = SystemColors.Window;
            txtMetodoSiembra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMetodoSiembra.Location = new Point(342, 538);
            txtMetodoSiembra.Name = "txtMetodoSiembra";
            txtMetodoSiembra.Size = new Size(298, 25);
            txtMetodoSiembra.TabIndex = 24;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 538);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 23;
            label2.Text = "Método de Siembra:";
            // 
            // dtpFechaSiembra
            // 
            dtpFechaSiembra.Location = new Point(342, 584);
            dtpFechaSiembra.Name = "dtpFechaSiembra";
            dtpFechaSiembra.Size = new Size(200, 23);
            dtpFechaSiembra.TabIndex = 27;
            // 
            // btnCancelarPlanta
            // 
            btnCancelarPlanta.BackColor = Color.IndianRed;
            btnCancelarPlanta.FlatStyle = FlatStyle.Flat;
            btnCancelarPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarPlanta.ForeColor = SystemColors.Window;
            btnCancelarPlanta.Location = new Point(603, 667);
            btnCancelarPlanta.Name = "btnCancelarPlanta";
            btnCancelarPlanta.Size = new Size(177, 54);
            btnCancelarPlanta.TabIndex = 28;
            btnCancelarPlanta.Text = "Cancelar";
            btnCancelarPlanta.UseVisualStyleBackColor = false;
            btnCancelarPlanta.Click += btnCancelarPlanta_Click;
            // 
            // btnGuardarPlanta
            // 
            btnGuardarPlanta.BackColor = Color.IndianRed;
            btnGuardarPlanta.FlatStyle = FlatStyle.Flat;
            btnGuardarPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarPlanta.ForeColor = SystemColors.Window;
            btnGuardarPlanta.Location = new Point(66, 667);
            btnGuardarPlanta.Name = "btnGuardarPlanta";
            btnGuardarPlanta.Size = new Size(177, 54);
            btnGuardarPlanta.TabIndex = 29;
            btnGuardarPlanta.Text = "Guardar";
            btnGuardarPlanta.UseVisualStyleBackColor = false;
            btnGuardarPlanta.Click += btnGuardarPlanta_Click;
            // 
            // FormPlantas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(834, 779);
            Controls.Add(btnGuardarPlanta);
            Controls.Add(btnCancelarPlanta);
            Controls.Add(dtpFechaSiembra);
            Controls.Add(label1);
            Controls.Add(txtMetodoSiembra);
            Controls.Add(label2);
            Controls.Add(cmbTipoPlanta);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(txtNombreCientifico);
            Controls.Add(label6);
            Controls.Add(txtNombrePlanta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormPlantas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plantas";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox3;
        private ComboBox cmbTipoPlanta;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label7;
        private TextBox txtNombreCientifico;
        private Label label6;
        private TextBox txtNombrePlanta;
        private Label label5;
        private Label label1;
        private TextBox txtMetodoSiembra;
        private Label label2;
        private DateTimePicker dtpFechaSiembra;
        private Button btnCancelarPlanta;
        private Button btnGuardarPlanta;
    }
}