
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AUserControls
{
    partial class RemoveUserCtrl
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
            this.Removebtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernamelbl = new System.Windows.Forms.Panel();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.emaillbl = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.usernamelbl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Removebtn
            // 
            this.Removebtn.Animated = true;
            this.Removebtn.BackColor = System.Drawing.Color.Transparent;
            this.Removebtn.BorderColor = System.Drawing.Color.White;
            this.Removebtn.BorderRadius = 7;
            this.Removebtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.Removebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Removebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Removebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Removebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Removebtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.Removebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Removebtn.ForeColor = System.Drawing.Color.White;
            this.Removebtn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Removebtn.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.Removebtn.HoverState.FillColor = System.Drawing.Color.White;
            this.Removebtn.HoverState.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Removebtn.Location = new System.Drawing.Point(703, 143);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(180, 45);
            this.Removebtn.TabIndex = 34;
            this.Removebtn.Text = "Remove";
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(189, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 45);
            this.panel1.TabIndex = 33;
            // 
            // usernamelbl
            // 
            this.usernamelbl.BackColor = System.Drawing.Color.DarkOrchid;
            this.usernamelbl.Controls.Add(this.namelbl);
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(307, -3);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(310, 52);
            this.usernamelbl.TabIndex = 0;
            // 
            // namelbl
            // 
            this.namelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(131, 14);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(64, 25);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 45);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainLabel.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.MainLabel.Location = new System.Drawing.Point(155, 26);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(652, 85);
            this.MainLabel.TabIndex = 32;
            this.MainLabel.Text = "Remove an Old User";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nametxt
            // 
            this.nametxt.Animated = true;
            this.nametxt.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.nametxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nametxt.BorderRadius = 5;
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
            this.nametxt.HoverState.BorderColor = System.Drawing.Color.Red;
            this.nametxt.Location = new System.Drawing.Point(132, 152);
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PlaceholderText = "Username";
            this.nametxt.SelectedText = "";
            this.nametxt.Size = new System.Drawing.Size(303, 36);
            this.nametxt.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(189, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 45);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.Controls.Add(this.passwordlbl);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(307, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 52);
            this.panel3.TabIndex = 0;
            // 
            // passwordlbl
            // 
            this.passwordlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(131, 14);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(64, 25);
            this.passwordlbl.TabIndex = 0;
            this.passwordlbl.Text = "Name";
            this.passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 45);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(188, 399);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 45);
            this.panel6.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel7.Controls.Add(this.emaillbl);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(307, -3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 52);
            this.panel7.TabIndex = 0;
            // 
            // emaillbl
            // 
            this.emaillbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(131, 14);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(64, 25);
            this.emaillbl.TabIndex = 0;
            this.emaillbl.Text = "Name";
            this.emaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(0, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 45);
            this.panel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.nametxt);
            this.Name = "RemoveUserCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.RemoveUserCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.usernamelbl.ResumeLayout(false);
            this.usernamelbl.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Removebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel usernamelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MainLabel;
        private Guna.UI2.WinForms.Guna2TextBox nametxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
    }
}
