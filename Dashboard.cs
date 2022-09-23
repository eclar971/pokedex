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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void caughtScreen1_Load(object sender, EventArgs e)
        {

        }

        private void markCaught_Click(object sender, EventArgs e)
        {
            caughtScreen1.Show();
            seenScreen1.Hide();
            scollerSceen1.Hide();
            statsScreen1.Hide();
            caughtScreen1.BringToFront();
        }

        private void scrollPokemon_Click(object sender, EventArgs e)
        {
            scollerSceen1.Show();
            caughtScreen1.Hide();
            seenScreen1.Hide();
            statsScreen1.Hide();
            scollerSceen1.BringToFront();
        }

        private void markSeen_Click(object sender, EventArgs e)
        {
            seenScreen1.Show();
            caughtScreen1.Hide();
            scollerSceen1.Hide();
            statsScreen1.Hide();
            seenScreen1.BringToFront();
        }

        private void scollerSceen1_Load(object sender, EventArgs e)
        {

        }

        private void veiwStats_Click(object sender, EventArgs e)
        {
            statsScreen1.Show();
            seenScreen1.Hide();
            caughtScreen1.Hide();
            scollerSceen1.Hide();
            statsScreen1.BringToFront();
        }
    }
}
