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
    public partial class Login_F : Form
    {
        public Login_F()
        {
            InitializeComponent();
        }
        Class_conex c = new Class_conex();
        DataTable LogiDataTable = new DataTable();
        DataTable Logiad = new DataTable();

        private void log()
        {
            try
            {
                string select;
                c.adp1.SelectCommand = new OleDbCommand(select = ("SELECT * FROM Funcionarios"), c.c1);
                c.adp1.Fill(LogiDataTable);
              
                for (int cont = 0; cont <10; cont++)
                {
                    if (LogiDataTable.Rows[cont][1].ToString() == txt_nome.Text && LogiDataTable.Rows[cont][2].ToString() == txt_senha.Text)
                    {
                        Form_F f = new Form_F();
                        f.Show();
                        this.Visible = false;
                        return;
                    }
                }
                
                    MessageBox.Show("Dados não são compactiveis");
            }
                
            catch 
            {
                MessageBox.Show("Funcionario não existente!");
            }
        }

        private void Logad()
       {
        try
        {
            string select;
           c.adp1.SelectCommand = new OleDbCommand(select = ("SELECT * FROM Admin"), c.c1);
            c.adp1.Fill(Logiad);
            if (Logiad.Rows[0][1].ToString() == txt_nome.Text && Logiad.Rows[0][2].ToString() == txt_senha.Text)
            {
                Form_Adimin f = new Form_Adimin();
                f.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Dados não são compactiveis");
            }

        }
        catch 
        {
                
            MessageBox.Show("Administrador não existente!");
        }
    }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text=="" || txt_senha.Text=="")
            {
                MessageBox.Show("preenche os campos vazios")
                ;return ;
            }
            
            if(rdbtn_Adm.Checked==true)
            {
                Logad();
            }
            else if(rdbtn_F.Checked==true)
            {
                log();
            }
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_senha.Clear();
            rdbtn_Adm.Checked = false;
            rdbtn_F.Checked = false;
            txt_nome.Enabled = false;
            txt_senha.Enabled = false;
            lbff1.Text = "Nome ";
            lb_ss1.Text = "Senha ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbtn_F_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rdbtn_F.Checked==true)
            {
                txt_nome.Enabled = true;
                txt_senha.Enabled = true;

                lbff1.Text = "Nome do Funcionario";
                lb_ss1.Text = "Senha do Funcionario";
            }
        }

        private void rdbtn_Adm_CheckedChanged(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            txt_senha.Enabled = true;
            lbff1.Text = "Nome do Administrador";
            lb_ss1.Text = "Senha do Administrador";
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
    

}
