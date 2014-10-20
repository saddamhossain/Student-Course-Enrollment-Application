﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;

namespace UniversityApp.DLL.GATEWAY
{
    class StudentGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;
        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["UniversityPractice"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = conn;

        }

        public string Save(Student aStudent)
        {
            CallForConnection();
            connection.Open();

            query = string.Format("INSERT INTO t_Student VALUES ('{0}', '{1}', '{2}')", aStudent.RegNo, aStudent.Email, aStudent.Address);

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
    }
}
