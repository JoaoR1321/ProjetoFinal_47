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
    class UsuarioBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "tbl_usuarios";

        public void Inserir(UsuarioDTO usuario)
        {
            string inserir = $"insert into {tabela} values(null, '{usuario.Nm}', '{usuario.Tlf}', '{usuario.R}', '{usuario.Nmr}', '{usuario.Brr}', '{usuario.Cdd}', '{usuario.Etd}', '{usuario.P}', '{usuario.Cpf}', '{usuario.Rg}', '{usuario.Dtn}', '{usuario.Email}', '{usuario.Pwd}')";
            conexao.ExecutarComando(inserir);
        }

        public void Alterar(UsuarioDTO usuario)
        {
            string alterar = $@"update {tabela} set nome = '{usuario.Nm}',
                                telefone ='{usuario.Tlf}',
                                rua ='{usuario.R}',
                                numero ='{usuario.Nmr}',
                                bairro ='{usuario.Brr}',
                                cidade ='{usuario.Cdd}',
                                estado ='{usuario.Etd}',
                                pais ='{usuario.P}',
                                cpf ='{usuario.Cpf}',
                                rg ='{usuario.Rg}',
                                dataNascimento ='{usuario.Dtn}',
                                email ='{usuario.Email}',
                                senha ='{usuario.Pwd}' where id ='{usuario.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(UsuarioDTO usuario)
        {
            string excluir = $"delete from {tabela} where id = {usuario.Id}";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return conexao.ExecutarConsulta(listar);
        }

        public bool Log(UsuarioDTO usuario)
        {
            string sql = $"select * from {tabela} where email ='{usuario.Email}' and senha ='{usuario.Pwd}' and cpf ='{usuario.Cpf}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}