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
    public partial class NovoVoluntario : Form
    {
        public NovoVoluntario()
        {
            InitializeComponent();
        }

        private void NovoVoluntario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.abrigoDataSet.Pessoas);
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.abrigoDataSet.Funcoes);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voluntariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void contacto_Emergencia_NomeLabel_Click(object sender, EventArgs e)
        {

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
            else
            {
                this.Close();
            }
        }
    }
}
