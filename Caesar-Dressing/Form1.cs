using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Caesar_Dressing
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private class Caesar {
            public string name = "";
            public string firstName = "";
            public string lastName = "";
            public int key = 0;

        };
        Caesar user = new Caesar();
        private void button1_Click(object sender, EventArgs e)
        {
            user.name = tbx_name.Text;
            user.firstName = user.name.Split(" ".ToCharArray())[0];
            user.lastName = user.name;
            MessageBox.Show($"'{user.firstName}'-'{user.lastName}'");


            foreach (string element in user.name.Split(" ".ToCharArray()))
            {
                // body of foreach loopr
                MessageBox.Show(element);
            }
        }
    }
}
