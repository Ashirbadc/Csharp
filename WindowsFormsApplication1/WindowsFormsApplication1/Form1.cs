using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string name = "";
        
        public Form1()
        {
            InitializeComponent();               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
          private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker2.Value;
            int years = ((int)ageDays.TotalDays) / 365;
            int day = dateTimePicker2.Value.Day;
            string month = dateTimePicker2.Value.ToString("MMMM");
            string year = dateTimePicker2.Value.ToString("yyyy");
            name = textBoxName.Text;
            labelAppointmentMessage.Text = "Hello " + name + ", " + "You're appointment is on " + day + "/" + month + "/" + year + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
