using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
               
            
                if (e.Node.NodeFont != null)
                {
                    e.Node.NodeFont = new Font(e.Node.NodeFont.FontFamily, e.Node.NodeFont.Size, FontStyle.Strikeout);

                }
                else
                {
                    e.Node.NodeFont = new Font(ArvoreDeCompras.Font.FontFamily, ArvoreDeCompras.Font.Size, FontStyle.Strikeout);
                }
           
        }
    }
}
