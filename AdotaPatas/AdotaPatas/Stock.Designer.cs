namespace AdotaPatas
{
    partial class Stock
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label especie_AnimalLabel;
            System.Windows.Forms.Label tamanhoLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label data_ValidadeLabel;
            System.Windows.Forms.Label obsLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.consumiveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumiveisTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.ConsumiveisTableAdapter();
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.consumiveisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPesqui = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.data_ValidadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtObser = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            especie_AnimalLabel = new System.Windows.Forms.Label();
            tamanhoLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            data_ValidadeLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumiveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumiveisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdotaPatas.Properties.Resources.imgLogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(769, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "STOCK";
            // 
            // abrigoDataSet
            // 
            this.abrigoDataSet.DataSetName = "AbrigoDataSet";
            this.abrigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumiveisBindingSource
            // 
            this.consumiveisBindingSource.DataMember = "Consumiveis";
            this.consumiveisBindingSource.DataSource = this.abrigoDataSet;
            // 
            // consumiveisTableAdapter
            // 
            this.consumiveisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdocaoTableAdapter = null;
            this.tableAdapterManager.AdotanteTableAdapter = null;
            this.tableAdapterManager.AnimaisTableAdapter = null;
            this.tableAdapterManager.AtividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumiveisTableAdapter = this.consumiveisTableAdapter;
            this.tableAdapterManager.FuncoesTableAdapter = null;
            this.tableAdapterManager.PessoasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            this.tableAdapterManager.VoluntariosTableAdapter = null;
            // 
            // consumiveisDataGridView
            // 
            this.consumiveisDataGridView.AutoGenerateColumns = false;
            this.consumiveisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumiveisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.consumiveisDataGridView.DataSource = this.consumiveisBindingSource;
            this.consumiveisDataGridView.Location = new System.Drawing.Point(529, 455);
            this.consumiveisDataGridView.Name = "consumiveisDataGridView";
            this.consumiveisDataGridView.RowHeadersVisible = false;
            this.consumiveisDataGridView.RowHeadersWidth = 62;
            this.consumiveisDataGridView.RowTemplate.Height = 28;
            this.consumiveisDataGridView.Size = new System.Drawing.Size(1206, 399);
            this.consumiveisDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Especie_Animal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Especie_Animal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tamanho";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tamanho";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_Validade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data_Validade";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Obs";
            this.dataGridViewTextBoxColumn8.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 701);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 153);
            this.button5.TabIndex = 39;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 701);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 153);
            this.button4.TabIndex = 38;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 141);
            this.button3.TabIndex = 37;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 141);
            this.button2.TabIndex = 36;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPesqui
            // 
            this.txtPesqui.Location = new System.Drawing.Point(158, 463);
            this.txtPesqui.Name = "txtPesqui";
            this.txtPesqui.Size = new System.Drawing.Size(324, 37);
            this.txtPesqui.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 873);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(475, 76);
            this.button6.TabIndex = 40;
            this.button6.Text = "Voltar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(536, 85);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(39, 30);
            iDLabel.TabIndex = 40;
            iDLabel.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "ID", true));
            this.txtId.Location = new System.Drawing.Point(704, 82);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(361, 37);
            this.txtId.TabIndex = 41;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(536, 128);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(78, 30);
            nomeLabel.TabIndex = 42;
            nomeLabel.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(704, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 37);
            this.txtNome.TabIndex = 43;
            // 
            // especie_AnimalLabel
            // 
            especie_AnimalLabel.AutoSize = true;
            especie_AnimalLabel.Location = new System.Drawing.Point(536, 171);
            especie_AnimalLabel.Name = "especie_AnimalLabel";
            especie_AnimalLabel.Size = new System.Drawing.Size(162, 30);
            especie_AnimalLabel.TabIndex = 44;
            especie_AnimalLabel.Text = "Especie Animal:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Especie_Animal", true));
            this.txtEspecie.Location = new System.Drawing.Point(704, 168);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(361, 37);
            this.txtEspecie.TabIndex = 45;
            // 
            // tamanhoLabel
            // 
            tamanhoLabel.AutoSize = true;
            tamanhoLabel.Location = new System.Drawing.Point(536, 214);
            tamanhoLabel.Name = "tamanhoLabel";
            tamanhoLabel.Size = new System.Drawing.Size(106, 30);
            tamanhoLabel.TabIndex = 46;
            tamanhoLabel.Text = "Tamanho:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Tamanho", true));
            this.txtTamanho.Location = new System.Drawing.Point(704, 211);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(361, 37);
            this.txtTamanho.TabIndex = 47;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(536, 257);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(112, 30);
            categoriaLabel.TabIndex = 48;
            categoriaLabel.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Categoria", true));
            this.txtCategoria.Location = new System.Drawing.Point(704, 254);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(361, 37);
            this.txtCategoria.TabIndex = 49;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(536, 300);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(131, 30);
            quantidadeLabel.TabIndex = 50;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Quantidade", true));
            this.txtQuantidade.Location = new System.Drawing.Point(704, 297);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(361, 37);
            this.txtQuantidade.TabIndex = 51;
            // 
            // data_ValidadeLabel
            // 
            data_ValidadeLabel.AutoSize = true;
            data_ValidadeLabel.Location = new System.Drawing.Point(536, 345);
            data_ValidadeLabel.Name = "data_ValidadeLabel";
            data_ValidadeLabel.Size = new System.Drawing.Size(150, 30);
            data_ValidadeLabel.TabIndex = 52;
            data_ValidadeLabel.Text = "Data Validade:";
            // 
            // data_ValidadeDateTimePicker
            // 
            this.data_ValidadeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consumiveisBindingSource, "Data_Validade", true));
            this.data_ValidadeDateTimePicker.Location = new System.Drawing.Point(704, 341);
            this.data_ValidadeDateTimePicker.Name = "data_ValidadeDateTimePicker";
            this.data_ValidadeDateTimePicker.Size = new System.Drawing.Size(361, 37);
            this.data_ValidadeDateTimePicker.TabIndex = 53;
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(536, 387);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(143, 30);
            obsLabel.TabIndex = 54;
            obsLabel.Text = "Observações:";
            // 
            // txtObser
            // 
            this.txtObser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumiveisBindingSource, "Obs", true));
            this.txtObser.Location = new System.Drawing.Point(704, 384);
            this.txtObser.Name = "txtObser";
            this.txtObser.Size = new System.Drawing.Size(361, 37);
            this.txtObser.TabIndex = 55;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1769, 969);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(especie_AnimalLabel);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(tamanhoLabel);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(data_ValidadeLabel);
            this.Controls.Add(this.data_ValidadeDateTimePicker);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObser);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPesqui);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consumiveisDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumiveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumiveisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource consumiveisBindingSource;
        private AbrigoDataSetTableAdapters.ConsumiveisTableAdapter consumiveisTableAdapter;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView consumiveisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPesqui;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker data_ValidadeDateTimePicker;
        private System.Windows.Forms.TextBox txtObser;
    }
}