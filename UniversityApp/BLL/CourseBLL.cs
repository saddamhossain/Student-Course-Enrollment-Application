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
            string msg =  aCourseGateway.Save(aCourse);
            return msg;
        }
    }
}
