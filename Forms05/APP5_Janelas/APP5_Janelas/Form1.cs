using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP5_Janelas
{
    public partial class frm_janela1 : Form
    {
        public frm_janela1()
        {
            InitializeComponent();
        }

        private void btn_proxJanela_Click(object sender, EventArgs e)
        {
            frm_Janela2 janela2 = new frm_Janela2();
            janela2.Show();
            this.Hide();
        }
    }
}
