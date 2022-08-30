using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorSorteio
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        static List<int> Lista = new List<int>();

        public void button1_Click(object sender, EventArgs e)
        {
            int inicial = 0;
            int final = 100;

            if(textBox1.Text.Length != 0)
                inicial = Convert.ToInt32(textBox1.Text);
            if(textBox2.Text.Length != 0)
                final = Convert.ToInt32(textBox2.Text);

            
            Random rnd = new Random();
            int Gerado = rnd.Next(inicial, final);
            foreach (int i in Lista)
            {
                if (Gerado == i)
                    return;
       
            }
            MessageBox.Show("NÚMERO SORTEADO: " + Gerado);
            Lista.Add(Gerado);
            Sorteados.Items.Add(Gerado);
           
        }

        private void Sorteados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sorteados.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
