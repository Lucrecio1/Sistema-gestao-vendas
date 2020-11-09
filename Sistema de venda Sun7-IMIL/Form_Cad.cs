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
    public partial class Form_Cad : Form
    {
        public Form_Cad()
        {
            InitializeComponent();
        }
       Class_conex c = new Class_conex();
        DataTable cm = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        private void add()
        {
            try
            {
                c.adp1.SelectCommand = new OleDbCommand("select *from Funcionarios ", c.c1);
                c.adp1.Fill(cm);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = "insert into Funcionarios(Nome,Senha) values (@Nome,@senha)";
                OleDbCommand comandos = new OleDbCommand(codigo, c.c1);
                comandos.Parameters.Add("@Nome", OleDbType.VarChar).Value = txt_Nome_Prod.Text;
                comandos.Parameters.Add("@senha", OleDbType.VarChar).Value = txt_se.Text;
              
                c.c1.Open();
                comandos.ExecuteNonQuery();
                txt_se.Clear();
                txt_Nome_Prod.Clear();
               
              
                add();
                c.c1.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Form_Adimin f = new Form_Adimin();
            f.Show();
            this.Visible = false;
        }
    }
}
