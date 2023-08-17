using _20110376_TruongChiKien_StudentManagement.COURSE;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110376_TruongChiKien_StudentManagement.SCORE
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        SCORES score = new SCORES();
        COURSES course = new COURSES();
        STUDENT.STUDENT student = new STUDENT.STUDENT();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudentList.DataSource = student.getStudents(new SqlCommand("SELECT id, fname, lname FROM std1"));

            dataGridViewScoreList.DataSource = score.getStudentsScore();
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.DisplayMember = "label";
            listBoxCourses.ValueMember = "id";
            dataGridViewScoreList.Columns[0].HeaderText = " ID";
            dataGridViewScoreList.Columns[1].HeaderText = "First name";
            dataGridViewScoreList.Columns[2].HeaderText = "Last name";
            dataGridViewScoreList.Columns[3].HeaderText = "Course ID";
            dataGridViewScoreList.Columns[4].HeaderText = "Label";
            dataGridViewScoreList.Columns[5].HeaderText = "Student score";
            dataGridViewStudentList.Columns[0].HeaderText = "ID";
            dataGridViewStudentList.Columns[1].HeaderText = "First name";
            dataGridViewStudentList.Columns[2].HeaderText = "Last name";



        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewScoreList.DataSource = score.getCourseScores(int.Parse(listBoxCourses.SelectedValue.ToString()));
        }

        //display the selected student scores
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridViewScoreList.DataSource = score.getCourseScores(int.Parse(dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString()));
        }

        //populate datagridview with all socres data
        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridViewScoreList.DataSource = score.getStudentsScore();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scores_list.txt";

            using (var writer = new StreamWriter(path))
            {
                //check if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //rows
                for (int i = 0; i < dataGridViewScoreList.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewScoreList.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridViewScoreList.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }

                    //make a new line
                    writer.WriteLine("");
                    //make a separation
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintDialog printDlg = new PrintDialog();
            //PrintDocument printDoc = new PrintDocument();
            //printDoc.DocumentName = "Print Document";
            //printDlg.Document = printDoc;
            //printDlg.AllowSelection = true;
            //printDlg.AllowSomePages = true;

            //if (printDlg.ShowDialog() == DialogResult.OK)
            //{
            //    printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            //    printDoc.Print();
            //}
            if (dataGridViewScoreList.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridViewScoreList, saveFileDialog1.FileName);
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
                                        + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                          list score\n";

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

        private void labelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridViewScoreList.DataSource = score.getStudentsScore();
        }


        //private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    DataGridView dgv = dataGridViewScoreList;

        //    // Thiết lập các thuộc tính in ấn của trang
        //    int x = e.MarginBounds.Left;
        //    int y = e.MarginBounds.Top;
        //    int cell_height = 0;
        //    int cell_width = 0;
        //    int colCount = dgv.Columns.Count;
        //    int rowCount = dgv.Rows.Count;

        //    // Tính tổng chiều cao của các dòng
        //    int totalRowHeight = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

        //    // In tiêu đề cột
        //    for (int i = 0; i < colCount; i++)
        //    {
        //        cell_width = dgv.Columns[i].Width;
        //        cell_height = dgv.Rows[0].Height;
        //        e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, cell_width, cell_height));
        //        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cell_width, cell_height));
        //        e.Graphics.DrawString(dgv.Columns[i].HeaderText, dgv.Font, Brushes.Black, new RectangleF(x, y, cell_width, cell_height));
        //        x += cell_width;
        //    }
        //    y += cell_height;

        //    // In dữ liệu từng dòng của DataGridView
        //    for (int j = 0; j < rowCount; j++)
        //    {
        //        x = e.MarginBounds.Left;
        //        cell_height = dgv.Rows[j].Height;
        //        for (int i = 0; i < colCount; i++)
        //        {
        //            cell_width = dgv.Columns[i].Width;
        //            object cellValue = dgv.Rows[j].Cells[i].Value;

        //            // Nếu là cột hình ảnh thì vẽ hình ảnh lên trang in

        //            if (dgv.Columns[i] is DataGridViewImageColumn && cellValue != null)
        //            {
        //                ImageConverter converter = new ImageConverter();
        //                Image img = (Image)converter.ConvertFrom(cellValue);

        //                dataGridViewScoreList.Rows[j].Cells[10].Value = img;

        //                //img = (Image)cellValue;
        //                //int imgWidth = img.Width;
        //                //int imgHeight = img.Height;

        //                // Thay đổi kích thước hình ảnh
        //                int maxWidth = cell_width; // Giảm 2 pixel để tránh vượt quá giới hạn ô
        //                int maxHeight = cell_height;

        //                img = img.GetThumbnailImage(maxWidth, maxHeight, null, IntPtr.Zero);
        //                Rectangle imgRect = new Rectangle(x, y, img.Width, img.Height);


        //                e.Graphics.DrawImage(img, imgRect);
        //            }
        //            else
        //            {
        //                string cellValueString = cellValue != null ? cellValue.ToString() : "";
        //                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cell_width, cell_height));
        //                e.Graphics.DrawString(cellValueString, dgv.Font, Brushes.Black, new RectangleF(x, y, cell_width, cell_height));
        //            }
        //            x += cell_width;
        //        }
        //        y += cell_height;

        //        // Kiểm tra nếu đang in vượt qua kích thước giấy thì chuyển sang trang mới
        //        if (y + cell_height > e.MarginBounds.Bottom)
        //        {
        //            e.HasMorePages = true;
        //            return;
        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scores_list.doc";

            using (var writer = new StreamWriter(path))
            {
                //check if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //rows
                for (int i = 0; i < dataGridViewScoreList.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewScoreList.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridViewScoreList.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }

                    //make a new line
                    writer.WriteLine("");
                    //make a separation
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }

        private void buttonPrinttxt_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scores_list.txt";

            using (var writer = new StreamWriter(path))
            {
                //check if the file exists
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //rows
                for (int i = 0; i < dataGridViewScoreList.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewScoreList.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridViewScoreList.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }

                    //make a new line
                    writer.WriteLine("");
                    //make a separation
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }

        private void listBoxCourses_Click_1(object sender, EventArgs e)
        {
            dataGridViewScoreList.DataSource = score.getCourseScores(int.Parse(listBoxCourses.SelectedValue.ToString()));
        }
    }
}