namespace Sgau
{
    partial class RiegosControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiegosControl));
            dgvRiegos = new DataGridView();
            panelMenu = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnVerInfo = new Button();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            btnEditarRiego = new Button();
            btnEliminarRiego = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiegos).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRiegos
            // 
            dgvRiegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvRiegos.BackgroundColor = Color.FloralWhite;
            dgvRiegos.BorderStyle = BorderStyle.None;
            dgvRiegos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRiegos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRiegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRiegos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRiegos.Dock = DockStyle.Fill;
            dgvRiegos.EditMode = DataGridViewEditMode.EditOnF2;
            dgvRiegos.EnableHeadersVisualStyles = false;
            dgvRiegos.GridColor = Color.LightGray;
            dgvRiegos.Location = new Point(0, 0);
            dgvRiegos.MultiSelect = false;
            dgvRiegos.Name = "dgvRiegos";
            dgvRiegos.ReadOnly = true;
            dgvRiegos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRiegos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRiegos.RowHeadersVisible = false;
            dgvRiegos.RowTemplate.Height = 30;
            dgvRiegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiegos.Size = new Size(889, 861);
            dgvRiegos.TabIndex = 24;
            dgvRiegos.SelectionChanged += dgvRiegos_SelectionChanged;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkOliveGreen;
            panelMenu.Controls.Add(label6);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnVerInfo);
            panelMenu.Controls.Add(label9);
            panelMenu.Controls.Add(label8);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(btnEditarRiego);
            panelMenu.Controls.Add(btnEliminarRiego);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(889, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(93, 861);
            panelMenu.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FloralWhite;
            label6.Location = new Point(16, 481);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 42;
            label6.Text = "Riego";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(13, 261);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 41;
            label5.Text = "Riego";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(7, 61);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 40;
            label2.Text = "Riego";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 39;
            label3.Text = "Menu ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(11, 694);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 31;
            label1.Text = "Planta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVerInfo
            // 
            btnVerInfo.BackColor = Color.Transparent;
            btnVerInfo.BackgroundImage = (Image)resources.GetObject("btnVerInfo.BackgroundImage");
            btnVerInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerInfo.FlatAppearance.BorderSize = 0;
            btnVerInfo.FlatStyle = FlatStyle.Flat;
            btnVerInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerInfo.ForeColor = Color.Transparent;
            btnVerInfo.Location = new Point(5, 585);
            btnVerInfo.Name = "btnVerInfo";
            btnVerInfo.Size = new Size(82, 81);
            btnVerInfo.TabIndex = 30;
            btnVerInfo.UseVisualStyleBackColor = false;
            btnVerInfo.Click += btnVerInfo_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FloralWhite;
            label9.Location = new Point(13, 236);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 29;
            label9.Text = "Editar";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FloralWhite;
            label8.Location = new Point(6, 456);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 28;
            label8.Text = "Eliminar";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(20, 669);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 27;
            label4.Text = "Info";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEditarRiego
            // 
            btnEditarRiego.BackColor = Color.Transparent;
            btnEditarRiego.BackgroundImage = (Image)resources.GetObject("btnEditarRiego.BackgroundImage");
            btnEditarRiego.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarRiego.FlatAppearance.BorderSize = 0;
            btnEditarRiego.FlatStyle = FlatStyle.Flat;
            btnEditarRiego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarRiego.ForeColor = Color.Transparent;
            btnEditarRiego.Location = new Point(8, 152);
            btnEditarRiego.Name = "btnEditarRiego";
            btnEditarRiego.Size = new Size(82, 81);
            btnEditarRiego.TabIndex = 12;
            btnEditarRiego.UseVisualStyleBackColor = false;
            btnEditarRiego.Click += btnEditarRiego_Click;
            // 
            // btnEliminarRiego
            // 
            btnEliminarRiego.BackColor = Color.Transparent;
            btnEliminarRiego.BackgroundImage = (Image)resources.GetObject("btnEliminarRiego.BackgroundImage");
            btnEliminarRiego.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarRiego.FlatAppearance.BorderSize = 0;
            btnEliminarRiego.FlatStyle = FlatStyle.Flat;
            btnEliminarRiego.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarRiego.ForeColor = Color.Transparent;
            btnEliminarRiego.Location = new Point(3, 372);
            btnEliminarRiego.Name = "btnEliminarRiego";
            btnEliminarRiego.Size = new Size(82, 81);
            btnEliminarRiego.TabIndex = 11;
            btnEliminarRiego.UseVisualStyleBackColor = false;
            btnEliminarRiego.Click += btnEliminarRiego_Click;
            // 
            // RiegosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRiegos);
            Controls.Add(panelMenu);
            Name = "RiegosControl";
            Size = new Size(982, 861);
            ((System.ComponentModel.ISupportInitialize)dgvRiegos).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvRiegos;
        private Panel panelMenu;
        private Button btnEditarRiego;
        private Button btnEliminarRiego;
        private Label label9;
        private Label label8;
        private Label label4;
        private Button btnVerInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
    }
}
