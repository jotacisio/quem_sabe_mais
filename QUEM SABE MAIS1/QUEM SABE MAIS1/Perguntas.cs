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
    class Perguntas : Form
    {
        
        //Vetor que guarda as perguntas, respostas, alternativas, pontuação e categoria
        public string[] pergunta11 = new string[8] { "Este famoso rapper branco de detroit ganhou inúmeros prêmios, tanto na música e cinema:", "Eminem", "Ben Afleck", "Eminem", "Rupee", "Eamon", "100" , "Música" };
        public string[] pergunta12 = new string[8] { "Qual o gênero musical da Banda AC/DC:", "Rock and roll", "Rock and roll", "Classic Rock", "Hard core", "Hip Hop", "200", "Música" };
        public string[] pergunta13 = new string[8] { "Bob Marley morreu de quê?", "De uma ferida no Pé", "De tanto fumar maconha", "De tanto cantar", "Overdose", "De uma ferida no Pé", "300", "Música" };
        public string[] pergunta14 = new string[8] { "Este MC jamaicano foi premiado com dois Grammy em sua carreira, mas eles foram roubados na década de 90:", "Shabba Ranks", "Ziggy Marley", "Toots Hibbert", "Shabba Ranks", "Bob Marley", "400", "Música" };
        public string[] pergunta15 = new string[8] { "O albúm musical mais vendido da historia da música:", "Thriller", "Back In Black", "Thriller", "The Immaculate Collection", "Dangerous", "500", "Música" };

        public string[] pergunta21 = new string[8] { "Qual o nome de Deus:", "Jeová ou Javé", "Jeová ou Javé", "Somente Deus", "Ala", "Senhor", "100", "A Bíblia" };
        public string[] pergunta22 = new string[8] { "Deus criou os céus e a terra neste dia:", "Primeiro dia", "Segundo dia", "Sétimo dia", "Quinto dia", "Primeiro dia", "200", "A Bíblia" };
        public string[] pergunta23 = new string[8] { "Onde esta a oração do pai nosso na Bíblia:", "Mateus capítulo 6", "Mateus capítulo 6", "João capítulo 4", "Mateus capítulo 8", "Lucas capítulo 9", "300", "A Bíblia" };
        public string[] pergunta24 = new string[8] { "Qual o maior missionario bíblico?", "Paulo", "Pedro", "Silas", "Paulo", "João", "400", "A Bíblia" };
        public string[] pergunta25 = new string[8] { "Onde se encontra na bíblia, o conceito de Frutos do Espírito?", "Galatas 5:19-21", "Eclesiastes 9:5", "Galatas 5:19-21", "Matheus 24:14-16", "Salmos 83:18", "500", "A Bíblia" };

        public string[] pergunta31 = new string[8] { "Ator Principal do filme I am Legend:", "Will Smith", "Will Smith", "Ray Charles", "Nicolas Cage", "Martin Lawrence", "100", "Filme" };
        public string[] pergunta32 = new string[8] { "Qual é o filme brasileiro indicado para o oscar com Fernada Montenegro em 1999?", "Central do Brasil", "O auto da compadecida", "Central do Brasil", "A vida é bela", "Assalto ao banco Central", "200", "Filme" };
        public string[] pergunta33 = new string[8] { "Esta premiação é responsável por honrar ilustres atores e atrizes :", "Academy Awards", "Vibe Awards", "Grammy Awards", "Academy Awards", "Source Awards", "300", "Filme" };
        public string[] pergunta34 = new string[8] { "Eminem é a estrela deste filme:", "8 Mile", "8 Mile", "Rap Game", "Detroit Kingpin", "Taxi", "400", "Filme" };
        public string[] pergunta35 = new string[8] { "Qual o planeta de origem do SUPER-HOMEM?", "Krypton", "Kryptonia", "Júpter", "Marte", "Krypton", "500", "Filme" };

        public string[] pergunta41 = new string[8] { "Clube brasileiro com o maior numero de títulos Nacionais:", "Palmeiras", "Palmeiras", "Flamengo", "Botafogo", "Fluminense", "100", "Esporte" };
        public string[] pergunta42 = new string[8] { "Este boxeador tirou um grande pedaço da orelha do companheiro de boxe durante uma luta, na década de 90:", "Mike Tyson", "Lennox Lewis", "Mike Tyson", "Muhammad Ali", "George Foreman", "200", "Esporte" };
        public string[] pergunta43 = new string[8] { "Jogador de Basquete que fez o maior numero de pontos em uma partida", "Wilt chamberlaim", "Michael Jordan", "Kobe Briant(Black Mamba)", "Wilt chamberlaim", "Shaquile O'neal(Shaq)", "300", "Esporte" };
        public string[] pergunta44 = new string[8] { "MVP(jogador mais valioso) da NBA no ano de 2011", "Derick Rose", "Allen Iverson", "Derick Rose", "Ron Artest", "Nate Robinson(Little Highflyer)", "400", "Esporte" };
        public string[] pergunta45 = new string[8] { "Cruyff jogou nessa seleção:", "Holanda", "Inglaterra", "Brasil", "Holanda", "Argentina", "500", "Esporte" };

        public string[] pergunta51 = new string[8] { "Aluno mais inteligente da turma:", "Lucas Torres", "Jotacísio", "Matheus Romano", "Lucas Matheus", "Lucas Torres", "100", "2.401.1m" };
        public string[] pergunta52 = new string[8] { "Menor aluno da turma:", "Ana Paula", "Eldér", "Lucas Matheus", "Ana Paula", "Lucas Torres", "200", "2.401.1m" };
        public string[] pergunta53 = new string[8] { "Mais bagunceiro da turma:", "Ashaphy", "Ashaphy", "Victor", "Welle", "Regina", "300", "2.401.1m" };
        public string[] pergunta54 = new string[8] { "O dorminhoco da turma:", "Matheus Romano", "Ashaphy", "Matheus Romano", "Jotacísio", "Gabriel", "400", "2.401.1m" };
        public string[] pergunta55 = new string[8] { "Melhor professor da turma:", "Alicson", "Edilene", "Alicson", "Gilson", "Marcos Aurélio", "500", "2.401.1m" };
        //Perguntas Bônus
        public string[] perguntaB1 = new string[8] { "QUAL A REGIÃO DO BRASIL QUE PREDOMINA O CLIMA TROPICAL SEMI-ÁRIDO?", "NORDESTE", "SUL", "NORTE", "NORDESTE", "SUDESTE", "50", "GEOGRAFIA" };
        public string[] perguntaB2 = new string[8] { "QUAL A CAPITAL DO CHILE?", "SANTIAGO", "CABUL", "SANTIAGO", "BUENOS AIRES", "MADRID", "50", "GEOGRAFIA" };
        public string[] perguntaB3 = new string[8] { "A QUE ELEMENTO QUÍMICO DA TABELA PERIÓDICA CORRESPONDE O SÍMBOLO ' Tb'?", "TÉRBIO", "TERÍBIO", "TÉRBIO", "TALÍO", "TARIO", "50", "QUÍMICA" };
        public string[] perguntaB4 = new string[8] { "O COLISEU É UM MONUMENTO HISTÓRICO DE QUE CIDADE EUROPÉIA?", "ROMA", "COPENHAGUE", "PARIS", "ROMA", "LONDRES", "50", "HISTORIA" };
        public string[] perguntaB5 = new string[8] { "QUANTOS PONTOS MARCA O PILOTO QUE VENCE UMA CORRIDA NA FÓRMULA MUNDIAL OU CONHECIDO PORPULARMENTE COMO FORMULA 1?", "20", "12", "15", "7", "20", "50", "ESPORTE" };

        public string[] perguntaB6 = new string[8] { "QUANDO COMEÇOU E TERMINOU A PRIMEIRA GUERRA MUNDIAL?", "1914-1918", "1914-1918", "1942-1948", "1914-1920", "1916-1920", "50", "HISTORIA" };
        public string[] perguntaB7 = new string[8] { "O FBI, É A POLÍCIA FEDERAL DE QUÊ PAÍS?", "ESTADOS UNIDOS", "ESTADOS UNIDOS", "ENGLATERRA", "CANADA", "MOSCOU", "50", "CONHECIMENTOS GERAIS" };
        public string[] perguntaB8 = new string[8] { "QUAL O NOME DO PATRIARCA DA INDEPENDÊNCIA DO BRASIL?", "JOSÉ BONIFÁCIO", "TIRADENTES", "JOSÉ BONIFÁCIO", "DOM PEDRO II", "VASCO DA GAMA", "50", "HISTORIA" };
        public string[] perguntaB9 = new string[8] { "O ESTREITO DE GIBRALTAR FICA ENTRE:", "ESPANHA E MARROCOS", "NORUEGA E DINAMARCA", "ESPANHA E MARROCOS", "PORTUGAL E ESPANHA", "SUIÇA E SUÉCIA", "50", "GEOGRAFIA" };
        public string[] perguntaB10 = new string[8] { "O QUE É O SOL ?", "ESTRELA", "COMETA", "PLANETA", "ESTRELA", "METEÓRO", "50", "CIÊNCIAS" };
    }
}
