using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClassesAbstratas.Classes
{
    class ClsProfessor : ClsPessoa
    {

        private string _licenciatura;
        private string _categoria;

        public string Licenciatura { get => _licenciatura; set => _licenciatura = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }

        public ClsProfessor()
        {
            _licenciatura = "";
            _categoria = "";
        }

        public override string Incluir()
        {
            return "Dados do professor incluídos com sucesso:\n"
            + Cpf + " \n"
            + Nome + "\n"
            + Endereco + "\n"
            + Licenciatura + "\n"
            + Categoria;
        }
    }
}
