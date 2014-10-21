using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;
using UniversityApp.DLL.GATEWAY;

namespace UniversityApp.BLL
{
    class StudentBLL
    {
        private StudentGateway aStudentGateway;


        public string Save(Student aStudent)
        {
            aStudentGateway = new StudentGateway();
            return aStudentGateway.Save(aStudent);
           
        }
    }
}
