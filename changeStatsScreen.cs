using System;
using System.Windows.Forms;

namespace pokedex
{
    public partial class changeStatsScreen : UserControl
    {
        public changeStatsScreen()
        {
            InitializeComponent();
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void changeStatsScreen_Load(object sender, EventArgs e)
        {

        }
        private void changeStatsScreen_Visable(object sender, EventArgs e)
        {
            int total = 0;
            total += scollerSceen.pokemon[scollerSceen.i].HP;
            total += scollerSceen.pokemon[scollerSceen.i].Attack;
            total += scollerSceen.pokemon[scollerSceen.i].Defense;
            total += scollerSceen.pokemon[scollerSceen.i].SpecialAttack;
            total += scollerSceen.pokemon[scollerSceen.i].SpecialDefense;
            total += scollerSceen.pokemon[scollerSceen.i].Speed;
            scollerSceen.pokemon[scollerSceen.i].Total = total;
            changeStatsPic.ImageLocation = scollerSceen.imagePath;
        }
        private void hpStat_Change(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].HP = Convert.ToInt32(hpStat.Texts);
            }
            catch (Exception exc)
            {
                hpStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].HP = 0;
            }
        }

        private void atkStat__TextChanged(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].Attack = Convert.ToInt32(atkStat.Texts);
            }
            catch (Exception exc)
            {
                atkStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].Attack = 0;
            }
        }

        private void defStat__TextChanged(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].Defense = Convert.ToInt32(defStat.Texts);
            }
            catch (Exception exc)
            {
                defStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].Defense = 0;
            }
        }

        private void spAtkStat__TextChanged(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].SpecialAttack = Convert.ToInt32(spAtkStat.Texts);
            }
            catch (Exception exc)
            {
                spAtkStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].SpecialAttack = 0;
            }
        }

        private void spDefStat__TextChanged(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].SpecialDefense = Convert.ToInt32(spDefStat.Texts);
            }
            catch (Exception exc)
            {
                spDefStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].SpecialDefense = 0;
            }
        }

        private void speStat__TextChanged(object sender, EventArgs e)
        {
            try
            {
                scollerSceen.pokemon[scollerSceen.i].Speed = Convert.ToInt32(speStat.Texts);
            }
            catch (Exception exc)
            {
                speStat.Texts = "0";
                scollerSceen.pokemon[scollerSceen.i].Speed = 0;
            }
        }
    }
}
