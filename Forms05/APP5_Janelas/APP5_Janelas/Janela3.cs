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
    public partial class frm_Janela3 : Form
    {
        public frm_Janela3()
        {
            InitializeComponent();
        }

        private void Janela3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns! chegamos na última janela !!! ");



        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            frm_Janela2 janela2 = new frm_Janela2();
            janela2.Show();
            this.Hide();
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            frm_janela1 janela1 = new frm_janela1();
            janela1.Show();
            this.Hide();
        }
    }
}
