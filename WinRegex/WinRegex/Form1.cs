using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRegex //Nikita Veligorski TA-20V
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Hexacode = @"^[A-F0-9a-f]+$";
            string Binary = @"^[0-1]+$";
            string CharactersOnly = @"^[a-zA-Z]+$";
            string Telephone = @"^[2-7][0-9]{6,7}$";

            if ((new Regex(Hexacode)).IsMatch(textBox1.Text))
            {
                textBox1.ForeColor = Color.Green;
            }
            else
            {
                textBox1.ForeColor = Color.Red;
            }

            if ((new Regex(CharactersOnly)).IsMatch(textBox2.Text))
            {
                textBox2.ForeColor = Color.Green;
            }
            else
            {
                textBox2.ForeColor = Color.Red;
            }

            if ((new Regex(Binary)).IsMatch(textBox3.Text))
            {
                textBox3.ForeColor = Color.Green;
            }
            else
            {
                textBox3.ForeColor = Color.Red;
            }

            if ((new Regex(Telephone)).IsMatch(textBox4.Text))
            {
                textBox4.ForeColor = Color.Green;
            }
            else
            {
                textBox4.ForeColor = Color.Red;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
