using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meetings
{
    public partial class Word_search_result_form : Form
    {
        public Word_search_result_form(String text, ArrayList filePath, ArrayList count)
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            // Create columns for the DataGridView
            DataGridViewTextBoxColumn textSearch = new DataGridViewTextBoxColumn();
            textSearch.HeaderText = "النص الذي ادخلته";
            textSearch.DataPropertyName = "text";
            textSearch.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            DataGridViewTextBoxColumn file_Path = new DataGridViewTextBoxColumn();
            file_Path.HeaderText = "مسار الملف";
            file_Path.DataPropertyName = "filePath";
            file_Path.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn counter = new DataGridViewTextBoxColumn();
            counter.HeaderText = "عدد مرات التكرار";
            counter.DataPropertyName = "counter";
            counter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




            // Add the columns to the DataGridView
            dataGridView1.Columns.Add(textSearch);
            dataGridView1.Columns.Add(file_Path);
            dataGridView1.Columns.Add(counter);


            // Create a DataTable to hold the data
            DataTable dt = new DataTable();
            dt.Columns.Add("text");
            dt.Columns.Add("filePath");
            dt.Columns.Add("counter");

            // Populate the DataTable with data from the arrays
            for (int i = 0; i < filePath.Count; i++)
            {
                dt.Rows.Add(text, filePath[i], count[i]);
            }

            // Bind the DataGridView to the DataTable
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string filepath = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            System.Diagnostics.Process.Start(filepath);


        }
    }

      
    }
