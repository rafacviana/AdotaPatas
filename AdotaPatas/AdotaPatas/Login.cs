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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = utilizadoresBindingSource.Find("Utilizador", txtUtil.Text);

            if (posicao != -1)
            {
                utilizadoresBindingSource.Position = posicao;

                DataRowView linha = (DataRowView)utilizadoresBindingSource.Current;

                if (linha["Password"].ToString() == txtPasse.Text)
                {
                    MessageBox.Show("Login efetuado com sucesso!");

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Utilizador não existe!");
            }
            
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'abrigoDataSet.Utilizadores'. Você pode movê-la ou removê-la conforme necessário.
            this.utilizadoresTableAdapter.Fill(this.abrigoDataSet.Utilizadores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar regista = new Registrar();
            regista.Show();
        }
    }
}
