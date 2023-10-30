using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClassesAbstratas.Classes
{
    class ClsAluno : ClsPessoa
    {
        private string _curso;
        private string _turma;

        public string Curso { get => _curso; set => _curso = value; }
        public string Turma { get => _turma; set => _turma = value; }

        public ClsAluno()
        {
            _curso = "";
            _turma = "";
        }

        public override string Incluir()
        {
            return "Dados do Aluno incluídos com sucesso:\n"
            + Cpf + " \n"
            + Nome + "\n"
            + Endereco + "\n"
            + Curso + "\n"
            + Turma;
        }


    }
}
