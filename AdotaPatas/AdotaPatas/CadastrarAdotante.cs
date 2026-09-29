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

                this.pessoasBindingSource.AddNew();
                this.adotanteBindingSource.AddNew();

                n_AgregadosNumericUpDown.Value = 0;
                horas_sozinho_diaNumericUpDown.Value = 0;
                espaco_EsteriorCheckBox.Checked = false;
                habitacao_ArrendadaCheckBox.Checked = false;
                autorizacao_SenhorioCheckBox.Checked = false;
                criancasCheckBox.Checked = false;
                experiencia_PreviaCheckBox.Checked = false;
                aceita_AcompanhamentoCheckBox.Checked = false;

                if (cmbHabitacao.Items.Count > 0)
                    cmbHabitacao.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os adotantes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adotanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adotanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void adotanteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pessoasBindingSource.EndEdit();
                this.adotanteBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

                DataRowView adotanteRow = (DataRowView)this.adotanteBindingSource.Current;
                idAdotanteSalvo = Convert.ToInt32(adotanteRow["ID_Adotante"]);

                MessageBox.Show("Adotante salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
