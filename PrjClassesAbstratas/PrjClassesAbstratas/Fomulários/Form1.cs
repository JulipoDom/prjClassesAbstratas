using PrjClassesAbstratas.Fomulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjClassesAbstratas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuCadastros_Click(object sender, EventArgs e)
        {
            FrmCadastro Cadastro = new FrmCadastro();
            Cadastro.MdiParent = this;
            Cadastro.Show();
        }
    }
}
