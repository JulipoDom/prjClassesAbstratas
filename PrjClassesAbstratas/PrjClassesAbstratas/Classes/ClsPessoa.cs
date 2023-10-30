using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClassesAbstratas.Classes
{
    public abstract class ClsPessoa
    {
        private string _cpf;
        private string _nome;
        private string _endereco;

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }

        public ClsPessoa()
        {
            _cpf = "";
            _nome = "";
            _endereco = "";
        }

        public abstract string Incluir();

        public string Excluir()
        {
            return "Dados excluídos com sucesso!!!";
        }
    }
}
