namespace AdotaPatas
{
    partial class CadastrarAdotante
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_NascimentoLabel;
            System.Windows.Forms.Label telemovelLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label bILabel;
            System.Windows.Forms.Label profissaoLabel;
            System.Windows.Forms.Label espaco_EsteriorLabel;
            System.Windows.Forms.Label habitacao_ArrendadaLabel;
            System.Windows.Forms.Label autorizacao_SenhorioLabel;
            System.Windows.Forms.Label n_AgregadosLabel;
            System.Windows.Forms.Label criancasLabel;
            System.Windows.Forms.Label motivo_AdocaoLabel;
            System.Windows.Forms.Label experiencia_PreviaLabel;
            System.Windows.Forms.Label horas_sozinho_diaLabel;
            System.Windows.Forms.Label aceita_AcompanhamentoLabel;
            System.Windows.Forms.Label obs_Label;
            System.Windows.Forms.Label estado_CandidaturaLabel;
            System.Windows.Forms.Label outros_AnimaisLabel;
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.adotanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adotanteTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AdotanteTableAdapter();
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.pessoasTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.PessoasTableAdapter();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.bITextBox = new System.Windows.Forms.TextBox();
            this.profissaoTextBox = new System.Windows.Forms.TextBox();
            this.espaco_EsteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.habitacao_ArrendadaCheckBox = new System.Windows.Forms.CheckBox();
            this.autorizacao_SenhorioCheckBox = new System.Windows.Forms.CheckBox();
            this.criancasCheckBox = new System.Windows.Forms.CheckBox();
            this.motivo_AdocaoTextBox = new System.Windows.Forms.TextBox();
            this.experiencia_PreviaCheckBox = new System.Windows.Forms.CheckBox();
            this.horas_sozinho_diaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.n_AgregadosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aceita_AcompanhamentoCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outros_AnimaisCheckBox = new System.Windows.Forms.CheckBox();
            this.estado_CandidaturaComboBox = new System.Windows.Forms.ComboBox();
            this.obs_TextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            telemovelLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            bILabel = new System.Windows.Forms.Label();
            profissaoLabel = new System.Windows.Forms.Label();
            espaco_EsteriorLabel = new System.Windows.Forms.Label();
            habitacao_ArrendadaLabel = new System.Windows.Forms.Label();
            autorizacao_SenhorioLabel = new System.Windows.Forms.Label();
            n_AgregadosLabel = new System.Windows.Forms.Label();
            criancasLabel = new System.Windows.Forms.Label();
            motivo_AdocaoLabel = new System.Windows.Forms.Label();
            experiencia_PreviaLabel = new System.Windows.Forms.Label();
            horas_sozinho_diaLabel = new System.Windows.Forms.Label();
            aceita_AcompanhamentoLabel = new System.Windows.Forms.Label();
            obs_Label = new System.Windows.Forms.Label();
            estado_CandidaturaLabel = new System.Windows.Forms.Label();
            outros_AnimaisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas_sozinho_diaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_AgregadosNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(28, 44);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 22;
            nomeLabel.Text = "Nome:";
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Location = new System.Drawing.Point(442, 45);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(130, 20);
            data_NascimentoLabel.TabIndex = 23;
            data_NascimentoLabel.Text = "Data Nascimento:";
            // 
            // telemovelLabel
            // 
            telemovelLabel.AutoSize = true;
            telemovelLabel.Location = new System.Drawing.Point(811, 81);
            telemovelLabel.Name = "telemovelLabel";
            telemovelLabel.Size = new System.Drawing.Size(82, 20);
            telemovelLabel.TabIndex = 24;
            telemovelLabel.Text = "Telemóvel:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(444, 81);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 20);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(27, 85);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(67, 20);
            moradaLabel.TabIndex = 26;
            moradaLabel.Text = "Morada:";
            // 
            // bILabel
            // 
            bILabel.AutoSize = true;
            bILabel.Location = new System.Drawing.Point(866, 41);
            bILabel.Name = "bILabel";
            bILabel.Size = new System.Drawing.Size(26, 20);
            bILabel.TabIndex = 27;
            bILabel.Text = "BI:";
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.Location = new System.Drawing.Point(28, 127);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new System.Drawing.Size(75, 20);
            profissaoLabel.TabIndex = 28;
            profissaoLabel.Text = "Profissão:";
            // 
            // espaco_EsteriorLabel
            // 
            espaco_EsteriorLabel.AutoSize = true;
            espaco_EsteriorLabel.Location = new System.Drawing.Point(442, 127);
            espaco_EsteriorLabel.Name = "espaco_EsteriorLabel";
            espaco_EsteriorLabel.Size = new System.Drawing.Size(119, 20);
            espaco_EsteriorLabel.TabIndex = 30;
            espaco_EsteriorLabel.Text = "Espaco Exterior:";
            // 
            // habitacao_ArrendadaLabel
            // 
            habitacao_ArrendadaLabel.AutoSize = true;
            habitacao_ArrendadaLabel.Location = new System.Drawing.Point(601, 127);
            habitacao_ArrendadaLabel.Name = "habitacao_ArrendadaLabel";
            habitacao_ArrendadaLabel.Size = new System.Drawing.Size(159, 20);
            habitacao_ArrendadaLabel.TabIndex = 31;
            habitacao_ArrendadaLabel.Text = "Habitacao Arrendada:";
            // 
            // autorizacao_SenhorioLabel
            // 
            autorizacao_SenhorioLabel.AutoSize = true;
            autorizacao_SenhorioLabel.Location = new System.Drawing.Point(811, 124);
            autorizacao_SenhorioLabel.Name = "autorizacao_SenhorioLabel";
            autorizacao_SenhorioLabel.Size = new System.Drawing.Size(161, 20);
            autorizacao_SenhorioLabel.TabIndex = 32;
            autorizacao_SenhorioLabel.Text = "Autorização Senhorio:";
            // 
            // n_AgregadosLabel
            // 
            n_AgregadosLabel.AutoSize = true;
            n_AgregadosLabel.Location = new System.Drawing.Point(28, 169);
            n_AgregadosLabel.Name = "n_AgregadosLabel";
            n_AgregadosLabel.Size = new System.Drawing.Size(110, 20);
            n_AgregadosLabel.TabIndex = 33;
            n_AgregadosLabel.Text = "Nº Agregados:";
            // 
            // criancasLabel
            // 
            criancasLabel.AutoSize = true;
            criancasLabel.Location = new System.Drawing.Point(217, 170);
            criancasLabel.Name = "criancasLabel";
            criancasLabel.Size = new System.Drawing.Size(70, 20);
            criancasLabel.TabIndex = 34;
            criancasLabel.Text = "Crianças:";
            // 
            // motivo_AdocaoLabel
            // 
            motivo_AdocaoLabel.AutoSize = true;
            motivo_AdocaoLabel.Location = new System.Drawing.Point(442, 217);
            motivo_AdocaoLabel.Name = "motivo_AdocaoLabel";
            motivo_AdocaoLabel.Size = new System.Drawing.Size(139, 20);
            motivo_AdocaoLabel.TabIndex = 35;
            motivo_AdocaoLabel.Text = "Motivo da Adoção:";
            // 
            // experiencia_PreviaLabel
            // 
            experiencia_PreviaLabel.AutoSize = true;
            experiencia_PreviaLabel.Location = new System.Drawing.Point(442, 171);
            experiencia_PreviaLabel.Name = "experiencia_PreviaLabel";
            experiencia_PreviaLabel.Size = new System.Drawing.Size(139, 20);
            experiencia_PreviaLabel.TabIndex = 36;
            experiencia_PreviaLabel.Text = "Experiência Prévia:";
            // 
            // horas_sozinho_diaLabel
            // 
            horas_sozinho_diaLabel.AutoSize = true;
            horas_sozinho_diaLabel.Location = new System.Drawing.Point(623, 171);
            horas_sozinho_diaLabel.Name = "horas_sozinho_diaLabel";
            horas_sozinho_diaLabel.Size = new System.Drawing.Size(163, 20);
            horas_sozinho_diaLabel.TabIndex = 37;
            horas_sozinho_diaLabel.Text = "Horas sozinho por dia:";
            // 
            // aceita_AcompanhamentoLabel
            // 
            aceita_AcompanhamentoLabel.AutoSize = true;
            aceita_AcompanhamentoLabel.Location = new System.Drawing.Point(28, 217);
            aceita_AcompanhamentoLabel.Name = "aceita_AcompanhamentoLabel";
            aceita_AcompanhamentoLabel.Size = new System.Drawing.Size(185, 20);
            aceita_AcompanhamentoLabel.TabIndex = 39;
            aceita_AcompanhamentoLabel.Text = "Aceita Acompanhamento:";
            // 
            // obs_Label
            // 
            obs_Label.AutoSize = true;
            obs_Label.Location = new System.Drawing.Point(28, 256);
            obs_Label.Name = "obs_Label";
            obs_Label.Size = new System.Drawing.Size(39, 20);
            obs_Label.TabIndex = 40;
            obs_Label.Text = "Obs:";
            // 
            // estado_CandidaturaLabel
            // 
            estado_CandidaturaLabel.AutoSize = true;
            estado_CandidaturaLabel.Location = new System.Drawing.Point(435, 260);
            estado_CandidaturaLabel.Name = "estado_CandidaturaLabel";
            estado_CandidaturaLabel.Size = new System.Drawing.Size(146, 20);
            estado_CandidaturaLabel.TabIndex = 41;
            estado_CandidaturaLabel.Text = "Estado Candidatura:";
            // 
            // outros_AnimaisLabel
            // 
            outros_AnimaisLabel.AutoSize = true;
            outros_AnimaisLabel.Location = new System.Drawing.Point(855, 171);
            outros_AnimaisLabel.Name = "outros_AnimaisLabel";
            outros_AnimaisLabel.Size = new System.Drawing.Size(117, 20);
            outros_AnimaisLabel.TabIndex = 42;
            outros_AnimaisLabel.Text = "Outros Animais:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(43, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cadastrar novo Adoptante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adoptante";
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
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.abrigoDataSet;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(87, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(331, 27);
            this.nomeTextBox.TabIndex = 23;
            // 
            // data_NascimentoDateTimePicker
            // 
            this.data_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoasBindingSource, "Data_Nascimento", true));
            this.data_NascimentoDateTimePicker.Location = new System.Drawing.Point(575, 41);
            this.data_NascimentoDateTimePicker.Name = "data_NascimentoDateTimePicker";
            this.data_NascimentoDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.data_NascimentoDateTimePicker.TabIndex = 24;
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Telemovel", true));
            this.telemovelTextBox.Location = new System.Drawing.Point(897, 78);
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(144, 27);
            this.telemovelTextBox.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(499, 78);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 27);
            this.emailTextBox.TabIndex = 26;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(97, 82);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(321, 27);
            this.moradaTextBox.TabIndex = 27;
            // 
            // bITextBox
            // 
            this.bITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource, "BI", true));
            this.bITextBox.Location = new System.Drawing.Point(897, 38);
            this.bITextBox.Name = "bITextBox";
            this.bITextBox.Size = new System.Drawing.Size(144, 27);
            this.bITextBox.TabIndex = 28;
            // 
            // profissaoTextBox
            // 
            this.profissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource, "Profissao", true));
            this.profissaoTextBox.Location = new System.Drawing.Point(107, 123);
            this.profissaoTextBox.Name = "profissaoTextBox";
            this.profissaoTextBox.Size = new System.Drawing.Size(129, 27);
            this.profissaoTextBox.TabIndex = 29;
            // 
            // espaco_EsteriorCheckBox
            // 
            this.espaco_EsteriorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Espaco_Esterior", true));
            this.espaco_EsteriorCheckBox.Location = new System.Drawing.Point(561, 126);
            this.espaco_EsteriorCheckBox.Name = "espaco_EsteriorCheckBox";
            this.espaco_EsteriorCheckBox.Size = new System.Drawing.Size(24, 24);
            this.espaco_EsteriorCheckBox.TabIndex = 31;
            this.espaco_EsteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // habitacao_ArrendadaCheckBox
            // 
            this.habitacao_ArrendadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Habitacao_Arrendada", true));
            this.habitacao_ArrendadaCheckBox.Location = new System.Drawing.Point(762, 126);
            this.habitacao_ArrendadaCheckBox.Name = "habitacao_ArrendadaCheckBox";
            this.habitacao_ArrendadaCheckBox.Size = new System.Drawing.Size(23, 24);
            this.habitacao_ArrendadaCheckBox.TabIndex = 32;
            this.habitacao_ArrendadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // autorizacao_SenhorioCheckBox
            // 
            this.autorizacao_SenhorioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Autorizacao_Senhorio", true));
            this.autorizacao_SenhorioCheckBox.Location = new System.Drawing.Point(972, 123);
            this.autorizacao_SenhorioCheckBox.Name = "autorizacao_SenhorioCheckBox";
            this.autorizacao_SenhorioCheckBox.Size = new System.Drawing.Size(48, 24);
            this.autorizacao_SenhorioCheckBox.TabIndex = 33;
            this.autorizacao_SenhorioCheckBox.UseVisualStyleBackColor = true;
            // 
            // criancasCheckBox
            // 
            this.criancasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Criancas", true));
            this.criancasCheckBox.Location = new System.Drawing.Point(290, 170);
            this.criancasCheckBox.Name = "criancasCheckBox";
            this.criancasCheckBox.Size = new System.Drawing.Size(27, 24);
            this.criancasCheckBox.TabIndex = 35;
            this.criancasCheckBox.UseVisualStyleBackColor = true;
            // 
            // motivo_AdocaoTextBox
            // 
            this.motivo_AdocaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource, "Motivo_Adocao", true));
            this.motivo_AdocaoTextBox.Location = new System.Drawing.Point(584, 214);
            this.motivo_AdocaoTextBox.Name = "motivo_AdocaoTextBox";
            this.motivo_AdocaoTextBox.Size = new System.Drawing.Size(457, 27);
            this.motivo_AdocaoTextBox.TabIndex = 36;
            // 
            // experiencia_PreviaCheckBox
            // 
            this.experiencia_PreviaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Experiencia_Previa", true));
            this.experiencia_PreviaCheckBox.Location = new System.Drawing.Point(580, 169);
            this.experiencia_PreviaCheckBox.Name = "experiencia_PreviaCheckBox";
            this.experiencia_PreviaCheckBox.Size = new System.Drawing.Size(19, 24);
            this.experiencia_PreviaCheckBox.TabIndex = 37;
            this.experiencia_PreviaCheckBox.UseVisualStyleBackColor = true;
            // 
            // horas_sozinho_diaNumericUpDown
            // 
            this.horas_sozinho_diaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.adotanteBindingSource, "Horas_sozinho_dia", true));
            this.horas_sozinho_diaNumericUpDown.Location = new System.Drawing.Point(787, 168);
            this.horas_sozinho_diaNumericUpDown.Name = "horas_sozinho_diaNumericUpDown";
            this.horas_sozinho_diaNumericUpDown.Size = new System.Drawing.Size(55, 27);
            this.horas_sozinho_diaNumericUpDown.TabIndex = 38;
            // 
            // n_AgregadosNumericUpDown
            // 
            this.n_AgregadosNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.adotanteBindingSource, "N_Agregados", true));
            this.n_AgregadosNumericUpDown.Location = new System.Drawing.Point(140, 164);
            this.n_AgregadosNumericUpDown.Name = "n_AgregadosNumericUpDown";
            this.n_AgregadosNumericUpDown.Size = new System.Drawing.Size(54, 27);
            this.n_AgregadosNumericUpDown.TabIndex = 39;
            // 
            // aceita_AcompanhamentoCheckBox
            // 
            this.aceita_AcompanhamentoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Aceita_Acompanhamento", true));
            this.aceita_AcompanhamentoCheckBox.Location = new System.Drawing.Point(215, 217);
            this.aceita_AcompanhamentoCheckBox.Name = "aceita_AcompanhamentoCheckBox";
            this.aceita_AcompanhamentoCheckBox.Size = new System.Drawing.Size(32, 24);
            this.aceita_AcompanhamentoCheckBox.TabIndex = 40;
            this.aceita_AcompanhamentoCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(outros_AnimaisLabel);
            this.groupBox1.Controls.Add(this.outros_AnimaisCheckBox);
            this.groupBox1.Controls.Add(estado_CandidaturaLabel);
            this.groupBox1.Controls.Add(this.estado_CandidaturaComboBox);
            this.groupBox1.Controls.Add(obs_Label);
            this.groupBox1.Controls.Add(this.obs_TextBox);
            this.groupBox1.Controls.Add(aceita_AcompanhamentoLabel);
            this.groupBox1.Controls.Add(this.aceita_AcompanhamentoCheckBox);
            this.groupBox1.Controls.Add(this.n_AgregadosNumericUpDown);
            this.groupBox1.Controls.Add(horas_sozinho_diaLabel);
            this.groupBox1.Controls.Add(this.horas_sozinho_diaNumericUpDown);
            this.groupBox1.Controls.Add(experiencia_PreviaLabel);
            this.groupBox1.Controls.Add(this.experiencia_PreviaCheckBox);
            this.groupBox1.Controls.Add(motivo_AdocaoLabel);
            this.groupBox1.Controls.Add(this.motivo_AdocaoTextBox);
            this.groupBox1.Controls.Add(criancasLabel);
            this.groupBox1.Controls.Add(this.criancasCheckBox);
            this.groupBox1.Controls.Add(n_AgregadosLabel);
            this.groupBox1.Controls.Add(autorizacao_SenhorioLabel);
            this.groupBox1.Controls.Add(this.autorizacao_SenhorioCheckBox);
            this.groupBox1.Controls.Add(habitacao_ArrendadaLabel);
            this.groupBox1.Controls.Add(this.habitacao_ArrendadaCheckBox);
            this.groupBox1.Controls.Add(espaco_EsteriorLabel);
            this.groupBox1.Controls.Add(this.espaco_EsteriorCheckBox);
            this.groupBox1.Controls.Add(profissaoLabel);
            this.groupBox1.Controls.Add(this.profissaoTextBox);
            this.groupBox1.Controls.Add(bILabel);
            this.groupBox1.Controls.Add(this.bITextBox);
            this.groupBox1.Controls.Add(moradaLabel);
            this.groupBox1.Controls.Add(this.moradaTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(telemovelLabel);
            this.groupBox1.Controls.Add(this.telemovelTextBox);
            this.groupBox1.Controls.Add(data_NascimentoLabel);
            this.groupBox1.Controls.Add(this.data_NascimentoDateTimePicker);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 354);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // outros_AnimaisCheckBox
            // 
            this.outros_AnimaisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.adotanteBindingSource, "Outros_Animais", true));
            this.outros_AnimaisCheckBox.Location = new System.Drawing.Point(978, 170);
            this.outros_AnimaisCheckBox.Name = "outros_AnimaisCheckBox";
            this.outros_AnimaisCheckBox.Size = new System.Drawing.Size(104, 24);
            this.outros_AnimaisCheckBox.TabIndex = 43;
            this.outros_AnimaisCheckBox.UseVisualStyleBackColor = true;
            // 
            // estado_CandidaturaComboBox
            // 
            this.estado_CandidaturaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adotanteBindingSource, "Estado_Candidatura", true));
            this.estado_CandidaturaComboBox.FormattingEnabled = true;
            this.estado_CandidaturaComboBox.Items.AddRange(new object[] {
            "Aprovada",
            "Em analise",
            "Recusada"});
            this.estado_CandidaturaComboBox.Location = new System.Drawing.Point(587, 257);
            this.estado_CandidaturaComboBox.Name = "estado_CandidaturaComboBox";
            this.estado_CandidaturaComboBox.Size = new System.Drawing.Size(146, 28);
            this.estado_CandidaturaComboBox.TabIndex = 42;
            // 
            // obs_TextBox
            // 
            this.obs_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Obs", true));
            this.obs_TextBox.Location = new System.Drawing.Point(73, 253);
            this.obs_TextBox.Name = "obs_TextBox";
            this.obs_TextBox.Size = new System.Drawing.Size(345, 27);
            this.obs_TextBox.TabIndex = 41;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(43)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(37, 560);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 40);
            this.button6.TabIndex = 42;
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
            this.btnNovo.Location = new System.Drawing.Point(941, 558);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(188, 42);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "Salvar";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CadastrarAdotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1169, 631);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastrarAdotante";
            this.Load += new System.EventHandler(this.CadastrarAdotante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adotanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas_sozinho_diaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_AgregadosNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource adotanteBindingSource;
        private AbrigoDataSetTableAdapters.AdotanteTableAdapter adotanteTableAdapter;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AbrigoDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_NascimentoDateTimePicker;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox bITextBox;
        private System.Windows.Forms.TextBox profissaoTextBox;
        private System.Windows.Forms.CheckBox espaco_EsteriorCheckBox;
        private System.Windows.Forms.CheckBox habitacao_ArrendadaCheckBox;
        private System.Windows.Forms.CheckBox autorizacao_SenhorioCheckBox;
        private System.Windows.Forms.CheckBox criancasCheckBox;
        private System.Windows.Forms.TextBox motivo_AdocaoTextBox;
        private System.Windows.Forms.CheckBox experiencia_PreviaCheckBox;
        private System.Windows.Forms.NumericUpDown horas_sozinho_diaNumericUpDown;
        private System.Windows.Forms.NumericUpDown n_AgregadosNumericUpDown;
        private System.Windows.Forms.CheckBox aceita_AcompanhamentoCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox obs_TextBox;
        private System.Windows.Forms.ComboBox estado_CandidaturaComboBox;
        private System.Windows.Forms.CheckBox outros_AnimaisCheckBox;
    }
}