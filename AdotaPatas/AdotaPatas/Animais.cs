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
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        private void Animais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abrigoDataSet.Animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.abrigoDataSet.Animais);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            animaisBindingSource.AddNew();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.RemoveCurrent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animaisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
            }
            catch
            {
                MessageBox.Show("Nao foi possivel gravar.\n\n" +
                "- As colunas Especie, Genero, Porte, Condicoes Especiais e Data Entrada sao de preenchimento Obrigatorio.\n", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void animaisDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Os dados introduzidos estao a dar erro. Verifique as seguintes condicoes:\n\n\n"+
                "- As colunas Especie, Genero, Porte, Condicoes Especiais e Data Entrada sao de preenchimento Obrigatorio.\n\n" +
                "- As colunas Peso e Numero Chip apenas aceitam numeros\n\n"+
                "- As colunas Condicoes Especiais e Esteril apenas aceitam os valores de 0 ou 1\n\n", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            animaisBindingSource.Filter = "Nome like '%" + txtProcurar.Text + "%'";
        }
    }
}
