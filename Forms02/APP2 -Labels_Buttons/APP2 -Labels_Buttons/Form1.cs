using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2__Labels_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {

            lbl_qtd.Text = "No mínimo  faltam 18";
            lbl_qtd.Visible = true;
        }
    }
}
