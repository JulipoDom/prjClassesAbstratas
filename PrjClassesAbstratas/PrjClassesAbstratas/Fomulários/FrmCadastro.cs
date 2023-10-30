using PrjClassesAbstratas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjClassesAbstratas.Fomulários
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0) 
            {
                foreach (TextBox Texto in grpProf.Controls)
                {
                    Texto.Text = "";
                }
            }
            else
            {
                foreach (TextBox Texto in GrpAluno.Controls)
                {
                    Texto.Text = "";
                }
            }
            lblStatus.Text = "";
        }

        private void BtnExcluirAluno_Click(object sender, EventArgs e)
        {
            ClsAluno ObjAluno = new ClsAluno();

            if (txtCpfAluno.Text != "")
            {
                lblStatus.Text = ObjAluno.Excluir();
            }
            else
            {
                lblStatus.Text = "ATENÇÃO: Digite o número do CPF para exclusão!!";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ClsProfessor ObjProfessor = new ClsProfessor();

            if (txtCpf.Text != "")
            {

                lblStatus.Text = ObjProfessor.Excluir();
            }
            else
            {
                lblStatus.Text = "ATENÇÃO: Digite o número do CPF para exclusão!!";
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            ClsProfessor ObjProfessor = new ClsProfessor();
            ObjProfessor.Cpf = txtCpf.Text;
            ObjProfessor.Nome = txtName.Text;
            ObjProfessor.Endereco = txtEnd.Text;
            ObjProfessor.Licenciatura = txtLicen.Text;
            ObjProfessor.Categoria = txtCate.Text;

            lblStatus.Text = ObjProfessor.Incluir();

        }

        private void BtnIncluirAluno_Click(object sender, EventArgs e)
        {
            ClsAluno ObjAluno = new ClsAluno();

            ObjAluno.Cpf = txtCpfAluno.Text;
            ObjAluno.Nome = txtNomeAluno.Text;
            ObjAluno.Endereco = txtEndAluno.Text;
            ObjAluno.Turma = txtTurma.Text;
            ObjAluno.Curso = txtCurso.Text;


            lblStatus.Text = ObjAluno.Incluir();

        }
    }
}
