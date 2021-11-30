using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace JoaoRicardo_Projeto_47.code.dal
{
    class Conexao
    {
            MySqlConnection conexao;

            public void Conectar()
            {
                try
                {
                    string conn = "Persist Security Info = false; "
                    "server = localhost; "
                    "database = ProjetoFinal; "
                "uid = root; pwd=";
                    conexao = new MySqlConnection(conn);
                    conexao.Open();
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Conexão não estabelecida!\n" + ex.Message);
                }
            }

            public void ExecutarComando(string sql)
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();

            }

            public DataTable ExecutarConsulta(string sql)
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
        }
}
