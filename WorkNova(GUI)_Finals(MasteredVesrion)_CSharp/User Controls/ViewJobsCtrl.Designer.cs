
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.User_Controls
{
    partial class ViewJobsCtrl
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
            this.JobListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // JobListView
            // 
            this.JobListView.GridLines = true;
            this.JobListView.HideSelection = false;
            this.JobListView.Location = new System.Drawing.Point(30, 63);
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(746, 406);
            this.JobListView.TabIndex = 1;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            // 
            // ViewJobsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.JobListView);
            this.Name = "ViewJobsCtrl";
            this.Size = new System.Drawing.Size(802, 532);
            this.Load += new System.EventHandler(this.ViewJobsCtrl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView JobListView;
    }
}
