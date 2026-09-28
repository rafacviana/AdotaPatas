using System;
using System.Windows.Forms;
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
    public partial class Atividades : Form
    {
        public Atividades()
        {
            InitializeComponent();

            txtAtivi.DataBindings.Clear();
            txtAnimal.DataBindings.Clear();
            txtPessoa.DataBindings.Clear();
            txtFuncao.DataBindings.Clear();
            txtDuracao.DataBindings.Clear();
            txtObs.DataBindings.Clear();
            dataDateTimePicker.DataBindings.Clear();

            atividadesDataGridView.SelectionChanged += atividadesDataGridView_SelectionChanged;
            atividadesDataGridView.CellClick += atividadesDataGridView_CellClick;
        }

        private void Atividades_Load(object sender, EventArgs e)
        {
            try
            {
                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);
                atividadesDataGridView.ClearSelection();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as atividades:\n\n" + ex.Message);
            }
        }

        private void atividadesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PreencherPelaLinhaSelecionada();
        }

        private void atividadesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                atividadesDataGridView.Rows[e.RowIndex].Selected = true;
                PreencherPelaLinhaSelecionada();
            }
        }

        private void PreencherPelaLinhaSelecionada()
        {
            if (atividadesDataGridView.CurrentRow == null)
                return;

            if (atividadesDataGridView.CurrentRow.IsNewRow)
                return;

            object item = atividadesDataGridView.CurrentRow.DataBoundItem;

            if (item == null)
                return;

            DataRowView dataRowView = item as DataRowView;

            if (dataRowView == null)
                return;

            DataRow row = dataRowView.Row;

            if (row.IsNull("ID_Atividade"))
                return;

            txtAtivi.Text = row["ID_Atividade"].ToString();
            txtAnimal.Text = row["ID_Animal"].ToString();
            txtPessoa.Text = row["ID_Pessoa"].ToString();
            txtFuncao.Text = row["ID_Funcao"].ToString();

            if (!row.IsNull("Data"))
            {
                dataDateTimePicker.Value =
                    Convert.ToDateTime(row["Data"]);
            }

            txtDuracao.Text = row["Duracao_min"].ToString();

            if (row.Table.Columns.Contains("Obs") && !row.IsNull("Obs"))
            {
                txtObs.Text = row["Obs"].ToString();
            }
            else
            {
                txtObs.Text = "";
            }
        }

        private void atividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                atividadesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(abrigoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar:\n\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnimal.Text) ||
                string.IsNullOrWhiteSpace(txtPessoa.Text) ||
                string.IsNullOrWhiteSpace(txtFuncao.Text) ||
                string.IsNullOrWhiteSpace(txtDuracao.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            int idAnimal;
            int idPessoa;
            int idFuncao;
            byte duracao;

            if (!int.TryParse(txtAnimal.Text, out idAnimal))
            {
                MessageBox.Show("O ID do animal deve ser numérico.");
                return;
            }

            if (!int.TryParse(txtPessoa.Text, out idPessoa))
            {
                MessageBox.Show("O ID da pessoa deve ser numérico.");
                return;
            }

            if (!int.TryParse(txtFuncao.Text, out idFuncao))
            {
                MessageBox.Show("O ID da função deve ser numérico.");
                return;
            }

            if (!byte.TryParse(txtDuracao.Text, out duracao))
            {
                MessageBox.Show("A duração deve ser numérica.");
                return;
            }

            try
            {
                AbrigoDataSet.AtividadesRow linha =
                    abrigoDataSet.Atividades.NewAtividadesRow();

                linha.ID_Animal = idAnimal;
                linha.ID_Pessoa = idPessoa;
                linha.ID_Funcao = idFuncao;
                linha.Data = dataDateTimePicker.Value;
                linha.Duracao_min = duracao;

                if (string.IsNullOrWhiteSpace(txtObs.Text))
                    linha.SetObsNull();
                else
                    linha.Obs = txtObs.Text;

                abrigoDataSet.Atividades.AddAtividadesRow(linha);

                atividadesTableAdapter.Update(abrigoDataSet.Atividades);
                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

                MessageBox.Show("Atividade adicionada com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar:\n\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAtivi.Text))
            {
                MessageBox.Show("Selecione uma atividade.");
                return;
            }

            int id;

            if (!int.TryParse(txtAtivi.Text, out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                AbrigoDataSet.AtividadesRow linha =
                    abrigoDataSet.Atividades.FindByID_Atividade(id);

                if (linha == null)
                {
                    MessageBox.Show("Atividade não encontrada.");
                    return;
                }

                linha.ID_Animal = Convert.ToInt32(txtAnimal.Text);
                linha.ID_Pessoa = Convert.ToInt32(txtPessoa.Text);
                linha.ID_Funcao = Convert.ToInt32(txtFuncao.Text);
                linha.Data = dataDateTimePicker.Value;
                linha.Duracao_min = Convert.ToByte(txtDuracao.Text);

                if (string.IsNullOrWhiteSpace(txtObs.Text))
                    linha.SetObsNull();
                else
                    linha.Obs = txtObs.Text;

                atividadesTableAdapter.Update(abrigoDataSet.Atividades);
                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

                MessageBox.Show("Atividade alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar:\n\n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAtivi.Text))
            {
                MessageBox.Show("Selecione uma atividade.");
                return;
            }

            int id;

            if (!int.TryParse(txtAtivi.Text, out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                AbrigoDataSet.AtividadesRow linha =
                    abrigoDataSet.Atividades.FindByID_Atividade(id);

                if (linha == null)
                {
                    MessageBox.Show("Atividade não encontrada.");
                    return;
                }

                linha.Delete();

                atividadesTableAdapter.Update(abrigoDataSet.Atividades);
                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

                MessageBox.Show("Atividade eliminada com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar:\n\n" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtAtivi.Text = "";
            txtAnimal.Text = "";
            txtPessoa.Text = "";
            txtFuncao.Text = "";
            txtDuracao.Text = "";
            txtObs.Text = "";
            txtPesq.Text = "";

            dataDateTimePicker.Value = DateTime.Now;

            atividadesDataGridView.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesq.Text))
            {
                MessageBox.Show("Introduza o ID da atividade.");
                return;
            }

            int id;

            if (!int.TryParse(txtPesq.Text, out id))
            {
                MessageBox.Show("Introduza um ID válido.");
                return;
            }

            try
            {
                AbrigoDataSet.AtividadesRow linha =
                    abrigoDataSet.Atividades.FindByID_Atividade(id);

                if (linha == null)
                {
                    MessageBox.Show("Atividade não encontrada.");
                    return;
                }

                txtAtivi.Text = linha.ID_Atividade.ToString();
                txtAnimal.Text = linha.ID_Animal.ToString();
                txtPessoa.Text = linha.ID_Pessoa.ToString();
                txtFuncao.Text = linha.ID_Funcao.ToString();
                dataDateTimePicker.Value = linha.Data;
                txtDuracao.Text = linha.Duracao_min.ToString();

                if (linha.IsObsNull())
                    txtObs.Text = "";
                else
                    txtObs.Text = linha.Obs;

                foreach (DataGridViewRow row in atividadesDataGridView.Rows)
                {
                    if (row.DataBoundItem is DataRowView dataRowView)
                    {
                        if (dataRowView.Row["ID_Atividade"] != DBNull.Value &&
                            Convert.ToInt32(dataRowView.Row["ID_Atividade"]) == id)
                        {
                            row.Selected = true;
                            atividadesDataGridView.CurrentCell =
                                row.Cells[0];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa:\n\n" + ex.Message);
            }
        }

        private void atividadesDataGridView_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PreencherPelaLinhaSelecionada();
            }
        }
    }
}