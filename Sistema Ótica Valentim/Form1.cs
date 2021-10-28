using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ótica_Valentim
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_cliente frm = new frm_cad_cliente();
            frm.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_cad_cliente frm = new frm_cad_cliente();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_cs_cliente frm = new frm_cs_cliente();
            frm.Show();
        }

        private void btn_cs_cliente_Click(object sender, EventArgs e)
        {
        frm_cs_cliente frm = new frm_cs_cliente();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();
            frm.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_caixa frm = new frm_caixa();
            frm.Show();
        }
    }
}
