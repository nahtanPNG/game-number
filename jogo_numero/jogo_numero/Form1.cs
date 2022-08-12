using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_numero
{
    public partial class Form1 : Form
    {
        //Variavel global
        int contador;
        public Form1()
        {
            InitializeComponent();
        }
        //Função para verificar se um dos botões está vazio
        public void VerificarVazio(Button Botão1, Button Botão2) //Segundo valor é o nome
        {
            if (Botão2.Text=="")
            {
                Botão2.Text = Botão1.Text;
                Botão1.Text = "";
            }
        }

        //Função para verificar se os números estão na ordem certa
        public void VerificarNum()
        {
            if(button1.Text=="1" && button2.Text=="2" && button3.Text=="3" && 
               button4.Text=="4" && button5.Text=="5" && button6.Text=="6" && 
               button7.Text=="7" && button8.Text=="8" && button9.Text=="")
            {
                MessageBox.Show("Muito bem Você é um vencedor!","Jogo dos Números",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            contador = contador + 1;
            textBox1.Text = "QUANTIDADE DE CLICKS " + contador;
        }
        public void Misturar()
        {
            //vetor com varios valores dentro de uma variavel 

            int[] bnum = new int[9];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random(); //é um programa que coloca as coias de forma randomica na tela

                verificalinha = Convert.ToInt32((rnd.Next(0, 8)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == verificalinha)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = verificalinha;
                    i++;
                }

            } while (i <= 8);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = "";

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Misturar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botão 3 troca com o 2 e o 6
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button6);
            VerificarNum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Troca comm 6 e 8
            VerificarVazio(button9, button6);
            VerificarVazio(button9, button8);
            VerificarNum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botão 1 troca com o 2 e com o 4
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button4);
            VerificarNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //botão 2 troca com o 1,3 e 5
            VerificarVazio(button2, button1);
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button5);
            VerificarNum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão 4 troca com o 1, 7 e 5
            VerificarVazio(button4, button1);
            VerificarVazio(button4, button7);
            VerificarVazio(button4, button5);
            VerificarNum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //botão 5 troca com o 2,4,6 e 8
            VerificarVazio(button5, button2);
            VerificarVazio(button5, button4);
            VerificarVazio(button5, button6);
            VerificarVazio(button5, button8);
            VerificarNum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //botão 6 troca com o vazio, 5 e 3
            VerificarVazio(button6, button5);
            VerificarVazio(button6, button3);
            VerificarNum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //botão 7 troca com o 4 e 8
            VerificarVazio(button7, button4);
            VerificarVazio(button7, button8);
            VerificarNum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //botão 8 troca com o vazio, 7 e 5
            VerificarVazio(button8, button5);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button9);
            VerificarNum();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Misturar();
            textBox1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Tem certeza que deseja sair?", "Jogo dos Números", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Sair == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Tem certeza que deseja sair?", "Jogo dos Números", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Sair == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = "";
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Misturar();
            textBox1.Clear();

            this.Refresh();
            this.Hide();
            Form1 NovoJogo = new Form1();
            NovoJogo.Show();
        }
    }
}
