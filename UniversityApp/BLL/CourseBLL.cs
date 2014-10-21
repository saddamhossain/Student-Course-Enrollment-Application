using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DLL.DAO;
using UniversityApp.DLL.GATEWAY;

namespace UniversityApp.BLL
{
    class CourseBLL
    {
        private CourseGateway aCourseGateway;


        public string Save(Course aCourse)
        {
            aCourseGateway = new CourseGateway();
            return  aCourseGateway.Save(aCourse);
            
        }

        public List<Course> GetCourseNameList()
        {
            List<Course> aCoursesList = aCourseGateway.GetAllCoursesList();
            return aCoursesList;
        }

        public List<Student> GetStudentRegNo()
        {
            List<Student> aStudentsRegList = StudentGateway.GetAllRegNoList();
            return aStudentsRegList;
        }
    }
}
