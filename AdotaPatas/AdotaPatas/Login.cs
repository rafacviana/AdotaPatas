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
            try
            {
                if (txtUtilizador.Text == "")
                {
                    MessageBox.Show("Introduza o utilizador.");
                    return;
                }

                if (txtPass.Text == "")
                {
                    MessageBox.Show("Introduza a password.");
                    return;
                }

                int existe = (int)this.utilizadoresTableAdapter.VerificarUser(txtUtilizador.Text);
                int pass = (int)this.utilizadoresTableAdapter.VerificarPass(txtUtilizador.Text, txtPass.Text);

                if (existe > 0)
                {
                    if (pass > 0)
                    {
                        Menu menu = new Menu(txtUtilizador.Text);
                        menu.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("A password nao esta correta");
                        txtPass.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("O utilizador nao se encontra registado!");
                    txtUtilizador.Text = "";
                    txtPass.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao tentar iniciar sessão.");
            }
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.utilizadoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.abrigoDataSet);
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao guardar os dados.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                this.utilizadoresTableAdapter.Fill(this.abrigoDataSet.Utilizadores);
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar os utilizadores.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar regista = new Registrar();
                regista.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possível abrir o registo.");
            }
        }
    }
}