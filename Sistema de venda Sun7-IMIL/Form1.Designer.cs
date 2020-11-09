namespace Sistema_de_venda_Sun7_IMIL
{
    partial class Form_F
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_totp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tot = new System.Windows.Forms.TextBox();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.txt_pes = new System.Windows.Forms.TextBox();
            this.Dgv_Venda = new System.Windows.Forms.DataGridView();
            this.nomedgvv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_Prod = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_V = new System.Windows.Forms.Button();
            this.btn_celect_Qt = new System.Windows.Forms.Button();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.txt_valord = new System.Windows.Forms.TextBox();
            this.txt_Qt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Recusar = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_Seis = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_Cinco = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_um = new System.Windows.Forms.Button();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Prod)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(294, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sistema de venda Sun7-II12B";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Purple;
            this.btn_sair.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_sair.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(835, -2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(83, 35);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_pesq);
            this.panel1.Controls.Add(this.txt_pes);
            this.panel1.Controls.Add(this.Dgv_Venda);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Dgv_Prod);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 479);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lb_totp);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_Tot);
            this.panel4.Location = new System.Drawing.Point(3, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(886, 31);
            this.panel4.TabIndex = 3;
            // 
            // lb_totp
            // 
            this.lb_totp.AutoSize = true;
            this.lb_totp.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_totp.Location = new System.Drawing.Point(244, 7);
            this.lb_totp.Name = "lb_totp";
            this.lb_totp.Size = new System.Drawing.Size(17, 17);
            this.lb_totp.TabIndex = 17;
            this.lb_totp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total de Quantidade vendidos :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(623, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total";
            // 
            // txt_Tot
            // 
            this.txt_Tot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.txt_Tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Tot.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txt_Tot.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Tot.Location = new System.Drawing.Point(689, 2);
            this.txt_Tot.Multiline = true;
            this.txt_Tot.Name = "txt_Tot";
            this.txt_Tot.Size = new System.Drawing.Size(192, 26);
            this.txt_Tot.TabIndex = 13;
            // 
            // btn_pesq
            // 
            this.btn_pesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_pesq.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_pesq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pesq.Location = new System.Drawing.Point(771, 1);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(107, 26);
            this.btn_pesq.TabIndex = 5;
            this.btn_pesq.Text = "Pesquisar";
            this.btn_pesq.UseVisualStyleBackColor = false;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // txt_pes
            // 
            this.txt_pes.BackColor = System.Drawing.Color.Violet;
            this.txt_pes.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txt_pes.ForeColor = System.Drawing.Color.Transparent;
            this.txt_pes.Location = new System.Drawing.Point(569, 2);
            this.txt_pes.Multiline = true;
            this.txt_pes.Name = "txt_pes";
            this.txt_pes.Size = new System.Drawing.Size(196, 27);
            this.txt_pes.TabIndex = 4;
            // 
            // Dgv_Venda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Venda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Venda.BackgroundColor = System.Drawing.Color.Purple;
            this.Dgv_Venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomedgvv,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Dgv_Venda.Location = new System.Drawing.Point(3, 239);
            this.Dgv_Venda.Name = "Dgv_Venda";
            this.Dgv_Venda.Size = new System.Drawing.Size(545, 201);
            this.Dgv_Venda.TabIndex = 3;
            this.Dgv_Venda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Venda_CellContentClick);
            // 
            // nomedgvv
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.nomedgvv.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomedgvv.HeaderText = "Nome";
            this.nomedgvv.Name = "nomedgvv";
            this.nomedgvv.ReadOnly = true;
            this.nomedgvv.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Quantidade";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Data ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(3, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 23);
            this.panel3.TabIndex = 2;
            // 
            // Dgv_Prod
            // 
            this.Dgv_Prod.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.Dgv_Prod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Prod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Prod.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Prod.GridColor = System.Drawing.Color.MediumOrchid;
            this.Dgv_Prod.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Prod.Name = "Dgv_Prod";
            this.Dgv_Prod.ReadOnly = true;
            this.Dgv_Prod.Size = new System.Drawing.Size(545, 219);
            this.Dgv_Prod.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_limpar);
            this.panel2.Controls.Add(this.btn_V);
            this.panel2.Controls.Add(this.btn_celect_Qt);
            this.panel2.Controls.Add(this.txt_troco);
            this.panel2.Controls.Add(this.txt_valord);
            this.panel2.Controls.Add(this.txt_Qt);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(569, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 404);
            this.panel2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(38, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(248, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "voltar para a janela de login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor dado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Troco";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Purple;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_limpar.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_limpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_limpar.Location = new System.Drawing.Point(186, 138);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 29);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_V
            // 
            this.btn_V.BackColor = System.Drawing.Color.Purple;
            this.btn_V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_V.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_V.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_V.Location = new System.Drawing.Point(186, 86);
            this.btn_V.Name = "btn_V";
            this.btn_V.Size = new System.Drawing.Size(100, 29);
            this.btn_V.TabIndex = 11;
            this.btn_V.Text = "Vender";
            this.btn_V.UseVisualStyleBackColor = false;
            this.btn_V.Click += new System.EventHandler(this.btn_V_Click);
            // 
            // btn_celect_Qt
            // 
            this.btn_celect_Qt.BackColor = System.Drawing.Color.Purple;
            this.btn_celect_Qt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_celect_Qt.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_celect_Qt.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_celect_Qt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_celect_Qt.Location = new System.Drawing.Point(186, 33);
            this.btn_celect_Qt.Name = "btn_celect_Qt";
            this.btn_celect_Qt.Size = new System.Drawing.Size(100, 29);
            this.btn_celect_Qt.TabIndex = 10;
            this.btn_celect_Qt.Text = "Selecionar";
            this.btn_celect_Qt.UseVisualStyleBackColor = false;
            this.btn_celect_Qt.Click += new System.EventHandler(this.btn_celect_Qt_Click);
            // 
            // txt_troco
            // 
            this.txt_troco.BackColor = System.Drawing.Color.Violet;
            this.txt_troco.Enabled = false;
            this.txt_troco.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txt_troco.ForeColor = System.Drawing.Color.Transparent;
            this.txt_troco.Location = new System.Drawing.Point(10, 138);
            this.txt_troco.Multiline = true;
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(151, 29);
            this.txt_troco.TabIndex = 3;
            // 
            // txt_valord
            // 
            this.txt_valord.BackColor = System.Drawing.Color.Violet;
            this.txt_valord.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txt_valord.ForeColor = System.Drawing.Color.Transparent;
            this.txt_valord.Location = new System.Drawing.Point(10, 86);
            this.txt_valord.MaxLength = 13;
            this.txt_valord.Multiline = true;
            this.txt_valord.Name = "txt_valord";
            this.txt_valord.Size = new System.Drawing.Size(151, 29);
            this.txt_valord.TabIndex = 2;
            // 
            // txt_Qt
            // 
            this.txt_Qt.BackColor = System.Drawing.Color.Violet;
            this.txt_Qt.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.txt_Qt.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Qt.Location = new System.Drawing.Point(10, 33);
            this.txt_Qt.Multiline = true;
            this.txt_Qt.Name = "txt_Qt";
            this.txt_Qt.Size = new System.Drawing.Size(151, 29);
            this.txt_Qt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Recusar);
            this.groupBox1.Controls.Add(this.btn_zero);
            this.groupBox1.Controls.Add(this.btn_nove);
            this.groupBox1.Controls.Add(this.btn_Seis);
            this.groupBox1.Controls.Add(this.btn_tres);
            this.groupBox1.Controls.Add(this.btn_oito);
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Controls.Add(this.btn_Cinco);
            this.groupBox1.Controls.Add(this.btn_quatro);
            this.groupBox1.Controls.Add(this.btn_dois);
            this.groupBox1.Controls.Add(this.btn_um);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(10, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Números";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.button1.Location = new System.Drawing.Point(197, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Recusar
            // 
            this.btn_Recusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Recusar.Enabled = false;
            this.btn_Recusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recusar.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_Recusar.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Recusar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Recusar.Location = new System.Drawing.Point(101, 151);
            this.btn_Recusar.Name = "btn_Recusar";
            this.btn_Recusar.Size = new System.Drawing.Size(84, 38);
            this.btn_Recusar.TabIndex = 10;
            this.btn_Recusar.Text = "Recusar";
            this.btn_Recusar.UseVisualStyleBackColor = false;
            this.btn_Recusar.Click += new System.EventHandler(this.btn_Recusar_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_zero.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_zero.Location = new System.Drawing.Point(6, 151);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(85, 38);
            this.btn_zero.TabIndex = 9;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_nove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nove.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_nove.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_nove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_nove.Location = new System.Drawing.Point(197, 107);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(85, 38);
            this.btn_nove.TabIndex = 8;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = false;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_Seis
            // 
            this.btn_Seis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seis.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_Seis.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Seis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Seis.Location = new System.Drawing.Point(197, 63);
            this.btn_Seis.Name = "btn_Seis";
            this.btn_Seis.Size = new System.Drawing.Size(85, 38);
            this.btn_Seis.TabIndex = 7;
            this.btn_Seis.Text = "6";
            this.btn_Seis.UseVisualStyleBackColor = false;
            this.btn_Seis.Click += new System.EventHandler(this.btn_Seis_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tres.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_tres.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_tres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_tres.Location = new System.Drawing.Point(197, 19);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(85, 38);
            this.btn_tres.TabIndex = 6;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = false;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_oito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oito.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_oito.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_oito.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_oito.Location = new System.Drawing.Point(100, 107);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(85, 38);
            this.btn_oito.TabIndex = 5;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = false;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_set.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_set.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_set.Location = new System.Drawing.Point(6, 107);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(85, 38);
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "7";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_Cinco
            // 
            this.btn_Cinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cinco.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_Cinco.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Cinco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Cinco.Location = new System.Drawing.Point(100, 63);
            this.btn_Cinco.Name = "btn_Cinco";
            this.btn_Cinco.Size = new System.Drawing.Size(85, 38);
            this.btn_Cinco.TabIndex = 3;
            this.btn_Cinco.Text = "5";
            this.btn_Cinco.UseVisualStyleBackColor = false;
            this.btn_Cinco.Click += new System.EventHandler(this.btn_Cinco_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_quatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quatro.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_quatro.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_quatro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_quatro.Location = new System.Drawing.Point(6, 63);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(85, 38);
            this.btn_quatro.TabIndex = 2;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = false;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dois.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_dois.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_dois.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_dois.Location = new System.Drawing.Point(100, 19);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(85, 38);
            this.btn_dois.TabIndex = 1;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = false;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_um
            // 
            this.btn_um.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_um.Font = new System.Drawing.Font("Lucida Fax", 11.25F);
            this.btn_um.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_um.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_um.Location = new System.Drawing.Point(6, 19);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(85, 38);
            this.btn_um.TabIndex = 0;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = false;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // dt_data
            // 
            this.dt_data.Location = new System.Drawing.Point(12, 13);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(147, 20);
            this.dt_data.TabIndex = 15;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(918, 526);
            this.Controls.Add(this.dt_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.Form_F_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Prod)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.TextBox txt_pes;
        private System.Windows.Forms.DataGridView Dgv_Venda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_Prod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_V;
        private System.Windows.Forms.Button btn_celect_Qt;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.TextBox txt_valord;
        private System.Windows.Forms.TextBox txt_Qt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_Seis;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_Cinco;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.TextBox txt_Tot;
        private System.Windows.Forms.Button btn_Recusar;
        private System.Windows.Forms.Label lb_totp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedgvv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

