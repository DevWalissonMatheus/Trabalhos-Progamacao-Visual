using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trabalho_2
{
    public partial class menu_principal : Form
    {
        Thread t2;
        public menu_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(nJ2);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void nJ2(object obj)
        {
            Application.Run(new cad_peca());
        }

        private void btn_cnspeca_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(nJ3);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void nJ3(object obj)
        {
            Application.Run(new cns_peca());
        }

        private void btn_excpeca_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(nJ4);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void nJ4(object obj)
        {
            Application.Run(new fExclusao());
        }
    }
}
