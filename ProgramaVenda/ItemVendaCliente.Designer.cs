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
            this.dg_Carrinho = new System.Windows.Forms.DataGridView();
            this.idpkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet2 = new ProgramaVenda.EstoqueDataSet2();
            this.itemVendaTableAdapter = new ProgramaVenda.EstoqueDataSet2TableAdapters.itemVendaTableAdapter();
            this.btRealizarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Produtos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNomeVenda
            // 
            this.cbNomeVenda.FormattingEnabled = true;
            this.cbNomeVenda.Location = new System.Drawing.Point(155, 36);
            this.cbNomeVenda.Name = "cbNomeVenda";
            this.cbNomeVenda.Size = new System.Drawing.Size(231, 21);
            this.cbNomeVenda.TabIndex = 0;
            this.cbNomeVenda.SelectedIndexChanged += new System.EventHandler(this.cbNomeVenda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
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
            this.dg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpkDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dg_Produtos.DataSource = this.produtoBindingSource;
            this.dg_Produtos.Location = new System.Drawing.Point(155, 76);
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
            this.btAddItemVenda.Location = new System.Drawing.Point(38, 80);
            this.btAddItemVenda.Name = "btAddItemVenda";
            this.btAddItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btAddItemVenda.TabIndex = 3;
            this.btAddItemVenda.Text = "Adicionar Item";
            this.btAddItemVenda.UseVisualStyleBackColor = true;
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
            // dg_Carrinho
            // 
            this.dg_Carrinho.AutoGenerateColumns = false;
            this.dg_Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpkDataGridViewTextBoxColumn1,
            this.idvendasDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dg_Carrinho.DataSource = this.itemVendaBindingSource;
            this.dg_Carrinho.Location = new System.Drawing.Point(155, 311);
            this.dg_Carrinho.Name = "dg_Carrinho";
            this.dg_Carrinho.Size = new System.Drawing.Size(591, 163);
            this.dg_Carrinho.TabIndex = 6;
            // 
            // idpkDataGridViewTextBoxColumn1
            // 
            this.idpkDataGridViewTextBoxColumn1.DataPropertyName = "Id_pk";
            this.idpkDataGridViewTextBoxColumn1.HeaderText = "Id_pk";
            this.idpkDataGridViewTextBoxColumn1.Name = "idpkDataGridViewTextBoxColumn1";
            // 
            // idvendasDataGridViewTextBoxColumn
            // 
            this.idvendasDataGridViewTextBoxColumn.DataPropertyName = "Id_vendas";
            this.idvendasDataGridViewTextBoxColumn.HeaderText = "Id_vendas";
            this.idvendasDataGridViewTextBoxColumn.Name = "idvendasDataGridViewTextBoxColumn";
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
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
            this.btRealizarVenda.Location = new System.Drawing.Point(-6, 155);
            this.btRealizarVenda.Name = "btRealizarVenda";
            this.btRealizarVenda.Size = new System.Drawing.Size(112, 44);
            this.btRealizarVenda.TabIndex = 7;
            this.btRealizarVenda.Text = "Concluir Venda";
            this.btRealizarVenda.UseVisualStyleBackColor = true;
            this.btRealizarVenda.Click += new System.EventHandler(this.btRealizarVenda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Carrinho";
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Location = new System.Drawing.Point(100, 76);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(35, 13);
            this.Produtos.TabIndex = 9;
            this.Produtos.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbQuantidade);
            this.panel1.Controls.Add(this.tbQuantidadeVendas);
            this.panel1.Controls.Add(this.btAddItemVenda);
            this.panel1.Controls.Add(this.btRealizarVenda);
            this.panel1.Location = new System.Drawing.Point(621, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 186);
            this.panel1.TabIndex = 10;
            // 
            // LbIdCliente
            // 
            this.LbIdCliente.AutoSize = true;
            this.LbIdCliente.Enabled = false;
            this.LbIdCliente.Location = new System.Drawing.Point(436, 36);
            this.LbIdCliente.Name = "LbIdCliente";
            this.LbIdCliente.Size = new System.Drawing.Size(35, 13);
            this.LbIdCliente.TabIndex = 11;
            this.LbIdCliente.Text = "label3";
            // 
            // ItemVendaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.LbIdCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_Carrinho);
            this.Controls.Add(this.dg_Produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNomeVenda);
            this.Name = "ItemVendaCliente";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dg_Carrinho;
        private EstoqueDataSet2 estoqueDataSet2;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private EstoqueDataSet2TableAdapters.itemVendaTableAdapter itemVendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btRealizarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbIdCliente;
    }
}