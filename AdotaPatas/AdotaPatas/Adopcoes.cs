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
    public partial class Adopcoes : Form
    {
        public Adopcoes()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu Menu = this.ParentForm as Menu; 

            if (Menu != null)
            {
                ListarAdotantes listarAdotantes = new ListarAdotantes();
                listarAdotantes.TopLevel = false;
                Menu.panel1.Controls.Clear();
                Menu.panel1.Controls.Add(listarAdotantes);
                listarAdotantes.Dock = DockStyle.Fill;
                listarAdotantes.BringToFront();
                listarAdotantes.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}
