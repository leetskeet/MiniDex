﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniDex
{
    public partial class DexEntry : Form
    {
        public int poke { get; set; }
        enum Pokemon
        {
            BULBA = 1, IVY, VENU, CHAR, CHARME, CHARI, SQUI, WAR, BLAST
        }

        public DexEntry()
        {
            InitializeComponent();
            string[] pokeName = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise" };
            
                switch((Pokemon)poke)
                {
                    case Pokemon.BULBA:
                        pokeLabel.Text = pokeName[0];
                        dexPic.Image = Properties.Resources.blast;
                        break;
                    case Pokemon.IVY:
                        pokeLabel.Text = pokeName[1];
                        dexPic.Image = Properties.Resources.ivy;
                        break;
                    case Pokemon.VENU:
                        pokeLabel.Text = pokeName[2];
                        dexPic.Image = Properties.Resources.venu;
                        break;
                    case Pokemon.CHAR:
                        pokeLabel.Text = pokeName[3];
                        dexPic.Image = Properties.Resources.charman;
                        break;
                    case Pokemon.CHARME:
                        pokeLabel.Text = pokeName[4];
                        dexPic.Image = Properties.Resources.charme;
                        break;
                    case Pokemon.CHARI:
                        pokeLabel.Text = pokeName[5];
                        dexPic.Image = Properties.Resources.zard;
                        break;
                    case Pokemon.SQUI:
                        pokeLabel.Text = pokeName[6];
                        dexPic.Image = Properties.Resources.squirtle;
                        break;
                    case Pokemon.WAR:
                        pokeLabel.Text = pokeName[7];
                        dexPic.Image = Properties.Resources.war;
                        break;
                    case Pokemon.BLAST:
                        pokeLabel.Text = pokeName[8];
                        dexPic.Image = Properties.Resources.blast;
                        break;

                }
            

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MiniDex.MainForm();
            main.ShowDialog();
        }
    }
}
