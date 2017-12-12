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
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int usrInput;
            usrInput = Convert.ToInt32(userEntry.Text);

            if (usrInput > 0 && usrInput < 10)
            {
                this.Hide();
                DexEntry dex = new MiniDex.DexEntry(usrInput);   
                dex.ShowDialog();

            }
            else
            {
                this.Hide();
                Error error = new MiniDex.Error();
                error.ShowDialog();
            }
                           
        }
    }
}