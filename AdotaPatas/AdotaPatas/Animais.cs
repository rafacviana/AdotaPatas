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

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abrigoDataSet);

        }

        private void Animais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abrigoDataSet.Animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.abrigoDataSet.Animais);

        }
    }
}
