namespace InventoryManagementProject.Forms.Reports
{
    partial class frmTransactions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            cmbTrans = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpTrans = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            panel2 = new Panel();
            btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            dgvTransactions = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbTrans);
            panel1.Controls.Add(dtpTrans);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 80);
            panel1.TabIndex = 0;
            // 
            // cmbTrans
            // 
            cmbTrans.BackColor = Color.Transparent;
            cmbTrans.BorderRadius = 10;
            cmbTrans.CustomizableEdges = customizableEdges1;
            cmbTrans.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrans.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTrans.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTrans.Font = new Font("Segoe UI", 10F);
            cmbTrans.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTrans.ItemHeight = 30;
            cmbTrans.Location = new Point(605, 20);
            cmbTrans.Name = "cmbTrans";
            cmbTrans.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbTrans.Size = new Size(179, 36);
            cmbTrans.TabIndex = 8;
            cmbTrans.SelectedIndexChanged += cmbTrans_SelectedIndexChanged;
            // 
            // dtpTrans
            // 
            dtpTrans.BorderRadius = 10;
            dtpTrans.Checked = true;
            dtpTrans.CustomizableEdges = customizableEdges3;
            dtpTrans.FillColor = Color.FromArgb(128, 128, 255);
            dtpTrans.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTrans.ForeColor = Color.White;
            dtpTrans.Format = DateTimePickerFormat.Long;
            dtpTrans.Location = new Point(803, 20);
            dtpTrans.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTrans.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTrans.Name = "dtpTrans";
            dtpTrans.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpTrans.Size = new Size(204, 36);
            dtpTrans.TabIndex = 7;
            dtpTrans.Value = new DateTime(2025, 7, 30, 20, 17, 10, 274);
            dtpTrans.ValueChanged += dtpTrans_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 36);
            label1.TabIndex = 6;
            label1.Text = "Transactions List";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnTransaction);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 52);
            panel2.TabIndex = 2;
            // 
            // btnTransaction
            // 
            btnTransaction.BorderRadius = 10;
            btnTransaction.CustomizableEdges = customizableEdges5;
            btnTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTransaction.FillColor = Color.FromArgb(128, 128, 255);
            btnTransaction.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.White;
            btnTransaction.Location = new Point(32, 8);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnTransaction.Size = new Size(180, 32);
            btnTransaction.TabIndex = 0;
            btnTransaction.Text = "New Transactions";
            btnTransaction.Click += btnTransaction_Click;
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.GridColor = Color.Black;
            dgvTransactions.Location = new Point(0, 80);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new Font("Roboto Slab", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvTransactions.Size = new Size(1029, 494);
            dgvTransactions.TabIndex = 5;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 626);
            Controls.Add(dgvTransactions);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactions";
            Text = "frmTransactions";
            Load += frmTransactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTrans;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrans;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
        private DataGridView dgvTransactions;
    }
}