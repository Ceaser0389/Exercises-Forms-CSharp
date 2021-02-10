using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int valorAtual;
        int valorMaximo = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            valorAtual = 0;
            timer1.Start();
            new Thread(executar).Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100 * valorAtual / valorMaximo;
            label1.Text = $"Processou {valorAtual} de {valorMaximo} dados!({progressBar1.Value}) %";
        }

        private void executar()
        {
            while(valorAtual < valorMaximo)
            {
                valorAtual++;
                Thread.Sleep(20);
            }
        }

    }
}
