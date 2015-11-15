using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QUEM_SABE_MAIS
{
    public partial class Form3 : Form
    {
        public string pontoss;

        public Form3(Form7 Form77)
        {
            InitializeComponent();
            objForm7 = Form77;
        }

        public Form7 objForm7;
        public string respostaC;

        public void geraPergunta(string Pergunta, string REPC, string ATA, string ATB, string ATC, string ATD, string PT, string Cat)
        {
            respostaC = REPC;
            LB_pergunta.Text = Pergunta;
            RBA.Text = ATA;
            RBB.Text = ATB;
            RBC.Text = ATC;
            RBD.Text = ATD;
            pontoss = PT;
            LB_categoria.Text = Cat;
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            verResposta();
        }

        public int addpontos()
        {
            objForm7.ppt = objForm7.ppt + Convert.ToInt32(pontoss);
            return objForm7.ppt;
        }
       
        public void gerapontos()
        {
            objForm7.LB_pontos.Text = addpontos().ToString();
        }

        public void verResposta()
        {
            if (RBA.Text == respostaC && RBA.Checked == true)
            {
                SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.aplauso);
                IniciarPlayer.Play();
                MessageBox.Show("Alternativa Correta", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();//esconder em vez de deletar
                gerapontos();
            }
            else if (RBB.Text == respostaC && RBB.Checked == true)
            {
                SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.aplauso);
                IniciarPlayer.Play();
                MessageBox.Show("Alternativa Correta", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                gerapontos();
            }
            else if (RBC.Text == respostaC && RBC.Checked == true)
            {
                SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.aplauso);
                IniciarPlayer.Play();
                MessageBox.Show("Alternativa Correta", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                gerapontos();
            }
            else if (RBD.Text == respostaC && RBD.Checked == true)
            {
                SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.aplauso);
                IniciarPlayer.Play();
                MessageBox.Show("Alternativa Correta", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                gerapontos();
            }
            else if (RBA.Checked != true && RBB.Checked != true && RBC.Checked != true && RBD.Checked != true)
            {
                MessageBox.Show("Escolha uma Alternativa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.Boo);
                IniciarPlayer.Play();
                MessageBox.Show("Resposta errada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();

            }
        }

        private void BT_confirm_Click(object sender, EventArgs e)
        {
            verResposta();
        }
    }
}
