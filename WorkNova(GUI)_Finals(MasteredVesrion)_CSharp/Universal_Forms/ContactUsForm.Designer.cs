
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    partial class ContactUsForm
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
            this.FormElispe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopMenuBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxCrossMark = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtfilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSnd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtBody = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubject = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeFooterPanle = new System.Windows.Forms.Panel();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.TopMenuBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TimeFooterPanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElispe
            // 
            this.FormElispe.BorderRadius = 8;
            this.FormElispe.TargetControl = this;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 20;
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
            this.TopMenuBarPanel.Location = new System.Drawing.Point(-1, -2);
            this.TopMenuBarPanel.Name = "TopMenuBarPanel";
            this.TopMenuBarPanel.Size = new System.Drawing.Size(827, 40);
            this.TopMenuBarPanel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkNova_GUI__Finals_MasteredVesrion__CSharp.Properties.Resources.Back_Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Blue;
            this.guna2ControlBox2.Location = new System.Drawing.Point(752, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(36, 35);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.Location = new System.Drawing.Point(716, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(39, 36);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // ControlBoxCrossMark
            // 
            this.ControlBoxCrossMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxCrossMark.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ControlBoxCrossMark.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlBoxCrossMark.IconColor = System.Drawing.Color.Red;
            this.ControlBoxCrossMark.Location = new System.Drawing.Point(786, 3);
            this.ControlBoxCrossMark.Name = "ControlBoxCrossMark";
            this.ControlBoxCrossMark.Size = new System.Drawing.Size(40, 34);
            this.ControlBoxCrossMark.TabIndex = 1;
            this.ControlBoxCrossMark.Click += new System.EventHandler(this.ControlBoxCrossMark_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtfilename.BorderRadius = 10;
            this.txtfilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilename.DefaultText = "";
            this.txtfilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilename.FillColor = System.Drawing.Color.DimGray;
            this.txtfilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilename.Location = new System.Drawing.Point(491, 145);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.PasswordChar = '\0';
            this.txtfilename.PlaceholderText = "File Adress";
            this.txtfilename.SelectedText = "";
            this.txtfilename.Size = new System.Drawing.Size(285, 71);
            this.txtfilename.TabIndex = 13;
            // 
            // BtnSnd
            // 
            this.BtnSnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSnd.FillColor = System.Drawing.Color.DarkOrchid;
            this.BtnSnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSnd.ForeColor = System.Drawing.Color.White;
            this.BtnSnd.Location = new System.Drawing.Point(696, 332);
            this.BtnSnd.Name = "BtnSnd";
            this.BtnSnd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnSnd.Size = new System.Drawing.Size(66, 63);
            this.BtnSnd.TabIndex = 12;
            this.BtnSnd.Text = "Send";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabel1.Location = new System.Drawing.Point(577, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Attach File";
            // 
            // txtBody
            // 
            this.txtBody.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtBody.BorderRadius = 12;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.DefaultText = "";
            this.txtBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBody.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.FillColor = System.Drawing.Color.DimGray;
            this.txtBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Location = new System.Drawing.Point(70, 241);
            this.txtBody.Name = "txtBody";
            this.txtBody.PasswordChar = '\0';
            this.txtBody.PlaceholderText = "Message";
            this.txtBody.SelectedText = "";
            this.txtBody.Size = new System.Drawing.Size(588, 204);
            this.txtBody.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtSubject.BorderRadius = 12;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.DefaultText = "";
            this.txtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubject.FillColor = System.Drawing.Color.DimGray;
            this.txtSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.txtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubject.Location = new System.Drawing.Point(72, 145);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.PlaceholderText = "Subject";
            this.txtSubject.SelectedText = "";
            this.txtSubject.Size = new System.Drawing.Size(340, 36);
            this.txtSubject.TabIndex = 9;
            // 
            // txtTo
            // 
            this.txtTo.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtTo.BorderRadius = 12;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FillColor = System.Drawing.Color.DimGray;
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.Location = new System.Drawing.Point(70, 93);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTo.PlaceholderText = "From";
            this.txtTo.SelectedText = "";
            this.txtTo.Size = new System.Drawing.Size(340, 36);
            this.txtTo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(340, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Send Email";
            // 
            // TimeFooterPanle
            // 
            this.TimeFooterPanle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFooterPanle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeFooterPanle.Controls.Add(this.dateLabel1);
            this.TimeFooterPanle.Controls.Add(this.TimeLabel);
            this.TimeFooterPanle.Location = new System.Drawing.Point(-3, 453);
            this.TimeFooterPanle.Name = "TimeFooterPanle";
            this.TimeFooterPanle.Size = new System.Drawing.Size(829, 28);
            this.TimeFooterPanle.TabIndex = 15;
            // 
            // dateLabel1
            // 
            this.dateLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel1.ForeColor = System.Drawing.Color.White;
            this.dateLabel1.Location = new System.Drawing.Point(22, 5);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(51, 20);
            this.dateLabel1.TabIndex = 3;
            this.dateLabel1.Text = "label1";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(744, 5);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(51, 20);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "label1";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ContactUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.TopMenuBarPanel);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.BtnSnd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeFooterPanle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactUsForm";
            this.Load += new System.EventHandler(this.ContactUsForm_Load);
            this.TopMenuBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TimeFooterPanle.ResumeLayout(false);
            this.TimeFooterPanle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormElispe;
        private Guna.UI2.WinForms.Guna2Panel TopMenuBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxCrossMark;
        private Guna.UI2.WinForms.Guna2TextBox txtfilename;
        private Guna.UI2.WinForms.Guna2CircleButton BtnSnd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBody;
        private Guna.UI2.WinForms.Guna2TextBox txtSubject;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TimeFooterPanle;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label TimeLabel;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.Timer ClockTimer;
    }
}