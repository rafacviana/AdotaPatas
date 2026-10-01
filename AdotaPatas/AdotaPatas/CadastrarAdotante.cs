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
    public partial class CadastrarAdotante : Form
    {
         int idAdotanteSalvo = -1;

        public CadastrarAdotante()
        {
            InitializeComponent();
        }

        private void CadastrarAdotante_Load(object sender, EventArgs e)
        {
            try
            {
                this.adotanteTableAdapter.Fill(this.abrigoDataSet.Adotante);
                this.pessoasTableAdapter.Fill(this.abrigoDataSet.Pessoas);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os adotantes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
 

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
                {
                    MessageBox.Show("O campo 'Nome' é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nomeTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(bITextBox.Text) || bITextBox.Text.Length < 8)
                {
                    MessageBox.Show("Insira um número de BI/Cartão de Cidadão válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bITextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(telemovelTextBox.Text) || telemovelTextBox.Text.Length != 9 || !telemovelTextBox.Text.StartsWith("9"))
                {
                    MessageBox.Show("O telemóvel tem de ter exatamente 9 dígitos e começar por '9'.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    telemovelTextBox.Focus();
                    return;
                }

                bool apenasNumeros = true;
                foreach (char c in telemovelTextBox.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        apenasNumeros = false;
                        break;
                    }
                }

                if (!apenasNumeros)
                {
                    MessageBox.Show("O telemóvel deve conter apenas números.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    telemovelTextBox.Focus();
                    return;
                }

                long telemovelInt = Convert.ToInt64(telemovelTextBox.Text);

                if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
                {
                    MessageBox.Show("O email inserido não é válido. Deve conter '@' e '.'.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Focus();
                    return;
                }

                DateTime dataNascimento = data_NascimentoDateTimePicker.Value;
                int idade = DateTime.Today.Year - dataNascimento.Year;
                if (dataNascimento.Date > DateTime.Today.AddYears(-idade))
                {
                    idade--;
                }

                if (idade < 18)
                {
                    MessageBox.Show("O adotante tem de ter pelo menos 18 anos de idade.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    data_NascimentoDateTimePicker.Focus();
                    return;
                }

                this.Validate();

                DataRowView pessoasRow = (DataRowView)this.pessoasBindingSource.Current;
                DataRowView adotanteRow = (DataRowView)this.adotanteBindingSource.Current;

                pessoasRow["Telemovel"] = telemovelInt;
                pessoasRow["Obs:"] = obs_TextBox.Text;

                adotanteRow["Espaco_Esterior"] = espaco_EsteriorCheckBox.Checked;
                adotanteRow["Habitacao_Arrendada"] = habitacao_ArrendadaCheckBox.Checked;
                adotanteRow["Autorizacao_Senhorio"] = autorizacao_SenhorioCheckBox.Checked;
                adotanteRow["Criancas"] = criancasCheckBox.Checked;
                adotanteRow["Experiencia_Previa"] = experiencia_PreviaCheckBox.Checked;
                adotanteRow["Aceita_Acompanhamento"] = aceita_AcompanhamentoCheckBox.Checked;
                adotanteRow["N_Agregados"] = (int)n_AgregadosNumericUpDown.Value;
                adotanteRow["Horas_sozinho_dia"] = (int)horas_sozinho_diaNumericUpDown.Value;
                adotanteRow["Estado_Candidatura"] = estado_CandidaturaComboBox.Text;
                adotanteRow["Data_Candidatura"] = DateTime.Now;
                adotanteRow["ID_Habitacao"] = 1;

                this.pessoasBindingSource.EndEdit();
                this.adotanteBindingSource.EndEdit();

                this.pessoasTableAdapter.Update(this.abrigoDataSet.Pessoas);

                int idPessoaGerado = 0;
                using (var cmd = new System.Data.SqlClient.SqlCommand("SELECT IDENT_CURRENT('Pessoas')", this.pessoasTableAdapter.Connection))
                {
                    if (this.pessoasTableAdapter.Connection.State != ConnectionState.Open)
                    {
                        this.pessoasTableAdapter.Connection.Open();
                    }
                    idPessoaGerado = Convert.ToInt32(cmd.ExecuteScalar());
                }

                adotanteRow.BeginEdit();
                adotanteRow["ID_Pessoa"] = idPessoaGerado;
                adotanteRow.EndEdit();

                this.adotanteBindingSource.EndEdit();
                this.adotanteTableAdapter.Update(this.abrigoDataSet.Adotante);

                idAdotanteSalvo = Convert.ToInt32(adotanteRow["ID_Pessoa"]);
                MessageBox.Show("Adotante registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();
        }

        private void LimparCampos()
        {
            this.pessoasBindingSource.AddNew();
            this.adotanteBindingSource.AddNew();

            nomeTextBox.Clear();
            bITextBox.Clear();
            moradaTextBox.Clear();
            telemovelTextBox.Clear();
            emailTextBox.Clear();
            obs_TextBox.Clear();
            motivo_AdocaoTextBox.Clear();
            n_AgregadosNumericUpDown.Value = 0;
            horas_sozinho_diaNumericUpDown.Value = 0;
            espaco_EsteriorCheckBox.Checked = false;
            habitacao_ArrendadaCheckBox.Checked = false;
            autorizacao_SenhorioCheckBox.Checked = false;
            criancasCheckBox.Checked = false;
            outros_AnimaisCheckBox.Checked = false;
            experiencia_PreviaCheckBox.Checked = false;
            aceita_AcompanhamentoCheckBox.Checked = false;

            DataRowView adotanteRowInit = (DataRowView)this.adotanteBindingSource.Current;
            adotanteRowInit["ID_Pessoa"] = -1;
            adotanteRowInit["Espaco_Esterior"] = false;
            adotanteRowInit["Habitacao_Arrendada"] = false;
            adotanteRowInit["Autorizacao_Senhorio"] = false;
            adotanteRowInit["Criancas"] = false;
            adotanteRowInit["Outros_Animais"] = false;
            adotanteRowInit["Experiencia_Previa"] = false;
            adotanteRowInit["Aceita_Acompanhamento"] = false;
            adotanteRowInit["N_Agregados"] = 0;
            adotanteRowInit["Horas_sozinho_dia"] = 0;
            adotanteRowInit["ID_Habitacao"] = 1;
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
    }
}
