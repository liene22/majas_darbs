using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma83
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int punkti;
        int reizes;
        public Form1()
        {
            InitializeComponent();
        }

        private void picMetamaisKaulins_Click(object sender, EventArgs e)
        {
            reizes = 0;
            labPunkti.Text = "";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            punkti =rand.Next(6) + 1;
            switch (punkti)
            {
                case 1: picMetamaisKaulins.Image = Properties.Resources.dice1; break;
                case 2: picMetamaisKaulins.Image = Properties.Resources.dice2; break;
                case 3: picMetamaisKaulins.Image = Properties.Resources.dice3; break;
                case 4: picMetamaisKaulins.Image = Properties.Resources.dice4; break;
                case 5: picMetamaisKaulins.Image = Properties.Resources.dice5; break;
                case 6: picMetamaisKaulins.Image = Properties.Resources.dice6; break;
            }
            reizes++;
            if (reizes == 10) 
            {
                timer.Stop();
                labPunkti.Text = "Punkti: " + punkti.ToString();
            }  
        }
    }
}
