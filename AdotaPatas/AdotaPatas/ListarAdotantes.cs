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
        private string conexaoString = @"Server=RAFA-NOTE\SQLEXPRESS;Database=Abrigo;Trusted_Connection=True;";
        //lembrem de colocarem o caminho da vossa BD. 

        public int idAdotanteSelecionado = -1;

        public ListarAdotantes()
        {
            InitializeComponent();
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
            this.Close();
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
    }
}
