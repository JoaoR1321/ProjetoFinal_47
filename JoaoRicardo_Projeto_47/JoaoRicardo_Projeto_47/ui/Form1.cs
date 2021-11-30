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

namespace JoaoRicardo_Projeto_47
{
    public partial class Form1 : Form
    {
        UsuarioBLL user = new UsuarioBLL();
        UsuarioDTO usuario = new UsuarioDTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuario.Nm = txtNome.Text;
            usuario.Tlf= txtTelefone.Text;
            usuario.R = txtRua.Text;
            usuario.Nmr = txtNumero.Text;
            usuario.Brr = txtBairro.Text;
            usuario.Cdd = txtCidade.Text;
            usuario.Etd  = txtEstado.Text;
            usuario.P = txtPais.Text;
            usuario.Cpf = txtCPF.Text;
            usuario.Rg = txtRG.Text;
            usuario.Dtn = dtDataNascimento.Text;
            usuario.Email = txtEmail.Text;
            usuario.Pwd = txtSenha.Text;

            user.Inserir(usuario);

            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dtgUsuarios.DataSource = user.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            usuario.Nm = txtNome.Text;
            usuario.Tlf = txtTelefone.Text;
            usuario.R = txtRua.Text;
            usuario.Nmr = txtNumero.Text;
            usuario.Brr = txtBairro.Text;
            usuario.Cdd = txtCidade.Text;
            usuario.Etd = txtEstado.Text;
            usuario.P = txtPais.Text;
            usuario.Cpf = txtCPF.Text;
            usuario.Rg = txtRG.Text;
            usuario.Dtn = dtDataNascimento.Text;
            usuario.Email = txtEmail.Text;
            usuario.Pwd = txtSenha.Text;

            user.Alterar(usuario);

            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dtgUsuarios.DataSource = user.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            usuario.Id = int.Parse(txtId.Text);

            user.Inserir(usuario);

            txtId.Clear();

            dtgUsuarios.DataSource = user.Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRua.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = dtgUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dtgUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstado.Text = dtgUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPais.Text = dtgUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCPF.Text = dtgUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtRG.Text = dtgUsuarios.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtEmail.Text = dtgUsuarios.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtSenha.Text = dtgUsuarios.Rows[e.RowIndex].Cells[12].Value.ToString();
        }
    }
}
