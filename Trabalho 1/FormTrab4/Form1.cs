using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTrab4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lLblEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tente usar a soma dos números desse RU: 3989950",
                            "Dica de senha",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtUsuario.Text != "oliveira"))
            {
                MessageBox.Show("Usuário inválido",
                                "Campo obrigatório",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
               if ((txtSenha.Text == "") || (txtSenha.Text != "43"))
            {
                MessageBox.Show("Senha incorreta",
                                "Campo obrigatório",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
        }
    }
}
