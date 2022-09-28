using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class removePokemon : UserControl
    {
        public removePokemon()
        {
            InitializeComponent();
        }

        private void removePokemon_Load(object sender, EventArgs e)
        {

        }

        private void remove_Visable(object sender, EventArgs e)
        {
            removeImg.ImageLocation = scollerSceen.imagePath;
        }

        private void deletePokemon_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeletePokemon(scollerSceen.pokemon[scollerSceen.i]);
        }
    }
}
