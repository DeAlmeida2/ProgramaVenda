namespace ProgramaVenda
{
    partial class CadCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCliente));
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet = new ProgramaVenda.EstoqueDataSet();
            this.clienteTableAdapter = new ProgramaVenda.EstoqueDataSetTableAdapters.clienteTableAdapter();
            this.btCadProduto = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(67, 64);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(148, 20);
            this.tbid.TabIndex = 0;
            this.tbid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(67, 110);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(148, 20);
            this.tbnome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btcadastrar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.tbtel);
            this.panel1.Controls.Add(this.tbcpf);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.tbnome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 352);
            this.panel1.TabIndex = 2;
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btcadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(67, 300);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(111, 37);
            this.btcadastrar.TabIndex = 11;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "CADASTRAR CLIENTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(68, 255);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(147, 20);
            this.tbemail.TabIndex = 4;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(68, 204);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(147, 20);
            this.tbtel.TabIndex = 3;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(67, 156);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(148, 20);
            this.tbcpf.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 330);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.estoqueDataSet;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "EstoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btCadProduto
            // 
            this.btCadProduto.Location = new System.Drawing.Point(593, 392);
            this.btCadProduto.Name = "btCadProduto";
            this.btCadProduto.Size = new System.Drawing.Size(111, 37);
            this.btCadProduto.TabIndex = 4;
            this.btCadProduto.Text = "Cadastrar Produto";
            this.btCadProduto.UseVisualStyleBackColor = true;
            this.btCadProduto.Click += new System.EventHandler(this.btCadProduto_Click);
            // 
            // btVenda
            // 
            this.btVenda.Location = new System.Drawing.Point(722, 392);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(111, 37);
            this.btVenda.TabIndex = 5;
            this.btVenda.Text = "Fazer uma Venda";
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btVenda);
            this.Controls.Add(this.btCadProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EstoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private EstoqueDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btCadProduto;
        private System.Windows.Forms.Button btVenda;
    }
}

