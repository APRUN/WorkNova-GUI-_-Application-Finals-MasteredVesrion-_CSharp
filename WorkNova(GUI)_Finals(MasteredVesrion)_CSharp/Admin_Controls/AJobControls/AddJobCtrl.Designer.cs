
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AJobControls
{
    partial class AddJobCtrl
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
            this.catcombobox = new System.Windows.Forms.ComboBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.paytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.citytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.exptxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.compnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // catcombobox
            // 
            this.catcombobox.BackColor = System.Drawing.Color.DimGray;
            this.catcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catcombobox.ForeColor = System.Drawing.Color.White;
            this.catcombobox.FormattingEnabled = true;
            this.catcombobox.Items.AddRange(new object[] {
            "Internship",
            "Part Time",
            "Full Time"});
            this.catcombobox.Location = new System.Drawing.Point(570, 239);
            this.catcombobox.Name = "catcombobox";
            this.catcombobox.Size = new System.Drawing.Size(146, 33);
            this.catcombobox.TabIndex = 25;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainLabel.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MainLabel.Location = new System.Drawing.Point(211, 39);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(517, 85);
            this.MainLabel.TabIndex = 24;
            this.MainLabel.Text = "Add a New Job";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderColor = System.Drawing.Color.White;
            this.AddBtn.BorderRadius = 7;
            this.AddBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.AddBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.ForeColor = System.Drawing.Color.DarkOrchid;
            this.AddBtn.Location = new System.Drawing.Point(383, 428);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 45);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // paytxt
            // 
            this.paytxt.Animated = true;
            this.paytxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.paytxt.BorderRadius = 7;
            this.paytxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.paytxt.BorderThickness = 2;
            this.paytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paytxt.DefaultText = "";
            this.paytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paytxt.FillColor = System.Drawing.Color.DimGray;
            this.paytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paytxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paytxt.ForeColor = System.Drawing.Color.White;
            this.paytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paytxt.Location = new System.Drawing.Point(558, 160);
            this.paytxt.Name = "paytxt";
            this.paytxt.PasswordChar = '\0';
            this.paytxt.PlaceholderText = "Pay";
            this.paytxt.SelectedText = "";
            this.paytxt.Size = new System.Drawing.Size(146, 42);
            this.paytxt.TabIndex = 18;
            // 
            // citytxt
            // 
            this.citytxt.Animated = true;
            this.citytxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
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
            this.citytxt.Location = new System.Drawing.Point(237, 320);
            this.citytxt.Name = "citytxt";
            this.citytxt.PasswordChar = '\0';
            this.citytxt.PlaceholderText = "City";
            this.citytxt.SelectedText = "";
            this.citytxt.Size = new System.Drawing.Size(146, 42);
            this.citytxt.TabIndex = 19;
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
            this.exptxt.Location = new System.Drawing.Point(577, 320);
            this.exptxt.Name = "exptxt";
            this.exptxt.PasswordChar = '\0';
            this.exptxt.PlaceholderText = "Experience";
            this.exptxt.SelectedText = "";
            this.exptxt.Size = new System.Drawing.Size(139, 42);
            this.exptxt.TabIndex = 20;
            // 
            // compnametxt
            // 
            this.compnametxt.Animated = true;
            this.compnametxt.BorderColor = System.Drawing.Color.DarkOrchid;
            this.compnametxt.BorderRadius = 7;
            this.compnametxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.compnametxt.BorderThickness = 2;
            this.compnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.compnametxt.DefaultText = "";
            this.compnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.compnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.compnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.compnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.compnametxt.FillColor = System.Drawing.Color.DimGray;
            this.compnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.compnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.compnametxt.ForeColor = System.Drawing.Color.White;
            this.compnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.compnametxt.Location = new System.Drawing.Point(237, 239);
            this.compnametxt.Name = "compnametxt";
            this.compnametxt.PasswordChar = '\0';
            this.compnametxt.PlaceholderText = "Company Name";
            this.compnametxt.SelectedText = "";
            this.compnametxt.Size = new System.Drawing.Size(290, 42);
            this.compnametxt.TabIndex = 21;
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
            this.nametxt.Location = new System.Drawing.Point(237, 160);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "Job Name";
            this.nametxt.SelectedText = "";
            this.nametxt.Size = new System.Drawing.Size(227, 42);
            this.nametxt.TabIndex = 22;
            // 
            // AddJobCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.catcombobox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.paytxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.exptxt);
            this.Controls.Add(this.compnametxt);
            this.Controls.Add(this.nametxt);
            this.Name = "AddJobCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.AddJobCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catcombobox;
        private System.Windows.Forms.Label MainLabel;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox paytxt;
        private Guna.UI2.WinForms.Guna2TextBox citytxt;
        private Guna.UI2.WinForms.Guna2TextBox exptxt;
        private Guna.UI2.WinForms.Guna2TextBox compnametxt;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
    }
}
