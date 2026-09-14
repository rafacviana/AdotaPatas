namespace AdotaPatas
{
    partial class Animais
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label obsLabel;
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abrigoDataSet = new AdotaPatas.AbrigoDataSet();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AnimaisTableAdapter();
            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.descricaoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.obsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.atividadesTableAdapter1 = new AdotaPatas.AbrigoDataSetTableAdapters.AtividadesTableAdapter();
            descricaoLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(24, 497);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(77, 20);
            descricaoLabel.TabIndex = 21;
            descricaoLabel.Text = "Descricao:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(605, 497);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(38, 20);
            obsLabel.TabIndex = 22;
            obsLabel.Text = "Obs:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(37, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Visao geral dos Animais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Animais";
            // 
            // abrigoDataSet
            // 
            this.abrigoDataSet.DataSetName = "AbrigoDataSet";
            this.abrigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "Animais";
            this.animaisBindingSource.DataSource = this.abrigoDataSet;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdocaoTableAdapter = null;
            this.tableAdapterManager.AdotanteTableAdapter = null;
            this.tableAdapterManager.AnimaisTableAdapter = this.animaisTableAdapter;
            this.tableAdapterManager.AtividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumiveisTableAdapter = null;
            this.tableAdapterManager.FuncoesTableAdapter = null;
            this.tableAdapterManager.PessoasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            this.tableAdapterManager.VoluntariosTableAdapter = null;
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AllowUserToAddRows = false;
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn1});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.Location = new System.Drawing.Point(12, 151);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.RowHeadersVisible = false;
            this.animaisDataGridView.Size = new System.Drawing.Size(1082, 322);
            this.animaisDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Especie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Especie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Porte";
            this.dataGridViewTextBoxColumn5.HeaderText = "Porte";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn6.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Idade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Condicoes_Especiais";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Condicoes_Especiais";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Esteril";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Esteril";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Numero_Chip";
            this.dataGridViewTextBoxColumn8.HeaderText = "Numero_Chip";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Data_Entrada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data_Entrada";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Foto";
            this.dataGridViewImageColumn1.HeaderText = "Foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(343, 86);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 42);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo Animal";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(501, 86);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 42);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(595, 86);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // descricaoRichTextBox
            // 
            this.descricaoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "Descricao", true));
            this.descricaoRichTextBox.Location = new System.Drawing.Point(107, 494);
            this.descricaoRichTextBox.Name = "descricaoRichTextBox";
            this.descricaoRichTextBox.Size = new System.Drawing.Size(352, 96);
            this.descricaoRichTextBox.TabIndex = 22;
            this.descricaoRichTextBox.Text = "";
            // 
            // obsRichTextBox
            // 
            this.obsRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "Obs", true));
            this.obsRichTextBox.Location = new System.Drawing.Point(649, 494);
            this.obsRichTextBox.Name = "obsRichTextBox";
            this.obsRichTextBox.Size = new System.Drawing.Size(382, 96);
            this.obsRichTextBox.TabIndex = 23;
            this.obsRichTextBox.Text = "";
            // 
            // atividadesTableAdapter1
            // 
            this.atividadesTableAdapter1.ClearBeforeFill = true;
            // 
            // Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1106, 631);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsRichTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoRichTextBox);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.animaisDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1106, 631);
            this.MinimumSize = new System.Drawing.Size(1106, 631);
            this.Name = "Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Animais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abrigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private AbrigoDataSet abrigoDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private AbrigoDataSetTableAdapters.AnimaisTableAdapter animaisTableAdapter;
        private AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox descricaoRichTextBox;
        private System.Windows.Forms.RichTextBox obsRichTextBox;
        private AbrigoDataSetTableAdapters.AtividadesTableAdapter atividadesTableAdapter1;
    }
}