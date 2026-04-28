namespace Sgau
{
    partial class FormAbono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbono));
            btnGuardarAbono = new Button();
            btnCancelarAbono = new Button();
            dtpFechaAbono = new DateTimePicker();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            cmbTipoAbono = new ComboBox();
            numCantidadAbono = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadAbono).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarAbono
            // 
            btnGuardarAbono.BackColor = Color.IndianRed;
            btnGuardarAbono.FlatStyle = FlatStyle.Flat;
            btnGuardarAbono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarAbono.ForeColor = SystemColors.Window;
            btnGuardarAbono.Location = new Point(66, 696);
            btnGuardarAbono.Name = "btnGuardarAbono";
            btnGuardarAbono.Size = new Size(177, 54);
            btnGuardarAbono.TabIndex = 40;
            btnGuardarAbono.Text = "Guardar";
            btnGuardarAbono.UseVisualStyleBackColor = false;
            btnGuardarAbono.Click += btnGuardarAbono_Click;
            // 
            // btnCancelarAbono
            // 
            btnCancelarAbono.BackColor = Color.IndianRed;
            btnCancelarAbono.FlatStyle = FlatStyle.Flat;
            btnCancelarAbono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarAbono.ForeColor = SystemColors.Window;
            btnCancelarAbono.Location = new Point(603, 696);
            btnCancelarAbono.Name = "btnCancelarAbono";
            btnCancelarAbono.Size = new Size(177, 54);
            btnCancelarAbono.TabIndex = 39;
            btnCancelarAbono.Text = "Cancelar";
            btnCancelarAbono.UseVisualStyleBackColor = false;
            btnCancelarAbono.Click += btnCancelarAbono_Click;
            // 
            // dtpFechaAbono
            // 
            dtpFechaAbono.Location = new Point(340, 434);
            dtpFechaAbono.Name = "dtpFechaAbono";
            dtpFechaAbono.Size = new Size(200, 23);
            dtpFechaAbono.TabIndex = 38;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 432);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 37;
            label1.Text = "Fecha de Abono:";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 492);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 35;
            label6.Text = "Cantidad de Abono:";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 372);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 33;
            label5.Text = "Tipo de Abono:";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 307);
            label4.Name = "label4";
            label4.Size = new Size(157, 35);
            label4.TabIndex = 32;
            label4.Text = "Abono";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
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
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // cmbTipoAbono
            // 
            cmbTipoAbono.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAbono.FormattingEnabled = true;
            cmbTipoAbono.Location = new Point(340, 372);
            cmbTipoAbono.Name = "cmbTipoAbono";
            cmbTipoAbono.Size = new Size(298, 23);
            cmbTipoAbono.TabIndex = 41;
            // 
            // numCantidadAbono
            // 
            numCantidadAbono.DecimalPlaces = 2;
            numCantidadAbono.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numCantidadAbono.Location = new Point(340, 492);
            numCantidadAbono.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidadAbono.Name = "numCantidadAbono";
            numCantidadAbono.Size = new Size(72, 23);
            numCantidadAbono.TabIndex = 42;
            numCantidadAbono.KeyPress += numCantidadRiego_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 500);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 43;
            label2.Text = "gr / ml";
            // 
            // FormAbono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(834, 779);
            Controls.Add(label2);
            Controls.Add(numCantidadAbono);
            Controls.Add(cmbTipoAbono);
            Controls.Add(btnGuardarAbono);
            Controls.Add(btnCancelarAbono);
            Controls.Add(dtpFechaAbono);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormAbono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abono";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadAbono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarAbono;
        private Button btnCancelarAbono;
        private DateTimePicker dtpFechaAbono;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ComboBox cmbTipoAbono;
        private NumericUpDown numCantidadAbono;
        private Label label2;
    }
}