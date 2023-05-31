using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Threading;

namespace Trabalho_2
{
    public partial class cns_peca : Form
    {
        Thread t4;
        public cns_peca()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private void PreencherDataGridView()
        {
            string conexaoString = "datasource=127.0.0.1;database=pecas;username=root;password=2402;";
            string consultaSQL = "SELECT * FROM cadastrar;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                using (MySqlCommand comando = new MySqlCommand(consultaSQL, conexao))
                {
                    MySqlCommand command = new MySqlCommand(consultaSQL, conexao);
                    
                    try
                    {
                        conexao.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
                PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t4 = new Thread(nJ5);
            t4.SetApartmentState(ApartmentState.STA);
            t4.Start();
        }
        private void nJ5(object obj)
        {
            Application.Run(new menu_principal());
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}