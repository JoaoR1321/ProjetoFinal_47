using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoaoRicardo_Projeto_47.code.bll;
using JoaoRicardo_Projeto_47.code.dto;

namespace JoaoRicardo_Projeto_47.ui
{
    public partial class Login : Form
    {
        UsuarioBLL user = new UsuarioBLL();
        UsuarioDTO usuario = new UsuarioDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text;
            usuario.Cpf = txtCpf.Text;
            usuario.Pwd = txtSenha.Text;

            if (user.Log(usuario) == true)
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }
    }
}
