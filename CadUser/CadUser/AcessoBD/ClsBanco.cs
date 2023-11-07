using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CadUser.AcessoBD
{
    class ClsBanco
    {
        string strConexao = Properties.Settings.Default.ConexaoBD;

        OleDbConnection conn = null;

        private int codUsuario;

        private int senha;

        private string nomeUsuario;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }

        public int Senha { get => senha; set => senha = value; }

        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }

        public ClsBanco()
        {
            conn = new OleDbConnection(strConexao);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao abrir arquivo...");
            }
        }

        public int Gravar()
        {
            OleDbCommand comando = new OleDbCommand();

            comando.CommandType = CommandType.Text;

            comando.Parameters.Add("@varCodigo", oleDbType: OleDbType.Integer).Value = codUsuario;
            comando.Parameters.Add("@varSenha", oleDbType: OleDbType.Integer).Value = senha;
            comando.Parameters.Add("@varNome", oleDbType: OleDbType.VarChar, 50).Value = nomeUsuario;

            comando.CommandText = "Insert into Usuario (CodUsuario, Senha, Nome) values (@varCodigo, @varSenha, @varNome)";

            comando.Connection = conn;

            int status = comando.ExecuteNonQuery();

            conn.Close();

            return status;

        }

    }
}
