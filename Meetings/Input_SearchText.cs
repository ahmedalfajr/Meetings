using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Meetings
{
    public partial class Input_SearchText : Form
    {

        string txt;
        public Input_SearchText()
        {
            InitializeComponent();
        }

        public string Txt { get => txt; set => txt = value; }

        private void Input_SearchText_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
          
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Text = "الرجاء ادخال نص";
            }
            else
            {

                txt = textBox1.Text;
                this.Hide();
            }
            
        }


   
    }
}
