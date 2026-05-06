namespace InventoryManagementProject.Forms.Reports
{
    partial class frmTransactionEntry
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label10 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            cmbTransactionType = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            dtpTransactionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel2 = new Panel();
            txtReferenceNo = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            panel3 = new Panel();
            lblTotalAmount = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            dgvAddedProduct = new DataGridView();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 35);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto Slab Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 4);
            label10.Name = "label10";
            label10.Size = new Size(195, 26);
            label10.TabIndex = 22;
            label10.Text = "Transaction Entry";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(128, 128, 255);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(570, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 35);
            guna2ControlBox1.TabIndex = 2;
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = Color.Transparent;
            cmbTransactionType.CustomizableEdges = customizableEdges3;
            cmbTransactionType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransactionType.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTransactionType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTransactionType.Font = new Font("Segoe UI", 10F);
            cmbTransactionType.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTransactionType.ItemHeight = 30;
            cmbTransactionType.Location = new Point(191, 17);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbTransactionType.Size = new Size(150, 36);
            cmbTransactionType.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab", 14.25F);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 3;
            label1.Text = "Transaction Type:";
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.BorderRadius = 10;
            dtpTransactionDate.Checked = true;
            dtpTransactionDate.CustomizableEdges = customizableEdges5;
            dtpTransactionDate.FillColor = Color.FromArgb(128, 128, 255);
            dtpTransactionDate.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTransactionDate.ForeColor = Color.White;
            dtpTransactionDate.Format = DateTimePickerFormat.Long;
            dtpTransactionDate.Location = new Point(398, 17);
            dtpTransactionDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTransactionDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTransactionDate.Size = new Size(204, 36);
            dtpTransactionDate.TabIndex = 8;
            dtpTransactionDate.Value = new DateTime(2025, 7, 30, 20, 17, 10, 274);
            // 
            // panel2
            // 
            panel2.Controls.Add(txtReferenceNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpTransactionDate);
            panel2.Controls.Add(cmbTransactionType);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 101);
            panel2.TabIndex = 9;
            // 
            // txtReferenceNo
            // 
            txtReferenceNo.CustomizableEdges = customizableEdges7;
            txtReferenceNo.DefaultText = "";
            txtReferenceNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtReferenceNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtReferenceNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtReferenceNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtReferenceNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReferenceNo.Font = new Font("Segoe UI", 9F);
            txtReferenceNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReferenceNo.Location = new Point(154, 63);
            txtReferenceNo.Name = "txtReferenceNo";
            txtReferenceNo.PlaceholderText = "";
            txtReferenceNo.SelectedText = "";
            txtReferenceNo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtReferenceNo.Size = new Size(171, 26);
            txtReferenceNo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab", 14.25F);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(136, 26);
            label2.TabIndex = 9;
            label2.Text = "Reference No:";
            // 
            // btnTransaction
            // 
            btnTransaction.BorderRadius = 10;
            btnTransaction.CustomizableEdges = customizableEdges9;
            btnTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTransaction.FillColor = Color.FromArgb(128, 128, 255);
            btnTransaction.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(422, 10);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnTransaction.Size = new Size(180, 36);
            btnTransaction.TabIndex = 14;
            btnTransaction.Text = "Add Product";
            btnTransaction.Click += btnAddProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Slab", 14.25F);
            label4.Location = new Point(15, 10);
            label4.Name = "label4";
            label4.Size = new Size(62, 26);
            label4.TabIndex = 15;
            label4.Text = "Total:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTransaction);
            panel3.Controls.Add(lblTotalAmount);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 336);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 112);
            panel3.TabIndex = 11;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Roboto Slab", 14.25F);
            lblTotalAmount.Location = new Point(83, 10);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 26);
            lblTotalAmount.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges11;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(128, 128, 255);
            btnSave.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(524, 74);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSave.Size = new Size(78, 26);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // dgvAddedProduct
            // 
            dgvAddedProduct.AllowUserToAddRows = false;
            dgvAddedProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAddedProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAddedProduct.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAddedProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAddedProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAddedProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAddedProduct.Dock = DockStyle.Fill;
            dgvAddedProduct.GridColor = Color.Black;
            dgvAddedProduct.Location = new Point(0, 136);
            dgvAddedProduct.Name = "dgvAddedProduct";
            dgvAddedProduct.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAddedProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Roboto Slab", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAddedProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAddedProduct.Size = new Size(615, 200);
            dgvAddedProduct.TabIndex = 12;
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // frmTransactionEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 448);
            Controls.Add(dgvAddedProduct);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactionEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransactionEntry";
            Load += frmTransactionEntry_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTransactionType;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTransactionDate;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtReferenceNo;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Label label4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Label lblTotalAmount;
        private DataGridView dgvAddedProduct;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
    }
}