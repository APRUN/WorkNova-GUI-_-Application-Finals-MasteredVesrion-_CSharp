
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AUserControls
{
    partial class AddUserCtrl
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.ApplyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainLabel.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MainLabel.Location = new System.Drawing.Point(239, 42);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(535, 85);
            this.MainLabel.TabIndex = 29;
            this.MainLabel.Text = "Add a New User";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Animated = true;
            this.ApplyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ApplyBtn.BorderColor = System.Drawing.Color.White;
            this.ApplyBtn.BorderRadius = 7;
            this.ApplyBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ApplyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApplyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApplyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApplyBtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.ApplyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApplyBtn.ForeColor = System.Drawing.Color.White;
            this.ApplyBtn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.ApplyBtn.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.ApplyBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.ApplyBtn.HoverState.ForeColor = System.Drawing.Color.DarkOrchid;
            this.ApplyBtn.Location = new System.Drawing.Point(594, 304);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(180, 45);
            this.ApplyBtn.TabIndex = 28;
            this.ApplyBtn.Text = "Add";
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Animated = true;
            this.passwordtxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.passwordtxt.BorderRadius = 7;
            this.passwordtxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.passwordtxt.BorderThickness = 2;
            this.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxt.DefaultText = "";
            this.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.FillColor = System.Drawing.Color.DimGray;
            this.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtxt.ForeColor = System.Drawing.Color.White;
            this.passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.Location = new System.Drawing.Point(533, 194);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.PlaceholderText = "Password";
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.Size = new System.Drawing.Size(265, 42);
            this.passwordtxt.TabIndex = 25;
            // 
            // emailtxt
            // 
            this.emailtxt.Animated = true;
            this.emailtxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.emailtxt.BorderRadius = 7;
            this.emailtxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.emailtxt.BorderThickness = 2;
            this.emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtxt.DefaultText = "";
            this.emailtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtxt.FillColor = System.Drawing.Color.DimGray;
            this.emailtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtxt.ForeColor = System.Drawing.Color.White;
            this.emailtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtxt.Location = new System.Drawing.Point(182, 307);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.PlaceholderText = "Email";
            this.emailtxt.SelectedText = "";
            this.emailtxt.Size = new System.Drawing.Size(290, 42);
            this.emailtxt.TabIndex = 26;
            // 
            // nametxt
            // 
            this.nametxt.Animated = true;
            this.nametxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.nametxt.BorderRadius = 7;
            this.nametxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.nametxt.BorderThickness = 2;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.DefaultText = "";
            this.nametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametxt.FillColor = System.Drawing.Color.DimGray;
            this.nametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nametxt.ForeColor = System.Drawing.Color.White;
            this.nametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametxt.Location = new System.Drawing.Point(182, 194);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "Username";
            this.nametxt.SelectedText = "";
            this.nametxt.Size = new System.Drawing.Size(260, 42);
            this.nametxt.TabIndex = 27;
            // 
            // AddUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.nametxt);
            this.Name = "AddUserCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.AddUserCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private Guna.UI2.WinForms.Guna2Button ApplyBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordtxt;
        private Guna.UI2.WinForms.Guna2TextBox emailtxt;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
    }
}
