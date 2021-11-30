using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoaoRicardo_Projeto_47.ui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            Form3 user = new Form3();
            user.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form1 dados = new Form1();
            dados.ShowDialog();
        }
    }
}
