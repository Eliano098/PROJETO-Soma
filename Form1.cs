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
    public partial class Form1 : Form
    {
        Random numAleatorio = new Random();
        Stopwatch stopWatch = new Stopwatch();
        SoundPlayer som;
        SoundPlayer som1 = new SoundPlayer(@"Audios\Fundo.wav");

        int personagem = 0;
        int soma = 0;
        int contador = 1;

        public Form1(int aux)
        {
            InitializeComponent();
            personagem = aux;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            som1.Play();

            if (personagem == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.Menino;
                pictureBox2.BackgroundImage = Properties.Resources.Menino;
                pictureBox3.BackgroundImage = Properties.Resources.Menino;
                pictureBox4.BackgroundImage = Properties.Resources.Menino;
                pictureBox5.BackgroundImage = Properties.Resources.Menino;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.Menina;
                pictureBox2.BackgroundImage = Properties.Resources.Menina;
                pictureBox3.BackgroundImage = Properties.Resources.Menina;
                pictureBox4.BackgroundImage = Properties.Resources.Menina;
                pictureBox5.BackgroundImage = Properties.Resources.Menina;
            }

            lblnum1.Text = numAleatorio.Next(1, 3).ToString();
            lblnum2.Text = numAleatorio.Next(1, 3).ToString();

            soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

            /////////////
            stopWatch.Start();
        }

        private void cmdProcessar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtResposta.Text) == soma)
            {
                contador++;

                if (contador >= 6)
                {
                    stopWatch.Stop();
                    Form2 F = new Form2(stopWatch);
                    F.ShowDialog();
                }
                else
                {
                    som = new SoundPlayer(@"Audios\Acerto.wav");
                    som.Play();

                    MessageBox.Show("PARABÉNS, você acertou.\nVá para proxima fase!!!");
                    AtualizarValores();
                    txtResposta.Clear();

                    som1.Play();
                }

            }
            else
            {
                som = new SoundPlayer(@"Audios\Falha.wav");
                som.Play();

                MessageBox.Show("QUE PENA, você errou.\nTente novamente!");

                contador--;
                AtualizarValores();
                txtResposta.Clear();

                som1.Play();

                if (contador <= 1)
                {
                    AtualizarFormulario();
                    AtualizarValores();
                    pictureBox1.Visible = true;
                    contador = 1;
                }
                else
                {
                    AtualizarFormulario();
                    AtualizarValores();
                }
            }
        }

        //METODOS

        private void AtualizarValores()
        {
            switch (contador)
            {
                case 1:
                    {
                        lblnum1.Text = numAleatorio.Next(1, 3).ToString();
                        lblnum2.Text = numAleatorio.Next(1, 3).ToString();

                        soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

                        AtualizarFormulario();
                        pictureBox1.Visible = true;
                    }
                    break;
                case 2:
                    {
                        lblnum1.Text = numAleatorio.Next(3, 5).ToString();
                        lblnum2.Text = numAleatorio.Next(1, 3).ToString();

                        soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

                        AtualizarFormulario();
                        pictureBox2.Visible = true;

                    }
                    break;
                case 3:
                    {
                        lblnum1.Text = numAleatorio.Next(5, 8).ToString();
                        lblnum2.Text = numAleatorio.Next(3, 5).ToString();

                        soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

                        AtualizarFormulario();
                        pictureBox3.Visible = true;

                    }
                    break;
                case 4:
                    {
                        lblnum1.Text = numAleatorio.Next(1, 5).ToString();
                        lblnum2.Text = numAleatorio.Next(8, 10).ToString();

                        soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

                        AtualizarFormulario();
                        pictureBox4.Visible = true;

                    }
                    break;
                case 5:
                    {
                        lblnum1.Text = numAleatorio.Next(8, 10).ToString();
                        lblnum2.Text = numAleatorio.Next(5, 8).ToString();

                        soma = int.Parse(lblnum1.Text) + int.Parse(lblnum2.Text);

                        AtualizarFormulario();
                        pictureBox5.Visible = true;
                    }
                    break;

            }
        }
        private void AtualizarFormulario()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

    }
}
