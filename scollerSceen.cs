using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class scollerSceen : UserControl
    {
        public List<Pokemon> pokemon = new List<Pokemon>();
        int i = 0;
        public scollerSceen()
        {
            InitializeComponent();
        }

        private void scollerSceen_Load(object sender, EventArgs e)
        {
            pokemon = SqliteDataAccess.LoadPokemon();
            pokemonInfo.Text = pokemon[i].ToString();
            pokemonImage.Image = Image.FromFile($"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png");
        }

        private void pokemonInfo_Click(object sender, EventArgs e)
        {

        }

        private void rightScroll_Click(object sender, EventArgs e)
        {
            if (i + 1 > pokemon.Count-1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            pokemonInfo.Text = pokemon[i].ToString();
            bool XYvariant = (pokemon[i].Name[pokemon[i].Name.Length - 1] != 'X' && pokemon[i].Name[pokemon[i].Name.Length - 1] != 'Y');
            if (pokemon[i].Name.Contains("Mega") && XYvariant)
            {
                pokemonImage.ImageLocation = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Mega"))
            {
                pokemonImage.ImageLocation = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega-{pokemon[i].Name[pokemon[i].Name.Length - 1]} (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Alola"))
            {
                pokemonImage.ImageLocation = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Alola (Custom).png";
            }
            else
            {
                pokemonImage.Image = Image.FromFile($"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png");
            }
        }

        private void leftScroll_Click(object sender, EventArgs e)
        {
            if (i - 1 > 0)
            {
                i--;
            }
            else
            {
                i = pokemon.Count-1;
            }
            pokemonInfo.Text = pokemon[i].ToString();
            bool XYvariant = (pokemon[i].Name[pokemon[i].Name.Length - 1] != 'X' && pokemon[i].Name[pokemon[i].Name.Length - 1] != 'Y');
            if (pokemon[i].Name.Contains("Mega") && XYvariant)
            {
                pokemonImage.ImageLocation = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Mega"))
            {
                pokemonImage.ImageLocation = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega-{pokemon[i].Name[pokemon[i].Name.Length - 1]} (Custom).png";
            }
            else
            {
                pokemonImage.Image = Image.FromFile($"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png");
            }
        }
    }
}
