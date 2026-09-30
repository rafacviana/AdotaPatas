using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdotaPatas
{
    public partial class ListarAdotantes : Form
    {
      


        public int idAdotanteSelecionado = -1;

        public ListarAdotantes(bool modoSelecao)
        {
            InitializeComponent();
            btnSelecionarAnimal.Visible = modoSelecao;

            if (modoSelecao == false)
            {
                label1.Text = "Adoptantes";
            }
            else
            {
                label1.Text = "Registrar Adopção";
                label9.Text = "Selecione um adoptante";
            }

        }

        private void ListarAdotantes_Load(object sender, EventArgs e)
        {

            try
            {
                this.abrigoDataSet.EnforceConstraints = false;
                this.adotanteTableAdapter.FillComPessoas(this.abrigoDataSet.Adotante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os adotantes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                DataRowView linha = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

                if (linha != null)
                {
                    if (linha.Row.Table.Columns.Contains("ID_Pessoa") && linha["ID_Pessoa"] != DBNull.Value)
                    {
                        idAdotanteSelecionado = Convert.ToInt32(linha["ID_Pessoa"]);
                    }
                    else if (linha.Row.Table.Columns.Contains("ID_Pessoas") && linha["ID_Pessoas"] != DBNull.Value)
                    {
                        idAdotanteSelecionado = Convert.ToInt32(linha["ID_Pessoas"]);
                    }
                    horas_sozinho_diaTextBox.Text = linha["Horas_sozinho_dia"]?.ToString() ?? "";
                    n_AgregadosTextBox.Text = linha["N_Agregados"]?.ToString() ?? "";
                    estado_CandidaturaTextBox.Text = linha["Estado_Candidatura"]?.ToString() ?? "";
                    motivo_RecusaTextBox.Text = linha["Motivo_Recusa"]?.ToString() ?? "";

                    if (linha["Outros_Animais"] != DBNull.Value)
                        outros_AnimaisCheckBox.Checked = Convert.ToBoolean(linha["Outros_Animais"]);
                    else
                        outros_AnimaisCheckBox.Checked = false;

                    if (linha["Criancas"] != DBNull.Value)
                        criancasCheckBox.Checked = Convert.ToBoolean(linha["Criancas"]);
                    else
                        criancasCheckBox.Checked = false;

                    if (linha["Espaco_Esterior"] != DBNull.Value)
                        espaco_EsteriorCheckBox.Checked = Convert.ToBoolean(linha["Espaco_Esterior"]);
                    else
                        espaco_EsteriorCheckBox.Checked = false;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    adotanteBindingSource.Filter = string.Format("Nome LIKE '%{0}%' OR Morada LIKE '%{0}%' OR CONVERT(Telemovel, 'System.String') LIKE '%{0}%' OR Email LIKE '%{0}%'", textBox1.Text);
                }
                else
                {
                    adotanteBindingSource.Filter = string.Empty;
                }
            }
            catch (Exception ex)
            {
                adotanteBindingSource.Filter = string.Empty;
            }
        }


        private void fillComPessoasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.adotanteTableAdapter.FillComPessoas(this.abrigoDataSet.Adotante);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu Menu = this.ParentForm as Menu;

            if (Menu != null)
            {
                MenuAdotantes menuAdoptantes = new MenuAdotantes();
                menuAdoptantes.TopLevel = false;
                Menu.panel1.Controls.Clear();
                Menu.panel1.Controls.Add(menuAdoptantes);
                menuAdoptantes.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idAdotanteSelecionado == -1)
            {
                MessageBox.Show("Por favor, selecione um adotante da lista antes de avançar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.adotanteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                Animais animais = new Animais();    //(idAdotanteSelecionado);

                this.Hide();
                animais.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao avançar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idAdotanteSelecionado == -1 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um adotante para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem a certeza de que deseja eliminar este adotante?", "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    this.adotanteBindingSource.RemoveCurrent();

                    this.adotanteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                    MessageBox.Show("Adotante eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao eliminar o adotante: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                    this.adotanteTableAdapter.FillComPessoas(this.abrigoDataSet.Adotante);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                this.abrigoDataSet.EnforceConstraints = false;
                this.adotanteTableAdapter.FillComPessoas(this.abrigoDataSet.Adotante);

                dataGridView1.ReadOnly = false;

                if (dataGridView1.Columns["ID_Pessoa"] != null)
                    dataGridView1.Columns["ID_Pessoa"].ReadOnly = true;
                if (dataGridView1.Columns["ID_Pessoas"] != null)
                    dataGridView1.Columns["ID_Pessoas"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os adotantes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
