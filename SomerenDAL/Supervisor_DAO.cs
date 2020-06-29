using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Supervisor_DAO : Base
    {
        public List<Supervisor> Db_Get_All_Supervisors()
        {
            string query = "SELECT LecturerID, teacherFirstName, teacherLastName FROM TEACHER AS T JOIN SUPERVISOR AS S " +
                "ON T.teacherId = S.LecturerID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        public void Db_Insert_Supervisor(int id)
        {
            string query = String.Format("INSERT INTO SUPERVISOR VALUES({0})", id);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Delete_Supervisor(Supervisor supervisor)
        {
            string query = String.Format("DELETE FROM SUPERVISOR WHERE LecturerID = {0}", supervisor.LecturerID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //for editing a supervisor
        public void Db_Update_Supervisor(Supervisor supervisor)
        {
            string query = String.Format("UPDATE TEACHER SET teacherFirstName = '{0}', teacherLastName = '{1}' FROM TEACHER AS T JOIN SUPERVISOR AS S ON T.teacherId = S.LecturerID WHERE T.teacherId = {2}"
                , supervisor.FirstName, supervisor.LastName, supervisor.LecturerID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor((int)dr["LecturerID"], dr["teacherFirstName"].ToString(), dr["teacherLastName"].ToString());
                supervisors.Add(supervisor);
            }
            return supervisors;
        }
    }
}
