using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadUser.AcessoBD;

namespace CadUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsBanco objBanco = new ClsBanco();

                objBanco.CodUsuario = Convert.ToInt32(TxtCod.Text);
                objBanco.Senha = Convert.ToInt32(TxtSenha.Text);
                objBanco.NomeUsuario = TxtNome.Text;

                int status;
                status = objBanco.Gravar();
                //Verifica o retorno da gravação
                if (status != 0)
                {
                    MessageBox.Show("Gravação com suceso!!", "SUCESSO");
                }
                else
                {
                    MessageBox.Show("Erro na gravação!!", "*** ERRO ***");
                }
                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro..." + erro.Message);
            }
        }

        private void LimparCampos()
        {
            TxtCod.Text = "";
            TxtSenha.Text = "";
            TxtNome.Text = "";
            TxtCod.Focus();
        }
    }
}
