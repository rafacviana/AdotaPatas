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
                string utilizadorIntroduzido = txtUtil.Text.Trim();
                string passwordIntroduzida = txtPasse.Text;

                if (utilizadorIntroduzido == "")
                {
                    MessageBox.Show("Introduza o utilizador.");
                    return;
                }

                if (passwordIntroduzida == "")
                {
                    MessageBox.Show("Introduza a password.");
                    return;
                }

                AbrigoDataSet.UtilizadoresDataTable tabelaUtilizadores =
                    new AbrigoDataSet.UtilizadoresDataTable();

                utilizadoresTableAdapter.Fill(tabelaUtilizadores);

                bool loginValido = false;

                foreach (AbrigoDataSet.UtilizadoresRow linha in tabelaUtilizadores.Rows)
                {
                    string utilizadorBD = linha.Utilizador.Trim();
                    string passwordBD = linha.Password;

                    if (utilizadorBD == utilizadorIntroduzido &&
                        passwordBD == passwordIntroduzida)
                    {
                        loginValido = true;
                        break;
                    }
                }

                if (!loginValido)
                {
                    MessageBox.Show("Utilizador ou password incorretos.");
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
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Não foi possível abrir o registo.");
            }
        }
    }
}