using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;

namespace UniversityApp.DLL.GATEWAY
{
    class CourseGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        public CourseGateway()
        {
            string conn = ConfigurationManager.ConnectionStrings["UniversityPractice"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string Save(Course aCourse)
        {
            connection.Open();

            query = string.Format("INSERT INTO t_Course VALUES ('{0}', '{1}', '{2}')", aCourse.Code, aCourse.Name, aCourse.Credit);

            command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();

            if (affectedRows > 0)
            {
                return "Insert success";
            }
            else
            {
                return "Some problem happened";
            }
        }

        public List<Course> GetAllCoursesList()
        {
            connection.Open();

            query = string.Format("SELECT * FROM t_Course");
            command = new SqlCommand(query,connection);

            SqlDataReader aReader = command.ExecuteReader();
            List<Course> courseList = new List<Course>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.Code = aReader[0].ToString();
                    aCourse.Name = aReader[1].ToString();
                    aCourse.Credit = aReader[2].ToString();
                    courseList.Add(aCourse);
                }
            }
            connection.Close();
            return courseList;

        }
    }
}
