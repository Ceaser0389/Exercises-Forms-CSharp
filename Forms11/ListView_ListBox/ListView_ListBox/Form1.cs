using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Vingadores");
            listBox1.Items.Add("Vingadores 2");
            listBox1.Items.Add("Vingadores 3");
            listBox1.Items.Add("Vingadores 4");
            listBox1.Items.Add("Batmam vs Super Man");
            listBox1.Items.Add("Liga da justiça");
            listBox1.Items.Add("Esquadrão Suicida");
            listBox1.Items.Add("Homem-Aranha 1");
            listBox1.Items.Add("Homem-Aranha 2");
            listBox1.Items.Add("Homem-Aranha 3");
        }
    }
}
