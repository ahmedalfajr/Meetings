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
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meetings
{
    public partial class Admin_Panel : Form
    {
        Input_SearchText form;

        public Admin_Panel()
        {
            InitializeComponent();
        this.Icon = Properties.Resources.download;


            this.Enabled = false;

        }

        public void EnableForm()
        {
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_newMeeting add = new add_newMeeting();
            add.EnableForm();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meeting_Search add = new Meeting_Search();
            add.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Decision_search add = new Decision_search();
            add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            string folderPath = null;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "اختر المجلد الذي تريد البحث ضمنه";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                form = new Input_SearchText();
                form.ShowDialog();
                string searchText = form.Txt;
                if (string.IsNullOrEmpty(searchText))
                {

                }
                else
                {
                    SearchInWordFiles(folderPath, searchText);

                }
            }
            else
            {
                MessageBox.Show("حدث خطأ ما");

            }


        }

        public void SearchInWordFiles(string folderPath, string searchText)
        {

            progressBar1.Value = 0;

            var filesPaths = new ArrayList();
            var counter = new ArrayList();


            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordFiles = Directory.GetFiles(folderPath, "*.docx", SearchOption.AllDirectories);
            progressBar1.Maximum = wordFiles.Length;
            int i = 0;
            label3.Text = "جار البحث ضمن المجلد، المجلد يحتوي على " + wordFiles.Length + "ملف ";
            foreach (var file in wordFiles)
            {

                try
                {
                    Document doc = wordApp.Documents.Open(file);
                    int x = CountTextOccurrencesInDocument(doc, searchText);
                    label4.Text = "يتم الان فتح الملف الـ " + i;
                    i++;
                 
                       progressBar1.Value ++;
                       

                    if (x > 0)
                    {
                        counter.Add(x);
                        filesPaths.Add(file);


                    }

                    doc.Close(false);
                    Marshal.ReleaseComObject(doc);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error processing file {file}: {ex.Message}");

                }
            }
            new Word_search_result_form(searchText, filesPaths, counter).Show();

            wordApp.Quit();
            Marshal.ReleaseComObject(wordApp);
        }

        static int CountTextOccurrencesInDocument(Document doc, string searchText)
        {
            int count = 0;

            foreach (Range range in doc.StoryRanges)
            {
                string text = range.Text;
                int index = text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

                while (index >= 0)
                {

                    count++;
                    index = text.IndexOf(searchText, index + searchText.Length, StringComparison.OrdinalIgnoreCase);
                }
            }

            return count;
        }

        static bool SearchTextInDocument(Document doc, string searchText)
        {
            foreach (Range range in doc.StoryRanges)
            {
                if (range.Text.Contains(searchText))
                {
                    return true;
                }
            }
            return false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "هل تريد تسجيل الخروج؟", "تسجيل الخروج", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;

                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }

   
    }
}

