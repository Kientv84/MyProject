using _20110376_TruongChiKien_StudentManagement.COURSE;
using _20110376_TruongChiKien_StudentManagement.HumanResource;
using _20110376_TruongChiKien_StudentManagement.RESULT;
using _20110376_TruongChiKien_StudentManagement.SCORE;
using _20110376_TruongChiKien_StudentManagement.STUDENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static string nameLogin;
        public static string roleLogin;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (nameLogin == "admin") aDMINToolStripMenuItem.Enabled = true;
            else aDMINToolStripMenuItem.Enabled = false;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            address addStdF = new address();
            addStdF.Show(this);
        }


        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENT.studentListForm StdLis = new STUDENT.studentListForm();
            StdLis.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENT.UpdateDeleteStudentForm upDelSTDF = new STUDENT.UpdateDeleteStudentForm();
            upDelSTDF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StdSF = new StaticsForm();
            StdSF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nè h muốn gói Form MângeStudentForm nhé , thì form đấy nằm trong package STUDENT . Vậy thì gọi tên package trc
            STUDENT.ManageStudentForm mng = new STUDENT.ManageStudentForm();
            mng.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm PrStdF = new PrintStudentsForm();
            PrStdF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COURSE.AddCourseForm addCourse = new COURSE.AddCourseForm();
            addCourse.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rmCourse = new RemoveCourseForm();
            rmCourse.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm edCourse = new EditCourseForm();
            edCourse.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm mngCrsF = new ManageCourseForm();
            mngCrsF.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addCrsFr = new AddScoreForm();
            addCrsFr.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm reSrFr = new RemoveScoreForm();
            reSrFr.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm mnSrFr = new ManageScoreForm();
            mnSrFr.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScrByCrsF = new avgScoreByCourseForm();
            avgScrByCrsF.Show(this);
        }

        private void studentListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            STUDENT.studentListForm stdlist = new STUDENT.studentListForm();
            stdlist.Show(this);
        }

        private void staticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            STUDENT.StaticsForm st = new STUDENT.StaticsForm();
            st.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            STUDENT.ManageStudentForm mng = new STUDENT.ManageStudentForm();
            mng.Show(this);
        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            STUDENT.PrintStudentsForm frintstd = new STUDENT.PrintStudentsForm();
            frintstd.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            STUDENT.UpdateDeleteStudentForm upDelSTDF = new STUDENT.UpdateDeleteStudentForm();
            upDelSTDF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            COURSE.AddCourseForm addcourse = new COURSE.AddCourseForm();
            addcourse.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            COURSE.RemoveCourseForm rmvcourse = new COURSE.RemoveCourseForm();
            rmvcourse.Show(this);
        }

        private void editCourseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            COURSE.EditCourseForm editcourse = new COURSE.EditCourseForm();
            editcourse.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            COURSE.ManageCourseForm mngcourse = new COURSE.ManageCourseForm();
            mngcourse.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            COURSE.PrintCoursesForm printcourese = new COURSE.PrintCoursesForm();
            printcourese.Show(this);
        }

        private void addScoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SCORE.AddScoreForm addscore = new SCORE.AddScoreForm();
            addscore.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SCORE.RemoveScoreForm removescore = new SCORE.RemoveScoreForm();
            removescore.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SCORE.ManageScoreForm mngscore = new SCORE.ManageScoreForm();
            mngscore.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SCORE.avgScoreByCourseForm avgbyscore = new avgScoreByCourseForm();
            avgbyscore.Show(this);
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCORE.PrintScoreForm prtscore = new SCORE.PrintScoreForm();
            prtscore.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultScoreForm avgresultbyscore = new ResultScoreForm();
            avgresultbyscore.Show(this);
        }

        private void listAcountRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccountRegister lar = new ListAccountRegister();
            lar.Show(this);
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResult stResult = new StaticResult();
            stResult.Show(this);

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            if(roleLogin != "ADMIN")
            {
                aDMINToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listAccountRegisterHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAccountRegisterHR listHR = new ListAccountRegisterHR();
            listHR.Show(this);
        }
    }
}
