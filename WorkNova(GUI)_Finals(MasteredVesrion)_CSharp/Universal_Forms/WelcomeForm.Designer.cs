
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    partial class WelcomeForm
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
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopMenuBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxCrossMark = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SignUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.ContactUsButton = new Guna.UI2.WinForms.Guna2Button();
            this.SignInButton = new Guna.UI2.WinForms.Guna2Button();
            this.AboutUsButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TopMenuBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.BorderRadius = 7;
            this.FormElipse.TargetControl = this;
            // 
            // TopMenuBarPanel
            // 
            this.TopMenuBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMenuBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopMenuBarPanel.Controls.Add(this.pictureBox1);
            this.TopMenuBarPanel.Controls.Add(this.guna2ControlBox2);
            this.TopMenuBarPanel.Controls.Add(this.guna2ControlBox1);
            this.TopMenuBarPanel.Controls.Add(this.ControlBoxCrossMark);
            this.TopMenuBarPanel.Location = new System.Drawing.Point(-1, -4);
            this.TopMenuBarPanel.Name = "TopMenuBarPanel";
            this.TopMenuBarPanel.Size = new System.Drawing.Size(802, 36);
            this.TopMenuBarPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkNova_GUI__Finals_MasteredVesrion__CSharp.Properties.Resources.Back_Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Blue;
            this.guna2ControlBox2.Location = new System.Drawing.Point(731, 7);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(27, 24);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.Location = new System.Drawing.Point(696, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 25);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // ControlBoxCrossMark
            // 
            this.ControlBoxCrossMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxCrossMark.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ControlBoxCrossMark.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlBoxCrossMark.IconColor = System.Drawing.Color.Red;
            this.ControlBoxCrossMark.Location = new System.Drawing.Point(767, 7);
            this.ControlBoxCrossMark.Name = "ControlBoxCrossMark";
            this.ControlBoxCrossMark.Size = new System.Drawing.Size(28, 25);
            this.ControlBoxCrossMark.TabIndex = 1;
            this.ControlBoxCrossMark.Click += new System.EventHandler(this.ControlBoxCrossMark_Click);
            // 
            // dateLabel1
            // 
            this.dateLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.dateLabel1.Location = new System.Drawing.Point(6, 7);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(80, 20);
            this.dateLabel1.TabIndex = 4;
            this.dateLabel1.Text = "dateLabel";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TimeLabel.Location = new System.Drawing.Point(705, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(82, 20);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "TimeLabel";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.BorderRadius = 10;
            this.SignUpButton.BorderThickness = 1;
            this.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(61)))), ((int)(((byte)(212)))));
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SignUpButton.Location = new System.Drawing.Point(631, 74);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(122, 36);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ContactUsButton
            // 
            this.ContactUsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactUsButton.BorderColor = System.Drawing.Color.DarkGray;
            this.ContactUsButton.BorderRadius = 10;
            this.ContactUsButton.BorderThickness = 1;
            this.ContactUsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ContactUsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ContactUsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ContactUsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ContactUsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(61)))), ((int)(((byte)(212)))));
            this.ContactUsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContactUsButton.ForeColor = System.Drawing.Color.White;
            this.ContactUsButton.Location = new System.Drawing.Point(36, 74);
            this.ContactUsButton.Name = "ContactUsButton";
            this.ContactUsButton.Size = new System.Drawing.Size(122, 36);
            this.ContactUsButton.TabIndex = 7;
            this.ContactUsButton.Text = "Contact Us";
            this.ContactUsButton.Click += new System.EventHandler(this.ContactUsButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInButton.BorderRadius = 10;
            this.SignInButton.BorderThickness = 1;
            this.SignInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(61)))), ((int)(((byte)(212)))));
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(427, 75);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(127, 36);
            this.SignInButton.TabIndex = 8;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutUsButton.BorderColor = System.Drawing.Color.DarkGray;
            this.AboutUsButton.BorderRadius = 10;
            this.AboutUsButton.BorderThickness = 1;
            this.AboutUsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AboutUsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AboutUsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AboutUsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AboutUsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(61)))), ((int)(((byte)(212)))));
            this.AboutUsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AboutUsButton.ForeColor = System.Drawing.Color.White;
            this.AboutUsButton.Location = new System.Drawing.Point(229, 75);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(122, 36);
            this.AboutUsButton.TabIndex = 9;
            this.AboutUsButton.Text = "About Us";
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Controls.Add(this.TimeLabel);
            this.guna2Panel1.Controls.Add(this.dateLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 416);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(802, 36);
            this.guna2Panel1.TabIndex = 12;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.ContactUsButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.AboutUsButton);
            this.Controls.Add(this.TopMenuBarPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.TopMenuBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2Panel TopMenuBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxCrossMark;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private Guna.UI2.WinForms.Guna2Button SignUpButton;
        private Guna.UI2.WinForms.Guna2Button ContactUsButton;
        private Guna.UI2.WinForms.Guna2Button SignInButton;
        private Guna.UI2.WinForms.Guna2Button AboutUsButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}