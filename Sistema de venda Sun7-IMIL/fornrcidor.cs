using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sistema_de_venda_Sun7_IMIL
{
    public partial class fornrcidor : Form
    {
        public fornrcidor()
        {
            InitializeComponent();
        }
        Class_conex c3 = new Class_conex();
        DataTable tab3 = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void Add()
        {
            try
            {
                tab3.Clear();
                string cod2 = ("select *From Fornecidores");
                c3.adp1.SelectCommand = new OleDbCommand(cod2, c3.c1);
                c3.adp1.Fill(tab3);
                dataGridView1.DataSource = tab3;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
        private void fornrcidor_Load(object sender, EventArgs e)
        {
            Add();
        }

        private void Dgv_For_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lk_volt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }
    }
}
