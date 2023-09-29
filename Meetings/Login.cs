using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Meetings
{
    public partial class Login : Form
    {

        Admin_Panel f2;
        add_newMeeting f1;

        public Login()
        {
            InitializeComponent();
            f2 = new Admin_Panel();
            f1 = new add_newMeeting();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {
                label3.Text = "يجب ادخال اسم المستخدم وكلمة السر";


            }
            else
            {
                System.Data.DataTable dt = db_handler.getInstance().RetriveFromDB("select * from users where username=N'" + username.Text + "' and  password=N'" + password.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    f2.EnableForm();
                    f1.EnableForm();
                    this.Hide();
                    f2.ShowDialog();
                }
                else
                {
                    label3.Text = "هنالك خطأ في اسم المستخدم او كلمة السر";

                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
