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
        private bool carregando = true;
        public Stock()
        {
            InitializeComponent();

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

        private void LimparCampos()
        {
            carregando = true;
            txtNome.Text = "";
            txtEspecie.Text = "";
            txtTamanho.Text = "";
            txtCategoria.Text = "";
            txtQuantidade.Text = "";
            txtObser.Text = "";
            txtPesqui.Text = "";

            data_ValidadeDateTimePicker.Value = DateTime.Now;

            if (consumiveisBindingSource != null)
            {
                consumiveisBindingSource.Position = -1;
            }

            consumiveisDataGridView.ClearSelection();
            carregando = false;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                carregando = true; 
                txtNome.DataBindings.Clear();
                txtEspecie.DataBindings.Clear();
                txtTamanho.DataBindings.Clear();
                txtCategoria.DataBindings.Clear();
                txtQuantidade.DataBindings.Clear();
                txtObser.DataBindings.Clear();
                data_ValidadeDateTimePicker.DataBindings.Clear();

                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                consumiveisDataGridView.ClearSelection();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o stock:\n\n" + ex.Message);
            }
            finally
            {
                carregando = false; 
            }
        }

        private void consumiveisDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carregando) return; 
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
            if (carregando) return;

            if (consumiveisDataGridView.CurrentRow == null || consumiveisDataGridView.CurrentRow.IsNewRow)
                return;

            object item = consumiveisDataGridView.CurrentRow.DataBoundItem;
            if (item == null) return;

            DataRowView dataRowView = item as DataRowView;
            if (dataRowView == null) return;

            DataRow row = dataRowView.Row;

            txtNome.Text = !row.IsNull("Nome") ? row["Nome"].ToString() : "";
            txtEspecie.Text = !row.IsNull("Especie_Animal") ? row["Especie_Animal"].ToString() : "";
            txtTamanho.Text = !row.IsNull("Tamanho") ? row["Tamanho"].ToString() : "";
            txtCategoria.Text = !row.IsNull("Categoria") ? row["Categoria"].ToString() : "";
            txtQuantidade.Text = !row.IsNull("Quantidade") ? row["Quantidade"].ToString() : "";

            if (!row.IsNull("Data_Validade"))
            {
                data_ValidadeDateTimePicker.Value = Convert.ToDateTime(row["Data_Validade"]);
            }

            txtObser.Text = (row.Table.Columns.Contains("Obs") && !row.IsNull("Obs")) ? row["Obs"].ToString() : "";
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
            if (consumiveisDataGridView.CurrentRow == null || consumiveisDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um consumível na tabela para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(consumiveisDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
                AbrigoDataSet.ConsumiveisRow linha = abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Consumível alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (consumiveisDataGridView.CurrentRow == null || consumiveisDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um consumível na tabela para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtTamanho.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(consumiveisDataGridView.CurrentRow.Cells["ID"].Value);

                AbrigoDataSet.ConsumiveisRow linha = abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Consumível alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (consumiveisDataGridView.CurrentRow == null || consumiveisDataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um consumível na tabela para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(consumiveisDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
                AbrigoDataSet.ConsumiveisRow linha = abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                linha.Delete();

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqui.Text))
            {
                MessageBox.Show("Introduza o ID do consumível.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(txtPesqui.Text, out id))
            {
                MessageBox.Show("Introduza um ID válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AbrigoDataSet.ConsumiveisRow linha = abrigoDataSet.Consumiveis.FindByID(id);

                if (linha == null)
                {
                    MessageBox.Show("Consumível não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtNome.Text = linha.Nome;
                txtEspecie.Text = linha.Especie_Animal;
                txtTamanho.Text = linha.Tamanho;
                txtCategoria.Text = linha.Categoria;
                txtQuantidade.Text = linha.Quantidade.ToString();

                if (!linha.IsData_ValidadeNull())
                    data_ValidadeDateTimePicker.Value = linha.Data_Validade;

                txtObser.Text = linha.IsObsNull() ? "" : linha.Obs;

                foreach (DataGridViewRow row in consumiveisDataGridView.Rows)
                {
                    if (row.DataBoundItem is DataRowView dataRowView)
                    {
                        if (dataRowView.Row["ID"] != DBNull.Value &&
                            Convert.ToInt32(dataRowView.Row["ID"]) == id)
                        {
                            row.Selected = true;
                            consumiveisDataGridView.CurrentCell = row.Cells[1];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consumiveisDataGridView_CellContentClick(object sender,DataGridViewCellEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}