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
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);
        }

        private void consumiveisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consumiveisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" ||
                txtEspecie.Text == "" ||
                txtTamanho.Text == "" ||
                txtCategoria.Text == "" ||
                txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }
           

            AbrigoDataSet.ConsumiveisRow linha;

            linha = abrigoDataSet.Consumiveis.NewConsumiveisRow();

            linha.Nome = txtNome.Text;
            linha.Especie_Animal = txtEspecie.Text;
            linha.Tamanho = txtTamanho.Text;
            linha.Categoria = txtCategoria.Text;
            linha.Quantidade = txtQuantidade.Text;
            linha.Data_Validade = data_ValidadeDateTimePicker.Value;
            linha.Obs = txtObser.Text;

            abrigoDataSet.Consumiveis.AddConsumiveisRow(linha);

            consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
            consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

            MessageBox.Show("Consumível adicionado com sucesso!");

            LimparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            AbrigoDataSet.ConsumiveisRow linha;

            linha = abrigoDataSet.Consumiveis.FindByID(id);

            if (linha != null)
            {
                linha.Nome = txtNome.Text;
                linha.Especie_Animal = txtEspecie.Text;
                linha.Tamanho = txtTamanho.Text;
                linha.Categoria = txtCategoria.Text;
                linha.Quantidade = txtQuantidade.Text;
                linha.Data_Validade = data_ValidadeDateTimePicker.Value;
                linha.Obs = txtObser.Text;

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Consumível não encontrado.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            AbrigoDataSet.ConsumiveisRow linha;

            linha = abrigoDataSet.Consumiveis.FindByID(id);

            if (linha != null)
            {
                linha.Delete();

                consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);
                consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

                MessageBox.Show("Consumível eliminado com sucesso!");

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Consumível não encontrado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPesqui.Text == "")
            {
                consumiveisBindingSource.RemoveFilter();
                return;
            }

            int id;

            if (!int.TryParse(txtPesqui.Text, out id))
            {
                MessageBox.Show("Introduza um ID válido.");
                return;
            }

            AbrigoDataSet.ConsumiveisRow linha =
                abrigoDataSet.Consumiveis.FindByID(id);

            if (linha != null)
            {
                txtId.Text = linha.ID.ToString();
                txtNome.Text = linha.Nome;
                txtEspecie.Text = linha.Especie_Animal;
                txtTamanho.Text = linha.Tamanho;
                txtCategoria.Text = linha.Categoria;
                txtQuantidade.Text = linha.Quantidade.ToString();
                data_ValidadeDateTimePicker.Value = linha.Data_Validade;

                if (linha.IsObsNull())
                {
                    txtObser.Text = "";
                }
                else
                {
                    txtObser.Text = linha.Obs;
                }

                consumiveisBindingSource.Filter = "ID = " + id;
            }
            else
            {
                MessageBox.Show("Consumível não encontrado.");
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

            consumiveisBindingSource.RemoveFilter();

            consumiveisDataGridView.ClearSelection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu
            menu.Show();
            this.Close();
        }

        private void consumiveisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consumiveisDataGridView.CurrentRow != null)
            {
                txtId.Text = consumiveisDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                txtNome.Text = consumiveisDataGridView.CurrentRow.Cells["Nome"].Value.ToString();
                txtEspecie.Text = consumiveisDataGridView.CurrentRow.Cells["Especie_Animal"].Value.ToString();
                txtTamanho.Text = consumiveisDataGridView.CurrentRow.Cells["Tamanho"].Value.ToString();
                txtCategoria.Text = consumiveisDataGridView.CurrentRow.Cells["Categoria"].Value.ToString();
                txtQuantidade.Text = consumiveisDataGridView.CurrentRow.Cells["Quantidade"].Value.ToString();

                if (consumiveisDataGridView.CurrentRow.Cells["Data_Validade"].Value != null)
                {
                    data_ValidadeDateTimePicker.Value = Convert.ToDateTime(
                        consumiveisDataGridView.CurrentRow.Cells["Data_Validade"].Value);
                }

                if (consumiveisDataGridView.CurrentRow.Cells["Obs"].Value != null)
                {
                    txtObser.Text = consumiveisDataGridView.CurrentRow.Cells["Obs"].Value.ToString();
                }
                else
                {
                    txtObser.Text = "";
                }
            }
        }

        private void txtPesqui_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesqui.Text))
            {
                consumiveisBindingSource.RemoveFilter();
                consumiveisBindingSource.Position = -1;
                consumiveisDataGridView.ClearSelection();
            }
        }
    }
}