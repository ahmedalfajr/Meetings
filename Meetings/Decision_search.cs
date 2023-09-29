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
    public partial class Decision_search : Form
    {
       
        private string mtg_title;
        private string mtg_description;
        private string mtg_number;
        private string mtg_date;
        private string mtg_participants;
        private string mtg_conclusion;
        private string[] dec_number;
        private string[] dec_content;
        private string[] dec_taken;

        public Decision_search()
        {
              
            InitializeComponent();
           
        }

        public string Mtg_title { get => mtg_title; set => mtg_title = value; }
        public string Mtg_description { get => mtg_description; set => mtg_description = value; }
        public string Mtg_number { get => mtg_number; set => mtg_number = value; }
        public string Mtg_date { get => mtg_date; set => mtg_date = value; }
        public string Mtg_participants { get => mtg_participants; set => mtg_participants = value; }
        public string Mtg_conclusion { get => mtg_conclusion; set => mtg_conclusion = value; }
        public string[] Dec_number { get => dec_number; set => dec_number = value; }
        public string[] Dec_content { get => dec_content; set => dec_content = value; }
        public string[] Dec_taken { get => dec_taken; set => dec_taken = value; }

        private void button1_Click(object sender, EventArgs e)
        {
          System.Data.DataTable dt = db_handler.getInstance().RetriveFromDB("select * from Decisions where number =N'" + decision_number.Text +"' or mtg_number like N'" + meeting_number.Text+ "';");
            if (dt.Rows.Count > 0)
            {
                System.Data.DataTable meeting = db_handler.getInstance().RetriveFromDB("select * from Meetings where id = " + dt.Rows[0]["mtg_id"] + ";");
                Mtg_title = meeting.Rows[0]["title"].ToString();
                Mtg_date = meeting.Rows[0]["date"].ToString(); ;
                Mtg_participants = meeting.Rows[0]["participant"].ToString();
                Mtg_conclusion = meeting.Rows[0]["concluiosn"].ToString();
                Dec_number = new string[dt.Rows.Count];
                Dec_content = new string[dt.Rows.Count];
                Dec_taken= new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {                   
                    Dec_number[i] = dt.Rows[i]["number"].ToString();
                    Dec_content[i] = dt.Rows[i]["decision_content"].ToString();
                    Dec_taken[i] = dt.Rows[i]["decision_taken"].ToString();
                }
                new Decisions_results(Dec_number, Dec_content, Dec_taken, Mtg_title, Mtg_date, Mtg_participants,Mtg_conclusion).ShowDialog();

            }

            else
            {
                MessageBox.Show("nothing to show");
            }
        }
    }
}
