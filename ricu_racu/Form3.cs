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
    public partial class Form3 : Form
    {
        int sk1, sk2, sk3;
        Random rand = new Random();
        int punkti = 0;
        int reizes;
        int gajiens = 1;

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
                labKomentars.Text = "Nepareizi! Izlaid gājienu.";
                reizes = 0;
                pauze.Start();
            }
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
            }
            else if (gajiens==1)
            {
                if (punkti > 0 && picKaulins1.Left < 820)
                {
                    timer.Interval = 500;
                    picKaulins1.Left = picKaulins1.Left + 50;
                    punkti--;
                }
                else if (punkti > 0 && picKaulins1.Left > 820)
                {
                    picKaulins1.Left = picKaulins1.Left - 50;
                    punkti--;
                }
                else if (punkti == 0 && picKaulins1.Left > 820)
                {
                    labKomentars.Text = "He-hē! Uzvar dzeltenais kauliņš.";
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
                    picGajiens.Image = Properties.Resources.kaulins2;
                    gajiens = 2;
                }
            }else if (gajiens == 2)
            {
                if (punkti > 0 && picKaulins2.Left < 820)
                {
                    timer.Interval = 500;
                    picKaulins2.Left = picKaulins2.Left + 50;
                    punkti--;
                }
                else if (punkti > 0 && picKaulins2.Left > 820)
                {
                    picKaulins2.Left = picKaulins2.Left - 50;
                    punkti--;
                }
                else if (punkti == 0 && picKaulins2.Left > 820)
                {
                    labKomentars.Text = "Ju-hū! Zaļie uzvar.";
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
                    picGajiens.Image = Properties.Resources.kaulins1;
                    gajiens = 1;
                }
            }
        }

        private void butSakums_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

        private void picMetamaisKaulins_Click(object sender, EventArgs e)
        {
            reizes = 0;
            timer.Interval = 100;
            timer.Start();
        }

        private void pauze_Tick(object sender, EventArgs e)
        {
            if (reizes < 1)
            {
                reizes++;
            }
            else
            {
                pauze.Stop();
                labKomentars.Text = "";
                txtAtbilde.Text = "";
                txtAtbilde.Enabled = true;
                butParbaude.Visible = true;
                picMetamaisKaulins.Visible = false;
                sk1 = rand.Next(10);
                sk2 = rand.Next(10);
                labPiemers.Text = sk1.ToString() + " x " + sk2.ToString() + " = ";
                if (gajiens == 1)
                {
                    picGajiens.Image = Properties.Resources.kaulins2;
                    gajiens = 2;
                }
                else
                {
                    picGajiens.Image = Properties.Resources.kaulins1;
                    gajiens = 1;
                }
                
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            labKomentars.Text = "";
            txtAtbilde.Text = "";
            picGajiens.Image = Properties.Resources.kaulins1;
            picMetamaisKaulins.Visible = false;
            sk1 = rand.Next(10);
            sk2 = rand.Next(10);
            labPiemers.Text = sk1.ToString() + " x " + sk2.ToString() + " = ";
            butSakums.Visible = false;
        }
    }
}
