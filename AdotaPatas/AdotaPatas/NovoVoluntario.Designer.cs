namespace AdotaPatas
{
    partial class NovoVoluntario
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
            System.Windows.Forms.Label data_NascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label telemovelLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label obs_Label;
            System.Windows.Forms.Label data_InicioLabel;
            System.Windows.Forms.Label iD_FuncaoLabel;
            System.Windows.Forms.Label carta_ConducaoLabel;
            System.Windows.Forms.Label contacto_Emergencia_NomeLabel;
            System.Windows.Forms.Label contacto_Emergencia_TelemovelLabel;
            System.Windows.Forms.Label nomeLabel1;
            this.voluntariosTableAdapter1 = new AdotaPatas.AbrigoDataSetTableAdapters.VoluntariosTableAdapter();
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.abrigoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcoesTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.FuncoesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.voluntariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.PessoasTableAdapter();
            this.data_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.obs_TextBox = new System.Windows.Forms.TextBox();
            this.data_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_FuncaoComboBox = new System.Windows.Forms.ComboBox();
            this.carta_ConducaoCheckBox = new System.Windows.Forms.CheckBox();
            this.viaturaCheckBox = new System.Windows.Forms.CheckBox();
            this.contacto_Emergencia_NomeTextBox = new System.Windows.Forms.TextBox();
            this.contacto_Emergencia_TelemovelTextBox = new System.Windows.Forms.TextBox();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.autorizacao_EncarregadoCheckBox = new System.Windows.Forms.CheckBox();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            telemovelLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            obs_Label = new System.Windows.Forms.Label();
            data_InicioLabel = new System.Windows.Forms.Label();
            iD_FuncaoLabel = new System.Windows.Forms.Label();
            carta_ConducaoLabel = new System.Windows.Forms.Label();
            contacto_Emergencia_NomeLabel = new System.Windows.Forms.Label();
            contacto_Emergencia_TelemovelLabel = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // voluntariosTableAdapter1
            // 
            this.voluntariosTableAdapter1.ClearBeforeFill = true;
            // 
            // abrigoDataSet
            // 
            this.abrigoDataSet.DataSetName = "AbrigoDataSet";
            this.abrigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abrigoDataSetBindingSource
            // 
            this.abrigoDataSetBindingSource.DataSource = this.abrigoDataSet;
            this.abrigoDataSetBindingSource.Position = 0;
            // 
            // funcoesBindingSource
            // 
            this.funcoesBindingSource.DataMember = "Funcoes";
            this.funcoesBindingSource.DataSource = this.abrigoDataSet;
            // 
            // funcoesTableAdapter
            // 
            this.funcoesTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(91, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cadastro de Voluntário";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(540, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(68, 501);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 40);
            this.button6.TabIndex = 17;
            this.button6.Text = "Voltar ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(598, 407);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 49);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo Voluntário";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // voluntariosBindingSource
            // 
            this.voluntariosBindingSource.DataMember = "Voluntarios";
            this.voluntariosBindingSource.DataSource = this.abrigoDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdocaoTableAdapter = null;
            this.tableAdapterManager.AdotanteTableAdapter = null;
            this.tableAdapterManager.AnimaisTableAdapter = null;
            this.tableAdapterManager.AtividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumiveisTableAdapter = null;
            this.tableAdapterManager.FuncoesTableAdapter = this.funcoesTableAdapter;
            this.tableAdapterManager.PessoasTableAdapter = this.pessoasTableAdapter;
            this.tableAdapterManager.UpdateOrder = AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            this.tableAdapterManager.VoluntariosTableAdapter = this.voluntariosTableAdapter1;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.abrigoDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Location = new System.Drawing.Point(63, 130);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(130, 20);
            data_NascimentoLabel.TabIndex = 22;
            data_NascimentoLabel.Text = "Data Nascimento:";
            // 
            // data_NascimentoDateTimePicker
            // 
            this.data_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoasBindingSource, "Data_Nascimento", true));
            this.data_NascimentoDateTimePicker.Location = new System.Drawing.Point(199, 126);
            this.data_NascimentoDateTimePicker.Name = "data_NascimentoDateTimePicker";
            this.data_NascimentoDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.data_NascimentoDateTimePicker.TabIndex = 23;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(67, 99);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 23;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(128, 93);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 27);
            this.nomeTextBox.TabIndex = 24;
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(64, 195);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(67, 20);
            moradaLabel.TabIndex = 24;
            moradaLabel.Text = "Morada:";
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(137, 192);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(352, 27);
            this.moradaTextBox.TabIndex = 25;
            // 
            // telemovelLabel
            // 
            telemovelLabel.AutoSize = true;
            telemovelLabel.Location = new System.Drawing.Point(506, 99);
            telemovelLabel.Name = "telemovelLabel";
            telemovelLabel.Size = new System.Drawing.Size(82, 20);
            telemovelLabel.TabIndex = 25;
            telemovelLabel.Text = "Telemóvel:";
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Telemovel", true));
            this.telemovelTextBox.Location = new System.Drawing.Point(594, 96);
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(134, 27);
            this.telemovelTextBox.TabIndex = 26;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(64, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 27);
            this.emailTextBox.TabIndex = 27;
            // 
            // obs_Label
            // 
            obs_Label.AutoSize = true;
            obs_Label.Location = new System.Drawing.Point(64, 228);
            obs_Label.Name = "obs_Label";
            obs_Label.Size = new System.Drawing.Size(39, 20);
            obs_Label.TabIndex = 27;
            obs_Label.Text = "Obs:";
            // 
            // obs_TextBox
            // 
            this.obs_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Obs:", true));
            this.obs_TextBox.Location = new System.Drawing.Point(109, 225);
            this.obs_TextBox.Multiline = true;
            this.obs_TextBox.Name = "obs_TextBox";
            this.obs_TextBox.Size = new System.Drawing.Size(377, 65);
            this.obs_TextBox.TabIndex = 28;
            // 
            // data_InicioLabel
            // 
            data_InicioLabel.AutoSize = true;
            data_InicioLabel.Location = new System.Drawing.Point(415, 299);
            data_InicioLabel.Name = "data_InicioLabel";
            data_InicioLabel.Size = new System.Drawing.Size(107, 20);
            data_InicioLabel.TabIndex = 28;
            data_InicioLabel.Text = "Data de Início:";
            // 
            // data_InicioDateTimePicker
            // 
            this.data_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voluntariosBindingSource, "Data_Inicio", true));
            this.data_InicioDateTimePicker.Location = new System.Drawing.Point(528, 294);
            this.data_InicioDateTimePicker.Name = "data_InicioDateTimePicker";
            this.data_InicioDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.data_InicioDateTimePicker.TabIndex = 29;
            // 
            // iD_FuncaoLabel
            // 
            iD_FuncaoLabel.AutoSize = true;
            iD_FuncaoLabel.Location = new System.Drawing.Point(269, 301);
            iD_FuncaoLabel.Name = "iD_FuncaoLabel";
            iD_FuncaoLabel.Size = new System.Drawing.Size(28, 20);
            iD_FuncaoLabel.TabIndex = 29;
            iD_FuncaoLabel.Text = "ID:";
            // 
            // iD_FuncaoComboBox
            // 
            this.iD_FuncaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntariosBindingSource, "ID_Funcao", true));
            this.iD_FuncaoComboBox.FormattingEnabled = true;
            this.iD_FuncaoComboBox.Location = new System.Drawing.Point(303, 298);
            this.iD_FuncaoComboBox.Name = "iD_FuncaoComboBox";
            this.iD_FuncaoComboBox.Size = new System.Drawing.Size(56, 28);
            this.iD_FuncaoComboBox.TabIndex = 30;
            // 
            // carta_ConducaoLabel
            // 
            carta_ConducaoLabel.AutoSize = true;
            carta_ConducaoLabel.Location = new System.Drawing.Point(506, 166);
            carta_ConducaoLabel.Name = "carta_ConducaoLabel";
            carta_ConducaoLabel.Size = new System.Drawing.Size(0, 20);
            carta_ConducaoLabel.TabIndex = 30;
            // 
            // carta_ConducaoCheckBox
            // 
            this.carta_ConducaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voluntariosBindingSource, "Carta_Conducao", true));
            this.carta_ConducaoCheckBox.Location = new System.Drawing.Point(430, 129);
            this.carta_ConducaoCheckBox.Name = "carta_ConducaoCheckBox";
            this.carta_ConducaoCheckBox.Size = new System.Drawing.Size(141, 24);
            this.carta_ConducaoCheckBox.TabIndex = 31;
            this.carta_ConducaoCheckBox.Text = "Carta Condução";
            this.carta_ConducaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // viaturaCheckBox
            // 
            this.viaturaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voluntariosBindingSource, "Viatura", true));
            this.viaturaCheckBox.Location = new System.Drawing.Point(587, 129);
            this.viaturaCheckBox.Name = "viaturaCheckBox";
            this.viaturaCheckBox.Size = new System.Drawing.Size(141, 24);
            this.viaturaCheckBox.TabIndex = 32;
            this.viaturaCheckBox.Text = "Viatura Própria";
            this.viaturaCheckBox.UseVisualStyleBackColor = true;
            // 
            // contacto_Emergencia_NomeLabel
            // 
            contacto_Emergencia_NomeLabel.AutoSize = true;
            contacto_Emergencia_NomeLabel.Location = new System.Drawing.Point(63, 340);
            contacto_Emergencia_NomeLabel.Name = "contacto_Emergencia_NomeLabel";
            contacto_Emergencia_NomeLabel.Size = new System.Drawing.Size(226, 20);
            contacto_Emergencia_NomeLabel.TabIndex = 32;
            contacto_Emergencia_NomeLabel.Text = "Nome do Contacto Emergência:";
            contacto_Emergencia_NomeLabel.Click += new System.EventHandler(this.contacto_Emergencia_NomeLabel_Click);
            // 
            // contacto_Emergencia_NomeTextBox
            // 
            this.contacto_Emergencia_NomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntariosBindingSource, "Contacto_Emergencia_Nome", true));
            this.contacto_Emergencia_NomeTextBox.Location = new System.Drawing.Point(291, 337);
            this.contacto_Emergencia_NomeTextBox.Name = "contacto_Emergencia_NomeTextBox";
            this.contacto_Emergencia_NomeTextBox.Size = new System.Drawing.Size(213, 27);
            this.contacto_Emergencia_NomeTextBox.TabIndex = 33;
            // 
            // contacto_Emergencia_TelemovelLabel
            // 
            contacto_Emergencia_TelemovelLabel.AutoSize = true;
            contacto_Emergencia_TelemovelLabel.Location = new System.Drawing.Point(522, 343);
            contacto_Emergencia_TelemovelLabel.Name = "contacto_Emergencia_TelemovelLabel";
            contacto_Emergencia_TelemovelLabel.Size = new System.Drawing.Size(82, 20);
            contacto_Emergencia_TelemovelLabel.TabIndex = 33;
            contacto_Emergencia_TelemovelLabel.Text = "Telemóvel:";
            // 
            // contacto_Emergencia_TelemovelTextBox
            // 
            this.contacto_Emergencia_TelemovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntariosBindingSource, "Contacto_Emergencia_Telemovel", true));
            this.contacto_Emergencia_TelemovelTextBox.Location = new System.Drawing.Point(610, 340);
            this.contacto_Emergencia_TelemovelTextBox.Name = "contacto_Emergencia_TelemovelTextBox";
            this.contacto_Emergencia_TelemovelTextBox.Size = new System.Drawing.Size(118, 27);
            this.contacto_Emergencia_TelemovelTextBox.TabIndex = 34;
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(63, 301);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(63, 20);
            nomeLabel1.TabIndex = 34;
            nomeLabel1.Text = "Função:";
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcoesBindingSource, "Nome", true));
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(132, 298);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(121, 28);
            this.nomeComboBox.TabIndex = 35;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voluntariosBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(67, 384);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ativoCheckBox.TabIndex = 36;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // autorizacao_EncarregadoCheckBox
            // 
            this.autorizacao_EncarregadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.voluntariosBindingSource, "Autorizacao_Encarregado", true));
            this.autorizacao_EncarregadoCheckBox.Location = new System.Drawing.Point(152, 384);
            this.autorizacao_EncarregadoCheckBox.Name = "autorizacao_EncarregadoCheckBox";
            this.autorizacao_EncarregadoCheckBox.Size = new System.Drawing.Size(207, 24);
            this.autorizacao_EncarregadoCheckBox.TabIndex = 37;
            this.autorizacao_EncarregadoCheckBox.Text = "Autorização Encarregado";
            this.autorizacao_EncarregadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // NovoVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(799, 579);
            this.Controls.Add(this.autorizacao_EncarregadoCheckBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(this.nomeComboBox);
            this.Controls.Add(contacto_Emergencia_TelemovelLabel);
            this.Controls.Add(this.contacto_Emergencia_TelemovelTextBox);
            this.Controls.Add(contacto_Emergencia_NomeLabel);
            this.Controls.Add(this.contacto_Emergencia_NomeTextBox);
            this.Controls.Add(this.viaturaCheckBox);
            this.Controls.Add(carta_ConducaoLabel);
            this.Controls.Add(this.carta_ConducaoCheckBox);
            this.Controls.Add(iD_FuncaoLabel);
            this.Controls.Add(this.iD_FuncaoComboBox);
            this.Controls.Add(data_InicioLabel);
            this.Controls.Add(this.data_InicioDateTimePicker);
            this.Controls.Add(obs_Label);
            this.Controls.Add(this.obs_TextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telemovelLabel);
            this.Controls.Add(this.telemovelTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_NascimentoLabel);
            this.Controls.Add(this.data_NascimentoDateTimePicker);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoVoluntario";
            this.Text = "NovoVoluntario";
            this.Load += new System.EventHandler(this.NovoVoluntario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AbrigoDataSetTableAdapters.VoluntariosTableAdapter voluntariosTableAdapter1;
        private System.Windows.Forms.BindingSource abrigoDataSetBindingSource;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource funcoesBindingSource;
        private AbrigoDataSetTableAdapters.FuncoesTableAdapter funcoesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource voluntariosBindingSource;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AbrigoDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.DateTimePicker data_NascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox obs_TextBox;
        private System.Windows.Forms.DateTimePicker data_InicioDateTimePicker;
        private System.Windows.Forms.ComboBox iD_FuncaoComboBox;
        private System.Windows.Forms.CheckBox carta_ConducaoCheckBox;
        private System.Windows.Forms.CheckBox viaturaCheckBox;
        private System.Windows.Forms.TextBox contacto_Emergencia_NomeTextBox;
        private System.Windows.Forms.TextBox contacto_Emergencia_TelemovelTextBox;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.CheckBox autorizacao_EncarregadoCheckBox;
    }
}