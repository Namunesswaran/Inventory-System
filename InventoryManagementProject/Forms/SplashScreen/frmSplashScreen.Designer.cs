namespace InventoryManagementProject.Forms.SplashScreen
{
    partial class frmSplashScreen
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            label2 = new Label();
            splashTimer = new System.Windows.Forms.Timer(components);
            form = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SwiftStock_removebg_preview;
            pictureBox1.Location = new Point(32, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Slab Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 219);
            label1.Name = "label1";
            label1.Size = new Size(327, 26);
            label1.TabIndex = 5;
            label1.Text = "Inventory Management System";
            // 
            // progressBar
            // 
            progressBar.CustomizableEdges = customizableEdges1;
            progressBar.Dock = DockStyle.Bottom;
            progressBar.FillColor = Color.White;
            progressBar.Location = new Point(0, 325);
            progressBar.Name = "progressBar";
            progressBar.ProgressColor = Color.FromArgb(128, 128, 255);
            progressBar.ProgressColor2 = Color.FromArgb(128, 128, 255);
            progressBar.RightToLeft = RightToLeft.No;
            progressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            progressBar.Size = new Size(600, 25);
            progressBar.TabIndex = 6;
            progressBar.Text = "guna2ProgressBar1";
            progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 305);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 7;
            label2.Text = "version 1.0.0";
            // 
            // splashTimer
            // 
            splashTimer.Enabled = true;
            splashTimer.Interval = 50;
            splashTimer.Tick += splashTimer_Tick;
            // 
            // form
            // 
            form.AnimateWindow = true;
            form.ContainerControl = this;
            form.DockIndicatorTransparencyValue = 0.6D;
            form.DragForm = false;
            form.TransparentWhileDrag = true;
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(600, 350);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashScreen";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Label label2;
        private System.Windows.Forms.Timer splashTimer;
        private Guna.UI2.WinForms.Guna2BorderlessForm form;
    }
}