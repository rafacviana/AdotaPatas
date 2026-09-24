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
        }

        private void Atividades_Load(object sender, EventArgs e)
        {
            atividadesTableAdapter.Fill(abrigoDataSet.Atividades);
        }

        private void atividadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atividadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtAtivi.Text = dataGridView1.CurrentRow.Cells["ID_Atividade"].Value.ToString();
                txtAnimal.Text = dataGridView1.CurrentRow.Cells["ID_Animal"].Value.ToString();
                txtPessoa.Text = dataGridView1.CurrentRow.Cells["ID_Pessoa"].Value.ToString();
                txtFuncao.Text = dataGridView1.CurrentRow.Cells["ID_Funcao"].Value.ToString();
                txtDuracao.Text = dataGridView1.CurrentRow.Cells["Duracao_min"].Value.ToString();

                dateTimePickerData.Value = Convert.ToDateTime(
                    dataGridView1.CurrentRow.Cells["Data"].Value);

                if (dataGridView1.CurrentRow.Cells["Obs"].Value != null)
                {
                    txtObs.Text = dataGridView1.CurrentRow.Cells["Obs"].Value.ToString();
                }
                else
                {
                    txtObs.Text = "";
                }
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAnimal.Text == "" ||
                txtPessoa.Text == "" ||
                txtFuncao.Text == "" ||
                txtDuracao.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            AbrigoDataSet.AtividadesRow linha;

            linha = abrigoDataSet.Atividades.NewAtividadesRow();

            linha.ID_Animal = Convert.ToInt32(txtAnimal.Text);
            linha.ID_Pessoa = Convert.ToInt32(txtPessoa.Text);
            linha.ID_Funcao = Convert.ToInt32(txtFuncao.Text);
            linha.Data = dateTimePickerData.Value;
            linha.Duracao_min = Convert.ToInt32(txtDuracao.Text);
            linha.Obs = txtObs.Text;

            abrigoDataSet.Atividades.AddAtividadesRow(linha);
            atividadesTableAdapter.Update(abrigoDataSet.Atividades);
            atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

            MessageBox.Show("Atividade adicionada com sucesso!");

            LimparCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAtivi.Text == "")
            {
                MessageBox.Show("Selecione uma atividade.");
                return;
            }

            int id = Convert.ToInt32(txtAtivi.Text);

            AbrigoDataSet.AtividadesRow linha;

            linha = abrigoDataSet.Atividades.FindByID_Atividade(id);

            if (linha != null)
            {
                linha.ID_Animal = Convert.ToInt32(txtAnimal.Text);
                linha.ID_Pessoa = Convert.ToInt32(txtPessoa.Text);
                linha.ID_Funcao = Convert.ToInt32(txtFuncao.Text);
                linha.Data = dateTimePickerData.Value;
                linha.Duracao_min = Convert.ToInt32(txtDuracao.Text);
                linha.Obs = txtObs.Text;

                atividadesTableAdapter.Update(abrigoDataSet.Atividades);

                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

                MessageBox.Show("Atividade alterada com sucesso!");
            }
            else
            {
                MessageBox.Show("Atividade não encontrada.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAtivi.Text == "")
            {
                MessageBox.Show("Selecione uma atividade.");
                return;
            }

            int id = Convert.ToInt32(txtAtivi.Text);

            AbrigoDataSet.AtividadesRow linha;

            linha = abrigoDataSet.Atividades.FindByID_Atividade(id);

            if (linha != null)
            {
                linha.Delete();
                atividadesTableAdapter.Update(abrigoDataSet.Atividades);
                atividadesTableAdapter.Fill(abrigoDataSet.Atividades);

                MessageBox.Show("Atividade eliminada com sucesso!");

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Atividade não encontrada.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPesq.Text == "")
            {
                MessageBox.Show("Introduza o ID da atividade.");
                return;
            }

            int id = Convert.ToInt32(txtPesq.Text);

            AbrigoDataSet.AtividadesRow linha;

            linha = abrigoDataSet.Atividades.FindByID_Atividade(id);

            if (linha != null)
            {
                txtAtivi.Text = linha.ID_Atividade.ToString();
                txtAnimal.Text = linha.ID_Animal.ToString();
                txtPessoa.Text = linha.ID_Pessoa.ToString();
                txtFuncao.Text = linha.ID_Funcao.ToString();
                dateTimePickerData.Value = linha.Data;
                txtDuracao.Text = linha.Duracao_min.ToString();

                if (linha.IsObsNull())
                {
                    txtObs.Text = "";
                }
                else
                {
                    txtObs.Text = linha.Obs;
                }

                MessageBox.Show("Atividade encontrada!");
            }
            else
            {
                MessageBox.Show("Atividade não encontrada.");
            }
        }
    }
    }
}
