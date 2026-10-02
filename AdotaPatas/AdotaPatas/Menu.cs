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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            Animais animais = new Animais();
            animais.Show();

            animais.TopLevel = false;
            panel1.Controls.Add(animais);

            animais.BringToFront();
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            Voluntario Voluntarios = new Voluntario();
            Voluntarios.TopLevel = false;
            panel1.Controls.Clear();
            //Voluntarios.Dock = DockStyle.Fill;
            panel1.Controls.Add(Voluntarios);

            Voluntarios.BringToFront();
            Voluntarios.Show();

        }

        private void btnAdopcoes_Click(object sender, EventArgs e)
        {
            MenuAdocoes MenuAdocoes = new MenuAdocoes();
            MenuAdocoes.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(MenuAdocoes);
            MenuAdocoes.Dock = DockStyle.Fill;
            MenuAdocoes.BringToFront();
            MenuAdocoes.Show();


        }

        private void btnDefinicoes_Click_1(object sender, EventArgs e)
        {
            MenuAdotantes menuAdoptantes = new MenuAdotantes();
            menuAdoptantes.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(menuAdoptantes);
            menuAdoptantes.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(stock);
            stock.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            Atividades ativity = new Atividades();
            ativity.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(ativity);
            ativity.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
