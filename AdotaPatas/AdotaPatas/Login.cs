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
                if (txtUtil.Text == "")
                {
                    MessageBox.Show("Introduza o utilizador.");
                    return;
                }

                if (txtPasse.Text == "")
                {
                    MessageBox.Show("Introduza a password.");
                    return;
                }

                bool utilizadorExiste = false;
                bool passwordCorreta = false;

                foreach (DataRow linha in abrigoDataSet.Utilizadores.Rows)
                {
                    string utilizador = linha["Utilizador"].ToString();
                    string password = linha["Password"].ToString();

                    if (utilizador == txtUtil.Text)
                    {
                        utilizadorExiste = true;

                        if (password == txtPasse.Text)
                        {
                            passwordCorreta = true;
                        }

                        break;
                    }
                }

                if (!utilizadorExiste)
                {
                    MessageBox.Show("O utilizador nao se encontra registado!");
                    txtUtil.Text = "";
                    txtPasse.Text = "";
                    return;
                }

                if (!passwordCorreta)
                {
                    MessageBox.Show("A password nao esta correta");
                    txtPasse.Text = "";
                    return;
                }

                Menu menu = new Menu();
                menu.Show(this);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar iniciar sessão: " + ex.Message);
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