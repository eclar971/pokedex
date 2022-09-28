using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;
using Dapper;

namespace pokedex
{
    public partial class search : Form
    {
        List<string> types = new List<string>() {"normal","fire","water","grass","electric","ice","fighting","poison","ground","flying","psychic","bug","rock","ghost","dark","dragon","steel","fairy"};
        string uiSearch = "";
        int num;
        List<Pokemon> pokemons = scollerSceen.pokemon;
        List<Data> seenCaught = SqliteDataAccess.LoadUserData();
        public search()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchData_Click(object sender, EventArgs e)
        {
            if (pokemons.Where(i => i.Name.ToLower().Contains(uiSearch)).ToList().Count() > 0 && !types.Contains(uiSearch) && !int.TryParse(uiSearch, out num))
            {
                searchVeiw.DataSource = pokemons.Where(i => i.Name.ToLower().Contains(uiSearch)).Select(i => new {i.Name, i.Num}).ToList();
            }
            else if (uiSearch == "caught")
            {
                searchVeiw.DataSource = seenCaught.Where(i => i.nickname != "").Select(i => new {i.pokemon, i.nickname}).ToList();
            }
            else if (uiSearch == "seen")
            {
                searchVeiw.DataSource = seenCaught.Where(i => i.nickname == "").Select(i => new { i.pokemon, i.nickname }).ToList();
            }
            else if (int.TryParse(uiSearch, out num))
            {
                searchVeiw.DataSource = pokemons.Where(i => i.Num == num).Select(i => new { i.Name, i.Num}).ToList();
            }
            else
            {
                searchVeiw.DataSource = pokemons.Where(i => i.Type.ToLower().Contains(uiSearch)).Select(i => new { i.Name, i.Num }).ToList();
            }
        }
        private void searchTextinput__TextChanged(object sender, EventArgs e)
        {
            uiSearch = searchTextinput.Texts.ToLower();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hi = searchVeiw[e.ColumnIndex, e.RowIndex].OwningRow.AccessibilityObject.Value.Split(';')[0];
            scollerSceen.i = pokemons.IndexOf(pokemons.Where(i => i.Name == hi).ToList()[0]);
            this.Close();
        }
    }
}
