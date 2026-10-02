namespace AdotaPatas
{
    partial class Atividades
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
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label duracao_minLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label iD_FuncaoLabel;
            System.Windows.Forms.Label iD_PessoaLabel;
            System.Windows.Forms.Label iD_AnimalLabel;
            System.Windows.Forms.Label iD_AtividadeLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.atividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadesTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AtividadesTableAdapter();
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.atividadesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtAtivi = new System.Windows.Forms.TextBox();
            obsLabel = new System.Windows.Forms.Label();
            duracao_minLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            iD_FuncaoLabel = new System.Windows.Forms.Label();
            iD_PessoaLabel = new System.Windows.Forms.Label();
            iD_AnimalLabel = new System.Windows.Forms.Label();
            iD_AtividadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(598, 310);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(143, 30);
            obsLabel.TabIndex = 33;
            obsLabel.Text = "Observações:";
            // 
            // duracao_minLabel
            // 
            duracao_minLabel.AutoSize = true;
            duracao_minLabel.Location = new System.Drawing.Point(598, 267);
            duracao_minLabel.Name = "duracao_minLabel";
            duracao_minLabel.Size = new System.Drawing.Size(98, 30);
            duracao_minLabel.TabIndex = 33;
            duracao_minLabel.Text = "Duração:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(598, 227);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(62, 30);
            dataLabel.TabIndex = 34;
            dataLabel.Text = "Data:";
            // 
            // iD_FuncaoLabel
            // 
            iD_FuncaoLabel.AutoSize = true;
            iD_FuncaoLabel.Location = new System.Drawing.Point(599, 183);
            iD_FuncaoLabel.Name = "iD_FuncaoLabel";
            iD_FuncaoLabel.Size = new System.Drawing.Size(87, 30);
            iD_FuncaoLabel.TabIndex = 35;
            iD_FuncaoLabel.Text = "Função:";
            // 
            // iD_PessoaLabel
            // 
            iD_PessoaLabel.AutoSize = true;
            iD_PessoaLabel.Location = new System.Drawing.Point(598, 139);
            iD_PessoaLabel.Name = "iD_PessoaLabel";
            iD_PessoaLabel.Size = new System.Drawing.Size(83, 30);
            iD_PessoaLabel.TabIndex = 36;
            iD_PessoaLabel.Text = "Pessoa:";
            // 
            // iD_AnimalLabel
            // 
            iD_AnimalLabel.AutoSize = true;
            iD_AnimalLabel.Location = new System.Drawing.Point(598, 96);
            iD_AnimalLabel.Name = "iD_AnimalLabel";
            iD_AnimalLabel.Size = new System.Drawing.Size(84, 30);
            iD_AnimalLabel.TabIndex = 37;
            iD_AnimalLabel.Text = "Animal:";
            // 
            // iD_AtividadeLabel
            // 
            iD_AtividadeLabel.AutoSize = true;
            iD_AtividadeLabel.Location = new System.Drawing.Point(599, 53);
            iD_AtividadeLabel.Name = "iD_AtividadeLabel";
            iD_AtividadeLabel.Size = new System.Drawing.Size(109, 30);
            iD_AtividadeLabel.TabIndex = 38;
            iD_AtividadeLabel.Text = "Atividade:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdotaPatas.Properties.Resources.imgLogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(820, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATIVIDADES";
            // 
            // abrigoDataSet
            // 
            this.abrigoDataSet.DataSetName = "AbrigoDataSet";
            this.abrigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadesBindingSource
            // 
            this.atividadesBindingSource.DataMember = "Atividades";
            this.atividadesBindingSource.DataSource = this.abrigoDataSet;
            // 
            // atividadesTableAdapter
            // 
            this.atividadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdocaoTableAdapter = null;
            this.tableAdapterManager.AdotanteTableAdapter = null;
            this.tableAdapterManager.AnimaisTableAdapter = null;
            this.tableAdapterManager.AtividadesTableAdapter = this.atividadesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumiveisTableAdapter = null;
            this.tableAdapterManager.FuncoesTableAdapter = null;
            this.tableAdapterManager.PessoasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            this.tableAdapterManager.VoluntariosTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 28;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(158, 374);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(324, 37);
            this.txtPesq.TabIndex = 29;
            // 
            // atividadesDataGridView
            // 
            this.atividadesDataGridView.AutoGenerateColumns = false;
            this.atividadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atividadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Obs});
            this.atividadesDataGridView.DataSource = this.atividadesBindingSource;
            this.atividadesDataGridView.Location = new System.Drawing.Point(509, 374);
            this.atividadesDataGridView.Name = "atividadesDataGridView";
            this.atividadesDataGridView.RowHeadersVisible = false;
            this.atividadesDataGridView.RowHeadersWidth = 62;
            this.atividadesDataGridView.RowTemplate.Height = 28;
            this.atividadesDataGridView.Size = new System.Drawing.Size(575, 441);
            this.atividadesDataGridView.TabIndex = 29;
            this.atividadesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.atividadesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Atividade";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Atividade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Animal";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Animal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Pessoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Pessoa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Funcao";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Funcao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Duracao_min";
            this.dataGridViewTextBoxColumn6.HeaderText = "Duracao_min";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Obs
            // 
            this.Obs.DataPropertyName = "Obs";
            this.Obs.HeaderText = "Obs";
            this.Obs.MinimumWidth = 8;
            this.Obs.Name = "Obs";
            this.Obs.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 141);
            this.button2.TabIndex = 30;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 141);
            this.button3.TabIndex = 31;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 153);
            this.button4.TabIndex = 32;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 564);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 153);
            this.button5.TabIndex = 33;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(744, 307);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(340, 37);
            this.txtObs.TabIndex = 21;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(744, 264);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(340, 37);
            this.txtDuracao.TabIndex = 34;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.atividadesBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(744, 222);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(340, 37);
            this.dataDateTimePicker.TabIndex = 35;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(741, 180);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(343, 37);
            this.txtFuncao.TabIndex = 36;
            // 
            // txtPessoa
            // 
            this.txtPessoa.Location = new System.Drawing.Point(741, 136);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(343, 37);
            this.txtPessoa.TabIndex = 37;
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(741, 93);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(343, 37);
            this.txtAnimal.TabIndex = 38;
            // 
            // txtAtivi
            // 
            this.txtAtivi.Location = new System.Drawing.Point(741, 50);
            this.txtAtivi.Name = "txtAtivi";
            this.txtAtivi.Size = new System.Drawing.Size(343, 37);
            this.txtAtivi.TabIndex = 39;
            // 
            // Atividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1192, 894);
            this.Controls.Add(this.txtAtivi);
            this.Controls.Add(iD_AtividadeLabel);
            this.Controls.Add(iD_AnimalLabel);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(iD_PessoaLabel);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(iD_FuncaoLabel);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(duracao_minLabel);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.atividadesDataGridView);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Atividades";
            this.Text = "Atividades";
            this.Load += new System.EventHandler(this.Atividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource atividadesBindingSource;
        private AbrigoDataSetTableAdapters.AtividadesTableAdapter atividadesTableAdapter;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.DataGridView atividadesDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtAtivi;
    }
}