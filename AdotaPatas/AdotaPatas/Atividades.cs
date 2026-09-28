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
            linha.Data = dataDateTimePicker.Value;
            linha.Duracao_min = byte.Parse(txtDuracao.Text);
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
                linha.Data = dataDateTimePicker.Value;
                linha.Duracao_min = byte.Parse(txtDuracao.Text);
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

            dataDateTimePicker.Value = DateTime.Now;

            atividadesDataGridView.ClearSelection();
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
                dataDateTimePicker.Value = linha.Data;
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

        private void atividadesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (atividadesDataGridView.CurrentRow != null)
            {
                txtAtivi.Text = atividadesDataGridView.CurrentRow.Cells["ID_Atividade"].Value.ToString();
                txtAnimal.Text = atividadesDataGridView.CurrentRow.Cells["ID_Animal"].Value.ToString();
                txtPessoa.Text = atividadesDataGridView.CurrentRow.Cells["ID_Pessoa"].Value.ToString();
                txtFuncao.Text = atividadesDataGridView.CurrentRow.Cells["ID_Funcao"].Value.ToString();
                txtDuracao.Text = atividadesDataGridView.CurrentRow.Cells["Duracao_min"].Value.ToString();

                dataDateTimePicker.Value = Convert.ToDateTime(
                    atividadesDataGridView.CurrentRow.Cells["Data"].Value);

                if (atividadesDataGridView.CurrentRow.Cells["Obs"].Value != null)
                {
                    txtObs.Text = atividadesDataGridView.CurrentRow.Cells["Obs"].Value.ToString();
                }
                else
                {
                    txtObs.Text = "";
                }
            }
        }
    }
    }
