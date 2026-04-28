namespace Sgau
{
    partial class AbonosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbonosControl));
            dgvAbonos = new DataGridView();
            panelMenu = new Panel();
            label2 = new Label();
            btnVerInfo = new Button();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            btnEditarAbono = new Button();
            btnEliminarAbono = new Button();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAbonos).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAbonos
            // 
            dgvAbonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAbonos.BackgroundColor = Color.FloralWhite;
            dgvAbonos.BorderStyle = BorderStyle.None;
            dgvAbonos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAbonos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAbonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAbonos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAbonos.Dock = DockStyle.Fill;
            dgvAbonos.EnableHeadersVisualStyles = false;
            dgvAbonos.GridColor = Color.LightGray;
            dgvAbonos.Location = new Point(0, 0);
            dgvAbonos.MultiSelect = false;
            dgvAbonos.Name = "dgvAbonos";
            dgvAbonos.ReadOnly = true;
            dgvAbonos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAbonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAbonos.RowHeadersVisible = false;
            dgvAbonos.RowTemplate.Height = 30;
            dgvAbonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbonos.Size = new Size(890, 861);
            dgvAbonos.TabIndex = 26;
            dgvAbonos.SelectionChanged += dgvAbonos_SelectionChanged;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkOliveGreen;
            panelMenu.Controls.Add(label8);
            panelMenu.Controls.Add(label7);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(btnVerInfo);
            panelMenu.Controls.Add(label11);
            panelMenu.Controls.Add(label10);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnEditarAbono);
            panelMenu.Controls.Add(btnEliminarAbono);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(890, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(92, 861);
            panelMenu.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(10, 694);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 34;
            label2.Text = "Planta";
            label2.TextAlign = ContentAlignment.TopCenter;
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
            btnVerInfo.TabIndex = 33;
            btnVerInfo.UseVisualStyleBackColor = false;
            btnVerInfo.Click += btnVerInfo_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FloralWhite;
            label11.Location = new Point(5, 456);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 32;
            label11.Text = "Eliminar";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FloralWhite;
            label10.Location = new Point(12, 236);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 31;
            label10.Text = "Editar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(19, 669);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 30;
            label1.Text = "Info";
            // 
            // btnEditarAbono
            // 
            btnEditarAbono.BackColor = Color.Transparent;
            btnEditarAbono.BackgroundImage = (Image)resources.GetObject("btnEditarAbono.BackgroundImage");
            btnEditarAbono.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarAbono.FlatAppearance.BorderSize = 0;
            btnEditarAbono.FlatStyle = FlatStyle.Flat;
            btnEditarAbono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarAbono.ForeColor = Color.Transparent;
            btnEditarAbono.Location = new Point(8, 152);
            btnEditarAbono.Name = "btnEditarAbono";
            btnEditarAbono.Size = new Size(82, 81);
            btnEditarAbono.TabIndex = 12;
            btnEditarAbono.UseVisualStyleBackColor = false;
            btnEditarAbono.Click += btnEditarAbono_Click;
            // 
            // btnEliminarAbono
            // 
            btnEliminarAbono.BackColor = Color.Transparent;
            btnEliminarAbono.BackgroundImage = (Image)resources.GetObject("btnEliminarAbono.BackgroundImage");
            btnEliminarAbono.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarAbono.FlatAppearance.BorderSize = 0;
            btnEliminarAbono.FlatStyle = FlatStyle.Flat;
            btnEliminarAbono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarAbono.ForeColor = Color.Transparent;
            btnEliminarAbono.Location = new Point(3, 372);
            btnEliminarAbono.Name = "btnEliminarAbono";
            btnEliminarAbono.Size = new Size(82, 81);
            btnEliminarAbono.TabIndex = 11;
            btnEliminarAbono.UseVisualStyleBackColor = false;
            btnEliminarAbono.Click += btnEliminarAbono_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FloralWhite;
            label8.Location = new Point(3, 60);
            label8.Name = "label8";
            label8.Size = new Size(91, 32);
            label8.TabIndex = 36;
            label8.Text = "Abono";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FloralWhite;
            label7.Location = new Point(7, 28);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 35;
            label7.Text = "Menu ";
            // 
            // AbonosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAbonos);
            Controls.Add(panelMenu);
            Name = "AbonosControl";
            Size = new Size(982, 861);
            ((System.ComponentModel.ISupportInitialize)dgvAbonos).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAbonos;
        private Panel panelMenu;
        private Button btnEditarAbono;
        private Button btnEliminarAbono;
        private Label label1;
        private Label label10;
        private Label label11;
        private Button btnVerInfo;
        private Label label2;
        private Label label8;
        private Label label7;
    }
}
