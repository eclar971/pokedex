﻿using System;
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
        public static List<Pokemon> pokemon = new List<Pokemon>();
        public static int i = 0;
        public static string imagePath = "";
        public scollerSceen()
        {
            InitializeComponent();
        }

        private void scollerSceen_Load(object sender, EventArgs e)
        {
            pokemonInfo.Text = pokemon[i].ToString();
            imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png";
            pokemonImage.Image = Image.FromFile(imagePath);
        }
        private void scollerSceen_Visable(object sender, EventArgs e)
        {
            pokemon = SqliteDataAccess.LoadPokemon();
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
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Mega"))
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega-{pokemon[i].Name[pokemon[i].Name.Length - 1]} (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Alola"))
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Alola (Custom).png";
            }
            else
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png";
            }
            pokemonImage.ImageLocation = imagePath;
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
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Mega"))
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Mega-{pokemon[i].Name[pokemon[i].Name.Length - 1]} (Custom).png";
            }
            else if (pokemon[i].Name.Contains("Alola"))
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')}-Alola (Custom).png";
            }
            else
            {
                imagePath = $"..\\..\\pokeImg\\{pokemon[i].Num.ToString().PadLeft(3, '0')} (Custom).png";
            }
            pokemonImage.ImageLocation = imagePath;
        }
    }
}
