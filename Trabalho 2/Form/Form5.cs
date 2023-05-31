using MySql.Data.MySqlClient;
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

namespace Trabalho_2
{
    public partial class fExclusao : Form
    {
        Thread t5;

        public object dataGridView2Itens { get; private set; }

        public fExclusao()
        {
            InitializeComponent();
        }

        private void btnMenuPrinc_Click(object sender, EventArgs e)
        {
            this.Close();
            t5 = new Thread(nJ6);
            t5.SetApartmentState(ApartmentState.STA);
            t5.Start();
        }
        private void nJ6(object obj)
        {
            Application.Run(new menu_principal());
        }

        private void fExclusao_Load(object sender, EventArgs e)
        {
            string conexao1 = "datasource=127.0.0.1;database=pecas;username=root;password=2402;";

            using (MySqlConnection conexao = new MySqlConnection(conexao1))
            {
                try
                {
                    conexao.Open();

                    string querySelecao = "SELECT * FROM cadastrar";
                    MySqlCommand comando = new MySqlCommand(querySelecao, conexao);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro!" + ex.Message);
                }
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow lS = dataGridView2.SelectedRows[0];
                int idItem = Convert.ToInt32(lS.Cells["id_peca"].Value);

                DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir o item selecionado?",
                    "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string conexao1 = "datasource=127.0.0.1;database=pecas;username=root;password=2402;";

                    using (MySqlConnection conexao = new MySqlConnection(conexao1))
                    {
                        try
                        {
                            conexao.Open();

                            string queryExclusao = "DELETE FROM cadastrar WHERE id_peca = @id_peca";
                            MySqlCommand comando = new MySqlCommand(queryExclusao, conexao);
                            comando.Parameters.AddWithValue("@id_peca", idItem);
                            comando.ExecuteNonQuery();

                            dataGridView2.Rows.Remove(lS);

                            MessageBox.Show("Item excluido com sucesso!");

                            conexao.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro! " + ex.Message);
                        }
                }
            }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
