using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdotaPatas
{
    public partial class Animais : Form
    {
        private int idAdotante = -1;
        private int idAnimal = -1;

        public Animais( int idAdotanteSelecionado = -1)
        {
            InitializeComponent();
            
            idAdotante = idAdotanteSelecionado;

            if (idAdotante != -1)
            {
                button1.Visible = true; 
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void Animais_Load(object sender, EventArgs e)
        {
            try
            {
                this.animaisTableAdapter.Fill(this.abrigoDataSet.Animais);

                AdotaPatas.AbrigoDataSetTableAdapters.AdocaoTableAdapter tempAdocaoAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AdocaoTableAdapter();
                tempAdocaoAdapter.Fill(this.abrigoDataSet.Adocao);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAlteracoes();
        }

        private void GuardarAlteracoes()
        {
            try
            {
                this.Validate();
                this.animaisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                MessageBox.Show("Alterações guardadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar as alterações:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (animaisDataGridView.CurrentRow == null || animaisDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, selecione um animal válido para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem a certeza que pretende eliminar este animal?", "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    animaisBindingSource.RemoveCurrent();

                    this.Validate();
                    this.animaisBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                    MessageBox.Show("Animal eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar o animal:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                animaisBindingSource.AddNew();

                animaisDataGridView.Focus();
                if (animaisDataGridView.CurrentRow != null)
                {
                    animaisDataGridView.CurrentCell = animaisDataGridView.CurrentRow.Cells[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar novo registo:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void animaisDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (animaisDataGridView.CurrentRow != null && animaisDataGridView.CurrentRow.Index < animaisDataGridView.Rows.Count - 1)
            {
                DataRowView linha = animaisDataGridView.CurrentRow.DataBoundItem as DataRowView;

                if (linha != null)
                {
                    if (linha.Row.Table.Columns.Contains("ID_Animal") && linha["ID_Animal"] != DBNull.Value)
                    {
                        idAnimal = Convert.ToInt32(linha["ID_Animal"]);  
                    }
                    else if (linha.Row.Table.Columns.Contains("ID") && linha["ID"] != DBNull.Value)
                    {
                        idAnimal = Convert.ToInt32(linha["ID"]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idAnimal == -1)
            {
                MessageBox.Show("Por favor, selecione um animal da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idAdotante == -1)
            {
                MessageBox.Show("Erro: Nenhum adotante associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                AdotaPatas.AbrigoDataSet.AdocaoRow novaAdocao = abrigoDataSet.Adocao.NewAdocaoRow();

                novaAdocao.ID_Animal = idAnimal;
                novaAdocao.ID_Pessoa = idAdotante; 
                novaAdocao.Atividade = "Registo de Adoção";
                novaAdocao.Data = DateTime.Now;
                novaAdocao.Descricao = "Animal adotado com sucesso.";   

                abrigoDataSet.Adocao.Rows.Add(novaAdocao);

                if (animaisBindingSource.Current is DataRowView linhaAtual)
                {
                    linhaAtual["Obs"] = false;
                }

                this.Validate();
                this.animaisBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                MessageBox.Show("Adoção registada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar a adoção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarAdocoes ListarAdocoes = new ListarAdocoes();
            ListarAdocoes.TopLevel = false;
            Menu Menu = this.ParentForm as Menu;
             
        }

        
    }
}
