using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using SautinSoft;
using Spire.Doc;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class FileOper
        {
            public void write(string x, string y)
            {
                StreamWriter sw = new StreamWriter(x);
                sw.Write(y);
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            if (OF.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = OF.FileName;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "PDF Filters(*.pdf)|*.pdf";
            if (OF.ShowDialog() == DialogResult.OK)
            {
                string path = OF.FileName.ToString();
                textBox1.Text = path;
            }
        }
      
        private void btnShowtxt_Click(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(textBox1.Text);
            string val = SR.ReadToEnd();
            richTextBox1.Text = val;
            SR.Close();
        }

        private void btnShowPDF_Click(object sender, EventArgs e)
        {
            PDDocument PDF = PDDocument.load(textBox1.Text);
            PDFTextStripper stripper = new PDFTextStripper();
            richTextBox1.Text = (stripper.getText(PDF));
        }
              
        private void btnConvertRTF_Click(object sender, EventArgs e) // PDF convert to RTF Function
        {
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF File|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnConvertJPG_Click(object sender, EventArgs e) // PDF convert to Image Function
        {
            SautinSoft.PdfFocus JPG = new SautinSoft.PdfFocus(); // 呼叫SautinSoft中的Image Convert Function
            JPG.OpenPdf(textBox1.Text);

            if (JPG.PageCount > 0)
            {
                JPG.ImageOptions.Dpi = 200;
                JPG.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                for (int page = 1; page <= JPG.PageCount; page++)
                    JPG.ToImage(textBox1.Text + "page" + page + ".jpg", page);
            }
        }

        private void btnConvertPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document.LoadFromFile(textBox1.Text);
            document.SaveToFile("result.PDF", FileFormat.PDF);
            System.Diagnostics.Process.Start("result.PDF");
        }

        private void btnPDF2Doc_Click(object sender, EventArgs e) // PDF convert to Doc Function
        {
            SautinSoft.PdfFocus doc = new SautinSoft.PdfFocus();  // 呼叫SautinSoft中的Doc Convert Function
            doc.OpenPdf(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\測試用文檔\Graph.pdf");
            doc.ToWord(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\NewGraph.docx");
        }

        private void btnPDF2Excel_Click(object sender, EventArgs e) // PDF convert to Excel Function
        {
            SautinSoft.PdfFocus excel = new SautinSoft.PdfFocus();  // 呼叫SautinSoft中的Excel Convert Function
            excel.OpenPdf(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\測試用文檔\Order.pdf");
            excel.ToExcel(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\NewOrder.xls");
        }

        private void btnPDF2Html_Click(object sender, EventArgs e) // PDF convert to Html Function
        {
            SautinSoft.PdfFocus Html = new SautinSoft.PdfFocus();  // 呼叫SautinSoft中的Html Convert Function
            Html.OpenPdf(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\測試用文檔\Graph.pdf");

            if (Html.PageCount > 0)
            {
                int result = Html.ToHtml(@"C:\Users\施宗佑\OneDrive\桌面\期末報告 - 物件導向程式設計\NewGraph.html");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FileOper FO = new FileOper();
                FO.write(textBox1.Text, richTextBox1.Text);
            }
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }      
    }     
}
