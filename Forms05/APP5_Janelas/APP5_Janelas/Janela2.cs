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
    public partial class frm_Janela2 : Form
    {
        public frm_Janela2()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_janela1 janela1 = new frm_janela1();
            janela1.Show();
            this.Hide();
        }

        private void btn_proxJanela_Click(object sender, EventArgs e)
        {
            frm_Janela3 janela3 = new frm_Janela3();
            janela3.Show();
            this.Hide();
        }
    }
}
