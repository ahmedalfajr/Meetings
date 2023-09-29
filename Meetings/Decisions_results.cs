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
    public partial class Decisions_results : Form
    {
       
        public Decisions_results()
        {

        

            InitializeComponent();
        }

        public Decisions_results(string[] decNumbers, string[] decContent, string[] decTaken, String mtg_title, String mtg_date, String mtg_participants, string mtg_conclusion)
        {
            InitializeComponent();


            // Create and configure the DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            // Create columns for the DataGridView
            DataGridViewTextBoxColumn mtgNumberColumn = new DataGridViewTextBoxColumn();
            mtgNumberColumn.HeaderText = "عنوان الاجتماع";
            mtgNumberColumn.DataPropertyName = "Title";

            DataGridViewTextBoxColumn mtgDateColumn = new DataGridViewTextBoxColumn();
            mtgDateColumn.HeaderText = "تاريخ الاجتماع";
            mtgDateColumn.DataPropertyName = "Date";

            DataGridViewTextBoxColumn mtgParticipantsColumn = new DataGridViewTextBoxColumn();
            mtgParticipantsColumn.HeaderText = "المشاركون";
            mtgParticipantsColumn.DataPropertyName = "Participants";


            DataGridViewTextBoxColumn mtgConclusionColumn = new DataGridViewTextBoxColumn();
            mtgConclusionColumn.HeaderText = "الخاتمة";
            mtgConclusionColumn.DataPropertyName = "Conclusion";
            // Add the columns to the DataGridView
            dataGridView2.Columns.Add(mtgNumberColumn);
            dataGridView2.Columns.Add(mtgDateColumn);
            dataGridView2.Columns.Add(mtgParticipantsColumn);
            dataGridView2.Columns.Add(mtgConclusionColumn);


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Title");
            dt1.Columns.Add("Date");
            dt1.Columns.Add("Participants");
            dt1.Columns.Add("Conclusion");


            // Populate the DataTable with data from the arrays

            dt1.Rows.Add(mtg_title, mtg_date, mtg_participants, mtg_conclusion);
            dataGridView2.DataSource = dt1;


            DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn();
            numberColumn.HeaderText = "رقم القرار";
            numberColumn.DataPropertyName = "Number";

            DataGridViewTextBoxColumn contentColumn = new DataGridViewTextBoxColumn();
            contentColumn.HeaderText = "محتويات القرار";
            contentColumn.DataPropertyName = "Content";

            DataGridViewTextBoxColumn takenColumn = new DataGridViewTextBoxColumn();
            takenColumn.HeaderText = "القرار المتخذ";
            takenColumn.DataPropertyName = "Taken";

            // Add the columns to the DataGridView
            dataGridView1.Columns.Add(numberColumn);
            dataGridView1.Columns.Add(contentColumn);
            dataGridView1.Columns.Add(takenColumn);

            // Create a DataTable to hold the data
            DataTable dt = new DataTable();
            dt.Columns.Add("Number");
            dt.Columns.Add("Content");
            dt.Columns.Add("Taken");

            // Populate the DataTable with data from the arrays
            for (int i = 0; i < decNumbers.Length; i++)
            {
                dt.Rows.Add(decNumbers[i], decContent[i], decTaken[i]);
            }

            // Bind the DataGridView to the DataTable
            dataGridView1.DataSource = dt;
        }

        private void Decisions_results_Load(object sender, EventArgs e)
        {

        }
    }
}
