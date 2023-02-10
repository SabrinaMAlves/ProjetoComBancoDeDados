using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_12_Sabrina_Relac_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Clientes tl_clientes = new frm_Clientes();
            tl_clientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Produtos tl_produtos = new frm_Produtos();
            tl_produtos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Vendas tl_vendas = new frm_Vendas();
            tl_vendas.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e) // Em MENU ele indica para qual tabela deseja visualizar 
        {
            frm_Clientes tl_clientes = new frm_Clientes();
            tl_clientes.Show();
        } 

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e) // Em MENU ele indica para qual tabela deseja visualizar 
        {
            frm_Produtos tl_produtos = new frm_Produtos();
            tl_produtos.Show();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e) // Em MENU ele indica para qual tabela deseja visualizar 
        {
            frm_Vendas tl_vendas = new frm_Vendas();
            tl_vendas.Show();
        }
    }
}
