
namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AEmployeeControls
{
    partial class ViewEmployeesCtrl
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
            this.EmpListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EmpListView
            // 
            this.EmpListView.GridLines = true;
            this.EmpListView.HideSelection = false;
            this.EmpListView.Location = new System.Drawing.Point(172, 60);
            this.EmpListView.Name = "EmpListView";
            this.EmpListView.Size = new System.Drawing.Size(610, 388);
            this.EmpListView.TabIndex = 0;
            this.EmpListView.UseCompatibleStateImageBehavior = false;
            this.EmpListView.View = System.Windows.Forms.View.Details;
            // 
            // ViewEmployeesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.EmpListView);
            this.Name = "ViewEmployeesCtrl";
            this.Size = new System.Drawing.Size(1018, 514);
            this.Load += new System.EventHandler(this.ViewEmployeesCtrl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmpListView;
    }
}
