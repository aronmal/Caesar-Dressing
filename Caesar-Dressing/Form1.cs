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
        private class Caesar
        {
            public string name = "";
            public string firstName = "";
            public string lastName = "";
            public List<char> letters = new List<char>(30);
            public List<int> numbers = new List<int>(30);
            public int key = 0;

        };
        Caesar user = new Caesar();
        private void einlesen_Click(object sender, EventArgs e)
        {
            if (tbx_name.Text.Length >= 30)
            {
                MessageBox.Show("Eingabe ist zu lang. Bitte halten sie sich kurz ;)", "Ungültige Eingabe");
            }
            else if (tbx_name.Text.Length > 3 || tbx_name.Text.IndexOf(" ") > 0)
            {
                user.name = tbx_name.Text;
                user.firstName = "";
                user.lastName = "";
                user.letters.Clear();
                user.numbers.Clear();
            }
            else
            {
                MessageBox.Show("Bitte '<Vorname> <Nachnahme>' mit einem Leerzeichen dazwischen eingeben.", "Ungültige Eingabe");
            }

            //foreach (string element in user.name.Split(" ".ToCharArray()))
            //{
            //    // body of foreach loopr
            //    MessageBox.Show(element);
            //}
        }
        private void split_Click(object sender, EventArgs e)
        {
            string[] splittedNames = user.name.Split(" ".ToCharArray());
            user.firstName = splittedNames[0];
            user.lastName = string.Join(" ", splittedNames.Skip(1));
            textBox2.Text = user.firstName;
            textBox3.Text = user.lastName;
            //MessageBox.Show($"'{user.firstName}'-'{user.lastName}'");
        }

        private void buchstabieren_Click(object sender, EventArgs e)
        {
            user.letters.AddRange(user.name);
            listBox1.Items.Clear();
            foreach (char c in user.letters)
            {
                listBox1.Items.Add(c);
            }
        }
        private void count_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (char c in user.letters)
            {
                listBox2.Items.Add(Convert.ToInt32(c));
            }
        }

        private void schti_Click(object sender, EventArgs e)
        {

            string[] fromA = new string[] { "s", "sch", "ch", "z", "o" };
            string[] toA = new string[] { "sch", "s", "s", "sch", "a" };

            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "", "" }
            };
            var warst = dic.Keys;
            string output = "";
            foreach (char c in tbx_name.Text)
            {
                string thisChar = c.ToString();
                Boolean active = true;
                int index = 0;
                foreach (string s in fromA)
                {
                    if (active && thisChar == s)
                    {
                        output += toA[index];
                        active = false;
                    }
                    index++;
                }
                if (active)
                {
                    output += thisChar;
                }
            }
            MessageBox.Show(output);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";
            int iChi = Convert.ToInt32(numericUpDown1.Value);
            int iChar = 0;
            foreach (char c in user.letters)
            {
                iChar = Convert.ToInt32(c);
                if (iChar >= 65 && iChar <= 90)
                    iChar = (iChar - 65 + iChi) % 26 + 65;
                if (iChar >= 97 && iChar <= 122)
                    iChar = (iChar - 97 + iChi) % 26 + 97;
                result += Convert.ToChar(iChar).ToString();
            }
            textBox4.Text = result;
        }
    }
}
