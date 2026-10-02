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
    public partial class ListarAdocoes : Form
    {
        public ListarAdocoes()
        {
            InitializeComponent();
        }

        private void ListarAdocoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.abrigoDataSet.Animais);
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.abrigoDataSet.Pessoas);
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Adocao'. Você pode movê-la ou removê-la conforme necessário.
            this.adocaoTableAdapter.Fill(this.abrigoDataSet.Adocao);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Atenção: Ao ativar o modo de edição, qualquer alteração feita será gravada permanentemente na base de dados. Desejas continuar?",
                "Aviso de Edição Permanente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                dataGridView1.ReadOnly = false;

                if (dataGridView1.Columns["ID"] != null)
                {
                    dataGridView1.Columns["ID"].ReadOnly = true;
                }
                if (dataGridView1.Columns["ID_Animal"] != null)
                {
                    dataGridView1.Columns["ID_Animal"].ReadOnly = true;
                }
                if (dataGridView1.Columns["ID_Pessoa"] != null)
                {
                    dataGridView1.Columns["ID_Pessoa"].ReadOnly = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.adocaoBindingSource.EndEdit();

                this.adocaoTableAdapter.Update(this.abrigoDataSet.Adocao);

                MessageBox.Show("Alterações guardadas com sucesso na base de dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar as alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.abrigoDataSet.HasChanges())
            {
                DialogResult resposta = MessageBox.Show(
                    "Tens alterações não guardadas. Se saíres agora, vais perder as modificações. Desejas sair sem guardar?",
                    "Alterações Pendentes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resposta == DialogResult.No)
                {
                    return;
                }
            }


            Menu Menu = this.ParentForm as Menu;

            if (Menu != null)
            {
                MenuAdocoes MenuAdocoes = new MenuAdocoes();
                MenuAdocoes.TopLevel = false;
                Menu.panel1.Controls.Clear();
                Menu.panel1.Controls.Add(MenuAdocoes);
                MenuAdocoes.Dock = DockStyle.Fill;
                MenuAdocoes.BringToFront();
                MenuAdocoes.Show();
            }

            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, selecione uma adoção para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem a certeza que pretende eliminar esta adoção? O animal associado voltará a ficar disponível na lista.",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataRowView linhaAtual = adocaoBindingSource.Current as DataRowView;

                    if (linhaAtual != null)
                    {
                        int idAnimalAdotado = Convert.ToInt32(linhaAtual["ID_Animal"]);

                        adocaoBindingSource.RemoveCurrent();
                        this.Validate();
                        this.adocaoTableAdapter.Update(this.abrigoDataSet.Adocao);

                        AdotaPatas.AbrigoDataSetTableAdapters.AnimaisTableAdapter tempAnimaisAdapter = new AdotaPatas.AbrigoDataSetTableAdapters.AnimaisTableAdapter();
                        tempAnimaisAdapter.Fill(this.abrigoDataSet.Animais);

                        var animalRow = this.abrigoDataSet.Animais.FirstOrDefault(a => a.ID_Animal == idAnimalAdotado); 
                        if (animalRow != null)
                        {
                            animalRow["Disponivel"] = true;
                            tempAnimaisAdapter.Update(this.abrigoDataSet.Animais);
                        }

                        MessageBox.Show("Adoção eliminada com sucesso! O animal voltou a ficar disponível.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar a adoção:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.adocaoTableAdapter.Fill(this.abrigoDataSet.Adocao);
                }
            }
        }
    }
}
