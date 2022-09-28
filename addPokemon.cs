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
    public partial class addPokemon : UserControl
    {
        string uiName;
        string uiType;
        int uiTotal;
        int uiHP;
        int uiAttack;
        int uiDefense;
        int uiSpecialAttack;
        int uiSpecialDefense;
        int uiSpeed;
        public addPokemon()
        {
            InitializeComponent();
        }

        private void newNameBox__TextChanged(object sender, EventArgs e)
        {
            uiName = newNameBox.Texts;
        }

        private void newTypeBox__TextChanged(object sender, EventArgs e)
        {
            uiType = newTypeBox.Texts;
        }

        private void newAttackBox__TextChanged(object sender, EventArgs e)
        {
            uiAttack = Convert.ToInt32(newAttackBox.Texts);
        }

        private void newSpeedBox__TextChanged(object sender, EventArgs e)
        {
            uiSpeed = Convert.ToInt32(newSpeedBox.Texts);
        }

        private void newSpAttackBox__TextChanged(object sender, EventArgs e)
        {
            uiSpecialAttack = Convert.ToInt32(newSpAttackBox.Texts);
        }

        private void newSpDefBox__TextChanged(object sender, EventArgs e)
        {
            uiSpecialDefense = Convert.ToInt32(newSpDefBox.Texts);
        }

        private void newHpBox__TextChanged(object sender, EventArgs e)
        {
            uiHP = Convert.ToInt32(newHpBox.Texts);
        }

        private void newDefBox__TextChanged(object sender, EventArgs e)
        {
            uiDefense = Convert.ToInt32(newDefBox.Texts);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Pokemon uiPokemon = new Pokemon();
            uiPokemon.Attack = uiAttack;
            uiPokemon.SpecialAttack = uiSpecialAttack;
            uiPokemon.Defense = uiDefense;
            uiPokemon.SpecialDefense = uiSpecialDefense;
            uiPokemon.Speed = uiSpeed;
            uiPokemon.HP = uiHP;
            uiPokemon.Type = uiType;
            uiPokemon.Name = uiName;
            uiPokemon.Total = uiAttack + uiSpecialAttack + uiDefense + uiSpecialDefense + uiSpeed + uiHP;
            uiPokemon.Num = SqliteDataAccess.LoadPokemon()[scollerSceen.pokemon.Count-1].Num + 1;
            SqliteDataAccess.SavePokemon(uiPokemon);

        }
    }
}
