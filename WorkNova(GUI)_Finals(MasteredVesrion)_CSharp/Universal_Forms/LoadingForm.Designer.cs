
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.LoadingPanelFilled = new Guna.UI2.WinForms.Guna2Panel();
            this.LoadingPanelSkeleton = new Guna.UI2.WinForms.Guna2Panel();
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LoaderElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingPanelSkeleton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingPanelFilled
            // 
            this.LoadingPanelFilled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingPanelFilled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(62)))), ((int)(((byte)(211)))));
            this.LoadingPanelFilled.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanelFilled.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingPanelFilled.Name = "LoadingPanelFilled";
            this.LoadingPanelFilled.Size = new System.Drawing.Size(0, 24);
            this.LoadingPanelFilled.TabIndex = 0;
            // 
            // LoadingPanelSkeleton
            // 
            this.LoadingPanelSkeleton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingPanelSkeleton.Controls.Add(this.LoadingPanelFilled);
            this.LoadingPanelSkeleton.Location = new System.Drawing.Point(38, 254);
            this.LoadingPanelSkeleton.Name = "LoadingPanelSkeleton";
            this.LoadingPanelSkeleton.Size = new System.Drawing.Size(547, 24);
            this.LoadingPanelSkeleton.TabIndex = 1;
            // 
            // FormElipse
            // 
            this.FormElipse.TargetControl = this;
            // 
            // LoaderElipse
            // 
            this.LoaderElipse.BorderRadius = 10;
            this.LoaderElipse.TargetControl = this.LoadingPanelSkeleton;
            // 
            // LoadTimer
            // 
            this.LoadTimer.Enabled = true;
            this.LoadTimer.Interval = 9;
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkNova_GUI__Finals_MasteredVesrion__CSharp.Properties.Resources.WorkNovaBanner;
            this.pictureBox1.Location = new System.Drawing.Point(95, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(630, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadingPanelSkeleton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.LoadingPanelSkeleton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoadingPanelFilled;
        private Guna.UI2.WinForms.Guna2Panel LoadingPanelSkeleton;
        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2Elipse LoaderElipse;
        private System.Windows.Forms.Timer LoadTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}