using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Login.l(textBox1.Text, textBox2.Text);
            if (m == 0)
            {
                MessageBox.Show("登录失败");
            }
            if (m == 1)
            {
                MessageBox.Show("登陆成功");
            }
            if (m == 2)
            {
                MessageBox.Show("mimacuowu");
            }
        }
    }
}
