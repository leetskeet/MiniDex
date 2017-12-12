using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ImageScroll(); //Method
        }

        private bool _StillOpen = true;

        private async void ImageScroll()
        {
            while(_StillOpen) //Loop
            {
                pokeDisplay.Image = Properties.Resources.bulba;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.ivy;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.venu;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.squirtle;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.war;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.blast;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.charman;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.charme;
                await Task.Delay(1000);
                pokeDisplay.Image = Properties.Resources.zard;
                await Task.Delay(1000);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int usrInput;
            usrInput = Convert.ToInt32(userEntry.Text);

            if (usrInput > 0 && usrInput < 10) //If / Else
            {
                _StillOpen = false;
                this.Hide();
                DexEntry dex = new DexEntry(usrInput);   
                dex.ShowDialog();
            }
            else
            {
                this.Hide();
                Error error = new Error();
                error.ShowDialog();
            }
                           
        }
    }
}