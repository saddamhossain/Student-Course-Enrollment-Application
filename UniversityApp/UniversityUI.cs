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
        }

        private void courseSaveButton_Click(object sender, System.EventArgs e)
        {
            aCourse = new Course();
            codeCourseTextBox.Text = aCourse.Code;
            nameCourseTextBox.Text = aCourse.Name;
            creditCourseTextBox.Text = aCourse.Credit;
             
            aCourseBll = new CourseBLL();
            string msg =  aCourseBll.Save(aCourse);
            MessageBox.Show(msg);


        }

        private void studentSaveButton_Click(object sender, System.EventArgs e)
        {
            aStudent = new Student();
            studentRegNoTextBox.Text = aStudent.RegNo;
            emailStudentTextBox.Text = aStudent.Email;
            addressStudentTextBox.Text = aStudent.Address;

            aStudentBll = new StudentBLL();
            string msg = aStudentBll.Save(aStudent);
        }
    }
}
