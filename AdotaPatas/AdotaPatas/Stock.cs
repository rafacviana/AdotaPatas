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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();

            txtId.DataBindings.Clear();
            txtNome.DataBindings.Clear();
            txtEspecie.DataBindings.Clear();
            txtTamanho.DataBindings.Clear();
            txtCategoria.DataBindings.Clear();
            txtQuantidade.DataBindings.Clear();
            txtObser.DataBindings.Clear();
            data_ValidadeDateTimePicker.DataBindings.Clear();
            txtPesqui.DataBindings.Clear();

            consumiveisDataGridView.SelectionChanged += consumiveisDataGridView_SelectionChanged;
            consumiveisDataGridView.CellClick += consumiveisDataGridView_CellClick;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                consumiveisDataGridView.ClearSelection();

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o stock:\n\n" + ex.Message);
            }
        }

        private void consumiveisDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            PreencherPelaLinhaSelecionada();
        }

        private void consumiveisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                consumiveisDataGridView.Rows[e.RowIndex].Selected = true;
                PreencherPelaLinhaSelecionada();
            }
        }

        private void PreencherPelaLinhaSelecionada()
        {
            if (consumiveisDataGridView.CurrentRow == null)
                return;

            if (consumiveisDataGridView.CurrentRow.IsNewRow)
                return;

            object item = consumiveisDataGridView.CurrentRow.DataBoundItem;

            if (item == null)
                return;

            DataRowView dataRowView = item as DataRowView;

            if (dataRowView == null)
                return;

            DataRow row = dataRowView.Row;

            if (row.IsNull("ID"))
                return;

            txtId.Text = row["ID"].ToString();

            if (!row.IsNull("Nome"))
                txtNome.Text = row["Nome"].ToString();
            else
                txtNome.Text = "";

            if (!row.IsNull("Especie_Animal"))
                txtEspecie.Text = row["Especie_Animal"].ToString();
            else
                txtEspecie.Text = "";

            if (!row.IsNull("Tamanho"))
                txtTamanho.Text = row["Tamanho"].ToString();
            else
                txtTamanho.Text = "";

            if (!row.IsNull("Categoria"))
                txtCategoria.Text = row["Categoria"].ToString();
            else
                txtCategoria.Text = "";

            if (!row.IsNull("Quantidade"))
                txtQuantidade.Text = row["Quantidade"].ToString();
            else
                txtQuantidade.Text = "";

            if (!row.IsNull("Data_Validade"))
            {
                data_ValidadeDateTimePicker.Value =
                    Convert.ToDateTime(row["Data_Validade"]);
            }

            if (row.Table.Columns.Contains("Obs") && !row.IsNull("Obs"))
                txtObser.Text = row["Obs"].ToString();
            else
                txtObser.Text = "";
        }

        private void consumiveisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                consumiveisBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(abrigoDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar:\n\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtTamanho.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            try
            {
                AbrigoDataSet.ConsumiveisRow linha =
                    abrigoDataSet.Consumiveis.NewConsumiveisRow();

                linha.Nome = txtNome.Text;
                linha.Especie_Animal = txtEspecie.Text;
                linha.Tamanho = txtTamanho.Text;
                linha.Categoria = txtCategoria.Text;
                linha.Quantidade = txtQuantidade.Text;
                linha.Data_Validade = data_ValidadeDateTimePicker.Value;

                if (string.IsNullOrWhiteSpace(txtObser.Text))
                    linha.SetObsNull();
                else
                    linha.Obs = txtObser.Text;

                abrigoDataSet.Consumiveis.AddConsumiveisRow(linha);

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível adicionado com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar:\n\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                AbrigoDataSet.ConsumiveisRow linha =
                    abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.");
                    return;
                }

                linha.Nome = txtNome.Text;
                linha.Especie_Animal = txtEspecie.Text;
                linha.Tamanho = txtTamanho.Text;
                linha.Categoria = txtCategoria.Text;
                linha.Quantidade = txtQuantidade.Text;
                linha.Data_Validade = data_ValidadeDateTimePicker.Value;

                if (string.IsNullOrWhiteSpace(txtObser.Text))
                    linha.SetObsNull();
                else
                    linha.Obs = txtObser.Text;

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar:\n\n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                AbrigoDataSet.ConsumiveisRow linha =
                    abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.");
                    return;
                }

                linha.Delete();

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível eliminado com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar:\n\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqui.Text))
            {
                MessageBox.Show("Introduza o ID do consumível.");
                return;
            }

            int id;

            if (!int.TryParse(txtPesqui.Text, out id))
            {
                MessageBox.Show("Introduza um ID válido.");
                return;
            }

            try
            {
                AbrigoDataSet.ConsumiveisRow linha =
                    abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.");
                    return;
                }

                txtId.Text = linha.ID.ToString();
                txtNome.Text = linha.Nome;
                txtEspecie.Text = linha.Especie_Animal;
                txtTamanho.Text = linha.Tamanho;
                txtCategoria.Text = linha.Categoria;
                txtQuantidade.Text = linha.Quantidade.ToString();

                if (!linha.IsData_ValidadeNull())
                    data_ValidadeDateTimePicker.Value = linha.Data_Validade;

                if (linha.IsObsNull())
                    txtObser.Text = "";
                else
                    txtObser.Text = linha.Obs;

                foreach (DataGridViewRow row in consumiveisDataGridView.Rows)
                {
                    if (row.DataBoundItem is DataRowView dataRowView)
                    {
                        if (dataRowView.Row["ID"] != DBNull.Value &&
                            Convert.ToInt32(dataRowView.Row["ID"]) == id)
                        {
                            row.Selected = true;
                            consumiveisDataGridView.CurrentCell = row.Cells[0];
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

        private void button5_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEspecie.Text = "";
            txtTamanho.Text = "";
            txtCategoria.Text = "";
            txtQuantidade.Text = "";
            txtObser.Text = "";
            txtPesqui.Text = "";

            data_ValidadeDateTimePicker.Value = DateTime.Now;

            consumiveisDataGridView.ClearSelection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consumiveisDataGridView_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PreencherPelaLinhaSelecionada();
            }
        }

        private void txtPesqui_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqui.Text))
            {
                consumiveisDataGridView.ClearSelection();
            }
        }
    }
}