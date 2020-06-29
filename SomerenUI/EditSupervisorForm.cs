using SomerenLogic;
using SomerenModel;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;

namespace SomerenUI
{
    public partial class EditSupervisorForm : Form
    {
        private Supervisor supervisor;
        public EditSupervisorForm(Supervisor supervisor)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            ShowSelectedSupervisor(supervisor);
        }
        public void ShowSelectedSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
            txtId.Text = supervisor.LecturerID.ToString();
            txtFirstName.Text = supervisor.FirstName;
            txtLastName.Text = supervisor.LastName;
        }

        private void listViewSelectedSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get the field that the user wants to edit
            supervisor.FirstName = txtFirstName.Text;
            supervisor.LastName = txtLastName.Text;
            supervisor.LecturerID = int.Parse(txtId.Text);

            Supervisor_Service supervisorService = new Supervisor_Service();
            supervisorService.UpdateSupervisor(supervisor);

            //close the form
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Supervisor_Service supervisorService = new Supervisor_Service();

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure that you wish to remove this supervisor?", "Remove supervisor", buttons);
            if (result == DialogResult.Yes)
            {
                supervisorService.DeleteASupervisor(supervisor);
            }
            this.Close();
        }
    }
}
