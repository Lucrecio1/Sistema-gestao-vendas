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
    public partial class form_Edit : Form
    {
        public form_Edit()
        {
            InitializeComponent();
        }
        Class_conex Con = new Class_conex();
        DataTable tabela = new DataTable();
        public static int ID;
        private void form_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                ID = Form_Adimin.ID;
                txt_Nome_edit.Text = Form_Adimin.n;
                txt_edit.Text = Form_Adimin.s;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void add()
        {
            try
            {
                Con.adp1.SelectCommand = new OleDbCommand("select *from Funcionarios ", Con.c1);
                Con.adp1.Fill(tabela);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string IDS = "update Funcionarios set Nome=@Nome,Senha=@sen where ID_F=" + ID;
                Con.cm1= new OleDbCommand(IDS, Con.c1);

                tabela.Clear();
                Con.cm1.Parameters.Add("@Nome", OleDbType.VarChar).Value=txt_Nome_edit.Text;
                Con.cm1.Parameters.Add("@sen", OleDbType.VarChar).Value = txt_edit.Text;
               

                Con.c1.Open();
                Con.cm1.ExecuteNonQuery();
                add();
                Con.c1.Close();

                Form_Adimin f = new Form_Adimin();
                f.Show();
                Visible = false;

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
