using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT studentNumber, studentFirstName, studentLastName FROM STUDENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student
                {
                    Number = (int)dr["studentNumber"],
                    FirstName = dr["studentFirstName"].ToString(),
                    LastName = dr["studentLastName"].ToString(),
                    FullName = dr["studentFirstName"].ToString() + " " + dr["studentLastName"].ToString(),
                };
                students.Add(student);
            }
            return students;
        }

    }
}
