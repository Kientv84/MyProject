using _20110376_TruongChiKien_StudentManagement.COURSE;
using _20110376_TruongChiKien_StudentManagement.SCORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.RESULT
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        COURSES course = new COURSES();
        My_DB mydb = new My_DB();

        public DataTable TaoBangThongKe()
        {
            SqlCommand command = new SqlCommand(" SELECT Tong.course_id, label, SLSV, SLSVPass, SLSVFail FROM(SELECT course_id, Count(student_id) as SLSV FROM dbo.score GROUP BY score.course_id) as Tong LEFT OUTER JOIN (SELECT course_id, Count(student_id) as SLSVPass FROM score WHERE student_score >= 5 GROUP BY score.course_id) as Pass ON Tong.course_id = Pass.course_id LEFT OUTER JOIN (SELECT course_id, Count(student_id) as SLSVFail FROM score WHERE student_score < 5 GROUP BY score.course_id) as Fail on Tong.course_id = Fail.course_id INNER JOIN course on Tong.course_id = course.id", mydb.getConnection);
            DataTable thongKeTable = score.getStudentScores(command);

            thongKeTable.Columns.Add("Result", typeof(string));
            int col = thongKeTable.Columns.Count;

            foreach (DataRow row in thongKeTable.Rows)
            {
                for (int i = 0; i < col; i++)
                {
                    if (row[i].ToString().Trim() == "")
                        row[i] = 0;
                }

                double tong = Convert.ToDouble(row["SLSV"]);
                double pass = Convert.ToDouble(row["SLSVPass"]);
                double fail = Convert.ToDouble(row["SLSVFail"]);

                if (pass > fail)
                    row["Result"] = "Pass";
                else
                    row["Result"] = "Fail";
                BieuDo.Series["Pass"].Points.AddXY(row["label"].ToString(), (pass / tong) * 100);
                BieuDo.Series["Fall"].Points.AddXY(row["label"].ToString(), (fail / tong) * 100);
                BieuDo.Series["Tong"].Points.AddXY(row["label"].ToString(), 100);
            }
            return thongKeTable;
        }
        
        

        private void StaticResult_Load(object sender, EventArgs e)
        {
            DataTable table = this.TaoBangThongKe();
            //this.dataGridView1.DataSource = table;

            foreach (DataRow row in table.Rows)
            {
                Label course = new Label();
                Label result = new Label();
                course.Text = row["label"].ToString();
                result.Text = row["result"].ToString();

                this.flowLayoutPanelCourse.Controls.Add(course);
                this.flowLayoutPanelResult.Controls.Add(result);
            }
        }
    }
}
