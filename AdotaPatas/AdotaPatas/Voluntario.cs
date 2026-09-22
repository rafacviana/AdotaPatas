using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdotaPatas
{
    public partial class Voluntario : Form
    {
        public Voluntario()
        {
            InitializeComponent();

            this.tableAdapterManager = new AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager();
        }
        private AdotaPatas.AbrigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        private void Voluntario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.abrigoDataSet.Funcoes);
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.abrigoDataSet.Pessoas);
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Voluntarios'. Você pode movê-la ou removê-la conforme necessário.
            this.voluntariosTableAdapter.Fill(this.abrigoDataSet.Voluntarios);

            if (this.voluntariosBindingSource.Current is DataRowView voluntarioAtual)
            {
                voluntarioAtual["Ativo"] = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voluntariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.abrigoDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Deseja salvar as alterações antes de sair?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Validate();
                    this.voluntariosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (voluntariosBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza de que deseja eliminar este voluntário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    voluntariosBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (NovoVoluntario nvVoluntario = new NovoVoluntario())
            {
                if(nvVoluntario.ShowDialog() == DialogResult.OK)
                {
                    this.abrigoDataSet.EnforceConstraints = false;

                    this.pessoasTableAdapter.Fill(this.abrigoDataSet.Pessoas);

                    this.voluntariosTableAdapter.Fill(this.abrigoDataSet.Voluntarios);

                    this.abrigoDataSet.EnforceConstraints = true;
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                voluntariosBindingSource.Filter = "Ativo = true";
            }
            else
            {
                voluntariosBindingSource.RemoveFilter();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDigitado = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(textoDigitado))
            {
                voluntariosBindingSource.RemoveFilter();
                return;
            }

            string textoProcurado = RemoverAcentos(textoDigitado).ToLower();
            string idsEncontrados = "";

            foreach (DataRow pessoa in abrigoDataSet.Pessoas.Rows)
            {
                if (pessoa.RowState == DataRowState.Deleted)
                    continue;

                bool encontrou = false;

                foreach (DataColumn coluna in abrigoDataSet.Pessoas.Columns)
                {
                    if (pessoa[coluna] != DBNull.Value)
                    {
                        string valorOriginal = pessoa[coluna].ToString();
                        string valorLimpo = RemoverAcentos(valorOriginal).ToLower();

                        if (valorLimpo.Contains(textoProcurado))
                        {
                            encontrou = true;
                            break;
                        }
                    }
                }

                if (encontrou)
                {
                    if (idsEncontrados != "")
                    {
                        idsEncontrados = idsEncontrados + ",";
                    }

                    idsEncontrados = idsEncontrados + pessoa["ID_Pessoas"].ToString();
                }
            }

            foreach (DataRow voluntario in abrigoDataSet.Voluntarios.Rows)
            {
                if (voluntario.RowState == DataRowState.Deleted)
                    continue;

                bool encontrou = false;

                foreach (DataColumn coluna in abrigoDataSet.Voluntarios.Columns)
                {
                    if (voluntario[coluna] != DBNull.Value)
                    {
                        string valorOriginal = voluntario[coluna].ToString();
                        string valorLimpo = RemoverAcentos(valorOriginal).ToLower();

                        if (valorLimpo.Contains(textoProcurado))
                        {
                            encontrou = true;
                            break;
                        }
                    }
                }

                if (encontrou)
                {
                    string idPessoaVoluntario = voluntario["ID_Pessoa"].ToString();

                    if (!idsEncontrados.Contains(idPessoaVoluntario))
                    {
                        if (idsEncontrados != "") { idsEncontrados = idsEncontrados + ",";}

                        idsEncontrados = idsEncontrados + idPessoaVoluntario;
                    }
                }
            }

            if (idsEncontrados != "")
            {
                voluntariosBindingSource.Filter = "ID_Pessoa IN (" + idsEncontrados + ")";
            }
            else
            {
                voluntariosBindingSource.Filter = "ID_Pessoa = -1";
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            texto = texto.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("â", "a").Replace("ä", "a");
            texto = texto.Replace("Á", "a").Replace("À", "a").Replace("Ã", "a").Replace("Â", "a").Replace("Ä", "a");

            texto = texto.Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e");
            texto = texto.Replace("É", "e").Replace("È", "e").Replace("Ê", "e").Replace("Ë", "e");

            texto = texto.Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i");
            texto = texto.Replace("Í", "i").Replace("Ì", "i").Replace("Î", "i").Replace("Ï", "i");

            texto = texto.Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("ô", "o").Replace("ö", "o");
            texto = texto.Replace("Ó", "o").Replace("Ò", "o").Replace("Õ", "o").Replace("Ô", "o").Replace("Ö", "o");

            texto = texto.Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u");
            texto = texto.Replace("Ú", "u").Replace("Ù", "u").Replace("Û", "u").Replace("Ü", "u");

            texto = texto.Replace("ç", "c").Replace("Ç", "c");

            return texto;
        }
    }
}