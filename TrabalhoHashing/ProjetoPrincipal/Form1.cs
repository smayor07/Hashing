using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPrincipal
{
    public partial class Form1 : Form
    {
        Hashing H = null;

        public Form1()
        {
            InitializeComponent();
            H = new Hashing(txtChave.Text);
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            if (rbHashingStandard.Checked)
            {
                H.Chave = txtChave.Text;
                int B = H.HashingStandard();

                if (B % 7 == 0)
                {
                    lblPosicao0.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 1)
                {
                    lblPosicao1.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 2)
                {
                    lblPosicao2.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 3)
                {
                    lblPosicao3.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 4)
                {
                    lblPosicao4.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 5)
                {
                    lblPosicao5.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 6)
                {
                    lblPosicao6.Text += H.Chave + " -> ";
                }
                txtChave.Text = "";
            }
            else if (rbHashingPI.Checked)
            {
                H.Chave = txtChave.Text;
                int B = H.HashingPI();

                if (B % 7 == 0)
                {
                    lblPosicao0.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 1)
                {
                    lblPosicao1.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 2)
                {
                    lblPosicao2.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 3)
                {
                    lblPosicao3.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 4)
                {
                    lblPosicao4.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 5)
                {
                    lblPosicao5.Text += H.Chave + " -> ";
                }
                else if (B % 7 == 6)
                {
                    lblPosicao6.Text += H.Chave + " -> ";
                }
                txtChave.Text = "";
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            lblPosicao0.Text = "R 0:";
            lblPosicao1.Text = "R 1:";
            lblPosicao2.Text = "R 2:";
            lblPosicao3.Text = "R 3:";
            lblPosicao4.Text = "R 4:";
            lblPosicao5.Text = "R 5:";
            lblPosicao6.Text = "R 6:";
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
