using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class Teacher_Service
    {
        Teacher_DAO teacher_db = new Teacher_DAO();

        public List<Teacher> GetTeachers()
        {
            try
            {
                List<Teacher> teachers = teacher_db.Db_Get_All_Teachers();
                return teachers;
            }
            catch (Exception)
            {
                // add fake teachers
                List<Teacher> teachers = new List<Teacher>();
                Teacher a = new Teacher("Mr.", "Teacher", 001);
                teachers.Add(a);

                Teacher b = new Teacher("Mr.", "Teacher", 002);
                teachers.Add(b);

                MessageBox.Show("Someren couldn't connect to the database");
                return teachers;
            }
        }

        //this is part of variant B from assignment 4
        //this is part of variant B from assignment 4
        public List<Teacher> GetTeachersNotSupervisor()
        {
            try
            {
                List<Teacher> teachers = teacher_db.Db_Get_Teachers_Not_Supervisor();
                return teachers;
            }
            catch (Exception)
            {
                // add fake teachers
                List<Teacher> teachers = new List<Teacher>();
                Teacher a = new Teacher("Mr.", "Teacher", 001);
                teachers.Add(a);

                Teacher b = new Teacher("Mr.", "Teacher", 002);
                teachers.Add(b);

                MessageBox.Show("Someren couldn't connect to the database");
                return teachers;
            }

        }

       
    }
}
