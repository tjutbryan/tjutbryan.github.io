using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                txtPath2.Text = ofd2.FileName;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            long filesize = new FileInfo(txtPath1.Text).Length;
            long filesize2 = new FileInfo(txtPath2.Text).Length;
            long max, min;
            if (filesize < filesize2)
            {
                max = filesize2;
                min = filesize;
            }
            else
            {
                max = filesize;
                min = filesize2;
            }
            long diff = max - min;
            txtDiff.Text = diff.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
