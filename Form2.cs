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
using System.Diagnostics;

namespace Projeto_Soma
{
    public partial class Form2 : Form
    {
        Stopwatch stopWatch;
        SoundPlayer som;

        public Form2(Stopwatch aux)
        {
            InitializeComponent();
            stopWatch = aux;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblSegundo.Text = stopWatch.Elapsed.ToString(@"m\:ss");
            som = new SoundPlayer(@"Audios\Tema.wav");
            som.Play();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
