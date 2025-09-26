using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace globalvaribles
{

    public partial class Form1 : Form
    {
        public static class GlobalVariables
        {
            public static string gonderi;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.gonderi = textBox1.Text;

            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
