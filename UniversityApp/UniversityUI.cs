using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DLL.DAO;

namespace UniversityApp
{
    public partial class UniversityUI : Form
    {
        private Course aCourse;
        private CourseBLL aCourseBll;
        private Student aStudent;
        private StudentBLL aStudentBll;

        public UniversityUI()
        {
            InitializeComponent();
          //  ShowCourseComboBox();
          //  ShowStudentRegNoComboBox();
            
        }



        private void ShowCourseComboBox()
        {
            aCourseBll = new CourseBLL();
            List<Course> nameCoursesList = aCourseBll.GetCourseNameList();

            foreach (Course course in nameCoursesList)
            {
                courseNameComboBox.Items.Add(course);
            }
            courseNameComboBox.DisplayMember = "Name";

        }

        private void ShowStudentRegNoComboBox()
        {
            aCourseBll = new CourseBLL();
            List<Student> aStudentsList = aCourseBll.GetStudentRegNo();

            foreach (Student aStudent in aStudentsList)
            {
                studentRegNoComboBox.Items.Add(aStudent);
            }
            studentRegNoComboBox.DisplayMember = "RegNo";
        }






        private void courseSaveButton_Click(object sender, System.EventArgs e)
        {
            aCourse = new Course();

            aCourse.Code = codeCourseTextBox.Text;
            aCourse.Name = nameCourseTextBox.Text;
            aCourse.Credit = creditCourseTextBox.Text;

            aCourseBll = new CourseBLL();
            string msg =  aCourseBll.Save(aCourse);
            MessageBox.Show(msg);
        }

        private void studentSaveButton_Click(object sender, System.EventArgs e)
        {
            aStudent = new Student();
            aStudent.RegNo = studentRegNoTextBox.Text;
            aStudent.Email = emailStudentTextBox.Text;
            aStudent.Address = addressStudentTextBox.Text;

            aStudentBll = new StudentBLL();
            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
        }
    }
}
