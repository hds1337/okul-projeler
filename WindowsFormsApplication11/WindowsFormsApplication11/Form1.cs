using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip test = new ToolTip();
            test.SetToolTip(textBox1, "Adınızı giririniz");
            test.SetToolTip(textBox2, "Soyadınızı giriniz");
            test.SetToolTip(textBox3, "Doğum Gününüzü ");
            test.SetToolTip(richTextBox1, "Adresinizi giriniz");
        }
    }
}
