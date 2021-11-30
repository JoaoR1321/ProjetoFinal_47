using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoaoRicardo_Projeto_47.code.dal;
using JoaoRicardo_Projeto_47.code.dto;
using System.Data;

namespace JoaoRicardo_Projeto_47.code.bll
{
    class DadosBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "tbl_dados";

        public void Inserir(DadosDTO dado)
        {
            string inserir = $"insert into {tabela} values(null, '{dado.Jrfg}', '{dado.J01}', '{dado.G13}')";
            conexao.ExecutarComando(inserir);
        }

        public void Alterar(DadosDTO dado)
        {
            string alterar = $@"update {tabela} set dado1 = '{dado.Jrfg}',
                                dado2 ='{dado.J01}',
                                dado3 ='{dado.G13}' where id ='{dado.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(DadosDTO dado)
        {
            string excluir = $"delete from {tabela} where id = {dado.Id}";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return conexao.ExecutarConsulta(listar);
        }
    }
}
