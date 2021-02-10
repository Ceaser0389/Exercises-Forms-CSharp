using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texto =
            {"Eu","Sou", "Um", "teste", "De", "Rich","Text","Box"
            };

            Color[] Cores =
            {
                Color.AliceBlue,
                Color.AntiqueWhite,
                Color.Aqua,
                Color.Azure,
                Color.Beige,
                Color.Bisque,
                Color.Black,
                Color.Green
            };
        Color[] Cores2 =
        {
                Color.BlanchedAlmond,
                Color.Blue,
                Color.BlueViolet,
                Color.Brown,
                Color.CadetBlue,
                Color.Chartreuse,
                Color.Chocolate,
                Color.Orange
            };
            for(int i=0; i < texto.Length; i++)
            {
                richTextBox1.SelectionColor = Cores[i];
                richTextBox1.SelectionBackColor = Cores2[i];
                richTextBox1.AppendText(texto[i]);
                richTextBox1.AppendText("\n");
                if( i %2 == 0)
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
