using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flimes_Marvel
{
    public partial class Form1 : Form
    {
        // Declara a variável fora do evento do botão (no nível da classe)
        private int pontos1 = 0;
        private int pontos2 = 0;
        private int pontos3 = 0;
        private int pontos4 = 0;
        private int pontos5 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Escolha1_Click(object sender, EventArgs e)
        {
            pontos1 += 1;
            Txt_Ponto1.Text = pontos1.ToString();
        }

        private void Btn_Escolha2_Click(object sender, EventArgs e)
        {
            pontos2 += 1;
            Txt_Ponto2.Text = pontos2.ToString();
        }

        private void Btn_Escolha3_Click(object sender, EventArgs e)
        {
            pontos3 += 1;
            Txt_Ponto3.Text = pontos3.ToString();
        }

        private void Btn_Escolha4_Click(object sender, EventArgs e)
        {
            pontos4 += 1;
            Txt_Ponto4.Text = pontos4.ToString();
        }

        private void Btn_Escolha5_Click(object sender, EventArgs e)
        {
            pontos5 += 1;
            Txt_Ponto5.Text = pontos5.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pic_Flimes1_Click(object sender, EventArgs e)
        {
            //Mostra a nota do Filme
            Txt_Nota.Text = "A nota é 8,4 com 380 mil votos";
            //Mostra o Trailer do filme
            axWindowsMediaPlayer1.URL = @"Video/Aranhaverso2.mp4";
        }

        private void Btn_Resultado_Click(object sender, EventArgs e)
        {
            if (pontos3 > pontos1 && pontos3 > pontos2 && pontos3 > pontos5 && pontos3 > pontos4)
            {
                MessageBox.Show("Vocês acertaram!","PARABÉNS!!!");
                // Txt_Nota.Text = "Vocês acertaram!";
            }
            else
            {
                MessageBox.Show("Você erraram!", "QUE PENA...");
                // Txt_Nota.Text = "Você erraram!";
            }
        }

        private void Pic_Flimes2_Click(object sender, EventArgs e)
        {
            //Mostra a nota do Filme
            Txt_Nota.Text = "A nota é 8,2 com 880 mil votos";
            //Mostra o Trailer do filme
            axWindowsMediaPlayer1.URL = @"Video/Sem_Volta.mp4";
        }

        private void Pic_Flimes3_Click(object sender, EventArgs e)
        {
            //Mostra a nota do Filme
            Txt_Nota.Text = "A nota é 8,4 com 1,3 milões de votos";
            //Mostra o Trailer do filme
            axWindowsMediaPlayer1.URL = @"Video/Ultimato.mp4";
        }

        private void Pic_Flimes4_Click(object sender, EventArgs e)
        {
            //Mostra a nota do Filme
            Txt_Nota.Text = "A nota é 8,4 com 1,2 milhões de votos";
            //Mostra o Trailer do filme
            axWindowsMediaPlayer1.URL = @"Video/Guerra_Infinita.mp4";
        }

        private void Pic_Flimes5_Click(object sender, EventArgs e)
        {
            //Mostra a nota do Filme
            Txt_Nota.Text = "A nota é 8,4 com 670 mil votos";
            //Mostra o Trailer do filme
            axWindowsMediaPlayer1.URL = @"Video/Aranhaverso1.mp4";

        }
    }
}
