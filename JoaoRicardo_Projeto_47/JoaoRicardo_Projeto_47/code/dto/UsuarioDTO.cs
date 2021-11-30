using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoRicardo_Projeto_47.code.dto
{
    class UsuarioDTO
    {
        private int _id;
        private string _nm;
        private string _tlf;
        private string _r;
        private string _nmr;
        private string brr;
        private string _cdd;
        private string _etd;
        private string _p;
        private string _cpf;
        private string _rg;
        private string _dtn;
        private string _email;
        private string pwd;

        public int Id { get => _id; set => _id = value; }
        public string Nm { get => _nm; set => _nm = value; }
        public string Tlf { get => _tlf; set => _tlf = value; }
        public string R { get => _r; set => _r = value; }
        public string Nmr { get => _nmr; set => _nmr = value; }
        public string Brr { get => brr; set => brr = value; }
        public string Cdd { get => _cdd; set => _cdd = value; }
        public string Etd { get => _etd; set => _etd = value; }
        public string P { get => _p; set => _p = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Dtn { get => _dtn; set => _dtn = value; }
        public string Email { get => _email; set => _email = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
