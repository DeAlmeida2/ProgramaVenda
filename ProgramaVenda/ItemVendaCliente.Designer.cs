namespace ProgramaVenda
{
    partial class ItemVendaCliente
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
            this.components = new System.ComponentModel.Container();
            this.cbNomeVenda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Produtos = new System.Windows.Forms.DataGridView();
            this.idpkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet1 = new ProgramaVenda.EstoqueDataSet1();
            this.produtoTableAdapter = new ProgramaVenda.EstoqueDataSet1TableAdapters.produtoTableAdapter();
            this.btAddItemVenda = new System.Windows.Forms.Button();
            this.tbQuantidadeVendas = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet2 = new ProgramaVenda.EstoqueDataSet2();
            this.itemVendaTableAdapter = new ProgramaVenda.EstoqueDataSet2TableAdapters.itemVendaTableAdapter();
            this.btRealizarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Produtos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbIdCliente = new System.Windows.Forms.Label();
            this.dg_Carrinho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Carrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomeVenda
            // 
            this.cbNomeVenda.FormattingEnabled = true;
            this.cbNomeVenda.Location = new System.Drawing.Point(96, 21);
            this.cbNomeVenda.Name = "cbNomeVenda";
            this.cbNomeVenda.Size = new System.Drawing.Size(231, 21);
            this.cbNomeVenda.TabIndex = 0;
            this.cbNomeVenda.SelectedIndexChanged += new System.EventHandler(this.cbNomeVenda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dg_Produtos
            // 
            this.dg_Produtos.AllowUserToAddRows = false;
            this.dg_Produtos.AutoGenerateColumns = false;
            this.dg_Produtos.BackgroundColor = System.Drawing.Color.Teal;
            this.dg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpkDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dg_Produtos.DataSource = this.produtoBindingSource;
            this.dg_Produtos.Location = new System.Drawing.Point(96, 61);
            this.dg_Produtos.Name = "dg_Produtos";
            this.dg_Produtos.Size = new System.Drawing.Size(443, 187);
            this.dg_Produtos.TabIndex = 2;
            // 
            // idpkDataGridViewTextBoxColumn
            // 
            this.idpkDataGridViewTextBoxColumn.DataPropertyName = "Id_pk";
            this.idpkDataGridViewTextBoxColumn.HeaderText = "Id_pk";
            this.idpkDataGridViewTextBoxColumn.Name = "idpkDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.estoqueDataSet1;
            // 
            // estoqueDataSet1
            // 
            this.estoqueDataSet1.DataSetName = "EstoqueDataSet1";
            this.estoqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btAddItemVenda
            // 
            this.btAddItemVenda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAddItemVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddItemVenda.ForeColor = System.Drawing.Color.White;
            this.btAddItemVenda.Location = new System.Drawing.Point(38, 80);
            this.btAddItemVenda.Name = "btAddItemVenda";
            this.btAddItemVenda.Size = new System.Drawing.Size(75, 29);
            this.btAddItemVenda.TabIndex = 3;
            this.btAddItemVenda.Text = "Adicionar Item";
            this.btAddItemVenda.UseVisualStyleBackColor = false;
            this.btAddItemVenda.Click += new System.EventHandler(this.btAddItemVenda_Click);
            // 
            // tbQuantidadeVendas
            // 
            this.tbQuantidadeVendas.Location = new System.Drawing.Point(25, 43);
            this.tbQuantidadeVendas.Name = "tbQuantidadeVendas";
            this.tbQuantidadeVendas.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidadeVendas.TabIndex = 4;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(44, 22);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 5;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataMember = "itemVenda";
            this.itemVendaBindingSource.DataSource = this.estoqueDataSet2;
            // 
            // estoqueDataSet2
            // 
            this.estoqueDataSet2.DataSetName = "EstoqueDataSet2";
            this.estoqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemVendaTableAdapter
            // 
            this.itemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // btRealizarVenda
            // 
            this.btRealizarVenda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btRealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRealizarVenda.ForeColor = System.Drawing.Color.White;
            this.btRealizarVenda.Location = new System.Drawing.Point(323, 446);
            this.btRealizarVenda.Name = "btRealizarVenda";
            this.btRealizarVenda.Size = new System.Drawing.Size(112, 44);
            this.btRealizarVenda.TabIndex = 7;
            this.btRealizarVenda.Text = "Concluir Venda";
            this.btRealizarVenda.UseVisualStyleBackColor = false;
            this.btRealizarVenda.Click += new System.EventHandler(this.btRealizarVenda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(30, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Carrinho";
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Produtos.Location = new System.Drawing.Point(41, 61);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(35, 13);
            this.Produtos.TabIndex = 9;
            this.Produtos.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbQuantidade);
            this.panel1.Controls.Add(this.tbQuantidadeVendas);
            this.panel1.Controls.Add(this.btAddItemVenda);
            this.panel1.Location = new System.Drawing.Point(562, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 187);
            this.panel1.TabIndex = 10;
            // 
            // LbIdCliente
            // 
            this.LbIdCliente.AutoSize = true;
            this.LbIdCliente.Enabled = false;
            this.LbIdCliente.Location = new System.Drawing.Point(377, 21);
            this.LbIdCliente.Name = "LbIdCliente";
            this.LbIdCliente.Size = new System.Drawing.Size(35, 13);
            this.LbIdCliente.TabIndex = 11;
            this.LbIdCliente.Text = "label3";
            // 
            // dg_Carrinho
            // 
            this.dg_Carrinho.BackgroundColor = System.Drawing.Color.Teal;
            this.dg_Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Carrinho.Location = new System.Drawing.Point(96, 268);
            this.dg_Carrinho.Name = "dg_Carrinho";
            this.dg_Carrinho.Size = new System.Drawing.Size(547, 157);
            this.dg_Carrinho.TabIndex = 12;
            // 
            // ItemVendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(747, 545);
            this.Controls.Add(this.dg_Carrinho);
            this.Controls.Add(this.LbIdCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btRealizarVenda);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_Produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNomeVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemVendaCliente";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Carrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomeVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Produtos;
        private EstoqueDataSet1 estoqueDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private EstoqueDataSet1TableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAddItemVenda;
        private System.Windows.Forms.TextBox tbQuantidadeVendas;
        private System.Windows.Forms.Label lbQuantidade;
        private EstoqueDataSet2 estoqueDataSet2;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private EstoqueDataSet2TableAdapters.itemVendaTableAdapter itemVendaTableAdapter;
        private System.Windows.Forms.Button btRealizarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbIdCliente;
        private System.Windows.Forms.DataGridView dg_Carrinho;
    }
}