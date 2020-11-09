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
    public partial class Form_rela : Form
    {
        public Form_rela()
        {
            InitializeComponent();
        }
        Class_conex c3 = new Class_conex();
        DataTable tab3 = new DataTable();

        private void Form_rela_Load(object sender, EventArgs e)
        {
            Add();
        }
        public void Add()
        {
            try
            {
                tab3.Clear();
                string cod2 = ("select *From Relatorio");
                c3.adp1.SelectCommand = new OleDbCommand(cod2, c3.c1);
                c3.adp1.Fill(tab3);
                dataGridView1.DataSource = tab3;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void lk_volt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
