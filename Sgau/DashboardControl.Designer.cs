namespace Sgau
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            lblTotalPlantas = new Label();
            lblTotalRiegos = new Label();
            label4 = new Label();
            lblTotalAbonos = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalPlantas);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(87, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 97);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lblTotalAbonos);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(87, 573);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 97);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblTotalRiegos);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(87, 354);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 97);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(57, 33);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "TOTAL PLANTAS";
            // 
            // lblTotalPlantas
            // 
            lblTotalPlantas.AutoSize = true;
            lblTotalPlantas.FlatStyle = FlatStyle.Flat;
            lblTotalPlantas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPlantas.ForeColor = Color.DarkOliveGreen;
            lblTotalPlantas.Location = new Point(610, 33);
            lblTotalPlantas.Name = "lblTotalPlantas";
            lblTotalPlantas.Size = new Size(0, 25);
            lblTotalPlantas.TabIndex = 1;
            // 
            // lblTotalRiegos
            // 
            lblTotalRiegos.AutoSize = true;
            lblTotalRiegos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRiegos.ForeColor = Color.DarkOliveGreen;
            lblTotalRiegos.Location = new Point(610, 43);
            lblTotalRiegos.Name = "lblTotalRiegos";
            lblTotalRiegos.Size = new Size(0, 25);
            lblTotalRiegos.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(57, 43);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 2;
            label4.Text = "TOTAL RIEGOS";
            // 
            // lblTotalAbonos
            // 
            lblTotalAbonos.AutoSize = true;
            lblTotalAbonos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAbonos.ForeColor = Color.DarkOliveGreen;
            lblTotalAbonos.Location = new Point(610, 40);
            lblTotalAbonos.Name = "lblTotalAbonos";
            lblTotalAbonos.Size = new Size(0, 25);
            lblTotalAbonos.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(57, 40);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 4;
            label6.Text = "TOTAL ABONOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(351, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 91);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(351, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 91);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(351, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(159, 91);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "DashboardControl";
            Size = new Size(982, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTotalPlantas;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label lblTotalRiegos;
        private Label label4;
        private Label lblTotalAbonos;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
