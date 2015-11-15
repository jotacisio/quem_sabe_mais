using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace QUEM_SABE_MAIS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); BT_jogar.Select();
        }

        private void BT_jogar_Click_1(object sender, EventArgs e)
        {
            Form7 objform7 = new Form7();
            objform7.Show();
            SoundPlayer IniciarPlayer = new SoundPlayer(Properties.Resources.DingDong);
            IniciarPlayer.Play();
        }

    }
}
