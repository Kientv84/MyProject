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
using Rectangle = System.Drawing.Rectangle;

namespace _20110376_TruongChiKien_StudentManagement.STUDENT
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            // Dem sinh vien

        }
        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet3.std1' table. You can move, or remove it, as needed.
            this.std1TableAdapter.Fill(this.qlsvDataSet3.std1);
            fillGrid(new SqlCommand("SELECT * FROM std1"));

            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

      


        
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dgv = dataGridView1;

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
                //    DateTime bdate;
                x = e.MarginBounds.Left;
                cell_height = dgv.Rows[j].Height;
                DateTime bdate;
                for (int i = 0; i < colCount; i++)
                {
                    cell_width = dgv.Columns[i].Width;
                    object cellValue = dgv.Rows[j].Cells[i].Value;
                    if (i == 3)
                    {
                        bdate = Convert.ToDateTime(dataGridView1.Rows[j].Cells[i].Value.ToString());
                        cellValue = bdate.ToString("dd-MM-yyyy");
                    }


                    // Nếu là cột hình ảnh thì vẽ hình ảnh lên trang in

                    if (dgv.Columns[i] is DataGridViewImageColumn && cellValue != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        Image img = (Image)converter.ConvertFrom(cellValue);

                        dataGridView1.Rows[j].Cells[11].Value = img;

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
                                        + "\nMôn: Lập trình trên Windows\n\t\t                       Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n                                                          student list\n";

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



        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridView1, saveFileDialog1.FileName);
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

        private void radioButtonYes_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std1 WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + "'AND'" + date2 + "'";

                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std1 WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + "'AND'" + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM std1 WHERE bdate BETWEEN'" + date1 + "'AND'" + date2 + "'";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std1 WHERE gender ='Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std1 WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std1";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
                printDoc.Print();
            }
        }

        private void buttonPrintDoc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord(dataGridView1, saveFileDialog1.FileName);
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {

            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;

                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if (j == dataGridView1.Columns.Count - 2)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                            }
                            else
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }

                        }
                        writer.WriteLine("");
                        writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //MessageBox.Show("Save To Text File Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";

            //using (var writer = new StreamWriter(path))
            //{
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //    }
            //    DateTime bdate;

            //    for (int i = 0; i < DataGridViewPrintStudent.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < DataGridViewPrintStudent.Columns.Count ; j++)
            //        {
            //            if (j == 3)
            //            {
            //                bdate = Convert.ToDateTime(DataGridViewPrintStudent.Rows[i].Cells[j].Value.ToString());
            //                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
            //            }
            //            else if (j == DataGridViewPrintStudent.Columns.Count - 2)
            //            {
            //                writer.Write("\t" + DataGridViewPrintStudent.Rows[i].Cells[j].Value.ToString() + "\t");
            //            }
            //            else
            //            {
            //                writer.Write("\t" + DataGridViewPrintStudent.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //            }
            //        }
            //        writer.WriteLine("");
            //        writer.WriteLine("-----------------------------------------------------------------------------------------------------------");
            //    }

            //    writer.Close();
            //    MessageBox.Show("Data Exported");
            //}
        }

        
    }
}
