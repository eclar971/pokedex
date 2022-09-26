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
    public partial class seenScreen : UserControl
    {
        string UIwhereSeen = "";
        string UIisShiny = "";
        string UIwhenSeen = "";
        public seenScreen()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seenScreen_Load(object sender, EventArgs e)
        {

        }
        private void seenScreen_Visble(object sender, EventArgs e)
        {
            seenPokemonPic.ImageLocation = scollerSceen.imagePath;
        }

        private void whereSeen__TextChanged(object sender, EventArgs e)
        {
            UIwhereSeen = whereSeen.Texts;
        }

        private void isShinnySeen__TextChanged(object sender, EventArgs e)
        {
            UIisShiny = isShinnySeen.Texts;
        }

        private void whenSeen__TextChanged(object sender, EventArgs e)
        {
            UIwhenSeen = whenSeen.Texts;
        }

        private void saveSeen_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.when = UIwhenSeen;
            data.where = UIwhereSeen;
            data.shiny = UIisShiny;
            data.pokemon = scollerSceen.pokemon[scollerSceen.i].Name;
            SqliteDataAccess.SaveUserData(data);
            var userDataTable = SqliteDataAccess.LoadUserData();
        }
    }
}
