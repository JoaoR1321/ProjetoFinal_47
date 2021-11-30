using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoRicardo_Projeto_47.code.dto
{
    class DadosDTO
    {
        private int _id;
        private string _jrfg;
        private string j01;
        private string g13;

        public int Id { get => _id; set => _id = value; }
        public string Jrfg { get => _jrfg; set => _jrfg = value; }
        public string J01 { get => j01; set => j01 = value; }
        public string G13 { get => g13; set => g13 = value; }
    }
}