using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class Supervisor_Service
    {
        Supervisor_DAO supervisor_db = new Supervisor_DAO();
        public List<Supervisor> GetSupervisors()
        {
            try
            {
                List<Supervisor> supervisors = supervisor_db.Db_Get_All_Supervisors();
                return supervisors;
            }
            catch (Exception)
            {
                // add list of fake supervisors
                List<Supervisor> supervisors = new List<Supervisor>();
                Supervisor a = new Supervisor(12, "Test", "Supervisor 1");
                supervisors.Add(a);

                Supervisor b = new Supervisor(13, "Test", "Supervisor 2");
                supervisors.Add(b);

                MessageBox.Show("Someren couldn't connect to the database");
                return supervisors;
            }
        }

        public void InsertNewSupervisor(int id)
        {
            supervisor_db.Db_Insert_Supervisor(id);
        }

        public void DeleteASupervisor(Supervisor supervisor)
        {
            supervisor_db.Db_Delete_Supervisor(supervisor);
        }

        public void UpdateSupervisor(Supervisor supervisor)
        {
            supervisor_db.Db_Update_Supervisor(supervisor);
        }

    }
}

