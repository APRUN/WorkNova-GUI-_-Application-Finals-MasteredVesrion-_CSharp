
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AEmployeeControls
{
    partial class AddEmployeeCtrl
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
            this.contacttxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cnictxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.agetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.exptxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.citytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.jobnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainLabel.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MainLabel.Location = new System.Drawing.Point(150, 27);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(683, 85);
            this.MainLabel.TabIndex = 33;
            this.MainLabel.Text = "Add a New Employee";
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
            this.ApplyBtn.Location = new System.Drawing.Point(653, 383);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(180, 45);
            this.ApplyBtn.TabIndex = 32;
            this.ApplyBtn.Text = "Add";
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // contacttxt
            // 
            this.contacttxt.Animated = true;
            this.contacttxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.contacttxt.BorderRadius = 7;
            this.contacttxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.contacttxt.BorderThickness = 2;
            this.contacttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contacttxt.DefaultText = "";
            this.contacttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contacttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contacttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contacttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contacttxt.FillColor = System.Drawing.Color.DimGray;
            this.contacttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contacttxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contacttxt.ForeColor = System.Drawing.Color.White;
            this.contacttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contacttxt.Location = new System.Drawing.Point(363, 154);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.PasswordChar = '\0';
            this.contacttxt.PlaceholderText = "Contact";
            this.contacttxt.SelectedText = "";
            this.contacttxt.Size = new System.Drawing.Size(271, 42);
            this.contacttxt.TabIndex = 30;
            this.contacttxt.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
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
            this.nametxt.Location = new System.Drawing.Point(106, 154);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "Username";
            this.nametxt.SelectedText = "";
            this.nametxt.Size = new System.Drawing.Size(227, 42);
            this.nametxt.TabIndex = 31;
            // 
            // cnictxt
            // 
            this.cnictxt.Animated = true;
            this.cnictxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.cnictxt.BorderRadius = 7;
            this.cnictxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cnictxt.BorderThickness = 2;
            this.cnictxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnictxt.DefaultText = "";
            this.cnictxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cnictxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cnictxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnictxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnictxt.FillColor = System.Drawing.Color.DimGray;
            this.cnictxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnictxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnictxt.ForeColor = System.Drawing.Color.White;
            this.cnictxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnictxt.Location = new System.Drawing.Point(106, 280);
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.PasswordChar = '\0';
            this.cnictxt.PlaceholderText = "CNIC";
            this.cnictxt.SelectedText = "";
            this.cnictxt.Size = new System.Drawing.Size(291, 42);
            this.cnictxt.TabIndex = 30;
            // 
            // agetxt
            // 
            this.agetxt.Animated = true;
            this.agetxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.agetxt.BorderRadius = 7;
            this.agetxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.agetxt.BorderThickness = 2;
            this.agetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.agetxt.DefaultText = "";
            this.agetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.agetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.agetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.agetxt.FillColor = System.Drawing.Color.DimGray;
            this.agetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.agetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.agetxt.ForeColor = System.Drawing.Color.White;
            this.agetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.agetxt.Location = new System.Drawing.Point(435, 280);
            this.agetxt.Name = "agetxt";
            this.agetxt.PasswordChar = '\0';
            this.agetxt.PlaceholderText = "Age";
            this.agetxt.SelectedText = "";
            this.agetxt.Size = new System.Drawing.Size(108, 42);
            this.agetxt.TabIndex = 30;
            // 
            // exptxt
            // 
            this.exptxt.Animated = true;
            this.exptxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.exptxt.BorderRadius = 7;
            this.exptxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.exptxt.BorderThickness = 2;
            this.exptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exptxt.DefaultText = "";
            this.exptxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.exptxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.exptxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.exptxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.exptxt.FillColor = System.Drawing.Color.DimGray;
            this.exptxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.exptxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exptxt.ForeColor = System.Drawing.Color.White;
            this.exptxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.exptxt.Location = new System.Drawing.Point(596, 280);
            this.exptxt.Name = "exptxt";
            this.exptxt.PasswordChar = '\0';
            this.exptxt.PlaceholderText = "Experience";
            this.exptxt.SelectedText = "";
            this.exptxt.Size = new System.Drawing.Size(125, 42);
            this.exptxt.TabIndex = 30;
            // 
            // citytxt
            // 
            this.citytxt.Animated = true;
            this.citytxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.citytxt.BorderRadius = 7;
            this.citytxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.citytxt.BorderThickness = 2;
            this.citytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.citytxt.DefaultText = "";
            this.citytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.citytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.citytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.citytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.citytxt.FillColor = System.Drawing.Color.DimGray;
            this.citytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.citytxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.citytxt.ForeColor = System.Drawing.Color.White;
            this.citytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.citytxt.Location = new System.Drawing.Point(679, 154);
            this.citytxt.Name = "citytxt";
            this.citytxt.PasswordChar = '\0';
            this.citytxt.PlaceholderText = "City";
            this.citytxt.SelectedText = "";
            this.citytxt.Size = new System.Drawing.Size(190, 42);
            this.citytxt.TabIndex = 30;
            // 
            // jobnametxt
            // 
            this.jobnametxt.Animated = true;
            this.jobnametxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.jobnametxt.BorderRadius = 7;
            this.jobnametxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.jobnametxt.BorderThickness = 2;
            this.jobnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jobnametxt.DefaultText = "";
            this.jobnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.jobnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.jobnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jobnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jobnametxt.FillColor = System.Drawing.Color.DimGray;
            this.jobnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jobnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jobnametxt.ForeColor = System.Drawing.Color.White;
            this.jobnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jobnametxt.Location = new System.Drawing.Point(106, 383);
            this.jobnametxt.Name = "jobnametxt";
            this.jobnametxt.PasswordChar = '\0';
            this.jobnametxt.PlaceholderText = "Job Name";
            this.jobnametxt.SelectedText = "";
            this.jobnametxt.Size = new System.Drawing.Size(277, 42);
            this.jobnametxt.TabIndex = 30;
            // 
            // AddEmployeeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.exptxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.jobnametxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.nametxt);
            this.Name = "AddEmployeeCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.AddEmployeeCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private Guna.UI2.WinForms.Guna2Button ApplyBtn;
        private Guna.UI2.WinForms.Guna2TextBox contacttxt;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
        private Guna.UI2.WinForms.Guna2TextBox cnictxt;
        private Guna.UI2.WinForms.Guna2TextBox agetxt;
        private Guna.UI2.WinForms.Guna2TextBox exptxt;
        private Guna.UI2.WinForms.Guna2TextBox citytxt;
        private Guna.UI2.WinForms.Guna2TextBox jobnametxt;
    }
}
