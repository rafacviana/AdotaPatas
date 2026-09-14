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
           NovoVoluntario nvVonluntario = new NovoVoluntario();
            nvVonluntario.TopLevel = true;
            nvVonluntario.ShowDialog();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                voluntariosBindingSource.Filter = "Ativo = true";
            }
            else
            {
                voluntariosBindingSource.RemoveFilter();
            }
        }
    }
}
