﻿using System;
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
    public partial class scollerSceen : UserControl
    {
        public scollerSceen()
        {
            InitializeComponent();
        }

        private void scollerSceen_Load(object sender, EventArgs e)
        {
            List<Pokemon> pokemon = new List<Pokemon>();
            pokemon = SqliteDataAccess.LoadPokemon();
        }
    }
}
