using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Drawing.Text;

namespace Trabalho_2
{
    public partial class Login : Form
    {
        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void tab_curso_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (usuario == "maycon" && senha == "26")
            {
                MessageBox.Show("Bem-vindo, Maycon!");
                this.Close();
                t1 = new Thread(nJ1);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else if (usuario == "walisson" && senha == "43")
            {
                MessageBox.Show("Bem-vindo, Walisson");
                this.Close();
                t1 = new Thread(nJ1);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
        private void nJ1(object obj)
        {
            Application.Run(new menu_principal());
        }

        private void lkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tente usar a soma de um desses RUs Maycon 3903722 ou Walisson 3989950",
                            "Dica de senha",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
        }
    }
}