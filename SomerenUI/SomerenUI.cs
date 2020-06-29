using SomerenLogic;
using SomerenModel;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        //this is a part of variant B from assignment 3
        //this is a part of variant B from assignment 3
        string studentIDSelect = null;
        Drink drink = null;



        //this is part of variant A from assignment 3
        //this is part of variant A from assignment 3
        //We will create this listview from code
        ListView viewStudentList;

        public SomerenUI()
        {
            InitializeComponent();
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(15, 15);
            //add images to the list 
            imgList.Images.Add(Properties.Resources.fullbottle);
            imgList.Images.Add(Properties.Resources.halfbottle);
            listViewDrinks.SmallImageList = imgList;
        }
        public ListView CreateStudentListView()
        {
            ListView myList = new ListView();

            //add columns
            myList.View = View.Details;
            myList.Columns.Add("student id", 90, HorizontalAlignment.Left);
            myList.Columns.Add("name", 90, HorizontalAlignment.Left);
            myList.Columns.Add("last name", 90, HorizontalAlignment.Left);

            myList.Size = new Size(750, 290);
            myList.Location = new Point(21, 52);
            myList.Margin = new Padding(4, 4, 4, 4);
            return myList;
        }
        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        //private to internal because we will reference it from the other form
        internal void showPanel(string panelName)
        {
            //hide all panels
            pnl_Dashboard.Hide();
            img_Dashboard.Hide();
            pnl_Students.Hide();
            pnl_Teachers.Hide();
            pnl_Drinks.Hide();
            pnl_CashRegister.Hide();
            pnl_Supervisors.Hide();


            if (panelName == "Dashboard")
            {
                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Students")
            {
                //Check if the listview already exist, if not create one.
                if (viewStudentList == null)
                {
                    viewStudentList = CreateStudentListView();
                    pnl_Students.Controls.Add(viewStudentList);
                }

                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students
                Student_Service studService = new Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                viewStudentList.Items.Clear();

                foreach (Student s in studentList)
                {
                    ListViewItem student = new ListViewItem(new string[] { s.Number.ToString(), s.FirstName, s.LastName });
                    viewStudentList.Items.Add(student);
                }
            }
            else if (panelName == "Lecturers")
            {
                // show teachers panel
                pnl_Teachers.Show();

                // fill the teachers listview within the teacher panel with a list of teachers
                Teacher_Service teacherService = new Teacher_Service();
                List<Teacher> teacherList = teacherService.GetTeachers();

                // clear the items in listview
                listViewTeachers.Items.Clear();

                // fill list
                foreach (Teacher s in teacherList)
                {
                    ListViewItem teacher = new ListViewItem(s.Number.ToString());
                    teacher.SubItems.Add(s.FirstName);
                    teacher.SubItems.Add(s.LastName);
                    listViewTeachers.Items.Add(teacher);
                }
            }



            //this is part of variant A from assignment 3
            //this is part of variant A from assignment 3
            else if (panelName == "Drinks Supplies")
            {
                //show drinks panel 
                pnl_Drinks.Show();

                //fill the drinks listview wihin the drink panel with a list of drinks
                Drink_Service drinkService = new Drink_Service();
                List<Drink> drinkList = drinkService.GetDrinks();

                //clear the items in listview
                listViewDrinks.Items.Clear();

                //fill list
                foreach (Drink d in drinkList)
                {
                    ListViewItem drink = new ListViewItem(new string[] { d.DrinkName, String.Format("{0:0.00}", d.Price), d.StockAmount.ToString() });
                    drink.Tag = d;
                    if (d.StockAmount < 10)
                    {
                        //show half bottle icon
                        drink.ImageIndex = 1;
                    }
                    else
                    {
                        //show full bottle icon 
                        drink.ImageIndex = 0;
                    }
                    listViewDrinks.Items.Add(drink);
                }
                this.Refresh();
            }




            //this is a part of variant B from assignment 3
            //this is a part of variant B from assignment 3
            else if (panelName == "CashRegister")
            {
                //show panel
                pnl_CashRegister.Show();

                //get list of drinks and students
                Student_Service studService = new Student_Service();
                List<Student> studentList = studService.GetStudents();

                Drink_Service drinkService = new Drink_Service();
                List<Drink> drinkList = drinkService.GetDrinks();

                //clear the listview before filling it again
                lv_Cash_Student.Items.Clear();
                lv_Cash_Drinks.Items.Clear();

                //get students
                foreach (Student s in studentList)
                {
                    ListViewItem student = new ListViewItem(s.Number.ToString());
                    student.SubItems.Add(s.FullName);

                    lv_Cash_Student.Items.Add(student);
                }

                //get drinks
                foreach (Drink d in drinkList)
                {
                    ListViewItem drink = new ListViewItem(d.DrinkNumber.ToString());
                    drink.SubItems.Add(d.DrinkName);
                    drink.SubItems.Add(d.Price.ToString("0.00"));
                    drink.SubItems.Add(d.StockAmount.ToString());

                    lv_Cash_Drinks.Items.Add(drink);
                }
            }

            //this is a part of variant B from assignment 4
            //this is a part of variant B from assignment 4
            else if (panelName == "Supervisors")
            {
                //show supervisor panek
                pnl_Supervisors.Show();

                //fill the supervisors listview within the supervisor panel with list of supervisors
                Supervisor_Service supervisorService = new Supervisor_Service();
                List<Supervisor> supervisorList = supervisorService.GetSupervisors();

                //clear items in listview
                listViewSupervisors.Items.Clear();

                //fill list
                foreach (Supervisor s in supervisorList)
                {
                    ListViewItem supervisor = new ListViewItem(new string[] { s.LecturerID.ToString(), s.FirstName, s.LastName });
                    supervisor.Tag = s;
                    listViewSupervisors.Items.Add(supervisor);
                }
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks Supplies");
        }

        //this is part of variant A from assignment 3
        //this is part of variant A from assignment 3
        private void btnNewDrinks_Click(object sender, EventArgs e)
        {
            //when clicked, a new form will be made 
            //where user could create a new drink
            NewForm form = new NewForm();
            form.ShowDialog();
            showPanel("Drinks Supplies");
        }
        private void listViewDrinks_Click(object sender, EventArgs e)
        {
            Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
            //another form where user could edit the drink
            var editDrinkForm = new EditDrinkForm(drink);
            editDrinkForm.ShowDialog();
            showPanel("Drinks Supplies");
        }


        //this is a part of variant B from assignment 3
        //this is a part of variant B from assignment 3
        private void cashRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("CashRegister");
        }
        //btn checkout in cashRegister
        private void btn_CashRegister_Checkout_Click_1(object sender, EventArgs e)
        {
            if (studentIDSelect != null && drink != null)
            {
                //show order
                string order = $"Order from student {studentIDSelect} has been made.";
                MessageBox.Show(order);

                //update drink
                Drink_Service ds = new Drink_Service();
                ds.SaleDrink(drink);

                //reset values
                studentIDSelect = null;
                drink = null;

                //refresh form
                Refresh();
                showPanel("CashRegister");
            }
            else
            {
                MessageBox.Show("Not a valid selection");
            }
        }
        private void lv_Cash_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select item
            for (int i = 0; i < lv_Cash_Student.SelectedItems.Count; i++)
            {
                studentIDSelect = lv_Cash_Student.SelectedItems[0].Text;
            }
        }
        private void lv_Cash_Drinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            drink = new Drink();
            //select item
            for (int i = 0; i < lv_Cash_Drinks.SelectedItems.Count; i++)
            {
                drink.DrinkNumber = int.Parse(lv_Cash_Drinks.SelectedItems[0].Text);
            }
        }


        //this is a part of variant B from assignment 3
        //this is a part of variant B from assignment 3
        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void listViewSupervisors_Click(object sender, EventArgs e)
        {
            Supervisor supervisor = (Supervisor)listViewSupervisors.SelectedItems[0].Tag;

            //another form will show where user could edit a supervisor
            var editSupervisorForm = new EditSupervisorForm(supervisor);
            editSupervisorForm.ShowDialog();
            showPanel("Supervisors");
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            //when clicked, a new form will be made 
            //where user could add a new supervisor
            AddSupervisorForm form = new AddSupervisorForm();
            form.ShowDialog();
            showPanel("Supervisors");
        }
    }
}
