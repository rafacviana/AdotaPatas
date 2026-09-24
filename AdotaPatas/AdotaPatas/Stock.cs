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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                txtEspecie.Text = dataGridView1.CurrentRow.Cells["Especie_Animal"].Value.ToString();
                txtTamanho.Text = dataGridView1.CurrentRow.Cells["Tamanho"].Value.ToString();
                txtCategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                txtQuantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();

                if (dataGridView1.CurrentRow.Cells["Data_Validade"].Value != null)
                {
                    dateTimePickerValidade.Value = Convert.ToDateTime(
                        dataGridView1.CurrentRow.Cells["Data_Validade"].Value);
                }

                if (dataGridView1.CurrentRow.Cells["Obs"].Value != null)
                {
                    txtObser.Text = dataGridView1.CurrentRow.Cells["Obs"].Value.ToString();
                }
                else
                {
                    txtObser.Text = "";
                }
            }
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
            linha.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            linha.Data_Validade = dateTimePickerValidade.Value;
            linha.Obs = txtObser.Text;

            abrigoDataSet.Consumiveis.AddConsumiveisRow(linha);

            consumiveisTableAdapter.Update(abrigoDataSet.Consumiveis);

            consumiveisTableAdapter.Fill(abrigoDataSet.Consumiveis);

            MessageBox.Show("Consumível adicionado com sucesso!");

            LimparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")

            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);

            AbrigoDataSet.ConsumiveisRow linha;

            linha = abrigoDataSet.Consumiveis.FindByID(id);

            if (linha != null)

            {

                linha.Nome = txtNome.Text;
                linha.Especie_Animal = txtEspecie.Text;
                linha.Tamanho = txtTamanho.Text;
                linha.Categoria = txtCategoria.Text;
                linha.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                linha.Data_Validade = dateTimePickerValidade.Value;
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
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um consumível.");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);

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
                MessageBox.Show("Introduza o ID do consumível.");
                return;
            }

            int id = Convert.ToInt32(txtPesqui.Text);

            AbrigoDataSet.ConsumiveisRow linha;

            linha = abrigoDataSet.Consumiveis.FindByID(id);

            if (linha != null)

            {
                txtID.Text = linha.ID.ToString();
                txtNome.Text = linha.Nome;
                txtEspecie.Text = linha.Especie_Animal;
                txtTamanho.Text = linha.Tamanho;
                txtCategoria.Text = linha.Categoria;
                txtQuantidade.Text = linha.Quantidade.ToString();
                dateTimePickerValidade.Value = linha.Data_Validade;

                if (linha.IsObsNull())
                {
                    txtObser.Text = "";
                }
                else
                {
                    txtObser.Text = linha.Obs;
                }

                MessageBox.Show("Consumível encontrado!");
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
            txtAtivi.Text = "";
            txtAnimal.Text = "";
            txtPessoa.Text = "";
            txtFuncao.Text = "";
            txtDuracao.Text = "";
            txtObs.Text = "";
            txtPesq.Text = "";

            dateTimePickerData.Value = DateTime.Now;

            dataGridView1.ClearSelection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
