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
    public partial class statsScreen : UserControl
    {
        public statsScreen()
        {
            InitializeComponent();
        }

        private void statsScreen_Load(object sender, EventArgs e)
        {
        }
        private void statsScreen_Visable(object sender, EventArgs e)
        {
            int total = 0;
            total += scollerSceen.pokemon[scollerSceen.i].HP;
            total += scollerSceen.pokemon[scollerSceen.i].Attack;
            total += scollerSceen.pokemon[scollerSceen.i].Defense;
            total += scollerSceen.pokemon[scollerSceen.i].SpecialAttack;
            total += scollerSceen.pokemon[scollerSceen.i].SpecialDefense;
            total += scollerSceen.pokemon[scollerSceen.i].Speed;
            scollerSceen.pokemon[scollerSceen.i].Total = total;
            statsPic.ImageLocation = scollerSceen.imagePath;
            name.Text = "Name: " + scollerSceen.pokemon[scollerSceen.i].Name;
            number.Text = "Number: " + scollerSceen.pokemon[scollerSceen.i].Num.ToString();
            specialDefense.Text = "Sp. Def: " + scollerSceen.pokemon[scollerSceen.i].SpecialDefense.ToString();
            specialAttack.Text = "Sp. Atk: " + scollerSceen.pokemon[scollerSceen.i].SpecialAttack.ToString();
            attack.Text = "Attack: " + scollerSceen.pokemon[scollerSceen.i].Attack.ToString();
            defense.Text = "Defense: " + scollerSceen.pokemon[scollerSceen.i].Defense.ToString();
            totalStats.Text = "Total: " + scollerSceen.pokemon[scollerSceen.i].Total.ToString();
            type.Text = "Type: " + scollerSceen.pokemon[scollerSceen.i].Type;
            hp.Text = "Hp: " + scollerSceen.pokemon[scollerSceen.i].HP.ToString();
            speed.Text = "Speed: " + scollerSceen.pokemon[scollerSceen.i].Speed.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statsPic_Click(object sender, EventArgs e)
        {

        }
    }
}
