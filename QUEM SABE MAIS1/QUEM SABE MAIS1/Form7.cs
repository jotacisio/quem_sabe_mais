using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUEM_SABE_MAIS
{
    public partial class Form7 : Form
    {
        public int ppt;

        public Form7()
        {
            InitializeComponent();
        }
        public void pegaPergunta(string st)
        {
            Form3 OBJ_Form3 = new Form3(this);

            Perguntas Perguntas = new Perguntas();
            //vetores que armazenam pergunta apartir da classe Pergunta
            string[] pp = Perguntas.pergunta11;
            string[] pp2 = Perguntas.pergunta12;
            string[] pp3 = Perguntas.pergunta13;
            string[] pp4 = Perguntas.pergunta14;
            string[] pp5 = Perguntas.pergunta15;

            string[] pp6 = Perguntas.pergunta21;
            string[] pp7 = Perguntas.pergunta22;
            string[] pp8 = Perguntas.pergunta23;
            string[] pp9 = Perguntas.pergunta24;
            string[] pp10 = Perguntas.pergunta25;

            string[] pp11 = Perguntas.pergunta31;
            string[] pp12 = Perguntas.pergunta32;
            string[] pp13 = Perguntas.pergunta33;
            string[] pp14 = Perguntas.pergunta34;
            string[] pp15 = Perguntas.pergunta35;

            string[] pp16 = Perguntas.pergunta41;
            string[] pp17 = Perguntas.pergunta42;
            string[] pp18 = Perguntas.pergunta43;
            string[] pp19 = Perguntas.pergunta44;
            string[] pp20 = Perguntas.pergunta45;

            string[] pp21 = Perguntas.pergunta51;
            string[] pp22 = Perguntas.pergunta52;
            string[] pp23 = Perguntas.pergunta53;
            string[] pp24 = Perguntas.pergunta54;
            string[] pp25 = Perguntas.pergunta55;
            //Perguntas Bônus
            string[] ppB1 = Perguntas.perguntaB1;
            string[] ppB2 = Perguntas.perguntaB2;
            string[] ppB3 = Perguntas.perguntaB3;
            string[] ppB4 = Perguntas.perguntaB4;
            string[] ppB5 = Perguntas.perguntaB5;

            string[] ppB6 = Perguntas.perguntaB6;
            string[] ppB7 = Perguntas.perguntaB7;
            string[] ppB8 = Perguntas.perguntaB8;
            string[] ppB9 = Perguntas.perguntaB9;
            string[] ppB10 = Perguntas.perguntaB10;

            switch (st)
            {
                //pega cada vetor e add no gerapergunta
                case "11": OBJ_Form3.geraPergunta(pp[0], pp[1], pp[2], pp[3], pp[4], pp[5], pp[6], pp[7]); break;
                case "12": OBJ_Form3.geraPergunta(pp2[0], pp2[1], pp2[2], pp2[3], pp2[4], pp2[5], pp2[6], pp2[7]); break;
                case "13": OBJ_Form3.geraPergunta(pp3[0], pp3[1], pp3[2], pp3[3], pp3[4], pp3[5], pp3[6], pp3[7]); break;
                case "14": OBJ_Form3.geraPergunta(pp4[0], pp4[1], pp4[2], pp4[3], pp4[4], pp4[5], pp4[6], pp4[7]); break;
                case "15": OBJ_Form3.geraPergunta(pp5[0], pp5[1], pp5[2], pp5[3], pp5[4], pp5[5], pp5[6], pp5[6]); break;

                case "21": OBJ_Form3.geraPergunta(pp6[0], pp6[1], pp6[2], pp6[3], pp6[4], pp6[5], pp6[6], pp6[7]); break;
                case "22": OBJ_Form3.geraPergunta(pp7[0], pp7[1], pp7[2], pp7[3], pp7[4], pp7[5], pp7[6], pp7[7]); break;
                case "23": OBJ_Form3.geraPergunta(pp8[0], pp8[1], pp8[2], pp8[3], pp8[4], pp8[5], pp8[6], pp8[7]); break;
                case "24": OBJ_Form3.geraPergunta(pp9[0], pp9[1], pp9[2], pp9[3], pp9[4], pp9[5], pp9[6], pp9[7]); break;
                case "25": OBJ_Form3.geraPergunta(pp10[0], pp10[1], pp10[2], pp10[3], pp10[4], pp10[5], pp10[6], pp10[7]); break;

                case "31": OBJ_Form3.geraPergunta(pp11[0], pp11[1], pp11[2], pp11[3], pp11[4], pp11[5], pp11[6], pp11[7]); break;
                case "32": OBJ_Form3.geraPergunta(pp12[0], pp12[1], pp2[2], pp12[3], pp12[4], pp12[5], pp12[6], pp12[7]); break;
                case "33": OBJ_Form3.geraPergunta(pp13[0], pp13[1], pp13[2], pp13[3], pp13[4], pp13[5], pp13[6], pp13[7]); break;
                case "34": OBJ_Form3.geraPergunta(pp14[0], pp14[1], pp14[2], pp14[3], pp14[4], pp14[5], pp14[6], pp14[7]); break;
                case "35": OBJ_Form3.geraPergunta(pp15[0], pp15[1], pp15[2], pp15[3], pp15[4], pp15[5], pp15[6], pp15[7]); break;

                case "41": OBJ_Form3.geraPergunta(pp16[0], pp16[1], pp16[2], pp16[3], pp16[4], pp16[5], pp16[6], pp16[7]); break;
                case "42": OBJ_Form3.geraPergunta(pp17[0], pp17[1], pp17[2], pp17[3], pp17[4], pp17[5], pp17[6], pp17[7]); break;
                case "43": OBJ_Form3.geraPergunta(pp18[0], pp18[1], pp18[2], pp18[3], pp18[4], pp18[5], pp18[6], pp18[7]); break;
                case "44": OBJ_Form3.geraPergunta(pp19[0], pp19[1], pp19[2], pp19[3], pp19[4], pp19[5], pp19[6], pp19[7]); break;
                case "45": OBJ_Form3.geraPergunta(pp20[0], pp20[1], pp20[2], pp20[3], pp20[4], pp20[5], pp20[6], pp20[7]); break;

                case "51": OBJ_Form3.geraPergunta(pp21[0], pp21[1], pp21[2], pp21[3], pp21[4], pp21[5], pp21[6], pp21[7]); break;
                case "52": OBJ_Form3.geraPergunta(pp22[0], pp22[1], pp22[2], pp22[3], pp22[4], pp22[5], pp22[6], pp22[7]); break;
                case "53": OBJ_Form3.geraPergunta(pp23[0], pp23[1], pp23[2], pp23[3], pp23[4], pp23[5], pp23[6], pp23[7]); break;
                case "54": OBJ_Form3.geraPergunta(pp24[0], pp24[1], pp24[2], pp24[3], pp24[4], pp24[5], pp24[6], pp24[7]); break;
                case "55": OBJ_Form3.geraPergunta(pp25[0], pp25[1], pp25[2], pp25[3], pp25[4], pp25[5], pp25[6], pp25[7]); break;

                case "B1": OBJ_Form3.geraPergunta(ppB1[0], ppB1[1], ppB1[2], ppB1[3], ppB1[4], ppB1[5], ppB1[6], ppB1[7]); break;
                case "B2": OBJ_Form3.geraPergunta(ppB2[0], ppB2[1], ppB2[2], ppB2[3], ppB2[4], ppB2[5], ppB2[6], ppB2[7]); break;
                case "B3": OBJ_Form3.geraPergunta(ppB3[0], ppB3[1], ppB3[2], ppB3[3], ppB3[4], ppB3[5], ppB3[6], ppB3[7]); break;
                case "B4": OBJ_Form3.geraPergunta(ppB4[0], ppB4[1], ppB4[2], ppB4[3], ppB4[4], ppB4[5], ppB4[6], ppB4[7]); break;
                case "B5": OBJ_Form3.geraPergunta(ppB5[0], ppB5[1], ppB5[2], ppB5[3], ppB5[4], ppB5[5], ppB5[6], ppB5[7]); break;

                case "B6": OBJ_Form3.geraPergunta(ppB6[0], ppB6[1], ppB6[2], ppB6[3], ppB6[4], ppB6[5], ppB6[6], ppB6[7]); break;
                case "B7": OBJ_Form3.geraPergunta(ppB7[0], ppB7[1], ppB7[2], ppB7[3], ppB7[4], ppB7[5], ppB7[6], ppB7[7]); break;
                case "B8": OBJ_Form3.geraPergunta(ppB8[0], ppB8[1], ppB8[2], ppB8[3], ppB8[4], ppB7[5], ppB7[6], ppB7[7]); break;
                case "B9": OBJ_Form3.geraPergunta(ppB9[0], ppB9[1], ppB9[2], ppB9[3], ppB9[4], ppB8[5], ppB8[6], ppB8[7]); break;
                case "B10": OBJ_Form3.geraPergunta(ppB10[0], ppB10[1], ppB10[2], ppB10[3], ppB10[4], ppB10[5], ppB10[6], ppB10[7]); break;
            }
            OBJ_Form3.Show();
        }
        //Click nos botões da categoria MÚSICA
        //-------------------------------------------------------
        //-------------------------------------------------------
        private void BT_Musica1_Click(object sender, EventArgs e)
        {
            BT_Musica1.Enabled = false;
            BT_Musica2.Enabled = true;
            pegaPergunta("11");
        }

        private void BT_Musica2_Click(object sender, EventArgs e)
        {
            BT_Musica2.Enabled = false;
            LB_fase2.Visible = true;
            BT_Musica3.Visible = true;
            BT_Musica3.Enabled = true;
            pegaPergunta("12");
        }

        private void BT_Musica3_Click(object sender, EventArgs e)
        {
            BT_Musica3.Enabled = false;
            BT_Musica4.Visible = true;
            BT_Musica4.Enabled = true;
            pegaPergunta("13");
        }

        private void BT_Musica4_Click(object sender, EventArgs e)
        {
            BT_Musica4.Enabled = false;
            LB_fase3.Visible = true;
            BT_Musica5.Visible = true;
            BT_Musica5.Enabled = true;
            pegaPergunta("14");
        }

        private void BT_Musica5_Click(object sender, EventArgs e)
        {
            BT_Musica5.Enabled = false;
            pegaPergunta("15");
        }
        //Click nos botões da categoria A BÍBLIA
        //-------------------------------------------------------
        //-------------------------------------------------------
        private void BT_biblia1_Click(object sender, EventArgs e)
        {
            BT_biblia1.Enabled = false;
            BT_biblia2.Enabled = true;
            pegaPergunta("21");
        }

        private void BT_biblia2_Click(object sender, EventArgs e)
        {
            BT_biblia2.Enabled = false;
            LB_fase2.Visible = true;
            BT_biblia3.Visible = true;
            BT_biblia3.Enabled = true;
            pegaPergunta("22");
        }

        private void BT_biblia3_Click(object sender, EventArgs e)
        {
            BT_biblia3.Enabled = false;
            BT_biblia4.Visible = true;
            BT_biblia4.Enabled = true;
            pegaPergunta("23");
        }

        private void BT_biblia4_Click(object sender, EventArgs e)
        {
            BT_biblia4.Enabled = false;
            LB_fase3.Visible = true;
            BT_biblia5.Visible = true;
            BT_biblia5.Enabled = true;
            pegaPergunta("24");
        }

        private void BT_biblia5_Click(object sender, EventArgs e)
        {
            BT_biblia5.Enabled = false;
            pegaPergunta("25");
        }
        //Click nos botões da categoria FILME
        //-------------------------------------------------------
        //-------------------------------------------------------
        private void BT_filmes1_Click(object sender, EventArgs e)
        {
            BT_filmes1.Enabled = false;
            BT_filmes2.Enabled = true;
            pegaPergunta("31");
        }

        private void BT_filmes2_Click(object sender, EventArgs e)
        {
            BT_filmes2.Enabled = false;
            LB_fase2.Visible = true;
            BT_filmes3.Visible = true;
            BT_filmes3.Enabled = true;
            pegaPergunta("32");
        }

        private void BT_filmes3_Click(object sender, EventArgs e)
        {
            BT_filmes3.Enabled = false;
            BT_filmes4.Visible = true;
            BT_filmes4.Enabled = true;
            pegaPergunta("33");
        }

        private void BT_filmes4_Click(object sender, EventArgs e)
        {
            BT_filmes4.Enabled = false;
            LB_fase3.Visible = true;
            BT_filmes5.Visible = true;
            BT_filmes5.Enabled = true;
            pegaPergunta("34");
        }

        private void BT_filmes5_Click(object sender, EventArgs e)
        {
            BT_filmes5.Enabled = false;
            pegaPergunta("35");
        }
        //Click nos botões da categoria ESPORTE
        //-------------------------------------------------------
        //-------------------------------------------------------
        private void BT_esportes1_Click(object sender, EventArgs e)
        {
            BT_esportes1.Enabled = false;
            BT_esportes2.Enabled = true;
            pegaPergunta("41");
        }
        private void BT_esportes2_Click(object sender, EventArgs e)
        {
            BT_esportes2.Enabled = false;
            LB_fase2.Visible = true;
            BT_esportes3.Visible = true;
            BT_esportes3.Enabled = true;
            pegaPergunta("42");
        }

        private void BT_esportes3_Click(object sender, EventArgs e)
        {
            BT_esportes3.Enabled = false;
            BT_esportes4.Visible = true;
            BT_esportes4.Enabled = true;
            pegaPergunta("43");
        }

        private void BT_esportes4_Click(object sender, EventArgs e)
        {
            BT_esportes4.Enabled = false;
            LB_fase3.Visible = true;
            BT_esportes5.Visible = true;
            BT_esportes5.Enabled = true;
            pegaPergunta("44");
        }

        private void BT_esportes5_Click(object sender, EventArgs e)
        {
            BT_esportes5.Enabled = false;
            pegaPergunta("45");
        }
        //Click nos botões da categoria 2.401.1m
        //-------------------------------------------------------
        //-------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            pegaPergunta("55");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            LB_fase3.Visible = true;
            button5.Visible = true;
            button5.Enabled = true;
            pegaPergunta("54");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            button4.Enabled = true;
            pegaPergunta("53");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            LB_fase2.Visible = true;
            button3.Visible = true;
            button3.Enabled = true;
            pegaPergunta("52");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            pegaPergunta("51");
        }

        private void BT_bonus_Click_1(object sender, EventArgs e)
        {
            if (LB_pontos.Text == "100" || LB_pontos.Text == "2100" ||
                LB_pontos.Text == "2200" || LB_pontos.Text == "2300" ||
                LB_pontos.Text == "2400" || LB_pontos.Text == "2500" ||
                LB_pontos.Text == "2600" || LB_pontos.Text == "2500" ||
                LB_pontos.Text == "2700" || LB_pontos.Text == "2800" ||
                LB_pontos.Text == "2900" || LB_pontos.Text == "3000")
            {
                this.Width = 765;
            }
            else
            {
                MessageBox.Show("Você ainda não está habilitado para responder as perguntas bônus. Continue acertando e logo poderá vê-las", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BT_sair_Click_1(object sender, EventArgs e)
        {
            Form5 objform5 = new Form5();
            objform5.Show();
        }
        private void BT_B2_Click(object sender, EventArgs e)
        {
            BT_B2.Enabled = false;
            pegaPergunta("B2");
        }

        private void BT_B9_Click(object sender, EventArgs e)
        {
            BT_B9.Enabled = false;
            pegaPergunta("B9");
        }

        private void BT_B8_Click(object sender, EventArgs e)
        {
            BT_B8.Enabled = false;
            pegaPergunta("B8");
        }

        private void BT_B7_Click(object sender, EventArgs e)
        {
            BT_B7.Enabled = false;
            pegaPergunta("B7");
        }

        private void BT_B6_Click(object sender, EventArgs e)
        {
            BT_B6.Enabled = false;
            pegaPergunta("B6");
        }

        private void BT_B5_Click(object sender, EventArgs e)
        {
            BT_B5.Enabled = false;
            pegaPergunta("B5");
        }

        private void BT_B4_Click(object sender, EventArgs e)
        {
            BT_B4.Enabled = false;
            pegaPergunta("B4");
        }

        private void BT_B3_Click(object sender, EventArgs e)
        {
            BT_B3.Enabled = false;
            pegaPergunta("B3");
        }

        private void BT_B10_Click(object sender, EventArgs e)
        {
            BT_B10.Enabled = false;
            pegaPergunta("B10");
        }

        private void BT_B1_Click(object sender, EventArgs e)
        {
            BT_B1.Enabled = false;
            pegaPergunta("B1");
        }
    }
}
