using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Trabalho_2
{
    public partial class cad_peca : Form
    {
        Thread t3;
        public cad_peca()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cad_peca_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;database=pecas;username=root;password=2402;";
            MySqlConnection conexao = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;

            try
            {
                conexao.Open();
                string sqlpecas = "insert into cadastrar (numero_serie, nome_peca, fabricante, modelo)" +
                                  " values " +
                                  " ('" + txt_nserie.Text + "', '" + txt_nomepeca.Text + "', '" + txt_fab.Text + "', '" + txt_mod.Text + "')";
                comando.CommandText = sqlpecas;

                comando.ExecuteReader();
                
                MessageBox.Show("Cadastramento realizado com sucesso!");
            }
            catch (MySqlException) 
            {
                MessageBox.Show("Não foi possivel se conectar ao Banco de Dados");
            }
            finally 
            { 
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
            this.Close();
            t3 = new Thread(nJ4);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void nJ4(object obj)
        {
            Application.Run(new menu_principal());
        }

        private void btnMprincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(nJ6);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void nJ6(object obj)
        {
            Application.Run(new menu_principal());
        }
    }
}
