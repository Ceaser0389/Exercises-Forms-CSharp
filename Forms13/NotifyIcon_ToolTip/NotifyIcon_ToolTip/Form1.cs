using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon_ToolTip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
        }

        private void confg1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou a opção 1");
        }

        private void config2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou a opção 2");
        }

        private void config3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sou a opção 3");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
