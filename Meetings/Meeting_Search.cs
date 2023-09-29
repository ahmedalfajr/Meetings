using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Meetings
{
    public partial class Meeting_Search : Form
    {
        public Meeting_Search()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            System.Data.DataTable dt = db_handler.getInstance().RetriveFromDB("select * from Meetings where number like N'" + meeting_number.Text + "' or title like N'" + meeting_title.Text + "' or date like N'" + meeting_date.Text + "';");
            if (dt.Rows.Count > 0)
            {

                System.Data.DataTable decisions = db_handler.getInstance().RetriveFromDB("select * from Decisions where mtg_id =" + dt.Rows[0]["id"] + ";");

                MessageBox.Show(dt.Rows[0]["number"] + "\n" + dt.Rows[0]["title"] + "\n" + dt.Rows[0]["date"] + "\n" + dt.Rows[0]["date"] + "\n" + dt.Rows[0]["participant"] + "\n" + dt.Rows[0]["concluiosn"]);

                for (int i = 0; i < decisions.Rows.Count; i++)
                {
                    MessageBox.Show(decisions.Rows[i]["number"] + "\n" + decisions.Rows[i]["decision_content"] + "\n" + decisions.Rows[i]["decision_taken"] );

                }
            }

            else {
                MessageBox.Show("nothing to show");
            }

        }
    }
}
