using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tema1
{
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("help_add.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_add.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("help_caut.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_caut.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("help_edit.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_edit.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("help_del.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_del.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("help_xml.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_xml.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("help_excel.txt") == true)
            {
                System.IO.StreamReader objReader = new StreamReader("help_excel.txt");
                //MessageBox.Show(objReader.ReadToEnd());
                rtfh.Text = (objReader.ReadToEnd());
                objReader.Close();

            }
            else
            {
                MessageBox.Show("Fisier help inexistent!");
            }
        }

    }
}
