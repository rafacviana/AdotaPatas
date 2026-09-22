using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdotaPatas
{
    public partial class NovoVoluntario : Form
    {
        public NovoVoluntario()
        {
            InitializeComponent();
        }

        private void NovoVoluntario_Load(object sender, EventArgs e)
        {
            try
            {
                this.funcoesTableAdapter.Fill(this.abrigoDataSet.Funcoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as funções: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PrepararRegisto();
        }

        private void PrepararRegisto()
        {
            this.pessoasBindingSource.CancelEdit();
            this.voluntariosBindingSource.CancelEdit();
            this.abrigoDataSet.RejectChanges();

            this.pessoasBindingSource.AddNew();
            DataRowView novoVoluntario = (DataRowView)this.voluntariosBindingSource.AddNew();

            if (novoVoluntario != null)
            {
                novoVoluntario["Ativo"] = true;
                novoVoluntario["Data_Inicio"] = DateTime.Now;

                if (nomeComboBox.SelectedValue != null)
                {
                    novoVoluntario["ID_Funcao"] = nomeComboBox.SelectedValue;
                    idTextBox.Text = nomeComboBox.SelectedValue.ToString();
                }
            }

            this.ativoCheckBox.Checked = true;
        }

        private bool ValidarTelemovel()
        {
            string telemovel = telemovelTextBox.Text.Trim();

            if (string.IsNullOrEmpty(telemovel))
            {
                MessageBox.Show("Por favor, preencha o número de telemóvel.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telemovelTextBox.Select();
                return false;
            }

            if (telemovel.Length != 9 || !telemovel.StartsWith("9") || !telemovel.All(char.IsDigit))
            {
                MessageBox.Show("O número de telemóvel deve ter exatamente 9 dígitos e começar pelo número 9.", "Telemóvel Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telemovelTextBox.Select();
                return false;
            }
            return true;
        }

        private bool ValidarEmail()
        {
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha o endereço de email.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Select();
                return false;
            }

            try
            {
                var enderecoMail = new System.Net.Mail.MailAddress(email);

                if (enderecoMail.Address != email)
                {
                    MessageBox.Show("Por favor, insira um endereço de email válido.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Select();
                    return false;
                }

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um endereço de email válido.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Select();
                return false;
            }
        }
        private void AtualizarVoluntarioEmMemoria()
        {
            if (voluntariosBindingSource.Current is DataRowView voluntarioAtual)
            {
                voluntarioAtual["Ativo"] = ativoCheckBox.Checked;
                voluntarioAtual["Carta_Conducao"] = carta_ConducaoCheckBox.Checked;
                voluntarioAtual["Viatura"] = viaturaCheckBox.Checked;
                voluntarioAtual["Autorizacao_Encarregado"] = autorizacao_EncarregadoCheckBox.Checked;
                voluntarioAtual["Data_Inicio"] = data_InicioDateTimePicker.Value;
                if (nomeComboBox.SelectedValue != null)
                {
                    voluntarioAtual["ID_Funcao"] = nomeComboBox.SelectedValue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarTelemovel() || !ValidarEmail())
                return;

            try
            {
                this.Validate();

                var novaPessoa = this.abrigoDataSet.Pessoas.NewPessoasRow();

                novaPessoa.Nome = nomeTextBox.Text.Trim();
                novaPessoa.Data_Nascimento = data_NascimentoDateTimePicker.Value;

                if (!string.IsNullOrEmpty(moradaTextBox.Text))
                    novaPessoa.Morada = moradaTextBox.Text;
                if (!string.IsNullOrWhiteSpace(telemovelTextBox.Text))
                    novaPessoa.Telemovel = Convert.ToInt32(telemovelTextBox.Text.Trim());

                novaPessoa.Email = emailTextBox.Text.Trim();
                novaPessoa._Obs_ = obs_TextBox.Text;

                this.abrigoDataSet.Pessoas.AddPessoasRow(novaPessoa);

                this.pessoasTableAdapter.Update(this.abrigoDataSet.Pessoas);

                var novoVoluntario = this.abrigoDataSet.Voluntarios.NewVoluntariosRow();

                novoVoluntario.ID_Pessoa = novaPessoa.ID_Pessoas;
                novoVoluntario.Data_Inicio = data_InicioDateTimePicker.Value;
                novoVoluntario.Ativo = ativoCheckBox.Checked;

                if (nomeComboBox.SelectedValue != null)
                {
                    novoVoluntario.ID_Funcao = Convert.ToInt32(nomeComboBox.SelectedValue);
                }

                novoVoluntario.Carta_Conducao = carta_ConducaoCheckBox.Checked;
                novoVoluntario.Viatura = viaturaCheckBox.Checked;
                novoVoluntario.Contacto_Emergencia_Nome = contacto_Emergencia_NomeTextBox.Text.Trim();

                if (!string.IsNullOrWhiteSpace(contacto_Emergencia_TelemovelTextBox.Text))
                    novoVoluntario.Contacto_Emergencia_Telemovel = Convert.ToInt32(contacto_Emergencia_TelemovelTextBox.Text.Trim());

                novoVoluntario.Autorizacao_Encarregado = autorizacao_EncarregadoCheckBox.Checked;


                this.abrigoDataSet.Voluntarios.AddVoluntariosRow(novoVoluntario);

                if (this.tableAdapterManager != null)
                {
                    this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
                }
                else
                {
                    this.pessoasTableAdapter.Update(this.abrigoDataSet);
                }

                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
                MessageBox.Show("Voluntário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro de Gravação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            }        

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.abrigoDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Deseja salvar as alterações antes de sair?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!ValidarTelemovel() || !ValidarEmail())
                        return;
                    try
                    {
                        AtualizarVoluntarioEmMemoria();
                        this.Validate();
                        this.pessoasBindingSource.EndEdit();
                        this.voluntariosBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (this.abrigoDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Existem dados não salvos. Deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!ValidarTelemovel() || !ValidarEmail())
                        return;

                    try
                    {
                        AtualizarVoluntarioEmMemoria();
                        this.Validate();
                        this.pessoasBindingSource.EndEdit();
                        this.voluntariosBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                        PrepararRegisto();
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.voluntariosBindingSource.CancelEdit();
                    this.pessoasBindingSource.CancelEdit();
                    this.abrigoDataSet.RejectChanges();

                    PrepararRegisto();
                }
            }
            else
            {
                PrepararRegisto();
            }
        }

        private void nomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(nomeComboBox.SelectedValue != null)
            {    
                idTextBox.Text = nomeComboBox.SelectedValue.ToString();

                if (voluntariosBindingSource.Current is DataRowView linhaAtual)
                {
                    linhaAtual["ID_Funcao"] = nomeComboBox.SelectedValue;
                }
            }
        }
    }
}