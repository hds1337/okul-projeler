using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)&& string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Kullanıcı adınızı ve şifrenizi giriniz!","Uyarı");
            }
         
            if (textBox1.Text == "asd" && textBox2.Text == "123")
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Yanlış giriş");
            }
        }
    }
}
