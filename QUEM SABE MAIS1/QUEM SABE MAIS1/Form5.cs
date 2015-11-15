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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form1 obj_form1 = new Form1();

        private void BT_novogame_Click(object sender, EventArgs e)
        {
            Hide();
            obj_form1.Show();
        }
    }
}
