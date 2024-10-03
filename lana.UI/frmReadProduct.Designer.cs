namespace lana.UI
{
    partial class frmReadProduct
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
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.produtoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckBox1 = new System.Windows.Forms.CheckBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(1113, 541);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(456, 541);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(1113, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelect,
            this.IdProduto,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.descricaoProdutoDataGridViewTextBoxColumn,
            this.estoqueProdutoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dgv1.DataSource = this.produtoDTOBindingSource;
            this.dgv1.Location = new System.Drawing.Point(456, 110);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(732, 411);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.FillWeight = 57.86242F;
            this.btnSelect.HeaderText = "Options";
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSelect.Text = "Select";
            this.btnSelect.ToolTipText = "Select";
            this.btnSelect.UseColumnTextForButtonValue = true;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.FillWeight = 72.9137F;
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.Name = "IdProduto";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.FillWeight = 72.9137F;
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // descricaoProdutoDataGridViewTextBoxColumn
            // 
            this.descricaoProdutoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoProduto";
            this.descricaoProdutoDataGridViewTextBoxColumn.FillWeight = 72.9137F;
            this.descricaoProdutoDataGridViewTextBoxColumn.HeaderText = "DescricaoProduto";
            this.descricaoProdutoDataGridViewTextBoxColumn.Name = "descricaoProdutoDataGridViewTextBoxColumn";
            // 
            // estoqueProdutoDataGridViewTextBoxColumn
            // 
            this.estoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueProduto";
            this.estoqueProdutoDataGridViewTextBoxColumn.FillWeight = 72.9137F;
            this.estoqueProdutoDataGridViewTextBoxColumn.HeaderText = "EstoqueProduto";
            this.estoqueProdutoDataGridViewTextBoxColumn.Name = "estoqueProdutoDataGridViewTextBoxColumn";
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "PrecoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.FillWeight = 72.9137F;
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "PrecoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.FillWeight = 143.684F;
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // produtoDTOBindingSource
            // 
            this.produtoDTOBindingSource.DataSource = typeof(lana.DTO.ProdutoDTO);
            // 
            // cBox1
            // 
            this.cBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Location = new System.Drawing.Point(70, 320);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(130, 21);
            this.cBox1.TabIndex = 5;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(224, 320);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(213, 23);
            this.btnImg.TabIndex = 4;
            this.btnImg.Text = "Selecionar imagem";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pBox1
            // 
            this.pBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox1.Location = new System.Drawing.Point(224, 110);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(213, 204);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 14;
            this.pBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(70, 188);
            this.txtDescricao.MaxLength = 3000;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(130, 70);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 136);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(70, 162);
            this.txtEstoque.MaxLength = 150;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(130, 20);
            this.txtEstoque.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(70, 266);
            this.txtPreco.MaxLength = 150;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(130, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço:";
            // 
            // ckBox1
            // 
            this.ckBox1.AutoSize = true;
            this.ckBox1.Location = new System.Drawing.Point(70, 297);
            this.ckBox1.Name = "ckBox1";
            this.ckBox1.Size = new System.Drawing.Size(103, 17);
            this.ckBox1.TabIndex = 23;
            this.ckBox1.Text = "Em Lançamento";
            this.ckBox1.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(9, 378);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(130, 23);
            this.btnRecord.TabIndex = 26;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 110);
            this.txtId.MaxLength = 150;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 20);
            this.txtId.TabIndex = 24;
            // 
            // frmReadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.ckBox1);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReadProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReadProduct";
            this.Load += new System.EventHandler(this.frmReadProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource produtoDTOBindingSource;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.CheckBox ckBox1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}