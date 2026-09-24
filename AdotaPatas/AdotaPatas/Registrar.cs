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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Utilizadores'. Você pode movê-la ou removê-la conforme necessário.
            //this.utilizadoresTableAdapter.Fill(this.abrigoDataSet.Utilizadores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.abrigoDataSet.Utilizadores.AddUtilizadoresRow(
        txtUser.Text,
        txtPass.Text,
        txtNome.Text
    );

            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

            MessageBox.Show("Guardado");
        }
    }
}
