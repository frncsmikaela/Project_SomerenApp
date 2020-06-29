using SomerenLogic;
using SomerenModel;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;

namespace SomerenUI
{
    public partial class AddSupervisorForm : Form
    {
        //this form will show the list of lecturers that are not a supervisor
        //where they could add a lecturer as a supervisor 
        public AddSupervisorForm()
        {
            InitializeComponent();
            Teacher_Service teacherService = new Teacher_Service();
            List<Teacher> teacherList = teacherService.GetTeachersNotSupervisor();

            // fill list
            foreach (Teacher s in teacherList)
            {
                ListViewItem teacher = new ListViewItem(s.Number.ToString());
                teacher.Tag = s;
                teacher.SubItems.Add(s.FirstName);
                teacher.SubItems.Add(s.LastName);
                listViewLecturers.Items.Add(teacher);
            }
            //if user did not select any lecturer from the list, button for adding supervisor is unabled
            btnAddSelectedSupervisor.Enabled = false;
        }

        private void AddSupervisorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSelectedSupervisor_Click(object sender, EventArgs e)
        {
            Supervisor_Service supervisor_Service = new Supervisor_Service();

            Teacher teacher = (Teacher)listViewLecturers.SelectedItems[0].Tag;
            int teacherId = teacher.Number;

            supervisor_Service.InsertNewSupervisor(teacherId);
            this.Hide();
        }

        private void listViewLecturers_Click(object sender, EventArgs e)
        {
            //if a user selected a lecturer, button for adding supervisor will be enabled
            btnAddSelectedSupervisor.Enabled = true;
        }
    }
}
