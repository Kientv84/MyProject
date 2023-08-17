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

namespace _20110376_TruongChiKien_StudentManagement.HumanResource
{
    public partial class ListStudentCourseForm : Form
    {
        public ListStudentCourseForm()
        {
            InitializeComponent();
        }
        STUDENT.STUDENT student = new STUDENT.STUDENT();
        SCORES score = new SCORES();
        COURSES course = new COURSES();
        public static int key = 0;
        public void reloadListBoxData(int teacherid)
        {
            key = teacherid;
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE teacherId = " + teacherid);
            this.listBoxCourse.DataSource = course.getAll1Coursess(command);
            this.listBoxCourse.ValueMember = "id";
            this.listBoxCourse.DisplayMember = "Label";
            this.listBoxCourse.SelectedItem = null;
        }
        public void loadDataGridView(SqlCommand command)
        {
            this.dataGridViewListContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewListContact.RowTemplate.Height = 80;
            this.dataGridViewListContact.DataSource = student.getStudents(command);
            picol = (DataGridViewImageColumn)dataGridViewListContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewListContact.AllowUserToAddRows = false;

            for (int i = 0; i < this.dataGridViewListContact.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    this.dataGridViewListContact.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void ListStudentCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as N'ID',lname as N'Last Name', fname as N'Fist Name', bdate as N'BirthDay', gender as N'Gender', phone as N'Phone', address as N'Address', picture as N'Picture' FROM std1 WHERE 'selectCourse' LIKE '%" + key + "%'");
            this.loadDataGridView(command);
            dataGridViewListContact.ReadOnly = true;
            dataGridViewListContact.AllowUserToAddRows = false;
        }

        private System.Drawing.Image ConvertToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }

        private void printToWord_btn_Click(object sender, EventArgs e)
        {
            /*// Tạo đường dẫn đến word
           _Application oWord = new Microsoft.Office.Interop.Word.Application();
           //Tạo một Document
           _Document wordDoc = oWord.Documents.Add();
           int ColumnCount = dataGridViewListContact.Columns.Count;
           int RowCount = dataGridViewListContact.Rows.Count;
           object missing = System.Reflection.Missing.Value;
           Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
           string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
               + DateTime.Today.Year.ToString("0000");
           foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
           {
               //Get the header range and add the header details.
               Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
               headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
               headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
               para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
               para1.Range.Font.Bold = 2;        // Độ Đậm Chữ
               para1.Range.Font.Size = 14;
               para1.Range.Text = "Trường Đại Học Sư Phạm Kỹ Thuật Tp Hồ Chí Minh\n" + time
                               + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                          Course Semester\n";
               para1.Range.Text = "Người thực hiện:";
               para1.Range.Font.Size = 12;
               para1.Range.Bold = 0;
               para1.Range.Underline = 0;
               para1.Range.Font.Name = "Times New Roman";
               para1.Range.InsertParagraphAfter();

               para1.Range.Text = "Họ và tên: Triệu Phúc Định";
               para1.Range.Font.Size = 12;
               para1.Range.Bold = 0;
               para1.Range.Underline = 0;
               para1.Range.Font.Name = "Times New Roman";
               para1.Range.InsertParagraphAfter();

               para1.Range.Text = "MSSV: 20110362";
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

           // Tạo bảng danh sách sinh viên
           Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewListContact.Rows.Count + 1, dataGridViewListContact.Columns.Count, ref missing, ref missing);
           //Xuất hiện khung table
           tableST.Borders.Enable = 1;
           Object oMissing = System.Reflection.Missing.Value;
           for (int c = 0; c <= ColumnCount - 1; c++)
           {

               tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewListContact.Columns[c].HeaderText;
               tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
               tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;


           }
           for (int r = 0; r <= RowCount - 1; r++)
           {
               for (int k = 0; k <= ColumnCount - 1; k++)
               { 
                 //  if (tableST.Rows[r].Cells[k]. )
               }
           }
           for (int i = 2; i <= tableST.Rows.Count; i++)
           {

               for (int j = 1; j < tableST.Columns.Count + 1; j++)
               {

                   //Lưu text
                   //Image pic = this.ConvertToImage((Byte[])Rows[i].Cells[7].Value);

                   tableST.Rows[i].Cells[j].Range.Text = dataGridViewListContact.Rows[i - 2].Cells[j - 1].Value.ToString();
                   //tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                   tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                   //tableST.Rows[i].Cells[6].Range.Text = ConvertToImage((Byte[])dataGridViewListContact.Rows[i - 2].Cells[5].Value);

               }


           }
           // Lưu thông tin 
           object filename = @"C:\Users\Admin\OneDrive\Desktop\lecturer-student.doc";
           wordDoc.SaveAs2(ref filename);
           wordDoc.Close();
           oWord.Quit();
           MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);*/
            if (dataGridViewListContact.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridViewListContact, saveFileDialog1.FileName);
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
            //}
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
                                        + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                                list course\n";

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
                    for (int i = 0; i < DGV.ColumnCount ; i++)
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

        private void listBoxCourse_Click_1(object sender, EventArgs e)
        {
            dataGridViewListContact.DataSource = score.getStudentScore(int.Parse(listBoxCourse.SelectedValue.ToString()));
        }
    }
}
