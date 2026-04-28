namespace Sgau
{
    partial class FormRiego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiego));
            numCantidadRiego = new NumericUpDown();
            cmbMetodoRiego = new ComboBox();
            btnGuardarRiego = new Button();
            btnCancelarRiego = new Button();
            dtpFechaRiego = new DateTimePicker();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidadRiego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numCantidadRiego
            // 
            numCantidadRiego.Location = new Point(340, 506);
            numCantidadRiego.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCantidadRiego.Name = "numCantidadRiego";
            numCantidadRiego.Size = new Size(72, 23);
            numCantidadRiego.TabIndex = 53;
            // 
            // cmbMetodoRiego
            // 
            cmbMetodoRiego.FormattingEnabled = true;
            cmbMetodoRiego.Location = new Point(340, 386);
            cmbMetodoRiego.Name = "cmbMetodoRiego";
            cmbMetodoRiego.Size = new Size(298, 23);
            cmbMetodoRiego.TabIndex = 52;
            // 
            // btnGuardarRiego
            // 
            btnGuardarRiego.BackColor = Color.IndianRed;
            btnGuardarRiego.FlatStyle = FlatStyle.Flat;
            btnGuardarRiego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarRiego.ForeColor = SystemColors.Window;
            btnGuardarRiego.Location = new Point(66, 710);
            btnGuardarRiego.Name = "btnGuardarRiego";
            btnGuardarRiego.Size = new Size(177, 54);
            btnGuardarRiego.TabIndex = 51;
            btnGuardarRiego.Text = "Guardar";
            btnGuardarRiego.UseVisualStyleBackColor = false;
            btnGuardarRiego.Click += btnGuardarRiego_Click;
            // 
            // btnCancelarRiego
            // 
            btnCancelarRiego.BackColor = Color.IndianRed;
            btnCancelarRiego.FlatStyle = FlatStyle.Flat;
            btnCancelarRiego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarRiego.ForeColor = SystemColors.Window;
            btnCancelarRiego.Location = new Point(603, 710);
            btnCancelarRiego.Name = "btnCancelarRiego";
            btnCancelarRiego.Size = new Size(177, 54);
            btnCancelarRiego.TabIndex = 50;
            btnCancelarRiego.Text = "Cancelar";
            btnCancelarRiego.UseVisualStyleBackColor = false;
            btnCancelarRiego.Click += btnCancelarRiego_Click;
            // 
            // dtpFechaRiego
            // 
            dtpFechaRiego.Location = new Point(340, 448);
            dtpFechaRiego.Name = "dtpFechaRiego";
            dtpFechaRiego.Size = new Size(200, 23);
            dtpFechaRiego.TabIndex = 49;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 446);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 48;
            label1.Text = "Fecha de Riego:";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 506);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 47;
            label6.Text = "Cantidad de Riego:";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 386);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 46;
            label5.Text = "Método de Riego:";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 321);
            label4.Name = "label4";
            label4.Size = new Size(157, 35);
            label4.TabIndex = 45;
            label4.Text = "Irrigación";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(834, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 514);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 54;
            label2.Text = "ml";
            // 
            // FormRiego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(834, 779);
            Controls.Add(label2);
            Controls.Add(numCantidadRiego);
            Controls.Add(cmbMetodoRiego);
            Controls.Add(btnGuardarRiego);
            Controls.Add(btnCancelarRiego);
            Controls.Add(dtpFechaRiego);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormRiego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Irrigación";
            ((System.ComponentModel.ISupportInitialize)numCantidadRiego).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numCantidadRiego;
        private ComboBox cmbMetodoRiego;
        private Button btnGuardarRiego;
        private Button btnCancelarRiego;
        private DateTimePicker dtpFechaRiego;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
    }
}