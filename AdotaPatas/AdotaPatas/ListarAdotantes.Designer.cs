namespace AdotaPatas
{
    partial class ListarAdotantes
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
            System.Windows.Forms.Label horas_sozinho_diaLabel;
            System.Windows.Forms.Label outros_AnimaisLabel;
            System.Windows.Forms.Label criancasLabel;
            System.Windows.Forms.Label n_AgregadosLabel;
            System.Windows.Forms.Label estado_CandidaturaLabel;
            System.Windows.Forms.Label espaco_EsteriorLabel;
            System.Windows.Forms.Label motivo_RecusaLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.adotanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adotanteTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AdotanteTableAdapter();
            this.pessoasTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.PessoasTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adotanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.horas_sozinho_diaTextBox = new System.Windows.Forms.TextBox();
            this.outros_AnimaisCheckBox = new System.Windows.Forms.CheckBox();
            this.criancasCheckBox = new System.Windows.Forms.CheckBox();
            this.n_AgregadosTextBox = new System.Windows.Forms.TextBox();
            this.estado_CandidaturaTextBox = new System.Windows.Forms.TextBox();
            this.espaco_EsteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.motivo_RecusaTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fillComPessoasToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillComPessoasToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telemovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHabitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacoEsteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.habitacaoArrendadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nAgregadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criancasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outrosAnimaisDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horassozinhodiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienciaPreviaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.motivoAdocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estadoCandidaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCandidaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoRecusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            horas_sozinho_diaLabel = new System.Windows.Forms.Label();
            outros_AnimaisLabel = new System.Windows.Forms.Label();
            criancasLabel = new System.Windows.Forms.Label();
            n_AgregadosLabel = new System.Windows.Forms.Label();
            estado_CandidaturaLabel = new System.Windows.Forms.Label();
            espaco_EsteriorLabel = new System.Windows.Forms.Label();
            motivo_RecusaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource1)).BeginInit();
            this.fillComPessoasToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // horas_sozinho_diaLabel
            // 
            horas_sozinho_diaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            horas_sozinho_diaLabel.AutoSize = true;
            horas_sozinho_diaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horas_sozinho_diaLabel.Location = new System.Drawing.Point(64, 519);
            horas_sozinho_diaLabel.Name = "horas_sozinho_diaLabel";
            horas_sozinho_diaLabel.Size = new System.Drawing.Size(145, 17);
            horas_sozinho_diaLabel.TabIndex = 33;
            horas_sozinho_diaLabel.Text = "Horas sozinho por dia:";
            // 
            // outros_AnimaisLabel
            // 
            outros_AnimaisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            outros_AnimaisLabel.AutoSize = true;
            outros_AnimaisLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            outros_AnimaisLabel.Location = new System.Drawing.Point(64, 485);
            outros_AnimaisLabel.Name = "outros_AnimaisLabel";
            outros_AnimaisLabel.Size = new System.Drawing.Size(105, 17);
            outros_AnimaisLabel.TabIndex = 34;
            outros_AnimaisLabel.Text = "Outros Animais:";
            // 
            // criancasLabel
            // 
            criancasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            criancasLabel.AutoSize = true;
            criancasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            criancasLabel.Location = new System.Drawing.Point(218, 485);
            criancasLabel.Name = "criancasLabel";
            criancasLabel.Size = new System.Drawing.Size(61, 17);
            criancasLabel.TabIndex = 35;
            criancasLabel.Text = "Crianças:";
            // 
            // n_AgregadosLabel
            // 
            n_AgregadosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            n_AgregadosLabel.AutoSize = true;
            n_AgregadosLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n_AgregadosLabel.Location = new System.Drawing.Point(313, 519);
            n_AgregadosLabel.Name = "n_AgregadosLabel";
            n_AgregadosLabel.Size = new System.Drawing.Size(97, 17);
            n_AgregadosLabel.TabIndex = 36;
            n_AgregadosLabel.Text = "Nº Agregados:";
            // 
            // estado_CandidaturaLabel
            // 
            estado_CandidaturaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            estado_CandidaturaLabel.AutoSize = true;
            estado_CandidaturaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estado_CandidaturaLabel.Location = new System.Drawing.Point(735, 482);
            estado_CandidaturaLabel.Name = "estado_CandidaturaLabel";
            estado_CandidaturaLabel.Size = new System.Drawing.Size(130, 17);
            estado_CandidaturaLabel.TabIndex = 37;
            estado_CandidaturaLabel.Text = "Estado Candidatura:";
            // 
            // espaco_EsteriorLabel
            // 
            espaco_EsteriorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            espaco_EsteriorLabel.AutoSize = true;
            espaco_EsteriorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            espaco_EsteriorLabel.Location = new System.Drawing.Point(313, 485);
            espaco_EsteriorLabel.Name = "espaco_EsteriorLabel";
            espaco_EsteriorLabel.Size = new System.Drawing.Size(105, 17);
            espaco_EsteriorLabel.TabIndex = 38;
            espaco_EsteriorLabel.Text = "Espaco Exterior:";
            // 
            // motivo_RecusaLabel
            // 
            motivo_RecusaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            motivo_RecusaLabel.AutoSize = true;
            motivo_RecusaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motivo_RecusaLabel.Location = new System.Drawing.Point(735, 517);
            motivo_RecusaLabel.Name = "motivo_RecusaLabel";
            motivo_RecusaLabel.Size = new System.Drawing.Size(100, 17);
            motivo_RecusaLabel.TabIndex = 39;
            motivo_RecusaLabel.Text = "Motivo Recusa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPessoaDataGridViewTextBoxColumn,
            this.Nome,
            this.Data_Nascimento,
            this.Morada,
            this.Telemovel,
            this.Email,
            this.bIDataGridViewTextBoxColumn,
            this.profissaoDataGridViewTextBoxColumn,
            this.iDHabitacaoDataGridViewTextBoxColumn,
            this.espacoEsteriorDataGridViewCheckBoxColumn,
            this.habitacaoArrendadaDataGridViewCheckBoxColumn,
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn,
            this.nAgregadosDataGridViewTextBoxColumn,
            this.criancasDataGridViewCheckBoxColumn,
            this.outrosAnimaisDataGridViewCheckBoxColumn,
            this.horassozinhodiaDataGridViewTextBoxColumn,
            this.experienciaPreviaDataGridViewCheckBoxColumn,
            this.motivoAdocaoDataGridViewTextBoxColumn,
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn,
            this.estadoCandidaturaDataGridViewTextBoxColumn,
            this.dataCandidaturaDataGridViewTextBoxColumn,
            this.motivoRecusaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adotanteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(975, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // adotanteBindingSource
            // 
            this.adotanteBindingSource.DataMember = "Adotante";
            this.adotanteBindingSource.DataSource = this.abrigoDataSet;
            // 
            // adotanteTableAdapter
            // 
            this.adotanteTableAdapter.ClearBeforeFill = true;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(316, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(30, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Existentes na base de dados";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Adoptantes";
            // 
            // adotanteBindingSource1
            // 
            this.adotanteBindingSource1.DataMember = "FK_Adotante_Pessoas";
            this.adotanteBindingSource1.DataSource = this.pessoasBindingSource;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdocaoTableAdapter = null;
            this.tableAdapterManager.AdotanteTableAdapter = this.adotanteTableAdapter;
            this.tableAdapterManager.AnimaisTableAdapter = null;
            this.tableAdapterManager.AtividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumiveisTableAdapter = null;
            this.tableAdapterManager.FuncoesTableAdapter = null;
            this.tableAdapterManager.PessoasTableAdapter = this.pessoasTableAdapter;
            this.tableAdapterManager.UpdateOrder = AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            this.tableAdapterManager.VoluntariosTableAdapter = null;
            // 
            // horas_sozinho_diaTextBox
            // 
            this.horas_sozinho_diaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.horas_sozinho_diaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource1, "Horas_sozinho_dia", true));
            this.horas_sozinho_diaTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas_sozinho_diaTextBox.Location = new System.Drawing.Point(215, 516);
            this.horas_sozinho_diaTextBox.Name = "horas_sozinho_diaTextBox";
            this.horas_sozinho_diaTextBox.Size = new System.Drawing.Size(64, 25);
            this.horas_sozinho_diaTextBox.TabIndex = 34;
            // 
            // outros_AnimaisCheckBox
            // 
            this.outros_AnimaisCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outros_AnimaisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource1, "Outros_Animais", true));
            this.outros_AnimaisCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outros_AnimaisCheckBox.Location = new System.Drawing.Point(175, 482);
            this.outros_AnimaisCheckBox.Name = "outros_AnimaisCheckBox";
            this.outros_AnimaisCheckBox.Size = new System.Drawing.Size(21, 24);
            this.outros_AnimaisCheckBox.TabIndex = 35;
            this.outros_AnimaisCheckBox.UseVisualStyleBackColor = true;
            // 
            // criancasCheckBox
            // 
            this.criancasCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.criancasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource1, "Criancas", true));
            this.criancasCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criancasCheckBox.Location = new System.Drawing.Point(285, 482);
            this.criancasCheckBox.Name = "criancasCheckBox";
            this.criancasCheckBox.Size = new System.Drawing.Size(22, 24);
            this.criancasCheckBox.TabIndex = 36;
            this.criancasCheckBox.UseVisualStyleBackColor = true;
            // 
            // n_AgregadosTextBox
            // 
            this.n_AgregadosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.n_AgregadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource1, "N_Agregados", true));
            this.n_AgregadosTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_AgregadosTextBox.Location = new System.Drawing.Point(416, 516);
            this.n_AgregadosTextBox.Name = "n_AgregadosTextBox";
            this.n_AgregadosTextBox.Size = new System.Drawing.Size(68, 25);
            this.n_AgregadosTextBox.TabIndex = 37;
            // 
            // estado_CandidaturaTextBox
            // 
            this.estado_CandidaturaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.estado_CandidaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource1, "Estado_Candidatura", true));
            this.estado_CandidaturaTextBox.Location = new System.Drawing.Point(871, 480);
            this.estado_CandidaturaTextBox.Name = "estado_CandidaturaTextBox";
            this.estado_CandidaturaTextBox.Size = new System.Drawing.Size(161, 20);
            this.estado_CandidaturaTextBox.TabIndex = 38;
            // 
            // espaco_EsteriorCheckBox
            // 
            this.espaco_EsteriorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.espaco_EsteriorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource1, "Espaco_Esterior", true));
            this.espaco_EsteriorCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espaco_EsteriorCheckBox.Location = new System.Drawing.Point(424, 482);
            this.espaco_EsteriorCheckBox.Name = "espaco_EsteriorCheckBox";
            this.espaco_EsteriorCheckBox.Size = new System.Drawing.Size(24, 24);
            this.espaco_EsteriorCheckBox.TabIndex = 39;
            this.espaco_EsteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // motivo_RecusaTextBox
            // 
            this.motivo_RecusaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.motivo_RecusaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource1, "Motivo_Recusa", true));
            this.motivo_RecusaTextBox.Location = new System.Drawing.Point(863, 509);
            this.motivo_RecusaTextBox.Multiline = true;
            this.motivo_RecusaTextBox.Name = "motivo_RecusaTextBox";
            this.motivo_RecusaTextBox.Size = new System.Drawing.Size(169, 37);
            this.motivo_RecusaTextBox.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(67, 568);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 40);
            this.button6.TabIndex = 41;
            this.button6.Text = "Voltar ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(854, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 42;
            this.button1.Text = "Próximo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillComPessoasToolStrip
            // 
            this.fillComPessoasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillComPessoasToolStripButton});
            this.fillComPessoasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillComPessoasToolStrip.Name = "fillComPessoasToolStrip";
            this.fillComPessoasToolStrip.Size = new System.Drawing.Size(1106, 25);
            this.fillComPessoasToolStrip.TabIndex = 43;
            this.fillComPessoasToolStrip.Text = "fillComPessoasToolStrip";
            // 
            // fillComPessoasToolStripButton
            // 
            this.fillComPessoasToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillComPessoasToolStripButton.Name = "fillComPessoasToolStripButton";
            this.fillComPessoasToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.fillComPessoasToolStripButton.Text = "FillComPessoas";
            this.fillComPessoasToolStripButton.Click += new System.EventHandler(this.fillComPessoasToolStripButton_Click);
            // 
            // iDPessoaDataGridViewTextBoxColumn
            // 
            this.iDPessoaDataGridViewTextBoxColumn.DataPropertyName = "ID_Pessoa";
            this.iDPessoaDataGridViewTextBoxColumn.HeaderText = "ID_Pessoa";
            this.iDPessoaDataGridViewTextBoxColumn.Name = "iDPessoaDataGridViewTextBoxColumn";
            this.iDPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.DataPropertyName = "Data_Nascimento";
            this.Data_Nascimento.HeaderText = "Data de Nascimento";
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.ReadOnly = true;
            // 
            // Morada
            // 
            this.Morada.DataPropertyName = "Morada";
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            // 
            // Telemovel
            // 
            this.Telemovel.DataPropertyName = "Telemovel";
            this.Telemovel.HeaderText = "Telemóvel";
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Nome";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // bIDataGridViewTextBoxColumn
            // 
            this.bIDataGridViewTextBoxColumn.DataPropertyName = "BI";
            this.bIDataGridViewTextBoxColumn.HeaderText = "BI";
            this.bIDataGridViewTextBoxColumn.Name = "bIDataGridViewTextBoxColumn";
            this.bIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDataGridViewTextBoxColumn.Visible = false;
            // 
            // profissaoDataGridViewTextBoxColumn
            // 
            this.profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
            this.profissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.profissaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDHabitacaoDataGridViewTextBoxColumn
            // 
            this.iDHabitacaoDataGridViewTextBoxColumn.DataPropertyName = "ID_Habitacao";
            this.iDHabitacaoDataGridViewTextBoxColumn.HeaderText = "ID_Habitacao";
            this.iDHabitacaoDataGridViewTextBoxColumn.Name = "iDHabitacaoDataGridViewTextBoxColumn";
            this.iDHabitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDHabitacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // espacoEsteriorDataGridViewCheckBoxColumn
            // 
            this.espacoEsteriorDataGridViewCheckBoxColumn.DataPropertyName = "Espaco_Esterior";
            this.espacoEsteriorDataGridViewCheckBoxColumn.HeaderText = "Espaco_Esterior";
            this.espacoEsteriorDataGridViewCheckBoxColumn.Name = "espacoEsteriorDataGridViewCheckBoxColumn";
            this.espacoEsteriorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.espacoEsteriorDataGridViewCheckBoxColumn.Visible = false;
            // 
            // habitacaoArrendadaDataGridViewCheckBoxColumn
            // 
            this.habitacaoArrendadaDataGridViewCheckBoxColumn.DataPropertyName = "Habitacao_Arrendada";
            this.habitacaoArrendadaDataGridViewCheckBoxColumn.HeaderText = "Habitacao_Arrendada";
            this.habitacaoArrendadaDataGridViewCheckBoxColumn.Name = "habitacaoArrendadaDataGridViewCheckBoxColumn";
            this.habitacaoArrendadaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.habitacaoArrendadaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // autorizacaoSenhorioDataGridViewCheckBoxColumn
            // 
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn.DataPropertyName = "Autorizacao_Senhorio";
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn.HeaderText = "Autorizacao_Senhorio";
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn.Name = "autorizacaoSenhorioDataGridViewCheckBoxColumn";
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn.ReadOnly = true;
            this.autorizacaoSenhorioDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nAgregadosDataGridViewTextBoxColumn
            // 
            this.nAgregadosDataGridViewTextBoxColumn.DataPropertyName = "N_Agregados";
            this.nAgregadosDataGridViewTextBoxColumn.HeaderText = "N_Agregados";
            this.nAgregadosDataGridViewTextBoxColumn.Name = "nAgregadosDataGridViewTextBoxColumn";
            this.nAgregadosDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAgregadosDataGridViewTextBoxColumn.Visible = false;
            // 
            // criancasDataGridViewCheckBoxColumn
            // 
            this.criancasDataGridViewCheckBoxColumn.DataPropertyName = "Criancas";
            this.criancasDataGridViewCheckBoxColumn.HeaderText = "Criancas";
            this.criancasDataGridViewCheckBoxColumn.Name = "criancasDataGridViewCheckBoxColumn";
            this.criancasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.criancasDataGridViewCheckBoxColumn.Visible = false;
            // 
            // outrosAnimaisDataGridViewCheckBoxColumn
            // 
            this.outrosAnimaisDataGridViewCheckBoxColumn.DataPropertyName = "Outros_Animais";
            this.outrosAnimaisDataGridViewCheckBoxColumn.HeaderText = "Outros_Animais";
            this.outrosAnimaisDataGridViewCheckBoxColumn.Name = "outrosAnimaisDataGridViewCheckBoxColumn";
            this.outrosAnimaisDataGridViewCheckBoxColumn.ReadOnly = true;
            this.outrosAnimaisDataGridViewCheckBoxColumn.Visible = false;
            // 
            // horassozinhodiaDataGridViewTextBoxColumn
            // 
            this.horassozinhodiaDataGridViewTextBoxColumn.DataPropertyName = "Horas_sozinho_dia";
            this.horassozinhodiaDataGridViewTextBoxColumn.HeaderText = "Horas_sozinho_dia";
            this.horassozinhodiaDataGridViewTextBoxColumn.Name = "horassozinhodiaDataGridViewTextBoxColumn";
            this.horassozinhodiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horassozinhodiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // experienciaPreviaDataGridViewCheckBoxColumn
            // 
            this.experienciaPreviaDataGridViewCheckBoxColumn.DataPropertyName = "Experiencia_Previa";
            this.experienciaPreviaDataGridViewCheckBoxColumn.HeaderText = "Experiencia_Previa";
            this.experienciaPreviaDataGridViewCheckBoxColumn.Name = "experienciaPreviaDataGridViewCheckBoxColumn";
            this.experienciaPreviaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.experienciaPreviaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // motivoAdocaoDataGridViewTextBoxColumn
            // 
            this.motivoAdocaoDataGridViewTextBoxColumn.DataPropertyName = "Motivo_Adocao";
            this.motivoAdocaoDataGridViewTextBoxColumn.HeaderText = "Motivo_Adocao";
            this.motivoAdocaoDataGridViewTextBoxColumn.Name = "motivoAdocaoDataGridViewTextBoxColumn";
            this.motivoAdocaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivoAdocaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // aceitaAcompanhamentoDataGridViewCheckBoxColumn
            // 
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn.DataPropertyName = "Aceita_Acompanhamento";
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn.HeaderText = "Aceita_Acompanhamento";
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn.Name = "aceitaAcompanhamentoDataGridViewCheckBoxColumn";
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aceitaAcompanhamentoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // estadoCandidaturaDataGridViewTextBoxColumn
            // 
            this.estadoCandidaturaDataGridViewTextBoxColumn.DataPropertyName = "Estado_Candidatura";
            this.estadoCandidaturaDataGridViewTextBoxColumn.HeaderText = "Estado_Candidatura";
            this.estadoCandidaturaDataGridViewTextBoxColumn.Name = "estadoCandidaturaDataGridViewTextBoxColumn";
            this.estadoCandidaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoCandidaturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCandidaturaDataGridViewTextBoxColumn
            // 
            this.dataCandidaturaDataGridViewTextBoxColumn.DataPropertyName = "Data_Candidatura";
            this.dataCandidaturaDataGridViewTextBoxColumn.HeaderText = "Data_Candidatura";
            this.dataCandidaturaDataGridViewTextBoxColumn.Name = "dataCandidaturaDataGridViewTextBoxColumn";
            this.dataCandidaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCandidaturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // motivoRecusaDataGridViewTextBoxColumn
            // 
            this.motivoRecusaDataGridViewTextBoxColumn.DataPropertyName = "Motivo_Recusa";
            this.motivoRecusaDataGridViewTextBoxColumn.HeaderText = "Motivo_Recusa";
            this.motivoRecusaDataGridViewTextBoxColumn.Name = "motivoRecusaDataGridViewTextBoxColumn";
            this.motivoRecusaDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivoRecusaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ListarAdotantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1106, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(motivo_RecusaLabel);
            this.Controls.Add(this.motivo_RecusaTextBox);
            this.Controls.Add(espaco_EsteriorLabel);
            this.Controls.Add(this.espaco_EsteriorCheckBox);
            this.Controls.Add(estado_CandidaturaLabel);
            this.Controls.Add(this.estado_CandidaturaTextBox);
            this.Controls.Add(n_AgregadosLabel);
            this.Controls.Add(this.n_AgregadosTextBox);
            this.Controls.Add(criancasLabel);
            this.Controls.Add(this.criancasCheckBox);
            this.Controls.Add(outros_AnimaisLabel);
            this.Controls.Add(this.outros_AnimaisCheckBox);
            this.Controls.Add(horas_sozinho_diaLabel);
            this.Controls.Add(this.horas_sozinho_diaTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillComPessoasToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(210, 53);
            this.Name = "ListarAdotantes";
            this.Text = "ListarAdotantes";
            this.Load += new System.EventHandler(this.ListarAdotantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource1)).EndInit();
            this.fillComPessoasToolStrip.ResumeLayout(false);
            this.fillComPessoasToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource adotanteBindingSource;
        private AbrigoDataSetTableAdapters.AdotanteTableAdapter adotanteTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private AbrigoDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource adotanteBindingSource1;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox horas_sozinho_diaTextBox;
        private System.Windows.Forms.CheckBox outros_AnimaisCheckBox;
        private System.Windows.Forms.CheckBox criancasCheckBox;
        private System.Windows.Forms.TextBox n_AgregadosTextBox;
        private System.Windows.Forms.TextBox estado_CandidaturaTextBox;
        private System.Windows.Forms.CheckBox espaco_EsteriorCheckBox;
        private System.Windows.Forms.TextBox motivo_RecusaTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillComPessoasToolStrip;
        private System.Windows.Forms.ToolStripButton fillComPessoasToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telemovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHabitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn espacoEsteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habitacaoArrendadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorizacaoSenhorioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAgregadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn criancasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outrosAnimaisDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horassozinhodiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn experienciaPreviaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoAdocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aceitaAcompanhamentoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCandidaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCandidaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoRecusaDataGridViewTextBoxColumn;
    }
}