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
    public partial class Form3 : Form
    {
        DadosBLL dat = new DadosBLL();
        DadosDTO dado = new DadosDTO();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            dado.Jrfg = txtJRFG.Text;
            dado.J01= txtJ01.Text;
            dado.G13= txtG13.Text;

            dat.Inserir(dado);

            txtJRFG.Clear();
            txtJ01.Clear();
            txtG13.Clear();

            dtgDados.DataSource = dat.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dado.Jrfg = txtJRFG.Text;
            dado.J01 = txtJ01.Text;
            dado.G13 = txtG13.Text;

            dat.Alterar(dado);

            txtJRFG.Clear();
            txtJ01.Clear();
            txtG13.Clear();

            dtgDados.DataSource = dat.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dado.Id = int.Parse(txtID.Text);

            dat.Excluir(dado);

            txtID.Clear();

            dtgDados.DataSource = dat.Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtJRFG.Text = txtID.Text = dtgDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtJ01.Text = dtgDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtG13.Text = dtgDados.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
