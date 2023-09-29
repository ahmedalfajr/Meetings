using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Meetings
{
    public partial class add_newMeeting : Form
    {
        public add_newMeeting()
        {
            InitializeComponent();
            this.Enabled = false;

        }

        public void EnableForm()
        {
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            db_handler.getInstance().Execute("insert into Meetings (number ,title ,date ,time,participant,concluiosn) values (N'" + metting_number.Text + "' ,N'" + metting_title.Text + "' ,N'" + metting_date.Text + "' ,N'" + metting_time.Text + "',N'" + metting_participants.Text + "',N'" + metting_conclusion.Text + "')");
            System.Data.DataTable dt = db_handler.getInstance().RetriveFromDB("select * from Meetings where number=N'" + metting_number.Text + "'");
            if (dt.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                        if (row.Cells["number"].Value != null || row.Cells["decision"].Value != null || row.Cells["decision_content"].Value != null)
                        {
                            db_handler.getInstance().Execute("insert into Decisions (number ,decision_content ,decision_taken,mtg_id,mtg_number) values (N'" + row.Cells["number"].Value + "' ,N'" + row.Cells["decision"].Value + "' ,N'" + row.Cells["decision_content"].Value + "' ," + dt.Rows[0]["id"] + ",'" +  metting_number.Text + "')");

                        }
                        else { }

                    }
                    MessageBox.Show("تمت الاضافة بنجاح");


                }


                }

            
        

   

        private void button2_Click(object sender, EventArgs e)
        {

           //System.Data.DataTable dt = db_handler.getInstance().RetriveFromDB("select id from Meetings");



            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = decision_number.Text;
            newRow.Cells[1].Value = decision_.Text;
            newRow.Cells[2].Value = decision_contents.Text;

            if (dataGridView1.Rows.Add(newRow)>0) {
                decision_number.Text = "";
                decision_.Text = "";
                decision_contents.Text = "";
            }


            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
