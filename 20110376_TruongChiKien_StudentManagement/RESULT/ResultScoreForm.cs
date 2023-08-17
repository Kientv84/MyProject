using _20110376_TruongChiKien_StudentManagement.COURSE;
using _20110376_TruongChiKien_StudentManagement.SCORE;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace _20110376_TruongChiKien_StudentManagement.RESULT
{
    public partial class ResultScoreForm : Form
    {
        public ResultScoreForm()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        COURSES course = new COURSES();
        My_DB mydb = new My_DB();
        private void ResultScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand commandStd = new SqlCommand(" SELECT id , fname as FirstName,lname as LastName FROM std1", mydb.getConnection);
            this.dataGridViewScore.DataSource = this.showData(commandStd);
            dataGridViewScore.AllowUserToAddRows = false;
            dataGridViewScore.ReadOnly = true;
        }

        public DataTable showData(SqlCommand command)
        {

            //---------TAO CAU TRUC BANG--------------//

            //Bang loc student
            SqlDataAdapter adapterStd = new SqlDataAdapter(command);
            DataTable tableStd = new DataTable();
            adapterStd.Fill(tableStd);

            //Tạo table2 để lấy dữ liệu của lable để add thêm vào cột của table
            SqlCommand commandLabel = new SqlCommand("SELECT label FROM course", mydb.getConnection);
            SqlDataAdapter adapterLabel = new SqlDataAdapter(commandLabel);
            DataTable tableLabel = new DataTable();
            adapterLabel.Fill(tableLabel);


            foreach (DataRow rowLabel in tableLabel.Rows)
            {
                string name = rowLabel[0].ToString();
                tableStd.Columns.Add(name, typeof(string));
            }

            tableStd.Columns.Add("AverageScore", typeof(string));
            tableStd.Columns.Add("Result", typeof(string));
            dataGridViewScore.DataSource = tableStd;


            //----THEM THONG TIN BANG ------//

            // Lay Bang Diem cua moi sinh vien
            SqlCommand commandScore = new SqlCommand("SELECT * FROM score, (SELECT student_id, avg(student_score) as AverageScore FROM score GROUP BY(student_id)) as AVGtable, course WHERE score.student_id= AVGtable.student_id and course.id = score.course_id", mydb.getConnection);
            SqlDataAdapter adapterScore = new SqlDataAdapter(commandScore);
            DataTable tableScore = new DataTable();
            adapterScore.Fill(tableScore);

            foreach (DataRow rowStd in tableStd.Rows)
            {
                foreach (DataRow rowScore in tableScore.Rows)
                {
                    if (rowStd["Id"].ToString().Trim() == rowScore["student_id"].ToString().Trim())
                    {
                        string tmp = rowScore["label"].ToString();
                        rowStd[tmp] = rowScore["student_score"];
                        rowStd["AverageScore"] = rowScore["AverageScore"];
                    }
                }

                if (rowStd["AverageScore"].ToString().Trim() != "")
                {
                    if (Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) >= 5 && Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) < 6)
                    {
                        rowStd["Result"] = "Average";
                    }
                    else if (Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) >= 6 && Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) < 7)
                    {
                        rowStd["Result"] = "Fairly good";
                    }
                    else if (Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) >= 7 && Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) < 8)
                    {
                        rowStd["Result"] = "Good";
                    }
                    else if (Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) >= 8)
                    {
                        rowStd["Result"] = "Excellent";
                    }
                    else
                    {
                        rowStd["Result"] = "Below Avenrage";
                    }

                }
            }

            int col = tableStd.Columns.Count;
            foreach (DataRow rowStd in tableStd.Rows)
            {
                for (int i = 0; i < col; i++)
                {
                    if (rowStd[i].ToString().Trim() == "")
                        rowStd[i] = "Not study!";
                }
            }
            return tableStd;

        }

        private void dataGridViewScore_Click(object sender, EventArgs e)
        {
            //StudentResultScoreForm UpdateDeleteform = new StudentResultScoreForm();
            //UpdateDeleteform.id_text.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            //UpdateDeleteform.fname_text.Text = dataGridViewScore.CurrentRow.Cells[1].Value.ToString();
            //UpdateDeleteform.lname_text.Text = dataGridViewScore.CurrentRow.Cells[2].Value.ToString();
            //UpdateDeleteform.Show();
            textBoxSudentID.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewScore.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewScore.CurrentRow.Cells[2].Value.ToString();
        }
        int plag = 0;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string key = this.textBoxSearch.Text;
            SqlCommand command = new SqlCommand(" SELECT id,fname as FirstName ,lname as LastName FROM std1 WHERE CONCAT(fname,id,lname) LIKE '%" + key + "%'", mydb.getConnection);
            this.dataGridViewScore.DataSource = this.showData(command);
            dataGridViewScore.AllowUserToAddRows = false;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";
            //using (var writer = new StreamWriter(path))
            //{
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //    }

            //    DateTime bdate;

            //    for (int i = 0; i < dataGridViewScore.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridViewScore.Columns.Count - 1; j++)
            //        {
            //            if (j == 3)
            //            {
            //                bdate = Convert.ToDateTime(dataGridViewScore.Rows[i].Cells[j].Value.ToString());
            //                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
            //            }
            //            else if (j == dataGridViewScore.Columns.Count - 2)
            //            {
            //                writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString());
            //            }
            //            else
            //            {
            //                writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //            }
            //        }
            //        writer.WriteLine("");
            //        writer.WriteLine("-------------------------------------------------------------------------------------");
            //    }
            //}

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\re.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                //rows
                try
                {
                    writer.Write("\t" + "Student id " + "     |          Firstname    |          Lastname     |   C++    |      PHP   |      CDG    |      GoLang    |      Ruby    |      Physical    |      Avenrage Score    |         Result          |    ");
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    for (int i = 0; i < dataGridViewScore.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewScore.Columns.Count; j++)

                        {
                            writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");


                        }
                        writer.WriteLine("");
                        writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        public void exportDataToWord(DataGridView DGV, string filename)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    // Tạo đường dẫn đến word
                    _Application oWord = new Microsoft.Office.Interop.Word.Application();
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;
                    _Document wordDoc = oWord.Documents.Add();
                    //Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                    wordDoc.Application.Visible = true;
                    wordDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
                    string oTemp = "";
                    // var table = wordDoc.Tables.Add(wordDoc.Range(), DGV.RowCount + 1, DGV.ColumnCount);
                    // Đặt định dạng cho bảng
                    //table.Borders.Enable = 1;
                    //     table.AllowAutoFit = true;
                    //     table.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow);
                    //     Object oMissing = System.Reflection.Missing.Value;
                    //header text
                    object missing = System.Reflection.Missing.Value;
                    Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
                    string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                        + DateTime.Today.Year.ToString("0000");
                    foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
                    {
                        /*Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "COURSE STUDENT LIST\n";
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
*/
                        //Get the header range and add the header details.
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                        para1.Range.Font.Bold = 1;        // Độ Đậm Chữ
                        para1.Range.Font.Size = 14;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.Text = "Trường Đại Học Sư Phạm Kỹ Thuật Tp Hồ Chí Minh\n" + time
                                        + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                                                                                      Result scores\n";

                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "Người thực hiện:";
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "Họ và tên: Trương Chí Kiên";
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        para1.Range.Text = "MSSV: 20110376";
                        para1.Range.Font.Size = 12;
                        para1.Range.Bold = 0;
                        para1.Range.Underline = 0;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.InsertParagraphAfter();

                        Microsoft.Office.Interop.Word.Range footersRange = section.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        para1.Range.Fields.Add(footersRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                        para1.Range.Font.Bold = 2;        // Độ Đậm Chữ
                        para1.Range.Font.Size = 14;
                        para1.Range.Font.Name = "Times New Roman";
                        para1.Range.Text = "TP.HCM, " + time;


                        section.Borders.Enable = 1;
                        section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                        section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                        section.Borders.OutsideColor = WdColor.wdColorBlack;

                    }
                    Table table = wordDoc.Tables.Add(para1.Range, DGV.Rows.Count + 1, DGV.Columns.Count, ref missing, ref missing);
                    // Table table = wordDoc.Tables.Add(wordDoc.Range(), DGV.RowCount + 1, DGV.ColumnCount);
                    table.Borders.Enable = 1;
                    // Thêm tên cột cho bảng
                    var headerRow = table.Rows[1];
                    for (int i = 0; i < DGV.ColumnCount; i++)
                    {
                        headerRow.Cells[i + 1].Range.Text = DGV.Columns[i].HeaderText;
                    }

                    // Thêm dữ liệu từ DataGridView vào bảng
                    for (int r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c < ColumnCount; c++)
                        {

                            if (DGV.Rows[r].Cells[c].Value != null)
                            {
                                // Check ở cột Có tên là Birth Date thì không in ra giờ 
                                if (DGV.Columns[c].HeaderText == "Birthday")
                                {
                                    DateTime dt = (DateTime)DGV.Rows[r].Cells[c].Value;
                                    string Bdate = dt.ToString("dd/MM/yyyy");
                                    table.Cell(r + 2, c + 1).Range.InsertAfter(Bdate);
                                }

                                // Nếu tên cột là "Picture", chèn hình ảnh vào ô tương ứng


                                /*Để chèn hình ảnh vào ô tương ứng nếu tên cột là "Picture", 
                                    sử dụng câu lệnh kiểm tra if (DGV.Columns[c].HeaderText == "Picture"), 
                                        và chèn hình ảnh vào bằng cách sử dụng đoạn mã tương tự như trong đoạn mã ban đầu.*/

                                else if (DGV.Columns[c].HeaderText == "Picture")
                                {
                                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[c].Value;
                                    if (imgbyte != null)
                                    {
                                        MemoryStream ms = new MemoryStream(imgbyte);
                                        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                                        Clipboard.SetDataObject(finalPic);
                                        table.Cell(r + 2, c + 1).Range.Paste();
                                    }
                                }
                                else
                                {
                                    table.Cell(r + 2, c + 1).Range.Text = DGV.Rows[r].Cells[c].Value.ToString();
                                }
                            }
                            else
                            {
                                table.Cell(r + 2, c + 1).Range.Text = "";
                            }



                        }
                    }

                    // Lưu tài liệu Word
                    wordDoc.SaveAs2(filename);
                }
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string key = this.textBoxSearch.Text;
            SqlCommand command = new SqlCommand(" SELECT id,fname as FirstName ,lname as LastName FROM std1 WHERE CONCAT(fname,id,lname) LIKE '%" + key + "%'", mydb.getConnection);
            this.dataGridViewScore.DataSource = this.showData(command);
            dataGridViewScore.AllowUserToAddRows = false;
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";
            //using (var writer = new StreamWriter(path))
            //{
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //    }

            //    DateTime bdate;

            //    for (int i = 0; i < dataGridViewScore.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridViewScore.Columns.Count - 1; j++)
            //        {
            //            if (j == 3)
            //            {
            //                bdate = Convert.ToDateTime(dataGridViewScore.Rows[i].Cells[j].Value.ToString());
            //                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
            //            }
            //            else if (j == dataGridViewScore.Columns.Count - 2)
            //            {
            //                writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString());
            //            }
            //            else
            //            {
            //                writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //            }
            //        }
            //        writer.WriteLine("");
            //        writer.WriteLine("-------------------------------------------------------------------------------------");
            //    }
            //}

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\re.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                //rows
                try
                {
                    writer.Write("\t" + "Student id " + "     |          Firstname    |          Lastname     |   C++    |      PHP   |      CDG    |      GoLang    |      Ruby    |      Physical    |      Avenrage Score    |         Result          |    ");
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    for (int i = 0; i < dataGridViewScore.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewScore.Columns.Count; j++)

                        {
                            writer.Write("\t" + dataGridViewScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");


                        }
                        writer.WriteLine("");
                        writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Printer_btn_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewScore.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridViewScore, saveFileDialog1.FileName);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Notification");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification");
            }
        }

        private void dataGridViewScore_Click_1(object sender, EventArgs e)
        {
            //StudentResultScoreForm UpdateDeleteform = new StudentResultScoreForm();
            //UpdateDeleteform.id_text.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            //UpdateDeleteform.fname_text.Text = dataGridViewScore.CurrentRow.Cells[1].Value.ToString();
            //UpdateDeleteform.lname_text.Text = dataGridViewScore.CurrentRow.Cells[2].Value.ToString();
            //UpdateDeleteform.Show();
            textBoxSudentID.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewScore.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewScore.CurrentRow.Cells[2].Value.ToString();
        }


        /*private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dgv = dataGridViewScore;

            // Thiết lập các thuộc tính in ấn của trang
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int cell_height = 0;
            int cell_width = 0;
            int colCount = dgv.Columns.Count;
            int rowCount = dgv.Rows.Count;

            // Tính tổng chiều cao của các dòng
            int totalRowHeight = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            // In tiêu đề cột
            for (int i = 0; i < colCount; i++)
            {
                cell_width = dgv.Columns[i].Width;
                cell_height = dgv.Rows[0].Height;
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, cell_width, cell_height));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cell_width, cell_height));
                e.Graphics.DrawString(dgv.Columns[i].HeaderText, dgv.Font, Brushes.Black, new RectangleF(x, y, cell_width, cell_height));
                x += cell_width;
            }
            y += cell_height;

            // In dữ liệu từng dòng của DataGridView
            for (int j = 0; j < rowCount; j++)
            {
                x = e.MarginBounds.Left;
                cell_height = dgv.Rows[j].Height;
                for (int i = 0; i < colCount; i++)
                {
                    cell_width = dgv.Columns[i].Width;
                    object cellValue = dgv.Rows[j].Cells[i].Value;

                    // Nếu là cột hình ảnh thì vẽ hình ảnh lên trang in

                    if (dgv.Columns[i] is DataGridViewImageColumn && cellValue != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        Image img = (Image)converter.ConvertFrom(cellValue);

                        dataGridViewScore.Rows[j].Cells[10].Value = img;

                        //img = (Image)cellValue;
                        //int imgWidth = img.Width;
                        //int imgHeight = img.Height;

                        // Thay đổi kích thước hình ảnh
                        int maxWidth = cell_width; // Giảm 2 pixel để tránh vượt quá giới hạn ô
                        int maxHeight = cell_height;

                        img = img.GetThumbnailImage(maxWidth, maxHeight, null, IntPtr.Zero);
                        Rectangle imgRect = new Rectangle(x, y, img.Width, img.Height);


                        e.Graphics.DrawImage(img, imgRect);
                    }
                    else
                    {
                        string cellValueString = cellValue != null ? cellValue.ToString() : "";
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cell_width, cell_height));
                        e.Graphics.DrawString(cellValueString, dgv.Font, Brushes.Black, new RectangleF(x, y, cell_width, cell_height));
                    }
                    x += cell_width;
                }
                y += cell_height;

                // Kiểm tra nếu đang in vượt qua kích thước giấy thì chuyển sang trang mới
                if (y + cell_height > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }*/


    }
}

