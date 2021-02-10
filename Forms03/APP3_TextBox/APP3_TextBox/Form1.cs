using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            bool sucesso = Int32.TryParse(text_Idade.Text, out resultado);
            if (!sucesso)
            {
                lbl_Resposta.Text =("Voçê errou na idade");
                return;
            }

            if (! string.IsNullOrEmpty(text_Nome.Text) && !string.IsNullOrEmpty(text_Sobrenome.Text) && !string.IsNullOrEmpty(text_Idade.Text)){
                lbl_Resposta.Text = "Olá ," + text_Nome.Text + "  " + text_Sobrenome.Text + ", voçê tem  " + text_Idade.Text + " anos ";

                text_Nome.Text = "";
                text_Sobrenome.Text = "";
                text_Idade.Text = "";

            }
            else
            {
                lbl_Resposta.Text = "Por favor, complete todos  os campos! PS: Sobrenome é opcional !";
            }
        }

        private void validarInt(object sender, KeyPressEventArgs e)
        {
            char teclaDigitada = e.KeyChar;
            if (!char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void ValidarTexto(object sender, EventArgs e)
        {
            int resultado;
            bool sucesso = Int32.TryParse(text_Idade.Text, out resultado);
            if (!sucesso)
            {
                text_Idade.Text = "0";
                
            }
        }
    }
}
