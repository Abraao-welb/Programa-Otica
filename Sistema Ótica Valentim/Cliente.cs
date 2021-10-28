using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ótica_Valentim;
using ClassLibrary1;
using System.Data.Sql;
using System.Data.SqlClient;
using 

namespace Sistema_Ótica_Valentim
{
    public partial class frm_cad_cliente : Form
    {
        public frm_cad_cliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection comn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=db_sistema;Integrated Security=True");

            string sql = "INSERT INTO pessoas(id_cliente, Nome, Telefone, Dados) VALUES (@id_cliente, @Nome, @Telefone, @Dados)";
            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, comn);

                c.Parameters.Add(new SqlParameter("@id_cliente", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.cxTelefone.Text));
                c.Parameters.Add(new SqlParameter("@Dados", this.txtDados.Text));

                comn.Open();

                c.BeginExecuteNonQuery();

                comn.Close();

                MessageBox.Show("Enviado com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            } 
            finally
            {
                comn.Close();
            }
        }
    }
}

