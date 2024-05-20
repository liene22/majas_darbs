using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma84
{
    public partial class Form2 : Form
    {
        int sk1, sk2, sk3;
        Random rand = new Random();
        int punkti = 0;
        int reizes;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (reizes < 10)
            {
                punkti = rand.Next(6) + 1;
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
            }else if (punkti > 0 && picKaulins.Left<820)
            {
                timer.Interval = 500;
                picKaulins.Left = picKaulins.Left + 50;
                punkti--;
            }else if(punkti > 0 && picKaulins.Left > 820)
            {
                picKaulins.Left = picKaulins.Left - 50;
                punkti--;
            }
            else if(punkti == 0 && picKaulins.Left > 820)
            {
                labKomentars.Text = "Lieliski pastradāts!";
                timer.Stop();
                picMetamaisKaulins.Visible = false;
                txtAtbilde.Visible = false;
                labPiemers.Visible = false;
                butSakums.Visible = true;
            }
            else
            {
                timer.Stop();
                labKomentars.Text = "";
                txtAtbilde.Text = "";
                txtAtbilde.Enabled = true;
                butParbaude.Visible = true;
                picMetamaisKaulins.Visible = false;
                sk1 = rand.Next(10);
                sk2 = rand.Next(10);
                labPiemers.Text = sk1.ToString() + " x " + sk2.ToString() + " = ";
            }
        }

        private void picMetamaisKaulins_Click(object sender, EventArgs e)
        {
            reizes = 0;
            timer.Interval = 100;
            timer.Start();
        }

        private void butSakums_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

        private void butParbaude_Click(object sender, EventArgs e)
        {
            bool irSk = false;
            irSk = int.TryParse(txtAtbilde.Text, out sk3);
            if (sk1 * sk2 == sk3)
            {
                labKomentars.Text = "Pareizi! Met kauliņu.";
                picMetamaisKaulins.Visible = true;
                butParbaude.Visible = false;
                txtAtbilde.Enabled = false;
            }
            else
            {
                labKomentars.Text = "Nepareizi!";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labKomentars.Text = "";
            txtAtbilde.Text = "";
            picMetamaisKaulins.Visible = false;
            sk1 = rand.Next(10);
            sk2 = rand.Next(10);
            labPiemers.Text = sk1.ToString() + " x " + sk2.ToString() + " = ";
            butSakums.Visible = false;
        }


    }
}
