
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AAdminControls
{
    partial class ViewAdminsCtrl
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
            this.AdminListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AdminListView
            // 
            this.AdminListView.GridLines = true;
            this.AdminListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AdminListView.HideSelection = false;
            this.AdminListView.Location = new System.Drawing.Point(160, 58);
            this.AdminListView.Name = "AdminListView";
            this.AdminListView.Size = new System.Drawing.Size(615, 400);
            this.AdminListView.TabIndex = 0;
            this.AdminListView.UseCompatibleStateImageBehavior = false;
            this.AdminListView.View = System.Windows.Forms.View.Details;
            // 
            // ViewAdminsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.AdminListView);
            this.Name = "ViewAdminsCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.ViewAdminsCtrl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AdminListView;
    }
}
