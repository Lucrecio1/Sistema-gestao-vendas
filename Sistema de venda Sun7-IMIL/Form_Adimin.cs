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
    public partial class Form_Adimin : Form
    {
        public Form_Adimin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Class_conex c3 = new Class_conex();
        DataTable tab3 = new DataTable();
        public static int ID3, Celecio2 = 0; public static string n3, p3, q3, categoria3;

        private void button5_Click(object sender, EventArgs e)
        {
            btn_Ok1Edd.Visible = false;
            btn_Cancel1Edd.Visible = false;
            cmb_ct.Visible = false;
            ls_ctAdd.Visible = true;
            ls_ctAdd.Items.Clear();
            cd();
            lb_Info.Visible = false;
            titu.Text = "Cadastro de Produtos";
            txt_Nome_Prod.Clear();
            txtQt.Clear();
            txt_Preco.Clear();
            cmb_ct.Text = "";
            LK_Canpro.Visible = true;
            Lk_CdPro.Visible = true;
            lb_Nomf.Visible = true;
            txt_nF.Visible = true;
            lb_f.Visible = true;
            txtQt.Enabled = true;
            txt_Nome_Prod.Enabled = true;
            txt_Preco.Enabled = true;
            ls_ctAdd.Enabled = true;
        }

        private void Form_Adimin_Load(object sender, EventArgs e)
        {   
            Add();
        }
        public void Add()
        {
            try
            {
                tab3.Clear();
                string cod2 = ("select *From Produtos");
                c3.adp1.SelectCommand = new OleDbCommand(cod2, c3.c1);
                c3.adp1.Fill(tab3);
                Dgv_P_Adim.DataSource = tab3;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
        DataTable tabf = new DataTable();
        public void cartabF()
        {
            try
            {
                tabf.Clear();
                string cod2 = ("select *From Funcionarios");
                c3.adp1.SelectCommand = new OleDbCommand(cod2, c3.c1);
                c3.adp1.Fill(tabf);
                Dgv_tabF.DataSource = tabf;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
    }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
           
        }

        private void forn()
        {
            string cod = "insert into Fornecidores(Nome,Quantidade,Produto,Data) values (@Nome,@quant,@Nome1,@dat)";
            c3.cm1 = new OleDbCommand(cod, c3.c1);
            c3.cm1.Parameters.Add("@Nome", OleDbType.VarChar).Value = txt_nF.Text; 
            c3.cm1.Parameters.Add("@quant", OleDbType.Numeric).Value = txtQt.Text;
            c3.cm1.Parameters.Add("@Nome1", OleDbType.VarChar).Value = txt_Nome_Prod.Text;
            c3.cm1.Parameters.Add("@dat", OleDbType.VarChar).Value = dta_data.Text;
            c3.c1.Open();
            c3.cm1.ExecuteNonQuery();
            txtQt.Clear();
            txt_Nome_Prod.Clear();
            txt_Preco.Clear();
            txt_nF.Clear();
            ls_ctAdd.Items.Clear();
            c3.c1.Close();
            cd();
        }
        DataTable ct = new DataTable();
        private void cd()
        {
            try
            {
               
                ct.Clear();
                c3.adp1.SelectCommand = new OleDbCommand("select Categoria.Nom from Categoria", c3.c1);
                c3.adp1.Fill(ct);
                for (int i = 0; i < ct.Rows.Count; i++)
                {
                    ls_ctAdd.Items.Add(ct.Rows[i][0]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void cd2()
        {
            try
            {

                ct.Clear();
                c3.adp1.SelectCommand = new OleDbCommand("select Categoria.Nom from Categoria", c3.c1);
                c3.adp1.Fill(ct);
                for (int i = 0; i < ct.Rows.Count; i++)
                {
                    cmb_ct.Items.Add(ct.Rows[i][0]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cd1()
        {
            lb_Info.Visible = false;
            titu.Text = "      Editar Produto";
            cmb_ct.Items.Clear();

           
            txtQt.Enabled = true;
            txt_Nome_Prod.Enabled = true;
            txt_Preco.Enabled = true;
            cmb_ct.Enabled = true;
            ls_ctAdd.Visible = false;
            cmb_ct.Visible = true;

            try
            {
                txt_Nome_Prod.Text = n3;
                txt_Preco.Text = p3;
                txtQt.Text = q3;
                cmb_ct.Text=categoria3;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            titu.Text = "";
            lb_Info.Visible = true;
            txt_Nome_Prod.Clear();
            txtQt.Clear();
            txt_Preco.Clear();
            cmb_ct.Text = "";
            
            txtQt.Enabled = false;
            txt_Nome_Prod.Enabled = false;
            txt_Preco.Enabled = false;
            ls_ctAdd.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int IDR = int.Parse(Dgv_P_Adim.Rows[Dgv_P_Adim.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from Produtos where ID_P=" + IDR;
                c3.cm1 = new OleDbCommand(Codigo, c3.c1);
                c3.c1.Open();
                c3.cm1.ExecuteNonQuery();
                c3.c1.Close();
                Add();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_Cancel1Edd.Visible = false;
            LK_Canpro.Visible = false;
            Lk_CdPro.Visible= false;
            txt_nF.Visible = false;
            lb_Nomf.Visible = false;

            carr();
            cd1();
            cd2();
        }

        private void btn_Ok1_Click(object sender, EventArgs e)
        {
            if ((txt_Nome_Prod.Enabled == false && txtQt.Enabled == false) || txt_Preco.Enabled == false)
            {
                MessageBox.Show("Não há Produtos para editar.");
                return;
            }
            else if (txt_Nome_Prod.Text == "" || txt_Preco.Text == "" || txtQt.Text == "" || cmb_ct.Text == "")
            {
                MessageBox.Show("Um ou mais campos não foram Preenchidos.");
                return;
            }
            try
            {
                string IDS = "update Produtos set Nome=@Nome,Quantidade=@Quantidade,Preço=@Preço,Categoria=@Categoria where ID_P=" + ID3;
                OleDbCommand cmd = new OleDbCommand(IDS, c3.c1);

                tab3.Clear();
                cmd.Parameters.Add("@Nome", OleDbType.VarChar).Value = txt_Nome_Prod.Text;
                cmd.Parameters.Add("@Quantidade", OleDbType.Numeric).Value = txtQt.Text;
                cmd.Parameters.Add("@Preço", OleDbType.Numeric).Value = txt_Preco.Text;
                cmd.Parameters.Add("@Categoria", OleDbType.VarChar).Value = cmb_ct.Text;

                c3.c1.Open();
                cmd.ExecuteNonQuery();
                Add();
                c3.c1.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Cancel1_Click(object sender, EventArgs e)
        {
            lb_Info.Visible = true;
            txt_Nome_Prod.Clear();
            txtQt.Clear();
            txt_Preco.Clear();
            cmb_ct.Items.Clear();
            
            txtQt.Enabled = false;
            txt_Nome_Prod.Enabled = false;
            txt_Preco.Enabled = false;
            cmb_ct.Enabled = false;
        }

        private void btn_Ver_F_Click(object sender, EventArgs e)
        {
            cartabF();
            lkl_R.Enabled = true;
            lkl_E.Enabled = true;
            lkl_C.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        public static string n, s;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int IDR = int.Parse(Dgv_tabF.Rows[Dgv_tabF.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from Funcionarios where ID_F=" + IDR;
                c3.cm1 = new OleDbCommand(Codigo, c3.c1);
                c3.c1.Open();
                c3.cm1.ExecuteNonQuery();
                c3.c1.Close();
                cartabF();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int codigo = Dgv_tabF.CurrentRow.Index;
            ID = int.Parse(Dgv_tabF.Rows[codigo].Cells[0].Value.ToString());
            n = Dgv_tabF.Rows[codigo].Cells[1].Value.ToString();
            s = Dgv_tabF.Rows[codigo].Cells[2].Value.ToString();


            form_Edit foms = new form_Edit();
            foms.Show();
            this.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Cad f = new Form_Cad();
            f.Show();
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((txt_Nome_Prod.Enabled == false && txtQt.Enabled == false) || txt_Preco.Enabled == false)
            {
                MessageBox.Show("Não há nada para cadastrar");
                return;
            }
            else if (txt_Nome_Prod.Text == "" || txt_Preco.Text == "" || txtQt.Text == "" || ls_ctAdd.Text == "")
            {
                MessageBox.Show("Um ou mais campos não foram Preenchidos, ou selecione um dos elementos na lista de categoria");
                return;
            }
            try
            {
                string codigo = "insert into Produtos(Nome,Quantidade,Preço,Categoria) values (@Nome,@qt,@preço,@Categoria)";
                c3.cm1 = new OleDbCommand(codigo, c3.c1);
                c3.cm1.Parameters.Add("@Nome", OleDbType.VarChar).Value = txt_Nome_Prod.Text;
                c3.cm1.Parameters.Add("@qt", OleDbType.Numeric).Value = txtQt.Text;
                c3.cm1.Parameters.Add("@preço", OleDbType.Numeric).Value = txt_Preco.Text;
                c3.cm1.Parameters.Add("@Categoria", OleDbType.VarChar).Value = ls_ctAdd.Text;
                c3.c1.Open();
                c3.cm1.ExecuteNonQuery();
               

                Add();
                c3.c1.Close();
                forn();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_forn_Click(object sender, EventArgs e)
        {
            fornrcidor f = new fornrcidor();
            f.Show();
            this.Visible = true;
            
           

        }

        private void Dgv_P_Adim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_F f = new Form_F();
            f.Show();
            this.Visible = false;
           
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_Info.Visible = true;
            txt_Nome_Prod.Clear();
            txtQt.Clear();
            txt_Preco.Clear();
            cmb_ct.Items.Clear();
            titu.Text = "";
            txtQt.Enabled = false;
            txt_Nome_Prod.Enabled = false;
            txt_Preco.Enabled = false;
            ls_ctAdd.Items.Clear();
           ls_ctAdd.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_F f = new Login_F();
            f.Show();
            this.Visible = false;
        }

        public static int qt3 = 0, Id_Produto3, tot3, l3;

        DataTable tabela = new DataTable();
        public static int ID;

        public void carr()
        {
            btn_Ok1Edd.Visible = true;
            btn_Cancel1Edd.Visible = true;

            int codigo = Dgv_P_Adim.CurrentRow.Index;
            ID3 = int.Parse(Dgv_P_Adim.Rows[codigo].Cells[0].Value.ToString());
            n3 = Dgv_P_Adim.Rows[codigo].Cells[1].Value.ToString();
            q3 = Dgv_P_Adim.Rows[codigo].Cells[2].Value.ToString();
            p3 = Dgv_P_Adim.Rows[codigo].Cells[3].Value.ToString();
            categoria3 = Dgv_P_Adim.Rows[codigo].Cells[4].Value.ToString();
        }
        public void carre()
        {
            int codigo = Dgv_P_Adim.CurrentRow.Index;
            ID3 = int.Parse(Dgv_P_Adim.Rows[codigo].Cells[0].Value.ToString());
            n3 = Dgv_P_Adim.Rows[codigo].Cells[1].Value.ToString();
            q3 = Dgv_P_Adim.Rows[codigo].Cells[2].Value.ToString();
            p3 = Dgv_P_Adim.Rows[codigo].Cells[3].Value.ToString();
            categoria3 = Dgv_P_Adim.Rows[codigo].Cells[4].Value.ToString();
        }
    }
}
