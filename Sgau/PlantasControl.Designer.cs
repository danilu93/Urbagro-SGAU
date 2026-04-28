namespace Sgau
{
    partial class PlantasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantasControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnListaAbonos = new Button();
            label2 = new Label();
            btnEditarPlanta = new Button();
            btnAgregarPlanta = new Button();
            btnListaRiegos = new Button();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnEliminarPlanta = new Button();
            cmbTipoPlanta = new ComboBox();
            panelTop = new Panel();
            txtTipoPlanta = new TextBox();
            btnTipoPlanta = new Button();
            dgvPlantas = new DataGridView();
            panelMenu.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlantas).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkOliveGreen;
            panelMenu.Controls.Add(btnListaAbonos);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(btnEditarPlanta);
            panelMenu.Controls.Add(btnAgregarPlanta);
            panelMenu.Controls.Add(btnListaRiegos);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(label7);
            panelMenu.Controls.Add(label6);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(btnEliminarPlanta);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(889, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(93, 861);
            panelMenu.TabIndex = 22;
            // 
            // btnListaAbonos
            // 
            btnListaAbonos.BackColor = Color.Transparent;
            btnListaAbonos.BackgroundImage = (Image)resources.GetObject("btnListaAbonos.BackgroundImage");
            btnListaAbonos.BackgroundImageLayout = ImageLayout.Stretch;
            btnListaAbonos.FlatAppearance.BorderSize = 0;
            btnListaAbonos.FlatStyle = FlatStyle.Flat;
            btnListaAbonos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaAbonos.ForeColor = Color.Transparent;
            btnListaAbonos.Location = new Point(3, 728);
            btnListaAbonos.Name = "btnListaAbonos";
            btnListaAbonos.Size = new Size(82, 81);
            btnListaAbonos.TabIndex = 25;
            btnListaAbonos.UseVisualStyleBackColor = false;
            btnListaAbonos.Click += btnListaAbonos_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(6, 812);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 24;
            label2.Text = "Abonos";
            // 
            // btnEditarPlanta
            // 
            btnEditarPlanta.BackColor = Color.Transparent;
            btnEditarPlanta.BackgroundImage = (Image)resources.GetObject("btnEditarPlanta.BackgroundImage");
            btnEditarPlanta.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarPlanta.FlatAppearance.BorderSize = 0;
            btnEditarPlanta.FlatStyle = FlatStyle.Flat;
            btnEditarPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPlanta.ForeColor = Color.Transparent;
            btnEditarPlanta.Location = new Point(6, 259);
            btnEditarPlanta.Name = "btnEditarPlanta";
            btnEditarPlanta.Size = new Size(82, 81);
            btnEditarPlanta.TabIndex = 12;
            btnEditarPlanta.UseVisualStyleBackColor = false;
            btnEditarPlanta.Click += btnEditarPlanta_Click;
            // 
            // btnAgregarPlanta
            // 
            btnAgregarPlanta.BackColor = Color.Transparent;
            btnAgregarPlanta.BackgroundImage = (Image)resources.GetObject("btnAgregarPlanta.BackgroundImage");
            btnAgregarPlanta.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarPlanta.FlatAppearance.BorderSize = 0;
            btnAgregarPlanta.FlatStyle = FlatStyle.Flat;
            btnAgregarPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPlanta.ForeColor = Color.Transparent;
            btnAgregarPlanta.Location = new Point(6, 105);
            btnAgregarPlanta.Name = "btnAgregarPlanta";
            btnAgregarPlanta.Size = new Size(82, 81);
            btnAgregarPlanta.TabIndex = 13;
            btnAgregarPlanta.UseVisualStyleBackColor = false;
            btnAgregarPlanta.Click += btnAgregarPlanta_Click;
            // 
            // btnListaRiegos
            // 
            btnListaRiegos.BackColor = Color.Transparent;
            btnListaRiegos.BackgroundImage = (Image)resources.GetObject("btnListaRiegos.BackgroundImage");
            btnListaRiegos.BackgroundImageLayout = ImageLayout.Stretch;
            btnListaRiegos.FlatAppearance.BorderSize = 0;
            btnListaRiegos.FlatStyle = FlatStyle.Flat;
            btnListaRiegos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaRiegos.ForeColor = Color.Transparent;
            btnListaRiegos.Location = new Point(6, 576);
            btnListaRiegos.Name = "btnListaRiegos";
            btnListaRiegos.Size = new Size(82, 81);
            btnListaRiegos.TabIndex = 17;
            btnListaRiegos.UseVisualStyleBackColor = false;
            btnListaRiegos.Click += btnListaRiegos_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(11, 660);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 16;
            label3.Text = "Riegos";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FloralWhite;
            label7.Location = new Point(4, 504);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 15;
            label7.Text = "Eliminar";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FloralWhite;
            label6.Location = new Point(4, 189);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 14;
            label6.Text = "Agregar";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FloralWhite;
            label5.Location = new Point(11, 343);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 13;
            label5.Text = "Editar";
            // 
            // btnEliminarPlanta
            // 
            btnEliminarPlanta.BackColor = Color.Transparent;
            btnEliminarPlanta.BackgroundImage = (Image)resources.GetObject("btnEliminarPlanta.BackgroundImage");
            btnEliminarPlanta.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarPlanta.FlatAppearance.BorderSize = 0;
            btnEliminarPlanta.FlatStyle = FlatStyle.Flat;
            btnEliminarPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPlanta.ForeColor = Color.Transparent;
            btnEliminarPlanta.Location = new Point(3, 420);
            btnEliminarPlanta.Name = "btnEliminarPlanta";
            btnEliminarPlanta.Size = new Size(82, 81);
            btnEliminarPlanta.TabIndex = 11;
            btnEliminarPlanta.UseVisualStyleBackColor = false;
            btnEliminarPlanta.Click += btnEliminarPlanta_Click;
            // 
            // cmbTipoPlanta
            // 
            cmbTipoPlanta.FormattingEnabled = true;
            cmbTipoPlanta.Location = new Point(765, 13);
            cmbTipoPlanta.Name = "cmbTipoPlanta";
            cmbTipoPlanta.Size = new Size(121, 23);
            cmbTipoPlanta.TabIndex = 22;
            cmbTipoPlanta.Text = "Tipo Planta";
            cmbTipoPlanta.SelectedIndexChanged += cmbTipoPlanta_SelectedIndexChanged;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkOliveGreen;
            panelTop.Controls.Add(cmbTipoPlanta);
            panelTop.Controls.Add(txtTipoPlanta);
            panelTop.Controls.Add(btnTipoPlanta);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(889, 43);
            panelTop.TabIndex = 23;
            // 
            // txtTipoPlanta
            // 
            txtTipoPlanta.Location = new Point(602, 13);
            txtTipoPlanta.Name = "txtTipoPlanta";
            txtTipoPlanta.Size = new Size(157, 23);
            txtTipoPlanta.TabIndex = 21;
            txtTipoPlanta.TextChanged += txtTipoPlanta_TextChanged;
            // 
            // btnTipoPlanta
            // 
            btnTipoPlanta.BackColor = Color.Transparent;
            btnTipoPlanta.BackgroundImage = (Image)resources.GetObject("btnTipoPlanta.BackgroundImage");
            btnTipoPlanta.BackgroundImageLayout = ImageLayout.Stretch;
            btnTipoPlanta.FlatAppearance.BorderSize = 0;
            btnTipoPlanta.FlatStyle = FlatStyle.Flat;
            btnTipoPlanta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTipoPlanta.ForeColor = Color.Transparent;
            btnTipoPlanta.Location = new Point(569, 13);
            btnTipoPlanta.Name = "btnTipoPlanta";
            btnTipoPlanta.Size = new Size(27, 26);
            btnTipoPlanta.TabIndex = 20;
            btnTipoPlanta.UseVisualStyleBackColor = false;
            btnTipoPlanta.Click += btnTipoPlanta_Click;
            // 
            // dgvPlantas
            // 
            dgvPlantas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPlantas.BackgroundColor = Color.FloralWhite;
            dgvPlantas.BorderStyle = BorderStyle.None;
            dgvPlantas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPlantas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPlantas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlantas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPlantas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPlantas.EnableHeadersVisualStyles = false;
            dgvPlantas.GridColor = Color.LightGray;
            dgvPlantas.Location = new Point(0, 49);
            dgvPlantas.MultiSelect = false;
            dgvPlantas.Name = "dgvPlantas";
            dgvPlantas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPlantas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPlantas.RowHeadersVisible = false;
            dgvPlantas.RowTemplate.Height = 30;
            dgvPlantas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlantas.Size = new Size(982, 812);
            dgvPlantas.TabIndex = 0;
            // 
            // PlantasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(dgvPlantas);
            Name = "PlantasControl";
            Size = new Size(982, 861);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlantas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnEditarPlanta;
        private Button btnAgregarPlanta;
        private Button btnEliminarPlanta;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panelTop;
        private ComboBox cmbTipoPlanta;
        private TextBox txtTipoPlanta;
        private Button btnTipoPlanta;
        private Button btnListaAbonos;
        private Label label2;
        private Button btnListaRiegos;
        private Label label3;
        private DataGridView dgvPlantas;
    }
}
