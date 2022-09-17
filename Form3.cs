using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Projeto_Soma
{
    public partial class Form3 : Form
    {
        int personagem;
        SoundPlayer som;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            som = new SoundPlayer(@"Audios\Fundo.wav");
            som.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personagem = 1;
            som.Stop();
            Form1 F1 = new Form1(personagem);
            F1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            personagem = 2;
            som.Stop();
            Form1 F2 = new Form1(personagem);
            F2.ShowDialog();
        }
    }
}
