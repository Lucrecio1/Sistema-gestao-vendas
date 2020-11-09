namespace Sistema_de_venda_Sun7_IMIL
{
    partial class Login_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbff1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_canc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtn_F = new System.Windows.Forms.RadioButton();
            this.rdbtn_Adm = new System.Windows.Forms.RadioButton();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lb_ss1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbff1
            // 
            this.lbff1.AutoSize = true;
            this.lbff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbff1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbff1.Location = new System.Drawing.Point(54, 104);
            this.lbff1.Name = "lbff1";
            this.lbff1.Size = new System.Drawing.Size(49, 18);
            this.lbff1.TabIndex = 0;
            this.lbff1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Purple;
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_nome.Location = new System.Drawing.Point(48, 125);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(319, 25);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Purple;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_entrar.Location = new System.Drawing.Point(86, 227);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(107, 32);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_canc);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.lb_ss1);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.lbff1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 302);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 73);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 30);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(114, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "BEM-VINDO AO SISTEMA DE VENDA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(483, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orchid;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOGIN DE ADMINISTRADOR OU FUCIONÁRIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_canc
            // 
            this.btn_canc.BackColor = System.Drawing.Color.Purple;
            this.btn_canc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_canc.Location = new System.Drawing.Point(236, 225);
            this.btn_canc.Name = "btn_canc";
            this.btn_canc.Size = new System.Drawing.Size(105, 34);
            this.btn_canc.TabIndex = 5;
            this.btn_canc.Text = "CANCELAR";
            this.btn_canc.UseVisualStyleBackColor = false;
            this.btn_canc.Click += new System.EventHandler(this.btn_canc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_F);
            this.groupBox1.Controls.Add(this.rdbtn_Adm);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(394, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPEÇÕES";
            // 
            // rdbtn_F
            // 
            this.rdbtn_F.AutoSize = true;
            this.rdbtn_F.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdbtn_F.Location = new System.Drawing.Point(6, 27);
            this.rdbtn_F.Name = "rdbtn_F";
            this.rdbtn_F.Size = new System.Drawing.Size(112, 23);
            this.rdbtn_F.TabIndex = 0;
            this.rdbtn_F.TabStop = true;
            this.rdbtn_F.Text = "Funcionário";
            this.rdbtn_F.UseVisualStyleBackColor = true;
            this.rdbtn_F.CheckedChanged += new System.EventHandler(this.rdbtn_F_CheckedChanged);
            // 
            // rdbtn_Adm
            // 
            this.rdbtn_Adm.AutoSize = true;
            this.rdbtn_Adm.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Adm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdbtn_Adm.Location = new System.Drawing.Point(6, 70);
            this.rdbtn_Adm.Name = "rdbtn_Adm";
            this.rdbtn_Adm.Size = new System.Drawing.Size(130, 23);
            this.rdbtn_Adm.TabIndex = 6;
            this.rdbtn_Adm.TabStop = true;
            this.rdbtn_Adm.Text = "Administrador";
            this.rdbtn_Adm.UseVisualStyleBackColor = true;
            this.rdbtn_Adm.CheckedChanged += new System.EventHandler(this.rdbtn_Adm_CheckedChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.Purple;
            this.txt_senha.Enabled = false;
            this.txt_senha.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_senha.Location = new System.Drawing.Point(48, 182);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(319, 24);
            this.txt_senha.TabIndex = 4;
            // 
            // lb_ss1
            // 
            this.lb_ss1.AutoSize = true;
            this.lb_ss1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ss1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb_ss1.Location = new System.Drawing.Point(54, 161);
            this.lb_ss1.Name = "lb_ss1";
            this.lb_ss1.Size = new System.Drawing.Size(50, 18);
            this.lb_ss1.TabIndex = 3;
            this.lb_ss1.Text = "Senha";
            // 
            // Login_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MediumOrchid;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_F";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbff1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtn_Adm;
        private System.Windows.Forms.RadioButton rdbtn_F;
        private System.Windows.Forms.Button btn_canc;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lb_ss1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}