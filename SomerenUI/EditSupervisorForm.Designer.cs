namespace SomerenUI
{
    partial class EditSupervisorForm
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
            this.listViewSelectedSupervisor = new System.Windows.Forms.ListView();
            this.lecturerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lecturerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lecturerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSelectedSupervisor
            // 
            this.listViewSelectedSupervisor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lecturerID,
            this.lecturerName,
            this.lecturerLastName});
            this.listViewSelectedSupervisor.FullRowSelect = true;
            this.listViewSelectedSupervisor.Location = new System.Drawing.Point(18, 68);
            this.listViewSelectedSupervisor.Name = "listViewSelectedSupervisor";
            this.listViewSelectedSupervisor.Size = new System.Drawing.Size(729, 352);
            this.listViewSelectedSupervisor.TabIndex = 9;
            this.listViewSelectedSupervisor.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedSupervisor.View = System.Windows.Forms.View.Details;
            this.listViewSelectedSupervisor.SelectedIndexChanged += new System.EventHandler(this.listViewSelectedSupervisor_SelectedIndexChanged);
            // 
            // lecturerID
            // 
            this.lecturerID.Text = "Lecturer ID ";
            this.lecturerID.Width = 127;
            // 
            // lecturerName
            // 
            this.lecturerName.Text = "Name";
            this.lecturerName.Width = 104;
            // 
            // lecturerLastName
            // 
            this.lecturerLastName.Text = "Last Name";
            this.lecturerLastName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supervisor";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(766, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 65);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Save Changes";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(28, 109);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(179, 109);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(328, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(765, 346);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 74);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Supervisor";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // EditSupervisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 520);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSelectedSupervisor);
            this.Name = "EditSupervisorForm";
            this.Text = "Edit Supervisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSelectedSupervisor;
        private System.Windows.Forms.ColumnHeader lecturerID;
        private System.Windows.Forms.ColumnHeader lecturerName;
        private System.Windows.Forms.ColumnHeader lecturerLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnRemove;
    }
}