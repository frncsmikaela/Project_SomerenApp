namespace SomerenUI
{
    partial class AddSupervisorForm
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
            this.listViewLecturers = new System.Windows.Forms.ListView();
            this.addLecturerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSelectedSupervisor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLecturers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewLecturers
            // 
            this.listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addLecturerID,
            this.addFirstName,
            this.addLastName});
            this.listViewLecturers.FullRowSelect = true;
            this.listViewLecturers.HoverSelection = true;
            this.listViewLecturers.Location = new System.Drawing.Point(25, 70);
            this.listViewLecturers.Name = "listViewLecturers";
            this.listViewLecturers.Size = new System.Drawing.Size(679, 395);
            this.listViewLecturers.TabIndex = 4;
            this.listViewLecturers.UseCompatibleStateImageBehavior = false;
            this.listViewLecturers.View = System.Windows.Forms.View.Details;
            this.listViewLecturers.Click += new System.EventHandler(this.listViewLecturers_Click);
            // 
            // addLecturerID
            // 
            this.addLecturerID.Text = "Lecturer ID";
            this.addLecturerID.Width = 116;
            // 
            // addFirstName
            // 
            this.addFirstName.Text = "First Name";
            this.addFirstName.Width = 131;
            // 
            // addLastName
            // 
            this.addLastName.Text = "Last Name";
            this.addLastName.Width = 115;
            // 
            // btnAddSelectedSupervisor
            // 
            this.btnAddSelectedSupervisor.Location = new System.Drawing.Point(735, 404);
            this.btnAddSelectedSupervisor.Name = "btnAddSelectedSupervisor";
            this.btnAddSelectedSupervisor.Size = new System.Drawing.Size(118, 61);
            this.btnAddSelectedSupervisor.TabIndex = 7;
            this.btnAddSelectedSupervisor.Text = "Add Supervisor";
            this.btnAddSelectedSupervisor.UseVisualStyleBackColor = true;
            this.btnAddSelectedSupervisor.Click += new System.EventHandler(this.btnAddSelectedSupervisor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(190, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Click the list to add a supervisor ";
            // 
            // lblLecturers
            // 
            this.lblLecturers.AutoSize = true;
            this.lblLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblLecturers.Location = new System.Drawing.Point(28, 23);
            this.lblLecturers.Name = "lblLecturers";
            this.lblLecturers.Size = new System.Drawing.Size(137, 33);
            this.lblLecturers.TabIndex = 5;
            this.lblLecturers.Text = "Lecturers";
            // 
            // AddSupervisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.listViewLecturers);
            this.Controls.Add(this.btnAddSelectedSupervisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLecturers);
            this.Name = "AddSupervisorForm";
            this.Text = "Add/Remove Supervisor";
            this.Load += new System.EventHandler(this.AddSupervisorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader addLecturerID;
        private System.Windows.Forms.ColumnHeader addFirstName;
        private System.Windows.Forms.ColumnHeader addLastName;
        private System.Windows.Forms.Button btnAddSelectedSupervisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLecturers;
    }
}