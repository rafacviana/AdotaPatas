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
            Voluntarios.Show();
            Voluntarios.TopLevel = false;
            panel1.Controls.Clear();
            //Voluntarios.Dock = DockStyle.Fill;
            panel1.Controls.Add(Voluntarios);

            Voluntarios.BringToFront();
           
        }
    }
}
