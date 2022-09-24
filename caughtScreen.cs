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
    public partial class caughtScreen : UserControl
    {
        string UIcaughtNickname = "";
        string UIwhereCaught = "";
        string UIisShiny = "";
        string UIwhenCaught = "";
        public caughtScreen()
        {
            InitializeComponent();
        }

        private void caughtNickname__TextChanged(object sender, EventArgs e)
        {
            UIcaughtNickname = caughtNickname.Texts;
        }

        private void whereCaught__TextChanged(object sender, EventArgs e)
        {

            UIwhereCaught = whereCaught.Texts;
        }

        private void isShinny__TextChanged(object sender, EventArgs e)
        {

            UIisShiny = isShinny.Texts;
        }
        private void whenCaught__TextChanged(object sender, EventArgs e)
        {

            UIwhenCaught = whenCaught.Texts;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveCaught_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.nickname = UIcaughtNickname;
            data.when = UIwhenCaught;
            data.where = UIwhereCaught;
            data.shiny = UIisShiny;
            data.pokemon = scollerSceen.pokemon[scollerSceen.i].Name;
            SqliteDataAccess.SaveUserData(data);
            var userDataTable = SqliteDataAccess.LoadUserData();
        }

        private void caughtPokemonPic_Click(object sender, EventArgs e)
        {
            
        }
        private void caughtScreen_Visble(object sender, EventArgs e)
        {
            caughtPokemonPic.ImageLocation = scollerSceen.imagePath;
        }
    }
}
