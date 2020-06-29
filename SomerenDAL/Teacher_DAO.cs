using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Teacher_DAO : Base
    {
        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "SELECT teacherId, teacherFirstName, teacherLastName FROM TEACHER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher(dr["teacherFirstName"].ToString(), dr["teacherLastname"].ToString(), (int)dr["teacherId"]);
                teachers.Add(teacher);
            }
            return teachers;
        }

        //this is part of variant B from assignment 4
        //this is part of variant B from assignment 4

        //this will select all teachers that are not a supervisor
        public List<Teacher> Db_Get_Teachers_Not_Supervisor()
        {
            string query = "SELECT T.teacherId, T.teacherFirstName,T.teacherLastName FROM TEACHER AS T " +
                "LEFT JOIN SUPERVISOR AS S ON T.teacherId = S.LecturerID " +
                "WHERE S.LecturerID IS NULL";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


    }
}
