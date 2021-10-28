using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sistema_Ótica_Valentim
{
    public partial class frm_cs_cliente : Form
    {
        public frm_cs_cliente()
        {
            InitializeComponent();
        }

        private void consulta_cliente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection comn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=db_sistema;Integrated Security=True");

            string sql = "INSERT INTO pessoas(id_cliente, Nome, Telefone, Dados) VALUES (@id_cliente, @Nome, @Telefone, @Dados)";
            Random numeroID = new Random();
            numeroID.Next();
        }
    }
}
