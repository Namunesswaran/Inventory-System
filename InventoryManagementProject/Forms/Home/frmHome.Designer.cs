namespace InventoryManagementProject.Forms.Home
{
    partial class frmHome
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
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1 = new Panel();
            label1 = new Label();
            panel7 = new Panel();
            lblSales = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblTransactions = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblProduct = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 80);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 36);
            label1.TabIndex = 5;
            label1.Text = "Welcome";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(lblSales);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.FromArgb(128, 128, 255);
            panel7.Location = new Point(0, 266);
            panel7.Name = "panel7";
            panel7.Size = new Size(1036, 186);
            panel7.TabIndex = 3;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.ForeColor = Color.FromArgb(128, 128, 255);
            lblSales.Location = new Point(28, 74);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(0, 36);
            lblSales.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(291, 36);
            label5.TabIndex = 9;
            label5.Text = "Total Sales Revenue";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(lblTransactions);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Bottom;
            panel6.ForeColor = Color.FromArgb(128, 128, 255);
            panel6.Location = new Point(0, 451);
            panel6.Name = "panel6";
            panel6.Size = new Size(1036, 175);
            panel6.TabIndex = 2;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.ForeColor = Color.FromArgb(128, 128, 255);
            lblTransactions.Location = new Point(31, 74);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(0, 36);
            lblTransactions.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 18);
            label4.Name = "label4";
            label4.Size = new Size(275, 36);
            label4.TabIndex = 8;
            label4.Text = "Total Transactions";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(lblProduct);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(1036, 186);
            panel4.TabIndex = 0;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = Color.FromArgb(128, 128, 255);
            lblProduct.Location = new Point(24, 76);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(0, 36);
            lblProduct.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 19);
            label2.Name = "label2";
            label2.Size = new Size(217, 36);
            label2.TabIndex = 6;
            label2.Text = "Total Products";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(825, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 184);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(825, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 184);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(825, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 173);
            panel5.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._3d_rendering_cartoon_shopping_cart;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.top_view_business_items_with_growth_chart_colored_cones;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(209, 184);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.business_people_shaking_hands_finishing_up_meeting;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(209, 173);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 626);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm form;
        private Panel panel1;
        private Label label1;
        private Panel panel7;
        private Label label5;
        private Panel panel6;
        private Label label4;
        private Panel panel4;
        private Label label2;
        private Label lblSales;
        private Label lblTransactions;
        private Label lblProduct;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}