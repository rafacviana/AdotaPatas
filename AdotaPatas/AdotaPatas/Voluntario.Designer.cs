namespace AdotaPatas
{
    partial class Voluntario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.iDFuncaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Função = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.funcoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cartaConducaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viaturaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contactoEmergenciaNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoEmergenciaTelemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizacaoEncarregadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.voluntariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voluntariosTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.VoluntariosTableAdapter();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.voluntariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.PessoasTableAdapter();
            this.funcoesTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.FuncoesTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(32, 560);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "Voltar ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(874, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPessoaDataGridViewTextBoxColumn,
            this.Nome,
            this.iDFuncaoDataGridViewTextBoxColumn,
            this.Função,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.cartaConducaoDataGridViewCheckBoxColumn,
            this.viaturaDataGridViewCheckBoxColumn,
            this.contactoEmergenciaNomeDataGridViewTextBoxColumn,
            this.contactoEmergenciaTelemovelDataGridViewTextBoxColumn,
            this.autorizacaoEncarregadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.voluntariosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 322);
            this.dataGridView1.TabIndex = 16;
            // 
            // iDPessoaDataGridViewTextBoxColumn
            // 
            this.iDPessoaDataGridViewTextBoxColumn.DataPropertyName = "ID_Pessoa";
            this.iDPessoaDataGridViewTextBoxColumn.HeaderText = "ID_Pessoa";
            this.iDPessoaDataGridViewTextBoxColumn.Name = "iDPessoaDataGridViewTextBoxColumn";
            this.iDPessoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "ID_Pessoa";
            this.Nome.DataSource = this.pessoasBindingSource;
            this.Nome.DisplayMember = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ValueMember = "ID_Pessoas";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.abrigoDataSet;
            // 
            // abrigoDataSet
            // 
            this.abrigoDataSet.DataSetName = "AbrigoDataSet";
            this.abrigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDFuncaoDataGridViewTextBoxColumn
            // 
            this.iDFuncaoDataGridViewTextBoxColumn.DataPropertyName = "ID_Funcao";
            this.iDFuncaoDataGridViewTextBoxColumn.HeaderText = "ID_Funcao";
            this.iDFuncaoDataGridViewTextBoxColumn.Name = "iDFuncaoDataGridViewTextBoxColumn";
            this.iDFuncaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Função
            // 
            this.Função.DataPropertyName = "ID_Funcao";
            this.Função.DataSource = this.funcoesBindingSource;
            this.Função.DisplayMember = "Nome";
            this.Função.HeaderText = "Função";
            this.Função.Name = "Função";
            this.Função.ValueMember = "ID_Funcao";
            // 
            // funcoesBindingSource
            // 
            this.funcoesBindingSource.DataMember = "Funcoes";
            this.funcoesBindingSource.DataSource = this.abrigoDataSet;
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "Data_Inicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "Data_Inicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "Data_Fim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "Data_Fim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.Width = 80;
            // 
            // cartaConducaoDataGridViewCheckBoxColumn
            // 
            this.cartaConducaoDataGridViewCheckBoxColumn.DataPropertyName = "Carta_Conducao";
            this.cartaConducaoDataGridViewCheckBoxColumn.HeaderText = "Carta_Conducao";
            this.cartaConducaoDataGridViewCheckBoxColumn.Name = "cartaConducaoDataGridViewCheckBoxColumn";
            // 
            // viaturaDataGridViewCheckBoxColumn
            // 
            this.viaturaDataGridViewCheckBoxColumn.DataPropertyName = "Viatura";
            this.viaturaDataGridViewCheckBoxColumn.FillWeight = 80F;
            this.viaturaDataGridViewCheckBoxColumn.HeaderText = "Viatura";
            this.viaturaDataGridViewCheckBoxColumn.Name = "viaturaDataGridViewCheckBoxColumn";
            // 
            // contactoEmergenciaNomeDataGridViewTextBoxColumn
            // 
            this.contactoEmergenciaNomeDataGridViewTextBoxColumn.DataPropertyName = "Contacto_Emergencia_Nome";
            this.contactoEmergenciaNomeDataGridViewTextBoxColumn.HeaderText = "Contacto_Emergencia_Nome";
            this.contactoEmergenciaNomeDataGridViewTextBoxColumn.Name = "contactoEmergenciaNomeDataGridViewTextBoxColumn";
            // 
            // contactoEmergenciaTelemovelDataGridViewTextBoxColumn
            // 
            this.contactoEmergenciaTelemovelDataGridViewTextBoxColumn.DataPropertyName = "Contacto_Emergencia_Telemovel";
            this.contactoEmergenciaTelemovelDataGridViewTextBoxColumn.HeaderText = "Contacto_Emergencia_Telemovel";
            this.contactoEmergenciaTelemovelDataGridViewTextBoxColumn.Name = "contactoEmergenciaTelemovelDataGridViewTextBoxColumn";
            // 
            // autorizacaoEncarregadoDataGridViewCheckBoxColumn
            // 
            this.autorizacaoEncarregadoDataGridViewCheckBoxColumn.DataPropertyName = "Autorizacao_Encarregado";
            this.autorizacaoEncarregadoDataGridViewCheckBoxColumn.HeaderText = "Autorizacao_Encarregado";
            this.autorizacaoEncarregadoDataGridViewCheckBoxColumn.Name = "autorizacaoEncarregadoDataGridViewCheckBoxColumn";
            // 
            // voluntariosBindingSource
            // 
            this.voluntariosBindingSource.DataMember = "Voluntarios";
            this.voluntariosBindingSource.DataSource = this.abrigoDataSet;
            // 
            // voluntariosTableAdapter
            // 
            this.voluntariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(13, 82);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 49);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Cadastrar Voluntario";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1018, 89);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 42);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // voluntariosBindingSource1
            // 
            this.voluntariosBindingSource1.DataMember = "Voluntarios";
            this.voluntariosBindingSource1.DataSource = this.abrigoDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // funcoesTableAdapter
            // 
            this.funcoesTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Mostrar apenas voluntários ativos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 20);
            this.textBox1.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(761, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Voluntario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1106, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voluntario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Voluntario";
            this.Load += new System.EventHandler(this.Voluntario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource voluntariosBindingSource;
        private AbrigoDataSetTableAdapters.VoluntariosTableAdapter voluntariosTableAdapter;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource voluntariosBindingSource1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private AbrigoDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.BindingSource funcoesBindingSource;
        private AbrigoDataSetTableAdapters.FuncoesTableAdapter funcoesTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFuncaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Função;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cartaConducaoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn viaturaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoEmergenciaNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoEmergenciaTelemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorizacaoEncarregadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
    }
}