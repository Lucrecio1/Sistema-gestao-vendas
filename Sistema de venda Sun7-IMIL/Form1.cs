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
    public partial class Form_F : Form
    {
        public Form_F()
        {
            InitializeComponent();
        }
        Class_conex c2 = new Class_conex();
        DataTable tab2 = new DataTable();
        public static int ID2, Celecio2=0; public static string n2, p2, q2, categoria2;
        public static int qt2=0, Id_Produto2, tot2, l2;
        public static int quantidades2;
        public static decimal totais2 = 0;
        public int t2 = 0,t3=0;
        string nome2;
        public void Add()
        {
            try
            {
                tab2.Clear();
            string cod2 = ("select *From Produtos");
            c2.adp1.SelectCommand = new OleDbCommand(cod2, c2.c1);
            c2.adp1.Fill(tab2);
            Dgv_Prod.DataSource = tab2;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool validar = true;
        string operador;
        #region inserir numeros
        private void btn_um_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "1";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("1");
            }
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "2";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("2");
            }

        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "3";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("3");
            }
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "4";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("4");
            }
        }

        private void btn_Cinco_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "5";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("5");
            }
        }

        private void btn_Seis_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "6";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("6");
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "7";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("7");
            }
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "8";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("8");
            }
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            btn_Recusar.Enabled = false;
            if (txt_valord.Text == "")
            {
                MessageBox.Show(" receba um valor!");
                return;
            }
            decimal dinheiro = int.Parse(txt_valord.Text);


            if (dinheiro >= totais2)
            {
                btn_limpar.Enabled = true;
                txt_troco.Text = (dinheiro - totais2).ToString() + " KZ";
                lb_totp.Text = t2.ToString();
                Update();
                update_3();

                l2 = 0;
               
                
            }
            else
            {
                MessageBox.Show("Valor insoficiente");
            }
            Celecio2 = 0;
            btn_V.Enabled = false;
            txt_Qt.Enabled = false;

        }

        private void btn_Recusar_Click(object sender, EventArgs e)
        {
            
            for (int ct = 0; ct < Dgv_Venda.RowCount; ct++)
            {
                try
                {
                    if (Dgv_Venda.Rows[ct].Cells[0].Value.ToString() == nome2)
                {
                    int qt22 = int.Parse(Dgv_Venda.Rows[ct].Cells[3].Value.ToString());

                    totais2 = totais2 - qt22;
                        qt22 = 0;
                    txt_Tot.Text = totais2.ToString();
                    Dgv_Venda.Rows.RemoveAt(Dgv_Venda.CurrentRow.Index);

                    l2--;
                        break;
                }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
               
                
            }
            txt_Qt.Clear();
           
            l2 = 0;
        }

        private void Dgv_Venda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "9";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("9");
            }
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txt_valord.Text = "";
                txt_valord.Text = "0";
                validar = false;
            }
            else
            {
                txt_valord.Text = txt_valord.Text + ("0");
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valord.Clear();
            txt_troco.Clear();
            txt_Tot.Clear();
            Dgv_Venda.Rows.Clear();
            txt_Qt.Enabled = true;
              
        }
        #endregion fim
        private void Form_F_Load(object sender, EventArgs e)
        {
            Add();
            btn_V.Enabled = false;
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            try
            {
                tab2.Clear();
                string codi="select * from Produtos where Nome like '"+txt_pes.Text+"%'";
                c2.adp1.SelectCommand = new OleDbCommand(codi, c2.c1);
                c2.adp1.Fill(tab2);
                Dgv_Prod.DataSource = tab2;
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message);
            }
            txt_pes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_F f = new Login_F();
            f.Show();
            this.Visible = false;
        }

        int qt12;
        private void celecionar()
        {
            try
            {
                btn_limpar.Enabled = false;
                int preço2;
                int codigo = Dgv_Prod.CurrentRow.Index;
                Celecio2 = int.Parse(txt_Qt.Text);
                qt12 = int.Parse(Dgv_Prod.Rows[codigo].Cells[2].Value.ToString());
                qt2 = int.Parse(Dgv_Prod.Rows[codigo].Cells[2].Value.ToString()) - Celecio2;
                Id_Produto2 = int.Parse(Dgv_Prod.Rows[codigo].Cells[0].Value.ToString());
                nome2 = Dgv_Prod.Rows[codigo].Cells[1].Value.ToString();
                preço2 = int.Parse(Dgv_Prod.Rows[codigo].Cells[3].Value.ToString());


                for (int ct = 0; ct < Dgv_Venda.RowCount; ct++)
                {
                    try
                    {
                        if (Dgv_Venda.Rows[ct].Cells[0].Value.ToString() == nome2)
                        {
                            tot2 = Celecio2 * preço2;
                            Dgv_Venda.Rows[ct].Cells[1].Value = int.Parse(Dgv_Venda.Rows[ct].Cells[1].Value.ToString()) + Celecio2;
                            Dgv_Venda.Rows[ct].Cells[2].Value = dt_data.Text;
                            Dgv_Venda.Rows[ct].Cells[3].Value = int.Parse(Dgv_Venda.Rows[ct].Cells[3].Value.ToString()) + tot2;

                            txt_Qt.Clear();

                            btn_Recusar.Enabled = true;
                            btn_V.Enabled = true;

                            totais2 = totais2 + tot2;

                            t2 = t2 + Celecio2;
                            txt_Tot.Text = totais2.ToString() + " KZ";
                            Updates();
                            return;
                        }
                    }
                    catch {}
                }
                if (Celecio2 == 0)
                {
                    MessageBox.Show("0 não é uma quantidade valida");
                    txt_Qt.Clear();

                    return;
                }
                else if (qt12 >= Celecio2 )
                    {
                        tot2 = Celecio2 * preço2;
                        totais2 = totais2 + tot2;

                        t2 = t2 + Celecio2;
                        txt_Tot.Text = totais2.ToString() + " KZ";
                       txt_Qt.Clear();
                    btn_Recusar.Enabled = true;
                    btn_V.Enabled = true;
                    Updates();
                        Updates_2();
                        l2 = l2 + 1;
                        
                    }
                    else
                    {
                        MessageBox.Show("Não pode comprar este produto porque a quantidade existente é inferior a que desejas");
                    txt_Qt.Clear();
                    return;
                    }
                }
            

            catch (Exception erro)
            {
                if (txt_Qt.Text == "")
                    MessageBox.Show(erro.Message + " Digite a quantidade Pretendida! ");
            }
           
        }
        private void Updates()
        {
            try
            {
                string Codigo = "update Produtos set Quantidade=@qt where ID_P=" + Id_Produto2;
                c2.cm1 = new OleDbCommand(Codigo, c2.c1);
                c2.cm1.Parameters.Add("@qt", OleDbType.Numeric).Value = qt2;
                c2.c1.Open();
                c2.cm1.ExecuteNonQuery();
                Add();
                c2.c1.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        }
        int ii = 0;
        public void Updates_2()
        {
           Dgv_Venda.Rows.Add();
           Dgv_Venda.Rows[l2].Cells[0].Value = nome2;
           Dgv_Venda.Rows[l2].Cells[1].Value = Celecio2;
           Dgv_Venda.Rows[l2].Cells[2].Value = dt_data.Text;
           Dgv_Venda.Rows[l2].Cells[3].Value = tot2;
           
        }
        public void update_3()
            {

            try
            {
                for (int i = 0; i < ii; i++)
                {
                 string codigo = "insert into Relatorio(Nome,Quantidade,Preço,Data) values (@Nome,@qt,@preço,@data)";
                c2.cm1 = new OleDbCommand(codigo, c2.c1);
                c2.cm1.Parameters.Add("@Nome", OleDbType.VarChar).Value = nome2;
                c2.cm1.Parameters.Add("@qt", OleDbType.Numeric).Value = Celecio2;
                c2.cm1.Parameters.Add("@preço", OleDbType.Numeric).Value = tot2;
                c2.cm1.Parameters.Add("@data", OleDbType.VarChar).Value = dt_data.Text;
                c2.c1.Open();
                c2.cm1.ExecuteNonQuery();
                c2.c1.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btn_celect_Qt_Click(object sender, EventArgs e)
        {
            celecionar();
            
        }
        public void List()
        {
            l2--;
        }
    }
}
